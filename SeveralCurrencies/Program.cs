using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Pour pouvoir afficher des caractères encodé en UTF8 dans la console
        Console.OutputEncoding = Encoding.UTF8;

        float money = 7.77f;

        ShowMoney showMoney;

        showMoney = ShowDollars;
        Console.WriteLine(showMoney(money));

        showMoney = ShowEuros;
        Console.WriteLine(showMoney(money));
    }

    public delegate string ShowMoney(float money);

    public static string ShowDollars(float money)
    {
        return $"{money} $";
    }

    public static string ShowEuros(float money)
    {
        return $"{money} €";
    }
}