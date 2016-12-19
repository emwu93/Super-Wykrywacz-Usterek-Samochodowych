using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperWykrywaczUsterekSamochodowych
{
    public partial class Form1 : System.Windows.Forms.Form
    {
       public string problem_key; //kod problemu
       
       
       
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private string diag(string problem_key)
        {
            IDictionary<string, string> baza = new Dictionary<string, string>(); //baza kodow wraz z ich znaczeniem
            string wynik="";
            //nie odpala baza --START
            baza.Add("1AB", "Dolej paliwa");            
            baza.Add("1AD", "Naładuj akumulator");
            baza.Add("1AE", "Wymień rozrusznik");
            baza.Add("1AF", "Wymień przewody wysokiego napięcia");
            baza.Add("1AG", "Sprawdź cewkę zapłonową");
            //nie odpala baza --KONIEC

            //problem podczas jazdy --START
            baza.Add("2AC", "Sprawdź stan sworzni i amortyzatorów");
            baza.Add("2AD","Sprawdź przeguby");
            baza.Add("2AF","Sprawdź stan tarczy hamulcowych");
            baza.Add("2AG","Napompuj koła");
            baza.Add("2AH","Wyważ koła");
            baza.Add("2AJ","Uzupełnij płyn hamulcowy");
            baza.Add("2AK", "Wymień klocki i tarcze hamulcowe oraz odpowietrz układ hamulcowy");
            baza.Add("2AL", "Wymień pompe hamulcową i odpowietrz układ hamulcowy");
            baza.Add("2AM","Odpowietrz układ hamulcowy");

            wynik = baza[problem_key];

            return wynik;
        }
        
           
        //nie odpala przyciski -- START
        private void nie_odpala_Click(object sender, EventArgs e)
        {
            problem_key += "1A";
            panel1.Visible = false;
            czy_jest_paliwo.Visible = true;
                        
        }

        private void probl_podcz_jazdy_Click(object sender, EventArgs e)
        {
            problem_key += "2A";
            panel1.Visible = false;
            prob_pod_jaz.Visible = true;
        }

        private void czy_paliwo_tak_Click(object sender, EventArgs e)
        {
            czy_jest_paliwo.Visible = false;
            czy_accu.Visible = true;
        }

        private void czy_paliwo_nie_Click(object sender, EventArgs e)
        {
            problem_key += "B";
            czy_jest_paliwo.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_accu_tak_Click(object sender, EventArgs e)
        {
            czy_accu.Visible = false;
            czy_rozr.Visible=true;
        }

        private void czy_accu_nie_Click(object sender, EventArgs e)
        {
            czy_accu.Visible = false;
            problem_key += "D";            
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_rozr_tak_Click(object sender, EventArgs e)
        {
            problem_key += "E";
            czy_rozr.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_rozr_nie_Click(object sender, EventArgs e)
        {
            czy_rozr.Visible = false;
            czy_przewody.Visible = true;
        }

        private void czy_przewody_tak_Click(object sender, EventArgs e)
        {
            problem_key += "G";
            czy_przewody.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_przewody_nie_Click(object sender, EventArgs e)
        {
            problem_key += "F";
            czy_przewody.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void strona_glowna_Click(object sender, EventArgs e)
        {
            diagnoza.Visible = false;
            panel1.Visible = true;
            problem_key = null;
        }

        private void niepoko_odglosy_Click(object sender, EventArgs e)
        {
            prob_pod_jaz.Visible = false;
            stuka_pod_skrecania.Visible = true;
        }

        private void probl_z_prow_Click(object sender, EventArgs e)
        {
            prob_pod_jaz.Visible = false;
            szarpie_sciaga.Visible = true;
        }

        private void probl_z_ham_Click(object sender, EventArgs e)
        {
            prob_pod_jaz.Visible = false;
            prob_z_ham.Visible = true;
        }

        private void stuka_pod_skr_tak_Click(object sender, EventArgs e)
        {
            problem_key += "D";
            stuka_pod_skrecania.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void stuka_pod_skr_nie_Click(object sender, EventArgs e)
        {
            problem_key += "C";
            stuka_pod_skrecania.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);

        }

        private void szarpie_kiero_Click(object sender, EventArgs e)
        {
            problem_key += "F";
            szarpie_sciaga.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void sciaga_sam_Click(object sender, EventArgs e)
        {
            szarpie_sciaga.Visible = false;
            czy_cisnienie.Visible = true;
        }

        private void czy_cisnienie_tak_Click(object sender, EventArgs e)
        {
            problem_key += "H";
            czy_cisnienie.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_cisnienie_nie_Click(object sender, EventArgs e)
        {
            problem_key += "G";
            czy_cisnienie.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void plyn_ham_tak_Click(object sender, EventArgs e)
        {
            prob_z_ham.Visible = false;
            czy_tarcze.Visible = true;
        }

        private void plyn_ham_nie_Click(object sender, EventArgs e)
        {
            problem_key += "J";
            prob_z_ham.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);

        }

        private void czy_ham_tak_Click(object sender, EventArgs e)
        {
            czy_tarcze.Visible = false;
            czy_pompa.Visible = true;
        }

        private void czy_ham_nie_Click(object sender, EventArgs e)
        {
            problem_key += "K";
            czy_tarcze.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_pompa_tak_Click(object sender, EventArgs e)
        {
            problem_key += "M";
            czy_pompa.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }

        private void czy_pompa_nie_Click(object sender, EventArgs e)
        {
            problem_key += "L";
            czy_pompa.Visible = false;
            diagnoza.Visible = true;
            richTextBox1.Text = diag(problem_key);
        }




        //nie odpala przyciski -- KONIEC
    }
}
