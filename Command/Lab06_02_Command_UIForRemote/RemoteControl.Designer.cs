
namespace Lab06_RemoteControl
{
    partial class RemoteControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSlot1 = new System.Windows.Forms.ComboBox();
            this.txtStatus1 = new System.Windows.Forms.TextBox();
            this.btnOn1 = new System.Windows.Forms.Button();
            this.btnOFF1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSlot2 = new System.Windows.Forms.ComboBox();
            this.btnON2 = new System.Windows.Forms.Button();
            this.btnOFF2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnDoor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSlot3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOFF3 = new System.Windows.Forms.Button();
            this.btnON3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slot 01";
            // 
            // cboSlot1
            // 
            this.cboSlot1.FormattingEnabled = true;
            this.cboSlot1.Items.AddRange(new object[] {
            "Light",
            "TV",
            "Door"});
            this.cboSlot1.Location = new System.Drawing.Point(81, 15);
            this.cboSlot1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSlot1.Name = "cboSlot1";
            this.cboSlot1.Size = new System.Drawing.Size(115, 24);
            this.cboSlot1.TabIndex = 1;
            this.cboSlot1.SelectedIndexChanged += new System.EventHandler(this.cboSlot1_SelectedIndexChanged);
            // 
            // txtStatus1
            // 
            this.txtStatus1.Location = new System.Drawing.Point(24, 386);
            this.txtStatus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.Size = new System.Drawing.Size(36, 22);
            this.txtStatus1.TabIndex = 2;
            // 
            // btnOn1
            // 
            this.btnOn1.Location = new System.Drawing.Point(217, 12);
            this.btnOn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOn1.Name = "btnOn1";
            this.btnOn1.Size = new System.Drawing.Size(43, 28);
            this.btnOn1.TabIndex = 3;
            this.btnOn1.Text = "ON";
            this.btnOn1.UseVisualStyleBackColor = true;
            this.btnOn1.Click += new System.EventHandler(this.btnOn1_Click);
            // 
            // btnOFF1
            // 
            this.btnOFF1.Location = new System.Drawing.Point(268, 12);
            this.btnOFF1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOFF1.Name = "btnOFF1";
            this.btnOFF1.Size = new System.Drawing.Size(49, 28);
            this.btnOFF1.TabIndex = 4;
            this.btnOFF1.Text = "OFF";
            this.btnOFF1.UseVisualStyleBackColor = true;
            this.btnOFF1.Click += new System.EventHandler(this.btnOFF1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slot 02";
            // 
            // cboSlot2
            // 
            this.cboSlot2.FormattingEnabled = true;
            this.cboSlot2.Items.AddRange(new object[] {
            "Light",
            "TV",
            "Door"});
            this.cboSlot2.Location = new System.Drawing.Point(81, 60);
            this.cboSlot2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSlot2.Name = "cboSlot2";
            this.cboSlot2.Size = new System.Drawing.Size(115, 24);
            this.cboSlot2.TabIndex = 1;
            this.cboSlot2.SelectedIndexChanged += new System.EventHandler(this.cboSlot2_SelectedIndexChanged);
            // 
            // btnON2
            // 
            this.btnON2.Location = new System.Drawing.Point(217, 58);
            this.btnON2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnON2.Name = "btnON2";
            this.btnON2.Size = new System.Drawing.Size(43, 28);
            this.btnON2.TabIndex = 3;
            this.btnON2.Text = "ON";
            this.btnON2.UseVisualStyleBackColor = true;
            this.btnON2.Click += new System.EventHandler(this.btnON2_Click);
            // 
            // btnOFF2
            // 
            this.btnOFF2.Location = new System.Drawing.Point(268, 58);
            this.btnOFF2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOFF2.Name = "btnOFF2";
            this.btnOFF2.Size = new System.Drawing.Size(49, 28);
            this.btnOFF2.TabIndex = 4;
            this.btnOFF2.Text = "OFF";
            this.btnOFF2.UseVisualStyleBackColor = true;
            this.btnOFF2.Click += new System.EventHandler(this.btnOFF2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đèn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng khách";
            // 
            // btnTV
            // 
            this.btnTV.Location = new System.Drawing.Point(81, 383);
            this.btnTV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(64, 28);
            this.btnTV.TabIndex = 7;
            this.btnTV.Text = "TV";
            this.btnTV.UseVisualStyleBackColor = true;
            // 
            // btnDoor
            // 
            this.btnDoor.Location = new System.Drawing.Point(185, 383);
            this.btnDoor.Name = "btnDoor";
            this.btnDoor.Size = new System.Drawing.Size(58, 26);
            this.btnDoor.TabIndex = 8;
            this.btnDoor.Text = "Door";
            this.btnDoor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Door";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboSlot3
            // 
            this.cboSlot3.FormattingEnabled = true;
            this.cboSlot3.Items.AddRange(new object[] {
            "Light",
            "TV",
            "Door"});
            this.cboSlot3.Location = new System.Drawing.Point(81, 106);
            this.cboSlot3.Margin = new System.Windows.Forms.Padding(4);
            this.cboSlot3.Name = "cboSlot3";
            this.cboSlot3.Size = new System.Drawing.Size(115, 24);
            this.cboSlot3.TabIndex = 10;
            this.cboSlot3.SelectedIndexChanged += new System.EventHandler(this.cboSlot3_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Slot 03";
            // 
            // btnOFF3
            // 
            this.btnOFF3.Location = new System.Drawing.Point(268, 106);
            this.btnOFF3.Margin = new System.Windows.Forms.Padding(4);
            this.btnOFF3.Name = "btnOFF3";
            this.btnOFF3.Size = new System.Drawing.Size(49, 28);
            this.btnOFF3.TabIndex = 13;
            this.btnOFF3.Text = "OFF";
            this.btnOFF3.UseVisualStyleBackColor = true;
            this.btnOFF3.Click += new System.EventHandler(this.btnOFF3_Click);
            // 
            // btnON3
            // 
            this.btnON3.Location = new System.Drawing.Point(217, 106);
            this.btnON3.Margin = new System.Windows.Forms.Padding(4);
            this.btnON3.Name = "btnON3";
            this.btnON3.Size = new System.Drawing.Size(43, 28);
            this.btnON3.TabIndex = 12;
            this.btnON3.Text = "ON";
            this.btnON3.UseVisualStyleBackColor = true;
            this.btnON3.Click += new System.EventHandler(this.btnON3_Click_1);
            // 
            // RemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 633);
            this.Controls.Add(this.btnOFF3);
            this.Controls.Add(this.btnON3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSlot3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDoor);
            this.Controls.Add(this.btnTV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOFF2);
            this.Controls.Add(this.btnOFF1);
            this.Controls.Add(this.btnON2);
            this.Controls.Add(this.btnOn1);
            this.Controls.Add(this.txtStatus1);
            this.Controls.Add(this.cboSlot2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSlot1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RemoteControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSlot1;
        private System.Windows.Forms.TextBox txtStatus1;
        private System.Windows.Forms.Button btnOn1;
        private System.Windows.Forms.Button btnOFF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSlot2;
        private System.Windows.Forms.Button btnON2;
        private System.Windows.Forms.Button btnOFF2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btnDoor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSlot3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOFF3;
        private System.Windows.Forms.Button btnON3;
    }
}

