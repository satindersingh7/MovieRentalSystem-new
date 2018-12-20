namespace MovieRentalSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeadCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_AddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_ViewCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.HeadMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_AddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_ViewMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_IssueMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_ReturnMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_View = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_top10 = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_customeradd = new System.Windows.Forms.Panel();
            this.addcustomer = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_customerview = new System.Windows.Forms.Panel();
            this.gridcustomer = new System.Windows.Forms.DataGridView();
            this.CustomerEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_addmovie = new System.Windows.Forms.Panel();
            this.addmovie = new System.Windows.Forms.Button();
            this.extboxgenere = new System.Windows.Forms.TextBox();
            this.textboxplot = new System.Windows.Forms.TextBox();
            this.textboxcopies = new System.Windows.Forms.TextBox();
            this.textBoxyear = new System.Windows.Forms.TextBox();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.textBoxrating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_viewmovie = new System.Windows.Forms.Panel();
            this.gridmovie = new System.Windows.Forms.DataGridView();
            this.menumovie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_return = new System.Windows.Forms.Panel();
            this.dataGridView1return = new System.Windows.Forms.DataGridView();
            this.menureturn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_top10 = new System.Windows.Forms.Panel();
            this.gridc = new System.Windows.Forms.DataGridView();
            this.gridm = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnl_customeradd.SuspendLayout();
            this.pnl_customerview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomer)).BeginInit();
            this.CustomerEdit.SuspendLayout();
            this.pnl_addmovie.SuspendLayout();
            this.pnl_viewmovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmovie)).BeginInit();
            this.menumovie.SuspendLayout();
            this.pnl_return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1return)).BeginInit();
            this.menureturn.SuspendLayout();
            this.pnl_top10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeadCustomer,
            this.HeadMovie,
            this.lnk_View,
            this.lnk_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeadCustomer
            // 
            this.HeadCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lnk_AddCustomer,
            this.lnk_ViewCustomers});
            this.HeadCustomer.Name = "HeadCustomer";
            this.HeadCustomer.Size = new System.Drawing.Size(71, 20);
            this.HeadCustomer.Text = "Customer";
            // 
            // lnk_AddCustomer
            // 
            this.lnk_AddCustomer.Name = "lnk_AddCustomer";
            this.lnk_AddCustomer.Size = new System.Drawing.Size(159, 22);
            this.lnk_AddCustomer.Text = "Add Customer";
            this.lnk_AddCustomer.Click += new System.EventHandler(this.lnk_AddCustomer_Click);
            // 
            // lnk_ViewCustomers
            // 
            this.lnk_ViewCustomers.Name = "lnk_ViewCustomers";
            this.lnk_ViewCustomers.Size = new System.Drawing.Size(159, 22);
            this.lnk_ViewCustomers.Text = "View Customers";
            this.lnk_ViewCustomers.Click += new System.EventHandler(this.lnk_ViewCustomers_Click);
            // 
            // HeadMovie
            // 
            this.HeadMovie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lnk_AddMovie,
            this.lnk_ViewMovies,
            this.lnk_IssueMovie,
            this.lnk_ReturnMovie});
            this.HeadMovie.Name = "HeadMovie";
            this.HeadMovie.Size = new System.Drawing.Size(52, 20);
            this.HeadMovie.Text = "Movie";
            // 
            // lnk_AddMovie
            // 
            this.lnk_AddMovie.Name = "lnk_AddMovie";
            this.lnk_AddMovie.Size = new System.Drawing.Size(145, 22);
            this.lnk_AddMovie.Text = "Add Movie";
            this.lnk_AddMovie.Click += new System.EventHandler(this.lnk_AddMovie_Click);
            // 
            // lnk_ViewMovies
            // 
            this.lnk_ViewMovies.Name = "lnk_ViewMovies";
            this.lnk_ViewMovies.Size = new System.Drawing.Size(145, 22);
            this.lnk_ViewMovies.Text = "View Movies";
            this.lnk_ViewMovies.Click += new System.EventHandler(this.lnk_ViewMovies_Click);
            // 
            // lnk_IssueMovie
            // 
            this.lnk_IssueMovie.Name = "lnk_IssueMovie";
            this.lnk_IssueMovie.Size = new System.Drawing.Size(145, 22);
            this.lnk_IssueMovie.Text = "Issue Movie";
            this.lnk_IssueMovie.Click += new System.EventHandler(this.lnk_IssueMovie_Click);
            // 
            // lnk_ReturnMovie
            // 
            this.lnk_ReturnMovie.Name = "lnk_ReturnMovie";
            this.lnk_ReturnMovie.Size = new System.Drawing.Size(145, 22);
            this.lnk_ReturnMovie.Text = "Return Movie";
            this.lnk_ReturnMovie.Click += new System.EventHandler(this.lnk_ReturnMovie_Click);
            // 
            // lnk_View
            // 
            this.lnk_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lnk_top10});
            this.lnk_View.Name = "lnk_View";
            this.lnk_View.Size = new System.Drawing.Size(44, 20);
            this.lnk_View.Text = "View";
            // 
            // lnk_top10
            // 
            this.lnk_top10.Name = "lnk_top10";
            this.lnk_top10.Size = new System.Drawing.Size(222, 22);
            this.lnk_top10.Text = "Top 10 Moview / Customers";
            this.lnk_top10.Click += new System.EventHandler(this.lnk_top10_Click);
            // 
            // lnk_Exit
            // 
            this.lnk_Exit.Name = "lnk_Exit";
            this.lnk_Exit.Size = new System.Drawing.Size(37, 20);
            this.lnk_Exit.Text = "Exit";
            this.lnk_Exit.Click += new System.EventHandler(this.lnk_Exit_Click);
            // 
            // pnl_customeradd
            // 
            this.pnl_customeradd.Controls.Add(this.addcustomer);
            this.pnl_customeradd.Controls.Add(this.tb);
            this.pnl_customeradd.Controls.Add(this.tb3);
            this.pnl_customeradd.Controls.Add(this.tb2);
            this.pnl_customeradd.Controls.Add(this.tb1);
            this.pnl_customeradd.Controls.Add(this.label5);
            this.pnl_customeradd.Controls.Add(this.label4);
            this.pnl_customeradd.Controls.Add(this.label3);
            this.pnl_customeradd.Controls.Add(this.label2);
            this.pnl_customeradd.Location = new System.Drawing.Point(310, 26);
            this.pnl_customeradd.Name = "pnl_customeradd";
            this.pnl_customeradd.Size = new System.Drawing.Size(228, 355);
            this.pnl_customeradd.TabIndex = 10;
            this.pnl_customeradd.Visible = false;
            // 
            // addcustomer
            // 
            this.addcustomer.Location = new System.Drawing.Point(82, 290);
            this.addcustomer.Name = "addcustomer";
            this.addcustomer.Size = new System.Drawing.Size(75, 41);
            this.addcustomer.TabIndex = 26;
            this.addcustomer.Text = "Add Customer";
            this.addcustomer.UseVisualStyleBackColor = true;
            this.addcustomer.Click += new System.EventHandler(this.addcustomer_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(92, 231);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(120, 20);
            this.tb.TabIndex = 25;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(92, 147);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(120, 50);
            this.tb3.TabIndex = 24;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(92, 100);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(120, 20);
            this.tb2.TabIndex = 23;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(92, 57);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(120, 20);
            this.tb1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name";
            // 
            // pnl_customerview
            // 
            this.pnl_customerview.Controls.Add(this.gridcustomer);
            this.pnl_customerview.Location = new System.Drawing.Point(2, 26);
            this.pnl_customerview.Name = "pnl_customerview";
            this.pnl_customerview.Size = new System.Drawing.Size(879, 233);
            this.pnl_customerview.TabIndex = 11;
            this.pnl_customerview.Visible = false;
            // 
            // gridcustomer
            // 
            this.gridcustomer.AllowUserToAddRows = false;
            this.gridcustomer.AllowUserToDeleteRows = false;
            this.gridcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcustomer.ContextMenuStrip = this.CustomerEdit;
            this.gridcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcustomer.Location = new System.Drawing.Point(0, 0);
            this.gridcustomer.Name = "gridcustomer";
            this.gridcustomer.ReadOnly = true;
            this.gridcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridcustomer.Size = new System.Drawing.Size(879, 233);
            this.gridcustomer.TabIndex = 5;
            // 
            // CustomerEdit
            // 
            this.CustomerEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItemCustomer});
            this.CustomerEdit.Name = "contextMenuStrip1";
            this.CustomerEdit.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItemCustomer
            // 
            this.editToolStripMenuItemCustomer.Name = "editToolStripMenuItemCustomer";
            this.editToolStripMenuItemCustomer.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItemCustomer.Text = "Edit";
            this.editToolStripMenuItemCustomer.Click += new System.EventHandler(this.editToolStripMenuItemCustomer_Click);
            // 
            // pnl_addmovie
            // 
            this.pnl_addmovie.Controls.Add(this.textBoxtitle);
            this.pnl_addmovie.Controls.Add(this.addmovie);
            this.pnl_addmovie.Controls.Add(this.extboxgenere);
            this.pnl_addmovie.Controls.Add(this.textboxplot);
            this.pnl_addmovie.Controls.Add(this.textboxcopies);
            this.pnl_addmovie.Controls.Add(this.textBoxyear);
            this.pnl_addmovie.Controls.Add(this.textBoxrating);
            this.pnl_addmovie.Controls.Add(this.label6);
            this.pnl_addmovie.Controls.Add(this.label1);
            this.pnl_addmovie.Controls.Add(this.label7);
            this.pnl_addmovie.Controls.Add(this.label8);
            this.pnl_addmovie.Controls.Add(this.label9);
            this.pnl_addmovie.Controls.Add(this.label10);
            this.pnl_addmovie.Location = new System.Drawing.Point(307, 26);
            this.pnl_addmovie.Name = "pnl_addmovie";
            this.pnl_addmovie.Size = new System.Drawing.Size(256, 355);
            this.pnl_addmovie.TabIndex = 13;
            this.pnl_addmovie.Visible = false;
            // 
            // addmovie
            // 
            this.addmovie.Location = new System.Drawing.Point(76, 294);
            this.addmovie.Name = "addmovie";
            this.addmovie.Size = new System.Drawing.Size(84, 48);
            this.addmovie.TabIndex = 34;
            this.addmovie.Text = "Add Movie";
            this.addmovie.UseVisualStyleBackColor = true;
            this.addmovie.Click += new System.EventHandler(this.addmovie_Click);
            // 
            // extboxgenere
            // 
            this.extboxgenere.Location = new System.Drawing.Point(76, 209);
            this.extboxgenere.Multiline = true;
            this.extboxgenere.Name = "extboxgenere";
            this.extboxgenere.Size = new System.Drawing.Size(173, 53);
            this.extboxgenere.TabIndex = 33;
            // 
            // textboxplot
            // 
            this.textboxplot.Location = new System.Drawing.Point(76, 150);
            this.textboxplot.Multiline = true;
            this.textboxplot.Name = "textboxplot";
            this.textboxplot.Size = new System.Drawing.Size(173, 53);
            this.textboxplot.TabIndex = 32;
            // 
            // textboxcopies
            // 
            this.textboxcopies.Location = new System.Drawing.Point(76, 124);
            this.textboxcopies.Name = "textboxcopies";
            this.textboxcopies.Size = new System.Drawing.Size(173, 20);
            this.textboxcopies.TabIndex = 31;
            // 
            // textBoxyear
            // 
            this.textBoxyear.Location = new System.Drawing.Point(76, 98);
            this.textBoxyear.Name = "textBoxyear";
            this.textBoxyear.Size = new System.Drawing.Size(173, 20);
            this.textBoxyear.TabIndex = 30;
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.Location = new System.Drawing.Point(76, 13);
            this.textBoxtitle.Multiline = true;
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(173, 53);
            this.textBoxtitle.TabIndex = 28;
            // 
            // textBoxrating
            // 
            this.textBoxrating.Location = new System.Drawing.Point(76, 72);
            this.textBoxrating.Name = "textBoxrating";
            this.textBoxrating.Size = new System.Drawing.Size(173, 20);
            this.textBoxrating.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Plot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Copies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Rating";
            // 
            // pnl_viewmovie
            // 
            this.pnl_viewmovie.Controls.Add(this.gridmovie);
            this.pnl_viewmovie.Location = new System.Drawing.Point(2, 27);
            this.pnl_viewmovie.Name = "pnl_viewmovie";
            this.pnl_viewmovie.Size = new System.Drawing.Size(879, 223);
            this.pnl_viewmovie.TabIndex = 14;
            this.pnl_viewmovie.Visible = false;
            // 
            // gridmovie
            // 
            this.gridmovie.AllowUserToAddRows = false;
            this.gridmovie.AllowUserToDeleteRows = false;
            this.gridmovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmovie.ContextMenuStrip = this.menumovie;
            this.gridmovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmovie.Location = new System.Drawing.Point(0, 0);
            this.gridmovie.Name = "gridmovie";
            this.gridmovie.ReadOnly = true;
            this.gridmovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmovie.Size = new System.Drawing.Size(879, 223);
            this.gridmovie.TabIndex = 1;
            // 
            // menumovie
            // 
            this.menumovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.issueToolStripMenuItem});
            this.menumovie.Name = "contextMenuStrip1";
            this.menumovie.Size = new System.Drawing.Size(101, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.issueToolStripMenuItem.Text = "Issue";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // pnl_return
            // 
            this.pnl_return.Controls.Add(this.dataGridView1return);
            this.pnl_return.Location = new System.Drawing.Point(5, 27);
            this.pnl_return.Name = "pnl_return";
            this.pnl_return.Size = new System.Drawing.Size(873, 232);
            this.pnl_return.TabIndex = 16;
            this.pnl_return.Visible = false;
            // 
            // dataGridView1return
            // 
            this.dataGridView1return.AllowUserToAddRows = false;
            this.dataGridView1return.AllowUserToDeleteRows = false;
            this.dataGridView1return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1return.ContextMenuStrip = this.menureturn;
            this.dataGridView1return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1return.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1return.Name = "dataGridView1return";
            this.dataGridView1return.ReadOnly = true;
            this.dataGridView1return.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1return.Size = new System.Drawing.Size(873, 232);
            this.dataGridView1return.TabIndex = 1;
            // 
            // menureturn
            // 
            this.menureturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menureturn.Name = "contextMenuStrip1";
            this.menureturn.Size = new System.Drawing.Size(110, 26);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // pnl_top10
            // 
            this.pnl_top10.Controls.Add(this.gridc);
            this.pnl_top10.Controls.Add(this.gridm);
            this.pnl_top10.Location = new System.Drawing.Point(2, 27);
            this.pnl_top10.Name = "pnl_top10";
            this.pnl_top10.Size = new System.Drawing.Size(879, 389);
            this.pnl_top10.TabIndex = 18;
            this.pnl_top10.Visible = false;
            // 
            // gridc
            // 
            this.gridc.AllowUserToAddRows = false;
            this.gridc.AllowUserToDeleteRows = false;
            this.gridc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridc.Location = new System.Drawing.Point(3, 3);
            this.gridc.Name = "gridc";
            this.gridc.ReadOnly = true;
            this.gridc.Size = new System.Drawing.Size(875, 180);
            this.gridc.TabIndex = 1;
            // 
            // gridm
            // 
            this.gridm.AllowUserToAddRows = false;
            this.gridm.AllowUserToDeleteRows = false;
            this.gridm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridm.Location = new System.Drawing.Point(3, 189);
            this.gridm.Name = "gridm";
            this.gridm.ReadOnly = true;
            this.gridm.Size = new System.Drawing.Size(875, 195);
            this.gridm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 414);
            this.Controls.Add(this.pnl_addmovie);
            this.Controls.Add(this.pnl_customeradd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_top10);
            this.Controls.Add(this.pnl_return);
            this.Controls.Add(this.pnl_viewmovie);
            this.Controls.Add(this.pnl_customerview);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_customeradd.ResumeLayout(false);
            this.pnl_customeradd.PerformLayout();
            this.pnl_customerview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomer)).EndInit();
            this.CustomerEdit.ResumeLayout(false);
            this.pnl_addmovie.ResumeLayout(false);
            this.pnl_addmovie.PerformLayout();
            this.pnl_viewmovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmovie)).EndInit();
            this.menumovie.ResumeLayout(false);
            this.pnl_return.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1return)).EndInit();
            this.menureturn.ResumeLayout(false);
            this.pnl_top10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeadCustomer;
        private System.Windows.Forms.ToolStripMenuItem lnk_AddCustomer;
        private System.Windows.Forms.ToolStripMenuItem lnk_ViewCustomers;
        private System.Windows.Forms.ToolStripMenuItem HeadMovie;
        private System.Windows.Forms.ToolStripMenuItem lnk_AddMovie;
        private System.Windows.Forms.ToolStripMenuItem lnk_ViewMovies;
        private System.Windows.Forms.ToolStripMenuItem lnk_IssueMovie;
        private System.Windows.Forms.ToolStripMenuItem lnk_ReturnMovie;
        private System.Windows.Forms.ToolStripMenuItem lnk_View;
        private System.Windows.Forms.ToolStripMenuItem lnk_top10;
        private System.Windows.Forms.ToolStripMenuItem lnk_Exit;
        private System.Windows.Forms.Panel pnl_customeradd;
        private System.Windows.Forms.Button addcustomer;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_customerview;
        private System.Windows.Forms.DataGridView gridcustomer;
        private System.Windows.Forms.ContextMenuStrip CustomerEdit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemCustomer;
        private System.Windows.Forms.Panel pnl_addmovie;
        private System.Windows.Forms.Button addmovie;
        private System.Windows.Forms.TextBox extboxgenere;
        private System.Windows.Forms.TextBox textboxplot;
        private System.Windows.Forms.TextBox textboxcopies;
        private System.Windows.Forms.TextBox textBoxyear;
        private System.Windows.Forms.TextBox textBoxtitle;
        private System.Windows.Forms.TextBox textBoxrating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl_viewmovie;
        private System.Windows.Forms.DataGridView gridmovie;
        private System.Windows.Forms.ContextMenuStrip menumovie;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_return;
        private System.Windows.Forms.DataGridView dataGridView1return;
        private System.Windows.Forms.ContextMenuStrip menureturn;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_top10;
        private System.Windows.Forms.DataGridView gridc;
        private System.Windows.Forms.DataGridView gridm;
    }
}