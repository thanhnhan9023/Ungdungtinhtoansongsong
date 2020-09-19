using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Threading;

namespace UngDungSongSong
{
    public partial class UngDungSapXep : DevExpress.XtraEditors.XtraForm
    {
        ImageList imglist = new ImageList();
        List<ListViewItem> lst = new List<ListViewItem>();
        List<ListViewItem> lst1;
      
        int loai;
        string maloai;
        public UngDungSapXep(int loai, string maloai)
        {
            InitializeComponent();
            this.loai = loai;
            this.maloai = maloai;
        }
        public void loadlistview()
        {
            string sql1 = "select * from UNGDUNG";
            string sql = "SELECT HINHANH, TENUD, LUOTDOWN,SOLUOTDG,TONGDG,DANHGIA FROM LOAI, UNGDUNG WHERE LOAI.MALOAI = UNGDUNG.MALOAI AND LOAI.MALOAI='" + maloai + "'";
            DataTable data = Dataprovider.Instance.laydulieutubang(sql1);
            foreach (DataRow item in data.Rows)
            {



                string tenud = item["TENUD"].ToString();
                string ha = item["HINHANH"].ToString();
                string luotdowwn = item["LUOTDOWN"].ToString();
                string soluotdg = item["SOLUOTDG"].ToString();
                string tongdiem = item["TONGDG"].ToString();
                string danhgia = item["DANHGIA"].ToString();

                imglist.ImageSize = new Size(150, 150);
                ListViewItem item2 = new ListViewItem(new[] { ha, tenud, luotdowwn, soluotdg, tongdiem, danhgia });
                string path = @"C:\Lap Trinh HUFI\khaithacdulieu\UngDungSongSong\UngDungSongSong\Images\ungdung\" + ha;


                ListViewItem item1 = new ListViewItem(new[] { ha, tenud, luotdowwn, soluotdg, tongdiem, danhgia });
                lstUngdung.SmallImageList = imglist;
                item2.ImageIndex = imglist.Images.Add(Image.FromFile(path), Color.Transparent);

                lst.Add(item2);

            }
            lst1 = new List<ListViewItem>(lst);
        }

        public void loadliview2()
        {
            string sql1 = "select * from UNGDUNG";
            string sql = "SELECT HINHANH, TENUD, LUOTDOWN,SOLUOTDG,TONGDG,DANHGIA FROM LOAI, UNGDUNG WHERE LOAI.MALOAI = UNGDUNG.MALOAI AND LOAI.MALOAI='" + maloai + "'";
            DataTable data = Dataprovider.Instance.laydulieutubang(sql1);
            foreach (DataRow item in data.Rows)
            {



                string tenud = item["TENUD"].ToString();
                string ha = item["HINHANH"].ToString();
             
                imglist.ImageSize = new Size(150, 150);
                ListViewItem item2 = new ListViewItem(new[] { ha, tenud,  });
                string path2 = Application.StartupPath + "\\Images\\ungdung\\" + ha;
                string path = @"C:\Lap Trinh HUFI\khaithacdulieu\UngDungSongSong\UngDungSongSong\Images\ungdung\" + ha;


                ListViewItem item1 = new ListViewItem(new[] { ha, tenud});
                lstUngdung.SmallImageList = imglist;
                item2.ImageIndex = imglist.Images.Add(Image.FromFile(path2), Color.Transparent);

                lst.Add(item2);

            }
            lst1 = new List<ListViewItem>(lst);
        }


        // tuần tự cải tiến theo hạng
        //public void sapxeptheohangtuantu()
        //{

        //    lstUngdung.Items.Clear();
        //    var topwatch = Stopwatch.StartNew();
        //    int[] rank_list= new int[lst.Count]; 
         
        //    int i;
        //    for (i = 0; i < lst.Count; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (int.Parse(lst[i].SubItems[2].Text) <= int.Parse(lst[j].SubItems[2].Text))
        //            {
        //                rank_list[i]++;
        //            }
        //            else
        //            {
        //                rank_list[j]++;

        //            }
        //        }


        //    }
        //    for (i = 0; i < lst.Count; i++)
        //    {
        //        lst1[rank_list[i]] = lst[i];
        //    }






        //    var time = topwatch.Elapsed.TotalSeconds;
        //    txtThoiGian.Text = time + "s";
        //}


            // tuần tự chưa cải tiến theo hạng
        //public void sapxeptuantu1() 
        //{
        //    var topwatch = Stopwatch.StartNew();
        //    for (int i = 0; i < lst.Count; i++)
        //    {
        //        int x = 0;
        //        for (int k = i - 1; k >= 0; k--)
        //        {
        //            double a = double.Parse(lst[k].SubItems[3].Text);
        //            double b = double.Parse(lst[k].SubItems[4].Text);
        //            double a1 = double.Parse(lst[i].SubItems[3].Text);
        //            double b1 = double.Parse(lst[i].SubItems[4].Text);
        //            double c = 0, c1 = 0;
        //            if (a != 0)
        //            {
        //                c = b / a;
        //            }

