
namespace DMav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmtwButton = new System.Windows.Forms.Button();
            this.cwtmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmtwButton
            // 
            this.cmtwButton.Location = new System.Drawing.Point(11, 12);
            this.cmtwButton.Name = "cmtwButton";
            this.cmtwButton.Size = new System.Drawing.Size(173, 23);
            this.cmtwButton.TabIndex = 3;
            this.cmtwButton.TabStop = false;
            this.cmtwButton.Text = "Convert MP3 to WAV";
            this.cmtwButton.UseVisualStyleBackColor = true;
            this.cmtwButton.Click += new System.EventHandler(this.cmtw_Click);
            // 
            // cwtmButton
            // 
            this.cwtmButton.Location = new System.Drawing.Point(11, 41);
            this.cwtmButton.Name = "cwtmButton";
            this.cwtmButton.Size = new System.Drawing.Size(173, 23);
            this.cwtmButton.TabIndex = 4;
            this.cwtmButton.TabStop = false;
            this.cwtmButton.Text = "Convert WAV to MP3";
            this.cwtmButton.UseVisualStyleBackColor = true;
            this.cwtmButton.Click += new System.EventHandler(this.cwtmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 76);
            this.Controls.Add(this.cwtmButton);
            this.Controls.Add(this.cmtwButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMav";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmtwButton;
        private System.Windows.Forms.Button cwtmButton;
    }
}

