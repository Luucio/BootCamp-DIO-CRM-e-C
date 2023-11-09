using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp_C_CRM.Models
{
    public class Pessoa
    {
        ///atalho "Prop" para definir atributos.
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {   
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
///Utilizar o "@" antes de uma palavra reservada permite que você a utilize para nomear atributos e etc (Ex: Apresentar ( String @class))