        //            if (a1 != 0)
        //            {
        //                c1 = b1 / a1;
        //            }
        //            lst[i].SubItems[5].Text = c1.ToString("0.00");
        //            if (int.Parse(lst[k].SubItems[2].Text) > int.Parse(lst[i].SubItems[2].Text))
        //                x++;
        //            else if (int.Parse(lst[k].SubItems[2].Text) == int.Parse(lst[i].SubItems[2].Text))
        //            {   
        //                if(c>=c1)
        //                    x++;
                        
        //            }
        //        }
        //        for (int j = i + 1; j < lst.Count; j++)
        //        {
        //            lst[i].SubItems[5].Text = "12";
        //            double a = double.Parse(lst[j].SubItems[3].Text);
        //            double b = double.Parse(lst[j].SubItems[4].Text);
        //            double a1 = double.Parse(lst[i].SubItems[3].Text);
        //            double b1 = double.Parse(lst[i].SubItems[4].Text);
        //            double c = 0, c1 = 0;
        //            if (a != 0)
        //            {
        //                c = b / a;
        //            }

        //            if (a1 != 0)
        //            {
        //                c1 = b1 / a1;
        //            }
        //            lst[i].SubItems[5].Text = c1.ToString("0.00");
        //            if (int.Parse(lst[j].SubItems[2].Text) > int.Parse(lst[i].SubItems[2].Text))
        //            {
        //                x++;
        //            }
        //            else if (int.Parse(lst[j].SubItems[2].Text) == int.Parse(lst[i].SubItems[2].Text))
        //            {
        //                if (c >= c1)
        //                    x++;

        //            }

        //        }

        //        lst1[x] = lst[i];
        //    }
        //    var time = topwatch.Elapsed.TotalSeconds;
        //    txtThoiGian.Text = time + "s";

        //}
      
        public void sapxeptheohangsongsong() // song song áp dụng cải tiến theo hạng
        {
            lstUngdung.Items.Clear();
            var topwatch = Stopwatch.StartNew();
            int[] rank_list = new int[lst.Count];
            rank_list[0] = 0;
            Parallel.For(1, lst.Count, i =>
              {
                  for (int j = 0; j < i; j++)

                  {
                      double a1 = double.Parse(lst[i].SubItems[3].Text);
                      double b1 = double.Parse(lst[i].SubItems[4].Text);
                      double a = double.Parse(lst[j].SubItems[3].Text);
                      double b = double.Parse(lst[j].SubItems[4].Text);

                      double c = 0, c1 = 0;
                      if (a != 0)
                      {
                          c = b / a;
                      }
                      if (a1 != 0)
                      {
                          c1 = b1 / a1;
                      }
                      lst[i].SubItems[5].Text = c1.ToString("0.00");
                      if (int.Parse(lst[i].SubItems[2].Text) < int.Parse(lst[j].SubItems[2].Text))
                      {
                          rank_list[i]++;
                      }
                      else if (int.Parse(lst[i].SubItems[2].Text) == int.Parse(lst[j].SubItems[2].Text))
                      {
                          if (c >= c1)
                              rank_list[i]++;
                      }
                     if(int.Parse(lst[i].SubItems[2].Text) > int.Parse(lst[j].SubItems[2].Text))
                      {
                          rank_list[j]++;

                      }
                      else if(int.Parse(lst[i].SubItems[2].Text) == int.Parse(lst[j].SubItems[2].Text))
                      {
                          if (c > c1)
                              rank_list[j]++;

                      }
                  }
              for (int k = 0; k < lst.Count; k++)
              {
                  lst1[rank_list[i]] = lst[i];
                  }

              });
           

            
            

            var time = topwatch.Elapsed.TotalSeconds;
            txtThoiGian.Text = time + "s";
        }
     
