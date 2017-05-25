using Exc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace KTVSystem
{
    public partial class Frm_SongSearch : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();

        //private DataTable dt = new DataTable();


        public Frm_SongSearch()
        {
            InitializeComponent();
            this.TopMost = false;
        }



        private void Frm_SongSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void Q_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text + ((Button)sender).Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strNew = this.txtSearch.Text.Substring(0, this.txtSearch.Text.Length - 1);
            this.txtSearch.Text = strNew;
            this.txtSearch.SelectionStart = this.txtSearch.Text.Length;
            this.txtSearch.Focus();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //for (int count = 0; count < dgSearch.Columns.Count; count++)
            //{
            //    DataColumn dc = new DataColumn(dgSearch.Columns[count].Name.ToString());
            //    dt.Columns.Add(dc);

            //}
            //for (int count = 0; count < dgSearch.Rows.Count; count++)
            //{
            //    DataRow dr = dt.NewRow();
            //    for (int countsub = 0; count < dgSearch.Columns.Count; countsub++)
            //    {
            //        dr[countsub] = dgSearch.Rows[count].Cells[countsub].Value.ToString();
            //    }
            //    dt.Rows.Add(dr);
            //}



            try
            {


                DataRow[] rows1 = Data.dt.Select("SongPinyin='" + txtSearch.Text + "'");
                DataTable dtNew = Data.dt.Clone();
                for (int i = 0; i < rows1.Length; i++)
                {
                    dtNew.Rows.Add(rows1[i].ItemArray);

                }
                dgSearch.DataSource = dtNew;




            }
            catch (Exception)
            {

                throw;
            }



        }


        /// <summary>
        /// 单元行的双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //创建一个歌曲信息的对象
            //Songs s = new Songs();

            ////将点歌的信息传给对象
            //s.SongName = dgSearch.CurrentRow.Cells["SongName"].Value.ToString();
            //s.SingerName = dgSearch.CurrentRow.Cells["SingerName"].Value.ToString();

            ////将相对应的信息添加到已点列表：Common.listSongs中（在model中创建的全局变量）
            //Common.listSongs.Add(s);

            //提示用户添加歌曲成功
            //MessageBox.Show(s.SongName + " 添加成功！");


            string id = Convert.ToString(this.dgSearch.CurrentRow.Cells[0].Value.ToString());
            string songName = Convert.ToString(this.dgSearch.CurrentRow.Cells[1].Value.ToString());
            DataRow[] songs = Data.dt.Select("ID = '" + id + "'");
            for (int i = 0; i < songs.Length; i++)
            {
                Frm_FamilyKTV.curPlayList.Rows.Add(songs[i].ItemArray);//将dataRow添加到DataTable中
            }
            MessageBox.Show(songName + " 添加成功！");
        }


        private void Frm_SongSearch_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

