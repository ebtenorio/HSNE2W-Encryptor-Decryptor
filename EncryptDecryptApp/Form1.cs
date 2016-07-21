using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PTI.Security;
using System.Diagnostics;

namespace EncryptDecryptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (this.hsnRadioButton.Checked)
            {
                this.targetStringTextBox.Text = this.HSNEncrypt(this.sourceStringTextBox.Text);
            }
            else if (this.edi2WebRadioButton.Checked)
            {
                this.targetStringTextBox.Text = this.EDI2WebEncrypt(this.sourceStringTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please select method.");
            }
            
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (this.hsnRadioButton.Checked)
            {
                this.targetStringTextBox.Text = this.HSNDecrypt(this.sourceStringTextBox.Text);
            }
            else if (this.edi2WebRadioButton.Checked)
            {
                this.targetStringTextBox.Text = this.EDI2WebDecrypt(this.sourceStringTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please select method.");
            }
         
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.sourceStringTextBox.Clear();
            this.targetStringTextBox.Clear();
            this.edi2WebRadioButton.Checked = false;
            this.hsnRadioButton.Checked = false;                
        }

        private string EDI2WebEncrypt(string sourceString)
        {
            SecuritySVC _securityService = new SecuritySVC();
            return _securityService.StringEncrypt(sourceString);
        }

        private string EDI2WebDecrypt(string sourceString)
        {
            SecuritySVC _securityService = new SecuritySVC();
            return _securityService.StringDecrypt(sourceString);          
        }

        private string HSNEncrypt(string sourceString)
        {
            PTI.Crypt _securityService = new PTI.Crypt();
            return _securityService.Encrypt(sourceString);
        }

        private string HSNDecrypt(string sourceString)
        {
            PTI.Crypt _securityService = new PTI.Crypt();
            return _securityService.Decrypt(sourceString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WriteToEventLog(this.newEventLogTextField.Text.Trim(), "Application", EventLogEntryType.Information, "THIS IS AN APPEVENT MESSAGE" + DateTime.Now);            
        }

        private void WriteToEventLog(string AppEventSource, string AppEventLog, EventLogEntryType AppEventType, string AppEventMessage)
        {
            try
            {
                if (!(EventLog.SourceExists(AppEventSource)))
                {
                    EventLog.CreateEventSource(AppEventSource, AppEventLog);
                }

                EventLog.WriteEntry(AppEventSource, AppEventMessage, AppEventType);

                MessageBox.Show("Done");

                this.newEventLogTextField.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
    
    }
}