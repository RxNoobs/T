using Exc;
using System;
using System.Collections;
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

namespace KTVSystem
{
    public partial class Frm_Singer : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Frm_Singer()
        {
            InitializeComponent();
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        private void Frm_Singer_Load(object sender, EventArgs e)
        {
            getXmlInfo();
            dataGridView1.DefaultCellStyle.BackColor = Color.LightSteelBlue;//背景色        
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行

        }
        private void getXmlInfo()
        {

            dataGridView1.DataSource = Data.dt;
            
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        //显示选中XML节点的详细信息
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CurrentCell.Style.SelectionBackColor = Color.Red;
        }

        /// <summary>
        /// 大陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mainlandSingger_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='大陆'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }

        private void btn_mainlandGroup_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='大陆'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }
        /// <summary>
        /// 港台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_hAdSinger_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='港台'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }

        private void btn_hAdGroup_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='港台'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }
        /// <summary>
        /// 欧美地区歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_eAaSinger_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='欧美'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }

        private void btn_eAaGroup_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='欧美'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }
        /// <summary>
        /// 日韩地区歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KKCSinger_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='日韩'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }

        private void btn_KKCGroup_Click(object sender, EventArgs e)
        {
            DataRow[] rows1 = Data.dt.Select("SingerRegion='日韩'");//条件查询
            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < rows1.Length; i++)
            {
                dtNew.Rows.Add(rows1[i].ItemArray);//将dataRow添加到DataTable中
            }
            dataGridView1.DataSource = dtNew;//将查询后的数据绑定为数据表的数据源
        }


        /// <summary>
        /// 点击歌手显示歌曲信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string singerName = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            DataRow[] singerSongs = Data.dt.Select("SingerName = '" + singerName + "'");

            DataTable dtNew = Data.dt.Clone();//复制表结构
            for (int i = 0; i < singerSongs.Length; i++)
            {
                dtNew.Rows.Add(singerSongs[i].ItemArray);//将dataRow添加到DataTable中
            }
            SingerMessage messageInfo = new SingerMessage(dtNew);//通过实例化传递songNameList列表
            //弹出模式对话框
            messageInfo.Show();
        }

        private void Frm_Singer_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        /// <summary>
        /// 鼠标移动到某行时更改背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }
        /// <summary>
        /// 鼠标离开时还原背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
  
        }
        /// <summary>
        /// 取消默认选中首行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Rows[0].Selected = false;
            }
        }

    }
}
