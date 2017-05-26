namespace ShortestPath
{
    partial class Main
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.GreenCircleLabel = new System.Windows.Forms.Label();
            this.ClosestGreenRadioButton = new System.Windows.Forms.RadioButton();
            this.CreatLineLeftSideRadioButton = new System.Windows.Forms.RadioButton();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(129, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(530, 430);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // GreenCircleLabel
            // 
            this.GreenCircleLabel.AutoSize = true;
            this.GreenCircleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenCircleLabel.Location = new System.Drawing.Point(133, 28);
            this.GreenCircleLabel.Name = "GreenCircleLabel";
            this.GreenCircleLabel.Size = new System.Drawing.Size(260, 25);
            this.GreenCircleLabel.TabIndex = 3;
            this.GreenCircleLabel.Text = "Move around Green circle";
            // 
            // ClosestGreenRadioButton
            // 
            this.ClosestGreenRadioButton.AutoSize = true;
            this.ClosestGreenRadioButton.Location = new System.Drawing.Point(12, 68);
            this.ClosestGreenRadioButton.Name = "ClosestGreenRadioButton";
            this.ClosestGreenRadioButton.Size = new System.Drawing.Size(103, 17);
            this.ClosestGreenRadioButton.TabIndex = 4;
            this.ClosestGreenRadioButton.TabStop = true;
            this.ClosestGreenRadioButton.Text = "Closest to Green";
            this.ClosestGreenRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreatLineLeftSideRadioButton
            // 
            this.CreatLineLeftSideRadioButton.AutoSize = true;
            this.CreatLineLeftSideRadioButton.Location = new System.Drawing.Point(12, 91);
            this.CreatLineLeftSideRadioButton.Name = "CreatLineLeftSideRadioButton";
            this.CreatLineLeftSideRadioButton.Size = new System.Drawing.Size(87, 17);
            this.CreatLineLeftSideRadioButton.TabIndex = 5;
            this.CreatLineLeftSideRadioButton.TabStop = true;
            this.CreatLineLeftSideRadioButton.Text = "LeftSide Line";
            this.CreatLineLeftSideRadioButton.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(399, 37);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(131, 13);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "(Press and Hold Ctrl+LMB)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 510);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.CreatLineLeftSideRadioButton);
            this.Controls.Add(this.ClosestGreenRadioButton);
            this.Controls.Add(this.GreenCircleLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.LoadButton);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "ShortestPath";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label GreenCircleLabel;
        private System.Windows.Forms.RadioButton ClosestGreenRadioButton;
        private System.Windows.Forms.RadioButton CreatLineLeftSideRadioButton;
        private System.Windows.Forms.Label labelInfo;
    }
}

