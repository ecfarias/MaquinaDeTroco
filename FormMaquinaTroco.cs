using System.Globalization;

namespace MaquinaDeTroco {

    /// <summary>
    /// Parte-se do princípio que não há a terceira casa decimal
    /// </summary>
    public partial class FormMaquinaTroco : Form {
        private decimal ValorEmCaixa {
            get {
                if (Moedas == null) return 0;
                return Moedas.Sum(x => x.Quantidade * x.Valor);
            }
        }

        private List<Moeda>? Moedas { get; set; }

        public FormMaquinaTroco() {
            InitializeComponent();
            btn001.Text = (0.01m).ToString("C2");
            btn005.Text = (0.05m).ToString("C2");
            btn010.Text = (0.1m).ToString("C2");
            btn025.Text = (0.25m).ToString("C2");
            btn050.Text = (0.5m).ToString("C2");
            btn100.Text = (1m).ToString("C2");

            btn001Sangria.Text = (0.01m).ToString("C2");
            btn005Sangria.Text = (0.05m).ToString("C2");
            btn010Sangria.Text = (0.1m).ToString("C2");
            btn025Sangria.Text = (0.25m).ToString("C2");
            btn050Sangria.Text = (0.5m).ToString("C2");
            btn100Sangria.Text = (1m).ToString("C2");
            // Preload 
            //AbastecerMoeda(0.01m, 100);
            //AbastecerMoeda(0.05m, 100);
            //AbastecerMoeda(0.10m, 100);
            //AbastecerMoeda(0.25m, 100);
            //AbastecerMoeda(0.50m, 100);
            //AbastecerMoeda(1.00m, 100);
            //txtValorTroco.Text = "R$ 7,77";
            //AtualizaSaldo();
            //*********/
        }

        private void btnMoeda_Click(object sender, EventArgs e) {
            if (sender.GetType() == typeof(Button)) {
                switch (((Button)sender).Name) {
                    case "btn001": txtValorMoeda.Text = (0.01m).ToString("C2"); break;
                    case "btn005": txtValorMoeda.Text = (0.05m).ToString("C2"); break;
                    case "btn010": txtValorMoeda.Text = (0.1m).ToString("C2"); break;
                    case "btn025": txtValorMoeda.Text = (0.25m).ToString("C2"); break;
                    case "btn050": txtValorMoeda.Text = (0.5m).ToString("C2"); break;
                    case "btn100": txtValorMoeda.Text = (1m).ToString("C2"); break;
                    default:
                        throw new NotImplementedException("Botão não implementado");
                }
            }
        }

        private void btnMoedaSangria_Click(object sender, EventArgs e) {
            if (sender.GetType() == typeof(Button)) {
                switch (((Button)sender).Name) {
                    case "btn001Sangria": txtValorMoedaSangria.Text = (0.01m).ToString("C2"); break;
                    case "btn005Sangria": txtValorMoedaSangria.Text = (0.05m).ToString("C2"); break;
                    case "btn010Sangria": txtValorMoedaSangria.Text = (0.1m).ToString("C2"); break;
                    case "btn025Sangria": txtValorMoedaSangria.Text = (0.25m).ToString("C2"); break;
                    case "btn050Sangria": txtValorMoedaSangria.Text = (0.5m).ToString("C2"); break;
                    case "btn100Sangria": txtValorMoedaSangria.Text = (1m).ToString("C2"); break;
                    default:
                        throw new NotImplementedException("Botão não implementado");
                }
            }
        }

        private void btnAbastecer_Click(object sender, EventArgs e) {
            if (!validaAbastecer()) return;
            AbastecerMoeda(decimal.Parse(txtValorMoeda.Text, NumberStyles.Currency), int.Parse(txtQtdMoeda.Text));
            txtValorMoeda.Text = "";
            txtQtdMoeda.Text = "";
            AtualizaSaldo();
        }

