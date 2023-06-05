
namespace mini_market_management_system
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_logout = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView_sellList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_seller = new System.Windows.Forms.Label();
            this.DataGridView_poduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridView_seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_addorder = new System.Windows.Forms.Button();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.TextBox_qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_qty = new System.Windows.Forms.Label();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_sellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_poduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(33, 601);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(110, 38);
            this.label_logout.TabIndex = 37;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_exit.Location = new System.Drawing.Point(1065, 2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 33;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DataGridView_sellList);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Controls.Add(this.DataGridView_poduct);
            this.panel1.Controls.Add(this.dataGridView_seller);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_print);
            this.panel1.Controls.Add(this.button_addorder);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.TextBox_qty);
            this.panel1.Controls.Add(this.label_qty);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Location = new System.Drawing.Point(173, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 605);
            this.panel1.TabIndex = 32;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.Location = new System.Drawing.Point(731, 251);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(36, 35);
            this.label_amount.TabIndex = 27;
            this.label_amount.Text = "Tl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(516, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 35);
            this.label4.TabIndex = 26;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 35);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sells List";
            // 
            // DataGridView_sellList
            // 
            dataGridViewCellStyle100.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle100;
            this.DataGridView_sellList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_sellList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_sellList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_sellList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_sellList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle101.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_sellList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle101;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle102.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_sellList.DefaultCellStyle = dataGridViewCellStyle102;
            this.DataGridView_sellList.EnableHeadersVisualStyles = false;
            this.DataGridView_sellList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.Location = new System.Drawing.Point(382, 359);
            this.DataGridView_sellList.Name = "DataGridView_sellList";
            this.DataGridView_sellList.RowHeadersVisible = false;
            this.DataGridView_sellList.RowHeadersWidth = 62;
            this.DataGridView_sellList.RowTemplate.Height = 28;
            this.DataGridView_sellList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_sellList.Size = new System.Drawing.Size(525, 158);
            this.DataGridView_sellList.TabIndex = 24;
            this.DataGridView_sellList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridView_sellList.ThemeStyle.ReadOnly = false;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(264, 313);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(105, 56);
            this.button_refresh.TabIndex = 23;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(67, 323);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(191, 43);
            this.comboBox_category.TabIndex = 22;
            this.comboBox_category.Text = "Select Category";
            this.comboBox_category.SelectionChangeCommitted += new System.EventHandler(this.comboBox_category_SelectionChangeCommitted);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(793, 48);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(69, 35);
            this.label_date.TabIndex = 21;
            this.label_date.Text = "Date:";
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seller.ForeColor = System.Drawing.Color.White;
            this.label_seller.Location = new System.Drawing.Point(50, 24);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(138, 35);
            this.label_seller.TabIndex = 20;
            this.label_seller.Text = "Seller Name";
            // 
            // DataGridView_poduct
            // 
            dataGridViewCellStyle103.BackColor = System.Drawing.Color.White;
            this.DataGridView_poduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle103;
            this.DataGridView_poduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_poduct.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_poduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_poduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_poduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle104.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle104.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle104.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_poduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle104;
            dataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle105.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle105.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle105.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle105.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle105.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle105.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_poduct.DefaultCellStyle = dataGridViewCellStyle105;
            this.DataGridView_poduct.EnableHeadersVisualStyles = false;
            this.DataGridView_poduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_poduct.Location = new System.Drawing.Point(67, 372);
            this.DataGridView_poduct.Name = "DataGridView_poduct";
            this.DataGridView_poduct.RowHeadersVisible = false;
            this.DataGridView_poduct.RowHeadersWidth = 62;
            this.DataGridView_poduct.RowTemplate.Height = 28;
            this.DataGridView_poduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_poduct.Size = new System.Drawing.Size(287, 224);
            this.DataGridView_poduct.TabIndex = 19;
            this.DataGridView_poduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView_poduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_poduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_poduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_poduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_poduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_poduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_poduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_poduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_poduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_poduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_poduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_poduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_poduct.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridView_poduct.ThemeStyle.ReadOnly = false;
            this.DataGridView_poduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_poduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_poduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_poduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_poduct.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridView_poduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_poduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_poduct.Click += new System.EventHandler(this.DataGridView_poduct_Click);
            // 
            // dataGridView_seller
            // 
            dataGridViewCellStyle106.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle106;
            this.dataGridView_seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_seller.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_seller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_seller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle107.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle107.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle107.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle107.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle107;
            this.dataGridView_seller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle108.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle108.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle108.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle108.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle108.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle108.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_seller.DefaultCellStyle = dataGridViewCellStyle108;
            this.dataGridView_seller.EnableHeadersVisualStyles = false;
            this.dataGridView_seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.Location = new System.Drawing.Point(382, 90);
            this.dataGridView_seller.Name = "dataGridView_seller";
            this.dataGridView_seller.RowHeadersVisible = false;
            this.dataGridView_seller.RowHeadersWidth = 62;
            this.dataGridView_seller.RowTemplate.Height = 28;
            this.dataGridView_seller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_seller.Size = new System.Drawing.Size(525, 158);
            this.dataGridView_seller.TabIndex = 16;
            this.dataGridView_seller.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_seller.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_seller.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView_seller.ThemeStyle.ReadOnly = false;
            this.dataGridView_seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_seller.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView_seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(458, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 58);
            this.label6.TabIndex = 15;
            this.label6.Text = "SELLING";
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(822, 310);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(105, 56);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_print
            // 
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(799, 539);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(105, 56);
            this.button_print.TabIndex = 11;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_addorder
            // 
            this.button_addorder.FlatAppearance.BorderSize = 0;
            this.button_addorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addorder.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addorder.ForeColor = System.Drawing.Color.White;
            this.button_addorder.Location = new System.Drawing.Point(153, 251);
            this.button_addorder.Name = "button_addorder";
            this.button_addorder.Size = new System.Drawing.Size(157, 56);
            this.button_addorder.TabIndex = 10;
            this.button_addorder.Text = "Add Order";
            this.button_addorder.UseVisualStyleBackColor = true;
            this.button_addorder.Click += new System.EventHandler(this.button_addorder_Click);
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 18;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.Parent = this.TextBox_name;
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.FocusedState.Parent = this.TextBox_name;
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.HoverState.Parent = this.TextBox_name;
            this.TextBox_name.Location = new System.Drawing.Point(154, 98);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.ShadowDecoration.Parent = this.TextBox_name;
            this.TextBox_name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_name.TabIndex = 7;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(50, 99);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(73, 35);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Name";
            // 
            // TextBox_qty
            // 
            this.TextBox_qty.BorderRadius = 18;
            this.TextBox_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_qty.DefaultText = "";
            this.TextBox_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_qty.DisabledState.Parent = this.TextBox_qty;
            this.TextBox_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_qty.FocusedState.Parent = this.TextBox_qty;
            this.TextBox_qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_qty.HoverState.Parent = this.TextBox_qty;
            this.TextBox_qty.Location = new System.Drawing.Point(153, 182);
            this.TextBox_qty.Name = "TextBox_qty";
            this.TextBox_qty.PasswordChar = '\0';
            this.TextBox_qty.PlaceholderText = "";
            this.TextBox_qty.SelectedText = "";
            this.TextBox_qty.ShadowDecoration.Parent = this.TextBox_qty;
            this.TextBox_qty.Size = new System.Drawing.Size(200, 36);
            this.TextBox_qty.TabIndex = 5;
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qty.ForeColor = System.Drawing.Color.White;
            this.label_qty.Location = new System.Drawing.Point(50, 182);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(104, 35);
            this.label_qty.TabIndex = 4;
            this.label_qty.Text = "Quantity";
            // 
            // TextBox_price
            // 
            this.TextBox_price.BorderRadius = 18;
            this.TextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_price.DefaultText = "";
            this.TextBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.DisabledState.Parent = this.TextBox_price;
            this.TextBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.FocusedState.Parent = this.TextBox_price;
            this.TextBox_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.HoverState.Parent = this.TextBox_price;
            this.TextBox_price.Location = new System.Drawing.Point(154, 140);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.ReadOnly = true;
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.ShadowDecoration.Parent = this.TextBox_price;
            this.TextBox_price.Size = new System.Drawing.Size(200, 36);
            this.TextBox_price.TabIndex = 3;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.White;
            this.label_price.Location = new System.Drawing.Point(50, 141);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(66, 35);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Price";
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MaxInputLength = 100;
            this.ProdId.MinimumWidth = 8;
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 8;
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 8;
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 8;
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 18;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.Parent = this.TextBox_id;
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.FocusedState.Parent = this.TextBox_id;
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.HoverState.Parent = this.TextBox_id;
            this.TextBox_id.Location = new System.Drawing.Point(744, 321);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.ShadowDecoration.Parent = this.TextBox_id;
            this.TextBox_id.Size = new System.Drawing.Size(82, 36);
            this.TextBox_id.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(641, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 28;
            this.label5.Text = "Build";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_sellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_poduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_seller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_addorder;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_qty;
        private System.Windows.Forms.Label label_qty;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_seller;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_poduct;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_sellList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label5;
    }
}