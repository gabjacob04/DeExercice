using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeExercice
{
    public class DePipe : DeControleur
    {
        private int valeurDe;
        public DePipe(int nombreFace, string type) : base(nombreFace, type)
        {
            type = "Pipé";
        }

        public override int Brasser()
        {
            Random random = new Random();
            valeurDe = random.Next(1, 7);
            if (valeurDe <= 3)
            {
                valeurDe = random.Next(1, 7);
                PointDe();
                return valeurDe;
            }
            else
            {
                PointDe();
                return valeurDe;
            }
        }

        public override int PointDe()
        {
            Point = valeurDe;
            return Point;
        }
    }
}
