using SistemaBCCSLN;

class Program
{
    static void Main(string[] args)
    {
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 15000;
        meuPix.ChavePix = "contato@gemini.com";

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;
        
        PessoaJuridica pJuridica = new PessoaJuridica();
        PessoaFisica pFisica = new PessoaFisica();

        IConversorGrandeza converter = new ConversorBilhoes();
        decimal valorBI = converter.Converter(meuPix.Valor);

        converter = new ConversorTrilhoes();
        decimal valorTRI = converter.Converter(meuPix.Valor);

        Console.WriteLine($"PIX de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");
    }
    public static void ExibirRelatorio(decimal valorBruto, IConversorGrandeza conversor)
    {
        decimal valorConvertido = conversor.Converter(valorBruto);
        Console.WriteLine($"Valor convertido: {valorConvertido:N2} {conversor.ObterSimbolo()}");
    }
}