        private bool validaAbastecer() {
            string msg = "";
            if (txtValorMoeda.Text == string.Empty) msg += "Selecione/Digite um valor de moeda\n";
            else {
                decimal vlDecimal;
                vlDecimal = decimal.Parse(txtValorMoeda.Text, NumberStyles.Currency);
                if (vlDecimal <= 0) msg += "Valor de moeda inválido\n";
            }
            if (txtQtdMoeda.Text == string.Empty) msg += "Campo Quantidade é obrigatório\n";
            else {
                int vlInt;
                vlInt = int.Parse(txtQtdMoeda.Text);
                if (vlInt <= 0) msg += "Quantidade inválida\n";
            }
            if (string.IsNullOrEmpty(msg)) return true;
            MessageBox.Show(msg, "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtValorMoeda.Focus();
            return false;
        }

        private void AbastecerMoeda(decimal valorMoeda, int qtdMoeda) {
            if (Moedas == null) Moedas = new List<Moeda>();
            if (Moedas.Any(x => x.Valor == valorMoeda)) {
                Moedas[Moedas.FindIndex(x => x.Valor == valorMoeda)].Quantidade += qtdMoeda;
            } else {
                Moedas.Add(new Moeda(valorMoeda, qtdMoeda));
            }
        }

        private void AtualizaSaldo() {
            lvlValorEmCaixa.Text = ValorEmCaixa.ToString("C2");
            dataGridView1.DataSource = (from m in Moedas
                                        where m.Quantidade > 0
                                        orderby m.Valor
                                        select new { Valor = m.Valor, Quantidade = m.Quantidade }).ToList();
            Application.DoEvents();
        }

        private void btnSangria_Click(object sender, EventArgs e) {
            if (!validaSangria()) return;
            var sucesso = SangriaMoeda(decimal.Parse(txtValorMoedaSangria.Text, NumberStyles.Currency), int.Parse(txtQtdMoedaSangria.Text));
            if (!sucesso) {
                MessageBox.Show("Não há moedas disponíveis no valor selecionado para executar a sangria.", "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                txtValorMoedaSangria.Text = "";
                txtQtdMoedaSangria.Text = "";
                AtualizaSaldo();
            }
        }

        private bool validaSangria() {
            string msg = "";
            if (txtValorMoedaSangria.Text == string.Empty) msg += "Selecione/Digite um valor de moeda\n";
            else {
                decimal vlDecimal;
                vlDecimal = decimal.Parse(txtValorMoedaSangria.Text, NumberStyles.Currency);
                if (vlDecimal <= 0) msg += "Valor de moeda inválido\n";
            }
            if (txtQtdMoedaSangria.Text == string.Empty) msg += "Campo Quantidade é obrigatório\n";
            else {
                int vlInt;
                vlInt = int.Parse(txtQtdMoedaSangria.Text);
                if (vlInt <= 0) msg += "Quantidade inválida\n";
            }
            if (string.IsNullOrEmpty(msg)) return true;
            MessageBox.Show(msg, "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtValorMoedaSangria.Focus();
            return false;
        }

        private bool SangriaMoeda(decimal valorMoeda, int qtdMoeda) {
            if (Moedas == null) return false;
            if (Moedas.Any(x => x.Valor == valorMoeda)) {
                var indexMoedas = Moedas.FindIndex(x => x.Valor == valorMoeda);
                if (qtdMoeda > Moedas[indexMoedas].Quantidade) return false;
                Moedas[indexMoedas].Quantidade -= qtdMoeda;
                return true;
            }
            return false;
        }

        private void btnTroco_Click(object sender, EventArgs e) {
            if (!validaTroco()) return;
            var troco = CalculaTroco(decimal.Parse(txtValorTroco.Text, NumberStyles.Currency));
            if (troco == null) {
                MessageBox.Show("Não foi possível fornecer troco", "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                string mensagem;
                mensagem = $"Troco composto de:\n";
                foreach (var t in troco) {
                    mensagem += $"{t.Quantidade} moeda(s) de {t.Valor.ToString("C2")}\n";
                }
                MessageBox.Show(mensagem, "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorTroco.Text = "";
                AtualizaSaldo();
            }
        }

        private bool validaTroco() {
            string msg = "";
            if (txtValorTroco.Text == string.Empty) msg += "Campo Valor é obrigatório\n";
            else {
                decimal vlDecimal;
                vlDecimal = decimal.Parse(txtValorTroco.Text, NumberStyles.Currency);
                if (vlDecimal <= 0) msg += "Valor de troco inválido\n";
            }
            if (string.IsNullOrEmpty(msg)) return true;
            MessageBox.Show(msg, "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtValorTroco.Focus();
            return false;
        }

        private List<Moeda>? BuscaSolucaoDaCombinacao(decimal valorTroco, IEnumerable<Moeda> combinacao) {
            if (ValorEmCaixa < valorTroco) return null;
            decimal tempResto = valorTroco;
            List<Moeda> ret = new List<Moeda>();
            foreach (var moeda in combinacao.Where(x => x.Quantidade > 0).OrderByDescending(x => x.Valor)) {
                if (tempResto == 0) break;
                if (tempResto < moeda.Valor) continue;
                int qtd = (int)(tempResto / moeda.Valor);
                ret.Add(new Moeda(moeda.Valor, qtd));
                tempResto -= qtd * moeda.Valor;
            }
            if (tempResto == 0) return ret; //Deu Certo
            return null;
        }

        private List<Moeda>? CalculaTroco(decimal valorTroco) {
            if (Moedas == null) return null;
            //Primeiro Calcula todas as combinações possíveis de moedas
            var Solucoes = new List<List<Moeda>>();
            var combinacoes = getCombinacoes(Moedas.Where(x => x.Quantidade > 0)).ToList();
            //Dentre as combinações, quais resolvem o troco?
            foreach (var combinacao in combinacoes) {
                var solucao = BuscaSolucaoDaCombinacao(valorTroco, combinacao);
                if (solucao == null) continue;
                Solucoes.Add(solucao.ToList());
            }
            //Das soluções, qual delas usam menos moedas
            int i = int.MaxValue;
            int index = -1;
            foreach (var solucao in Solucoes) {
                int j = solucao.Sum(x => x.Quantidade);
                if (j < i) {
                    i = j;
                    index = Solucoes.IndexOf(solucao);
                }
            }
            if (index == -1) return null;

            //Atualizar Moedas no Caixa
            foreach (var item in Solucoes[index]) {
                var indexMoedas = Moedas.FindIndex(x => x.Valor == item.Valor);
                Moedas[indexMoedas].Quantidade -= item.Quantidade;
            }

            return Solucoes[index];
        }

        private IEnumerable<T[]> getCombinacoes<T>(IEnumerable<T> source) {
            if (null == source)
                throw new ArgumentNullException(nameof(source));
            T[] data = source.ToArray();

            return Enumerable
              .Range(0, 1 << (data.Length))
              .Select(index => data
                 .Where((v, i) => (index & (1 << i)) != 0)
                 .ToArray());
        }

        private void CurrencyValidating(object sender, System.ComponentModel.CancelEventArgs e) {
            TextBox box = (TextBox)sender;
            if (box.Text == "") return;
            decimal result;
            e.Cancel = !decimal.TryParse(box.Text, NumberStyles.Currency, null, out result);
            box.Text = result.ToString("C2");
            box.SelectAll();
        }

        private void IntValidating(object sender, System.ComponentModel.CancelEventArgs e) {
            TextBox box = (TextBox)sender;
            if (box.Text == "") return;
            e.Cancel = !int.TryParse(box.Text, out _);
            box.SelectAll();
        }

        private void TextBoxFocusEnter(object sender, EventArgs e) {
            TextBox box = ((TextBox)sender);
            switch (box.Name) {
                case "txtQtdMoeda":
                case "txtValorMoeda":
                    AcceptButton = btnAbastecer;
                    break;
                case "txtQtdMoedaSangria":
                case "txtValorMoedaSangria":
                    AcceptButton = btnSangria;
                    break;
                case "txtValorTroco":
                    AcceptButton = btnTroco;
                    break;
                default: throw new NotImplementedException($"TextBox: {box.Name}");
            }
        }
    }
}