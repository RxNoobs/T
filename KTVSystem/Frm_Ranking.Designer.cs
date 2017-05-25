namespace KTVSystem
{
    partial class Frm_Ranking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgRanking = new System.Windows.Forms.DataGridView();
            this.lblRanking = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRanking
            // 
            this.dgRanking.AllowUserToAddRows = false;
            this.dgRanking.AllowUserToDeleteRows = false;
            this.dgRanking.AllowUserToResizeColumns = false;
            this.dgRanking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgRanking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRanking.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgRanking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRanking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRanking.Location = new System.Drawing.Point(12, 93);
            this.dgRanking.MultiSelect = false;
            this.dgRanking.Name = "dgRanking";
            this.dgRanking.ReadOnly = true;
            this.dgRanking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRanking.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRanking.RowHeadersWidth = 50;
            this.dgRanking.RowTemplate.Height = 40;
            this.dgRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRanking.Size = new System.Drawing.Size(689, 307);
            this.dgRanking.TabIndex = 6;
            this.dgRanking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRanking_CellDoubleClick);
            this.dgRanking.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRanking_CellMouseEnter);
            this.dgRanking.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRanking_CellMouseLeave);
            this.dgRanking.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRanking_DataBindingComplete);
            this.dgRanking.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgRanking_RowPostPaint);
            this.dgRanking.MouseEnter += new System.EventHandler(this.dgRanking_MouseEnter);
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.BackColor = System.Drawing.Color.Transparent;
            this.lblRanking.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRanking.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRanking.Location = new System.Drawing.Point(0, 0);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(423, 56);
            this.lblRanking.TabIndex = 7;
            this.lblRanking.Text = "歌曲热度排行榜";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SongName";
            this.Column1.HeaderText = "歌曲名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ID";
            this.Column4.HeaderText = "歌曲编号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SingerName";
            this.Column2.HeaderText = "歌手名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SongLanguage";
            this.Column3.HeaderText = "歌曲语种";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Frm_Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KTVSystem.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 454);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.dgRanking);
            this.Name = "Frm_Ranking";
            this.Text = "9";
            this.Load += new System.EventHandler(this.Frm_Ranking_Load);
            this.SizeChanged += new System.EventHandler(this.Frm_Ranking_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRanking;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}