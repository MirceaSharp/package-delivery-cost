using System;

namespace Petrescu_Mircea_TussentijdsExamen_Opdracht2
{
    class TwoDayPackage : Package
    {
        public TwoDayPackage(string Bestemmingadres, string BestemmingNaam, double Gewicht, double PrijsPerkg, string Verzendadres, string Verzendnaam, double Vastekost) : base(Bestemmingadres, BestemmingNaam, Gewicht, PrijsPerkg, Verzendadres, Verzendnaam)
        {

        }


        private double _vastekost;
        public double Vastekost { get; set; }


        public override double Verzendingskosten()
        {
            return base.Verzendingskosten() + Vastekost;
        }

        public override string BerekeningVerzendingsKosten()
        {

            return "Gegevens verzending" + Environment.NewLine + "Verzender: " + Verzendnaam + Environment.NewLine + "Bestemmeling: " + BestemmingNaam + Environment.NewLine + "Gewicht" + " " + Gewicht + " " + Environment.NewLine + "Te betalen: " + Gewicht + " X " + PrijsPerkg + " + " + Vastekost + " = " + Verzendingskosten();

        }






    }
}
