namespace responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.dropdownDep = new System.Windows.Forms.ComboBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblDetail = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pictLogo
            // 
            this.pictLogo.Location = new System.Drawing.Point(12, 12);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(79, 59);
            this.pictLogo.TabIndex = 0;
            this.pictLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(97, 34);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(48, 15);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "HR APP";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(29, 109);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(99, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Karyawan :";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(29, 167);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(91, 15);
            this.lblDep.TabIndex = 3;
            this.lblDep.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(147, 106);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(111, 23);
            this.tbNama.TabIndex = 4;
            // 
            // dropdownDep
            // 
            this.dropdownDep.FormattingEnabled = true;
            this.dropdownDep.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN "});
            this.dropdownDep.Location = new System.Drawing.Point(147, 167);
            this.dropdownDep.Name = "dropdownDep";
            this.dropdownDep.Size = new System.Drawing.Size(111, 23);
            this.dropdownDep.TabIndex = 5;
            this.dropdownDep.SelectedIndexChanged += new System.EventHandler(this.dropdownDep_SelectedIndexChanged);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(29, 223);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(70, 33);
            this.btInsert.TabIndex = 6;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(147, 223);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(70, 33);
            this.btEdit.TabIndex = 7;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(259, 223);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(70, 33);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 300);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(384, 177);
            this.dgv.TabIndex = 9;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblDetail
            // 
            this.lblDetail.Location = new System.Drawing.Point(316, 23);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(97, 117);
            this.lblDetail.TabIndex = 10;
            this.lblDetail.Text = "ID Departemen: \r\nHR = HR \r\nENG = engineer \r\nDEV = developer \r\nPM = Product manage" +
    "r \r\nFIN = finance";
            this.lblDetail.UseWaitCursor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(355, 223);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(70, 33);
            this.btnLoadData.TabIndex = 11;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 500);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.dropdownDep);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pictLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictLogo;
        private Label lblLogo;
        private Label lblNama;
        private Label lblDep;
        private TextBox tbNama;
        private ComboBox dropdownDep;
        private Button btInsert;
        private Button btEdit;
        private Button btDelete;
        private DataGridView dgv;
        private Label lblDetail;
        private Button btnLoadData;
    }
}