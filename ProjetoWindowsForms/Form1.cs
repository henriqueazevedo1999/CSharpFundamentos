using ProjetoWindowsForms.Calculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProcessar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string sobrenome = textBoxSobrenome.Text.Trim();

            if (!validaTamanhoString(nome, 3, "Nome"))
                return;

            if (!validaTamanhoString(sobrenome, 4, "Sobrenome"))
                return;

            string nomeCompleto = $"{nome} {sobrenome}";

            MessageBox.Show($"Nome completo: {nomeCompleto}");
        }

        private bool validaTamanhoString(string valor, int tamanhoMinimo, string nome)
        {
            if (valor.Length < tamanhoMinimo)
            {
                mostraAviso($"{nome} deve conter no mínimo {tamanhoMinimo} caracteres");
                return false;
            }

            return true;
        }

        private void mostraAviso(string texto)
        {
            MessageBox.Show(texto, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            if (!ConvertEx.ToDouble(textBoxNumero1.Text, out double numero1))
            {
                mostraAviso("Número 1 inválido");
                textBoxNumero1.Focus();
                return;
            }

            if (!ConvertEx.ToDouble(textBoxNumero2.Text, out double numero2))
            {
                mostraAviso("Número 2 inválido");
                textBoxNumero2.Focus();
                return;
            }

            double soma = numero1 + numero2;

            MessageBox.Show($"Soma: {soma}");
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!ConvertEx.ToInt(textBoxQtdHoras.Text, out int quantidadeHoras))
            {
                mostraAviso($"Quantidade de horas inválida");
                textBoxQtdHoras.Focus();
                return;
            }

            if (!ConvertEx.ToDouble(textBoxValorHora.Text, out double valorHora))
            {
                mostraAviso($"Valor da hora inválido");
                textBoxValorHora.Focus();
                return;
            }

            double valorCompras = 0.0;
            bool fezCompras = radioButtonFezCompraSim.Checked;

            if (fezCompras && !ConvertEx.ToDouble(textBoxValor.Text, out valorCompras))
            {
                mostraAviso($"Valor das compras inválido");
                textBoxValor.Focus();
                return;
            }

            bool auxilioEducacao = checkBoxAuxEducacao.Checked;

            CalculoFolhaPagamento calculoFP = new()
            { 
                AuxilioEducacao = auxilioEducacao,
                FezCompras = fezCompras,
                ValorCompras = valorCompras,
                ValorHora = valorHora,
                QuantidadeHoras = quantidadeHoras
            };

            StringBuilder sb = new();

            sb.AppendLine($"Salário bruto  : {calculoFP.CalcularSalarioBruto():C2}");
            sb.AppendLine($"Salário líquido: {calculoFP.CalcularSalarioLiquido():C2}");

            preencheResultado(sb.ToString());
        }

        private void preencheResultado(string texto)
        {
            richTextBox.Text = texto;
        }

        private void radioButtonFezCompraSim_CheckedChanged(object sender, EventArgs e)
        {
            labelValor.Visible = radioButtonFezCompraSim.Checked;
            textBoxValor.Visible = radioButtonFezCompraSim.Checked;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxValorHora.Clear();
            textBoxQtdHoras.Clear();
            checkBoxAuxEducacao.Checked = false;
            radioButtonFezComprasNao.Checked = true;
            textBoxValor.Clear();
            richTextBox.Clear();

            textBoxQtdHoras.Focus();
        }
    }
}
