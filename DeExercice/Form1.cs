namespace DeExercice
{
    public partial class Form1 : Form
    {
        int pointTotal = 0;

        private DeOrdinaire deOrdinaire = new DeOrdinaire(6, "Ordinaire");
        private DePipe dePipe = new DePipe(6, "Pipé");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenererUnDe();
        }

        public void GenererUnDe()
        {
            Random random = new Random();
            if (random.Next(1, 3) == 1)
            {
                deOrdinaire.Brasser();
                lblNombreObtenue.Text = "Nombre obtenue : " + deOrdinaire.Point.ToString();
                pointTotal += deOrdinaire.Point;
                lblTypeDe.Text = "Type de dé : " + deOrdinaire.Type;
            }
            else
            {
                dePipe.Brasser();
                lblNombreObtenue.Text = "Nombre obtenue : " + dePipe.Point.ToString();
                pointTotal += dePipe.Point;
                lblTypeDe.Text = "Type de dé : " + dePipe.Type;
            }
            lblTotal.Text = "Point total : " + pointTotal.ToString();
        }
    }
}