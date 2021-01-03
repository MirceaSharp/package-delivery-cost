namespace Petrescu_Mircea_TussentijdsExamen_Opdracht2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEinde = new System.Windows.Forms.Button();
            this.btnBereken = new System.Windows.Forms.Button();
            this.rdTwoDay = new System.Windows.Forms.RadioButton();
            this.rdOvernight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVerzenderAdres = new System.Windows.Forms.TextBox();
            this.txtVerzenderNaam = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNaamBestemming = new System.Windows.Forms.TextBox();
            this.txtAdresBestemming = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrijskg = new System.Windows.Forms.TextBox();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtSoort = new System.Windows.Forms.TextBox();
            this.txtBetalen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(25, 31);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Tag = "";
            this.lblNaam.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "";
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naam";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gewicht (in kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prijs per kg";
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(514, 338);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(131, 52);
            this.btnEinde.TabIndex = 14;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(377, 340);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(104, 48);
            this.btnBereken.TabIndex = 15;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // rdTwoDay
            // 
            this.rdTwoDay.AutoSize = true;
            this.rdTwoDay.Location = new System.Drawing.Point(41, 22);
            this.rdTwoDay.Name = "rdTwoDay";
            this.rdTwoDay.Size = new System.Drawing.Size(65, 17);
            this.rdTwoDay.TabIndex = 16;
            this.rdTwoDay.TabStop = true;
            this.rdTwoDay.Text = "TwoDay";
            this.rdTwoDay.UseVisualStyleBackColor = true;
            this.rdTwoDay.CheckedChanged += new System.EventHandler(this.rdTwoDay_CheckedChanged);
            // 
            // rdOvernight
            // 
            this.rdOvernight.AutoSize = true;
            this.rdOvernight.Location = new System.Drawing.Point(41, 56);
            this.rdOvernight.Name = "rdOvernight";
            this.rdOvernight.Size = new System.Drawing.Size(71, 17);
            this.rdOvernight.TabIndex = 17;
            this.rdOvernight.TabStop = true;
            this.rdOvernight.Text = "Overnight";
            this.rdOvernight.UseVisualStyleBackColor = true;
            this.rdOvernight.CheckedChanged += new System.EventHandler(this.rdOvernight_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtVerzenderAdres);
            this.groupBox1.Controls.Add(this.txtVerzenderNaam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNaam);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 107);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verzender";
            // 
            // txtVerzenderAdres
            // 
            this.txtVerzenderAdres.Location = new System.Drawing.Point(81, 66);
            this.txtVerzenderAdres.Name = "txtVerzenderAdres";
            this.txtVerzenderAdres.Size = new System.Drawing.Size(119, 20);
            this.txtVerzenderAdres.TabIndex = 3;
            this.txtVerzenderAdres.TextChanged += new System.EventHandler(this.txtVerzenderAdres_TextChanged);
            // 
            // txtVerzenderNaam
            // 
            this.txtVerzenderNaam.Location = new System.Drawing.Point(81, 31);
            this.txtVerzenderNaam.Name = "txtVerzenderNaam";
            this.txtVerzenderNaam.Size = new System.Drawing.Size(119, 20);
            this.txtVerzenderNaam.TabIndex = 2;
            this.txtVerzenderNaam.TextChanged += new System.EventHandler(this.txtVerzenderNaam_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Controls.Add(this.txtNaamBestemming);
            this.groupBox2.Controls.Add(this.txtAdresBestemming);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 93);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bestemming";
            // 
            // txtNaamBestemming
            // 
            this.txtNaamBestemming.Location = new System.Drawing.Point(80, 17);
            this.txtNaamBestemming.Name = "txtNaamBestemming";
            this.txtNaamBestemming.Size = new System.Drawing.Size(119, 20);
            this.txtNaamBestemming.TabIndex = 4;
            this.txtNaamBestemming.TextChanged += new System.EventHandler(this.txtNaamBestemming_TextChanged);
            // 
            // txtAdresBestemming
            // 
            this.txtAdresBestemming.Location = new System.Drawing.Point(80, 47);
            this.txtAdresBestemming.Name = "txtAdresBestemming";
            this.txtAdresBestemming.Size = new System.Drawing.Size(119, 20);
            this.txtAdresBestemming.TabIndex = 5;
            this.txtAdresBestemming.TextChanged += new System.EventHandler(this.txtAdresBestemming_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdOvernight);
            this.groupBox3.Controls.Add(this.rdTwoDay);
            this.groupBox3.Location = new System.Drawing.Point(419, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 96);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soort Verzending";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Soort Zending";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Te Betalen";
            // 
            // txtPrijskg
            // 
            this.txtPrijskg.Location = new System.Drawing.Point(149, 330);
            this.txtPrijskg.Name = "txtPrijskg";
            this.txtPrijskg.Size = new System.Drawing.Size(119, 20);
            this.txtPrijskg.TabIndex = 4;
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(149, 292);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(119, 20);
            this.txtGewicht.TabIndex = 5;
            // 
            // txtSoort
            // 
            this.txtSoort.Location = new System.Drawing.Point(460, 180);
            this.txtSoort.Name = "txtSoort";
            this.txtSoort.Size = new System.Drawing.Size(119, 20);
            this.txtSoort.TabIndex = 6;
            this.txtSoort.TextChanged += new System.EventHandler(this.txtSoort_TextChanged);
            // 
            // txtBetalen
            // 
            this.txtBetalen.Location = new System.Drawing.Point(460, 221);
            this.txtBetalen.Name = "txtBetalen";
            this.txtBetalen.Size = new System.Drawing.Size(119, 20);
            this.txtBetalen.TabIndex = 7;
            this.txtBetalen.TextChanged += new System.EventHandler(this.txtBetalen_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrijskg);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.txtSoort);
            this.Controls.Add(this.txtBetalen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.RadioButton rdTwoDay;
        private System.Windows.Forms.RadioButton rdOvernight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVerzenderAdres;
        private System.Windows.Forms.TextBox txtVerzenderNaam;
        private System.Windows.Forms.TextBox txtNaamBestemming;
        private System.Windows.Forms.TextBox txtAdresBestemming;
        private System.Windows.Forms.TextBox txtPrijskg;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtSoort;
        private System.Windows.Forms.TextBox txtBetalen;
    }
}

