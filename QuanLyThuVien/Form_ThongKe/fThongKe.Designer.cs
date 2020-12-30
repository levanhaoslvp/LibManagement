namespace QuanLyThuVien.Form_ThongKe
{
    partial class fThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabThongKe = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvDauSachMuonNhieu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenTheLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvSachTheoTheLoai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayout3 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvSachConLai = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvTheLoai = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabThongKe.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThongKe
            // 
            this.tabThongKe.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabThongKe.Controls.Add(this.metroTabPage2);
            this.tabThongKe.Controls.Add(this.metroTabPage3);
            this.tabThongKe.Controls.Add(this.metroTabPage1);
            this.tabThongKe.Controls.Add(this.metroTabPage4);
            this.tabThongKe.ItemSize = new System.Drawing.Size(364, 40);
            this.tabThongKe.Location = new System.Drawing.Point(3, 3);
            this.tabThongKe.Multiline = true;
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(839, 564);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabThongKe.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "       Sách được mượn nhiều       ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvDauSachMuonNhieu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 481);
            this.panel2.TabIndex = 2;
            // 
            // lvDauSachMuonNhieu
            // 
            this.lvDauSachMuonNhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.lvDauSachMuonNhieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.TenTheLoai,
            this.columnHeader8,
            this.columnHeader10});
            this.lvDauSachMuonNhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDauSachMuonNhieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDauSachMuonNhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lvDauSachMuonNhieu.FullRowSelect = true;
            this.lvDauSachMuonNhieu.GridLines = true;
            this.lvDauSachMuonNhieu.HideSelection = false;
            this.lvDauSachMuonNhieu.Location = new System.Drawing.Point(0, 0);
            this.lvDauSachMuonNhieu.Name = "lvDauSachMuonNhieu";
            this.lvDauSachMuonNhieu.Size = new System.Drawing.Size(776, 481);
            this.lvDauSachMuonNhieu.TabIndex = 38;
            this.lvDauSachMuonNhieu.UseCompatibleStateImageBehavior = false;
            this.lvDauSachMuonNhieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STT";
            this.columnHeader3.Width = 76;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.Text = "Tên đầu sách";
            this.TenTheLoai.Width = 343;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tập";
            this.columnHeader8.Width = 116;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số lượt mượn";
            this.columnHeader10.Width = 133;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.panel1);
            this.metroTabPage3.Controls.Add(this.flowLayout3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "       Phân nhóm theo thể loại       ";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvSachTheoTheLoai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 516);
            this.panel1.TabIndex = 3;
            // 
            // lvSachTheoTheLoai
            // 
            this.lvSachTheoTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.lvSachTheoTheLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSachTheoTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSachTheoTheLoai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSachTheoTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lvSachTheoTheLoai.FullRowSelect = true;
            this.lvSachTheoTheLoai.GridLines = true;
            this.lvSachTheoTheLoai.HideSelection = false;
            this.lvSachTheoTheLoai.Location = new System.Drawing.Point(0, 0);
            this.lvSachTheoTheLoai.Name = "lvSachTheoTheLoai";
            this.lvSachTheoTheLoai.Size = new System.Drawing.Size(685, 516);
            this.lvSachTheoTheLoai.TabIndex = 33;
            this.lvSachTheoTheLoai.UseCompatibleStateImageBehavior = false;
            this.lvSachTheoTheLoai.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đầu sách";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tập";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác giả";
            this.columnHeader4.Width = 179;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 133;
            // 
            // flowLayout3
            // 
            this.flowLayout3.Location = new System.Drawing.Point(3, 0);
            this.flowLayout3.Name = "flowLayout3";
            this.flowLayout3.Size = new System.Drawing.Size(142, 513);
            this.flowLayout3.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.Controls.Add(this.panel3);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage1.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "       Số lượng sách còn trong kho         ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvSachConLai);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 496);
            this.panel3.TabIndex = 2;
            // 
            // lvSachConLai
            // 
            this.lvSachConLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.lvSachConLai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvSachConLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSachConLai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSachConLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lvSachConLai.FullRowSelect = true;
            this.lvSachConLai.GridLines = true;
            this.lvSachConLai.HideSelection = false;
            this.lvSachConLai.Location = new System.Drawing.Point(0, 0);
            this.lvSachConLai.Name = "lvSachConLai";
            this.lvSachConLai.Size = new System.Drawing.Size(801, 496);
            this.lvSachConLai.TabIndex = 38;
            this.lvSachConLai.UseCompatibleStateImageBehavior = false;
            this.lvSachConLai.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "STT";
            this.columnHeader9.Width = 76;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên đầu sách";
            this.columnHeader11.Width = 343;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tập";
            this.columnHeader12.Width = 116;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số lượng";
            this.columnHeader13.Width = 133;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.panel4);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Thể loại yêu thích";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvTheLoai);
            this.panel4.Location = new System.Drawing.Point(17, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(781, 479);
            this.panel4.TabIndex = 2;
            // 
            // lvTheLoai
            // 
            this.lvTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.lvTheLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTheLoai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lvTheLoai.FullRowSelect = true;
            this.lvTheLoai.GridLines = true;
            this.lvTheLoai.HideSelection = false;
            this.lvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.lvTheLoai.Name = "lvTheLoai";
            this.lvTheLoai.Size = new System.Drawing.Size(781, 479);
            this.lvTheLoai.TabIndex = 42;
            this.lvTheLoai.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "STT";
            this.columnHeader14.Width = 76;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tên thể loại";
            this.columnHeader15.Width = 430;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Số lượt mượn";
            this.columnHeader16.Width = 116;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabThongKe);
            this.Name = "fThongKe";
            this.Size = new System.Drawing.Size(845, 570);
            this.tabThongKe.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabControl tabThongKe;
        private System.Windows.Forms.FlowLayoutPanel flowLayout3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvSachTheoTheLoai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvDauSachMuonNhieu;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader TenTheLoai;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lvSachConLai;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvTheLoai;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}
