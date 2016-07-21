namespace EncryptDecryptApp
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.sourceStringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targetStringTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.hsnRadioButton = new System.Windows.Forms.RadioButton();
            this.edi2WebRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.newEventLogTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(148, 202);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(229, 202);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // sourceStringTextBox
            // 
            this.sourceStringTextBox.Location = new System.Drawing.Point(12, 96);
            this.sourceStringTextBox.Name = "sourceStringTextBox";
            this.sourceStringTextBox.Size = new System.Drawing.Size(373, 20);
            this.sourceStringTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target String";
            // 
            // targetStringTextBox
            // 
            this.targetStringTextBox.Location = new System.Drawing.Point(12, 160);
            this.targetStringTextBox.Name = "targetStringTextBox";
            this.targetStringTextBox.Size = new System.Drawing.Size(373, 20);
            this.targetStringTextBox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(310, 202);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // hsnRadioButton
            // 
            this.hsnRadioButton.AutoSize = true;
            this.hsnRadioButton.Location = new System.Drawing.Point(12, 12);
            this.hsnRadioButton.Name = "hsnRadioButton";
            this.hsnRadioButton.Size = new System.Drawing.Size(48, 17);
            this.hsnRadioButton.TabIndex = 7;
            this.hsnRadioButton.TabStop = true;
            this.hsnRadioButton.Text = "HSN";
            this.hsnRadioButton.UseVisualStyleBackColor = true;
            // 
            // edi2WebRadioButton
            // 
            this.edi2WebRadioButton.AutoSize = true;
            this.edi2WebRadioButton.Location = new System.Drawing.Point(12, 35);
            this.edi2WebRadioButton.Name = "edi2WebRadioButton";
            this.edi2WebRadioButton.Size = new System.Drawing.Size(71, 17);
            this.edi2WebRadioButton.TabIndex = 8;
            this.edi2WebRadioButton.TabStop = true;
            this.edi2WebRadioButton.Text = "EDi2Web";
            this.edi2WebRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Write to Event Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newEventLogTextField
            // 
            this.newEventLogTextField.Location = new System.Drawing.Point(15, 272);
            this.newEventLogTextField.Name = "newEventLogTextField";
            this.newEventLogTextField.Size = new System.Drawing.Size(237, 20);
            this.newEventLogTextField.TabIndex = 10;
            this.newEventLogTextField.Text = "WSTranslator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 324);
            this.Controls.Add(this.newEventLogTextField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edi2WebRadioButton);
            this.Controls.Add(this.hsnRadioButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.targetStringTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceStringTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form1";
            this.Text = "Decrypt and Encrypt String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox sourceStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targetStringTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton hsnRadioButton;
        private System.Windows.Forms.RadioButton edi2WebRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newEventLogTextField;
    }
}

