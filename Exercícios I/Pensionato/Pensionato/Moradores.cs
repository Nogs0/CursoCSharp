using System;
using System.Collections.Generic;
using System.Text;

namespace Pensionato
{
    class Moradores
    {
        private int _quarto;
        public double Aluguel { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Moradores(string nome, string email, int room)
        {
            Nome = nome;
            Email = email;
            _quarto = room;
        }

        public Moradores(string nome, string email, int room, double aluguel) : this(nome, email, room)
        {
            Aluguel = aluguel;
        }

        public int Quarto
        {
            get { return _quarto;  }
            set
            {
                if(value >= 1 && value <= 10)
                {
                    _quarto = value;
                }
            }
        }

    }
}
