namespace KTVSystem
{
    partial class Frm_Language
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnChinese = new System.Windows.Forms.Button();
            this.btnYueChinese = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnRiHan = new System.Windows.Forms.Button();
            this.btnOL = new System.Windows.Forms.Button();
            this.dgLanguage = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongPinyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerPinyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChinese
            // 
            this.btnChinese.Location = new System.Drawing.Point(15, 20);
            this.btnChinese.Name = "btnChinese";
            this.btnChinese.Size = new System.Drawing.Size(63, 30);
            this.btnChinese.TabIndex = 6;
            this.btnChinese.Text = "国语";
            this.btnChinese.UseVisualStyleBackColor = true;
            this.btnChinese.Click += new System.EventHandler(this.btnChinese_Click);
            // 
            // btnYueChinese
            // 
            this.btnYueChinese.Location = new System.Drawing.Point(15, 68);
            this.btnYueChinese.Name = "btnYueChinese";
            this.btnYueChinese.Size = new System.Drawing.Size(63, 30);
            this.btnYueChinese.TabIndex = 7;
            this.btnYueChinese.Text = "粤语";
            this.btnYueChinese.UseVisualStyleBackColor = true;
            this.btnYueChinese.Click += new System.EventHandler(this.btnYueChinese_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(17, 115);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(63, 30);
            this.btnEnglish.TabIndex = 8;
            this.btnEnglish.Text = "欧美";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnRiHan
            // 
            this.btnRiHan.Location = new System.Drawing.Point(15, 162);
            this.btnRiHan.Name = "btnRiHan";
            this.btnRiHan.Size = new System.Drawing.Size(63, 30);
            this.btnRiHan.TabIndex = 9;
            this.btnRiHan.Text = "日韩";
            this.btnRiHan.UseVisualStyleBackColor = true;
            this.btnRiHan.Click += new System.EventHandler(this.btnRiHan_Click);
            // 
            // btnOL
            // 
            this.btnOL.Location = new System.Drawing.Point(14, 209);
            this.btnOL.Name = "btnOL";
            this.btnOL.Size = new System.Drawing.Size(63, 30);
            this.btnOL.TabIndex = 11;
            this.btnOL.Text = "其他语种";
            this.btnOL.UseVisualStyleBackColor = true;
            this.btnOL.Click += new System.EventHandler(this.btnOL_Click);
            // 
            // dgLanguage
            // 
            this.dgLanguage.AllowUserToAddRows = false;
            this.dgLanguage.AllowUserToDeleteRows = false;
            this.dgLanguage.AllowUserToResizeColumns = false;
            this.dgLanguage.AllowUserToResizeRows = false;
            this.dgLanguage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLanguage.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLanguage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanguage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SongName,
            this.SongPinyin,
            this.SongLanguage,
            this.SingerName,
            this.SingerPinyin,
            this.SingerRegion,
            this.count});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLanguage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLanguage.Location = new System.Drawing.Point(101, 12);
            this.dgLanguage.MultiSelect = false;
            this.dgLanguage.Name = "dgLanguage";
            this.dgLanguage.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLanguage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLanguage.RowHeadersVisible = false;
            this.dgLanguage.RowTemplate.Height = 23;
            this.dgLanguage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLanguage.Size = new System.Drawing.Size(612, 308);
            this.dgLanguage.TabIndex = 12;
            this.dgLanguage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLanguage_CellDoubleClick);
            //this.dgLanguage.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLanguage_CellMouseEnter);
            //this.dgLanguage.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLanguage_CellMouseLeave);
            //this.dgLanguage.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgLanguage_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌名";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            // 
            // SongPinyin
            // 
            this.SongPinyin.DataPropertyName = "SongPinyin";
            this.SongPinyin.HeaderText = "歌曲拼音";
            this.SongPinyin.Name = "SongPinyin";
            this.SongPinyin.ReadOnly = true;
            this.SongPinyin.Visible = false;
            // 
            // SongLanguage
            // 
            this.SongLanguage.DataPropertyName = "SongLanguage";
            this.SongLanguage.HeaderText = "语种";
            this.SongLanguage.Name = "SongLanguage";
            this.SongLanguage.ReadOnly = true;
            this.SongLanguage.Visible = false;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SingerPinyin
            // 
            this.SingerPinyin.DataPropertyName = "SingerPinyin";
            this.SingerPinyin.HeaderText = "歌手拼音";
            this.SingerPinyin.Name = "SingerPinyin";
            this.SingerPinyin.ReadOnly = true;
            this.SingerPinyin.Visible = false;
            // 
            // SingerRegion
            // 
            this.SingerRegion.DataPropertyName = "SingerRegion";
            this.SingerRegion.HeaderText = "歌手地区";
            this.SingerRegion.Name = "SingerRegion";
            this.SingerRegion.ReadOnly = true;
            this.SingerRegion.Visible = false;
            // 
            // count
            // 
            this.count.DataPropertyName = "Count";
            this.count.HeaderText = "演唱次数";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Visible = false;
            // 
            // Frm_Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTVSystem.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(740, 454);
            this.Controls.Add(this.dgLanguage);
            this.Controls.Add(this.btnOL);
            this.Controls.Add(this.btnRiHan);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnYueChinese);
            this.Controls.Add(this.btnChinese);
            this.Name = "Frm_Language";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_Language_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_Language_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChinese;
        private System.Windows.Forms.Button btnYueChinese;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnRiHan;
        private System.Windows.Forms.Button btnOL;
        private System.Windows.Forms.DataGridView dgLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongPinyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerPinyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
} 