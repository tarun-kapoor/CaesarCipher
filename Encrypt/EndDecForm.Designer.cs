namespace Encrypt
{
    partial class EncDecForm
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
            this.components = new System.ComponentModel.Container();
            this.txtEncDec = new System.Windows.Forms.TextBox();
            this.btnDec = new System.Windows.Forms.Button();
            this.cbEnc = new System.Windows.Forms.CheckBox();
            this.btnEnc = new System.Windows.Forms.Button();
            this.toolTipEnc = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtEncDec
            // 
            this.txtEncDec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncDec.Location = new System.Drawing.Point(12, 7);
            this.txtEncDec.Multiline = true;
            this.txtEncDec.Name = "txtEncDec";
            this.txtEncDec.Size = new System.Drawing.Size(426, 275);
            this.txtEncDec.TabIndex = 0;
            // 
            // btnDec
            // 
            this.btnDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDec.Location = new System.Drawing.Point(362, 288);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(76, 25);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Dec";
            this.toolTipEnc.SetToolTip(this.btnDec, "Press Escape to Decrypt the Text");
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnEncDec_Click);
            // 
            // cbEnc
            // 
            this.cbEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnc.AutoSize = true;
            this.cbEnc.Location = new System.Drawing.Point(12, 296);
            this.cbEnc.Name = "cbEnc";
            this.cbEnc.Size = new System.Drawing.Size(87, 17);
            this.cbEnc.TabIndex = 2;
            this.cbEnc.Text = "Enc on Input";
            this.toolTipEnc.SetToolTip(this.cbEnc, "Check this to Encrypt the text as you type");
            this.cbEnc.UseVisualStyleBackColor = true;
            this.cbEnc.CheckedChanged += new System.EventHandler(this.cbEnc_CheckedChanged);
            // 
            // btnEnc
            // 
            this.btnEnc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnc.Location = new System.Drawing.Point(280, 288);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(76, 25);
            this.btnEnc.TabIndex = 3;
            this.btnEnc.Text = "Enc";
            this.toolTipEnc.SetToolTip(this.btnEnc, "Press Enter to Encrypt the Text");
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // toolTipEnc
            // 
            this.toolTipEnc.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipEnc.ToolTipTitle = "Encrypt Decrypt by Tarun Kapoor";
            // 
            // EncDecForm
            // 
            this.AcceptButton = this.btnEnc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDec;
            this.ClientSize = new System.Drawing.Size(450, 325);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.cbEnc);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.txtEncDec);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 520);
            this.MinimumSize = new System.Drawing.Size(282, 196);
            this.Name = "EncDecForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "EncDec - Tarun Kapoor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncDec;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.CheckBox cbEnc;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.ToolTip toolTipEnc;
    }
}

