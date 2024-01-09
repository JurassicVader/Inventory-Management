namespace App
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
            title_lbl = new Label();
            parts_grid_view = new DataGridView();
            parts_lbl = new Label();
            parts_search_txtbox = new TextBox();
            parts_search_btn = new Button();
            products_search_btn = new Button();
            products_search_txtbox = new TextBox();
            products_lbl = new Label();
            products_grid_view = new DataGridView();
            parts_add_btn = new Button();
            parts_modify_btn = new Button();
            parts_delete_btn = new Button();
            products_delete_btn = new Button();
            products_modify_btn = new Button();
            products_add_btn = new Button();
            EXIT_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)parts_grid_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)products_grid_view).BeginInit();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            title_lbl.Location = new Point(12, 9);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(401, 37);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Inventory Management System";
            // 
            // parts_grid_view
            // 
            parts_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parts_grid_view.Location = new Point(43, 165);
            parts_grid_view.Name = "parts_grid_view";
            parts_grid_view.RowTemplate.Height = 25;
            parts_grid_view.Size = new Size(621, 272);
            parts_grid_view.TabIndex = 1;
            // 
            // parts_lbl
            // 
            parts_lbl.AutoSize = true;
            parts_lbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            parts_lbl.Location = new Point(43, 119);
            parts_lbl.Name = "parts_lbl";
            parts_lbl.Size = new Size(61, 30);
            parts_lbl.TabIndex = 2;
            parts_lbl.Text = "Parts";
            // 
            // parts_search_txtbox
            // 
            parts_search_txtbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            parts_search_txtbox.Location = new Point(433, 116);
            parts_search_txtbox.Name = "parts_search_txtbox";
            parts_search_txtbox.Size = new Size(231, 35);
            parts_search_txtbox.TabIndex = 3;
            // 
            // parts_search_btn
            // 
            parts_search_btn.Location = new Point(338, 119);
            parts_search_btn.Name = "parts_search_btn";
            parts_search_btn.Size = new Size(75, 23);
            parts_search_btn.TabIndex = 4;
            parts_search_btn.Text = "Search";
            parts_search_btn.UseVisualStyleBackColor = true;
            parts_search_btn.Click += parts_search_btn_Click;
            // 
            // products_search_btn
            // 
            products_search_btn.Location = new Point(1127, 119);
            products_search_btn.Name = "products_search_btn";
            products_search_btn.Size = new Size(75, 23);
            products_search_btn.TabIndex = 8;
            products_search_btn.Text = "Search";
            products_search_btn.UseVisualStyleBackColor = true;
            products_search_btn.Click += products_search_btn_Click;
            // 
            // products_search_txtbox
            // 
            products_search_txtbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            products_search_txtbox.Location = new Point(1222, 116);
            products_search_txtbox.Name = "products_search_txtbox";
            products_search_txtbox.Size = new Size(231, 35);
            products_search_txtbox.TabIndex = 7;
            // 
            // products_lbl
            // 
            products_lbl.AutoSize = true;
            products_lbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            products_lbl.Location = new Point(832, 119);
            products_lbl.Name = "products_lbl";
            products_lbl.Size = new Size(98, 30);
            products_lbl.TabIndex = 6;
            products_lbl.Text = "Products";
            // 
            // products_grid_view
            // 
            products_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            products_grid_view.Location = new Point(832, 165);
            products_grid_view.Name = "products_grid_view";
            products_grid_view.RowTemplate.Height = 25;
            products_grid_view.Size = new Size(621, 272);
            products_grid_view.TabIndex = 5;
            // 
            // parts_add_btn
            // 
            parts_add_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            parts_add_btn.Location = new Point(391, 462);
            parts_add_btn.Name = "parts_add_btn";
            parts_add_btn.Size = new Size(75, 40);
            parts_add_btn.TabIndex = 9;
            parts_add_btn.Text = "Add";
            parts_add_btn.UseVisualStyleBackColor = true;
            parts_add_btn.Click += parts_add_btn_Click;
            // 
            // parts_modify_btn
            // 
            parts_modify_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            parts_modify_btn.Location = new Point(487, 462);
            parts_modify_btn.Name = "parts_modify_btn";
            parts_modify_btn.Size = new Size(75, 40);
            parts_modify_btn.TabIndex = 10;
            parts_modify_btn.Text = "Modify";
            parts_modify_btn.UseVisualStyleBackColor = true;
            parts_modify_btn.Click += parts_modify_btn_Click;
            // 
            // parts_delete_btn
            // 
            parts_delete_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            parts_delete_btn.Location = new Point(580, 462);
            parts_delete_btn.Name = "parts_delete_btn";
            parts_delete_btn.Size = new Size(75, 40);
            parts_delete_btn.TabIndex = 11;
            parts_delete_btn.Text = "Delete";
            parts_delete_btn.UseVisualStyleBackColor = true;
            parts_delete_btn.Click += parts_delete_btn_Click;
            // 
            // products_delete_btn
            // 
            products_delete_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            products_delete_btn.Location = new Point(1372, 462);
            products_delete_btn.Name = "products_delete_btn";
            products_delete_btn.Size = new Size(75, 40);
            products_delete_btn.TabIndex = 14;
            products_delete_btn.Text = "Delete";
            products_delete_btn.UseVisualStyleBackColor = true;
            products_delete_btn.Click += products_delete_btn_Click;
            // 
            // products_modify_btn
            // 
            products_modify_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            products_modify_btn.Location = new Point(1279, 462);
            products_modify_btn.Name = "products_modify_btn";
            products_modify_btn.Size = new Size(75, 40);
            products_modify_btn.TabIndex = 13;
            products_modify_btn.Text = "Modify";
            products_modify_btn.UseVisualStyleBackColor = true;
            products_modify_btn.Click += products_modify_btn_Click;
            // 
            // products_add_btn
            // 
            products_add_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            products_add_btn.Location = new Point(1183, 462);
            products_add_btn.Name = "products_add_btn";
            products_add_btn.Size = new Size(75, 40);
            products_add_btn.TabIndex = 12;
            products_add_btn.Text = "Add";
            products_add_btn.UseVisualStyleBackColor = true;
            products_add_btn.Click += products_add_btn_Click;
            // 
            // EXIT_btn
            // 
            EXIT_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EXIT_btn.Location = new Point(1372, 567);
            EXIT_btn.Name = "EXIT_btn";
            EXIT_btn.Size = new Size(75, 40);
            EXIT_btn.TabIndex = 15;
            EXIT_btn.Text = "Exit";
            EXIT_btn.UseVisualStyleBackColor = true;
            EXIT_btn.Click += EXIT_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 737);
            Controls.Add(EXIT_btn);
            Controls.Add(products_delete_btn);
            Controls.Add(products_modify_btn);
            Controls.Add(products_add_btn);
            Controls.Add(parts_delete_btn);
            Controls.Add(parts_modify_btn);
            Controls.Add(parts_add_btn);
            Controls.Add(products_search_btn);
            Controls.Add(products_search_txtbox);
            Controls.Add(products_lbl);
            Controls.Add(products_grid_view);
            Controls.Add(parts_search_btn);
            Controls.Add(parts_search_txtbox);
            Controls.Add(parts_lbl);
            Controls.Add(parts_grid_view);
            Controls.Add(title_lbl);
            Name = "Form1";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)parts_grid_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)products_grid_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private DataGridView parts_grid_view;
        private Label parts_lbl;
        private TextBox parts_search_txtbox;
        private Button parts_search_btn;
        private Button products_search_btn;
        private TextBox products_search_txtbox;
        private Label products_lbl;
        private DataGridView products_grid_view;
        private Button parts_add_btn;
        private Button parts_modify_btn;
        private Button parts_delete_btn;
        private Button products_delete_btn;
        private Button products_modify_btn;
        private Button products_add_btn;
        private Button EXIT_btn;
    }
}