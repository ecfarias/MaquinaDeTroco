namespace MaquinaDeTroco {
    partial class FormMaquinaTroco {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.lvlValorEmCaixa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorMoeda = new System.Windows.Forms.TextBox();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.txtQtdMoeda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn050 = new System.Windows.Forms.Button();
            this.btn025 = new System.Windows.Forms.Button();
            this.btn010 = new System.Windows.Forms.Button();
            this.btn005 = new System.Windows.Forms.Button();
            this.btn001 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorMoedaSangria = new System.Windows.Forms.TextBox();
            this.btnSangria = new System.Windows.Forms.Button();
            this.txtQtdMoedaSangria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn100Sangria = new System.Windows.Forms.Button();
            this.btn050Sangria = new System.Windows.Forms.Button();
            this.btn025Sangria = new System.Windows.Forms.Button();
            this.btn010Sangria = new System.Windows.Forms.Button();
            this.btn005Sangria = new System.Windows.Forms.Button();
            this.btn001Sangria = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValorTroco = new System.Windows.Forms.TextBox();
            this.btnTroco = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em Caixa:";
            // 
            // lvlValorEmCaixa
            // 
            this.lvlValorEmCaixa.AutoSize = true;
            this.lvlValorEmCaixa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlValorEmCaixa.Location = new System.Drawing.Point(197, 75);
            this.lvlValorEmCaixa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lvlValorEmCaixa.Name = "lvlValorEmCaixa";
            this.lvlValorEmCaixa.Size = new System.Drawing.Size(155, 51);
            this.lvlValorEmCaixa.TabIndex = 1;
            this.lvlValorEmCaixa.Text = "R$ 0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorMoeda);
            this.groupBox1.Controls.Add(this.btnAbastecer);
            this.groupBox1.Controls.Add(this.txtQtdMoeda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn100);
            this.groupBox1.Controls.Add(this.btn050);
            this.groupBox1.Controls.Add(this.btn025);
            this.groupBox1.Controls.Add(this.btn010);
            this.groupBox1.Controls.Add(this.btn005);
            this.groupBox1.Controls.Add(this.btn001);
            this.groupBox1.Location = new System.Drawing.Point(22, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(923, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abastecimento";
            // 
            // txtValorMoeda
            // 
            this.txtValorMoeda.Location = new System.Drawing.Point(186, 109);
            this.txtValorMoeda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValorMoeda.Name = "txtValorMoeda";
            this.txtValorMoeda.Size = new System.Drawing.Size(182, 39);
            this.txtValorMoeda.TabIndex = 6;
            this.txtValorMoeda.Enter += new System.EventHandler(this.TextBoxFocusEnter);
            this.txtValorMoeda.Validating += new System.ComponentModel.CancelEventHandler(this.CurrencyValidating);
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Location = new System.Drawing.Point(383, 109);
            this.btnAbastecer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(173, 111);
            this.btnAbastecer.TabIndex = 8;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = true;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // txtQtdMoeda
            // 
            this.txtQtdMoeda.Location = new System.Drawing.Point(186, 171);
            this.txtQtdMoeda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQtdMoeda.Name = "txtQtdMoeda";
            this.txtQtdMoeda.Size = new System.Drawing.Size(182, 39);
            this.txtQtdMoeda.TabIndex = 7;
            this.txtQtdMoeda.Enter += new System.EventHandler(this.TextBoxFocusEnter);
            this.txtQtdMoeda.Validating += new System.ComponentModel.CancelEventHandler(this.IntValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor da Moeda:";
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(763, 47);
            this.btn100.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(139, 49);
            this.btn100.TabIndex = 5;
            this.btn100.Text = "R$ 1,00";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btn050
            // 
            this.btn050.Location = new System.Drawing.Point(613, 47);
            this.btn050.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn050.Name = "btn050";
            this.btn050.Size = new System.Drawing.Size(139, 49);
            this.btn050.TabIndex = 4;
            this.btn050.Text = "R$ 0,50";
            this.btn050.UseVisualStyleBackColor = true;
            this.btn050.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btn025
            // 
            this.btn025.Location = new System.Drawing.Point(462, 47);
            this.btn025.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn025.Name = "btn025";
            this.btn025.Size = new System.Drawing.Size(139, 49);
            this.btn025.TabIndex = 3;
            this.btn025.Text = "R$ 0,25";
            this.btn025.UseVisualStyleBackColor = true;
            this.btn025.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btn010
            // 
            this.btn010.Location = new System.Drawing.Point(312, 47);
            this.btn010.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn010.Name = "btn010";
            this.btn010.Size = new System.Drawing.Size(139, 49);
            this.btn010.TabIndex = 2;
            this.btn010.Text = "R$ 0,10";
            this.btn010.UseVisualStyleBackColor = true;
            this.btn010.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btn005
            // 
            this.btn005.Location = new System.Drawing.Point(162, 47);
            this.btn005.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn005.Name = "btn005";
            this.btn005.Size = new System.Drawing.Size(139, 49);
            this.btn005.TabIndex = 1;
            this.btn005.Text = "R$ 0,05";
            this.btn005.UseVisualStyleBackColor = true;
            this.btn005.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // btn001
            // 
            this.btn001.Location = new System.Drawing.Point(11, 47);
            this.btn001.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn001.Name = "btn001";
            this.btn001.Size = new System.Drawing.Size(139, 49);
            this.btn001.TabIndex = 0;
            this.btn001.Text = "R$ 0,01";
            this.btn001.UseVisualStyleBackColor = true;
            this.btn001.Click += new System.EventHandler(this.btnMoeda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValorMoedaSangria);
            this.groupBox2.Controls.Add(this.btnSangria);
            this.groupBox2.Controls.Add(this.txtQtdMoedaSangria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn100Sangria);
            this.groupBox2.Controls.Add(this.btn050Sangria);
            this.groupBox2.Controls.Add(this.btn025Sangria);
            this.groupBox2.Controls.Add(this.btn010Sangria);
            this.groupBox2.Controls.Add(this.btn005Sangria);
            this.groupBox2.Controls.Add(this.btn001Sangria);
            this.groupBox2.Location = new System.Drawing.Point(22, 405);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(923, 258);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sangria";
            // 
            // txtValorMoedaSangria
            // 
            this.txtValorMoedaSangria.Location = new System.Drawing.Point(186, 109);
            this.txtValorMoedaSangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValorMoedaSangria.Name = "txtValorMoedaSangria";
            this.txtValorMoedaSangria.Size = new System.Drawing.Size(182, 39);
            this.txtValorMoedaSangria.TabIndex = 6;
            this.txtValorMoedaSangria.Enter += new System.EventHandler(this.TextBoxFocusEnter);
            this.txtValorMoedaSangria.Validating += new System.ComponentModel.CancelEventHandler(this.CurrencyValidating);
            // 
            // btnSangria
            // 
            this.btnSangria.Location = new System.Drawing.Point(383, 109);
            this.btnSangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(173, 111);
            this.btnSangria.TabIndex = 8;
            this.btnSangria.Text = "Sangria";
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // txtQtdMoedaSangria
            // 
            this.txtQtdMoedaSangria.Location = new System.Drawing.Point(186, 171);
            this.txtQtdMoedaSangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQtdMoedaSangria.Name = "txtQtdMoedaSangria";
            this.txtQtdMoedaSangria.Size = new System.Drawing.Size(182, 39);
            this.txtQtdMoedaSangria.TabIndex = 7;
            this.txtQtdMoedaSangria.Enter += new System.EventHandler(this.TextBoxFocusEnter);
            this.txtQtdMoedaSangria.Validating += new System.ComponentModel.CancelEventHandler(this.IntValidating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor da Moeda:";
            // 
            // btn100Sangria
            // 
            this.btn100Sangria.Location = new System.Drawing.Point(763, 47);
            this.btn100Sangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn100Sangria.Name = "btn100Sangria";
            this.btn100Sangria.Size = new System.Drawing.Size(139, 49);
            this.btn100Sangria.TabIndex = 5;
            this.btn100Sangria.Text = "R$ 1,00";
            this.btn100Sangria.UseVisualStyleBackColor = true;
            this.btn100Sangria.Click += new System.EventHandler(this.btnMoedaSangria_Click);
            // 
            // btn050Sangria
            // 
            this.btn050Sangria.Location = new System.Drawing.Point(613, 47);
            this.btn050Sangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn050Sangria.Name = "btn050Sangria";
            this.btn050Sangria.Size = new System.Drawing.Size(139, 49);
            this.btn050Sangria.TabIndex = 4;
            this.btn050Sangria.Text = "R$ 0,50";
            this.btn050Sangria.UseVisualStyleBackColor = true;
            this.btn050Sangria.Click += new System.EventHandler(this.btnMoedaSangria_Click);
            // 
            // btn025Sangria
            // 
            this.btn025Sangria.Location = new System.Drawing.Point(462, 47);
            this.btn025Sangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn025Sangria.Name = "btn025Sangria";
            this.btn025Sangria.Size = new System.Drawing.Size(139, 49);
            this.btn025Sangria.TabIndex = 3;
            this.btn025Sangria.Text = "R$ 0,25";
            this.btn025Sangria.UseVisualStyleBackColor = true;
            this.btn025Sangria.Click += new System.EventHandler(this.btnMoedaSangria_Click);
            // 
            // btn010Sangria
            // 
            this.btn010Sangria.Location = new System.Drawing.Point(312, 47);
            this.btn010Sangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn010Sangria.Name = "btn010Sangria";
            this.btn010Sangria.Size = new System.Drawing.Size(139, 49);
            this.btn010Sangria.TabIndex = 2;
            this.btn010Sangria.Text = "R$ 0,10";
            this.btn010Sangria.UseVisualStyleBackColor = true;
            this.btn010Sangria.Click += new System.EventHandler(this.btnMoedaSangria_Click);
            // 
            // btn005Sangria
            // 
            this.btn005Sangria.Location = new System.Drawing.Point(162, 47);
            this.btn005Sangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn005Sangria.Name = "btn005Sangria";
            this.btn005Sangria.Size = new System.Drawing.Size(139, 49);
            this.btn005Sangria.TabIndex = 1;
            this.btn005Sangria.Text = "R$ 0,05";
            this.btn005Sangria.UseVisualStyleBackColor = true;
            this.btn005Sangria.Click += new System.EventHandler(this.btnMoedaSangria_Click);
            // 
            // btn001Sangria
            // 
            this.btn001Sangria.Location = new System.Drawing.Point(11, 47);
            this.btn001Sangria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn001Sangria.Name = "btn001Sangria";
            this.btn001Sangria.Size = new System.Drawing.Size(139, 49);
            this.btn001Sangria.TabIndex = 0;
            this.btn001Sangria.Text = "R$ 0,01";
            this.btn001Sangria.UseVisualStyleBackColor = true;
            this.btn001Sangria.Click += new System.EventHandler(this.btnMoedaSangria_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValorTroco);
            this.groupBox3.Controls.Add(this.btnTroco);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(22, 676);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(923, 258);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Troco";
            // 
            // txtValorTroco
            // 
            this.txtValorTroco.Location = new System.Drawing.Point(186, 47);
            this.txtValorTroco.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValorTroco.Name = "txtValorTroco";
            this.txtValorTroco.Size = new System.Drawing.Size(182, 39);
            this.txtValorTroco.TabIndex = 1;
            this.txtValorTroco.Enter += new System.EventHandler(this.TextBoxFocusEnter);
            this.txtValorTroco.Validating += new System.ComponentModel.CancelEventHandler(this.CurrencyValidating);
            // 
            // btnTroco
            // 
            this.btnTroco.Location = new System.Drawing.Point(383, 109);
            this.btnTroco.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(173, 111);
            this.btnTroco.TabIndex = 2;
            this.btnTroco.Text = "Troco";
            this.btnTroco.UseVisualStyleBackColor = true;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Valor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colValor,
            this.colQuantidade});
            this.dataGridView1.Location = new System.Drawing.Point(956, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(507, 800);
            this.dataGridView1.TabIndex = 13;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "Valor";
            this.colValor.HeaderText = "Valor";
            this.colValor.MinimumWidth = 10;
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 200;
            // 
            // colQuantidade
            // 
            this.colQuantidade.DataPropertyName = "Quantidade";
            this.colQuantidade.HeaderText = "Qt";
            this.colQuantidade.MinimumWidth = 10;
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 200;
            // 
            // FormMaquinaTroco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvlValorEmCaixa);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMaquinaTroco";
            this.Text = "Máquina de Troco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lvlValorEmCaixa;
        private GroupBox groupBox1;
        private Button btnAbastecer;
        private TextBox txtQtdMoeda;
        private Label label4;
        private Label label3;
        private Button btn100;
        private Button btn050;
        private Button btn025;
        private Button btn010;
        private Button btn005;
        private Button btn001;
        private TextBox txtValorMoeda;
        private GroupBox groupBox2;
        private TextBox txtValorMoedaSangria;
        private Button btnSangria;
        private TextBox txtQtdMoedaSangria;
        private Label label2;
        private Label label5;
        private Button btn100Sangria;
        private Button btn050Sangria;
        private Button btn025Sangria;
        private Button btn010Sangria;
        private Button btn005Sangria;
        private Button btn001Sangria;
        private GroupBox groupBox3;
        private TextBox txtValorTroco;
        private Button btnTroco;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colQuantidade;
    }
}