namespace LojaInstrumentos.Models;

public static class InfoSistema
{
    public const string Nome = "Loja de Instrumentos Musicais";
    public const string Descricao = "Sistema de Vendas";
    public const string Versao = "1.0";

    public static string TituloJanela(string tela) => $"{Nome} — {tela}";

    public static string TextoSobre =>
        $"{Nome}\n{Descricao} — Versão {Versao}";
}
