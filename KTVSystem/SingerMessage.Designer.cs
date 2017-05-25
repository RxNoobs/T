namespace KTVSystem
{
    partial class SingerMessage
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
            this.dgvSingerMessage = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSingerMessage
            // 
            this.dgvSingerMessage.AllowUserToAddRows = false;
            this.dgvSingerMessage.AllowUserToDeleteRows = false;
            this.dgvSingerMessage.AllowUserToResizeRows = false;
            this.dgvSingerMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSingerMessage.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvSingerMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSingerMessage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSingerMessage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSingerMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSingerMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingerMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.SongName,
            this.Column6,
            this.Column1,
            this.Column5,
            this.SingerName,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSingerMessage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSingerMessage.Location = new System.Drawing.Point(12, 45);
            this.dgvSingerMessage.MultiSelect = false;
            this.dgvSingerMessage.Name = "dgvSingerMessage";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSingerMessage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSingerMessage.RowHeadersVisible = false;
            this.dgvSingerMessage.RowTemplate.Height = 23;
            this.dgvSingerMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSingerMessage.Size = new System.Drawing.Size(608, 281);
            this.dgvSingerMessage.TabIndex = 31;
            this.dgvSingerMessage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSingerMessage_CellDoubleClick);
            this.dgvSingerMessage.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSingerMessage_CellMouseEnter);
            this.dgvSingerMessage.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSingerMessage_CellMouseLeave);
            this.dgvSingerMessage.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSingerMessage_DataBindingComplete);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ID";
            this.Column7.HeaderText = "序号";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌曲名";
            this.SongName.Name = "SongName";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SongLanguage";
            this.Column6.HeaderText = "歌曲语种";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SingerPinyin";
            this.Column1.HeaderText = "歌手简拼";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SongPinyin";
            this.Column5.HeaderText = "歌曲简拼";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手名";
            this.SingerName.Name = "SingerName";
            this.SingerName.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SingerRegion";
            this.Column4.HeaderText = "歌手地区";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // SingerMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTVSystem.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.dgvSingerMessage);
            this.Name = "SingerMessage";
            this.Text = "SingerMessage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SingerMessage_Load);
            this.SizeChanged += new System.EventHandler(this.SingerMessage_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSingerMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}