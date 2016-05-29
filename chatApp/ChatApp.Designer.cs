namespace chatApp
{
    partial class ChatApp
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(62, 12);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(113, 20);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.Text = "beni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(207, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(104, 20);
            this.textBoxIP.TabIndex = 3;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(364, 12);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(64, 20);
            this.textBoxPuerto.TabIndex = 5;
            this.textBoxPuerto.Text = "2121";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puerto:";
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(437, 10);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(82, 23);
            this.buttonConectar.TabIndex = 6;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxOutput.Location = new System.Drawing.Point(13, 53);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(505, 148);
            this.richTextBoxOutput.TabIndex = 7;
            this.richTextBoxOutput.Text = "";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 215);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(298, 36);
            this.richTextBoxInput.TabIndex = 8;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyEnter);
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 295);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.textBoxPuerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "ChatApp";
            this.Text = "                       ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
    }
}

