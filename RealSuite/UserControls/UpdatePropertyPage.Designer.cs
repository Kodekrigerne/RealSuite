using RealSuite.CustomControls;

namespace RealSuite.UserControls
{
    partial class UpdatePropertyPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            vurderingKr_label = new Label();
            panel1 = new Panel();
            vurdering_textbox = new NumericUpDown();
            tilbage_button = new Button();
            vurdering_button = new Button();
            solgtdato_label = new Label();
            solgtdato_dateTimePicker = new DateTimePicker();
            ejendomsmægler_textbox = new TextBox();
            kr_label = new Label();
            pris_textbox = new NumericUpDown();
            sælgernavn_textbox = new TextBox();
            addSellerButton = new Button();
            addSellerGrid = new RsDataGridView();
            price_checkbox = new Label();
            seller_checkbox = new Label();
            squaremeter_checkbox = new Label();
            buildyear_checkbox = new Label();
            zip_checkbox = new Label();
            streetnumber_checklabel = new Label();
            streetname_checklabel = new Label();
            solgt_checkbox = new CheckBox();
            solgt_label = new Label();
            sælgerID_textbox = new TextBox();
            opdater_button = new Button();
            dato_datepicker = new DateTimePicker();
            ejendomsmæglerID_textbox = new TextBox();
            kvm_textbox = new TextBox();
            byggeår_textbox = new TextBox();
            zipcode_textbox = new TextBox();
            husnr_textbox = new TextBox();
            vejnavn_textbox = new TextBox();
            dato_label = new Label();
            ejendomsmælger_label = new Label();
            vurdering_label = new Label();
            pris_label = new Label();
            sælger_label = new Label();
            kvm_label = new Label();
            byggeår_label = new Label();
            postnr_label = new Label();
            husnr_label = new Label();
            vejnavn_label = new Label();
            id_label = new Label();
            id_textbox = new TextBox();
            redigering_checkbox = new CheckBox();
            brugVurdering_button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).BeginInit();
            SuspendLayout();
            // 
            // vurderingKr_label
            // 
            vurderingKr_label.AutoSize = true;
            vurderingKr_label.Location = new Point(688, 58);
            vurderingKr_label.Name = "vurderingKr_label";
            vurderingKr_label.Size = new Size(24, 20);
            vurderingKr_label.TabIndex = 81;
            vurderingKr_label.Text = "kr.";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(vurdering_textbox);
            panel1.Location = new Point(557, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 27);
            panel1.TabIndex = 80;
            // 
            // vurdering_textbox
            // 
            vurdering_textbox.BackColor = SystemColors.Menu;
            vurdering_textbox.BorderStyle = BorderStyle.None;
            vurdering_textbox.Enabled = false;
            vurdering_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            vurdering_textbox.Location = new Point(-2, 1);
            vurdering_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            vurdering_textbox.Name = "vurdering_textbox";
            vurdering_textbox.ReadOnly = true;
            vurdering_textbox.Size = new Size(144, 23);
            vurdering_textbox.TabIndex = 39;
            vurdering_textbox.TextAlign = HorizontalAlignment.Right;
            vurdering_textbox.ThousandsSeparator = true;
            // 
            // tilbage_button
            // 
            tilbage_button.Location = new Point(833, 12);
            tilbage_button.Name = "tilbage_button";
            tilbage_button.Size = new Size(80, 29);
            tilbage_button.TabIndex = 67;
            tilbage_button.TabStop = false;
            tilbage_button.Text = "Tilbage";
            tilbage_button.UseVisualStyleBackColor = true;
            tilbage_button.Click += BackButton_Click;
            // 
            // vurdering_button
            // 
            vurdering_button.Enabled = false;
            vurdering_button.Location = new Point(718, 53);
            vurdering_button.Name = "vurdering_button";
            vurdering_button.Size = new Size(113, 29);
            vurdering_button.TabIndex = 65;
            vurdering_button.Text = "Få vurdering";
            vurdering_button.UseVisualStyleBackColor = true;
            vurdering_button.Click += vurdering_button_Click;
            // 
            // solgtdato_label
            // 
            solgtdato_label.AutoSize = true;
            solgtdato_label.Location = new Point(213, 514);
            solgtdato_label.Name = "solgtdato_label";
            solgtdato_label.Size = new Size(79, 20);
            solgtdato_label.TabIndex = 79;
            solgtdato_label.Text = "Dato solgt";
            solgtdato_label.Visible = false;
            // 
            // solgtdato_dateTimePicker
            // 
            solgtdato_dateTimePicker.CustomFormat = "";
            solgtdato_dateTimePicker.Enabled = false;
            solgtdato_dateTimePicker.Format = DateTimePickerFormat.Short;
            solgtdato_dateTimePicker.Location = new Point(298, 511);
            solgtdato_dateTimePicker.Name = "solgtdato_dateTimePicker";
            solgtdato_dateTimePicker.Size = new Size(125, 27);
            solgtdato_dateTimePicker.TabIndex = 64;
            solgtdato_dateTimePicker.Visible = false;
            // 
            // ejendomsmægler_textbox
            // 
            ejendomsmægler_textbox.Enabled = false;
            ejendomsmægler_textbox.Location = new Point(222, 420);
            ejendomsmægler_textbox.Name = "ejendomsmægler_textbox";
            ejendomsmægler_textbox.ReadOnly = true;
            ejendomsmægler_textbox.Size = new Size(138, 27);
            ejendomsmægler_textbox.TabIndex = 78;
            ejendomsmægler_textbox.TabStop = false;
            ejendomsmægler_textbox.Text = "Maria Thodegaard";
            // 
            // kr_label
            // 
            kr_label.AutoSize = true;
            kr_label.Location = new Point(298, 385);
            kr_label.Name = "kr_label";
            kr_label.Size = new Size(24, 20);
            kr_label.TabIndex = 77;
            kr_label.Text = "kr.";
            // 
            // pris_textbox
            // 
            pris_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            pris_textbox.Location = new Point(166, 382);
            pris_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            pris_textbox.Name = "pris_textbox";
            pris_textbox.Size = new Size(126, 27);
            pris_textbox.TabIndex = 57;
            pris_textbox.TextAlign = HorizontalAlignment.Right;
            pris_textbox.ThousandsSeparator = true;
            pris_textbox.ValueChanged += pris_textbox_ValueChanged;
            pris_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // sælgernavn_textbox
            // 
            sælgernavn_textbox.Enabled = false;
            sælgernavn_textbox.Location = new Point(222, 296);
            sælgernavn_textbox.Name = "sælgernavn_textbox";
            sælgernavn_textbox.ReadOnly = true;
            sælgernavn_textbox.Size = new Size(138, 27);
            sælgernavn_textbox.TabIndex = 76;
            sælgernavn_textbox.TabStop = false;
            // 
            // addSellerButton
            // 
            addSellerButton.Enabled = false;
            addSellerButton.Location = new Point(35, 329);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(120, 29);
            addSellerButton.TabIndex = 54;
            addSellerButton.Text = "Tilføj sælger";
            addSellerButton.UseVisualStyleBackColor = true;
            addSellerButton.Click += addSellerButton_Click;
            // 
            // addSellerGrid
            // 
            dataGridViewCellStyle1.NullValue = null;
            addSellerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            addSellerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            addSellerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            addSellerGrid.ColumnHeadersHeight = 4;
            addSellerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 221, 177);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            addSellerGrid.DefaultCellStyle = dataGridViewCellStyle3;
            addSellerGrid.Location = new Point(468, 99);
            addSellerGrid.Name = "addSellerGrid";
            addSellerGrid.ReadOnly = true;
            addSellerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            addSellerGrid.Size = new Size(430, 312);
            addSellerGrid.TabIndex = 45;
            addSellerGrid.CellDoubleClick += addSellerGrid_CellDoubleClick;
            // 
            // price_checkbox
            // 
            price_checkbox.AutoSize = true;
            price_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            price_checkbox.ForeColor = Color.LightGreen;
            price_checkbox.Location = new Point(328, 385);
            price_checkbox.Name = "price_checkbox";
            price_checkbox.Size = new Size(28, 24);
            price_checkbox.TabIndex = 75;
            price_checkbox.Text = "P";
            price_checkbox.Visible = false;
            // 
            // seller_checkbox
            // 
            seller_checkbox.AutoSize = true;
            seller_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            seller_checkbox.ForeColor = Color.LightGreen;
            seller_checkbox.Location = new Point(366, 299);
            seller_checkbox.Name = "seller_checkbox";
            seller_checkbox.Size = new Size(28, 24);
            seller_checkbox.TabIndex = 74;
            seller_checkbox.Text = "P";
            seller_checkbox.Visible = false;
            // 
            // squaremeter_checkbox
            // 
            squaremeter_checkbox.AutoSize = true;
            squaremeter_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            squaremeter_checkbox.ForeColor = Color.LightGreen;
            squaremeter_checkbox.Location = new Point(307, 250);
            squaremeter_checkbox.Name = "squaremeter_checkbox";
            squaremeter_checkbox.Size = new Size(28, 24);
            squaremeter_checkbox.TabIndex = 73;
            squaremeter_checkbox.Text = "P";
            squaremeter_checkbox.Visible = false;
            // 
            // buildyear_checkbox
            // 
            buildyear_checkbox.AutoSize = true;
            buildyear_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buildyear_checkbox.ForeColor = Color.LightGreen;
            buildyear_checkbox.Location = new Point(307, 207);
            buildyear_checkbox.Name = "buildyear_checkbox";
            buildyear_checkbox.Size = new Size(28, 24);
            buildyear_checkbox.TabIndex = 72;
            buildyear_checkbox.Text = "P";
            buildyear_checkbox.Visible = false;
            // 
            // zip_checkbox
            // 
            zip_checkbox.AutoSize = true;
            zip_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            zip_checkbox.ForeColor = Color.LightGreen;
            zip_checkbox.Location = new Point(307, 166);
            zip_checkbox.Name = "zip_checkbox";
            zip_checkbox.Size = new Size(28, 24);
            zip_checkbox.TabIndex = 71;
            zip_checkbox.Text = "P";
            zip_checkbox.Visible = false;
            // 
            // streetnumber_checklabel
            // 
            streetnumber_checklabel.AutoSize = true;
            streetnumber_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetnumber_checklabel.ForeColor = Color.LightGreen;
            streetnumber_checklabel.Location = new Point(307, 118);
            streetnumber_checklabel.Name = "streetnumber_checklabel";
            streetnumber_checklabel.Size = new Size(28, 24);
            streetnumber_checklabel.TabIndex = 70;
            streetnumber_checklabel.Text = "P";
            streetnumber_checklabel.Visible = false;
            // 
            // streetname_checklabel
            // 
            streetname_checklabel.AutoSize = true;
            streetname_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetname_checklabel.ForeColor = Color.LightGreen;
            streetname_checklabel.Location = new Point(307, 71);
            streetname_checklabel.Name = "streetname_checklabel";
            streetname_checklabel.Size = new Size(28, 24);
            streetname_checklabel.TabIndex = 69;
            streetname_checklabel.Text = "P";
            streetname_checklabel.Visible = false;
            // 
            // solgt_checkbox
            // 
            solgt_checkbox.AutoSize = true;
            solgt_checkbox.Enabled = false;
            solgt_checkbox.Location = new Point(99, 514);
            solgt_checkbox.Name = "solgt_checkbox";
            solgt_checkbox.Size = new Size(81, 24);
            solgt_checkbox.TabIndex = 63;
            solgt_checkbox.Text = "Er solgt";
            solgt_checkbox.UseVisualStyleBackColor = true;
            solgt_checkbox.CheckedChanged += solgt_checkbox_CheckedChanged;
            // 
            // solgt_label
            // 
            solgt_label.AutoSize = true;
            solgt_label.Location = new Point(35, 514);
            solgt_label.Name = "solgt_label";
            solgt_label.Size = new Size(44, 20);
            solgt_label.TabIndex = 68;
            solgt_label.Text = "Solgt";
            // 
            // sælgerID_textbox
            // 
            sælgerID_textbox.Enabled = false;
            sælgerID_textbox.Location = new Point(166, 296);
            sælgerID_textbox.Name = "sælgerID_textbox";
            sælgerID_textbox.ReadOnly = true;
            sælgerID_textbox.Size = new Size(50, 27);
            sælgerID_textbox.TabIndex = 56;
            sælgerID_textbox.TabStop = false;
            sælgerID_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // opdater_button
            // 
            opdater_button.Enabled = false;
            opdater_button.Location = new Point(758, 529);
            opdater_button.Name = "opdater_button";
            opdater_button.Size = new Size(94, 29);
            opdater_button.TabIndex = 66;
            opdater_button.Text = "Opdater";
            opdater_button.UseVisualStyleBackColor = true;
            opdater_button.Click += opdater_button_Click;
            // 
            // dato_datepicker
            // 
            dato_datepicker.Enabled = false;
            dato_datepicker.Format = DateTimePickerFormat.Short;
            dato_datepicker.Location = new Point(167, 462);
            dato_datepicker.Name = "dato_datepicker";
            dato_datepicker.Size = new Size(125, 27);
            dato_datepicker.TabIndex = 61;
            // 
            // ejendomsmæglerID_textbox
            // 
            ejendomsmæglerID_textbox.Enabled = false;
            ejendomsmæglerID_textbox.Location = new Point(167, 420);
            ejendomsmæglerID_textbox.Name = "ejendomsmæglerID_textbox";
            ejendomsmæglerID_textbox.ReadOnly = true;
            ejendomsmæglerID_textbox.Size = new Size(49, 27);
            ejendomsmæglerID_textbox.TabIndex = 60;
            ejendomsmæglerID_textbox.TabStop = false;
            ejendomsmæglerID_textbox.Text = "1000";
            ejendomsmæglerID_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // kvm_textbox
            // 
            kvm_textbox.Enabled = false;
            kvm_textbox.Location = new Point(167, 250);
            kvm_textbox.MaxLength = 5;
            kvm_textbox.Name = "kvm_textbox";
            kvm_textbox.Size = new Size(125, 27);
            kvm_textbox.TabIndex = 53;
            kvm_textbox.TextChanged += kvm_textbox_TextChanged;
            kvm_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // byggeår_textbox
            // 
            byggeår_textbox.Enabled = false;
            byggeår_textbox.Location = new Point(167, 206);
            byggeår_textbox.MaxLength = 4;
            byggeår_textbox.Name = "byggeår_textbox";
            byggeår_textbox.Size = new Size(125, 27);
            byggeår_textbox.TabIndex = 51;
            byggeår_textbox.TextChanged += byggeår_textbox_TextChanged;
            byggeår_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // zipcode_textbox
            // 
            zipcode_textbox.Enabled = false;
            zipcode_textbox.Location = new Point(167, 162);
            zipcode_textbox.MaxLength = 4;
            zipcode_textbox.Name = "zipcode_textbox";
            zipcode_textbox.Size = new Size(125, 27);
            zipcode_textbox.TabIndex = 49;
            zipcode_textbox.TextChanged += zipcode_textbox_TextChanged;
            zipcode_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // husnr_textbox
            // 
            husnr_textbox.Enabled = false;
            husnr_textbox.Location = new Point(167, 114);
            husnr_textbox.MaxLength = 4;
            husnr_textbox.Name = "husnr_textbox";
            husnr_textbox.Size = new Size(125, 27);
            husnr_textbox.TabIndex = 47;
            husnr_textbox.TextChanged += husnr_textbox_TextChanged;
            husnr_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // vejnavn_textbox
            // 
            vejnavn_textbox.Enabled = false;
            vejnavn_textbox.Location = new Point(167, 67);
            vejnavn_textbox.Name = "vejnavn_textbox";
            vejnavn_textbox.Size = new Size(125, 27);
            vejnavn_textbox.TabIndex = 43;
            vejnavn_textbox.TextChanged += vejnavn_textbox_TextChanged;
            vejnavn_textbox.KeyPress += HandleLetter_KeyPress;
            // 
            // dato_label
            // 
            dato_label.AutoSize = true;
            dato_label.Location = new Point(39, 467);
            dato_label.Name = "dato_label";
            dato_label.Size = new Size(109, 20);
            dato_label.TabIndex = 62;
            dato_label.Text = "Dato sat tilsalg";
            // 
            // ejendomsmælger_label
            // 
            ejendomsmælger_label.AutoSize = true;
            ejendomsmælger_label.Location = new Point(35, 423);
            ejendomsmælger_label.Name = "ejendomsmælger_label";
            ejendomsmælger_label.Size = new Size(125, 20);
            ejendomsmælger_label.TabIndex = 59;
            ejendomsmælger_label.Text = "Ejendomsmægler";
            // 
            // vurdering_label
            // 
            vurdering_label.AutoSize = true;
            vurdering_label.Location = new Point(476, 58);
            vurdering_label.Name = "vurdering_label";
            vurdering_label.Size = new Size(74, 20);
            vurdering_label.TabIndex = 58;
            vurdering_label.Text = "Vurdering";
            // 
            // pris_label
            // 
            pris_label.AutoSize = true;
            pris_label.Location = new Point(35, 384);
            pris_label.Name = "pris_label";
            pris_label.Size = new Size(32, 20);
            pris_label.TabIndex = 55;
            pris_label.Text = "Pris";
            // 
            // sælger_label
            // 
            sælger_label.AutoSize = true;
            sælger_label.Location = new Point(35, 296);
            sælger_label.Name = "sælger_label";
            sælger_label.Size = new Size(55, 20);
            sælger_label.TabIndex = 52;
            sælger_label.Text = "Sælger";
            // 
            // kvm_label
            // 
            kvm_label.AutoSize = true;
            kvm_label.Location = new Point(35, 254);
            kvm_label.Name = "kvm_label";
            kvm_label.Size = new Size(98, 20);
            kvm_label.TabIndex = 50;
            kvm_label.Text = "Kvadratmeter";
            // 
            // byggeår_label
            // 
            byggeår_label.AutoSize = true;
            byggeår_label.Location = new Point(35, 210);
            byggeår_label.Name = "byggeår_label";
            byggeår_label.Size = new Size(64, 20);
            byggeår_label.TabIndex = 48;
            byggeår_label.Text = "Byggeår";
            // 
            // postnr_label
            // 
            postnr_label.AutoSize = true;
            postnr_label.Location = new Point(35, 166);
            postnr_label.Name = "postnr_label";
            postnr_label.Size = new Size(91, 20);
            postnr_label.TabIndex = 46;
            postnr_label.Text = "Postnummer";
            // 
            // husnr_label
            // 
            husnr_label.AutoSize = true;
            husnr_label.Location = new Point(35, 121);
            husnr_label.Name = "husnr_label";
            husnr_label.Size = new Size(89, 20);
            husnr_label.TabIndex = 44;
            husnr_label.Text = "Husnummer";
            // 
            // vejnavn_label
            // 
            vejnavn_label.AutoSize = true;
            vejnavn_label.Location = new Point(35, 74);
            vejnavn_label.Name = "vejnavn_label";
            vejnavn_label.Size = new Size(60, 20);
            vejnavn_label.TabIndex = 42;
            vejnavn_label.Text = "Vejnavn";
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(39, 31);
            id_label.Name = "id_label";
            id_label.Size = new Size(22, 20);
            id_label.TabIndex = 82;
            id_label.Text = "Id";
            // 
            // id_textbox
            // 
            id_textbox.Enabled = false;
            id_textbox.Location = new Point(167, 31);
            id_textbox.Name = "id_textbox";
            id_textbox.Size = new Size(125, 27);
            id_textbox.TabIndex = 83;
            // 
            // redigering_checkbox
            // 
            redigering_checkbox.AutoSize = true;
            redigering_checkbox.Location = new Point(35, 556);
            redigering_checkbox.Name = "redigering_checkbox";
            redigering_checkbox.Size = new Size(150, 24);
            redigering_checkbox.TabIndex = 84;
            redigering_checkbox.Text = "Aktivér redigering";
            redigering_checkbox.UseVisualStyleBackColor = true;
            redigering_checkbox.CheckedChanged += redigering_checkbox_CheckedChanged;
            // 
            // brugVurdering_button
            // 
            brugVurdering_button.Location = new Point(605, 20);
            brugVurdering_button.Name = "brugVurdering_button";
            brugVurdering_button.Size = new Size(78, 29);
            brugVurdering_button.TabIndex = 85;
            brugVurdering_button.Text = "Brug";
            brugVurdering_button.UseVisualStyleBackColor = true;
            brugVurdering_button.Visible = false;
            brugVurdering_button.Click += brugVurdering_button_Click;
            // 
            // UpdatePropertyPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(brugVurdering_button);
            Controls.Add(redigering_checkbox);
            Controls.Add(id_textbox);
            Controls.Add(id_label);
            Controls.Add(vurderingKr_label);
            Controls.Add(panel1);
            Controls.Add(tilbage_button);
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
            Controls.Add(opdater_button);
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
            Name = "UpdatePropertyPage";
            Size = new Size(928, 603);
            Click += UpdatePropertyPage_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vurderingKr_label;
        private Panel panel1;
        private NumericUpDown vurdering_textbox;
        private Button tilbage_button;
        private Button vurdering_button;
        private Label solgtdato_label;
        private DateTimePicker solgtdato_dateTimePicker;
        private TextBox ejendomsmægler_textbox;
        private Label kr_label;
        private NumericUpDown pris_textbox;
        private TextBox sælgernavn_textbox;
        private Button addSellerButton;
        private Label price_checkbox;
        private Label seller_checkbox;
        private Label squaremeter_checkbox;
        private Label buildyear_checkbox;
        private Label zip_checkbox;
        private Label streetnumber_checklabel;
        private Label streetname_checklabel;
        private CheckBox solgt_checkbox;
        private Label solgt_label;
        private TextBox sælgerID_textbox;
        private Button opdater_button;
        private DateTimePicker dato_datepicker;
        private TextBox ejendomsmæglerID_textbox;
        private TextBox kvm_textbox;
        private TextBox byggeår_textbox;
        private TextBox zipcode_textbox;
        private TextBox husnr_textbox;
        private TextBox vejnavn_textbox;
        private Label dato_label;
        private Label ejendomsmælger_label;
        private Label vurdering_label;
        private Label pris_label;
        private Label sælger_label;
        private Label kvm_label;
        private Label byggeår_label;
        private Label postnr_label;
        private Label husnr_label;
        private Label vejnavn_label;
        private Label id_label;
        private TextBox id_textbox;
        private CheckBox redigering_checkbox;
        private Button brugVurdering_button;
        private RsDataGridView addSellerGrid;
    }
}
