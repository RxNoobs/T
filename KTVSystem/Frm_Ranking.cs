using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using KTVSystem.Properties;
using Exc;

namespace KTVSystem
{
    public partial class Frm_Ranking : Form
    {

        AutoSizeFormClass asc = new AutoSizeFormClass();
        Frm_AlreadyExists ae = new Frm_AlreadyExists();

        public Frm_Ranking()
        {
            InitializeComponent();
            dgRanking.AutoGenerateColumns = false;
        }

        private void GetAll()
        {
            dgRanking.DataSource = Data.dt;
        }



        private void Frm_Ranking_Load(object sender, EventArgs e)
        {
            GetAll();
            dgRanking.DefaultCellStyle.BackColor = Color.LightSteelBlue;//背景色
            this.dgRanking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行
        }


        private void dgRanking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(this.dgRanking.CurrentRow.Cells[1].Value.ToString());
            string songName = Convert.ToString(this.dgRanking.CurrentRow.Cells[0].Value.ToString());
            DataRow[] songs = Data.dt.Select("ID = '" + id + "'");
            for (int i = 0; i < songs.Length; i++)
            {
                Frm_FamilyKTV.curPlayList.Rows.Add(songs[i].ItemArray);//将dataRow添加到DataTable中
            }
            MessageBox.Show(songName + " 添加成功！");
        }

        private void Frm_Ranking_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }


        /// <summary>
        /// 排行榜行序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgRanking_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgRanking.RowHeadersWidth - 4,
                e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgRanking.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgRanking.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgRanking_MouseEnter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 鼠标移动到某行时更改背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgRanking_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgRanking.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }
        /// <summary>
        /// 鼠标离开时还原背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgRanking_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgRanking.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }

        private void dgRanking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgRanking.Rows.Count > 0)
            {
                this.dgRanking.Rows[0].Selected = false;
            }
        }
    }
}
