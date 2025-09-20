namespace LinguaGestual
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbVisualizador = new PictureBox();
            txtFrase = new TextBox();
            btnConverter = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbVisualizador).BeginInit();
            SuspendLayout();
            // 
            // pbVisualizador
            // 
            pbVisualizador.Location = new Point(167, 143);
            pbVisualizador.Name = "pbVisualizador";
            pbVisualizador.Size = new Size(346, 488);
            pbVisualizador.TabIndex = 0;
            pbVisualizador.TabStop = false;
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(591, 258);
            txtFrase.Multiline = true;
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(346, 84);
            txtFrase.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(591, 364);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(346, 29);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter Mensagem";
            btnConverter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnConverter);
            Controls.Add(txtFrase);
            Controls.Add(pbVisualizador);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Linguagem Gestual";
            ((System.ComponentModel.ISupportInitialize)pbVisualizador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVisualizador;
        private TextBox txtFrase;
        private Button btnConverter;
        private System.Windows.Forms.Timer timer1;
    }
}
