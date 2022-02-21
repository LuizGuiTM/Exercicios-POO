using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
     class Jogo
    {
        private int Codigo;
        private string Nome;
        private string Categoria;
        private DateTime DataLancamento;
        private string[] categoriasValidas = new string[4] {"ação", "luta", "esportes", "tiro"};

        public void setCodigo(int codigo1, int n)
        {
            if (codigo1 > 0)
            {
                Codigo = codigo1;
            }
            else 
            {
                throw new Exception("Codigo deve ser maior que 0.");
            }
        }

        public void setNome(string nome, int n) 
        {
            if (nome.Trim().Length == 0)
                throw new Exception("Nome Obrigatório");
            else 
                Nome = nome;
        }

        public void setCategoria(string categoria, int n) 
        {
            
            foreach (string cat in categoriasValidas) 
            {
                if (cat == categoria.Trim().ToLower()) 
                {
                    Categoria = cat;
                    break;
                    
                }
                
            }
            if(Categoria == null)
                throw new Exception("Categoria Invalida");
        }

        public void setData(DateTime data, int n) 
        {
            if (data > DateTime.Now) 
            {
                throw new Exception("Data não pode ser superior a data atual");
            }

            DataLancamento = data;
        }
        public string GetNome()
        {
            return Nome;
        }
        public int GetCodigo()
        {
            return Codigo;
        }
        public string GetCategoria()
        {
            return Categoria;
        }
        public DateTime GetData()
        {
            return DataLancamento;
        }


       


     

        

    }
}

