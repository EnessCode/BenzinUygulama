using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenzinUygulama
{
    public partial class Kontrol : Form
    {
        public Kontrol()
        {
            InitializeComponent();
        }

        private void Kontrol_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbBenzinDataSet1.TBLHAREKET2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLHAREKET2TableAdapter.Fill(this.dbBenzinDataSet1.TBLHAREKET2);
            // TODO: Bu kod satırı 'dbBenzinDataSet.TBLHAREKET' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLHAREKETTableAdapter.Fill(this.dbBenzinDataSet.TBLHAREKET);

        }
    }
}
