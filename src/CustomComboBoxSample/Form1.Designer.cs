namespace CustomComboBoxSample
{
    partial class Form1
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
            this.myComboBox1 = new CustomComboBoxSample.MyComboBox();
            this.myComboBox2 = new CustomComboBoxSample.MyComboBox();
            this.myComboBox3 = new CustomComboBoxSample.MyComboBox();
            this.SuspendLayout();
            // 
            // myComboBox1
            // 
            this.myComboBox1.AutoWidthDropDown = true;
            this.myComboBox1.DropDownAlignment = CustomComboBoxSample.MyComboBox.DropDownAlignments.Left;
            this.myComboBox1.FormattingEnabled = true;
            this.myComboBox1.Items.AddRange(new object[] {
            "Lorem ipsum dolor sit amet",
            "consectetur adipiscing elit, sed do eiusmod",
            "tempor incididunt ut labore et dolore magna aliqua.",
            "Ut enim ad minim veniam"});
            this.myComboBox1.Location = new System.Drawing.Point(12, 12);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.Size = new System.Drawing.Size(121, 21);
            this.myComboBox1.TabIndex = 0;
            // 
            // myComboBox2
            // 
            this.myComboBox2.AutoWidthDropDown = true;
            this.myComboBox2.DropDownAlignment = CustomComboBoxSample.MyComboBox.DropDownAlignments.Middle;
            this.myComboBox2.FormattingEnabled = true;
            this.myComboBox2.Items.AddRange(new object[] {
            "Lorem ipsum dolor sit amet",
            "consectetur adipiscing elit, sed do eiusmod",
            "tempor incididunt ut labore et dolore magna aliqua.",
            "Ut enim ad minim veniam"});
            this.myComboBox2.Location = new System.Drawing.Point(12, 39);
            this.myComboBox2.Name = "myComboBox2";
            this.myComboBox2.Size = new System.Drawing.Size(121, 21);
            this.myComboBox2.TabIndex = 0;
            // 
            // myComboBox3
            // 
            this.myComboBox3.AutoWidthDropDown = true;
            this.myComboBox3.DropDownAlignment = CustomComboBoxSample.MyComboBox.DropDownAlignments.Right;
            this.myComboBox3.FormattingEnabled = true;
            this.myComboBox3.Items.AddRange(new object[] {
            "Lorem ipsum dolor sit amet",
            "consectetur adipiscing elit, sed do eiusmod",
            "tempor incididunt ut labore et dolore magna aliqua.",
            "Ut enim ad minim veniam"});
            this.myComboBox3.Location = new System.Drawing.Point(12, 66);
            this.myComboBox3.Name = "myComboBox3";
            this.myComboBox3.Size = new System.Drawing.Size(121, 21);
            this.myComboBox3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 133);
            this.Controls.Add(this.myComboBox3);
            this.Controls.Add(this.myComboBox2);
            this.Controls.Add(this.myComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyComboBox myComboBox1;
        private MyComboBox myComboBox2;
        private MyComboBox myComboBox3;
    }
}

