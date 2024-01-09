namespace App
{
    partial class ModifyProduct
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
            min_lbl = new Label();
            max_lbl = new Label();
            price_cost_lbl = new Label();
            inventory_lbl = new Label();
            name_lbl = new Label();
            min_txtbox = new TextBox();
            max_txtbox = new TextBox();
            price_cost_txtbox = new TextBox();
            inventory_txtbox = new TextBox();
            name_txtbox = new TextBox();
            id_txtbox = new TextBox();
            id_lbl = new Label();
            save_btn = new Button();
            cancel_btn = new Button();
            label2 = new Label();
            delete_parts_btn = new Button();
            associated_parts_gridview = new DataGridView();
            label1 = new Label();
            add_parts_btn = new Button();
            candidate_parts_gridview = new DataGridView();
            products_search_btn = new Button();
            products_search_txtbox = new TextBox();
            Modify_products_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)associated_parts_gridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidate_parts_gridview).BeginInit();
            SuspendLayout();
            // 
            // min_lbl
            // 
            min_lbl.AutoSize = true;
            min_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            min_lbl.Location = new Point(223, 294);
            min_lbl.Name = "min_lbl";
            min_lbl.Size = new Size(34, 20);
            min_lbl.TabIndex = 67;
            min_lbl.Text = "Min";
            // 
            // max_lbl
            // 
            max_lbl.AutoSize = true;
            max_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            max_lbl.Location = new Point(67, 294);
            max_lbl.Name = "max_lbl";
            max_lbl.Size = new Size(37, 20);
            max_lbl.TabIndex = 66;
            max_lbl.Text = "Max";
            // 
            // price_cost_lbl
            // 
            price_cost_lbl.AutoSize = true;
            price_cost_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            price_cost_lbl.Location = new Point(20, 256);
            price_cost_lbl.Name = "price_cost_lbl";
            price_cost_lbl.Size = new Size(84, 20);
            price_cost_lbl.TabIndex = 65;
            price_cost_lbl.Text = "Price / Cost";
            // 
            // inventory_lbl
            // 
            inventory_lbl.AutoSize = true;
            inventory_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_lbl.Location = new Point(34, 218);
            inventory_lbl.Name = "inventory_lbl";
            inventory_lbl.Size = new Size(70, 20);
            inventory_lbl.TabIndex = 64;
            inventory_lbl.Text = "Inventory";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.Location = new Point(55, 180);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(49, 20);
            name_lbl.TabIndex = 63;
            name_lbl.Text = "Name";
            // 
            // min_txtbox
            // 
            min_txtbox.Location = new Point(281, 291);
            min_txtbox.Name = "min_txtbox";
            min_txtbox.Size = new Size(77, 23);
            min_txtbox.TabIndex = 62;
            // 
            // max_txtbox
            // 
            max_txtbox.Location = new Point(129, 291);
            max_txtbox.Name = "max_txtbox";
            max_txtbox.Size = new Size(77, 23);
            max_txtbox.TabIndex = 61;
            // 
            // price_cost_txtbox
            // 
            price_cost_txtbox.Location = new Point(129, 253);
            price_cost_txtbox.Name = "price_cost_txtbox";
            price_cost_txtbox.Size = new Size(131, 23);
            price_cost_txtbox.TabIndex = 60;
            // 
            // inventory_txtbox
            // 
            inventory_txtbox.Location = new Point(129, 215);
            inventory_txtbox.Name = "inventory_txtbox";
            inventory_txtbox.Size = new Size(131, 23);
            inventory_txtbox.TabIndex = 59;
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(129, 177);
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(131, 23);
            name_txtbox.TabIndex = 58;
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(129, 139);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.ReadOnly = true;
            id_txtbox.Size = new Size(131, 23);
            id_txtbox.TabIndex = 57;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            id_lbl.Location = new Point(80, 142);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(24, 20);
            id_lbl.TabIndex = 56;
            id_lbl.Text = "ID";
            // 
            // save_btn
            // 
            save_btn.Location = new Point(745, 530);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(75, 40);
            save_btn.TabIndex = 55;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(847, 530);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(75, 40);
            cancel_btn.TabIndex = 54;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 264);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 53;
            label2.Text = "Parts Associated with this Product";
            // 
            // delete_parts_btn
            // 
            delete_parts_btn.Location = new Point(847, 466);
            delete_parts_btn.Name = "delete_parts_btn";
            delete_parts_btn.Size = new Size(75, 40);
            delete_parts_btn.TabIndex = 52;
            delete_parts_btn.Text = "Delete";
            delete_parts_btn.UseVisualStyleBackColor = true;
            delete_parts_btn.Click += delete_parts_btn_Click;
            // 
            // associated_parts_gridview
            // 
            associated_parts_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associated_parts_gridview.Location = new Point(451, 293);
            associated_parts_gridview.Name = "associated_parts_gridview";
            associated_parts_gridview.RowTemplate.Height = 25;
            associated_parts_gridview.Size = new Size(525, 150);
            associated_parts_gridview.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 45);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 50;
            label1.Text = "All candidate Parts";
            // 
            // add_parts_btn
            // 
            add_parts_btn.Location = new Point(847, 247);
            add_parts_btn.Name = "add_parts_btn";
            add_parts_btn.Size = new Size(75, 40);
            add_parts_btn.TabIndex = 49;
            add_parts_btn.Text = "Add";
            add_parts_btn.UseVisualStyleBackColor = true;
            add_parts_btn.Click += add_parts_btn_Click;
            // 
            // candidate_parts_gridview
            // 
            candidate_parts_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidate_parts_gridview.Location = new Point(451, 74);
            candidate_parts_gridview.Name = "candidate_parts_gridview";
            candidate_parts_gridview.RowTemplate.Height = 25;
            candidate_parts_gridview.Size = new Size(525, 150);
            candidate_parts_gridview.TabIndex = 48;
            // 
            // products_search_btn
            // 
            products_search_btn.Location = new Point(646, 20);
            products_search_btn.Name = "products_search_btn";
            products_search_btn.Size = new Size(75, 23);
            products_search_btn.TabIndex = 47;
            products_search_btn.Text = "Search";
            products_search_btn.UseVisualStyleBackColor = true;
            products_search_btn.Click += products_search_btn_Click;
            // 
            // products_search_txtbox
            // 
            products_search_txtbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            products_search_txtbox.Location = new Point(745, 13);
            products_search_txtbox.Name = "products_search_txtbox";
            products_search_txtbox.Size = new Size(231, 35);
            products_search_txtbox.TabIndex = 46;
            // 
            // Modify_products_lbl
            // 
            Modify_products_lbl.AutoSize = true;
            Modify_products_lbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Modify_products_lbl.Location = new Point(8, 13);
            Modify_products_lbl.Name = "Modify_products_lbl";
            Modify_products_lbl.Size = new Size(163, 30);
            Modify_products_lbl.TabIndex = 45;
            Modify_products_lbl.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 600);
            Controls.Add(min_lbl);
            Controls.Add(max_lbl);
            Controls.Add(price_cost_lbl);
            Controls.Add(inventory_lbl);
            Controls.Add(name_lbl);
            Controls.Add(min_txtbox);
            Controls.Add(max_txtbox);
            Controls.Add(price_cost_txtbox);
            Controls.Add(inventory_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(id_txtbox);
            Controls.Add(id_lbl);
            Controls.Add(save_btn);
            Controls.Add(cancel_btn);
            Controls.Add(label2);
            Controls.Add(delete_parts_btn);
            Controls.Add(associated_parts_gridview);
            Controls.Add(label1);
            Controls.Add(add_parts_btn);
            Controls.Add(candidate_parts_gridview);
            Controls.Add(products_search_btn);
            Controls.Add(products_search_txtbox);
            Controls.Add(Modify_products_lbl);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)associated_parts_gridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidate_parts_gridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label min_lbl;
        private Label max_lbl;
        private Label price_cost_lbl;
        private Label inventory_lbl;
        private Label name_lbl;
        private TextBox min_txtbox;
        private TextBox max_txtbox;
        private TextBox price_cost_txtbox;
        private TextBox inventory_txtbox;
        private TextBox name_txtbox;
        private TextBox id_txtbox;
        private Label id_lbl;
        private Button save_btn;
        private Button cancel_btn;
        private Label label2;
        private Button delete_parts_btn;
        private DataGridView associated_parts_gridview;
        private Label label1;
        private Button add_parts_btn;
        private DataGridView candidate_parts_gridview;
        private Button products_search_btn;
        private TextBox products_search_txtbox;
        private Label Modify_products_lbl;
    }
}