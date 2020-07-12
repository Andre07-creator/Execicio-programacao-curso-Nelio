using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace programa_Vetores_2.Entites
{
    class Jogos
    {
        public string NomeJ { get; set; }
        public double PrecoJ { get; set; }

        public Jogos()
        {
        }

        public Jogos(string nomeJ, double precoJ)
        {
            NomeJ = nomeJ;
            PrecoJ = precoJ;
        }

        public override string ToString()
        {
            return "Jogo:" + NomeJ + ", Preço:" + PrecoJ.ToString("F2" , CultureInfo.InvariantCulture);
        }
    }
}
