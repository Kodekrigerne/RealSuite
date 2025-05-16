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
            pris_label = new Label();
            vejnavn_textbox = new TextBox();
            husnr_textbox = new TextBox();
            zipcode_textbox = new TextBox();
            byggeår_textbox = new TextBox();
            kvm_textbox = new TextBox();
            ejendomsmæglerID_textbox = new TextBox();
            dato_datepicker = new DateTimePicker();
            tilføjbolig_button = new Button();
            sælgerID_textbox = new TextBox();
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
            vurderingKr_label = new Label();
            panel2 = new Panel();
            label1 = new Label();
            listedDateFromLabel = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel8 = new Panel();
            label7 = new Label();
            panel9 = new Panel();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
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
            addSellerGrid.Location = new Point(450, 222);
            addSellerGrid.Margin = new Padding(3, 2, 3, 2);
            addSellerGrid.MultiSelect = false;
            addSellerGrid.Name = "addSellerGrid";
            addSellerGrid.ReadOnly = true;
            addSellerGrid.RowHeadersVisible = false;
            addSellerGrid.RowHeadersWidth = 51;
            addSellerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            addSellerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addSellerGrid.Size = new Size(350, 217);
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
            addSellerButton.BackColor = Color.FromArgb(170, 212, 255);
            addSellerButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addSellerButton.ForeColor = Color.White;
            addSellerButton.Location = new Point(14, 11);
            addSellerButton.Margin = new Padding(3, 2, 3, 2);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(142, 43);
            addSellerButton.TabIndex = 6;
            addSellerButton.Text = "Tilføj sælger";
            addSellerButton.UseVisualStyleBackColor = false;
            addSellerButton.Click += addSellerButton_Click;
            // 
            // vejnavn_label
            // 
            vejnavn_label.AutoSize = true;
            vejnavn_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            vejnavn_label.ForeColor = Color.White;
            vejnavn_label.Location = new Point(15, 12);
            vejnavn_label.Name = "vejnavn_label";
            vejnavn_label.Size = new Size(58, 17);
            vejnavn_label.TabIndex = 0;
            vejnavn_label.Text = "Vejnavn";
            // 
            // husnr_label
            // 
            husnr_label.AutoSize = true;
            husnr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            husnr_label.ForeColor = Color.White;
            husnr_label.Location = new Point(156, 12);
            husnr_label.Name = "husnr_label";
            husnr_label.Size = new Size(84, 17);
            husnr_label.TabIndex = 1;
            husnr_label.Text = "Husnummer";
            // 
            // postnr_label
            // 
            postnr_label.AutoSize = true;
            postnr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            postnr_label.ForeColor = Color.White;
            postnr_label.Location = new Point(267, 10);
            postnr_label.Name = "postnr_label";
            postnr_label.Size = new Size(87, 17);
            postnr_label.TabIndex = 2;
            postnr_label.Text = "Postnummer";
            // 
            // byggeår_label
            // 
            byggeår_label.AutoSize = true;
            byggeår_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            byggeår_label.ForeColor = Color.White;
            byggeår_label.Location = new Point(15, 13);
            byggeår_label.Name = "byggeår_label";
            byggeår_label.Size = new Size(58, 17);
            byggeår_label.TabIndex = 3;
            byggeår_label.Text = "Byggeår";
            // 
            // kvm_label
            // 
            kvm_label.AutoSize = true;
            kvm_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            kvm_label.ForeColor = Color.White;
            kvm_label.Location = new Point(129, 10);
            kvm_label.Name = "kvm_label";
            kvm_label.Size = new Size(91, 17);
            kvm_label.TabIndex = 4;
            kvm_label.Text = "Kvadratmeter";
            // 
            // pris_label
            // 
            pris_label.AutoSize = true;
            pris_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            pris_label.ForeColor = Color.White;
            pris_label.Location = new Point(8, 10);
            pris_label.Name = "pris_label";
            pris_label.Size = new Size(31, 17);
            pris_label.TabIndex = 6;
            pris_label.Text = "Pris";
            // 
            // vejnavn_textbox
            // 
            vejnavn_textbox.Font = new Font("Microsoft YaHei", 9.75F);
            vejnavn_textbox.Location = new Point(13, 31);
            vejnavn_textbox.Margin = new Padding(3, 2, 3, 2);
            vejnavn_textbox.Name = "vejnavn_textbox";
            vejnavn_textbox.Size = new Size(110, 25);
            vejnavn_textbox.TabIndex = 1;
            vejnavn_textbox.TextChanged += vejnavn_textbox_TextChanged;
            vejnavn_textbox.KeyPress += HandleLetter_KeyPress;
            // 
            // husnr_textbox
            // 
            husnr_textbox.Font = new Font("Microsoft YaHei", 9.75F);
            husnr_textbox.Location = new Point(158, 31);
            husnr_textbox.Margin = new Padding(3, 2, 3, 2);
            husnr_textbox.MaxLength = 4;
            husnr_textbox.Name = "husnr_textbox";
            husnr_textbox.Size = new Size(82, 25);
            husnr_textbox.TabIndex = 2;
            husnr_textbox.TextChanged += husnr_textbox_TextChanged;
            husnr_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // zipcode_textbox
            // 
            zipcode_textbox.Font = new Font("Microsoft YaHei", 9.75F);
            zipcode_textbox.Location = new Point(269, 31);
            zipcode_textbox.Margin = new Padding(3, 2, 3, 2);
            zipcode_textbox.MaxLength = 4;
            zipcode_textbox.Name = "zipcode_textbox";
            zipcode_textbox.Size = new Size(85, 25);
            zipcode_textbox.TabIndex = 3;
            zipcode_textbox.TextChanged += zipcode_textbox_TextChanged;
            zipcode_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // byggeår_textbox
            // 
            byggeår_textbox.Font = new Font("Microsoft YaHei", 9.75F);
            byggeår_textbox.Location = new Point(16, 32);
            byggeår_textbox.Margin = new Padding(3, 2, 3, 2);
            byggeår_textbox.MaxLength = 4;
            byggeår_textbox.Name = "byggeår_textbox";
            byggeår_textbox.Size = new Size(78, 25);
            byggeår_textbox.TabIndex = 4;
            byggeår_textbox.TextChanged += byggeår_textbox_TextChanged;
            byggeår_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // kvm_textbox
            // 
            kvm_textbox.Font = new Font("Microsoft YaHei", 9.75F);
            kvm_textbox.Location = new Point(129, 32);
            kvm_textbox.Margin = new Padding(3, 2, 3, 2);
            kvm_textbox.MaxLength = 5;
            kvm_textbox.Name = "kvm_textbox";
            kvm_textbox.Size = new Size(91, 25);
            kvm_textbox.TabIndex = 5;
            kvm_textbox.TextChanged += kvm_textbox_TextChanged;
            kvm_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // ejendomsmæglerID_textbox
            // 
            ejendomsmæglerID_textbox.Enabled = false;
            ejendomsmæglerID_textbox.Font = new Font("Microsoft YaHei", 9F);
            ejendomsmæglerID_textbox.Location = new Point(8, 7);
            ejendomsmæglerID_textbox.Margin = new Padding(3, 2, 3, 2);
            ejendomsmæglerID_textbox.Name = "ejendomsmæglerID_textbox";
            ejendomsmæglerID_textbox.ReadOnly = true;
            ejendomsmæglerID_textbox.Size = new Size(43, 23);
            ejendomsmæglerID_textbox.TabIndex = 8;
            ejendomsmæglerID_textbox.TabStop = false;
            ejendomsmæglerID_textbox.Text = "1000";
            ejendomsmæglerID_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // dato_datepicker
            // 
            dato_datepicker.Format = DateTimePickerFormat.Short;
            dato_datepicker.Location = new Point(14, 16);
            dato_datepicker.Margin = new Padding(3, 2, 3, 2);
            dato_datepicker.Name = "dato_datepicker";
            dato_datepicker.Size = new Size(110, 23);
            dato_datepicker.TabIndex = 8;
            // 
            // tilføjbolig_button
            // 
            tilføjbolig_button.Enabled = false;
            tilføjbolig_button.Location = new Point(760, 529);
            tilføjbolig_button.Name = "tilføjbolig_button";
            tilføjbolig_button.Size = new Size(94, 29);
            tilføjbolig_button.TabIndex = 12;
            tilføjbolig_button.Text = "Tilføj";
            tilføjbolig_button.UseVisualStyleBackColor = true;
            tilføjbolig_button.Click += tilføjbolig_button_Click;
            // 
            // sælgerID_textbox
            // 
            sælgerID_textbox.BackColor = Color.PowderBlue;
            sælgerID_textbox.BorderStyle = BorderStyle.FixedSingle;
            sælgerID_textbox.Enabled = false;
            sælgerID_textbox.ForeColor = Color.White;
            sælgerID_textbox.Location = new Point(162, 24);
            sælgerID_textbox.Margin = new Padding(3, 2, 3, 2);
            sælgerID_textbox.Name = "sælgerID_textbox";
            sælgerID_textbox.ReadOnly = true;
            sælgerID_textbox.Size = new Size(44, 23);
            sælgerID_textbox.TabIndex = 6;
            sælgerID_textbox.TabStop = false;
            sælgerID_textbox.TextAlign = HorizontalAlignment.Center;
            sælgerID_textbox.TextChanged += sælger_textbox_TextChanged;
            // 
            // solgt_checkbox
            // 
            solgt_checkbox.AutoSize = true;
            solgt_checkbox.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            solgt_checkbox.ForeColor = Color.White;
            solgt_checkbox.Location = new Point(13, 8);
            solgt_checkbox.Margin = new Padding(3, 2, 3, 2);
            solgt_checkbox.Name = "solgt_checkbox";
            solgt_checkbox.Size = new Size(78, 23);
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
            streetname_checklabel.Location = new Point(122, 35);
            streetname_checklabel.Name = "streetname_checklabel";
            streetname_checklabel.Size = new Size(21, 20);
            streetname_checklabel.TabIndex = 22;
            streetname_checklabel.Text = "O";
            streetname_checklabel.Visible = false;
            // 
            // streetnumber_checklabel
            // 
            streetnumber_checklabel.AutoSize = true;
            streetnumber_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetnumber_checklabel.ForeColor = Color.Red;
            streetnumber_checklabel.Location = new Point(239, 35);
            streetnumber_checklabel.Name = "streetnumber_checklabel";
            streetnumber_checklabel.Size = new Size(21, 20);
            streetnumber_checklabel.TabIndex = 23;
            streetnumber_checklabel.Text = "O";
            streetnumber_checklabel.Visible = false;
            // 
            // zip_checkbox
            // 
            zip_checkbox.AutoSize = true;
            zip_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            zip_checkbox.ForeColor = Color.Red;
            zip_checkbox.Location = new Point(353, 35);
            zip_checkbox.Name = "zip_checkbox";
            zip_checkbox.Size = new Size(21, 20);
            zip_checkbox.TabIndex = 24;
            zip_checkbox.Text = "O";
            zip_checkbox.Visible = false;
            // 
            // buildyear_checkbox
            // 
            buildyear_checkbox.AutoSize = true;
            buildyear_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buildyear_checkbox.ForeColor = Color.Red;
            buildyear_checkbox.Location = new Point(93, 36);
            buildyear_checkbox.Name = "buildyear_checkbox";
            buildyear_checkbox.Size = new Size(21, 20);
            buildyear_checkbox.TabIndex = 25;
            buildyear_checkbox.Text = "O";
            buildyear_checkbox.Visible = false;
            // 
            // squaremeter_checkbox
            // 
            squaremeter_checkbox.AutoSize = true;
            squaremeter_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            squaremeter_checkbox.ForeColor = Color.Red;
            squaremeter_checkbox.Location = new Point(218, 35);
            squaremeter_checkbox.Name = "squaremeter_checkbox";
            squaremeter_checkbox.Size = new Size(21, 20);
            squaremeter_checkbox.TabIndex = 26;
            squaremeter_checkbox.Text = "O";
            squaremeter_checkbox.Visible = false;
            // 
            // seller_checkbox
            // 
            seller_checkbox.AutoSize = true;
            seller_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            seller_checkbox.ForeColor = Color.Red;
            seller_checkbox.Location = new Point(302, 27);
            seller_checkbox.Name = "seller_checkbox";
            seller_checkbox.Size = new Size(21, 20);
            seller_checkbox.TabIndex = 27;
            seller_checkbox.Text = "O";
            seller_checkbox.Visible = false;
            // 
            // price_checkbox
            // 
            price_checkbox.AutoSize = true;
            price_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            price_checkbox.ForeColor = Color.Red;
            price_checkbox.Location = new Point(140, 36);
            price_checkbox.Name = "price_checkbox";
            price_checkbox.Size = new Size(21, 20);
            price_checkbox.TabIndex = 28;
            price_checkbox.Text = "O";
            price_checkbox.Visible = false;
            // 
            // sælgernavn_textbox
            // 
            sælgernavn_textbox.BackColor = Color.PowderBlue;
            sælgernavn_textbox.BorderStyle = BorderStyle.FixedSingle;
            sælgernavn_textbox.Enabled = false;
            sælgernavn_textbox.ForeColor = Color.White;
            sælgernavn_textbox.Location = new Point(212, 24);
            sælgernavn_textbox.Margin = new Padding(3, 2, 3, 2);
            sælgernavn_textbox.Name = "sælgernavn_textbox";
            sælgernavn_textbox.ReadOnly = true;
            sælgernavn_textbox.Size = new Size(92, 23);
            sælgernavn_textbox.TabIndex = 31;
            sælgernavn_textbox.TabStop = false;
            // 
            // pris_textbox
            // 
            pris_textbox.Font = new Font("Microsoft YaHei", 9.75F);
            pris_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            pris_textbox.Location = new Point(8, 31);
            pris_textbox.Margin = new Padding(3, 2, 3, 2);
            pris_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            pris_textbox.Name = "pris_textbox";
            pris_textbox.Size = new Size(110, 25);
            pris_textbox.TabIndex = 7;
            pris_textbox.TextAlign = HorizontalAlignment.Right;
            pris_textbox.ThousandsSeparator = true;
            pris_textbox.ValueChanged += pris_textbox_ValueChanged;
            // 
            // kr_label
            // 
            kr_label.AutoSize = true;
            kr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            kr_label.ForeColor = Color.White;
            kr_label.Location = new Point(119, 38);
            kr_label.Name = "kr_label";
            kr_label.Size = new Size(23, 17);
            kr_label.TabIndex = 33;
            kr_label.Text = "kr.";
            // 
            // ejendomsmægler_textbox
            // 
            ejendomsmægler_textbox.Enabled = false;
            ejendomsmægler_textbox.Font = new Font("Microsoft YaHei", 9F);
            ejendomsmægler_textbox.Location = new Point(8, 34);
            ejendomsmægler_textbox.Margin = new Padding(3, 2, 3, 2);
            ejendomsmægler_textbox.Name = "ejendomsmægler_textbox";
            ejendomsmægler_textbox.ReadOnly = true;
            ejendomsmægler_textbox.Size = new Size(121, 23);
            ejendomsmægler_textbox.TabIndex = 34;
            ejendomsmægler_textbox.TabStop = false;
            ejendomsmægler_textbox.Text = "Maria Thodegaard";
            // 
            // solgtdato_dateTimePicker
            // 
            solgtdato_dateTimePicker.CalendarFont = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solgtdato_dateTimePicker.CustomFormat = "";
            solgtdato_dateTimePicker.Format = DateTimePickerFormat.Short;
            solgtdato_dateTimePicker.Location = new Point(124, 40);
            solgtdato_dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            solgtdato_dateTimePicker.Name = "solgtdato_dateTimePicker";
            solgtdato_dateTimePicker.ShowUpDown = true;
            solgtdato_dateTimePicker.Size = new Size(87, 23);
            solgtdato_dateTimePicker.TabIndex = 10;
            solgtdato_dateTimePicker.Visible = false;
            // 
            // solgtdato_label
            // 
            solgtdato_label.AutoSize = true;
            solgtdato_label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            solgtdato_label.ForeColor = Color.White;
            solgtdato_label.Location = new Point(8, 40);
            solgtdato_label.Name = "solgtdato_label";
            solgtdato_label.Size = new Size(115, 19);
            solgtdato_label.TabIndex = 36;
            solgtdato_label.Text = "Vælg salgsdato:";
            solgtdato_label.Visible = false;
            // 
            // vurdering_button
            // 
            vurdering_button.BackColor = Color.FromArgb(159, 192, 255);
            vurdering_button.Enabled = false;
            vurdering_button.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vurdering_button.ForeColor = Color.White;
            vurdering_button.Location = new Point(12, 8);
            vurdering_button.Margin = new Padding(3, 2, 3, 2);
            vurdering_button.Name = "vurdering_button";
            vurdering_button.Size = new Size(149, 37);
            vurdering_button.TabIndex = 11;
            vurdering_button.Text = "Få vurdering";
            vurdering_button.UseVisualStyleBackColor = false;
            vurdering_button.Click += vurdering_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(269, 361);
            clear_button.Margin = new Padding(3, 2, 3, 2);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(55, 22);
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
            vurdering_textbox.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vurdering_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            vurdering_textbox.Location = new Point(14, 51);
            vurdering_textbox.Margin = new Padding(3, 2, 3, 2);
            vurdering_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            vurdering_textbox.Name = "vurdering_textbox";
            vurdering_textbox.ReadOnly = true;
            vurdering_textbox.Size = new Size(109, 21);
            vurdering_textbox.TabIndex = 39;
            vurdering_textbox.TextAlign = HorizontalAlignment.Right;
            vurdering_textbox.ThousandsSeparator = true;
            // 
            // vurderingKr_label
            // 
            vurderingKr_label.AutoSize = true;
            vurderingKr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vurderingKr_label.ForeColor = Color.White;
            vurderingKr_label.Location = new Point(126, 56);
            vurderingKr_label.Name = "vurderingKr_label";
            vurderingKr_label.Size = new Size(23, 17);
            vurderingKr_label.TabIndex = 41;
            vurderingKr_label.Text = "kr.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 221, 177);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listedDateFromLabel);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 118);
            panel2.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 131, 184);
            label1.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(449, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 19;
            label1.Text = "Yderligere";
            // 
            // listedDateFromLabel
            // 
            listedDateFromLabel.AutoSize = true;
            listedDateFromLabel.BackColor = Color.FromArgb(100, 131, 184);
            listedDateFromLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            listedDateFromLabel.ForeColor = Color.White;
            listedDateFromLabel.Location = new Point(24, 14);
            listedDateFromLabel.Name = "listedDateFromLabel";
            listedDateFromLabel.Size = new Size(157, 19);
            listedDateFromLabel.TabIndex = 18;
            listedDateFromLabel.Text = "Adresseoplysninger";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(110, 149, 219);
            panel4.Controls.Add(byggeår_label);
            panel4.Controls.Add(byggeår_textbox);
            panel4.Controls.Add(buildyear_checkbox);
            panel4.Controls.Add(kvm_textbox);
            panel4.Controls.Add(kvm_label);
            panel4.Controls.Add(squaremeter_checkbox);
            panel4.Location = new Point(449, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 66);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(110, 149, 219);
            panel3.Controls.Add(vejnavn_label);
            panel3.Controls.Add(vejnavn_textbox);
            panel3.Controls.Add(streetname_checklabel);
            panel3.Controls.Add(husnr_label);
            panel3.Controls.Add(husnr_textbox);
            panel3.Controls.Add(streetnumber_checklabel);
            panel3.Controls.Add(postnr_label);
            panel3.Controls.Add(zipcode_textbox);
            panel3.Controls.Add(zip_checkbox);
            panel3.Location = new Point(23, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 66);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(110, 149, 219);
            panel5.Controls.Add(pris_label);
            panel5.Controls.Add(pris_textbox);
            panel5.Controls.Add(kr_label);
            panel5.Controls.Add(price_checkbox);
            panel5.Location = new Point(24, 148);
            panel5.Name = "panel5";
            panel5.Size = new Size(166, 66);
            panel5.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(100, 131, 184);
            label2.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 129);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 20;
            label2.Text = "Opslagspris";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(110, 149, 219);
            panel6.Controls.Add(vurderingKr_label);
            panel6.Controls.Add(vurdering_textbox);
            panel6.Controls.Add(vurdering_button);
            panel6.Location = new Point(214, 146);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 80);
            panel6.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(100, 131, 184);
            label3.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(462, 129);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 42;
            label3.Text = "Sælger";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(110, 149, 219);
            panel7.Controls.Add(sælgerID_textbox);
            panel7.Controls.Add(sælgernavn_textbox);
            panel7.Controls.Add(seller_checkbox);
            panel7.Controls.Add(addSellerButton);
            panel7.Location = new Point(462, 148);
            panel7.Name = "panel7";
            panel7.Size = new Size(326, 66);
            panel7.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(100, 131, 184);
            label4.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 233);
            label4.Name = "label4";
            label4.Size = new Size(141, 19);
            label4.TabIndex = 46;
            label4.Text = "Ejendomsmægler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(100, 131, 184);
            label5.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(214, 129);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 47;
            label5.Text = "Prisvurdering";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 149, 219);
            panel1.Controls.Add(ejendomsmæglerID_textbox);
            panel1.Controls.Add(ejendomsmægler_textbox);
            panel1.Location = new Point(24, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 62);
            panel1.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(100, 131, 184);
            label6.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(214, 236);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 49;
            label6.Text = "Dato";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(110, 149, 219);
            panel8.Controls.Add(dato_datepicker);
            panel8.Location = new Point(214, 251);
            panel8.Name = "panel8";
            panel8.Size = new Size(149, 62);
            panel8.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(100, 131, 184);
            label7.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 333);
            label7.Name = "label7";
            label7.Size = new Size(133, 19);
            label7.TabIndex = 51;
            label7.Text = "Er boligen solgt?";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(110, 149, 219);
            panel9.Controls.Add(solgt_checkbox);
            panel9.Controls.Add(solgtdato_label);
            panel9.Controls.Add(solgtdato_dateTimePicker);
            panel9.Location = new Point(23, 352);
            panel9.Name = "panel9";
            panel9.Size = new Size(237, 71);
            panel9.TabIndex = 52;
            // 
            // AddPropertyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel6);
            Controls.Add(label2);
            Controls.Add(clear_button);
            Controls.Add(addSellerGrid);
            Controls.Add(tilføjbolig_button);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddPropertyPage";
            Size = new Size(812, 452);
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
        private Label pris_label;
        private TextBox vejnavn_textbox;
        private TextBox husnr_textbox;
        private TextBox zipcode_textbox;
        private TextBox byggeår_textbox;
        private TextBox kvm_textbox;
        private TextBox ejendomsmæglerID_textbox;
        private DateTimePicker dato_datepicker;
        private Button tilføjbolig_button;
        private TextBox sælgerID_textbox;
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
        private Label vurderingKr_label;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label listedDateFromLabel;
        private Label label2;
        private Panel panel6;
        private Label label3;
        private Panel panel7;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Panel panel8;
        private Label label7;
        private Panel panel9;
    }
}
