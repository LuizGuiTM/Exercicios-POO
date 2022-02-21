using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
3.	Crie uma classe para representar um funcionário. A classe deve ter os seguintes atributos:

Código (int) : deve ser > 0
Nome  (string)  : (obrigatório)
RG  (string)  : (obrigatório)
Salario  (double)  : deve ser >=0


Encapsule os atributos com métodos Get/Set.

Crie também os seguintes métodos:

GetInss():  deve calcular o valor do INSS (11% do salário) e devolver este valor.

CalcularSalario() : Este método deverá retornar o salário do funcionário subtraído do INSS.

Crie um formulário para preencher os campos do cadastro.
Crie um botão para exibir os valores gravados na classe em um Textbox multiline.
*/

namespace Exercicio3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void butCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            try
            {
                f.setNome(tbName.Text);
                f.setRG(tbRG.Text);
                f.setSalario(Convert.ToDouble(npSalario.Value));
                f.setCodigo(Convert.ToInt32(npCode.Value));
                double valor = f.GetInss();
                double salarioLiquido = f.CalcularSalario();
            }
            catch(Exception erro) 
            {
                    MessageBox.Show(erro.Message);
            }
            txtResult.Text += "Code " + Convert.ToString(f.GetCodigo()) + "\n";
            txtResult.Text += "Nome "+ Convert.ToString(f.GetNome()) + "\n";
            txtResult.Text += "RG " +Convert.ToString(f.GetRG()) + "\n";
            txtResult.Text += "Salario " + Convert.ToString(f.GetSalario()) + "\n";
            txtResult.Text += "INSS " + Convert.ToString(f.GetInss()) + "\n";
            txtResult.Text += "Salário Liquido " + Convert.ToString(f.CalcularSalario()) + "\n";

        }
    }
}
