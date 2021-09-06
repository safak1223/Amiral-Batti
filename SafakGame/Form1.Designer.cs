
namespace SafakGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.ServerporttextBox = new System.Windows.Forms.TextBox();
            this.ClientporttextBox = new System.Windows.Forms.TextBox();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "İP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PORT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PORT:";
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(139, 35);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(116, 20);
            this.ServerIPtextBox.TabIndex = 6;
            this.ServerIPtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(139, 137);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(116, 20);
            this.ClientIPtextBox.TabIndex = 7;
            // 
            // ServerporttextBox
            // 
            this.ServerporttextBox.Location = new System.Drawing.Point(378, 35);
            this.ServerporttextBox.Name = "ServerporttextBox";
            this.ServerporttextBox.Size = new System.Drawing.Size(116, 20);
            this.ServerporttextBox.TabIndex = 8;
            // 
            // ClientporttextBox
            // 
            this.ClientporttextBox.Location = new System.Drawing.Point(378, 141);
            this.ClientporttextBox.Name = "ClientporttextBox";
            this.ClientporttextBox.Size = new System.Drawing.Size(116, 20);
            this.ClientporttextBox.TabIndex = 9;
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.Location = new System.Drawing.Point(116, 202);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.Size = new System.Drawing.Size(464, 153);
            this.ChatScreentextBox.TabIndex = 10;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(116, 373);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(391, 20);
            this.MessagetextBox.TabIndex = 11;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(512, 32);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(68, 24);
            this.Startbutton.TabIndex = 12;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(512, 369);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(68, 24);
            this.Sendbutton.TabIndex = 13;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(512, 138);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(68, 24);
            this.Connectbutton.TabIndex = 14;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.ChatScreentextBox);
            this.Controls.Add(this.ClientporttextBox);
            this.Controls.Add(this.ServerporttextBox);
            this.Controls.Add(this.ClientIPtextBox);
            this.Controls.Add(this.ServerIPtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.TextBox ServerporttextBox;
        private System.Windows.Forms.TextBox ClientporttextBox;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

