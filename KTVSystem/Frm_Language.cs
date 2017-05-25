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
using System.IO;
using Exc;

namespace KTVSystem
{
    public partial class Frm_Language : Form
    {
        //List<Songs> list = new List<Songs>();
        private string xmlPath = string.Empty;
        private XmlDocument xmlDoc = new XmlDocument();

        AutoSizeFormClass asc = new AutoSizeFormClass();


        public Frm_Language()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取歌曲信息
        /// </summary>
        public void UpdateDataList(string songLanguage)
        {
            //list.Clear();//清空歌曲列表列表数据
            //dgLanguage.DataSource = null;//清空dgLanguage中的数据便于重新加载新的数据

            //xmlDoc.Load("MusicLib.xml");
            //XmlNodeList xnl = xmlDoc.SelectNodes(xmlPath);
            //XmlNode xn = xmlDoc.SelectSingleNode("Songs");
            //foreach (XmlNode xnode in xnl)
            //{
            //    Songs song = new Songs();
            //    XmlElement xe = (XmlElement)xnode;
            //    song.ID = Convert.ToInt32(xe.GetAttribute("ID").ToString());
            //    song.SongName = xnode.SelectSingleNode("SongName").InnerText;
            //    song.SongPinyin = xnode.SelectSingleNode("SongPinyin").InnerText;
            //    song.SongLanguage = xnode.SelectSingleNode("SongLanguage").InnerText;
            //    song.SingerName = xnode.SelectSingleNode("SingerName").InnerText;
            //    song.SingerPinyin = xnode.SelectSingleNode("SingerPinyin").InnerText;
            //    song.SingerRegion = xnode.SelectSingleNode("SingerRegion").InnerText;
            //    list.Add(song);
            //}
            //dgLanguage.DataSource = list;

            DataRow[] dr = Data.dt.Select("SongLanguage='" + songLanguage + "'");
            DataTable dtNew = Data.dt.Clone();
            for (int i = 0; i < dr.Length; i++)
            {
                dtNew.Rows.Add(dr[i].ItemArray);
            }
            dgLanguage.DataSource = dtNew;
        }

        private void Frm_Language_Load(object sender, EventArgs e)
        {
            dgLanguage.DefaultCellStyle.BackColor = Color.LightSteelBlue;//背景色        
            this.dgLanguage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行
        }

        /// <summary>
        /// 华语单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChinese_Click(object sender, EventArgs e)
        {
            //xmlPath = "/Songs/SongInfo[SongLanguage[text()='国语']]";
            string str = btnChinese.Text.Trim();
            UpdateDataList(str);
        }

        /// <summary>
        /// 粤语单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYueChinese_Click(object sender, EventArgs e)
        {
            //xmlPath = "/Songs/SongInfo[SongLanguage[text()='粤语']]";
            string str = btnYueChinese.Text.Trim();
            UpdateDataList(str);
        }

        /// <summary>
        /// 欧美单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnglish_Click(object sender, EventArgs e)
        {

            //xmlPath = "/Songs/SongInfo[SongLanguage[text()='欧美']]";
            string str = btnEnglish.Text.Trim();
            UpdateDataList(str);
        }

        /// <summary>
        /// 日韩单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRiHan_Click(object sender, EventArgs e)
        {
            //xmlPath = "/Songs/SongInfo[SongLanguage[text()='日韩']]";
            string str = btnRiHan.Text.Trim();
            UpdateDataList(str);
        }

        /// <summary>
        /// 其它语种单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOL_Click(object sender, EventArgs e)
        {
            //xmlPath = "/Songs/SongInfo[SongLanguage[text()='其他语种']]";
            string str = btnOL.Text.Trim();
            UpdateDataList(str);
        }

        /// <summary>
        /// datagirdview单击行事件（将单击歌曲添加到已点列表）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgLanguage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Songs s = new Songs();
            //s.SongName = dgLanguage.CurrentRow.Cells["SongName"].Value.ToString();
            //s.SingerName = dgLanguage.CurrentRow.Cells["SingerName"].Value.ToString();
            //Common.listSongs.Add(s);
            //MessageBox.Show(s.SongName + " 添加成功！");

            string id = Convert.ToString(this.dgLanguage.CurrentRow.Cells[0].Value.ToString());
            string songName = Convert.ToString(this.dgLanguage.CurrentRow.Cells[1].Value.ToString());
            DataRow[] songs = Data.dt.Select("ID = '" + id + "'");
            for (int i = 0; i < songs.Length; i++)
            {
                Frm_FamilyKTV.curPlayList.Rows.Add(songs[i].ItemArray);//将dataRow添加到DataTable中
            }
            MessageBox.Show(songName + " 添加成功！");
        }

        private void Frm_Language_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        /// <summary>
        /// 鼠标移动到某行时更改背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgLanguage_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgLanguage.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }
        /// <summary>
        /// 鼠标离开时还原背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgLanguage_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgLanguage.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }
        /// <summary>
        /// 取消默认选中首行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgLanguage_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgLanguage.Rows.Count > 0)
            {
                this.dgLanguage.Rows[0].Selected = false;
            }
        }
    }
}
