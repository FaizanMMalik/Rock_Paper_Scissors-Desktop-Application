
namespace client2
{
    partial class Chatbox
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
            this.label3 = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtcmsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Message :";
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 15;
            this.listbox.Location = new System.Drawing.Point(249, 204);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(337, 169);
            this.listbox.TabIndex = 17;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(478, 161);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 37);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtcmsg
            // 
            this.txtcmsg.Location = new System.Drawing.Point(279, 78);
            this.txtcmsg.Multiline = true;
            this.txtcmsg.Name = "txtcmsg";
            this.txtcmsg.Size = new System.Drawing.Size(307, 66);
            this.txtcmsg.TabIndex = 15;
            // 
            // Chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtcmsg);
            this.Name = "Chatbox";
            this.Text = "Chatbox";
            this.Load += new System.EventHandler(this.Chatbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtcmsg;
    }
}