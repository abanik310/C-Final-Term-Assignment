namespace Diary.Presentation
{
    partial class EntryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxEntryDateContrl = new System.Windows.Forms.DateTimePicker();
            this.tbxTitleContrl = new System.Windows.Forms.TextBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.tbxEntry = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tbxEntryDateContrl
            // 
            this.tbxEntryDateContrl.Location = new System.Drawing.Point(24, 75);
            this.tbxEntryDateContrl.Name = "tbxEntryDateContrl";
            this.tbxEntryDateContrl.Size = new System.Drawing.Size(201, 20);
            this.tbxEntryDateContrl.TabIndex = 1;
            // 
            // tbxTitleContrl
            // 
            this.tbxTitleContrl.Location = new System.Drawing.Point(82, 17);
            this.tbxTitleContrl.Multiline = true;
            this.tbxTitleContrl.Name = "tbxTitleContrl";
            this.tbxTitleContrl.Size = new System.Drawing.Size(433, 25);
            this.tbxTitleContrl.TabIndex = 2;
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(19, 135);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(66, 25);
            this.lblEntry.TabIndex = 3;
            this.lblEntry.Text = "Entry";
            // 
            // tbxEntry
            // 
            this.tbxEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEntry.Location = new System.Drawing.Point(24, 173);
            this.tbxEntry.Name = "tbxEntry";
            this.tbxEntry.Size = new System.Drawing.Size(491, 288);
            this.tbxEntry.TabIndex = 4;
            this.tbxEntry.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.Location = new System.Drawing.Point(418, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxEntry);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.tbxTitleContrl);
            this.Controls.Add(this.tbxEntryDateContrl);
            this.Controls.Add(this.lblTitle);
            this.Name = "EntryControl";
            this.Size = new System.Drawing.Size(582, 575);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker tbxEntryDateContrl;
        private System.Windows.Forms.TextBox tbxTitleContrl;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.RichTextBox tbxEntry;
        private System.Windows.Forms.Button btnSave;
    }
}
