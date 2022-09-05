using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeExercice
{
    public abstract class DeControleur
    {
        private int nombreFace;
        private string type;
        private int point; 

        public string Type { get => type; set => type = value; }
        public int NombreFace { get => nombreFace; set => nombreFace = value; }
        public int Point { get => point; set => point = value; }

        public DeControleur(int nombreFace, string type)
        {
            this.nombreFace = nombreFace;
            this.type = type;
        }

        public abstract int Brasser();

        public abstract int PointDe();
    }
}
