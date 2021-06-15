using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bensa_asema
{
    public partial class Form1 : Form
    {
        string diesel = "C:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\diesel.txt";
        string e98 = "C:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\e98.txt";
        string e95 = "C:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\e95.txt";

        string tilausdiesel = "C:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\tilauksetdiesel.txt";
        string tilause98 = "C:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\tilauksete98.txt";
        string tilause95 = "C:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\tilauksete95.txt";

        public Form1()
        {
            InitializeComponent();

            piilota();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string aika = DateTime.Now.ToString();
            lblPaivamaaraJaAika.Text = aika;
        }

        public void piilota()
        {
            textBoxDieseljaljella.Enabled = false;
            textBoxE98jaljella.Enabled = false;
            textBoxE95jaljella.Enabled = false;
            buttonDiesel.Enabled = false;
            buttone98.Enabled = false;
            buttone95.Enabled = false;
            buttonTilaaDiesel.Enabled = false;
            buttonTilaaE98.Enabled = false;
            buttonTilaaE95.Enabled = false;
            textBoxDieselTilaus.Enabled = false;
            textBoxE98Tilaus.Enabled = false;
            textBoxE95Tilaus.Enabled = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)

        {

        }

        private void buttonKirjaudu_Click_1(object sender, EventArgs e)

        {
           
            //Käyttäjän "syöttämä" salasana

            {

                //  string[] rivi = System.IO.File.ReadAllLines("u:/KO/Tietojenkäsittely/Group14/tunnukset.txt");
                string[] rivi = System.IO.File.ReadAllLines("c:\\Users\\Mikko\\Desktop\\Bensaharjoitus\\tunnukset.txt");
                string kayttaja2 = rivi[0];
                string salis2 = rivi[1];

                //Jos käyttäjän antamat käyttäjätunnus ja tunnusluku ovat oikein, painikkeet otetaan käyttöön

                if (kayttaja2 == textBoxKayttaja.Text && salis2 == textBoxTunnusluku.Text)

                {

                    buttonE95.Enabled = true;
                    buttonE98.Enabled = true;
                    buttonDiesel.Enabled = true;
                    textBoxDieseljaljella.Enabled = true;
                    textBoxE98jaljella.Enabled = true;
                    textBoxE95jaljella.Enabled = true;
                    buttonTilaaDiesel.Enabled = true;
                    buttonTilaaE98.Enabled = true;
                    buttonTilaaE95.Enabled = true;
                    textBoxDieseltilaus.Enabled = true;
                    textBoxE98tilaus.Enabled = true;
                    textBoxE95tilaus.Enabled = true;

                    MessageBox.Show("Salasana oikein!");

                }

                else

                {

                    MessageBox.Show("Salasana väärin!");

                    MessageBox.Show("Salasana väärin! Haluatko yrittää uudelleen?", "Kirjautuminen", MessageBoxButtons.YesNo);

                    Application.Exit();
   
                }
            }
        }
