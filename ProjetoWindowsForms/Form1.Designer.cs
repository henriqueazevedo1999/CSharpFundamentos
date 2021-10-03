
namespace ProjetoWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonProcessar = new System.Windows.Forms.Button();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelQuantidadeHoras = new System.Windows.Forms.Label();
            this.labelValorHora = new System.Windows.Forms.Label();
            this.checkBoxAuxEducacao = new System.Windows.Forms.CheckBox();
            this.radioButtonFezCompraSim = new System.Windows.Forms.RadioButton();
            this.radioButtonFezComprasNao = new System.Windows.Forms.RadioButton();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxQtdHoras = new System.Windows.Forms.TextBox();
            this.textBoxValorHora = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBoxFezCompras = new System.Windows.Forms.GroupBox();
            this.groupBoxFezCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(110, 6);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(240, 27);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(110, 39);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(240, 27);
            this.textBoxSobrenome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonProcessar
            // 
            this.buttonProcessar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonProcessar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProcessar.Location = new System.Drawing.Point(135, 72);
            this.buttonProcessar.Name = "buttonProcessar";
            this.buttonProcessar.Size = new System.Drawing.Size(198, 64);
            this.buttonProcessar.TabIndex = 4;
            this.buttonProcessar.Text = "Processar";
            this.buttonProcessar.UseVisualStyleBackColor = false;
            this.buttonProcessar.Click += new System.EventHandler(this.buttonProcessar_Click);
            // 
            // buttonSomar
            // 
            this.buttonSomar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSomar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSomar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSomar.Location = new System.Drawing.Point(135, 230);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(198, 64);
            this.buttonSomar.TabIndex = 9;
            this.buttonSomar.Text = "Somar";
            this.buttonSomar.UseVisualStyleBackColor = false;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(110, 197);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(240, 27);
            this.textBoxNumero2.TabIndex = 8;
            // 
            // labelNumero2
            // 
            this.labelNumero2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Location = new System.Drawing.Point(26, 204);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(78, 20);
            this.labelNumero2.TabIndex = 7;
            this.labelNumero2.Text = "Número 2:";
            this.labelNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(110, 164);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(240, 27);
            this.textBoxNumero1.TabIndex = 6;
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Location = new System.Drawing.Point(26, 171);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(78, 20);
            this.labelNumero1.TabIndex = 5;
            this.labelNumero1.Text = "Número 1:";
            this.labelNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQuantidadeHoras
            // 
            this.labelQuantidadeHoras.AutoSize = true;
            this.labelQuantidadeHoras.Location = new System.Drawing.Point(393, 20);
            this.labelQuantidadeHoras.Name = "labelQuantidadeHoras";
            this.labelQuantidadeHoras.Size = new System.Drawing.Size(148, 20);
            this.labelQuantidadeHoras.TabIndex = 10;
            this.labelQuantidadeHoras.Text = "Quantidade de horas";
            this.labelQuantidadeHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelValorHora
            // 
            this.labelValorHora.AutoSize = true;
            this.labelValorHora.Location = new System.Drawing.Point(464, 61);
            this.labelValorHora.Name = "labelValorHora";
            this.labelValorHora.Size = new System.Drawing.Size(77, 20);
            this.labelValorHora.TabIndex = 11;
            this.labelValorHora.Text = "Valor hora";
            this.labelValorHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxAuxEducacao
            // 
            this.checkBoxAuxEducacao.AutoSize = true;
            this.checkBoxAuxEducacao.Location = new System.Drawing.Point(547, 99);
            this.checkBoxAuxEducacao.Name = "checkBoxAuxEducacao";
            this.checkBoxAuxEducacao.Size = new System.Drawing.Size(145, 24);
            this.checkBoxAuxEducacao.TabIndex = 12;
            this.checkBoxAuxEducacao.Text = "Auxílio educação";
            this.checkBoxAuxEducacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonFezCompraSim
            // 
            this.radioButtonFezCompraSim.AutoSize = true;
            this.radioButtonFezCompraSim.Location = new System.Drawing.Point(19, 26);
            this.radioButtonFezCompraSim.Name = "radioButtonFezCompraSim";
            this.radioButtonFezCompraSim.Size = new System.Drawing.Size(55, 24);
            this.radioButtonFezCompraSim.TabIndex = 13;
            this.radioButtonFezCompraSim.Text = "Sim";
            this.radioButtonFezCompraSim.UseVisualStyleBackColor = true;
            this.radioButtonFezCompraSim.CheckedChanged += new System.EventHandler(this.radioButtonFezCompraSim_CheckedChanged);
            // 
            // radioButtonFezComprasNao
            // 
            this.radioButtonFezComprasNao.AutoSize = true;
            this.radioButtonFezComprasNao.Checked = true;
            this.radioButtonFezComprasNao.Location = new System.Drawing.Point(19, 48);
            this.radioButtonFezComprasNao.Name = "radioButtonFezComprasNao";
            this.radioButtonFezComprasNao.Size = new System.Drawing.Size(58, 24);
            this.radioButtonFezComprasNao.TabIndex = 14;
            this.radioButtonFezComprasNao.TabStop = true;
            this.radioButtonFezComprasNao.Text = "Não";
            this.radioButtonFezComprasNao.UseVisualStyleBackColor = true;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(577, 181);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(43, 20);
            this.labelValor.TabIndex = 15;
            this.labelValor.Text = "Valor";
            this.labelValor.Visible = false;
            // 
            // textBoxQtdHoras
            // 
            this.textBoxQtdHoras.Location = new System.Drawing.Point(547, 13);
            this.textBoxQtdHoras.Name = "textBoxQtdHoras";
            this.textBoxQtdHoras.Size = new System.Drawing.Size(125, 27);
            this.textBoxQtdHoras.TabIndex = 16;
            // 
            // textBoxValorHora
            // 
            this.textBoxValorHora.Location = new System.Drawing.Point(547, 54);
            this.textBoxValorHora.Name = "textBoxValorHora";
            this.textBoxValorHora.Size = new System.Drawing.Size(125, 27);
            this.textBoxValorHora.TabIndex = 16;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(633, 180);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(125, 27);
            this.textBoxValor.TabIndex = 16;
            this.textBoxValor.Visible = false;
            // 
            // richTextBox
            // 
            this.richTextBox.Enabled = false;
            this.richTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(393, 290);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(365, 129);
            this.richTextBox.TabIndex = 17;
            this.richTextBox.Text = "";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(393, 258);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(75, 20);
            this.labelResultado.TabIndex = 11;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(664, 231);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(94, 29);
            this.buttonCalcular.TabIndex = 18;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(564, 230);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(94, 29);
            this.buttonLimpar.TabIndex = 18;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // groupBoxFezCompras
            // 
            this.groupBoxFezCompras.Controls.Add(this.radioButtonFezCompraSim);
            this.groupBoxFezCompras.Controls.Add(this.radioButtonFezComprasNao);
            this.groupBoxFezCompras.Location = new System.Drawing.Point(393, 129);
            this.groupBoxFezCompras.Name = "groupBoxFezCompras";
            this.groupBoxFezCompras.Size = new System.Drawing.Size(165, 78);
            this.groupBoxFezCompras.TabIndex = 19;
            this.groupBoxFezCompras.TabStop = false;
            this.groupBoxFezCompras.Text = "Fez compras";
            this.groupBoxFezCompras.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFezCompras);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxValorHora);
            this.Controls.Add(this.textBoxQtdHoras);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.checkBoxAuxEducacao);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelValorHora);
            this.Controls.Add(this.labelQuantidadeHoras);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.buttonProcessar);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxFezCompras.ResumeLayout(false);
            this.groupBoxFezCompras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonProcessar;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelQuantidadeHoras;
        private System.Windows.Forms.Label labelValorHora;
        private System.Windows.Forms.CheckBox checkBoxAuxEducacao;
        private System.Windows.Forms.RadioButton radioButtonFezCompraSim;
        private System.Windows.Forms.RadioButton radioButtonFezComprasNao;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxQtdHoras;
        private System.Windows.Forms.TextBox textBoxValorHora;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.GroupBox groupBoxFezCompras;
    }
}

