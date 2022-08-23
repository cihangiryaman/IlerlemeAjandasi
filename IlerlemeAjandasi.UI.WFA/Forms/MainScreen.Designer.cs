namespace IlerlemeAjandasi.UI.WFA.Forms
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Sidebar = new System.Windows.Forms.TableLayoutPanel();
            this.LogOutpctr = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Backbtn = new System.Windows.Forms.ToolStripButton();
            this.Closebtn = new System.Windows.Forms.ToolStripButton();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutpctr)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.ColumnCount = 1;
            this.Sidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Sidebar.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.RowCount = 2;
            this.Sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.58296F));
            this.Sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.Sidebar.Size = new System.Drawing.Size(152, 446);
            this.Sidebar.TabIndex = 0;
            // 
            // LogOutpctr
            // 
            this.LogOutpctr.Location = new System.Drawing.Point(3, 3);
            this.LogOutpctr.Name = "LogOutpctr";
            this.LogOutpctr.Size = new System.Drawing.Size(42, 30);
            this.LogOutpctr.TabIndex = 1;
            this.LogOutpctr.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LogOutpctr, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 407);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(146, 36);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(99, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 30);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Backbtn,
            this.Closebtn});
            this.toolStrip1.Location = new System.Drawing.Point(152, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Backbtn
            // 
            this.Backbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Backbtn.Image = ((System.Drawing.Image)(resources.GetObject("Backbtn.Image")));
            this.Backbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(23, 22);
            this.Backbtn.Text = "toolStripButton1";
            this.Backbtn.ToolTipText = "Geri";
            // 
            // Closebtn
            // 
            this.Closebtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Closebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(23, 22);
            this.Closebtn.Text = "toolStripButton2";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 446);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Sidebar);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Shown += new System.EventHandler(this.MainScreen_Shown);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogOutpctr)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel Sidebar;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox LogOutpctr;
        private ToolStrip toolStrip1;
        private ToolStripButton Backbtn;
        private ToolStripButton Closebtn;
    }
}