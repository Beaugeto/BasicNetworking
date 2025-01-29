namespace ClientApp
{
    partial class ClientForm
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
            this.SystemMsg_TextBox = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Send_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Receive_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Send_TextBox_C = new System.Windows.Forms.TextBox();
            this.Send_Button_C = new System.Windows.Forms.Button();
            this.SystemMsg_TextBox_C = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-414, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "System Messages:";
            // 
            // SystemMsg_TextBox
            // 
            this.SystemMsg_TextBox.Location = new System.Drawing.Point(-404, 700);
            this.SystemMsg_TextBox.Multiline = true;
            this.SystemMsg_TextBox.Name = "SystemMsg_TextBox";
            this.SystemMsg_TextBox.Size = new System.Drawing.Size(386, 158);
            this.SystemMsg_TextBox.TabIndex = 11;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(-404, 448);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(149, 48);
            this.Send_Button.TabIndex = 10;
            this.Send_Button.Text = "SEND";
            this.Send_Button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-414, -108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter your message here:";
            // 
            // Send_TextBox
            // 
            this.Send_TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Send_TextBox.Location = new System.Drawing.Point(-404, -52);
            this.Send_TextBox.Multiline = true;
            this.Send_TextBox.Name = "Send_TextBox";
            this.Send_TextBox.Size = new System.Drawing.Size(386, 206);
            this.Send_TextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-462, -288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server";
            // 
            // Receive_TextBox
            // 
            this.Receive_TextBox.Location = new System.Drawing.Point(638, 137);
            this.Receive_TextBox.Multiline = true;
            this.Receive_TextBox.Name = "Receive_TextBox";
            this.Receive_TextBox.Size = new System.Drawing.Size(469, 529);
            this.Receive_TextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter your message here:";
            // 
            // Send_TextBox_C
            // 
            this.Send_TextBox_C.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Send_TextBox_C.Location = new System.Drawing.Point(48, 137);
            this.Send_TextBox_C.Multiline = true;
            this.Send_TextBox_C.Name = "Send_TextBox_C";
            this.Send_TextBox_C.Size = new System.Drawing.Size(386, 206);
            this.Send_TextBox_C.TabIndex = 15;
            // 
            // Send_Button_C
            // 
            this.Send_Button_C.Location = new System.Drawing.Point(48, 373);
            this.Send_Button_C.Name = "Send_Button_C";
            this.Send_Button_C.Size = new System.Drawing.Size(149, 48);
            this.Send_Button_C.TabIndex = 16;
            this.Send_Button_C.Text = "SEND";
            this.Send_Button_C.UseVisualStyleBackColor = true;
            this.Send_Button_C.Click += new System.EventHandler(this.Send_Button_C_Click);
            // 
            // SystemMsg_TextBox_C
            // 
            this.SystemMsg_TextBox_C.Location = new System.Drawing.Point(48, 508);
            this.SystemMsg_TextBox_C.Multiline = true;
            this.SystemMsg_TextBox_C.Name = "SystemMsg_TextBox_C";
            this.SystemMsg_TextBox_C.Size = new System.Drawing.Size(386, 158);
            this.SystemMsg_TextBox_C.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "System Messages:";
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.Location = new System.Drawing.Point(12, 18);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(104, 37);
            this.Client.TabIndex = 19;
            this.Client.Text = "Client";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 364);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SystemMsg_TextBox_C);
            this.Controls.Add(this.Send_Button_C);
            this.Controls.Add(this.Send_TextBox_C);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Receive_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SystemMsg_TextBox);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SystemMsg_TextBox;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Send_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Receive_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Send_TextBox_C;
        private System.Windows.Forms.Button Send_Button_C;
        private System.Windows.Forms.TextBox SystemMsg_TextBox_C;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Client;
    }
}

