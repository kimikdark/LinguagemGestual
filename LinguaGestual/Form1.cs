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
                case 'Á':
                case 'À':
                case 'Ã':
                case 'Â':
                    return 'A';
                case 'É':
                case 'È':
                case 'Ê':
                    return 'E';
                case 'Í':
                case 'Ì':
                case 'Î':
                    return 'I';
                case 'Ó':
                case 'Ò':
                case 'Õ':
                case 'Ô':
                    return 'O';
                case 'Ú':
                case 'Ù':
                case 'Û':
                    return 'U';
                case 'Ç':
                    return 'C';
                default:
                    return c;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Limpa a PictureBox para o caso de uma nova tradução
            pbVisualizador.Image = null;

            // Obtém o texto da TextBox e o transforma para letras maiúsculas para facilitar a correspondência
            textoParaTraduzir = txtMensagem.Text.ToUpper();

            // Reinicia o índice para o início da frase
            indiceAtual = 0;

            // Inicia o Timer para começar a tradução
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

                // Converte a letra e verifica se é um caractere válido
                char letraProcessada = ConverterAcentos(letra);

                // Aceder à imagem diretamente a partir dos recursos
                try
                {
                    // O nome do recurso é a letra em maiúscula
                    string nomeDoRecurso = letraProcessada.ToString().ToUpper();

                    // Aceder aos recursos do projeto e obter o objeto da imagem
                    object recursoDaImagem = Properties.Resources.ResourceManager.GetObject(nomeDoRecurso);

                    if (recursoDaImagem != null)
                    {
                        pbVisualizador.Image = (System.Drawing.Image)recursoDaImagem;
                    }
                    else
                    {
                        // Limpa a PictureBox se o recurso não for encontrado (ex: espaços ou caracteres especiais)
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
                MessageBox.Show("Tradução concluída!");
            }
        }
    }
}
