namespace QuickBite
{
    partial class orderTakingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderTakingMenu));
            headerBackground = new Panel();
            listViewButton = new Button();
            pointsText = new Label();
            pointsLabel = new Label();
            headerBackground.SuspendLayout();
            SuspendLayout();
            // 
            // headerBackground
            // 
            headerBackground.BackgroundImage = (Image)resources.GetObject("headerBackground.BackgroundImage");
            headerBackground.Controls.Add(pointsLabel);
            headerBackground.Controls.Add(pointsText);
            headerBackground.Controls.Add(listViewButton);
            headerBackground.Dock = DockStyle.Top;
            headerBackground.Location = new Point(0, 0);
            headerBackground.Name = "headerBackground";
            headerBackground.Size = new Size(524, 65);
            headerBackground.TabIndex = 0;
            // 
            // listViewButton
            // 
            listViewButton.BackColor = Color.Transparent;
            listViewButton.BackgroundImage = (Image)resources.GetObject("listViewButton.BackgroundImage");
            listViewButton.BackgroundImageLayout = ImageLayout.Stretch;
            listViewButton.FlatAppearance.BorderSize = 0;
            listViewButton.FlatStyle = FlatStyle.Flat;
            listViewButton.ForeColor = Color.Transparent;
            listViewButton.Location = new Point(3, 3);
            listViewButton.Name = "listViewButton";
            listViewButton.Size = new Size(60, 60);
            listViewButton.TabIndex = 1;
            listViewButton.UseVisualStyleBackColor = false;
            // 
            // pointsText
            // 
            pointsText.AutoSize = true;
            pointsText.BackColor = Color.Transparent;
            pointsText.Location = new Point(469, 12);
            pointsText.Name = "pointsText";
            pointsText.Size = new Size(43, 15);
            pointsText.TabIndex = 2;
            pointsText.Text = "564564";
            pointsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.BackColor = Color.Transparent;
            pointsLabel.Location = new Point(469, 31);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(40, 15);
            pointsLabel.TabIndex = 3;
            pointsLabel.Text = "Points";
            pointsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderTakingMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 921);
            Controls.Add(headerBackground);
            Name = "orderTakingMenu";
            Text = "Quickbite Order Taking Menu";
            headerBackground.ResumeLayout(false);
            headerBackground.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button listViewButton;
        private Label pointsLabel;
        private Label pointsText;
        private Panel headerBackground;
        private Button button1;
    }
}