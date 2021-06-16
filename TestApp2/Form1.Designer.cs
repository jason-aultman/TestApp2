namespace TestApp2
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
            this.rtbOne = new System.Windows.Forms.RichTextBox();
            this.btnActivateTextBoxText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOne
            // 
            this.rtbOne.Location = new System.Drawing.Point(90, 51);
            this.rtbOne.Name = "rtbOne";
            this.rtbOne.Size = new System.Drawing.Size(403, 372);
            this.rtbOne.TabIndex = 0;
            this.rtbOne.Text = "Hello";
            // 
            // btnActivateTextBoxText
            // 
            this.btnActivateTextBoxText.Location = new System.Drawing.Point(579, 71);
            this.btnActivateTextBoxText.Name = "btnActivateTextBoxText";
            this.btnActivateTextBoxText.Size = new System.Drawing.Size(75, 23);
            this.btnActivateTextBoxText.TabIndex = 1;
            this.btnActivateTextBoxText.Text = "button1";
            this.btnActivateTextBoxText.UseVisualStyleBackColor = true;
            this.btnActivateTextBoxText.Click += new System.EventHandler(this.btnActivateTextBoxText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActivateTextBoxText);
            this.Controls.Add(this.rtbOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOne;
        private System.Windows.Forms.Button btnActivateTextBoxText;
    }
}

