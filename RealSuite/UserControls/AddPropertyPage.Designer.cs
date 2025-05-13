namespace RealSuite.UserControls
{
    partial class AddPropertyPage
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
            vejnavn_label = new Label();
            husnr_label = new Label();
            postnr_label = new Label();
            byggeår_label = new Label();
            kvm_label = new Label();
            sælger_label = new Label();
            pris_label = new Label();
            vurdering_label = new Label();
            ejendomsmælger_label = new Label();
            dato_label = new Label();
            vejnavn_textbox = new TextBox();
            husnr_textbox = new TextBox();
            zipcode_textbox = new TextBox();
            byggeår_textbox = new TextBox();
            kvm_textbox = new TextBox();
            pris_textbox = new TextBox();
            vurdering_textbox = new TextBox();
            ejendomsmægler_textbox = new TextBox();
            dato_datepicker = new DateTimePicker();
            tilføjsælger_button = new Button();
            sælger_textbox = new TextBox();
            solgt_label = new Label();
            solgt_checkbox = new CheckBox();
            streetname_checklabel = new Label();
            streetnumber_checklabel = new Label();
            zip_checkbox = new Label();
            buildyear_checkbox = new Label();
            squaremeter_checkbox = new Label();
            seller_checkbox = new Label();
            price_checkbox = new Label();
            realtor_checkbox = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // vejnavn_label
            // 
            vejnavn_label.AutoSize = true;
            vejnavn_label.Location = new Point(33, 52);
            vejnavn_label.Name = "vejnavn_label";
            vejnavn_label.Size = new Size(60, 20);
            vejnavn_label.TabIndex = 0;
            vejnavn_label.Text = "Vejnavn";
            // 
            // husnr_label
            // 
            husnr_label.AutoSize = true;
            husnr_label.Location = new Point(33, 99);
            husnr_label.Name = "husnr_label";
            husnr_label.Size = new Size(89, 20);
            husnr_label.TabIndex = 1;
            husnr_label.Text = "Husnummer";
            // 
            // postnr_label
            // 
            postnr_label.AutoSize = true;
            postnr_label.Location = new Point(33, 144);
            postnr_label.Name = "postnr_label";
            postnr_label.Size = new Size(91, 20);
            postnr_label.TabIndex = 2;
            postnr_label.Text = "Postnummer";
            // 
            // byggeår_label
            // 
            byggeår_label.AutoSize = true;
            byggeår_label.Location = new Point(33, 188);
            byggeår_label.Name = "byggeår_label";
            byggeår_label.Size = new Size(64, 20);
            byggeår_label.TabIndex = 3;
            byggeår_label.Text = "Byggeår";
            // 
            // kvm_label
            // 
            kvm_label.AutoSize = true;
            kvm_label.Location = new Point(33, 232);
            kvm_label.Name = "kvm_label";
            kvm_label.Size = new Size(98, 20);
            kvm_label.TabIndex = 4;
            kvm_label.Text = "Kvadratmeter";
            // 
            // sælger_label
            // 
            sælger_label.AutoSize = true;
            sælger_label.Location = new Point(33, 274);
            sælger_label.Name = "sælger_label";
            sælger_label.Size = new Size(55, 20);
            sælger_label.TabIndex = 5;
            sælger_label.Text = "Sælger";
            // 
            // pris_label
            // 
            pris_label.AutoSize = true;
            pris_label.Location = new Point(33, 316);
            pris_label.Name = "pris_label";
            pris_label.Size = new Size(32, 20);
            pris_label.TabIndex = 6;
            pris_label.Text = "Pris";
            // 
            // vurdering_label
            // 
            vurdering_label.AutoSize = true;
            vurdering_label.Location = new Point(554, 92);
            vurdering_label.Name = "vurdering_label";
            vurdering_label.Size = new Size(74, 20);
            vurdering_label.TabIndex = 7;
            vurdering_label.Text = "Vurdering";
            // 
            // ejendomsmælger_label
            // 
            ejendomsmælger_label.AutoSize = true;
            ejendomsmælger_label.Location = new Point(33, 401);
            ejendomsmælger_label.Name = "ejendomsmælger_label";
            ejendomsmælger_label.Size = new Size(125, 20);
            ejendomsmælger_label.TabIndex = 8;
            ejendomsmælger_label.Text = "Ejendomsmægler";
            // 
            // dato_label
            // 
            dato_label.AutoSize = true;
            dato_label.Location = new Point(33, 440);
            dato_label.Name = "dato_label";
            dato_label.Size = new Size(42, 20);
            dato_label.TabIndex = 9;
            dato_label.Text = "Dato";
            // 
            // vejnavn_textbox
            // 
            vejnavn_textbox.Location = new Point(165, 45);
            vejnavn_textbox.Name = "vejnavn_textbox";
            vejnavn_textbox.Size = new Size(125, 27);
            vejnavn_textbox.TabIndex = 1;
            vejnavn_textbox.TextChanged += vejnavn_textbox_TextChanged;
            vejnavn_textbox.KeyPress += HandleLetter_KeyPress;
            // 
            // husnr_textbox
            // 
            husnr_textbox.Location = new Point(165, 92);
            husnr_textbox.Name = "husnr_textbox";
            husnr_textbox.Size = new Size(125, 27);
            husnr_textbox.TabIndex = 2;
            husnr_textbox.TextChanged += husnr_textbox_TextChanged;
            husnr_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // zipcode_textbox
            // 
            zipcode_textbox.Location = new Point(165, 140);
            zipcode_textbox.Name = "zipcode_textbox";
            zipcode_textbox.Size = new Size(125, 27);
            zipcode_textbox.TabIndex = 3;
            zipcode_textbox.TextChanged += zipcode_textbox_TextChanged;
            zipcode_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // byggeår_textbox
            // 
            byggeår_textbox.Location = new Point(165, 184);
            byggeår_textbox.Name = "byggeår_textbox";
            byggeår_textbox.Size = new Size(125, 27);
            byggeår_textbox.TabIndex = 4;
            byggeår_textbox.TextChanged += byggeår_textbox_TextChanged;
            byggeår_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // kvm_textbox
            // 
            kvm_textbox.Location = new Point(165, 228);
            kvm_textbox.Name = "kvm_textbox";
            kvm_textbox.Size = new Size(125, 27);
            kvm_textbox.TabIndex = 5;
            kvm_textbox.TextChanged += kvm_textbox_TextChanged;
            kvm_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // pris_textbox
            // 
            pris_textbox.Location = new Point(165, 312);
            pris_textbox.Name = "pris_textbox";
            pris_textbox.Size = new Size(125, 27);
            pris_textbox.TabIndex = 7;
            pris_textbox.TextChanged += pris_textbox_TextChanged;
            pris_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // vurdering_textbox
            // 
            vurdering_textbox.Enabled = false;
            vurdering_textbox.Location = new Point(634, 89);
            vurdering_textbox.Name = "vurdering_textbox";
            vurdering_textbox.ReadOnly = true;
            vurdering_textbox.Size = new Size(125, 27);
            vurdering_textbox.TabIndex = 0;
            // 
            // ejendomsmægler_textbox
            // 
            ejendomsmægler_textbox.Location = new Point(165, 397);
            ejendomsmægler_textbox.Name = "ejendomsmægler_textbox";
            ejendomsmægler_textbox.Size = new Size(125, 27);
            ejendomsmægler_textbox.TabIndex = 8;
            ejendomsmægler_textbox.TextChanged += ejendomsmægler_textbox_TextChanged;
            // 
            // dato_datepicker
            // 
            dato_datepicker.Location = new Point(165, 440);
            dato_datepicker.Name = "dato_datepicker";
            dato_datepicker.Size = new Size(250, 27);
            dato_datepicker.TabIndex = 9;
            // 
            // tilføjsælger_button
            // 
            tilføjsælger_button.Location = new Point(675, 501);
            tilføjsælger_button.Name = "tilføjsælger_button";
            tilføjsælger_button.Size = new Size(94, 29);
            tilføjsælger_button.TabIndex = 11;
            tilføjsælger_button.Text = "Tilføj";
            tilføjsælger_button.UseVisualStyleBackColor = true;
            tilføjsælger_button.Click += tilføjsælger_button_Click;
            // 
            // sælger_textbox
            // 
            sælger_textbox.Location = new Point(165, 269);
            sælger_textbox.Name = "sælger_textbox";
            sælger_textbox.Size = new Size(125, 27);
            sælger_textbox.TabIndex = 6;
            sælger_textbox.TextChanged += sælger_textbox_TextChanged;
            // 
            // solgt_label
            // 
            solgt_label.AutoSize = true;
            solgt_label.Location = new Point(33, 492);
            solgt_label.Name = "solgt_label";
            solgt_label.Size = new Size(44, 20);
            solgt_label.TabIndex = 21;
            solgt_label.Text = "Solgt";
            // 
            // solgt_checkbox
            // 
            solgt_checkbox.AutoSize = true;
            solgt_checkbox.Location = new Point(97, 492);
            solgt_checkbox.Name = "solgt_checkbox";
            solgt_checkbox.Size = new Size(81, 24);
            solgt_checkbox.TabIndex = 10;
            solgt_checkbox.Text = "Er solgt";
            solgt_checkbox.UseVisualStyleBackColor = true;
            // 
            // streetname_checklabel
            // 
            streetname_checklabel.AutoSize = true;
            streetname_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetname_checklabel.ForeColor = Color.Red;
            streetname_checklabel.Location = new Point(305, 49);
            streetname_checklabel.Name = "streetname_checklabel";
            streetname_checklabel.Size = new Size(25, 24);
            streetname_checklabel.TabIndex = 22;
            streetname_checklabel.Text = "O";
            // 
            // streetnumber_checklabel
            // 
            streetnumber_checklabel.AutoSize = true;
            streetnumber_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetnumber_checklabel.ForeColor = Color.Red;
            streetnumber_checklabel.Location = new Point(305, 96);
            streetnumber_checklabel.Name = "streetnumber_checklabel";
            streetnumber_checklabel.Size = new Size(25, 24);
            streetnumber_checklabel.TabIndex = 23;
            streetnumber_checklabel.Text = "O";
            // 
            // zip_checkbox
            // 
            zip_checkbox.AutoSize = true;
            zip_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            zip_checkbox.ForeColor = Color.Red;
            zip_checkbox.Location = new Point(305, 144);
            zip_checkbox.Name = "zip_checkbox";
            zip_checkbox.Size = new Size(25, 24);
            zip_checkbox.TabIndex = 24;
            zip_checkbox.Text = "O";
            // 
            // buildyear_checkbox
            // 
            buildyear_checkbox.AutoSize = true;
            buildyear_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buildyear_checkbox.ForeColor = Color.Red;
            buildyear_checkbox.Location = new Point(305, 185);
            buildyear_checkbox.Name = "buildyear_checkbox";
            buildyear_checkbox.Size = new Size(25, 24);
            buildyear_checkbox.TabIndex = 25;
            buildyear_checkbox.Text = "O";
            // 
            // squaremeter_checkbox
            // 
            squaremeter_checkbox.AutoSize = true;
            squaremeter_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            squaremeter_checkbox.ForeColor = Color.Red;
            squaremeter_checkbox.Location = new Point(305, 228);
            squaremeter_checkbox.Name = "squaremeter_checkbox";
            squaremeter_checkbox.Size = new Size(25, 24);
            squaremeter_checkbox.TabIndex = 26;
            squaremeter_checkbox.Text = "O";
            // 
            // seller_checkbox
            // 
            seller_checkbox.AutoSize = true;
            seller_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            seller_checkbox.ForeColor = Color.Red;
            seller_checkbox.Location = new Point(305, 270);
            seller_checkbox.Name = "seller_checkbox";
            seller_checkbox.Size = new Size(25, 24);
            seller_checkbox.TabIndex = 27;
            seller_checkbox.Text = "O";
            // 
            // price_checkbox
            // 
            price_checkbox.AutoSize = true;
            price_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            price_checkbox.ForeColor = Color.Red;
            price_checkbox.Location = new Point(305, 316);
            price_checkbox.Name = "price_checkbox";
            price_checkbox.Size = new Size(25, 24);
            price_checkbox.TabIndex = 28;
            price_checkbox.Text = "O";
            // 
            // realtor_checkbox
            // 
            realtor_checkbox.AutoSize = true;
            realtor_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            realtor_checkbox.ForeColor = Color.Red;
            realtor_checkbox.Location = new Point(305, 397);
            realtor_checkbox.Name = "realtor_checkbox";
            realtor_checkbox.Size = new Size(25, 24);
            realtor_checkbox.TabIndex = 30;
            realtor_checkbox.Text = "O";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(573, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 31;
            // 
            // AddPropertyPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(realtor_checkbox);
            Controls.Add(price_checkbox);
            Controls.Add(seller_checkbox);
            Controls.Add(squaremeter_checkbox);
            Controls.Add(buildyear_checkbox);
            Controls.Add(zip_checkbox);
            Controls.Add(streetnumber_checklabel);
            Controls.Add(streetname_checklabel);
            Controls.Add(solgt_checkbox);
            Controls.Add(solgt_label);
            Controls.Add(sælger_textbox);
            Controls.Add(tilføjsælger_button);
            Controls.Add(dato_datepicker);
            Controls.Add(ejendomsmægler_textbox);
            Controls.Add(vurdering_textbox);
            Controls.Add(pris_textbox);
            Controls.Add(kvm_textbox);
            Controls.Add(byggeår_textbox);
            Controls.Add(zipcode_textbox);
            Controls.Add(husnr_textbox);
            Controls.Add(vejnavn_textbox);
            Controls.Add(dato_label);
            Controls.Add(ejendomsmælger_label);
            Controls.Add(vurdering_label);
            Controls.Add(pris_label);
            Controls.Add(sælger_label);
            Controls.Add(kvm_label);
            Controls.Add(byggeår_label);
            Controls.Add(postnr_label);
            Controls.Add(husnr_label);
            Controls.Add(vejnavn_label);
            Name = "AddPropertyPage";
            Size = new Size(928, 603);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vejnavn_label;
        private Label husnr_label;
        private Label postnr_label;
        private Label byggeår_label;
        private Label kvm_label;
        private Label sælger_label;
        private Label pris_label;
        private Label vurdering_label;
        private Label ejendomsmælger_label;
        private Label dato_label;
        private TextBox vejnavn_textbox;
        private TextBox husnr_textbox;
        private TextBox zipcode_textbox;
        private TextBox byggeår_textbox;
        private TextBox kvm_textbox;
        private TextBox pris_textbox;
        private TextBox vurdering_textbox;
        private TextBox ejendomsmægler_textbox;
        private DateTimePicker dato_datepicker;
        private Button tilføjsælger_button;
        private TextBox sælger_textbox;
        private Label solgt_label;
        private CheckBox solgt_checkbox;
        private Label streetname_checklabel;
        private Label streetnumber_checklabel;
        private Label zip_checkbox;
        private Label buildyear_checkbox;
        private Label squaremeter_checkbox;
        private Label seller_checkbox;
        private Label price_checkbox;
        private Label realtor_checkbox;
        private DataGridView dataGridView1;
    }
}
