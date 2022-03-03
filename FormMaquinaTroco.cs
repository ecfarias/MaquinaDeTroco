using System.Globalization;

namespace MaquinaDeTroco {

    /// <summary>
    /// Parte-se do princípio que não há a terceira casa decimal
    /// Problema conhecido: Se eu tiver no caixa 3 moedas de 10 centavos e uma de 25 e pedir troco pra 30 ele não consegue chegar no resultado
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
            AbastecerMoeda(0.01m, 100);
            AbastecerMoeda(0.05m, 100);
            AbastecerMoeda(0.10m, 100);
            AbastecerMoeda(0.25m, 100);
            AbastecerMoeda(0.50m, 100);
            AbastecerMoeda(1.00m, 100);
            AtualizaSaldo();
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
            if (txtQtdMoeda.Text == string.Empty) msg += "Campo Quantidade é obrigatório\n";
            decimal vlDecimal;
            vlDecimal = decimal.Parse(txtValorMoeda.Text, NumberStyles.Currency);
            if (vlDecimal <= 0) msg += "Valor de moeda inválido\n";
            int vlInt;
            vlInt = int.Parse(txtQtdMoeda.Text);
            if (vlInt <= 0) msg += "Quantidade inválida\n";
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
            if (txtQtdMoedaSangria.Text == string.Empty) msg += "Campo Quantidade é obrigatório\n";
            decimal vlDecimal;
            vlDecimal = decimal.Parse(txtValorMoedaSangria.Text, NumberStyles.Currency);
            if (vlDecimal <= 0) msg += "Valor de moeda inválido\n";
            int vlInt;
            vlInt = int.Parse(txtQtdMoedaSangria.Text);
            if (vlInt <= 0) msg += "Quantidade inválida\n";
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
            var troco = Troco(decimal.Parse(txtValorTroco.Text, NumberStyles.Currency));
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
            decimal vlDecimal;
            vlDecimal = decimal.Parse(txtValorTroco.Text, NumberStyles.Currency);
            if (vlDecimal <= 0) msg += "Valor de troco inválido\n";
            if (string.IsNullOrEmpty(msg)) return true;
            MessageBox.Show(msg, "Máquina de Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtValorTroco.Focus();
            return false;
        }

        private List<Moeda>? Troco(decimal valorTroco) {
            if (Moedas == null) return null;
            if (ValorEmCaixa < valorTroco) return null;
            decimal tempResto = valorTroco;
            List<Moeda> ret = new List<Moeda>();
            foreach (var moeda in Moedas.Where(x => x.Quantidade > 0).OrderByDescending(x => x.Valor)) {
                if (tempResto == 0) break;
                if (tempResto < moeda.Valor) continue;
                int qtd = (int)(tempResto / moeda.Valor);
                ret.Add(new Moeda(moeda.Valor, qtd));
                tempResto -= qtd * moeda.Valor;
            }
            if (tempResto == 0) { //Deu certo, descontar de Moedas
                foreach (var item in ret) {
                    var indexMoedas = Moedas.FindIndex(x => x.Valor == item.Valor);
                    Moedas[indexMoedas].Quantidade -= item.Quantidade;
                }
                return ret;
            } 
            return null;
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
            e.Cancel= !int.TryParse(box.Text, out _);
            box.SelectAll();
        }
    }
}