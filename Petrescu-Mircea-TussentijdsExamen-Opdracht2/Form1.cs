using System;
using System.Windows.Forms;

namespace Petrescu_Mircea_TussentijdsExamen_Opdracht2
{
    public partial class Form1 : Form
    {
        TwoDayPackage twoDay;
        OvernightPackage overnight;


        public Form1()
        {
            InitializeComponent();
        }

        private void lblNaam_Click(object sender, EventArgs e)
        {

        }

        private void rdTwoDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTwoDay.Checked == true)
            {
                txtSoort.Clear();
                label7.Text = "Vase kost";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdOvernight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOvernight.Checked == true)
            {
                txtSoort.Clear();
                label7.Text = "Toeslag per kg";
            }
        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVerzenderNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double acceptedWeight = Convert.ToDouble(txtGewicht.Text);
            double acceptedPrijs = Convert.ToDouble(txtPrijskg.Text);
            if (rdTwoDay.Checked == true)
            {

                if (!(String.IsNullOrWhiteSpace(txtVerzenderNaam.Text) || !(String.IsNullOrWhiteSpace(txtVerzenderAdres.Text) || !(String.IsNullOrWhiteSpace(txtNaamBestemming.Text) || !(String.IsNullOrWhiteSpace(txtAdresBestemming.Text) || !(String.IsNullOrWhiteSpace(txtGewicht.Text) || !(String.IsNullOrWhiteSpace(txtPrijskg.Text) || !(String.IsNullOrWhiteSpace(txtSoort.Text)))))))))
                {



                    if (acceptedWeight < 0)
                    {
                        MessageBox.Show("Gewicht kan niet negatif zijn", "fout");
                    }
                    else if (acceptedPrijs < 0)
                    {
                        MessageBox.Show("Prijs kan niet negatif zijn", "fout");
                    }
                    else if (txtSoort.Text.Contains("-"))
                    {
                        MessageBox.Show("Vaste kost kan niet negatif zijn", "fout");
                    }
                    else
                    {

                        twoDay = new TwoDayPackage(txtAdresBestemming.Text, txtNaamBestemming.Text, Convert.ToDouble(txtGewicht.Text), Convert.ToDouble(txtPrijskg.Text), txtVerzenderAdres.Text, txtVerzenderNaam.Text, Convert.ToDouble(txtSoort.Text));
                        twoDay.Vastekost = Convert.ToDouble(txtSoort.Text);
                        txtBetalen.Text = twoDay.Verzendingskosten().ToString();
                        MessageBox.Show(twoDay.ToString(), "Vrachtbrief");
                    }
                }
                else
                {
                    MessageBox.Show("U moet alle vakken invullen!");
                }
            }
            else if (rdOvernight.Checked == true)
            {

                if (txtGewicht.Text.Contains("-"))
                {
                    MessageBox.Show("Gewicht kan niet negatif zijn", "fout");
                }
                else if (txtPrijskg.Text.Contains("-"))
                {
                    MessageBox.Show("Prijs kan niet negatif zijn", "fout");
                }
                else if (txtSoort.Text.Contains("-"))
                {
                    MessageBox.Show("Toeslag per kg kan niet negatif zijn", "fout");
                }
                else if (!(String.IsNullOrWhiteSpace(txtVerzenderNaam.Text) || !(String.IsNullOrWhiteSpace(txtVerzenderAdres.Text) || !(String.IsNullOrWhiteSpace(txtNaamBestemming.Text) || !(String.IsNullOrWhiteSpace(txtAdresBestemming.Text) || !(String.IsNullOrWhiteSpace(txtGewicht.Text) || !(String.IsNullOrWhiteSpace(txtPrijskg.Text) || !(String.IsNullOrWhiteSpace(txtSoort.Text)))))))))
                {

                    overnight = new OvernightPackage(txtAdresBestemming.Text, txtNaamBestemming.Text, Convert.ToDouble(txtGewicht.Text), Convert.ToDouble(txtPrijskg.Text), txtVerzenderAdres.Text, txtVerzenderNaam.Text, Convert.ToDouble(txtSoort.Text));
                    overnight.ToeslagPerkg = Convert.ToDouble(txtSoort.Text);
                    txtBetalen.Text = overnight.Verzendingskosten().ToString();
                    MessageBox.Show(overnight.ToString(), "Vrachbrief");
                }
                else
                {
                    MessageBox.Show("U moet alle vakken invullen!");
                }
            }
            else
            {
                MessageBox.Show("U moet een soort verzending selecteren!");
            }

        }

        private void txtVerzenderAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNaamBestemming_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresBestemming_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBetalen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
