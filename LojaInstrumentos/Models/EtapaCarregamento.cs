namespace LojaInstrumentos.Models;

public class EtapaCarregamento
{
    public int ProgressoLimite { get; }
    public string Mensagem { get; }

    public EtapaCarregamento(int progressoLimite, string mensagem)
    {
        ProgressoLimite = progressoLimite;
        Mensagem = mensagem;
    }

    public static IReadOnlyList<EtapaCarregamento> Padrao { get; } = new List<EtapaCarregamento>
    {
        new(25, "Iniciando o sistema..."),
        new(50, "Carregando catálogo de instrumentos..."),
        new(75, "Preparando módulo de vendas..."),
        new(100, "Carregando relatórios...")
    };

    public static string ObterMensagem(int progresso)
    {
        foreach (var etapa in Padrao)
        {
            if (progresso < etapa.ProgressoLimite)
            {
                return etapa.Mensagem;
            }
        }

        return "Pronto!";
    }
}
