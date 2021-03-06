﻿namespace TestClient
{
    partial class ClientForm1
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
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_remote = new System.Windows.Forms.TextBox();
            this.textBox_local = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sid = new System.Windows.Forms.TextBox();
            this.button_init = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.cb_isUdp = new System.Windows.Forms.CheckBox();
            this.cb_unreliable = new System.Windows.Forms.CheckBox();
            this.button_sendunreliable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(147, 99);
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(100, 21);
            this.textBox_msg.TabIndex = 19;
            this.textBox_msg.Text = "hello";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(12, 99);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 18;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "sid";
            // 
            // textBox_remote
            // 
            this.textBox_remote.Location = new System.Drawing.Point(379, 9);
            this.textBox_remote.Name = "textBox_remote";
            this.textBox_remote.Size = new System.Drawing.Size(129, 21);
            this.textBox_remote.TabIndex = 16;
            this.textBox_remote.Text = "127.0.0.1:1000";
            // 
            // textBox_local
            // 
            this.textBox_local.Location = new System.Drawing.Point(118, 6);
            this.textBox_local.Name = "textBox_local";
            this.textBox_local.Size = new System.Drawing.Size(129, 21);
            this.textBox_local.TabIndex = 15;
            this.textBox_local.Text = "127.0.0.1:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "remote ipep";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "local ipep";
            // 
            // textBox_sid
            // 
            this.textBox_sid.Location = new System.Drawing.Point(147, 56);
            this.textBox_sid.Name = "textBox_sid";
            this.textBox_sid.Size = new System.Drawing.Size(100, 21);
            this.textBox_sid.TabIndex = 12;
            this.textBox_sid.Text = "0";
            // 
            // button_init
            // 
            this.button_init.Location = new System.Drawing.Point(12, 54);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(75, 23);
            this.button_init.TabIndex = 11;
            this.button_init.Text = "Init";
            this.button_init.UseVisualStyleBackColor = true;
            this.button_init.Click += new System.EventHandler(this.button_init_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(269, 59);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 20;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // cb_isUdp
            // 
            this.cb_isUdp.AutoSize = true;
            this.cb_isUdp.Location = new System.Drawing.Point(14, 30);
            this.cb_isUdp.Name = "cb_isUdp";
            this.cb_isUdp.Size = new System.Drawing.Size(72, 16);
            this.cb_isUdp.TabIndex = 21;
            this.cb_isUdp.Text = "Test UDP";
            this.cb_isUdp.UseVisualStyleBackColor = true;
            // 
            // cb_unreliable
            // 
            this.cb_unreliable.AutoSize = true;
            this.cb_unreliable.Checked = true;
            this.cb_unreliable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_unreliable.Location = new System.Drawing.Point(118, 33);
            this.cb_unreliable.Name = "cb_unreliable";
            this.cb_unreliable.Size = new System.Drawing.Size(102, 16);
            this.cb_unreliable.TabIndex = 22;
            this.cb_unreliable.Text = "Test ClientEx";
            this.cb_unreliable.UseVisualStyleBackColor = true;
            // 
            // button_sendunreliable
            // 
            this.button_sendunreliable.Location = new System.Drawing.Point(14, 155);
            this.button_sendunreliable.Name = "button_sendunreliable";
            this.button_sendunreliable.Size = new System.Drawing.Size(181, 23);
            this.button_sendunreliable.TabIndex = 23;
            this.button_sendunreliable.Text = "Send Unreliable";
            this.button_sendunreliable.UseVisualStyleBackColor = true;
            this.button_sendunreliable.Click += new System.EventHandler(this.button_sendunreliable_Click);
            // 
            // ClientForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 245);
            this.Controls.Add(this.button_sendunreliable);
            this.Controls.Add(this.cb_unreliable);
            this.Controls.Add(this.cb_isUdp);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_remote);
            this.Controls.Add(this.textBox_local);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sid);
            this.Controls.Add(this.button_init);
            this.Name = "ClientForm1";
            this.Text = "CForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_remote;
        private System.Windows.Forms.TextBox textBox_local;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sid;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.CheckBox cb_isUdp;
        private System.Windows.Forms.CheckBox cb_unreliable;
        private System.Windows.Forms.Button button_sendunreliable;
    }
}

