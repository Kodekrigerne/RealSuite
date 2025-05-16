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
            addSellerGrid = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            addSellerButton = new Button();
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
            ejendomsmæglerID_textbox = new TextBox();
            dato_datepicker = new DateTimePicker();
            tilføjbolig_button = new Button();
            sælgerID_textbox = new TextBox();
            solgt_label = new Label();
            solgt_checkbox = new CheckBox();
            streetname_checklabel = new Label();
            streetnumber_checklabel = new Label();
            zip_checkbox = new Label();
            buildyear_checkbox = new Label();
            squaremeter_checkbox = new Label();
            seller_checkbox = new Label();
            price_checkbox = new Label();
            sælgernavn_textbox = new TextBox();
            pris_textbox = new NumericUpDown();
            kr_label = new Label();
            ejendomsmægler_textbox = new TextBox();
            solgtdato_dateTimePicker = new DateTimePicker();
            solgtdato_label = new Label();
            vurdering_button = new Button();
            clear_button = new Button();
            vurdering_textbox = new NumericUpDown();
            panel1 = new Panel();
            vurderingKr_label = new Label();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addSellerGrid
            // 
            addSellerGrid.AllowUserToAddRows = false;
            addSellerGrid.AllowUserToDeleteRows = false;
            addSellerGrid.AllowUserToResizeColumns = false;
            addSellerGrid.AllowUserToResizeRows = false;
            addSellerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addSellerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addSellerGrid.Cursor = Cursors.Hand;
            addSellerGrid.Location = new Point(1174, 237);
            addSellerGrid.Margin = new Padding(9, 6, 9, 6);
            addSellerGrid.MultiSelect = false;
            addSellerGrid.Name = "addSellerGrid";
            addSellerGrid.ReadOnly = true;
            addSellerGrid.RowHeadersVisible = false;
            addSellerGrid.RowHeadersWidth = 51;
            addSellerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            addSellerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addSellerGrid.Size = new Size(1074, 749);
            addSellerGrid.TabIndex = 1;
            addSellerGrid.CellDoubleClick += addSellerGrid_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // addSellerButton
            // 
            addSellerButton.Location = new Point(83, 736);
            addSellerButton.Margin = new Padding(9, 6, 9, 6);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(300, 70);
            addSellerButton.TabIndex = 6;
            addSellerButton.Text = "Tilføj sælger";
            addSellerButton.UseVisualStyleBackColor = true;
            addSellerButton.Click += addSellerButton_Click;
            // 
            // vejnavn_label
            // 
            vejnavn_label.AutoSize = true;
            vejnavn_label.Location = new Point(83, 125);
            vejnavn_label.Margin = new Padding(9, 0, 9, 0);
            vejnavn_label.Name = "vejnavn_label";
            vejnavn_label.Size = new Size(143, 48);
            vejnavn_label.TabIndex = 0;
            vejnavn_label.Text = "Vejnavn";
            // 
            // husnr_label
            // 
            husnr_label.AutoSize = true;
            husnr_label.Location = new Point(83, 237);
            husnr_label.Margin = new Padding(9, 0, 9, 0);
            husnr_label.Name = "husnr_label";
            husnr_label.Size = new Size(215, 48);
            husnr_label.TabIndex = 1;
            husnr_label.Text = "Husnummer";
            // 
            // postnr_label
            // 
            postnr_label.AutoSize = true;
            postnr_label.Location = new Point(83, 346);
            postnr_label.Margin = new Padding(9, 0, 9, 0);
            postnr_label.Name = "postnr_label";
            postnr_label.Size = new Size(221, 48);
            postnr_label.TabIndex = 2;
            postnr_label.Text = "Postnummer";
            // 
            // byggeår_label
            // 
            byggeår_label.AutoSize = true;
            byggeår_label.Location = new Point(83, 451);
            byggeår_label.Margin = new Padding(9, 0, 9, 0);
            byggeår_label.Name = "byggeår_label";
            byggeår_label.Size = new Size(150, 48);
            byggeår_label.TabIndex = 3;
            byggeår_label.Text = "Byggeår";
            // 
            // kvm_label
            // 
            kvm_label.AutoSize = true;
            kvm_label.Location = new Point(83, 557);
            kvm_label.Margin = new Padding(9, 0, 9, 0);
            kvm_label.Name = "kvm_label";
            kvm_label.Size = new Size(233, 48);
            kvm_label.TabIndex = 4;
            kvm_label.Text = "Kvadratmeter";
            // 
            // sælger_label
            // 
            sælger_label.AutoSize = true;
            sælger_label.Location = new Point(83, 659);
            sælger_label.Margin = new Padding(9, 0, 9, 0);
            sælger_label.Name = "sælger_label";
            sælger_label.Size = new Size(131, 48);
            sælger_label.TabIndex = 5;
            sælger_label.Text = "Sælger";
            // 
            // pris_label
            // 
            pris_label.AutoSize = true;
            pris_label.Location = new Point(83, 870);
            pris_label.Margin = new Padding(9, 0, 9, 0);
            pris_label.Name = "pris_label";
            pris_label.Size = new Size(77, 48);
            pris_label.TabIndex = 6;
            pris_label.Text = "Pris";
            // 
            // vurdering_label
            // 
            vurdering_label.AutoSize = true;
            vurdering_label.Location = new Point(1174, 109);
            vurdering_label.Margin = new Padding(9, 0, 9, 0);
            vurdering_label.Name = "vurdering_label";
            vurdering_label.Size = new Size(177, 48);
            vurdering_label.TabIndex = 7;
            vurdering_label.Text = "Vurdering";
            // 
            // ejendomsmælger_label
            // 
            ejendomsmælger_label.AutoSize = true;
            ejendomsmælger_label.Location = new Point(83, 963);
            ejendomsmælger_label.Margin = new Padding(9, 0, 9, 0);
            ejendomsmælger_label.Name = "ejendomsmælger_label";
            ejendomsmælger_label.Size = new Size(297, 48);
            ejendomsmælger_label.TabIndex = 8;
            ejendomsmælger_label.Text = "Ejendomsmægler";
            // 
            // dato_label
            // 
            dato_label.AutoSize = true;
            dato_label.Location = new Point(83, 1056);
            dato_label.Margin = new Padding(9, 0, 9, 0);
            dato_label.Name = "dato_label";
            dato_label.Size = new Size(96, 48);
            dato_label.TabIndex = 9;
            dato_label.Text = "Dato";
            // 
            // vejnavn_textbox
            // 
            vejnavn_textbox.Location = new Point(411, 109);
            vejnavn_textbox.Margin = new Padding(9, 6, 9, 6);
            vejnavn_textbox.Name = "vejnavn_textbox";
            vejnavn_textbox.Size = new Size(307, 55);
            vejnavn_textbox.TabIndex = 1;
            vejnavn_textbox.TextChanged += vejnavn_textbox_TextChanged;
            vejnavn_textbox.KeyPress += HandleLetter_KeyPress;
            // 
            // husnr_textbox
            // 
            husnr_textbox.Location = new Point(411, 221);
            husnr_textbox.Margin = new Padding(9, 6, 9, 6);
            husnr_textbox.MaxLength = 4;
            husnr_textbox.Name = "husnr_textbox";
            husnr_textbox.Size = new Size(307, 55);
            husnr_textbox.TabIndex = 2;
            husnr_textbox.TextChanged += husnr_textbox_TextChanged;
            husnr_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // zipcode_textbox
            // 
            zipcode_textbox.Location = new Point(411, 336);
            zipcode_textbox.Margin = new Padding(9, 6, 9, 6);
            zipcode_textbox.MaxLength = 4;
            zipcode_textbox.Name = "zipcode_textbox";
            zipcode_textbox.Size = new Size(307, 55);
            zipcode_textbox.TabIndex = 3;
            zipcode_textbox.TextChanged += zipcode_textbox_TextChanged;
            zipcode_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // byggeår_textbox
            // 
            byggeår_textbox.Location = new Point(411, 442);
            byggeår_textbox.Margin = new Padding(9, 6, 9, 6);
            byggeår_textbox.MaxLength = 4;
            byggeår_textbox.Name = "byggeår_textbox";
            byggeår_textbox.Size = new Size(307, 55);
            byggeår_textbox.TabIndex = 4;
            byggeår_textbox.TextChanged += byggeår_textbox_TextChanged;
            byggeår_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // kvm_textbox
            // 
            kvm_textbox.Location = new Point(411, 547);
            kvm_textbox.Margin = new Padding(9, 6, 9, 6);
            kvm_textbox.MaxLength = 5;
            kvm_textbox.Name = "kvm_textbox";
            kvm_textbox.Size = new Size(307, 55);
            kvm_textbox.TabIndex = 5;
            kvm_textbox.TextChanged += kvm_textbox_TextChanged;
            kvm_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // ejendomsmæglerID_textbox
            // 
            ejendomsmæglerID_textbox.Enabled = false;
            ejendomsmæglerID_textbox.Location = new Point(411, 954);
            ejendomsmæglerID_textbox.Margin = new Padding(9, 6, 9, 6);
            ejendomsmæglerID_textbox.Name = "ejendomsmæglerID_textbox";
            ejendomsmæglerID_textbox.ReadOnly = true;
            ejendomsmæglerID_textbox.Size = new Size(115, 55);
            ejendomsmæglerID_textbox.TabIndex = 8;
            ejendomsmæglerID_textbox.TabStop = false;
            ejendomsmæglerID_textbox.Text = "1000";
            ejendomsmæglerID_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // dato_datepicker
            // 
            dato_datepicker.Format = DateTimePickerFormat.Short;
            dato_datepicker.Location = new Point(411, 1056);
            dato_datepicker.Margin = new Padding(9, 6, 9, 6);
            dato_datepicker.Name = "dato_datepicker";
            dato_datepicker.Size = new Size(307, 55);
            dato_datepicker.TabIndex = 8;
            // 
            // tilføjbolig_button
            // 
            tilføjbolig_button.Enabled = false;
            tilføjbolig_button.Location = new Point(2171, 1693);
            tilføjbolig_button.Margin = new Padding(9, 10, 9, 10);
            tilføjbolig_button.Name = "tilføjbolig_button";
            tilføjbolig_button.Size = new Size(269, 93);
            tilføjbolig_button.TabIndex = 12;
            tilføjbolig_button.Text = "Tilføj";
            tilføjbolig_button.UseVisualStyleBackColor = true;
            tilføjbolig_button.Click += tilføjbolig_button_Click;
            // 
            // sælgerID_textbox
            // 
            sælgerID_textbox.Enabled = false;
            sælgerID_textbox.Location = new Point(411, 659);
            sælgerID_textbox.Margin = new Padding(9, 6, 9, 6);
            sælgerID_textbox.Name = "sælgerID_textbox";
            sælgerID_textbox.ReadOnly = true;
            sælgerID_textbox.Size = new Size(118, 55);
            sælgerID_textbox.TabIndex = 6;
            sælgerID_textbox.TabStop = false;
            sælgerID_textbox.TextAlign = HorizontalAlignment.Center;
            sælgerID_textbox.TextChanged += sælger_textbox_TextChanged;
            // 
            // solgt_label
            // 
            solgt_label.AutoSize = true;
            solgt_label.Location = new Point(83, 1181);
            solgt_label.Margin = new Padding(9, 0, 9, 0);
            solgt_label.Name = "solgt_label";
            solgt_label.Size = new Size(102, 48);
            solgt_label.TabIndex = 21;
            solgt_label.Text = "Solgt";
            // 
            // solgt_checkbox
            // 
            solgt_checkbox.AutoSize = true;
            solgt_checkbox.Location = new Point(243, 1181);
            solgt_checkbox.Margin = new Padding(9, 6, 9, 6);
            solgt_checkbox.Name = "solgt_checkbox";
            solgt_checkbox.Size = new Size(185, 52);
            solgt_checkbox.TabIndex = 9;
            solgt_checkbox.Text = "Er solgt";
            solgt_checkbox.UseVisualStyleBackColor = true;
            solgt_checkbox.CheckedChanged += solgt_checkbox_CheckedChanged;
            // 
            // streetname_checklabel
            // 
            streetname_checklabel.AutoSize = true;
            streetname_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetname_checklabel.ForeColor = Color.Red;
            streetname_checklabel.Location = new Point(763, 118);
            streetname_checklabel.Margin = new Padding(9, 0, 9, 0);
            streetname_checklabel.Name = "streetname_checklabel";
            streetname_checklabel.Size = new Size(61, 59);
            streetname_checklabel.TabIndex = 22;
            streetname_checklabel.Text = "O";
            streetname_checklabel.Visible = false;
            // 
            // streetnumber_checklabel
            // 
            streetnumber_checklabel.AutoSize = true;
            streetnumber_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetnumber_checklabel.ForeColor = Color.Red;
            streetnumber_checklabel.Location = new Point(763, 230);
            streetnumber_checklabel.Margin = new Padding(9, 0, 9, 0);
            streetnumber_checklabel.Name = "streetnumber_checklabel";
            streetnumber_checklabel.Size = new Size(61, 59);
            streetnumber_checklabel.TabIndex = 23;
            streetnumber_checklabel.Text = "O";
            streetnumber_checklabel.Visible = false;
            // 
            // zip_checkbox
            // 
            zip_checkbox.AutoSize = true;
            zip_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            zip_checkbox.ForeColor = Color.Red;
            zip_checkbox.Location = new Point(763, 346);
            zip_checkbox.Margin = new Padding(9, 0, 9, 0);
            zip_checkbox.Name = "zip_checkbox";
            zip_checkbox.Size = new Size(61, 59);
            zip_checkbox.TabIndex = 24;
            zip_checkbox.Text = "O";
            zip_checkbox.Visible = false;
            // 
            // buildyear_checkbox
            // 
            buildyear_checkbox.AutoSize = true;
            buildyear_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buildyear_checkbox.ForeColor = Color.Red;
            buildyear_checkbox.Location = new Point(763, 445);
            buildyear_checkbox.Margin = new Padding(9, 0, 9, 0);
            buildyear_checkbox.Name = "buildyear_checkbox";
            buildyear_checkbox.Size = new Size(61, 59);
            buildyear_checkbox.TabIndex = 25;
            buildyear_checkbox.Text = "O";
            buildyear_checkbox.Visible = false;
            // 
            // squaremeter_checkbox
            // 
            squaremeter_checkbox.AutoSize = true;
            squaremeter_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            squaremeter_checkbox.ForeColor = Color.Red;
            squaremeter_checkbox.Location = new Point(763, 547);
            squaremeter_checkbox.Margin = new Padding(9, 0, 9, 0);
            squaremeter_checkbox.Name = "squaremeter_checkbox";
            squaremeter_checkbox.Size = new Size(61, 59);
            squaremeter_checkbox.TabIndex = 26;
            squaremeter_checkbox.Text = "O";
            squaremeter_checkbox.Visible = false;
            // 
            // seller_checkbox
            // 
            seller_checkbox.AutoSize = true;
            seller_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            seller_checkbox.ForeColor = Color.Red;
            seller_checkbox.Location = new Point(909, 666);
            seller_checkbox.Margin = new Padding(9, 0, 9, 0);
            seller_checkbox.Name = "seller_checkbox";
            seller_checkbox.Size = new Size(61, 59);
            seller_checkbox.TabIndex = 27;
            seller_checkbox.Text = "O";
            seller_checkbox.Visible = false;
            // 
            // price_checkbox
            // 
            price_checkbox.AutoSize = true;
            price_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            price_checkbox.ForeColor = Color.Red;
            price_checkbox.Location = new Point(814, 870);
            price_checkbox.Margin = new Padding(9, 0, 9, 0);
            price_checkbox.Name = "price_checkbox";
            price_checkbox.Size = new Size(61, 59);
            price_checkbox.TabIndex = 28;
            price_checkbox.Text = "O";
            price_checkbox.Visible = false;
            // 
            // sælgernavn_textbox
            // 
            sælgernavn_textbox.Enabled = false;
            sælgernavn_textbox.Location = new Point(549, 659);
            sælgernavn_textbox.Margin = new Padding(9, 6, 9, 6);
            sælgernavn_textbox.Name = "sælgernavn_textbox";
            sælgernavn_textbox.ReadOnly = true;
            sælgernavn_textbox.Size = new Size(338, 55);
            sælgernavn_textbox.TabIndex = 31;
            sælgernavn_textbox.TabStop = false;
            // 
            // pris_textbox
            // 
            pris_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            pris_textbox.Location = new Point(411, 864);
            pris_textbox.Margin = new Padding(9, 6, 9, 6);
            pris_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            pris_textbox.Name = "pris_textbox";
            pris_textbox.Size = new Size(314, 55);
            pris_textbox.TabIndex = 7;
            pris_textbox.TextAlign = HorizontalAlignment.Right;
            pris_textbox.ThousandsSeparator = true;
            pris_textbox.ValueChanged += pris_textbox_ValueChanged;
            // 
            // kr_label
            // 
            kr_label.AutoSize = true;
            kr_label.Location = new Point(740, 870);
            kr_label.Margin = new Padding(9, 0, 9, 0);
            kr_label.Name = "kr_label";
            kr_label.Size = new Size(59, 48);
            kr_label.TabIndex = 33;
            kr_label.Text = "kr.";
            // 
            // ejendomsmægler_textbox
            // 
            ejendomsmægler_textbox.Enabled = false;
            ejendomsmægler_textbox.Location = new Point(549, 954);
            ejendomsmægler_textbox.Margin = new Padding(9, 6, 9, 6);
            ejendomsmægler_textbox.Name = "ejendomsmægler_textbox";
            ejendomsmægler_textbox.ReadOnly = true;
            ejendomsmægler_textbox.Size = new Size(338, 55);
            ejendomsmægler_textbox.TabIndex = 34;
            ejendomsmægler_textbox.TabStop = false;
            ejendomsmægler_textbox.Text = "Maria Thodegaard";
            // 
            // solgtdato_dateTimePicker
            // 
            solgtdato_dateTimePicker.CustomFormat = "";
            solgtdato_dateTimePicker.Format = DateTimePickerFormat.Short;
            solgtdato_dateTimePicker.Location = new Point(740, 1174);
            solgtdato_dateTimePicker.Margin = new Padding(9, 6, 9, 6);
            solgtdato_dateTimePicker.Name = "solgtdato_dateTimePicker";
            solgtdato_dateTimePicker.Size = new Size(307, 55);
            solgtdato_dateTimePicker.TabIndex = 10;
            solgtdato_dateTimePicker.Visible = false;
            // 
            // solgtdato_label
            // 
            solgtdato_label.AutoSize = true;
            solgtdato_label.Location = new Point(529, 1181);
            solgtdato_label.Margin = new Padding(9, 0, 9, 0);
            solgtdato_label.Name = "solgtdato_label";
            solgtdato_label.Size = new Size(184, 48);
            solgtdato_label.TabIndex = 36;
            solgtdato_label.Text = "Dato solgt";
            solgtdato_label.Visible = false;
            // 
            // vurdering_button
            // 
            vurdering_button.Enabled = false;
            vurdering_button.Location = new Point(1800, 106);
            vurdering_button.Margin = new Padding(9, 6, 9, 6);
            vurdering_button.Name = "vurdering_button";
            vurdering_button.Size = new Size(283, 70);
            vurdering_button.TabIndex = 11;
            vurdering_button.Text = "Få vurdering";
            vurdering_button.UseVisualStyleBackColor = true;
            vurdering_button.Click += vurdering_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(1629, 1270);
            clear_button.Margin = new Padding(9, 6, 9, 6);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(157, 70);
            clear_button.TabIndex = 13;
            clear_button.TabStop = false;
            clear_button.Text = "Ryd";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // vurdering_textbox
            // 
            vurdering_textbox.BackColor = SystemColors.Menu;
            vurdering_textbox.BorderStyle = BorderStyle.None;
            vurdering_textbox.Enabled = false;
            vurdering_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            vurdering_textbox.Location = new Point(-6, 3);
            vurdering_textbox.Margin = new Padding(9, 6, 9, 6);
            vurdering_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            vurdering_textbox.Name = "vurdering_textbox";
            vurdering_textbox.ReadOnly = true;
            vurdering_textbox.Size = new Size(360, 51);
            vurdering_textbox.TabIndex = 39;
            vurdering_textbox.TextAlign = HorizontalAlignment.Right;
            vurdering_textbox.ThousandsSeparator = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(vurdering_textbox);
            panel1.Location = new Point(1397, 109);
            panel1.Margin = new Padding(9, 6, 9, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 63);
            panel1.TabIndex = 40;
            // 
            // vurderingKr_label
            // 
            vurderingKr_label.AutoSize = true;
            vurderingKr_label.Location = new Point(1726, 115);
            vurderingKr_label.Margin = new Padding(9, 0, 9, 0);
            vurderingKr_label.Name = "vurderingKr_label";
            vurderingKr_label.Size = new Size(59, 48);
            vurderingKr_label.TabIndex = 41;
            vurderingKr_label.Text = "kr.";
            // 
            // AddPropertyPage
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vurderingKr_label);
            Controls.Add(panel1);
            Controls.Add(clear_button);
            Controls.Add(vurdering_button);
            Controls.Add(solgtdato_label);
            Controls.Add(solgtdato_dateTimePicker);
            Controls.Add(ejendomsmægler_textbox);
            Controls.Add(kr_label);
            Controls.Add(pris_textbox);
            Controls.Add(sælgernavn_textbox);
            Controls.Add(addSellerButton);
            Controls.Add(addSellerGrid);
            Controls.Add(price_checkbox);
            Controls.Add(seller_checkbox);
            Controls.Add(squaremeter_checkbox);
            Controls.Add(buildyear_checkbox);
            Controls.Add(zip_checkbox);
            Controls.Add(streetnumber_checklabel);
            Controls.Add(streetname_checklabel);
            Controls.Add(solgt_checkbox);
            Controls.Add(solgt_label);
            Controls.Add(sælgerID_textbox);
            Controls.Add(tilføjbolig_button);
            Controls.Add(dato_datepicker);
            Controls.Add(ejendomsmæglerID_textbox);
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
            Margin = new Padding(9, 6, 9, 6);
            Name = "AddPropertyPage";
            Size = new Size(2320, 1446);
            Click += AddPropertyPage_Click;
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label solgtdato_label;
        private DataGridView addSellerGrid;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button addSellerButton;
        private TextBox ejendomsmægler_textbox;

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
        private TextBox ejendomsmæglerID_textbox;
        private DateTimePicker dato_datepicker;
        private Button tilføjbolig_button;
        private TextBox sælgerID_textbox;
        private Label solgt_label;
        private CheckBox solgt_checkbox;
        private Label streetname_checklabel;
        private Label streetnumber_checklabel;
        private Label zip_checkbox;
        private Label buildyear_checkbox;
        private Label squaremeter_checkbox;
        private Label seller_checkbox;
        private Label price_checkbox;
        private DataGridView dataGridView1;
        private TextBox sælgernavn_textbox;
        private NumericUpDown pris_textbox;
        private Label kr_label;
        private DateTimePicker solgtdato_dateTimePicker;
        private Button vurdering_button;
        private Button clear_button;
        private NumericUpDown vurdering_textbox;
        private Panel panel1;
        private Label vurderingKr_label;
    }
}
