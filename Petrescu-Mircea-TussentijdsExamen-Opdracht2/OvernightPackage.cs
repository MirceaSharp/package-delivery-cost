using System;

namespace Petrescu_Mircea_TussentijdsExamen_Opdracht2
{

    class OvernightPackage : Package
    {
        public OvernightPackage(string Bestemmingadres, string BestemmingNaam, double Gewicht, double PrijsPerkg, string Verzendadres, string Verzendnaam, double ToeslagPerkg) : base(Bestemmingadres, BestemmingNaam, Gewicht, PrijsPerkg, Verzendadres, Verzendnaam)
        {

        }


        private double _toeslagPerkg;
        public double ToeslagPerkg { get; set; }

        public override double Verzendingskosten()
        {
            return (PrijsPerkg + ToeslagPerkg) * Gewicht;
        }


        public override string BerekeningVerzendingsKosten()
        {
            return "Gegevens verzending" + Environment.NewLine + "Verzender: " + Verzendnaam + Environment.NewLine + "Bestemmeling: " + BestemmingNaam + Environment.NewLine + "Gewicht" + " " + Gewicht + " " + Environment.NewLine + "Te betalen: " + " ( " + PrijsPerkg + " + " + ToeslagPerkg + " ) " + " X " + Gewicht + " = " + Verzendingskosten();

        }





    }
}
