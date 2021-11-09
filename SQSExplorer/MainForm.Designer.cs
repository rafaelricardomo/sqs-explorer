
namespace SQSExplorer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxQueues = new System.Windows.Forms.ListBox();
            this.btRefreshQueues = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btSendMessageSelectedQueue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEspecificacoesQueue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queues";
            // 
            // listBoxQueues
            // 
            this.listBoxQueues.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxQueues.FormattingEnabled = true;
            this.listBoxQueues.ItemHeight = 15;
            this.listBoxQueues.Location = new System.Drawing.Point(24, 92);
            this.listBoxQueues.Name = "listBoxQueues";
            this.listBoxQueues.Size = new System.Drawing.Size(404, 424);
            this.listBoxQueues.TabIndex = 2;
            // 
            // btRefreshQueues
            // 
            this.btRefreshQueues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshQueues.Location = new System.Drawing.Point(24, 522);
            this.btRefreshQueues.Name = "btRefreshQueues";
            this.btRefreshQueues.Size = new System.Drawing.Size(104, 23);
            this.btRefreshQueues.TabIndex = 3;
            this.btRefreshQueues.Text = "Refresh Queues";
            this.btRefreshQueues.UseVisualStyleBackColor = true;
            this.btRefreshQueues.Click += new System.EventHandler(this.btRefreshQueues_Click);
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
            // 
            // btSendMessageSelectedQueue
            // 
            this.btSendMessageSelectedQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendMessageSelectedQueue.Location = new System.Drawing.Point(656, 522);
            this.btSendMessageSelectedQueue.Name = "btSendMessageSelectedQueue";
            this.btSendMessageSelectedQueue.Size = new System.Drawing.Size(245, 23);
            this.btSendMessageSelectedQueue.TabIndex = 6;
            this.btSendMessageSelectedQueue.Text = "Click for send Message in Queue Selected";
            this.btSendMessageSelectedQueue.UseVisualStyleBackColor = true;
            this.btSendMessageSelectedQueue.Click += new System.EventHandler(this.btSendMessageSelectedQueue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEspecificacoesQueue);
            this.groupBox1.Location = new System.Drawing.Point(469, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 422);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Queue detail";
            // 
            // textBoxEspecificacoesQueue
            // 
            this.textBoxEspecificacoesQueue.AcceptsTab = true;
            this.textBoxEspecificacoesQueue.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxEspecificacoesQueue.Enabled = false;
            this.textBoxEspecificacoesQueue.Location = new System.Drawing.Point(29, 37);
            this.textBoxEspecificacoesQueue.Multiline = true;
            this.textBoxEspecificacoesQueue.Name = "textBoxEspecificacoesQueue";
            this.textBoxEspecificacoesQueue.Size = new System.Drawing.Size(403, 355);
            this.textBoxEspecificacoesQueue.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 561);
            this.Controls.Add(this.btSendMessageSelectedQueue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btRefreshQueues);
            this.Controls.Add(this.listBoxQueues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SQS Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxQueues;
        private System.Windows.Forms.Button btRefreshQueues;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSendMessageSelectedQueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEspecificacoesQueue;
    }
}

