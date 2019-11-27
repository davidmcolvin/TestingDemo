namespace WinFormUI
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.addButton = new System.Windows.Forms.Button();
      this.subtractButton = new System.Windows.Forms.Button();
      this.multiplyButton = new System.Windows.Forms.Button();
      this.divideButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.resultsTextBox = new System.Windows.Forms.TextBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.usersComboBox = new System.Windows.Forms.ComboBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.createPersonButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.numericUpDown2);
      this.groupBox1.Controls.Add(this.numericUpDown1);
      this.groupBox1.Controls.Add(this.resultsTextBox);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.divideButton);
      this.groupBox1.Controls.Add(this.multiplyButton);
      this.groupBox1.Controls.Add(this.subtractButton);
      this.groupBox1.Controls.Add(this.addButton);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(54, 55);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(319, 226);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.createPersonButton);
      this.groupBox2.Controls.Add(this.lastNameTextBox);
      this.groupBox2.Controls.Add(this.firstNameTextBox);
      this.groupBox2.Controls.Add(this.usersComboBox);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Location = new System.Drawing.Point(424, 55);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(319, 226);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "groupBox2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "First Number";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Second Number";
      // 
      // addButton
      // 
      this.addButton.Location = new System.Drawing.Point(21, 95);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(75, 23);
      this.addButton.TabIndex = 4;
      this.addButton.Text = "Add";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // subtractButton
      // 
      this.subtractButton.Location = new System.Drawing.Point(21, 124);
      this.subtractButton.Name = "subtractButton";
      this.subtractButton.Size = new System.Drawing.Size(75, 23);
      this.subtractButton.TabIndex = 5;
      this.subtractButton.Text = "Subtract";
      this.subtractButton.UseVisualStyleBackColor = true;
      this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
      // 
      // multiplyButton
      // 
      this.multiplyButton.Location = new System.Drawing.Point(21, 153);
      this.multiplyButton.Name = "multiplyButton";
      this.multiplyButton.Size = new System.Drawing.Size(75, 23);
      this.multiplyButton.TabIndex = 6;
      this.multiplyButton.Text = "Multiply";
      this.multiplyButton.UseVisualStyleBackColor = true;
      this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
      // 
      // divideButton
      // 
      this.divideButton.Location = new System.Drawing.Point(21, 182);
      this.divideButton.Name = "divideButton";
      this.divideButton.Size = new System.Drawing.Size(75, 23);
      this.divideButton.TabIndex = 7;
      this.divideButton.Text = "Divide";
      this.divideButton.UseVisualStyleBackColor = true;
      this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(162, 131);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Results";
      // 
      // resultsTextBox
      // 
      this.resultsTextBox.Location = new System.Drawing.Point(165, 153);
      this.resultsTextBox.Name = "resultsTextBox";
      this.resultsTextBox.Size = new System.Drawing.Size(100, 20);
      this.resultsTextBox.TabIndex = 9;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(145, 28);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
      this.numericUpDown1.TabIndex = 10;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(145, 58);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
      this.numericUpDown2.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 46);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Users";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(22, 95);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(57, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "First Name";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(22, 124);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(55, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "LastName";
      // 
      // usersComboBox
      // 
      this.usersComboBox.FormattingEnabled = true;
      this.usersComboBox.Location = new System.Drawing.Point(120, 43);
      this.usersComboBox.Name = "usersComboBox";
      this.usersComboBox.Size = new System.Drawing.Size(121, 21);
      this.usersComboBox.TabIndex = 15;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(120, 121);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
      this.lastNameTextBox.TabIndex = 12;
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(120, 92);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
      this.firstNameTextBox.TabIndex = 13;
      // 
      // createPersonButton
      // 
      this.createPersonButton.Location = new System.Drawing.Point(25, 165);
      this.createPersonButton.Name = "createPersonButton";
      this.createPersonButton.Size = new System.Drawing.Size(75, 23);
      this.createPersonButton.TabIndex = 12;
      this.createPersonButton.Text = "Create";
      this.createPersonButton.UseVisualStyleBackColor = true;
      this.createPersonButton.Click += new System.EventHandler(this.createPersonButton_Click);
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 449);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Dashboard";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.TextBox resultsTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button divideButton;
    private System.Windows.Forms.Button multiplyButton;
    private System.Windows.Forms.Button subtractButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.ComboBox usersComboBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button createPersonButton;
  }
}

