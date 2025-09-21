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
            txtMensagem = new TextBox();
            btnConverter = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbVisualizador).BeginInit();
            SuspendLayout();
            // 
            // pbVisualizador
            // 
            pbVisualizador.Location = new Point(68, 75);
            pbVisualizador.Name = "pbVisualizador";
            pbVisualizador.Size = new Size(265, 383);
            pbVisualizador.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVisualizador.TabIndex = 0;
            pbVisualizador.TabStop = false;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(365, 192);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(346, 84);
            txtMensagem.TabIndex = 1;
            txtMensagem.Text = "Digite a mensagem a traduzir!";
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(365, 306);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(346, 29);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter Mensagem";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 553);
            Controls.Add(btnConverter);
            Controls.Add(txtMensagem);
            Controls.Add(pbVisualizador);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Linguagem Gestual";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbVisualizador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVisualizador;
        private TextBox txtMensagem;
        private Button btnConverter;
        private System.Windows.Forms.Timer timer1;
    }
}
