
namespace Engine.Errors.Warming
{
    partial class WarmingError
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
            this.L_ErrorMessage = new System.Windows.Forms.Label();
            this.B_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_ErrorMessage
            // 
            this.L_ErrorMessage.AutoSize = true;
            this.L_ErrorMessage.Location = new System.Drawing.Point(13, 13);
            this.L_ErrorMessage.Name = "L_ErrorMessage";
            this.L_ErrorMessage.Size = new System.Drawing.Size(46, 17);
            this.L_ErrorMessage.TabIndex = 0;
            this.L_ErrorMessage.Text = "label1";
            // 
            // B_Ok
            // 
            this.B_Ok.Location = new System.Drawing.Point(16, 34);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(75, 23);
            this.B_Ok.TabIndex = 1;
            this.B_Ok.Text = "Ok";
            this.B_Ok.UseVisualStyleBackColor = true;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
            // 
            // WarmingError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Ok);
            this.Controls.Add(this.L_ErrorMessage);
            this.Name = "WarmingError";
            this.Text = "WarmingError";
            this.Load += new System.EventHandler(this.WarmingError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_ErrorMessage;
        private System.Windows.Forms.Button B_Ok;
    }
}