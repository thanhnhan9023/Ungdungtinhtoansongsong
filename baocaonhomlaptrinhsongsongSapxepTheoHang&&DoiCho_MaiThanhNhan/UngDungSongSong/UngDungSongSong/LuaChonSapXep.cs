using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungSongSong
{
    public partial class LuaChonSapXep : DevExpress.XtraEditors.XtraForm
    {
        int loai;
        public LuaChonSapXep(int loai)
        {
            InitializeComponent();
            this.loai = loai;
        }
        public void loadcombox()
        {
            string sql = "select * from LOAI";
            cboLoai.DataSource = Dataprovider.Instance.laydulieutubang(sql);
            cboLoai.DisplayMember = "TENLOAI";
            cboLoai.ValueMember = "MALOAI";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UngDungSapXep frm = new UngDungSapXep(loai, cboLoai.SelectedValue.ToString());
            this.Hide();
            frm.ShowDialog();
        }

        private void LuaChonSapXep_Load(object sender, EventArgs e)
        {
            loadcombox();
        }
    }
}
