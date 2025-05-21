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
            pris_label = new Label();
            sælger_label = new Label();
            kvm_label = new Label();
            byggeår_label = new Label();
            postnr_label = new Label();
            husnr_label = new Label();
            vejnavn_label = new Label();
            id_textbox = new TextBox();
            redigering_checkbox = new CheckBox();
            brugVurdering_button = new Button();
            fortrydButton = new Button();
            deleteButton = new Button();
            viewSellerButton = new Button();
            panel2 = new Panel();
            editingActivatedLabel = new Label();
            idPanel = new Panel();
            realtorPanel = new Panel();
            id_label = new Label();
            adressPanel = new Panel();
            adressLabel = new Label();
            propertyDetailsPanel = new Panel();
            propertyDetailsLabel = new Label();
            sellerPanel = new Panel();
            pricePanel = new Panel();
            priceAssessmentPanel = new Panel();
            soldStatusPanel = new Panel();
            forSaleLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).BeginInit();
            panel2.SuspendLayout();
            idPanel.SuspendLayout();
            realtorPanel.SuspendLayout();
            adressPanel.SuspendLayout();
            propertyDetailsPanel.SuspendLayout();
            sellerPanel.SuspendLayout();
            pricePanel.SuspendLayout();
            priceAssessmentPanel.SuspendLayout();
            soldStatusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // vurderingKr_label
            // 
            vurderingKr_label.AutoSize = true;
            vurderingKr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vurderingKr_label.ForeColor = Color.White;
            vurderingKr_label.Location = new Point(126, 43);
            vurderingKr_label.Name = "vurderingKr_label";
            vurderingKr_label.Size = new Size(23, 17);
            vurderingKr_label.TabIndex = 81;
            vurderingKr_label.Text = "kr.";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(vurdering_textbox);
            panel1.Location = new Point(10, 41);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 21);
            panel1.TabIndex = 80;
            // 
            // vurdering_textbox
            // 
            vurdering_textbox.BackColor = SystemColors.Menu;
            vurdering_textbox.BorderStyle = BorderStyle.None;
            vurdering_textbox.Enabled = false;
            vurdering_textbox.Font = new Font("Microsoft YaHei", 9F);
            vurdering_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            vurdering_textbox.Location = new Point(3, -1);
            vurdering_textbox.Margin = new Padding(3, 2, 3, 2);
            vurdering_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            vurdering_textbox.Name = "vurdering_textbox";
            vurdering_textbox.ReadOnly = true;
            vurdering_textbox.Size = new Size(106, 19);
            vurdering_textbox.TabIndex = 39;
            vurdering_textbox.TextAlign = HorizontalAlignment.Right;
            vurdering_textbox.ThousandsSeparator = true;
            // 
            // tilbage_button
            // 
            tilbage_button.BackColor = Color.FromArgb(197, 160, 95);
            tilbage_button.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tilbage_button.ForeColor = Color.White;
            tilbage_button.Location = new Point(727, 9);
            tilbage_button.Margin = new Padding(3, 2, 3, 2);
            tilbage_button.Name = "tilbage_button";
            tilbage_button.Size = new Size(72, 36);
            tilbage_button.TabIndex = 67;
            tilbage_button.TabStop = false;
            tilbage_button.Text = "Tilbage";
            tilbage_button.UseVisualStyleBackColor = false;
            tilbage_button.Click += BackButton_Click;
            // 
            // vurdering_button
            // 
            vurdering_button.BackColor = Color.FromArgb(197, 228, 194);
            vurdering_button.Enabled = false;
            vurdering_button.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vurdering_button.Location = new Point(8, 8);
            vurdering_button.Margin = new Padding(3, 2, 3, 2);
            vurdering_button.Name = "vurdering_button";
            vurdering_button.Size = new Size(106, 29);
            vurdering_button.TabIndex = 65;
            vurdering_button.Text = "Få vurdering";
            vurdering_button.UseVisualStyleBackColor = false;
            vurdering_button.Click += vurdering_button_Click;
            // 
            // solgtdato_label
            // 
            solgtdato_label.AutoSize = true;
            solgtdato_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            solgtdato_label.ForeColor = Color.White;
            solgtdato_label.Location = new Point(9, 41);
            solgtdato_label.Name = "solgtdato_label";
            solgtdato_label.Size = new Size(76, 17);
            solgtdato_label.TabIndex = 79;
            solgtdato_label.Text = "Dato solgt:";
            solgtdato_label.Visible = false;
            // 
            // solgtdato_dateTimePicker
            // 
            solgtdato_dateTimePicker.CustomFormat = "";
            solgtdato_dateTimePicker.Enabled = false;
            solgtdato_dateTimePicker.Font = new Font("Microsoft YaHei", 9F);
            solgtdato_dateTimePicker.Format = DateTimePickerFormat.Short;
            solgtdato_dateTimePicker.Location = new Point(87, 36);
            solgtdato_dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            solgtdato_dateTimePicker.Name = "solgtdato_dateTimePicker";
            solgtdato_dateTimePicker.Size = new Size(83, 23);
            solgtdato_dateTimePicker.TabIndex = 64;
            solgtdato_dateTimePicker.Visible = false;
            // 
            // ejendomsmægler_textbox
            // 
            ejendomsmægler_textbox.Enabled = false;
            ejendomsmægler_textbox.Font = new Font("Microsoft YaHei", 9F);
            ejendomsmægler_textbox.Location = new Point(50, 11);
            ejendomsmægler_textbox.Margin = new Padding(3, 2, 3, 2);
            ejendomsmægler_textbox.Name = "ejendomsmægler_textbox";
            ejendomsmægler_textbox.ReadOnly = true;
            ejendomsmægler_textbox.Size = new Size(115, 23);
            ejendomsmægler_textbox.TabIndex = 78;
            ejendomsmægler_textbox.TabStop = false;
            ejendomsmægler_textbox.Text = "Maria Thodegaard";
            // 
            // kr_label
            // 
            kr_label.AutoSize = true;
            kr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kr_label.ForeColor = Color.White;
            kr_label.Location = new Point(120, 18);
            kr_label.Name = "kr_label";
            kr_label.Size = new Size(23, 17);
            kr_label.TabIndex = 77;
            kr_label.Text = "kr.";
            // 
            // pris_textbox
            // 
            pris_textbox.Font = new Font("Microsoft YaHei", 9F);
            pris_textbox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            pris_textbox.Location = new Point(9, 14);
            pris_textbox.Margin = new Padding(3, 2, 3, 2);
            pris_textbox.Maximum = new decimal(new int[] { 75000000, 0, 0, 0 });
            pris_textbox.Name = "pris_textbox";
            pris_textbox.Size = new Size(110, 23);
            pris_textbox.TabIndex = 57;
            pris_textbox.TextAlign = HorizontalAlignment.Right;
            pris_textbox.ThousandsSeparator = true;
            pris_textbox.ValueChanged += pris_textbox_ValueChanged;
            pris_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // sælgernavn_textbox
            // 
            sælgernavn_textbox.Enabled = false;
            sælgernavn_textbox.Font = new Font("Microsoft YaHei", 9F);
            sælgernavn_textbox.Location = new Point(154, 10);
            sælgernavn_textbox.Margin = new Padding(3, 2, 3, 2);
            sælgernavn_textbox.Name = "sælgernavn_textbox";
            sælgernavn_textbox.ReadOnly = true;
            sælgernavn_textbox.Size = new Size(107, 23);
            sælgernavn_textbox.TabIndex = 76;
            sælgernavn_textbox.TabStop = false;
            // 
            // addSellerButton
            // 
            addSellerButton.Enabled = false;
            addSellerButton.Location = new Point(6, 6);
            addSellerButton.Margin = new Padding(3, 2, 3, 2);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(90, 30);
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
            addSellerGrid.Location = new Point(410, 184);
            addSellerGrid.Margin = new Padding(3, 2, 3, 2);
            addSellerGrid.Name = "addSellerGrid";
            addSellerGrid.ReadOnly = true;
            addSellerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            addSellerGrid.Size = new Size(376, 234);
            addSellerGrid.TabIndex = 45;
            addSellerGrid.CellDoubleClick += addSellerGrid_CellDoubleClick;
            // 
            // squaremeter_checkbox
            // 
            squaremeter_checkbox.AutoSize = true;
            squaremeter_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            squaremeter_checkbox.ForeColor = Color.LightGreen;
            squaremeter_checkbox.Location = new Point(230, 27);
            squaremeter_checkbox.Name = "squaremeter_checkbox";
            squaremeter_checkbox.Size = new Size(24, 20);
            squaremeter_checkbox.TabIndex = 73;
            squaremeter_checkbox.Text = "P";
            squaremeter_checkbox.Visible = false;
            // 
            // buildyear_checkbox
            // 
            buildyear_checkbox.AutoSize = true;
            buildyear_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            buildyear_checkbox.ForeColor = Color.LightGreen;
            buildyear_checkbox.Location = new Point(89, 27);
            buildyear_checkbox.Name = "buildyear_checkbox";
            buildyear_checkbox.Size = new Size(24, 20);
            buildyear_checkbox.TabIndex = 72;
            buildyear_checkbox.Text = "P";
            buildyear_checkbox.Visible = false;
            // 
            // zip_checkbox
            // 
            zip_checkbox.AutoSize = true;
            zip_checkbox.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            zip_checkbox.ForeColor = Color.LightGreen;
            zip_checkbox.Location = new Point(343, 26);
            zip_checkbox.Name = "zip_checkbox";
            zip_checkbox.Size = new Size(24, 20);
            zip_checkbox.TabIndex = 71;
            zip_checkbox.Text = "P";
            zip_checkbox.Visible = false;
            // 
            // streetnumber_checklabel
            // 
            streetnumber_checklabel.AutoSize = true;
            streetnumber_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetnumber_checklabel.ForeColor = Color.LightGreen;
            streetnumber_checklabel.Location = new Point(207, 26);
            streetnumber_checklabel.Name = "streetnumber_checklabel";
            streetnumber_checklabel.Size = new Size(24, 20);
            streetnumber_checklabel.TabIndex = 70;
            streetnumber_checklabel.Text = "P";
            streetnumber_checklabel.Visible = false;
            // 
            // streetname_checklabel
            // 
            streetname_checklabel.AutoSize = true;
            streetname_checklabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            streetname_checklabel.ForeColor = Color.LightGreen;
            streetname_checklabel.Location = new Point(106, 26);
            streetname_checklabel.Name = "streetname_checklabel";
            streetname_checklabel.Size = new Size(24, 20);
            streetname_checklabel.TabIndex = 69;
            streetname_checklabel.Text = "P";
            streetname_checklabel.Visible = false;
            // 
            // solgt_checkbox
            // 
            solgt_checkbox.AutoSize = true;
            solgt_checkbox.Enabled = false;
            solgt_checkbox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            solgt_checkbox.ForeColor = Color.White;
            solgt_checkbox.Location = new Point(8, 10);
            solgt_checkbox.Margin = new Padding(3, 2, 3, 2);
            solgt_checkbox.Name = "solgt_checkbox";
            solgt_checkbox.Size = new Size(74, 21);
            solgt_checkbox.TabIndex = 63;
            solgt_checkbox.Text = "Er solgt";
            solgt_checkbox.UseVisualStyleBackColor = true;
            solgt_checkbox.CheckedChanged += solgt_checkbox_CheckedChanged;
            // 
            // solgt_label
            // 
            solgt_label.AutoSize = true;
            solgt_label.BackColor = Color.FromArgb(100, 131, 184);
            solgt_label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            solgt_label.ForeColor = Color.White;
            solgt_label.Location = new Point(215, 285);
            solgt_label.Name = "solgt_label";
            solgt_label.Size = new Size(120, 19);
            solgt_label.TabIndex = 68;
            solgt_label.Text = "Er boligen solgt?";
            // 
            // sælgerID_textbox
            // 
            sælgerID_textbox.Enabled = false;
            sælgerID_textbox.Font = new Font("Microsoft YaHei", 9F);
            sælgerID_textbox.Location = new Point(104, 10);
            sælgerID_textbox.Margin = new Padding(3, 2, 3, 2);
            sælgerID_textbox.Name = "sælgerID_textbox";
            sælgerID_textbox.ReadOnly = true;
            sælgerID_textbox.Size = new Size(44, 23);
            sælgerID_textbox.TabIndex = 56;
            sælgerID_textbox.TabStop = false;
            sælgerID_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // opdater_button
            // 
            opdater_button.BackColor = Color.FromArgb(121, 183, 145);
            opdater_button.Enabled = false;
            opdater_button.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            opdater_button.ForeColor = Color.White;
            opdater_button.Location = new Point(547, 9);
            opdater_button.Margin = new Padding(3, 2, 3, 2);
            opdater_button.Name = "opdater_button";
            opdater_button.Size = new Size(142, 35);
            opdater_button.TabIndex = 66;
            opdater_button.Text = "Opdater ændringer";
            opdater_button.UseVisualStyleBackColor = false;
            opdater_button.Click += opdater_button_Click;
            // 
            // dato_datepicker
            // 
            dato_datepicker.Enabled = false;
            dato_datepicker.Font = new Font("Microsoft YaHei", 9F);
            dato_datepicker.Format = DateTimePickerFormat.Short;
            dato_datepicker.Location = new Point(272, 27);
            dato_datepicker.Margin = new Padding(3, 2, 3, 2);
            dato_datepicker.Name = "dato_datepicker";
            dato_datepicker.Size = new Size(85, 23);
            dato_datepicker.TabIndex = 61;
            // 
            // ejendomsmæglerID_textbox
            // 
            ejendomsmæglerID_textbox.Enabled = false;
            ejendomsmæglerID_textbox.Font = new Font("Microsoft YaHei", 9F);
            ejendomsmæglerID_textbox.Location = new Point(9, 11);
            ejendomsmæglerID_textbox.Margin = new Padding(3, 2, 3, 2);
            ejendomsmæglerID_textbox.Name = "ejendomsmæglerID_textbox";
            ejendomsmæglerID_textbox.ReadOnly = true;
            ejendomsmæglerID_textbox.Size = new Size(35, 23);
            ejendomsmæglerID_textbox.TabIndex = 60;
            ejendomsmæglerID_textbox.TabStop = false;
            ejendomsmæglerID_textbox.Text = "1000";
            ejendomsmæglerID_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // kvm_textbox
            // 
            kvm_textbox.Enabled = false;
            kvm_textbox.Font = new Font("Microsoft YaHei", 9F);
            kvm_textbox.Location = new Point(123, 27);
            kvm_textbox.Margin = new Padding(3, 2, 3, 2);
            kvm_textbox.MaxLength = 5;
            kvm_textbox.Name = "kvm_textbox";
            kvm_textbox.Size = new Size(110, 23);
            kvm_textbox.TabIndex = 53;
            kvm_textbox.TextChanged += kvm_textbox_TextChanged;
            kvm_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // byggeår_textbox
            // 
            byggeår_textbox.Enabled = false;
            byggeår_textbox.Font = new Font("Microsoft YaHei", 9F);
            byggeår_textbox.Location = new Point(15, 27);
            byggeår_textbox.Margin = new Padding(3, 2, 3, 2);
            byggeår_textbox.MaxLength = 4;
            byggeår_textbox.Name = "byggeår_textbox";
            byggeår_textbox.Size = new Size(76, 23);
            byggeår_textbox.TabIndex = 51;
            byggeår_textbox.TextChanged += byggeår_textbox_TextChanged;
            byggeår_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // zipcode_textbox
            // 
            zipcode_textbox.Enabled = false;
            zipcode_textbox.Font = new Font("Microsoft YaHei", 9F);
            zipcode_textbox.Location = new Point(235, 23);
            zipcode_textbox.Margin = new Padding(3, 2, 3, 2);
            zipcode_textbox.MaxLength = 4;
            zipcode_textbox.Name = "zipcode_textbox";
            zipcode_textbox.Size = new Size(110, 23);
            zipcode_textbox.TabIndex = 49;
            zipcode_textbox.TextChanged += zipcode_textbox_TextChanged;
            zipcode_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // husnr_textbox
            // 
            husnr_textbox.Enabled = false;
            husnr_textbox.Font = new Font("Microsoft YaHei", 9F);
            husnr_textbox.Location = new Point(135, 23);
            husnr_textbox.Margin = new Padding(3, 2, 3, 2);
            husnr_textbox.MaxLength = 4;
            husnr_textbox.Name = "husnr_textbox";
            husnr_textbox.Size = new Size(74, 23);
            husnr_textbox.TabIndex = 47;
            husnr_textbox.TextChanged += husnr_textbox_TextChanged;
            husnr_textbox.KeyPress += HandleDigit_KeyPress;
            // 
            // vejnavn_textbox
            // 
            vejnavn_textbox.Enabled = false;
            vejnavn_textbox.Font = new Font("Microsoft YaHei", 9F);
            vejnavn_textbox.Location = new Point(15, 24);
            vejnavn_textbox.Margin = new Padding(3, 2, 3, 2);
            vejnavn_textbox.Name = "vejnavn_textbox";
            vejnavn_textbox.Size = new Size(93, 23);
            vejnavn_textbox.TabIndex = 43;
            vejnavn_textbox.TextChanged += vejnavn_textbox_TextChanged;
            vejnavn_textbox.KeyPress += HandleLetter_KeyPress;
            // 
            // dato_label
            // 
            dato_label.AutoSize = true;
            dato_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            dato_label.ForeColor = Color.White;
            dato_label.Location = new Point(265, 10);
            dato_label.Name = "dato_label";
            dato_label.Size = new Size(102, 17);
            dato_label.TabIndex = 62;
            dato_label.Text = "Dato sat tilsalg";
            // 
            // ejendomsmælger_label
            // 
            ejendomsmælger_label.AutoSize = true;
            ejendomsmælger_label.BackColor = Color.FromArgb(100, 131, 184);
            ejendomsmælger_label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ejendomsmælger_label.ForeColor = Color.White;
            ejendomsmælger_label.Location = new Point(135, 11);
            ejendomsmælger_label.Name = "ejendomsmælger_label";
            ejendomsmælger_label.Size = new Size(125, 19);
            ejendomsmælger_label.TabIndex = 59;
            ejendomsmælger_label.Text = "Ejendomsmægler";
            // 
            // pris_label
            // 
            pris_label.AutoSize = true;
            pris_label.BackColor = Color.FromArgb(100, 131, 184);
            pris_label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pris_label.ForeColor = Color.White;
            pris_label.Location = new Point(14, 283);
            pris_label.Name = "pris_label";
            pris_label.Size = new Size(34, 19);
            pris_label.TabIndex = 55;
            pris_label.Text = "Pris";
            // 
            // sælger_label
            // 
            sælger_label.AutoSize = true;
            sælger_label.BackColor = Color.FromArgb(100, 131, 184);
            sælger_label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            sælger_label.ForeColor = Color.White;
            sælger_label.Location = new Point(410, 109);
            sælger_label.Name = "sælger_label";
            sælger_label.Size = new Size(56, 19);
            sælger_label.TabIndex = 52;
            sælger_label.Text = "Sælger";
            // 
            // kvm_label
            // 
            kvm_label.AutoSize = true;
            kvm_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            kvm_label.ForeColor = Color.White;
            kvm_label.Location = new Point(121, 10);
            kvm_label.Name = "kvm_label";
            kvm_label.Size = new Size(91, 17);
            kvm_label.TabIndex = 50;
            kvm_label.Text = "Kvadratmeter";
            // 
            // byggeår_label
            // 
            byggeår_label.AutoSize = true;
            byggeår_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            byggeår_label.ForeColor = Color.White;
            byggeår_label.Location = new Point(15, 10);
            byggeår_label.Name = "byggeår_label";
            byggeår_label.Size = new Size(58, 17);
            byggeår_label.TabIndex = 48;
            byggeår_label.Text = "Byggeår";
            // 
            // postnr_label
            // 
            postnr_label.AutoSize = true;
            postnr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            postnr_label.ForeColor = Color.White;
            postnr_label.Location = new Point(234, 6);
            postnr_label.Name = "postnr_label";
            postnr_label.Size = new Size(87, 17);
            postnr_label.TabIndex = 46;
            postnr_label.Text = "Postnummer";
            // 
            // husnr_label
            // 
            husnr_label.AutoSize = true;
            husnr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            husnr_label.ForeColor = Color.White;
            husnr_label.Location = new Point(134, 6);
            husnr_label.Name = "husnr_label";
            husnr_label.Size = new Size(84, 17);
            husnr_label.TabIndex = 44;
            husnr_label.Text = "Husnummer";
            // 
            // vejnavn_label
            // 
            vejnavn_label.AutoSize = true;
            vejnavn_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            vejnavn_label.ForeColor = Color.White;
            vejnavn_label.Location = new Point(14, 6);
            vejnavn_label.Name = "vejnavn_label";
            vejnavn_label.Size = new Size(58, 17);
            vejnavn_label.TabIndex = 42;
            vejnavn_label.Text = "Vejnavn";
            // 
            // id_textbox
            // 
            id_textbox.Enabled = false;
            id_textbox.Font = new Font("Microsoft YaHei", 9F);
            id_textbox.Location = new Point(13, 11);
            id_textbox.Margin = new Padding(3, 2, 3, 2);
            id_textbox.Name = "id_textbox";
            id_textbox.Size = new Size(63, 23);
            id_textbox.TabIndex = 83;
            // 
            // redigering_checkbox
            // 
            redigering_checkbox.AutoSize = true;
            redigering_checkbox.BackColor = Color.FromArgb(87, 107, 155);
            redigering_checkbox.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            redigering_checkbox.ForeColor = Color.White;
            redigering_checkbox.Location = new Point(327, 55);
            redigering_checkbox.Margin = new Padding(3, 2, 3, 2);
            redigering_checkbox.Name = "redigering_checkbox";
            redigering_checkbox.Size = new Size(152, 23);
            redigering_checkbox.TabIndex = 84;
            redigering_checkbox.Text = "Aktivér redigering";
            redigering_checkbox.UseVisualStyleBackColor = false;
            redigering_checkbox.CheckedChanged += redigering_checkbox_CheckedChanged;
            // 
            // brugVurdering_button
            // 
            brugVurdering_button.BackColor = Color.FromArgb(213, 231, 251);
            brugVurdering_button.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brugVurdering_button.Location = new Point(120, 8);
            brugVurdering_button.Margin = new Padding(3, 2, 3, 2);
            brugVurdering_button.Name = "brugVurdering_button";
            brugVurdering_button.Size = new Size(55, 29);
            brugVurdering_button.TabIndex = 85;
            brugVurdering_button.Text = "Brug";
            brugVurdering_button.UseVisualStyleBackColor = false;
            brugVurdering_button.Visible = false;
            brugVurdering_button.Click += brugVurdering_button_Click;
            // 
            // fortrydButton
            // 
            fortrydButton.BackColor = Color.FromArgb(207, 133, 88);
            fortrydButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            fortrydButton.ForeColor = Color.White;
            fortrydButton.Location = new Point(559, 54);
            fortrydButton.Margin = new Padding(3, 2, 3, 2);
            fortrydButton.Name = "fortrydButton";
            fortrydButton.Size = new Size(130, 35);
            fortrydButton.TabIndex = 86;
            fortrydButton.Text = "Fortryd ændringer";
            fortrydButton.UseVisualStyleBackColor = false;
            fortrydButton.Click += fortrydButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(718, 54);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(81, 35);
            deleteButton.TabIndex = 87;
            deleteButton.Text = "Slet bolig";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // viewSellerButton
            // 
            viewSellerButton.Location = new Point(271, 7);
            viewSellerButton.Margin = new Padding(3, 2, 3, 2);
            viewSellerButton.Name = "viewSellerButton";
            viewSellerButton.Size = new Size(99, 28);
            viewSellerButton.TabIndex = 88;
            viewSellerButton.Text = "Til sælger profil";
            viewSellerButton.UseVisualStyleBackColor = true;
            viewSellerButton.Click += viewSellerButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 221, 177);
            panel2.Controls.Add(editingActivatedLabel);
            panel2.Controls.Add(idPanel);
            panel2.Controls.Add(ejendomsmælger_label);
            panel2.Controls.Add(realtorPanel);
            panel2.Controls.Add(id_label);
            panel2.Controls.Add(redigering_checkbox);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(opdater_button);
            panel2.Controls.Add(fortrydButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 100);
            panel2.TabIndex = 89;
            // 
            // editingActivatedLabel
            // 
            editingActivatedLabel.AutoSize = true;
            editingActivatedLabel.BackColor = Color.White;
            editingActivatedLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editingActivatedLabel.Location = new Point(323, 26);
            editingActivatedLabel.Name = "editingActivatedLabel";
            editingActivatedLabel.Size = new Size(183, 19);
            editingActivatedLabel.TabIndex = 93;
            editingActivatedLabel.Text = "Redigering ikke aktiveret.";
            // 
            // idPanel
            // 
            idPanel.BackColor = Color.FromArgb(110, 149, 219);
            idPanel.Controls.Add(id_textbox);
            idPanel.Location = new Point(28, 33);
            idPanel.Name = "idPanel";
            idPanel.Size = new Size(88, 45);
            idPanel.TabIndex = 92;
            // 
            // realtorPanel
            // 
            realtorPanel.BackColor = Color.FromArgb(110, 149, 219);
            realtorPanel.Controls.Add(ejendomsmæglerID_textbox);
            realtorPanel.Controls.Add(ejendomsmægler_textbox);
            realtorPanel.Location = new Point(135, 29);
            realtorPanel.Name = "realtorPanel";
            realtorPanel.Size = new Size(176, 49);
            realtorPanel.TabIndex = 91;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.BackColor = Color.FromArgb(100, 131, 184);
            id_label.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id_label.ForeColor = Color.White;
            id_label.Location = new Point(28, 14);
            id_label.Name = "id_label";
            id_label.Size = new Size(22, 19);
            id_label.TabIndex = 82;
            id_label.Text = "Id";
            // 
            // adressPanel
            // 
            adressPanel.BackColor = Color.FromArgb(110, 149, 219);
            adressPanel.Controls.Add(vejnavn_textbox);
            adressPanel.Controls.Add(vejnavn_label);
            adressPanel.Controls.Add(streetname_checklabel);
            adressPanel.Controls.Add(husnr_label);
            adressPanel.Controls.Add(husnr_textbox);
            adressPanel.Controls.Add(postnr_label);
            adressPanel.Controls.Add(zipcode_textbox);
            adressPanel.Controls.Add(streetnumber_checklabel);
            adressPanel.Controls.Add(zip_checkbox);
            adressPanel.Location = new Point(14, 131);
            adressPanel.Name = "adressPanel";
            adressPanel.Size = new Size(377, 55);
            adressPanel.TabIndex = 90;
            adressPanel.Paint += adressPanel_Paint;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.BackColor = Color.FromArgb(100, 131, 184);
            adressLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adressLabel.ForeColor = Color.White;
            adressLabel.Location = new Point(14, 113);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(71, 19);
            adressLabel.TabIndex = 90;
            adressLabel.Text = "Addresse";
            // 
            // propertyDetailsPanel
            // 
            propertyDetailsPanel.BackColor = Color.FromArgb(110, 149, 219);
            propertyDetailsPanel.Controls.Add(byggeår_label);
            propertyDetailsPanel.Controls.Add(byggeår_textbox);
            propertyDetailsPanel.Controls.Add(kvm_textbox);
            propertyDetailsPanel.Controls.Add(buildyear_checkbox);
            propertyDetailsPanel.Controls.Add(kvm_label);
            propertyDetailsPanel.Controls.Add(squaremeter_checkbox);
            propertyDetailsPanel.Controls.Add(dato_datepicker);
            propertyDetailsPanel.Controls.Add(dato_label);
            propertyDetailsPanel.Location = new Point(14, 216);
            propertyDetailsPanel.Name = "propertyDetailsPanel";
            propertyDetailsPanel.Size = new Size(377, 61);
            propertyDetailsPanel.TabIndex = 90;
            // 
            // propertyDetailsLabel
            // 
            propertyDetailsLabel.AutoSize = true;
            propertyDetailsLabel.BackColor = Color.FromArgb(100, 131, 184);
            propertyDetailsLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            propertyDetailsLabel.ForeColor = Color.White;
            propertyDetailsLabel.Location = new Point(14, 197);
            propertyDetailsLabel.Name = "propertyDetailsLabel";
            propertyDetailsLabel.Size = new Size(96, 19);
            propertyDetailsLabel.TabIndex = 91;
            propertyDetailsLabel.Text = "Boligdetaljer";
            // 
            // sellerPanel
            // 
            sellerPanel.BackColor = Color.FromArgb(110, 149, 219);
            sellerPanel.Controls.Add(sælgernavn_textbox);
            sellerPanel.Controls.Add(sælgerID_textbox);
            sellerPanel.Controls.Add(addSellerButton);
            sellerPanel.Controls.Add(viewSellerButton);
            sellerPanel.Location = new Point(410, 127);
            sellerPanel.Name = "sellerPanel";
            sellerPanel.Size = new Size(376, 38);
            sellerPanel.TabIndex = 92;
            // 
            // pricePanel
            // 
            pricePanel.BackColor = Color.FromArgb(110, 149, 219);
            pricePanel.Controls.Add(pris_textbox);
            pricePanel.Controls.Add(kr_label);
            pricePanel.Location = new Point(14, 302);
            pricePanel.Name = "pricePanel";
            pricePanel.Size = new Size(179, 50);
            pricePanel.TabIndex = 93;
            // 
            // priceAssessmentPanel
            // 
            priceAssessmentPanel.BackColor = Color.FromArgb(110, 149, 219);
            priceAssessmentPanel.Controls.Add(brugVurdering_button);
            priceAssessmentPanel.Controls.Add(panel1);
            priceAssessmentPanel.Controls.Add(vurderingKr_label);
            priceAssessmentPanel.Controls.Add(vurdering_button);
            priceAssessmentPanel.Location = new Point(14, 358);
            priceAssessmentPanel.Name = "priceAssessmentPanel";
            priceAssessmentPanel.Size = new Size(180, 70);
            priceAssessmentPanel.TabIndex = 94;
            // 
            // soldStatusPanel
            // 
            soldStatusPanel.BackColor = Color.FromArgb(110, 149, 219);
            soldStatusPanel.Controls.Add(forSaleLabel);
            soldStatusPanel.Controls.Add(solgt_checkbox);
            soldStatusPanel.Controls.Add(solgtdato_label);
            soldStatusPanel.Controls.Add(solgtdato_dateTimePicker);
            soldStatusPanel.Location = new Point(215, 304);
            soldStatusPanel.Name = "soldStatusPanel";
            soldStatusPanel.Size = new Size(181, 67);
            soldStatusPanel.TabIndex = 95;
            // 
            // forSaleLabel
            // 
            forSaleLabel.AutoSize = true;
            forSaleLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            forSaleLabel.ForeColor = Color.White;
            forSaleLabel.Location = new Point(10, 40);
            forSaleLabel.Name = "forSaleLabel";
            forSaleLabel.Size = new Size(120, 17);
            forSaleLabel.TabIndex = 80;
            forSaleLabel.Text = "Boligen er til salg.";
            // 
            // UpdatePropertyPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(priceAssessmentPanel);
            Controls.Add(pricePanel);
            Controls.Add(sellerPanel);
            Controls.Add(propertyDetailsLabel);
            Controls.Add(adressLabel);
            Controls.Add(adressPanel);
            Controls.Add(propertyDetailsPanel);
            Controls.Add(tilbage_button);
            Controls.Add(addSellerGrid);
            Controls.Add(solgt_label);
            Controls.Add(pris_label);
            Controls.Add(sælger_label);
            Controls.Add(panel2);
            Controls.Add(soldStatusPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdatePropertyPage";
            Size = new Size(812, 452);
            Click += UpdatePropertyPage_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vurdering_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pris_textbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            idPanel.ResumeLayout(false);
            idPanel.PerformLayout();
            realtorPanel.ResumeLayout(false);
            realtorPanel.PerformLayout();
            adressPanel.ResumeLayout(false);
            adressPanel.PerformLayout();
            propertyDetailsPanel.ResumeLayout(false);
            propertyDetailsPanel.PerformLayout();
            sellerPanel.ResumeLayout(false);
            sellerPanel.PerformLayout();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            priceAssessmentPanel.ResumeLayout(false);
            priceAssessmentPanel.PerformLayout();
            soldStatusPanel.ResumeLayout(false);
            soldStatusPanel.PerformLayout();
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
        private Label pris_label;
        private Label sælger_label;
        private Label kvm_label;
        private Label byggeår_label;
        private Label postnr_label;
        private Label husnr_label;
        private Label vejnavn_label;
        private TextBox id_textbox;
        private CheckBox redigering_checkbox;
        private Button brugVurdering_button;
        private RsDataGridView addSellerGrid;
        private Button fortrydButton;
        private Button deleteButton;
        private Button viewSellerButton;
        private Panel panel2;
        private Panel adressPanel;
        private Label adressLabel;
        private Panel propertyDetailsPanel;
        private Panel realtorPanel;
        private Panel idPanel;
        private Label id_label;
        private Label propertyDetailsLabel;
        private Panel sellerPanel;
        private Panel pricePanel;
        private Panel priceAssessmentPanel;
        private Panel soldStatusPanel;
        private Label editingActivatedLabel;
        private Label forSaleLabel;
    }
}
