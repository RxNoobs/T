namespace KTVSystem
{
    partial class Frm_FamilyKTV
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAlreadyExists = new System.Windows.Forms.Button();
            this.btnAtmosphere = new System.Windows.Forms.Button();
            this.btnBroadcast = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblBroadcast = new System.Windows.Forms.Label();
            this.lblSwitch = new System.Windows.Forms.Label();
            this.lblMute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAgain = new System.Windows.Forms.Label();
            this.lblAtmosphere = new System.Windows.Forms.Label();
            this.lblAlreadyExists1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnSinger = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtAllsongs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongPinyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerPinyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllsongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackgroundImage = global::KTVSystem.Properties.Resources._9;
            this.btnOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOriginal.Location = new System.Drawing.Point(209, 444);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(68, 67);
            this.btnOriginal.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnOriginal, "切换原伴唱");
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackgroundImage = global::KTVSystem.Properties.Resources._81;
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitch.Location = new System.Drawing.Point(286, 444);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(68, 67);
            this.btnSwitch.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSwitch, "结束当前歌曲，切换到下一首演唱歌曲");
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::KTVSystem.Properties.Resources._7;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(756, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 66);
            this.btnExit.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnExit, "退出当前系统");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAlreadyExists
            // 
            this.btnAlreadyExists.BackgroundImage = global::KTVSystem.Properties.Resources._6;
            this.btnAlreadyExists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlreadyExists.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlreadyExists.Location = new System.Drawing.Point(676, 445);
            this.btnAlreadyExists.Name = "btnAlreadyExists";
            this.btnAlreadyExists.Size = new System.Drawing.Size(68, 67);
            this.btnAlreadyExists.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnAlreadyExists, "查询已点歌曲列表");
            this.btnAlreadyExists.UseVisualStyleBackColor = true;
            this.btnAlreadyExists.Click += new System.EventHandler(this.btnAlreadyExists_Click);
            this.btnAlreadyExists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAlreadyExists_MouseClick);
            // 
            // btnAtmosphere
            // 
            this.btnAtmosphere.BackgroundImage = global::KTVSystem.Properties.Resources._4;
            this.btnAtmosphere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtmosphere.Location = new System.Drawing.Point(597, 445);
            this.btnAtmosphere.Name = "btnAtmosphere";
            this.btnAtmosphere.Size = new System.Drawing.Size(68, 67);
            this.btnAtmosphere.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAtmosphere, "环境渲染");
            this.btnAtmosphere.UseVisualStyleBackColor = true;
            this.btnAtmosphere.Click += new System.EventHandler(this.btnAtmosphere_Click);
            // 
            // btnBroadcast
            // 
            this.btnBroadcast.BackgroundImage = global::KTVSystem.Properties.Resources._5;
            this.btnBroadcast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBroadcast.Location = new System.Drawing.Point(363, 444);
            this.btnBroadcast.Name = "btnBroadcast";
            this.btnBroadcast.Size = new System.Drawing.Size(69, 67);
            this.btnBroadcast.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBroadcast, "播放/暂停功能键");
            this.btnBroadcast.UseVisualStyleBackColor = true;
            this.btnBroadcast.Click += new System.EventHandler(this.btnBroadcast_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = global::KTVSystem.Properties.Resources._2;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMute.Location = new System.Drawing.Point(520, 445);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(68, 67);
            this.btnMute.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnMute, "设置为静音");
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnAgain.BackgroundImage = global::KTVSystem.Properties.Resources._31;
            this.btnAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgain.FlatAppearance.BorderSize = 0;
            this.btnAgain.Location = new System.Drawing.Point(442, 445);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(68, 67);
            this.btnAgain.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAgain, "重唱一次当前曲目");
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::KTVSystem.Properties.Resources._1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(130, 444);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 67);
            this.btnHome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnHome, "返回主界面");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Paint += new System.Windows.Forms.PaintEventHandler(this.btnHome_Paint);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblOriginal.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOriginal.Location = new System.Drawing.Point(212, 522);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(122, 29);
            this.lblOriginal.TabIndex = 6;
            this.lblOriginal.Text = "原/伴唱";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHome.Location = new System.Drawing.Point(145, 522);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 29);
            this.lblHome.TabIndex = 6;
            this.lblHome.Text = "首页";
            // 
            // lblBroadcast
            // 
            this.lblBroadcast.AutoSize = true;
            this.lblBroadcast.BackColor = System.Drawing.Color.Transparent;
            this.lblBroadcast.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBroadcast.Location = new System.Drawing.Point(370, 522);
            this.lblBroadcast.Name = "lblBroadcast";
            this.lblBroadcast.Size = new System.Drawing.Size(153, 29);
            this.lblBroadcast.TabIndex = 6;
            this.lblBroadcast.Text = "播放/暂停";
            // 
            // lblSwitch
            // 
            this.lblSwitch.AutoSize = true;
            this.lblSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lblSwitch.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSwitch.Location = new System.Drawing.Point(305, 522);
            this.lblSwitch.Name = "lblSwitch";
            this.lblSwitch.Size = new System.Drawing.Size(75, 29);
            this.lblSwitch.TabIndex = 6;
            this.lblSwitch.Text = "静音";
            // 
            // lblMute
            // 
            this.lblMute.AutoSize = true;
            this.lblMute.BackColor = System.Drawing.Color.Transparent;
            this.lblMute.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMute.Location = new System.Drawing.Point(534, 522);
            this.lblMute.Name = "lblMute";
            this.lblMute.Size = new System.Drawing.Size(106, 29);
            this.lblMute.TabIndex = 6;
            this.lblMute.Text = "下一曲";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(689, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "label1";
            // 
            // lblAgain
            // 
            this.lblAgain.AutoSize = true;
            this.lblAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblAgain.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAgain.Location = new System.Drawing.Point(461, 522);
            this.lblAgain.Name = "lblAgain";
            this.lblAgain.Size = new System.Drawing.Size(75, 29);
            this.lblAgain.TabIndex = 6;
            this.lblAgain.Text = "重唱";
            // 
            // lblAtmosphere
            // 
            this.lblAtmosphere.AutoSize = true;
            this.lblAtmosphere.BackColor = System.Drawing.Color.Transparent;
            this.lblAtmosphere.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAtmosphere.Location = new System.Drawing.Point(604, 522);
            this.lblAtmosphere.Name = "lblAtmosphere";
            this.lblAtmosphere.Size = new System.Drawing.Size(75, 29);
            this.lblAtmosphere.TabIndex = 6;
            this.lblAtmosphere.Text = "全屏";
            // 
            // lblAlreadyExists1
            // 
            this.lblAlreadyExists1.AutoSize = true;
            this.lblAlreadyExists1.BackColor = System.Drawing.Color.Transparent;
            this.lblAlreadyExists1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAlreadyExists1.Location = new System.Drawing.Point(686, 522);
            this.lblAlreadyExists1.Name = "lblAlreadyExists1";
            this.lblAlreadyExists1.Size = new System.Drawing.Size(137, 29);
            this.lblAlreadyExists1.TabIndex = 6;
            this.lblAlreadyExists1.Text = "已点列表";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit.Location = new System.Drawing.Point(774, 522);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(75, 29);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "退出";
            // 
            // btnRanking
            // 
            this.btnRanking.BackgroundImage = global::KTVSystem.Properties.Resources.初音14;
            this.btnRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRanking.Location = new System.Drawing.Point(898, 178);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(119, 97);
            this.btnRanking.TabIndex = 7;
            this.btnRanking.Text = "排行榜 Ranking";
            this.btnRanking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackgroundImage = global::KTVSystem.Properties.Resources.初音18;
            this.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLanguage.Location = new System.Drawing.Point(898, 429);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(119, 99);
            this.btnLanguage.TabIndex = 8;
            this.btnLanguage.Text = "语种 Language";
            this.btnLanguage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnSinger
            // 
            this.btnSinger.BackgroundImage = global::KTVSystem.Properties.Resources.初音8;
            this.btnSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinger.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSinger.Location = new System.Drawing.Point(898, 51);
            this.btnSinger.Name = "btnSinger";
            this.btnSinger.Size = new System.Drawing.Size(119, 100);
            this.btnSinger.TabIndex = 9;
            this.btnSinger.Text = "歌手 Singer";
            this.btnSinger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSinger.UseVisualStyleBackColor = true;
            this.btnSinger.Click += new System.EventHandler(this.btnSinger_Click);
            // 
            // btnSong
            // 
            this.btnSong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSong.BackgroundImage = global::KTVSystem.Properties.Resources.初音13;
            this.btnSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSong.Location = new System.Drawing.Point(898, 302);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(119, 99);
            this.btnSong.TabIndex = 10;
            this.btnSong.Text = "歌名搜索 Song";
            this.btnSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSong.UseVisualStyleBackColor = false;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtAllsongs);
            this.panel1.Location = new System.Drawing.Point(106, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 370);
            this.panel1.TabIndex = 11;
            // 
            // dtAllsongs
            // 
            this.dtAllsongs.AllowUserToAddRows = false;
            this.dtAllsongs.AllowUserToDeleteRows = false;
            this.dtAllsongs.AllowUserToResizeColumns = false;
            this.dtAllsongs.AllowUserToResizeRows = false;
            this.dtAllsongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAllsongs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtAllsongs.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dtAllsongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAllsongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtAllsongs.ColumnHeadersHeight = 60;
            this.dtAllsongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtAllsongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SongName,
            this.SongPinyin,
            this.SongLanguage,
            this.SingerName,
            this.SingerPinyin,
            this.SingerRegion,
            this.Count});
            this.dtAllsongs.Location = new System.Drawing.Point(0, 0);
            this.dtAllsongs.Name = "dtAllsongs";
            this.dtAllsongs.ReadOnly = true;
            this.dtAllsongs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAllsongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtAllsongs.RowHeadersVisible = false;
            this.dtAllsongs.RowHeadersWidth = 60;
            this.dtAllsongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtAllsongs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtAllsongs.RowTemplate.Height = 23;
            this.dtAllsongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtAllsongs.Size = new System.Drawing.Size(756, 370);
            this.dtAllsongs.TabIndex = 0;
            this.dtAllsongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAllsongs_CellContentClick);
            this.dtAllsongs.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAllsongs_CellMouseEnter);
            this.dtAllsongs.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAllsongs_CellMouseLeave);
            this.dtAllsongs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtAllsongs_DataBindingComplete);
            this.dtAllsongs.MouseLeave += new System.EventHandler(this.dtAllsongs_MouseLeave);
            // 
            // ID
            // 
            this.ID.HeaderText = "歌曲编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌曲名";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            // 
            // SongPinyin
            // 
            this.SongPinyin.DataPropertyName = "SongPinyin";
            this.SongPinyin.HeaderText = "歌曲简拼";
            this.SongPinyin.Name = "SongPinyin";
            this.SongPinyin.ReadOnly = true;
            // 
            // SongLanguage
            // 
            this.SongLanguage.DataPropertyName = "SongLanguage";
            this.SongLanguage.HeaderText = "歌曲语种";
            this.SongLanguage.Name = "SongLanguage";
            this.SongLanguage.ReadOnly = true;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SongLanguage";
            this.SingerName.HeaderText = "歌手名";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SingerPinyin
            // 
            this.SingerPinyin.DataPropertyName = "SingerPinyin";
            this.SingerPinyin.HeaderText = "歌手简拼";
            this.SingerPinyin.Name = "SingerPinyin";
            this.SingerPinyin.ReadOnly = true;
            // 
            // SingerRegion
            // 
            this.SingerRegion.DataPropertyName = "SingerRegion";
            this.SingerRegion.HeaderText = "歌手地区";
            this.SingerRegion.Name = "SingerRegion";
            this.SingerRegion.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "演唱次数";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_FamilyKTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTVSystem.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnSinger);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.lblAtmosphere);
            this.Controls.Add(this.lblSwitch);
            this.Controls.Add(this.lblAgain);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAlreadyExists1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBroadcast);
            this.Controls.Add(this.lblMute);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAlreadyExists);
            this.Controls.Add(this.btnAtmosphere);
            this.Controls.Add(this.btnBroadcast);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FamilyKTV";
            this.Text = "父类（基础控件）";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_FamilyKTV_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_FamilyKTV_SizeChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAllsongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblBroadcast;
        private System.Windows.Forms.Label lblSwitch;
        private System.Windows.Forms.Label lblMute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAgain;
        private System.Windows.Forms.Label lblAtmosphere;
        private System.Windows.Forms.Label lblAlreadyExists1;
        private System.Windows.Forms.Label lblExit;
        public System.Windows.Forms.Button btnOriginal;
        public System.Windows.Forms.Button btnSwitch;
        public System.Windows.Forms.Button btnBroadcast;
        public System.Windows.Forms.Button btnAgain;
        public System.Windows.Forms.Button btnMute;
        public System.Windows.Forms.Button btnAtmosphere;
        public System.Windows.Forms.Button btnAlreadyExists;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnSinger;
        private System.Windows.Forms.Button btnSong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dtAllsongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongPinyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerPinyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

