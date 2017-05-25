using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exc;

namespace KTVSystem
{
    public partial class SingerMessage : Form
    {
        //public DataGridViewRow dgvr;//声明一个DataGridViewRow对象

        AutoSizeFormClass asc = new AutoSizeFormClass();
        Frm_Singer singer = new Frm_Singer();

        public SingerMessage(DataTable dtNew)
        {
            InitializeComponent();
            // getMessageInfo();
            //if (songList.Count > 0)//判断歌曲列表是否有值
            //{
            //    dgvSingerMessage.DataSource = songList;//有就显示出来
            //}
            dgvSingerMessage.DataSource = dtNew;
        }

        private void SingerMessage_Load(object sender, EventArgs e)
        {
            dgvSingerMessage.DefaultCellStyle.BackColor = Color.LightSteelBlue;//背景色        
            this.dgvSingerMessage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行
        }

        private void dgvSingerMessage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SingerMessage_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void dgvSingerMessage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(this.dgvSingerMessage.CurrentRow.Cells[0].Value.ToString());
            string songName = Convert.ToString(this.dgvSingerMessage.CurrentRow.Cells[1].Value.ToString());
            DataRow[] songs = Data.dt.Select("ID = '" + id + "'");
            for (int i = 0; i < songs.Length; i++)
            {
                Frm_FamilyKTV.curPlayList.Rows.Add(songs[i].ItemArray);//将dataRow添加到DataTable中
            }
            MessageBox.Show(songName + " 添加成功！");
        }

        private void dgvSingerMessage_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvSingerMessage.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void dgvSingerMessage_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvSingerMessage.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }

        private void dgvSingerMessage_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgvSingerMessage.Rows.Count > 0)
            {
                this.dgvSingerMessage.Rows[0].Selected = false;
            }
        }
    }
}
