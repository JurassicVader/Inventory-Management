namespace App
{
    partial class AddPart
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
            title_lbl = new Label();
            inhouse_radiobtn = new RadioButton();
            outsourced_radiobtn = new RadioButton();
            id_lbl = new Label();
            id_txtbox = new TextBox();
            name_txtbox = new TextBox();
            inventory_txtbox = new TextBox();
            price_cost_txtbox = new TextBox();
            max_txtbox = new TextBox();
            min_txtbox = new TextBox();
            changable_txtbox = new TextBox();
            name_lbl = new Label();
            inventory_lbl = new Label();
            price_cost_lbl = new Label();
            max_lbl = new Label();
            min_lbl = new Label();
            changing_lbl = new Label();
            cancel_btn = new Button();
            save_btn = new Button();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title_lbl.Location = new Point(12, 9);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(87, 25);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Add Part";
            // 
            // inhouse_radiobtn
            // 
            inhouse_radiobtn.AutoSize = true;
            inhouse_radiobtn.Checked = true;
            inhouse_radiobtn.Location = new Point(147, 12);
            inhouse_radiobtn.Name = "inhouse_radiobtn";
            inhouse_radiobtn.Size = new Size(74, 19);
            inhouse_radiobtn.TabIndex = 1;
            inhouse_radiobtn.TabStop = true;
            inhouse_radiobtn.Text = "In-House";
            inhouse_radiobtn.UseVisualStyleBackColor = true;
            inhouse_radiobtn.CheckedChanged += inhouse_radiobtn_CheckedChanged;
            // 
            // outsourced_radiobtn
            // 
            outsourced_radiobtn.AutoSize = true;
            outsourced_radiobtn.Location = new Point(246, 12);
            outsourced_radiobtn.Name = "outsourced_radiobtn";
            outsourced_radiobtn.Size = new Size(87, 19);
            outsourced_radiobtn.TabIndex = 2;
            outsourced_radiobtn.Text = "Outsourced";
            outsourced_radiobtn.UseVisualStyleBackColor = true;
            outsourced_radiobtn.CheckedChanged += outsourced_radiobtn_CheckedChanged;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            id_lbl.Location = new Point(130, 84);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(24, 20);
            id_lbl.TabIndex = 3;
            id_lbl.Text = "ID";
            // 
            // id_txtbox
            // 
            id_txtbox.Location = new Point(179, 81);
            id_txtbox.Name = "id_txtbox";
            id_txtbox.ReadOnly = true;
            id_txtbox.Size = new Size(131, 23);
            id_txtbox.TabIndex = 4;
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(179, 119);
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(131, 23);
            name_txtbox.TabIndex = 5;
            // 
            // inventory_txtbox
            // 
            inventory_txtbox.Location = new Point(179, 157);
            inventory_txtbox.Name = "inventory_txtbox";
            inventory_txtbox.Size = new Size(131, 23);
            inventory_txtbox.TabIndex = 6;
            // 
            // price_cost_txtbox
            // 
            price_cost_txtbox.Location = new Point(179, 195);
            price_cost_txtbox.Name = "price_cost_txtbox";
            price_cost_txtbox.Size = new Size(131, 23);
            price_cost_txtbox.TabIndex = 7;
            // 
            // max_txtbox
            // 
            max_txtbox.Location = new Point(179, 233);
            max_txtbox.Name = "max_txtbox";
            max_txtbox.Size = new Size(77, 23);
            max_txtbox.TabIndex = 8;
            // 
            // min_txtbox
            // 
            min_txtbox.Location = new Point(331, 233);
            min_txtbox.Name = "min_txtbox";
            min_txtbox.Size = new Size(77, 23);
            min_txtbox.TabIndex = 9;
            // 
            // changable_txtbox
            // 
            changable_txtbox.Location = new Point(179, 271);
            changable_txtbox.Name = "changable_txtbox";
            changable_txtbox.Size = new Size(131, 23);
            changable_txtbox.TabIndex = 10;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.Location = new Point(105, 122);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(49, 20);
            name_lbl.TabIndex = 11;
            name_lbl.Text = "Name";
            // 
            // inventory_lbl
            // 
            inventory_lbl.AutoSize = true;
            inventory_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inventory_lbl.Location = new Point(84, 160);
            inventory_lbl.Name = "inventory_lbl";
            inventory_lbl.Size = new Size(70, 20);
            inventory_lbl.TabIndex = 12;
            inventory_lbl.Text = "Inventory";
            // 
            // price_cost_lbl
            // 
            price_cost_lbl.AutoSize = true;
            price_cost_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            price_cost_lbl.Location = new Point(70, 198);
            price_cost_lbl.Name = "price_cost_lbl";
            price_cost_lbl.Size = new Size(84, 20);
            price_cost_lbl.TabIndex = 13;
            price_cost_lbl.Text = "Price / Cost";
            // 
            // max_lbl
            // 
            max_lbl.AutoSize = true;
            max_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            max_lbl.Location = new Point(117, 236);
            max_lbl.Name = "max_lbl";
            max_lbl.Size = new Size(37, 20);
            max_lbl.TabIndex = 14;
            max_lbl.Text = "Max";
            // 
            // min_lbl
            // 
            min_lbl.AutoSize = true;
            min_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            min_lbl.Location = new Point(273, 236);
            min_lbl.Name = "min_lbl";
            min_lbl.Size = new Size(34, 20);
            min_lbl.TabIndex = 15;
            min_lbl.Text = "Min";
            // 
            // changing_lbl
            // 
            changing_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            changing_lbl.AutoSize = true;
            changing_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            changing_lbl.Location = new Point(43, 271);
            changing_lbl.Name = "changing_lbl";
            changing_lbl.Size = new Size(84, 20);
            changing_lbl.TabIndex = 16;
            changing_lbl.Text = "Machine ID";
            changing_lbl.TextAlign = ContentAlignment.TopRight;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(331, 332);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(77, 38);
            cancel_btn.TabIndex = 17;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Location = new Point(233, 332);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(77, 38);
            save_btn.TabIndex = 18;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(save_btn);
            Controls.Add(cancel_btn);
            Controls.Add(changing_lbl);
            Controls.Add(min_lbl);
            Controls.Add(max_lbl);
            Controls.Add(price_cost_lbl);
            Controls.Add(inventory_lbl);
            Controls.Add(name_lbl);
            Controls.Add(changable_txtbox);
            Controls.Add(min_txtbox);
            Controls.Add(max_txtbox);
            Controls.Add(price_cost_txtbox);
            Controls.Add(inventory_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(id_txtbox);
            Controls.Add(id_lbl);
            Controls.Add(outsourced_radiobtn);
            Controls.Add(inhouse_radiobtn);
            Controls.Add(title_lbl);
            Name = "AddPart";
            Text = "Add Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private RadioButton inhouse_radiobtn;
        private RadioButton outsourced_radiobtn;
        private Label id_lbl;
        private TextBox id_txtbox;
        private TextBox name_txtbox;
        private TextBox inventory_txtbox;
        private TextBox price_cost_txtbox;
        private TextBox max_txtbox;
        private TextBox min_txtbox;
        private TextBox changable_txtbox;
        private Label name_lbl;
        private Label inventory_lbl;
        private Label price_cost_lbl;
        private Label max_lbl;
        private Label min_lbl;
        private Label changing_lbl;
        private Button cancel_btn;
        private Button save_btn;
    }
}