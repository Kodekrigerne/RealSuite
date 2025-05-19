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
            vejnavnLabel = new Label();
            vejNrLabel = new Label();
            postNrLabel = new Label();
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
            panel2 = new Panel();
            label1 = new Label();
            listedDateFromLabel = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            vejnavn_label = new Label();
            husnr_label = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // vejnavnLabel
            // 
            vejnavnLabel.AutoSize = true;
            vejnavnLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            vejnavnLabel.ForeColor = Color.White;
            vejnavnLabel.Location = new Point(17, 23);
            vejnavnLabel.Name = "vejnavnLabel";
            vejnavnLabel.Size = new Size(76, 19);
            vejnavnLabel.TabIndex = 3;
            vejnavnLabel.Text = "Vejnavn:";
            // 
            // vejNrLabel
            // 
            vejNrLabel.AutoSize = true;
            vejNrLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            vejNrLabel.ForeColor = Color.White;
            vejNrLabel.Location = new Point(205, 24);
            vejNrLabel.Name = "vejNrLabel";
            vejNrLabel.Size = new Size(62, 19);
            vejNrLabel.TabIndex = 4;
            vejNrLabel.Text = "Vej nr.:";
            // 
            // postNrLabel
            // 
            postNrLabel.AutoSize = true;
            postNrLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            postNrLabel.ForeColor = Color.White;
            postNrLabel.Location = new Point(394, 23);
            postNrLabel.Name = "postNrLabel";
            postNrLabel.Size = new Size(66, 19);
            postNrLabel.TabIndex = 5;
            postNrLabel.Text = "Postnr.:";
            // 
            // fornavnTextBox
            // 
            fornavnTextBox.Location = new Point(17, 40);
            fornavnTextBox.Name = "fornavnTextBox";
            fornavnTextBox.Size = new Size(122, 27);
            fornavnTextBox.TabIndex = 1;
            fornavnTextBox.TextChanged += fornavnTextBox_TextChanged;
            fornavnTextBox.KeyPress += HandleLetter_KeyPress;
            // 
            // efternavnTextBox
            // 
            efternavnTextBox.Location = new Point(179, 41);
            efternavnTextBox.Name = "efternavnTextBox";
            efternavnTextBox.Size = new Size(125, 27);
            efternavnTextBox.TabIndex = 2;
            efternavnTextBox.TextChanged += efternavnTextBox_TextChanged;
            efternavnTextBox.KeyPress += HandleLetter_KeyPress;
            // 
            // telefonTextBox
            // 
            telefonTextBox.Location = new Point(42, 436);
            telefonTextBox.MaxLength = 8;
            telefonTextBox.Name = "telefonTextBox";
            telefonTextBox.Size = new Size(125, 27);
            telefonTextBox.TabIndex = 8;
            telefonTextBox.TextChanged += telefonTextBox_TextChanged;
            telefonTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // cprNrTextBox
            // 
            cprNrTextBox.Location = new Point(13, 24);
            cprNrTextBox.MaxLength = 6;
            cprNrTextBox.Name = "cprNrTextBox";
            cprNrTextBox.Size = new Size(125, 27);
            cprNrTextBox.TabIndex = 3;
            cprNrTextBox.TextChanged += cprNrTextBox_TextChanged;
            cprNrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // vejnavnTextBox
            // 
            vejnavnTextBox.Location = new Point(17, 53);
            vejnavnTextBox.Name = "vejnavnTextBox";
            vejnavnTextBox.Size = new Size(125, 27);
            vejnavnTextBox.TabIndex = 5;
            vejnavnTextBox.TextChanged += vejnavnTextBox_TextChanged;
            vejnavnTextBox.KeyPress += HandleLetter_KeyPress;
            // 
            // vejNrTextBox
            // 
            vejNrTextBox.Location = new Point(202, 53);
            vejNrTextBox.MaxLength = 4;
            vejNrTextBox.Name = "vejNrTextBox";
            vejNrTextBox.Size = new Size(125, 27);
            vejNrTextBox.TabIndex = 6;
            vejNrTextBox.TextChanged += vejNrTextBox_TextChanged;
            vejNrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // postNrTextBox
            // 
            postNrTextBox.Location = new Point(389, 53);
            postNrTextBox.MaxLength = 4;
            postNrTextBox.Name = "postNrTextBox";
            postNrTextBox.Size = new Size(125, 27);
            postNrTextBox.TabIndex = 7;
            postNrTextBox.TextChanged += postNrTextBox_TextChanged;
            postNrTextBox.KeyPress += HandleDigit_KeyPress;
            // 
            // tilføjButton
            // 
            tilføjButton.BackColor = Color.LightGreen;
            tilføjButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            tilføjButton.Location = new Point(475, 412);
            tilføjButton.Name = "tilføjButton";
            tilføjButton.Size = new Size(158, 81);
            tilføjButton.TabIndex = 9;
            tilføjButton.Text = "Opret";
            tilføjButton.UseVisualStyleBackColor = false;
            tilføjButton.Click += tilføjButton_Click;
            // 
            // cpr2NrTextBox
            // 
            cpr2NrTextBox.Location = new Point(159, 23);
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
            cprBindestregLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cprBindestregLabel.ForeColor = Color.White;
            cprBindestregLabel.Location = new Point(139, 25);
            cprBindestregLabel.Name = "cprBindestregLabel";
            cprBindestregLabel.Size = new Size(17, 24);
            cprBindestregLabel.TabIndex = 10;
            cprBindestregLabel.Text = "-";
            // 
            // fornavnCheckLabel
            // 
            fornavnCheckLabel.AutoSize = true;
            fornavnCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            fornavnCheckLabel.ForeColor = Color.Red;
            fornavnCheckLabel.Location = new Point(139, 43);
            fornavnCheckLabel.Name = "fornavnCheckLabel";
            fornavnCheckLabel.Size = new Size(25, 24);
            fornavnCheckLabel.TabIndex = 11;
            fornavnCheckLabel.Text = "O";
            fornavnCheckLabel.Visible = false;
            // 
            // efternavnCheckLabel
            // 
            efternavnCheckLabel.AutoSize = true;
            efternavnCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            efternavnCheckLabel.ForeColor = Color.Red;
            efternavnCheckLabel.Location = new Point(304, 45);
            efternavnCheckLabel.Name = "efternavnCheckLabel";
            efternavnCheckLabel.Size = new Size(25, 24);
            efternavnCheckLabel.TabIndex = 12;
            efternavnCheckLabel.Text = "O";
            efternavnCheckLabel.Visible = false;
            // 
            // cprCheckLabel
            // 
            cprCheckLabel.AutoSize = true;
            cprCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            cprCheckLabel.ForeColor = Color.Red;
            cprCheckLabel.Location = new Point(234, 25);
            cprCheckLabel.Name = "cprCheckLabel";
            cprCheckLabel.Size = new Size(25, 24);
            cprCheckLabel.TabIndex = 13;
            cprCheckLabel.Text = "O";
            cprCheckLabel.Visible = false;
            // 
            // vejnavnCheckLabel
            // 
            vejnavnCheckLabel.AutoSize = true;
            vejnavnCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            vejnavnCheckLabel.ForeColor = Color.Red;
            vejnavnCheckLabel.Location = new Point(150, 57);
            vejnavnCheckLabel.Name = "vejnavnCheckLabel";
            vejnavnCheckLabel.Size = new Size(25, 24);
            vejnavnCheckLabel.TabIndex = 14;
            vejnavnCheckLabel.Text = "O";
            vejnavnCheckLabel.Visible = false;
            // 
            // vejnrCheckLabel
            // 
            vejnrCheckLabel.AutoSize = true;
            vejnrCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            vejnrCheckLabel.ForeColor = Color.Red;
            vejnrCheckLabel.Location = new Point(335, 57);
            vejnrCheckLabel.Name = "vejnrCheckLabel";
            vejnrCheckLabel.Size = new Size(25, 24);
            vejnrCheckLabel.TabIndex = 15;
            vejnrCheckLabel.Text = "O";
            vejnrCheckLabel.Visible = false;
            // 
            // postnrCheckLabel
            // 
            postnrCheckLabel.AutoSize = true;
            postnrCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            postnrCheckLabel.ForeColor = Color.Red;
            postnrCheckLabel.Location = new Point(521, 57);
            postnrCheckLabel.Name = "postnrCheckLabel";
            postnrCheckLabel.Size = new Size(25, 24);
            postnrCheckLabel.TabIndex = 16;
            postnrCheckLabel.Text = "O";
            postnrCheckLabel.Visible = false;
            // 
            // telefonCheckLabel
            // 
            telefonCheckLabel.AutoSize = true;
            telefonCheckLabel.Font = new Font("Wingdings 2", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 2);
            telefonCheckLabel.ForeColor = Color.Red;
            telefonCheckLabel.Location = new Point(149, 28);
            telefonCheckLabel.Name = "telefonCheckLabel";
            telefonCheckLabel.Size = new Size(25, 24);
            telefonCheckLabel.TabIndex = 17;
            telefonCheckLabel.Text = "O";
            telefonCheckLabel.Visible = false;
            // 
            // rydButton
            // 
            rydButton.BackColor = Color.LightSalmon;
            rydButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            rydButton.Location = new Point(672, 409);
            rydButton.Name = "rydButton";
            rydButton.Size = new Size(158, 81);
            rydButton.TabIndex = 10;
            rydButton.Text = "Ryd";
            rydButton.UseVisualStyleBackColor = false;
            rydButton.Click += rydButton_Click;
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 168);
            panel2.TabIndex = 43;
            panel2.Click += AddSellerPage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 131, 184);
            label1.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(445, 31);
            label1.Name = "label1";
            label1.Size = new Size(139, 26);
            label1.TabIndex = 19;
            label1.Text = "CPR-nummer";
            // 
            // listedDateFromLabel
            // 
            listedDateFromLabel.AutoSize = true;
            listedDateFromLabel.BackColor = Color.FromArgb(100, 131, 184);
            listedDateFromLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            listedDateFromLabel.ForeColor = Color.White;
            listedDateFromLabel.Location = new Point(26, 19);
            listedDateFromLabel.Name = "listedDateFromLabel";
            listedDateFromLabel.Size = new Size(62, 26);
            listedDateFromLabel.TabIndex = 18;
            listedDateFromLabel.Text = "Navn";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(110, 149, 219);
            panel4.Controls.Add(cprNrTextBox);
            panel4.Controls.Add(cprBindestregLabel);
            panel4.Controls.Add(cpr2NrTextBox);
            panel4.Controls.Add(cprCheckLabel);
            panel4.Location = new Point(445, 56);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 75);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(110, 149, 219);
            panel3.Controls.Add(vejnavn_label);
            panel3.Controls.Add(husnr_label);
            panel3.Controls.Add(fornavnTextBox);
            panel3.Controls.Add(fornavnCheckLabel);
            panel3.Controls.Add(efternavnTextBox);
            panel3.Controls.Add(efternavnCheckLabel);
            panel3.Location = new Point(26, 44);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 88);
            panel3.TabIndex = 0;
            // 
            // vejnavn_label
            // 
            vejnavn_label.AutoSize = true;
            vejnavn_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            vejnavn_label.ForeColor = Color.White;
            vejnavn_label.Location = new Point(17, 13);
            vejnavn_label.Name = "vejnavn_label";
            vejnavn_label.Size = new Size(71, 19);
            vejnavn_label.TabIndex = 0;
            vejnavn_label.Text = "Fornavn";
            // 
            // husnr_label
            // 
            husnr_label.AutoSize = true;
            husnr_label.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            husnr_label.ForeColor = Color.White;
            husnr_label.Location = new Point(179, 15);
            husnr_label.Name = "husnr_label";
            husnr_label.Size = new Size(83, 19);
            husnr_label.TabIndex = 1;
            husnr_label.Text = "Efternavn";
            husnr_label.Click += husnr_label_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 149, 219);
            panel1.Controls.Add(vejnavnLabel);
            panel1.Controls.Add(vejnavnTextBox);
            panel1.Controls.Add(postnrCheckLabel);
            panel1.Controls.Add(vejnavnCheckLabel);
            panel1.Controls.Add(postNrTextBox);
            panel1.Controls.Add(vejnrCheckLabel);
            panel1.Controls.Add(vejNrTextBox);
            panel1.Controls.Add(vejNrLabel);
            panel1.Controls.Add(postNrLabel);
            panel1.Location = new Point(26, 233);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 105);
            panel1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(100, 131, 184);
            label2.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 208);
            label2.Name = "label2";
            label2.Size = new Size(87, 26);
            label2.TabIndex = 20;
            label2.Text = "Adresse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(100, 131, 184);
            label3.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 387);
            label3.Name = "label3";
            label3.Size = new Size(165, 26);
            label3.TabIndex = 45;
            label3.Text = "Telefonnummer";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(110, 149, 219);
            panel5.Controls.Add(telefonCheckLabel);
            panel5.Location = new Point(26, 412);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(211, 81);
            panel5.TabIndex = 46;
            // 
            // AddSellerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rydButton);
            Controls.Add(tilføjButton);
            Controls.Add(telefonTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "AddSellerPage";
            Size = new Size(928, 603);
            Click += AddSellerPage_Click;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label vejnavnLabel;
        private Label vejNrLabel;
        private Label postNrLabel;
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
        private Panel panel2;
        private Label label1;
        private Label listedDateFromLabel;
        private Panel panel4;
        private Panel panel3;
        private Label vejnavn_label;
        private Label husnr_label;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel panel5;
    }
}
