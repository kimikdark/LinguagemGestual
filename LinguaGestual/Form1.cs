using System.Windows.Forms;

namespace LinguaGestual
{
    public partial class Form1 : Form
    {
        private string textoParaTraduzir;
        private int indiceAtual = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public char ConverterAcentos(char c)
        {
            switch (char.ToUpper(c))
            {
                case '�':
                case '�':
                case '�':
                case '�':
                    return 'A';
                case '�':
                case '�':
                case '�':
                    return 'E';
                case '�':
                case '�':
                case '�':
                    return 'I';
                case '�':
                case '�':
                case '�':
                case '�':
                    return 'O';
                case '�':
                case '�':
                case '�':
                    return 'U';
                case '�':
                    return 'C';
                default:
                    return c;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Limpa a PictureBox para o caso de uma nova tradu��o
            pbVisualizador.Image = null;

            // Obt�m o texto da TextBox e o transforma para letras mai�sculas para facilitar a correspond�ncia
            textoParaTraduzir = txtMensagem.Text.ToUpper();

            // Reinicia o �ndice para o in�cio da frase
            indiceAtual = 0;

            // Inicia o Timer para come�ar a tradu��o
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1500; // Define o intervalo para 2seg
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (indiceAtual < textoParaTraduzir.Length)
            {
                char letra = textoParaTraduzir[indiceAtual];

                // Converte a letra e verifica se � um caractere v�lido
                char letraProcessada = ConverterAcentos(letra);

                // Aceder � imagem diretamente a partir dos recursos
                try
                {
                    // O nome do recurso � a letra em mai�scula
                    string nomeDoRecurso = letraProcessada.ToString().ToUpper();

                    // Aceder aos recursos do projeto e obter o objeto da imagem
                    object recursoDaImagem = Properties.Resources.ResourceManager.GetObject(nomeDoRecurso);

                    if (recursoDaImagem != null)
                    {
                        pbVisualizador.Image = (System.Drawing.Image)recursoDaImagem;
                    }
                    else
                    {
                        // Limpa a PictureBox se o recurso n�o for encontrado (ex: espa�os ou caracteres especiais)
                        pbVisualizador.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar o recurso da imagem: {ex.Message}");
                }

                indiceAtual++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Tradu��o conclu�da!");
            }
        }
    }
}
