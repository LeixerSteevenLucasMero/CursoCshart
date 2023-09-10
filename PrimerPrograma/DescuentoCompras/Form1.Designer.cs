namespace DescuentoCompras
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
            textCompra = new TextBox();
            label1 = new Label();
            btnConsultar = new Button();
            label2 = new Label();
            textDescuento = new TextBox();
            label3 = new Label();
            textDesTotal = new TextBox();
            SuspendLayout();
            // 
            // textCompra
            // 
            textCompra.Location = new Point(51, 55);
            textCompra.Name = "textCompra";
            textCompra.Size = new Size(158, 23);
            textCompra.TabIndex = 0;
            textCompra.Text = "Valor de la compra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 27);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el valor de la compra";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(88, 233);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 92);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor del descuento";
            // 
            // textDescuento
            // 
            textDescuento.Location = new Point(51, 120);
            textDescuento.Name = "textDescuento";
            textDescuento.Size = new Size(158, 23);
            textDescuento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 157);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor total con el descuento";
            // 
            // textDesTotal
            // 
            textDesTotal.Location = new Point(51, 185);
            textDesTotal.Name = "textDesTotal";
            textDesTotal.ScrollBars = ScrollBars.Vertical;
            textDesTotal.Size = new Size(158, 23);
            textDesTotal.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 348);
            Controls.Add(label3);
            Controls.Add(textDesTotal);
            Controls.Add(label2);
            Controls.Add(textDescuento);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Controls.Add(textCompra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCompra;
        private Label label1;
        private Button btnConsultar;
        private Label label2;
        private TextBox textDescuento;
        private Label label3;
        private TextBox textDesTotal;
    }
}