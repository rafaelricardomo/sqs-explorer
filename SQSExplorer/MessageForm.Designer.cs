
namespace SQSExplorer
{
    partial class MessageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btReceiveLastMessageSelectedQueue = new System.Windows.Forms.Button();
            this.lblQueueSelected = new System.Windows.Forms.Label();
            this.lblReceivedLastMessageId = new System.Windows.Forms.Label();
            this.btDeleteLastMessage = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send message in selected queue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btSendMessage
            // 
            this.btSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendMessage.Location = new System.Drawing.Point(24, 522);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(126, 23);
            this.btSendMessage.TabIndex = 3;
            this.btSendMessage.Text = "Send message";
            this.btSendMessage.UseVisualStyleBackColor = true;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessages_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2000, 61);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(24, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(905, 393);
            this.textBox1.TabIndex = 6;
            // 
            // btReceiveLastMessageSelectedQueue
            // 
            this.btReceiveLastMessageSelectedQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReceiveLastMessageSelectedQueue.Location = new System.Drawing.Point(156, 522);
            this.btReceiveLastMessageSelectedQueue.Name = "btReceiveLastMessageSelectedQueue";
            this.btReceiveLastMessageSelectedQueue.Size = new System.Drawing.Size(159, 23);
            this.btReceiveLastMessageSelectedQueue.TabIndex = 7;
            this.btReceiveLastMessageSelectedQueue.Text = "Receive Last Message";
            this.btReceiveLastMessageSelectedQueue.UseVisualStyleBackColor = true;
            this.btReceiveLastMessageSelectedQueue.Click += new System.EventHandler(this.btReceiveLastMessageSelectedQueue_Click);
            // 
            // lblQueueSelected
            // 
            this.lblQueueSelected.AutoSize = true;
            this.lblQueueSelected.Location = new System.Drawing.Point(366, 76);
            this.lblQueueSelected.Name = "lblQueueSelected";
            this.lblQueueSelected.Size = new System.Drawing.Size(88, 15);
            this.lblQueueSelected.TabIndex = 8;
            this.lblQueueSelected.Text = "Queue selected";
            // 
            // lblReceivedLastMessageId
            // 
            this.lblReceivedLastMessageId.AutoSize = true;
            this.lblReceivedLastMessageId.Location = new System.Drawing.Point(646, 76);
            this.lblReceivedLastMessageId.Name = "lblReceivedLastMessageId";
            this.lblReceivedLastMessageId.Size = new System.Drawing.Size(130, 15);
            this.lblReceivedLastMessageId.TabIndex = 9;
            this.lblReceivedLastMessageId.Text = "Receive last id message";
            // 
            // btDeleteLastMessage
            // 
            this.btDeleteLastMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteLastMessage.Location = new System.Drawing.Point(321, 522);
            this.btDeleteLastMessage.Name = "btDeleteLastMessage";
            this.btDeleteLastMessage.Size = new System.Drawing.Size(127, 23);
            this.btDeleteLastMessage.TabIndex = 10;
            this.btDeleteLastMessage.Text = "Delete last message";
            this.btDeleteLastMessage.UseVisualStyleBackColor = true;
            this.btDeleteLastMessage.Click += new System.EventHandler(this.btDeleteLastMessage_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(549, 522);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 561);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btDeleteLastMessage);
            this.Controls.Add(this.lblReceivedLastMessageId);
            this.Controls.Add(this.lblQueueSelected);
            this.Controls.Add(this.btReceiveLastMessageSelectedQueue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.Text = "SQS Explorer";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btReceiveLastMessageSelectedQueue;
        private System.Windows.Forms.Label lblQueueSelected;
        private System.Windows.Forms.Label lblReceivedLastMessageId;
        private System.Windows.Forms.Button btDeleteLastMessage;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

