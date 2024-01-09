namespace App
{
    partial class addProduct
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
            products_search_btn = new Button();
            products_search_txtbox = new TextBox();
            products_lbl = new Label();
            candidate_parts_gridview = new DataGridView();
            add_parts_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            delete_parts_btn = new Button();
            associated_parts_gridview = new DataGridView();
            cancel_btn = new Button();
            save_btn = new Button();
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
            ((System.ComponentModel.ISupportInitialize)candidate_parts_gridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associated_parts_gridview).BeginInit();
            SuspendLayout();
            // 
            // products_search_btn
            // 
            products_search_btn.Location = new Point(643, 19);
            products_search_btn.Name = "products_search_btn";
            products_search_btn.Size = new Size(75, 23);
            products_search_btn.TabIndex = 11;
            products_search_btn.Text = "Search";
            products_search_btn.UseVisualStyleBackColor = true;
            products_search_btn.Click += products_search_btn_Click;
            // 
            // products_search_txtbox
            // 
            products_search_txtbox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            products_search_txtbox.Location = new Point(742, 12);
            products_search_txtbox.Name = "products_search_txtbox";
            products_search_txtbox.Size = new Size(231, 35);
            products_search_txtbox.TabIndex = 10;
            // 
            // products_lbl
            // 
            products_lbl.AutoSize = true;
            products_lbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            products_lbl.Location = new Point(5, 12);
            products_lbl.Name = "products_lbl";
            products_lbl.Size = new Size(135, 30);
            products_lbl.TabIndex = 9;
            products_lbl.Text = "Add Product";
            // 
            // candidate_parts_gridview
            // 
            candidate_parts_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidate_parts_gridview.Location = new Point(448, 73);
            candidate_parts_gridview.Name = "candidate_parts_gridview";
            candidate_parts_gridview.RowTemplate.Height = 25;
            candidate_parts_gridview.Size = new Size(525, 150);
            candidate_parts_gridview.TabIndex = 12;
            // 
            // add_parts_btn
            // 
            add_parts_btn.Location = new Point(844, 246);
            add_parts_btn.Name = "add_parts_btn";
            add_parts_btn.Size = new Size(75, 40);
            add_parts_btn.TabIndex = 13;
            add_parts_btn.Text = "Add";
            add_parts_btn.UseVisualStyleBackColor = true;
            add_parts_btn.Click += add_parts_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 44);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 14;
            label1.Text = "All candidate Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 263);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 17;
            label2.Text = "Parts Associated with this Product";
            // 
            // delete_parts_btn
            // 
            delete_parts_btn.Location = new Point(844, 465);
            delete_parts_btn.Name = "delete_parts_btn";
            delete_parts_btn.Size = new Size(75, 40);
            delete_parts_btn.TabIndex = 16;
            delete_parts_btn.Text = "Delete";
            delete_parts_btn.UseVisualStyleBackColor = true;
            delete_parts_btn.Click += delete_parts_btn_Click;
            // 
            // associated_parts_gridview
            // 
            associated_parts_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associated_parts_gridview.Location = new Point(448, 292);
            associated_parts_gridview.Name = "associated_parts_gridview";
            associated_parts_gridview.RowTemplate.Height = 25;
            associated_parts_gridview.Size = new Size(525, 150);
            associated_parts_gridview.TabIndex = 15;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(844, 529);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(75, 40);
            cancel_btn.TabIndex = 18;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(742, 529);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(75, 40);
            save_btn.TabIndex = 19;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // min_lbl
            // 
            min_lbl.AutoSize = true;
            min_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            min_lbl.Location = new Point(220, 293);
            min_lbl.Name = "min_lbl";
            min_lbl.Size = new Size(34, 20);
            min_lbl.TabIndex = 44;
            min_lbl.Text = "Min";
            // 
            // max_lbl
            // 
            max_lbl.AutoSize = true;
            max_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            max_lbl.Location = new Point(64, 293);
            max_lbl.Name = "max_lbl";
            max_lbl.Size = new Size(37, 20);
            max_lbl.TabIndex = 43;
            max_lbl.Text = "Max";
            // 
            // price_cost_lbl
            // 
            price_cost_lbl.AutoSize = true;
            price_cost_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            price_cost_lbl.Location = new Point(17, 255);
            price_cost_lbl.Name = "price_cost_lbl";
            price_cost_lbl.Size = new Size(84, 20);
            price_cost_lbl.TabIndex = 42;
            price_cost_lbl.Text = "Price / Cost";
            // 
            // inventory_lbl
            // 
            inventory_lbl.AutoSize = true;
            inventory_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_lbl.Location = new Point(31, 217);
            inventory_lbl.Name = "inventory_lbl";
            inventory_lbl.Size = new Size(70, 20);
            inventory_lbl.TabIndex = 41;
            inventory_lbl.Text = "Inventory";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.Location = new Point(52, 179);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(49, 20);
            name_lbl.TabIndex = 40;
            name_lbl.Text = "Name";
            // 
            // min_txtbox
            // 
            min_txtbox.Location = new Point(278, 290);
            min_txtbox.Name = "min_txtbox";
            min_txtbox.Size = new Size(77, 23);
            min_txtbox.TabIndex = 39;
            // 
            // max_txtbox
            // 
            max_txtbox.Location = new Point(126, 290);
            max_txtbox.Name = "max_txtbox";
            max_txtbox.Size = new Size(77, 23);
            max_txtbox.TabIndex = 38;
            // 
            // price_cost_txtbox
            // 
            price_cost_txtbox.Location = new Point(126, 252);
            price_cost_txtbox.Name = "price_cost_txtbox";
            price_cost_txtbox.Size = new Size(131, 23);
            price_cost_txtbox.TabIndex = 37;
            // 
            // inventory_txtbox
            // 
            inventory_txtbox.Location = new Point(126, 214);
            inventory_txtbox.Name = "inventory_txtbox";
            inventory_txtbox.Size = new Size(131, 23);
            inventory_txtbox.TabIndex = 36;
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(126, 176);
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(131, 23);
            name_txtbox.TabIndex = 35;
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(126, 138);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.ReadOnly = true;
            id_txtbox.Size = new Size(131, 23);
            id_txtbox.TabIndex = 34;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            id_lbl.Location = new Point(77, 141);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(24, 20);
            id_lbl.TabIndex = 33;
            id_lbl.Text = "ID";
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 581);
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
            Controls.Add(products_lbl);
            Name = "addProduct";
            Text = "addProduct";
            ((System.ComponentModel.ISupportInitialize)candidate_parts_gridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)associated_parts_gridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button products_search_btn;
        private TextBox products_search_txtbox;
        private Label products_lbl;
        private DataGridView candidate_parts_gridview;
        private Button add_parts_btn;
        private Label label1;
        private Label label2;
        private Button delete_parts_btn;
        private DataGridView associated_parts_gridview;
        private Button cancel_btn;
        private Button save_btn;
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
    }
}