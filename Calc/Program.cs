using System.Collections.Generic;

public class Calc
{
    //private List<string> historico;
    private List<string> historico;// = new List<string>();

    static void Main(string[] args)
    {

    }

    public Calc()
    {
        historico = new List<string>();
    }

    public string Somar(double n1, double n2)
    {
        var result = n1 + n2;
        AdicionaLista(result.ToString("0.00"));
        return result.ToString("0.00");
    }
    public string Subtrair(double n1, double n2)
    {
        var result = n1 - n2;
        AdicionaLista(result.ToString("0.00"));
        return result.ToString("0.00");
    }
    public string Multiplicar(double n1, double n2)
    {
        var result = n1 * n2;
        AdicionaLista(result.ToString("0.00"));
        return result.ToString("0.00");
    }
    public string Dividir(double n1, double n2)
    {
        var result = n1 / n2;
        AdicionaLista(result.ToString("0.00"));
        return result.ToString("0.00");
    }
    public List<string> Historico()
    {
        if (historico.Count>3)
        {
            historico.RemoveRange(3, historico.Count - 3);
        }
        return historico;
    }
    private void AdicionaLista(string result)
    {
        historico.Insert(0,$"Histórico = {result}");
    }
}