using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210316_ArabaKayit
{
    public partial class frmAracKayit : Form
    {
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
           DialogResult sonuc = dialogRenkSec.ShowDialog();
           if(sonuc == DialogResult.OK)// kullanıcı Tamam demişse
           {
                btnRenkSec.BackColor = dialogRenkSec.Color;
           }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();
            // Text içindeki değer ilk sütuna atılır.
            satir.Text = txtAd.Text;
            satir.SubItems.Add(txtSoyad.Text);
            satir.SubItems.Add(numDaireNo.Value.ToString());
            satir.SubItems.Add(txtMarka.Text);
            satir.SubItems.Add(cmbVites.Text);

            satir.UseItemStyleForSubItems = false;
            satir.SubItems.Add("");
            satir.SubItems[5].BackColor = btnRenkSec.BackColor;

            satir.SubItems.Add(txtPlaka.Text);

            listArac.Items.Add(satir);
        }

        private void listArac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Silmek istediğinize emin misiniz?
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    listArac.Items.Remove(listArac.SelectedItems[0]);
                }
            }   
        }
    }
}
