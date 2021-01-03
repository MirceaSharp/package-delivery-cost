using System.Windows.Forms;

namespace Petrescu_Mircea_TussentijdsExamen_Opdracht2
{
    class Package
    {
        private string _bestemmingadres;
        private string _bestemmingNaam;
        private double _gewicht;
        private double _prijsPerkg;
        private string _verzendadres;
        private string _verzendnaam;

        public Package(string bestemmingadres, string bestemmingNaam, double gewicht, double prijsPerkg, string verzendadres, string verzendnaam)
        {
            Bestemmingadres = bestemmingadres;
            BestemmingNaam = bestemmingNaam;
            Gewicht = gewicht;
            PrijsPerkg = prijsPerkg;
            Verzendadres = verzendadres;
            Verzendnaam = verzendnaam;
        }




        public string Bestemmingadres { get; set; }

        public string BestemmingNaam { get; set; }

        public double Gewicht { get; set; }

        public double PrijsPerkg { get; set; }

        public string Verzendadres { get; set; }


        public string Verzendnaam { get; set; }

        public virtual double Verzendingskosten()
        {
            return Gewicht * PrijsPerkg;
        }



        public virtual string BerekeningVerzendingsKosten()
        {
            return "Te betalen" + Verzendingskosten();
        }




        public override string ToString()
        {
            string uitvoer = BerekeningVerzendingsKosten();
            return uitvoer;
            MessageBox.Show(BerekeningVerzendingsKosten().ToString());

        }
    }
}
