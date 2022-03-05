namespace Portageiro3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCircular2 = new Portageiro3.BotaoCircular();
            this.botaoCircular1 = new Portageiro3.BotaoCircular();
            this.label3 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.botaoCircular2);
            this.panel1.Controls.Add(this.botaoCircular1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(395, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 701);
            this.panel1.TabIndex = 1;
            // 
            // botaoCircular2
            // 
            this.botaoCircular2.BackColor = System.Drawing.Color.White;
            this.botaoCircular2.BackgroundColor = System.Drawing.Color.White;
            this.botaoCircular2.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCircular2.BorderRadius = 20;
            this.botaoCircular2.BorderSize = 1;
            this.botaoCircular2.FlatAppearance.BorderSize = 0;
            this.botaoCircular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCircular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCircular2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCircular2.Location = new System.Drawing.Point(47, 474);
            this.botaoCircular2.Name = "botaoCircular2";
            this.botaoCircular2.Size = new System.Drawing.Size(329, 40);
            this.botaoCircular2.TabIndex = 8;
            this.botaoCircular2.Text = "Limpar campos";
            this.botaoCircular2.TextColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCircular2.UseVisualStyleBackColor = false;
            this.botaoCircular2.Click += new System.EventHandler(this.botaoCircular2_Click);
            // 
            // botaoCircular1
            // 
            this.botaoCircular1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCircular1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCircular1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botaoCircular1.BorderRadius = 20;
            this.botaoCircular1.BorderSize = 0;
            this.botaoCircular1.FlatAppearance.BorderSize = 0;
            this.botaoCircular1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCircular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCircular1.ForeColor = System.Drawing.Color.White;
            this.botaoCircular1.Location = new System.Drawing.Point(47, 422);
            this.botaoCircular1.Name = "botaoCircular1";
            this.botaoCircular1.Size = new System.Drawing.Size(329, 40);
            this.botaoCircular1.TabIndex = 7;
            this.botaoCircular1.Text = "Entrar";
            this.botaoCircular1.TextColor = System.Drawing.Color.White;
            this.botaoCircular1.UseVisualStyleBackColor = false;
            this.botaoCircular1.Click += new System.EventHandler(this.botaoCircular1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(51, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // senha
            // 
            this.senha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.senha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.senha.BackColor = System.Drawing.SystemColors.Control;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.senha.Location = new System.Drawing.Point(47, 372);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(330, 27);
            this.senha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(51, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 701);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // username
            // 
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.username.Location = new System.Drawing.Point(47, 305);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(329, 27);
            this.username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(95, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sessão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Portageiro3.Properties.Resources.toll_login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 701);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senha;
        private BotaoCircular botaoCircular1;
        private BotaoCircular botaoCircular2;
    }
}

