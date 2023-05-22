namespace _13_WindowsForms
{
    partial class MainWidow
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
            button1 = new Button();
            dataView = new DataGridView();
            CarName = new DataGridViewTextBoxColumn();
            CarModel = new DataGridViewTextBoxColumn();
            CarYear = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(405, 133);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataView
            // 
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Columns.AddRange(new DataGridViewColumn[] { CarName, CarModel, CarYear });
            dataView.Location = new Point(113, 218);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 29;
            dataView.Size = new Size(563, 196);
            dataView.TabIndex = 1;
            // 
            // CarName
            // 
            CarName.HeaderText = "Car Name";
            CarName.MinimumWidth = 6;
            CarName.Name = "CarName";
            CarName.Width = 125;
            // 
            // CarModel
            // 
            CarModel.HeaderText = "Car Name";
            CarModel.MinimumWidth = 6;
            CarModel.Name = "CarModel";
            CarModel.Width = 125;
            // 
            // CarYear
            // 
            CarYear.HeaderText = "Car Year";
            CarYear.MinimumWidth = 6;
            CarYear.Name = "CarYear";
            CarYear.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(619, 89);
            label1.TabIndex = 2;
            label1.Text = "PODDAŁEM :(((((((";
            label1.Click += label1_Click;
            // 
            // MainWidow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label1);
            Controls.Add(dataView);
            Controls.Add(button1);
            Name = "MainWidow";
            Text = "MainWindow";
            Load += MainWidow_Load;
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataView;
        private DataGridViewTextBoxColumn CarName;
        private DataGridViewTextBoxColumn CarModel;
        private DataGridViewTextBoxColumn CarYear;
        private Label label1;
    }
}