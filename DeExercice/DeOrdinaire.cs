using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeExercice
{
    internal class DeOrdinaire : DeControleur
    {
        private int deValeur;

        public DeOrdinaire(int nombreFace, string type) : base(nombreFace, type)
        {
            type = "Ordinaire";
        }

        public override int Brasser()
        {
            Random random = new Random();
            deValeur = random.Next(1, 7);
            PointDe();
            return deValeur;
        }

        public override int PointDe()
        {
            Point = deValeur;
            return Point;
        }
    }
}
