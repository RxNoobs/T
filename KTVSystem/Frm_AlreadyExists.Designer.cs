namespace KTVSystem
{
    partial class Frm_AlreadyExists
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
            this.dgAlreadyExists = new System.Windows.Forms.DataGridView();
            this.lblAlreadyExists2 = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlreadyExists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlreadyExists
            // 
            this.dgAlreadyExists.AllowUserToAddRows = false;
            this.dgAlreadyExists.AllowUserToDeleteRows = false;
            this.dgAlreadyExists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlreadyExists.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlreadyExists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAlreadyExists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlreadyExists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerName,
            this.SongName,
            this.SongLanguage,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAlreadyExists.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAlreadyExists.Location = new System.Drawing.Point(24, 72);
            this.dgAlreadyExists.Name = "dgAlreadyExists";
            this.dgAlreadyExists.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlreadyExists.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAlreadyExists.RowHeadersVisible = false;
            this.dgAlreadyExists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlreadyExists.Size = new System.Drawing.Size(684, 215);
            this.dgAlreadyExists.TabIndex = 7;
            this.dgAlreadyExists.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgAlreadyExists_RowStateChanged);
            // 
            // lblAlreadyExists2
            // 
            this.lblAlreadyExists2.AutoSize = true;
            this.lblAlreadyExists2.BackColor = System.Drawing.Color.Transparent;
            this.lblAlreadyExists2.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAlreadyExists2.Location = new System.Drawing.Point(24, 27);
            this.lblAlreadyExists2.Name = "lblAlreadyExists2";
            this.lblAlreadyExists2.Size = new System.Drawing.Size(366, 56);
            this.lblAlreadyExists2.TabIndex = 8;
            this.lblAlreadyExists2.Text = "已点歌曲列表";
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(556, 302);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 9;
            this.btnplay.Text = "开始K歌";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(97, 302);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(87, 23);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "删除选中歌曲";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手名";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌曲名称";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            // 
            // SongLanguage
            // 
            this.SongLanguage.DataPropertyName = "SongLanguage";
            this.SongLanguage.HeaderText = "歌曲语种";
            this.SongLanguage.Name = "SongLanguage";
            this.SongLanguage.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "歌曲编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Frm_AlreadyExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KTVSystem.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(740, 454);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblAlreadyExists2);
            this.Controls.Add(this.dgAlreadyExists);
            this.Name = "Frm_AlreadyExists";
            this.Text = "Frm_AlreadyExists";
            this.SizeChanged += new System.EventHandler(this.Frm_AlreadyExists_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlreadyExists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlreadyExists2;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.DataGridView dgAlreadyExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}