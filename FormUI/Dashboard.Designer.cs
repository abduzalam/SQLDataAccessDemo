namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNametextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameAddtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameAddtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailAddtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumAddtextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 20;
            this.peopleFoundListBox.Location = new System.Drawing.Point(75, 125);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(441, 164);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNametextBox
            // 
            this.lastNametextBox.Location = new System.Drawing.Point(238, 38);
            this.lastNametextBox.Name = "lastNametextBox";
            this.lastNametextBox.Size = new System.Drawing.Size(278, 26);
            this.lastNametextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(71, 41);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(220, 79);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(128, 28);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // firstNameAddtextBox
            // 
            this.firstNameAddtextBox.Location = new System.Drawing.Point(238, 314);
            this.firstNameAddtextBox.Name = "firstNameAddtextBox";
            this.firstNameAddtextBox.Size = new System.Drawing.Size(278, 26);
            this.firstNameAddtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // lastNameAddtextBox
            // 
            this.lastNameAddtextBox.Location = new System.Drawing.Point(238, 358);
            this.lastNameAddtextBox.Name = "lastNameAddtextBox";
            this.lastNameAddtextBox.Size = new System.Drawing.Size(278, 26);
            this.lastNameAddtextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address";
            // 
            // EmailAddtextBox
            // 
            this.EmailAddtextBox.Location = new System.Drawing.Point(238, 399);
            this.EmailAddtextBox.Name = "EmailAddtextBox";
            this.EmailAddtextBox.Size = new System.Drawing.Size(278, 26);
            this.EmailAddtextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            // 
            // PhoneNumAddtextBox
            // 
            this.PhoneNumAddtextBox.Location = new System.Drawing.Point(238, 442);
            this.PhoneNumAddtextBox.Name = "PhoneNumAddtextBox";
            this.PhoneNumAddtextBox.Size = new System.Drawing.Size(278, 26);
            this.PhoneNumAddtextBox.TabIndex = 10;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(220, 504);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(128, 28);
            this.Addbutton.TabIndex = 12;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumAddtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailAddtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameAddtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameAddtextBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNametextBox);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNametextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameAddtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameAddtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailAddtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumAddtextBox;
        private System.Windows.Forms.Button Addbutton;
    }
}

