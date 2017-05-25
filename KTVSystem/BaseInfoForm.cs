using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Exc;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;

namespace KTVSystem
{
    public partial class Frm_FamilyKTV : Form
    {
        public static DataTable curPlayList = new DataTable();//复制表结构,当前点播歌曲的列表
        Socket MySocket;
        Socket MyClient;
        int k;
        byte[] buf;
        List<string> song = new List<string>();
        int d;
        bool isPlay = true;

        private int correntrowIndex;//取行下标

        AutoSizeFormClass asc = new AutoSizeFormClass();

        //歌曲信息的对象

        Frm_Singer singer = new Frm_Singer();
        Frm_Ranking ranking = new Frm_Ranking();
        Frm_SongSearch songsearch = new Frm_SongSearch();
        Frm_Language language = new Frm_Language();
        Frm_AlreadyExists alreadyExists = new Frm_AlreadyExists();



        public Frm_FamilyKTV()
        {
            InitializeComponent();
            string hostName = Dns.GetHostName();
            IPHostEntry localhost = Dns.GetHostByName(hostName);
            IPAddress localaddr = localhost.AddressList[0];
            MessageBox.Show(String.Format("本机的IP地址为{0}，请在播放端输入此IP并等待反馈！", localaddr.ToString()));

            IPAddress ip = IPAddress.Parse(localaddr.ToString());//服务器端IP地址  
            IPEndPoint iep = new IPEndPoint(ip, 5555);//服务端地址及端口  
            //1.建立套接字，以Tcp协议链接，字节流的方式进行数据传输  
            MySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //设置Socket地址可重复使用  
            MySocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //2.绑定套接字  
            MySocket.Bind(iep);
            //3.监听套接字  
            MySocket.Listen(10);
            //4.等待客户端请求  
            MyClient = MySocket.Accept();
            MyClient.Send(Encoding.Unicode.GetBytes("服务端连接成功！"));
            //定义字节数组  
            buf = new byte[1024];
            //接收来自客户端的信息，并保存在字节数组中  
            k = MyClient.Receive(buf);
            //输出显示客户端发送信息  
            //Console.WriteLine(Encoding.Unicode.GetString(buf, 0, k));
            MessageBox.Show(Encoding.Unicode.GetString(buf, 0, k));
            alreadyExists.MySocket = MyClient;
            timer1.Enabled = true;


        }

        private void btnHome_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnAlreadyExists_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            alreadyExists.TopLevel = false;
            alreadyExists.FormBorderStyle = FormBorderStyle.None;
            alreadyExists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Controls.Add(alreadyExists);
            alreadyExists.UpdateDataList();
            //MessageBox.Show(curPlayList.Rows.Count.ToString());
            Frm_AlreadyExists.playGridView.DataSource = curPlayList;
            alreadyExists.Show();


        }

        private void btnHome_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("亲~确定要退出KTV系统吗？", "确定退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();//获得当前进程，停止                
            }


        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            MyClient.Send(Encoding.Unicode.GetBytes("NextPlay"));
        }

        private void Frm_FamilyKTV_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            dtAllsongs.DefaultCellStyle.BackColor = Color.LightSteelBlue;//背景色        
            this.dtAllsongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选中整行

        }

        private void Frm_FamilyKTV_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void btnAlreadyExists_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAtmosphere_Click(object sender, EventArgs e)
        {
            MyClient.Send(Encoding.Unicode.GetBytes("Full"));
        }

        private void btnSinger_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            singer.TopLevel = false;
            singer.FormBorderStyle = FormBorderStyle.None;
            singer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Controls.Add(singer);
            singer.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ranking.TopLevel = false;
            ranking.FormBorderStyle = FormBorderStyle.None;
            ranking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Controls.Add(ranking);
            ranking.Show();

        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            songsearch.TopLevel = false;
            songsearch.FormBorderStyle = FormBorderStyle.None;
            songsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Controls.Add(songsearch);
            songsearch.Show();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            language.TopLevel = false;
            language.FormBorderStyle = FormBorderStyle.None;
            language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Controls.Add(language);
            language.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d++;
            if (MyClient.Available != 0)
            {
                k = MyClient.Receive(buf);
                string a = Encoding.Unicode.GetString(buf, 0, k);
                a = a.Substring(0, a.Length - 1);
                string[] b = a.Split('|');
                for (int i = 0; i < b.Length; i++)
                {
                    string[] c = b[i].Split('-');
                    dtAllsongs.Rows.Add(c);
            }
            }
          
            if (dtAllsongs.Rows.Count > 1 && d == 2)
            {
                for (int i = 0; i < dtAllsongs.ColumnCount; i++)
                {
                    DataColumn dc = new DataColumn(dtAllsongs.Columns[i].Name.ToString());
                    DataColumn dc1 = new DataColumn(dtAllsongs.Columns[i].Name.ToString());
                    Data.dt.Columns.Add(dc);
                    curPlayList.Columns.Add(dc1);
                }
                for (int j = 0; j < dtAllsongs.Rows.Count; j++)
                {
                    DataRow dr = Data.dt.NewRow();
                    for (int l = 0; l < dtAllsongs.Columns.Count; l++)
                    {
                        dr[l] = dtAllsongs.Rows[j].Cells[l].Value.ToString();
                    }
                    Data.dt.Rows.Add(dr);
                }
            }
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            MyClient.Send(Encoding.Unicode.GetBytes("SetTrack"));
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            MyClient.Send(Encoding.Unicode.GetBytes("Volume"));
        }

        private void btnBroadcast_Click(object sender, EventArgs e)
        {
            if (isPlay == true)
            {
                MyClient.Send(Encoding.Unicode.GetBytes("Pause"));
            }
            else
            {
                MyClient.Send(Encoding.Unicode.GetBytes("Play"));
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            MyClient.Send(Encoding.Unicode.GetBytes("RePlay"));
        }
        /// <summary>
        /// 鼠标移动到某行时更改背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtAllsongs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtAllsongs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }
        private void dtAllsongs_MouseLeave(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 鼠标离开时还原背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtAllsongs_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtAllsongs.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
        }

        private void dtAllsongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 取消默认选中首行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtAllsongs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dtAllsongs.Rows.Count > 0)
            {
                this.dtAllsongs.Rows[0].Selected = false;
            }
        }
    }
}
