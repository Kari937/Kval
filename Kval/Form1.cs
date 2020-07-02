using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kval
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonMenedzher_Click(object sender, EventArgs e)
        {
            FormMenedzher formMenedzher = new FormMenedzher();
            formMenedzher.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonFizicheskiyeLitsa_Click(object sender, EventArgs e)
        {
            FormFizicheskoyeLitso formFizicheskoyeLitso = new FormFizicheskoyeLitso();
            formFizicheskoyeLitso.Show();
        }

        private void buttonYuridicheskiyeLitsa_Click(object sender, EventArgs e)
        {
            FormYuridicheskoyeLitso formYuridicheskoyeLitso = new FormYuridicheskoyeLitso();
            formYuridicheskoyeLitso.Show();
        }
    }
}
