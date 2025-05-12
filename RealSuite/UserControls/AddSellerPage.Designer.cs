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
            // 
            // efternavnTextBox
            // 
            efternavnTextBox.Location = new Point(210, 157);
            efternavnTextBox.Name = "efternavnTextBox";
            efternavnTextBox.Size = new Size(125, 27);
            efternavnTextBox.TabIndex = 2;
            // 
            // telefonTextBox
            // 
            telefonTextBox.Location = new Point(210, 466);
            telefonTextBox.Name = "telefonTextBox";
            telefonTextBox.Size = new Size(125, 27);
            telefonTextBox.TabIndex = 7;
            // 
            // cprNrTextBox
            // 
            cprNrTextBox.Location = new Point(210, 228);
            cprNrTextBox.Name = "cprNrTextBox";
            cprNrTextBox.Size = new Size(125, 27);
            cprNrTextBox.TabIndex = 3;
            // 
            // vejnavnTextBox
            // 
            vejnavnTextBox.Location = new Point(210, 283);
            vejnavnTextBox.Name = "vejnavnTextBox";
            vejnavnTextBox.Size = new Size(125, 27);
            vejnavnTextBox.TabIndex = 4;
            // 
            // vejNrTextBox
            // 
            vejNrTextBox.Location = new Point(210, 336);
            vejNrTextBox.Name = "vejNrTextBox";
            vejNrTextBox.Size = new Size(125, 27);
            vejNrTextBox.TabIndex = 5;
            // 
            // postNrTextBox
            // 
            postNrTextBox.Location = new Point(210, 397);
            postNrTextBox.Name = "postNrTextBox";
            postNrTextBox.Size = new Size(125, 27);
            postNrTextBox.TabIndex = 6;
            // 
            // tilføjButton
            // 
            tilføjButton.Location = new Point(625, 464);
            tilføjButton.Name = "tilføjButton";
            tilføjButton.Size = new Size(94, 29);
            tilføjButton.TabIndex = 8;
            tilføjButton.Text = "Tilføj";
            tilføjButton.UseVisualStyleBackColor = true;
            tilføjButton.Click += tilføjButton_Click;
            // 
            // AddSellerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
