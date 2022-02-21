using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Funcionario
    {
        private int Codigo;
        private string Nome;
        private string RG;
        private double Salario;

        public double GetInss() 
        {
            return (Salario * 11) / 100;
        }
        
        public double CalcularSalario() 
        {
            return Salario - GetInss();
        }


        public void setCodigo(int codigo)
        {
            if (codigo > 0)
            {
                Codigo = codigo;
            }
            else
            {
                throw new Exception("Codigo deve ser maior que 0.");
            }
        }

        public void setNome(string nome)
        {
            if (nome.Trim().Length == 0)
                throw new Exception("Nome Obrigatório");
            else
                Nome = nome;
        }

        public void setRG(string rg)
        {

            if (rg.Trim().Length == 0)
                throw new Exception("RG Obrigatório");
            else
                RG = rg;
        }

        public void setSalario(Double salario)
        {
            if (salario < 0)
            {
                throw new Exception("Salario precisa ser maior que 0");
            }

            Salario = salario;
        }
        public string GetNome()
        {
            return Nome;
        }
        public int GetCodigo()
        {
            return Codigo;
        }
        public string GetRG()
        {
            return RG;
        }
        public Double GetSalario()
        {
            return Salario;
        }

    }
}
