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
using System.Net.Sockets;
namespace KTVSystem
{
    public partial class Frm_AlreadyExists : Form
    {

        public static DataGridView playGridView;
        private Socket _socket;
        public Socket MySocket
        {
            get { return _socket; }
            set { _socket = value; }
        }

        List<string> song = new List<string>();

        AutoSizeFormClass asc = new AutoSizeFormClass();

        public Frm_AlreadyExists()
        {
            InitializeComponent();
            dgAlreadyExists.AutoGenerateColumns = false;
            playGridView = dgAlreadyExists;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            MySocket.Send(Encoding.Unicode.GetBytes("Clear"));
            string messge = ""; song.Clear();
            for (int i = 0; i < dgAlreadyExists.RowCount; i++)
            {
                for (int j = 0; j < dgAlreadyExists.ColumnCount; j++)
                {
                    messge += dgAlreadyExists.Rows[i].Cells[j].Value + "-";
                }
                song.Add(messge.Substring(0, messge.Length - 1));
                messge = "";
            }
            for (int i = 0; i < song.Count; i++)
            {
                MySocket.Send(Encoding.Unicode.GetBytes(song[i] + "|"));
            }
        }

        private void btnAlreadyExists_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重新加载已点列表的数据
        /// </summary>
        public void UpdateDataList()
        {
            //dgAlreadyExists.Rows.Clear();//清空数据，便于刷新数据

            //Common.listSongs为已点列表
            //for (int i = 0; i < Common.listSongs.Count; i++)
            //{
            //    //在已点列表中添加数据【序号（自动增长），歌名，歌手】
            //    dgAlreadyExists.Rows.Add(i + 1, Common.listSongs[i].SongName, Common.listSongs[i].SingerName);
            //}
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AlreadyExists_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void dgAlreadyExists_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgAlreadyExists.SelectedRows.Count == 0)
                {
                    return;
                }
                int id = dgAlreadyExists.CurrentCell.RowIndex;
                dgAlreadyExists.Rows.RemoveAt(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
