
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
            this.btSendMessage.Text = "SEND MESSAGE";
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
            this.textBox1.Location = new System.Drawing.Point(24, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 393);
            this.textBox1.TabIndex = 6;
            // 
            // btReceiveLastMessageSelectedQueue
            // 
            this.btReceiveLastMessageSelectedQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReceiveLastMessageSelectedQueue.Location = new System.Drawing.Point(604, 522);
            this.btReceiveLastMessageSelectedQueue.Name = "btReceiveLastMessageSelectedQueue";
            this.btReceiveLastMessageSelectedQueue.Size = new System.Drawing.Size(159, 23);
            this.btReceiveLastMessageSelectedQueue.TabIndex = 7;
            this.btReceiveLastMessageSelectedQueue.Text = "RECEIVE LAST MESSAGE";
            this.btReceiveLastMessageSelectedQueue.UseVisualStyleBackColor = true;
            this.btReceiveLastMessageSelectedQueue.Click += new System.EventHandler(this.btReceiveLastMessageSelectedQueue_Click);
            // 
            // lblQueueSelected
            // 
            this.lblQueueSelected.AutoSize = true;
            this.lblQueueSelected.Location = new System.Drawing.Point(255, 76);
            this.lblQueueSelected.Name = "lblQueueSelected";
            this.lblQueueSelected.Size = new System.Drawing.Size(88, 15);
            this.lblQueueSelected.TabIndex = 8;
            this.lblQueueSelected.Text = "Queue selected";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
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
    }
}

