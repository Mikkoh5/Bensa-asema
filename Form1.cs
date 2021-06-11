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
