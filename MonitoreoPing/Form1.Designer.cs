namespace MonitoreoPing
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
            this.components = new System.ComponentModel.Container();
            this.btniniciar = new System.Windows.Forms.Button();
            this.timerchequeo = new System.Windows.Forms.Timer(this.components);
            this.btndetener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(12, 24);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // timerchequeo
            // 
            this.timerchequeo.Enabled = true;
            this.timerchequeo.Interval = 10000;
            this.timerchequeo.Tick += new System.EventHandler(this.timerchequeo_Tick);
            // 
            // btndetener
            // 
            this.btndetener.Location = new System.Drawing.Point(137, 24);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(75, 23);
            this.btndetener.TabIndex = 1;
            this.btndetener.Text = "Detener";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btniniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Timer timerchequeo;
        private System.Windows.Forms.Button btndetener;
    }
}