        public void sapxepdoichotuantu1() // tuần tự đổi chổ
        {
            lstUngdung.Items.Clear();
            var topwatch = Stopwatch.StartNew();
            for (int i = 0; i < lst.Count-1; i++)
            {
                for (int j = i+1; j < lst.Count; j++)
                {
                    double a1 = double.Parse(lst[i].SubItems[3].Text);
                    double b1 = double.Parse(lst[i].SubItems[4].Text);
                    double a = double.Parse(lst[j].SubItems[3].Text);
                    double b = double.Parse(lst[j].SubItems[4].Text);

                    double c = 0, c1 = 0;
                    if (a != 0)
                    {
                        c = b / a;
                    }
                    if (a1 != 0)
                    {
                        c1 = b1 / a1;
                    }
                    lst[i].SubItems[5].Text = c1.ToString("0.00");
                    if (int.Parse(lst[i].SubItems[2].Text) < int.Parse(lst[j].SubItems[2].Text))
                    {
                        ListViewItem item;
                        item = lst[i];
                        lst[i] = lst[j];
                        lst[j] = item;
                    }
                    else if (int.Parse(lst[i].SubItems[2].Text) == int.Parse(lst[j].SubItems[2].Text))
                    {
                        if (c >= c1)
                        {

                            ListViewItem item;
                            item = lst[i];
                            lst[i] = lst[j];
                            lst[j] = item;
                        }
                    }
                    }
                
            }
            var time = topwatch.Elapsed.TotalSeconds;
            txtThoiGian.Text = time + "s";
        }
        public void sapxepdoichosongsong1() // song song đổi chỗ
        {
            lstUngdung.Items.Clear();
            var topwatch = Stopwatch.StartNew();
            Parallel.For(0, lst.Count-1, i =>
              {
               

                      for (int j = i + 1; j < lst.Count; j++)
                      {
                          double a1 = double.Parse(lst[i].SubItems[3].Text);
                          double b1 = double.Parse(lst[i].SubItems[4].Text);
                          double a = double.Parse(lst[j].SubItems[3].Text);
                          double b = double.Parse(lst[j].SubItems[4].Text);

                          double c = 0, c1 = 0;
                          if (a != 0)
                          {
                              c = b / a;
                          }
                          if (a1 != 0)
                          {
                              c1 = b1 / a1;
                          }
                          lst[i].SubItems[5].Text = c1.ToString("0.00");
                          if (int.Parse(lst[i].SubItems[2].Text) < int.Parse(lst[j].SubItems[2].Text))
                          {

                              ListViewItem item;
                              item = lst[i];
                              lst[i] = lst[j];
                              lst[j] = item;
                          }
                          else if (int.Parse(lst[i].SubItems[2].Text) == int.Parse(lst[j].SubItems[2].Text))
                          {
                              if (c >= c1)
                              {

                                  ListViewItem item;
                                  item = lst[i];
                                  lst[i] = lst[j];
                                  lst[j] = item;
                              }

                          }
                      }
                  
                  
              });
            var time = topwatch.Elapsed.TotalSeconds;
            txtThoiGian.Text = time + "s";
        }
      
    
        public void sapxephang1() // tuần tự theo hạng
        {
            var topwatch = Stopwatch.StartNew();
            for (int i = 0; i < lst.Count; i++)
            {
                int x = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    double a = double.Parse(lst[k].SubItems[3].Text);
                    double b = double.Parse(lst[k].SubItems[4].Text);
                    double a1 = double.Parse(lst[i].SubItems[3].Text);
                    double b1 = double.Parse(lst[i].SubItems[4].Text);
                    double c = 0, c1 = 0;
                    if (a != 0)
                    {
                        c = b / a;
                    }

                    if (a1 != 0)
                    {
                        c1 = b1 / a1;
                    }
                    lst[i].SubItems[5].Text = c1.ToString("0.00");
                    if (int.Parse(lst[k].SubItems[2].Text) > int.Parse(lst[i].SubItems[2].Text))
                        x++;
                    else if (int.Parse(lst[k].SubItems[2].Text) == int.Parse(lst[i].SubItems[2].Text))
                    {
                        if (c >= c1)
                            x++;
                    }
                }
                for (int j = i + 1; j < lst.Count; j++)
                {
                    lst[i].SubItems[5].Text = "12";
                    double a = double.Parse(lst[j].SubItems[3].Text);
                    double b = double.Parse(lst[j].SubItems[4].Text);
                    double a1 = double.Parse(lst[i].SubItems[3].Text);
                    double b1 = double.Parse(lst[i].SubItems[4].Text);
                    double c = 0, c1 = 0;
                    if (a != 0)
                    {
                        c = b / a;
                    }

                    if (a1 != 0)
                    {
                        c1 = b1 / a1;
                    }
                    lst[i].SubItems[5].Text = c1.ToString("0.00");
                    if (int.Parse(lst[j].SubItems[2].Text) > int.Parse(lst[i].SubItems[2].Text))
                    {
                        x++;
                    }
                    else if (int.Parse(lst[j].SubItems[2].Text) == int.Parse(lst[i].SubItems[2].Text))
                    {
                        if (c > c1)
                            x++;
                    }

                }
                lst1[x] = lst[i];
            }
            var time = topwatch.Elapsed.TotalSeconds;
            txtThoiGian.Text = time + "s";
        }
        public void sapxephang1songsong() // sắp xếp theo hạng song song
        {

            lstUngdung.Items.Clear();
            var topwatch = Stopwatch.StartNew();
            Parallel.For(0, lst.Count, i =>
            {
                int x = 0;

                for (int k = i - 1; k >= 0; k--)
                {
                    double a1 = double.Parse(lst[i].SubItems[3].Text);
                    double b1 = double.Parse(lst[i].SubItems[4].Text);
                    double a = double.Parse(lst[k].SubItems[3].Text);
                    double b = double.Parse(lst[k].SubItems[4].Text);

                    double c = 0, c1 = 0;
                    if (a != 0)
                    {
                        c = b / a;
                    }
                    if (a1 != 0)
                    {
                        c1 = b1 / a1;
                    }
                    lst[i].SubItems[5].Text = c1.ToString("0.00");


                    if (int.Parse(lst[k].SubItems[2].Text) > int.Parse(lst[i].SubItems[2].Text))
                        x++;
                    else if (int.Parse(lst[k].SubItems[2].Text) == int.Parse(lst[i].SubItems[2].Text))
                    {
                        if (c >= c1)
                            x++;
                    }
                }

                for (int j = i + 1; j < lst.Count; j++)
                {

                    double a1 = double.Parse(lst[i].SubItems[3].Text);
                    double b1 = double.Parse(lst[i].SubItems[4].Text);
                    double a = double.Parse(lst[j].SubItems[3].Text);
                    double b = double.Parse(lst[j].SubItems[4].Text);

                    double c = 0, c1 = 0;
                    if (a != 0)
                    {
                        c = b / a;
                    }
                    if (a1 != 0)
                    {
                        c1 = b1 / a1;
                    }
                    lst[i].SubItems[5].Text = c1.ToString("0.00");


                    if (int.Parse(lst[j].SubItems[2].Text) > int.Parse(lst[i].SubItems[2].Text))
                        x++;
                    else if (int.Parse(lst[j].SubItems[2].Text) == int.Parse(lst[i].SubItems[2].Text))
                    {
                        if (c > c1)
                            x++;
                    }

                }
                lst1[x] = lst[i];
            });
            var time = topwatch.Elapsed.TotalSeconds;
            txtThoiGian.Text = time + "s";
        }
        private void UngDungSapXep_Load(object sender, EventArgs e)
        {
            txtThoiGian.Enabled = false;
            lstUngdung.Columns.Add("Picture");
            lstUngdung.Columns.Add("Tên Ứng Dụng");
            lstUngdung.Columns.Add("Lượt Download");
            lstUngdung.Columns.Add("Số lượt đánh giá");
            lstUngdung.Columns.Add("Tổng điểm đánh giá");
            lstUngdung.Columns.Add("Đánh Giá");
            lstUngdung.Columns[0].Width = 150;
            lstUngdung.Columns[1].Width = 150;
            lstUngdung.Columns[2].Width = 150;
            lstUngdung.Columns[3].Width = 190;
            lstUngdung.Columns[4].Width = 190;
            lstUngdung.Columns[5].Width = 150;

            lstUngdung.FullRowSelect = true;
            loadlistview();
            if (loai == 2) // song song theo hạng
            {

                sapxephang1songsong();
            
                foreach (ListViewItem item in lst1)
                {
                 
                    lstUngdung.Items.Add(item);
                   
                }
                lblloaisapxep.Text = "Theo Hạng Song Song";
                Form1 frm = new Form1();
                frm.Show();
            }
            if (loai == 1) // tuần tự theo hạng
            {
                sapxephang1();
                foreach (ListViewItem item in lst1)
                {
                  
                    lstUngdung.Items.Add(item);
                     
                }
                lblloaisapxep.Text = "Theo Hạng Tuần Tự";
                Form1 frm = new Form1();
                frm.Show();
            }
            if(loai==3) // tuần tự sắp xếp đổi chỗ  và so sánh
            {
                sapxepdoichotuantu1();
                foreach (ListViewItem item in lst)
                {
                    lstUngdung.Items.Add(item);
                    
                }
                lblloaisapxep.Text = "Đổi Chỗ Tuần Tự";
                Form1 frm = new Form1();
                frm.Show();

            }
            if(loai==4)// song song sắp xếp đổi chổ và so sánh
            {
                sapxepdoichosongsong1();
              
                foreach (ListViewItem item in lst)
                {
                    
                    if (item.Text == item.Text)
                    {
                        lstUngdung.Items.Remove(item);
                    }
                    lstUngdung.Items.Add(item);
               
                 
                    lblloaisapxep.Text = "Đổi Chỗ Song Song";
                }
                Form1 frm = new Form1();
                frm.Show();
            }
          

        }

        private void hiểnThịDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstUngdung.View = View.List;
           
        }

        private void hiểnThịChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstUngdung.View = View.Details;
        }
    }
}