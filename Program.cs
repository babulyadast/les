using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<People> collection = new List<People>();
        People s = new People("Положай Алина Андреевна", new DateOnly (2003,15,12));
        People l = new People("Николаева Анастасия Александровна", new DateOnly(2004, 04, 29));
        People o = new People("Тимакова Елизавета Дмитриевна", new DateOnly(2002, 04, 04));
        collection.Add(s);
        collection.Add (l);
        collection.Add (o);

        foreach(var item in collection)
        {
           Console.WriteLine(item.GetPassport());
        }
    }
}
class People
{
    private string _name;
    private string _family;
    private string _patronomic;

    private DateOnly _birthdaty;
    private int _age;

    public People (string fio, DateOnly date)
    {
        var fio_arr = fio.Split (' ');
        if (fio_arr.Length <= 2)
            return;

        _name = fio_arr[0];
        _family = fio_arr[1];
        _patronomic = fio_arr[2];

        _age = DateTime.Now.Year - date.Year;
    }
    public string GetPassport()
    {
        string info = $"Имя{_name}\n Фамилия{_family}\n Отчество{_patronomic} Возраст {_age}";
        return info ;
    }
}