
namespace mini_market_management_system
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_logout = new System.Windows.Forms.Label();
            this.button_category = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.dataGridView_seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(30, 601);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(110, 38);
            this.label_logout.TabIndex = 31;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // button_category
            // 
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_category.Location = new System.Drawing.Point(-3, 131);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(171, 66);
            this.button_category.TabIndex = 30;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_selling
            // 
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_selling.Location = new System.Drawing.Point(3, 227);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(161, 56);
            this.button_selling.TabIndex = 29;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = true;
            // 
            // button_product
            // 
            this.button_product.FlatAppearance.BorderSize = 0;
            this.button_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_product.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_product.Location = new System.Drawing.Point(3, 49);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(161, 56);
            this.button_product.TabIndex = 28;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_exit.Location = new System.Drawing.Point(1062, 2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 27;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.TextBox_pass);
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.dataGridView_seller);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.TextBox_age);
            this.panel1.Controls.Add(this.label_age);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Location = new System.Drawing.Point(170, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 605);
            this.panel1.TabIndex = 26;
            // 
            // TextBox_pass
            // 
            this.TextBox_pass.BorderRadius = 18;
            this.TextBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_pass.DefaultText = "";
            this.TextBox_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.DisabledState.Parent = this.TextBox_pass;
            this.TextBox_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.FocusedState.Parent = this.TextBox_pass;
            this.TextBox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_pass.HoverState.Parent = this.TextBox_pass;
            this.TextBox_pass.Location = new System.Drawing.Point(153, 340);
            this.TextBox_pass.Name = "TextBox_pass";
            this.TextBox_pass.PasswordChar = '\0';
            this.TextBox_pass.PlaceholderText = "";
            this.TextBox_pass.SelectedText = "";
            this.TextBox_pass.ShadowDecoration.Parent = this.TextBox_pass;
            this.TextBox_pass.Size = new System.Drawing.Size(200, 36);
            this.TextBox_pass.TabIndex = 18;
            this.TextBox_pass.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(50, 341);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(112, 35);
            this.label_password.TabIndex = 17;
            this.label_password.Text = "Password";
            // 
            // dataGridView_seller
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dataGridView_seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView_seller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_seller.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_seller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_seller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_seller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_seller.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridView_seller.EnableHeadersVisualStyles = false;
            this.dataGridView_seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_seller.Location = new System.Drawing.Point(382, 126);
            this.dataGridView_seller.Name = "dataGridView_seller";
            this.dataGridView_seller.RowHeadersVisible = false;
            this.dataGridView_seller.RowHeadersWidth = 62;
            this.dataGridView_seller.RowTemplate.Height = 28;
            this.dataGridView_seller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_seller.Size = new System.Drawing.Size(525, 470);
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
            this.dataGridView_seller.Click += new System.EventHandler(this.dataGridView_seller_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(264, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 58);
            this.label6.TabIndex = 15;
            this.label6.Text = "MANAGE SELLER";
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(153, 404);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(105, 56);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(264, 404);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(105, 56);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(42, 404);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(105, 56);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.TextBox_name.Location = new System.Drawing.Point(153, 180);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
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
            this.label_name.Location = new System.Drawing.Point(51, 181);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(73, 35);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Name";
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.BorderRadius = 18;
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.DefaultText = "";
            this.TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.DisabledState.Parent = this.TextBox_phone;
            this.TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.FocusedState.Parent = this.TextBox_phone;
            this.TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.HoverState.Parent = this.TextBox_phone;
            this.TextBox_phone.Location = new System.Drawing.Point(153, 289);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.PlaceholderText = "";
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.ShadowDecoration.Parent = this.TextBox_phone;
            this.TextBox_phone.Size = new System.Drawing.Size(200, 36);
            this.TextBox_phone.TabIndex = 5;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(50, 290);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(108, 35);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Phone no";
            // 
            // TextBox_age
            // 
            this.TextBox_age.BorderRadius = 18;
            this.TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_age.DefaultText = "";
            this.TextBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.DisabledState.Parent = this.TextBox_age;
            this.TextBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.FocusedState.Parent = this.TextBox_age;
            this.TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.HoverState.Parent = this.TextBox_age;
            this.TextBox_age.Location = new System.Drawing.Point(153, 236);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.PasswordChar = '\0';
            this.TextBox_age.PlaceholderText = "";
            this.TextBox_age.SelectedText = "";
            this.TextBox_age.ShadowDecoration.Parent = this.TextBox_age;
            this.TextBox_age.Size = new System.Drawing.Size(200, 36);
            this.TextBox_age.TabIndex = 3;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.ForeColor = System.Drawing.Color.White;
            this.label_age.Location = new System.Drawing.Point(52, 236);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(52, 35);
            this.label_age.TabIndex = 2;
            this.label_age.Text = "Age";
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
            this.TextBox_id.Location = new System.Drawing.Point(153, 127);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.ShadowDecoration.Parent = this.TextBox_id;
            this.TextBox_id.Size = new System.Drawing.Size(200, 36);
            this.TextBox_id.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(51, 127);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(39, 35);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_seller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private System.Windows.Forms.Label label_phone;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_age;
        private System.Windows.Forms.Label label_age;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label_id;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_pass;
        private System.Windows.Forms.Label label_password;
    }
}