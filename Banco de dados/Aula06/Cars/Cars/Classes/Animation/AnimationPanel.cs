namespace Cars.Classes.Animation;

/// <summary>
/// Controla a animação horizontal de abertura e fechamento de um painel.
/// </summary>
public sealed class AnimationPanel
{
    // Painel que terá a largura alterada durante a animação.
    private readonly Panel painel;

    // Timer responsável por atualizar o tamanho do painel continuamente.
    private readonly System.Windows.Forms.Timer timerAnimacao = new();

    // Guarda a largura original do painel antes de ele ser fechado.
    private readonly int larguraOriginal;

    // Quantidade de pixels adicionados ou removidos a cada atualização.
    private const int passoAnimacao = 20;

    // Indica a direção atual da animação.
    private DirecaoAnimacao direcaoAtual;

    // Possíveis direções da animação.
    private enum DirecaoAnimacao
    {
        Abrir,
        Fechar
    }

    /// <summary>
    /// Cria o controlador de animação para o painel informado.
    /// </summary>
    /// <param name="painel">Painel que será animado.</param>
    public AnimationPanel(Panel painel)
    {
        // Garante que um painel válido seja recebido pelo construtor.
        ArgumentNullException.ThrowIfNull(painel);

        this.painel = painel;
        larguraOriginal = painel.Width;

        // Define a velocidade da animação.
        timerAnimacao.Interval = 15;

        // Executa o método de atualização a cada intervalo do Timer.
        timerAnimacao.Tick += AtualizarAnimacao;

        // O painel começa fechado, mas sua largura original continua armazenada.
        painel.Width = 0;
    }

    /// <summary>
    /// Inicia a animação de abertura do painel.
    /// </summary>
    public void Abrir()
    {
        // Interrompe uma animação anterior antes de iniciar uma nova direção.
        timerAnimacao.Stop();
        direcaoAtual = DirecaoAnimacao.Abrir;
        timerAnimacao.Start();
    }

    /// <summary>
    /// Inicia a animação de fechamento do painel.
    /// </summary>
    public void Fechar()
    {
        // Interrompe uma animação anterior antes de iniciar uma nova direção.
        timerAnimacao.Stop();
        direcaoAtual = DirecaoAnimacao.Fechar;
        timerAnimacao.Start();
    }

    /// <summary>
    /// Altera gradualmente a largura do painel conforme a direção atual.
    /// </summary>
    private void AtualizarAnimacao(object? remetente, EventArgs argumentos)
    {
        if (direcaoAtual == DirecaoAnimacao.Abrir)
        {
            // Aumenta gradualmente a largura do painel.
            painel.Width += passoAnimacao;

            // Finaliza a abertura quando o tamanho original for atingido.
            if (painel.Width >= larguraOriginal)
            {
                painel.Width = larguraOriginal;
                timerAnimacao.Stop();
            }

            return;
        }

        // Diminui gradualmente a largura do painel.
        painel.Width -= passoAnimacao;

        // Finaliza o fechamento quando a largura chegar a zero.
        if (painel.Width <= 0)
        {
            painel.Width = 0;
            timerAnimacao.Stop();
        }
    }
}
