using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetimi.DTO;

namespace VarlikZimmetDepoYonetimi.UI
{
    public partial class Menu : Form
    {

        Kullanici kullanici;
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(Kullanici kullanici) :this()
        {
            this.kullanici = kullanici;
        }

        private void varlikLİstelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarlikListeleme varlikListeleme = new VarlikListeleme(kullanici);
            varlikListeleme.MdiParent = this;
            varlikListeleme.Show();
        }

        private void varlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varlik varlik = new Varlik();
            varlik.MdiParent = this;
            varlik.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            VarlikListeleme varlikListeleme = new VarlikListeleme(kullanici);
            varlikListeleme.MdiParent = this;
            varlikListeleme.Show();
        }

        private void zimmetAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZimmetAtama zimmet = new ZimmetAtama();
            zimmet.MdiParent = this;
            zimmet.Show();
        }

        private void tüketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarlikTuketimi varlikTuketimi = new VarlikTuketimi();
            varlikTuketimi.MdiParent = this;
            varlikTuketimi.Show();
        }
    }
    }

