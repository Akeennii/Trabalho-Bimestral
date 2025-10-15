using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElemento.Models
{
    public class Animal
    {
        private string nome;
        private string idade;
        public required string Nome { get => nome; set => nome = value; }
        public required string Idade { get => idade; set => idade = value; }

        public string Salva(Animal animal)
        {
            if (string.IsNullOrEmpty(animal.Nome) ||
                string.IsNullOrEmpty(animal.Idade))
            {
                return "Um dos campos obrigatórios não foi preenchido";
            }
            else
            {
                return "Salvo com sucesso";
            }
        }
    }
}