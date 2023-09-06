namespace PrimerPrograma
{
    partial class Form1
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
            btnVerMensaje = new Button();
            txtMensaje = new TextBox();
            SuspendLayout();
            // 
            // btnVerMensaje
            // 
            btnVerMensaje.Location = new Point(89, 191);
            btnVerMensaje.Name = "btnVerMensaje";
            btnVerMensaje.Size = new Size(102, 27);
            btnVerMensaje.TabIndex = 0;
            btnVerMensaje.Text = "Ver Mensaje";
            btnVerMensaje.UseVisualStyleBackColor = true;
            btnVerMensaje.Click += btnVerMensaje_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(24, 44);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(249, 23);
            txtMensaje.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 230);
            Controls.Add(txtMensaje);
            Controls.Add(btnVerMensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerMensaje;
        private TextBox txtMensaje;
    }
}