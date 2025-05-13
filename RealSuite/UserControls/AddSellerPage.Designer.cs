namespace RealSuite.UserControls
{
    partial class AddSellerPage
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
            components = new System.ComponentModel.Container();
            fornavnLabel = new Label();
            efternavnLabel = new Label();
            cprNrLabel = new Label();
            vejnavnLabel = new Label();
            vejNrLabel = new Label();
            postNrLabel = new Label();
            telefonLabel = new Label();
            fornavnTextBox = new TextBox();
            efternavnTextBox = new TextBox();
            telefonTextBox = new TextBox();
            cprNrTextBox = new TextBox();
            vejnavnTextBox = new TextBox();
            vejNrTextBox = new TextBox();
            postNrTextBox = new TextBox();
            tilføjButton = new Button();
            cpr2NrTextBox = new TextBox();
            cprBindestregLabel = new Label();
            fornavnCheckLabel = new Label();
            efternavnCheckLabel = new Label();
            cprCheckLabel = new Label();
            vejnavnCheckLabel = new Label();
            vejnrCheckLabel = new Label();
            postnrCheckLabel = new Label();
            telefonCheckLabel = new Label();
            addSellerPageTimer = new System.Windows.Forms.Timer(components);
            rydButton = new Button();
            SuspendLayout();
            // 
            // fornavnLabel
            // 
            fornavnLabel.AutoSize = true;
            fornavnLabel.Location = new Point(103, 88);
            fornavnLabel.Name = "fornavnLabel";
            fornavnLabel.Size = new Size(64, 20);
            fornavnLabel.TabIndex = 0;
            fornavnLabel.Text = "Fornavn:";
            // 
            // efternavnLabel
            // 
            efternavnLabel.AutoSize = true;
            efternavnLabel.Location = new Point(93, 164);
            efternavnLabel.Name = "efternavnLabel";
            efternavnLabel.Size = new Size(74, 20);
            efternavnLabel.TabIndex = 1;
            efternavnLabel.Text = "Efternavn:";
            // 
            // cprNrLabel
            // 
            cprNrLabel.AutoSize = true;
            cprNrLabel.Location = new Point(107, 231);
            cprNrLabel.Name = "cprNrLabel";
            cprNrLabel.Size = new Size(60, 20);
            cprNrLabel.TabIndex = 2;
            cprNrLabel.Text = "CPR-nr.:";
            // 
            // vejnavnLabel
            // 
            vejnavnLabel.AutoSize = true;
            vejnavnLabel.Location = new Point(104, 290);
            vejnavnLabel.Name = "vejnavnLabel";
            vejnavnLabel.Size = new Size(63, 20);
            vejnavnLabel.TabIndex = 3;
            vejnavnLabel.Text = "Vejnavn:";
            // 
            // vejNrLabel
            // 
            vejNrLabel.AutoSize = true;
            vejNrLabel.Location = new Point(115, 343);
            vejNrLabel.Name = "vejNrLabel";
            vejNrLabel.Size = new Size(52, 20);
            vejNrLabel.TabIndex = 4;
            vejNrLabel.Text = "Vej nr.:";
            // 
            // postNrLabel
            // 
            postNrLabel.AutoSize = true;
            postNrLabel.Location = new Point(112, 404);
            postNrLabel.Name = "postNrLabel";
            postNrLabel.Size = new Size(55, 20);
            postNrLabel.TabIndex = 5;
            postNrLabel.Text = "Postnr.:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new Point(106, 473);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new Size(61, 20);
            telefonLabel.TabIndex = 6;
            telefonLabel.Text = "Telefon:";
            // 
            // fornavnTextBox
            // 
            fornavnTextBox.Location = new Point(210, 81);
            fornavnTextBox.Name = "fornavnTextBox";
            fornavnTextBox.Size = new Size(125, 27);
            fornavnTextBox.TabIndex = 1;
            fornavnTextBox.TextChanged += fornavnTextBox_TextChanged;
            fornavnTextBox.KeyPress += HandleLetter_KeyPress;
            // 
            // efternavnTextBox
            // 
            efternavnTextBox.Location = new Point(210, 157);
            efternavnTextBox.Name = "efternavnTextBox";
            efternavnTextBox.Size = new Size(125, 27);
            efternavnTextBox.TabIndex = 2;
            efternavnTextBox.TextChanged += efternavnTextBox_TextChanged;
            efternavnTextBox.KeyPress += HandleLetter_KeyPress;
            // 
            // telefonTextBox
            // 
            telefonTextBox.Location = new Point(210, 466);
            telefonTextBox.MaxLength = 8;
            telefonTextBox.Name = "telefonTextBox";
            telefonTextBox.Size = new Size(125, 27);
            telefonTextBox.TabIndex = 8;
            telefonTextBox.TextChanged += telefonTextBox_TextChanged;
            telefonTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // cprNrTextBox
            // 
            cprNrTextBox.Location = new Point(210, 228);
            cprNrTextBox.MaxLength = 6;
            cprNrTextBox.Name = "cprNrTextBox";
            cprNrTextBox.Size = new Size(125, 27);
            cprNrTextBox.TabIndex = 3;
            cprNrTextBox.TextChanged += cprNrTextBox_TextChanged;
            cprNrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // vejnavnTextBox
            // 
            vejnavnTextBox.Location = new Point(210, 283);
            vejnavnTextBox.Name = "vejnavnTextBox";
            vejnavnTextBox.Size = new Size(125, 27);
            vejnavnTextBox.TabIndex = 5;
            vejnavnTextBox.TextChanged += vejnavnTextBox_TextChanged;
            vejnavnTextBox.KeyPress += HandleLetter_KeyPress;
            // 
            // vejNrTextBox
            // 
            vejNrTextBox.Location = new Point(210, 336);
            vejNrTextBox.MaxLength = 4;
            vejNrTextBox.Name = "vejNrTextBox";
            vejNrTextBox.Size = new Size(125, 27);
            vejNrTextBox.TabIndex = 6;
            vejNrTextBox.TextChanged += vejNrTextBox_TextChanged;
            vejNrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // postNrTextBox
            // 
            postNrTextBox.Location = new Point(210, 397);
            postNrTextBox.MaxLength = 4;
            postNrTextBox.Name = "postNrTextBox";
            postNrTextBox.Size = new Size(125, 27);
            postNrTextBox.TabIndex = 7;
            postNrTextBox.TextChanged += postNrTextBox_TextChanged;
            postNrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // tilføjButton
            // 
            tilføjButton.Location = new Point(539, 464);
            tilføjButton.Name = "tilføjButton";
            tilføjButton.Size = new Size(94, 29);
            tilføjButton.TabIndex = 9;
            tilføjButton.Text = "Opret";
            tilføjButton.UseVisualStyleBackColor = true;
            tilføjButton.Click += tilføjButton_Click;
            // 
            // cpr2NrTextBox
            // 
            cpr2NrTextBox.Location = new Point(359, 228);
            cpr2NrTextBox.MaxLength = 4;
            cpr2NrTextBox.Name = "cpr2NrTextBox";
            cpr2NrTextBox.Size = new Size(75, 27);
            cpr2NrTextBox.TabIndex = 4;
            cpr2NrTextBox.TextChanged += cpr2NrTextBox_TextChanged;
            cpr2NrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // cprBindestregLabel
            // 
            cprBindestregLabel.AutoSize = true;
            cprBindestregLabel.Location = new Point(338, 231);
            cprBindestregLabel.Name = "cprBindestregLabel";
            cprBindestregLabel.Size = new Size(15, 20);
            cprBindestregLabel.TabIndex = 10;
            cprBindestregLabel.Text = "-";
            // 
            // fornavnCheckLabel
            // 
            fornavnCheckLabel.AutoSize = true;
            fornavnCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            fornavnCheckLabel.ForeColor = Color.Red;
            fornavnCheckLabel.Location = new Point(341, 88);
            fornavnCheckLabel.Name = "fornavnCheckLabel";
            fornavnCheckLabel.Size = new Size(25, 24);
            fornavnCheckLabel.TabIndex = 11;
            fornavnCheckLabel.Text = "O";
            // 
            // efternavnCheckLabel
            // 
            efternavnCheckLabel.AutoSize = true;
            efternavnCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            efternavnCheckLabel.ForeColor = Color.Red;
            efternavnCheckLabel.Location = new Point(341, 161);
            efternavnCheckLabel.Name = "efternavnCheckLabel";
            efternavnCheckLabel.Size = new Size(25, 24);
            efternavnCheckLabel.TabIndex = 12;
            efternavnCheckLabel.Text = "O";
            // 
            // cprCheckLabel
            // 
            cprCheckLabel.AutoSize = true;
            cprCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            cprCheckLabel.ForeColor = Color.Red;
            cprCheckLabel.Location = new Point(451, 231);
            cprCheckLabel.Name = "cprCheckLabel";
            cprCheckLabel.Size = new Size(25, 24);
            cprCheckLabel.TabIndex = 13;
            cprCheckLabel.Text = "O";
            // 
            // vejnavnCheckLabel
            // 
            vejnavnCheckLabel.AutoSize = true;
            vejnavnCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            vejnavnCheckLabel.ForeColor = Color.Red;
            vejnavnCheckLabel.Location = new Point(350, 287);
            vejnavnCheckLabel.Name = "vejnavnCheckLabel";
            vejnavnCheckLabel.Size = new Size(25, 24);
            vejnavnCheckLabel.TabIndex = 14;
            vejnavnCheckLabel.Text = "O";
            // 
            // vejnrCheckLabel
            // 
            vejnrCheckLabel.AutoSize = true;
            vejnrCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            vejnrCheckLabel.ForeColor = Color.Red;
            vejnrCheckLabel.Location = new Point(350, 343);
            vejnrCheckLabel.Name = "vejnrCheckLabel";
            vejnrCheckLabel.Size = new Size(25, 24);
            vejnrCheckLabel.TabIndex = 15;
            vejnrCheckLabel.Text = "O";
            // 
            // postnrCheckLabel
            // 
            postnrCheckLabel.AutoSize = true;
            postnrCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            postnrCheckLabel.ForeColor = Color.Red;
            postnrCheckLabel.Location = new Point(350, 404);
            postnrCheckLabel.Name = "postnrCheckLabel";
            postnrCheckLabel.Size = new Size(25, 24);
            postnrCheckLabel.TabIndex = 16;
            postnrCheckLabel.Text = "O";
            // 
            // telefonCheckLabel
            // 
            telefonCheckLabel.AutoSize = true;
            telefonCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            telefonCheckLabel.ForeColor = Color.Red;
            telefonCheckLabel.Location = new Point(350, 469);
            telefonCheckLabel.Name = "telefonCheckLabel";
            telefonCheckLabel.Size = new Size(25, 24);
            telefonCheckLabel.TabIndex = 17;
            telefonCheckLabel.Text = "O";
            // 
            // rydButton
            // 
            rydButton.Location = new Point(651, 464);
            rydButton.Name = "rydButton";
            rydButton.Size = new Size(94, 29);
            rydButton.TabIndex = 10;
            rydButton.Text = "Ryd";
            rydButton.UseVisualStyleBackColor = true;
            rydButton.Click += rydButton_Click;
            // 
            // AddSellerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rydButton);
            Controls.Add(telefonCheckLabel);
            Controls.Add(postnrCheckLabel);
            Controls.Add(vejnrCheckLabel);
            Controls.Add(vejnavnCheckLabel);
            Controls.Add(cprCheckLabel);
            Controls.Add(efternavnCheckLabel);
            Controls.Add(fornavnCheckLabel);
            Controls.Add(cprBindestregLabel);
            Controls.Add(cpr2NrTextBox);
            Controls.Add(tilføjButton);
            Controls.Add(postNrTextBox);
            Controls.Add(vejNrTextBox);
            Controls.Add(vejnavnTextBox);
            Controls.Add(cprNrTextBox);
            Controls.Add(telefonTextBox);
            Controls.Add(efternavnTextBox);
            Controls.Add(fornavnTextBox);
            Controls.Add(telefonLabel);
            Controls.Add(postNrLabel);
            Controls.Add(vejNrLabel);
            Controls.Add(vejnavnLabel);
            Controls.Add(cprNrLabel);
            Controls.Add(efternavnLabel);
            Controls.Add(fornavnLabel);
            Name = "AddSellerPage";
            Size = new Size(928, 603);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fornavnLabel;
        private Label efternavnLabel;
        private Label cprNrLabel;
        private Label vejnavnLabel;
        private Label vejNrLabel;
        private Label postNrLabel;
        private Label telefonLabel;
        private TextBox fornavnTextBox;
        private TextBox efternavnTextBox;
        private TextBox telefonTextBox;
        private TextBox cprNrTextBox;
        private TextBox vejnavnTextBox;
        private TextBox vejNrTextBox;
        private TextBox postNrTextBox;
        private Button tilføjButton;
        private TextBox cpr2NrTextBox;
        private Label cprBindestregLabel;
        private Label fornavnCheckLabel;
        private Label efternavnCheckLabel;
        private Label cprCheckLabel;
        private Label vejnavnCheckLabel;
        private Label vejnrCheckLabel;
        private Label postnrCheckLabel;
        private Label telefonCheckLabel;
        private System.Windows.Forms.Timer addSellerPageTimer;
        private Button rydButton;
    }
}
