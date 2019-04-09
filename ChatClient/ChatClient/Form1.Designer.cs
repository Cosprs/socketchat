namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_printmessages = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_sendmessage = new System.Windows.Forms.TextBox();
            this.tb_pseudo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_printmessages
            // 
            this.tb_printmessages.Location = new System.Drawing.Point(34, 79);
            this.tb_printmessages.Multiline = true;
            this.tb_printmessages.Name = "tb_printmessages";
            this.tb_printmessages.Size = new System.Drawing.Size(556, 335);
            this.tb_printmessages.TabIndex = 0;
            this.tb_printmessages.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(481, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_sendmessage
            // 
            this.tb_sendmessage.Location = new System.Drawing.Point(34, 430);
            this.tb_sendmessage.Name = "tb_sendmessage";
            this.tb_sendmessage.Size = new System.Drawing.Size(556, 20);
            this.tb_sendmessage.TabIndex = 2;
            // 
            // tb_pseudo
            // 
            this.tb_pseudo.Location = new System.Drawing.Point(545, 4);
            this.tb_pseudo.Name = "tb_pseudo";
            this.tb_pseudo.Size = new System.Drawing.Size(154, 20);
            this.tb_pseudo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(545, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Choisir mon pseudo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tb_pseudo);
            this.panel1.Controls.Add(this.tb_sendmessage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_printmessages);
            this.panel1.Location = new System.Drawing.Point(48, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 513);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 572);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_printmessages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_sendmessage;
        private System.Windows.Forms.TextBox tb_pseudo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

