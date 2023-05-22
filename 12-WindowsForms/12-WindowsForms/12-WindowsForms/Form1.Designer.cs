namespace _12_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clickMeButton = new Button();
            clickMeLabel = new Label();
            SuspendLayout();
            // 
            // clickMeButton
            // 
            clickMeButton.Location = new Point(262, 132);
            clickMeButton.Name = "clickMeButton";
            clickMeButton.Size = new Size(202, 134);
            clickMeButton.TabIndex = 0;
            clickMeButton.Text = "Click me";
            clickMeButton.UseVisualStyleBackColor = true;
            clickMeButton.Click += clickMeButton_Click;
            // 
            // clickMeLabel
            // 
            clickMeLabel.AutoSize = true;
            clickMeLabel.Location = new Point(253, 73);
            clickMeLabel.MinimumSize = new Size(200, 20);
            clickMeLabel.Name = "clickMeLabel";
            clickMeLabel.Size = new Size(200, 20);
            clickMeLabel.TabIndex = 1;
            clickMeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clickMeLabel);
            Controls.Add(clickMeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickMeButton;
        private Label clickMeLabel;
    }
}