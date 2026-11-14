class Program
{
    static void Main(string[] args)
    {
        practice4 chaR = new practice4('A');
        String STR = new String('B', "Привет");
        Int INT = new Int('C', "Гойда", 42);

        chaR.Print();
        Console.WriteLine();
        STR.Print();
        Console.WriteLine();
        INT.Print();
        Console.WriteLine();

        practice4 opa1 = new practice4(chaR);
        String opa2 = new String(STR);
        Int opa3 = new Int(INT);

        INT.Char = 'Z';
        INT.StringField = "Копия";
        INT.IntField = 67;

        Console.WriteLine("Оригинал INT после изменения:");
        INT.Print();

        Console.WriteLine("Копия opa3 :");
        opa3.Print();

        Console.ReadKey();
    }
}


class practice4
{
    public char Char;
    public practice4(char С)
    {
        Char = С;
    }
    public practice4(practice4 box)
    {
        Char = box.Char;
    }
    public void Print()
    {
        Console.WriteLine($"[char] символ:{Char}");
    }
}
class String : practice4
{
    public string StringField;

    public String(char С, string S) : base(С)
    {
        StringField = S;
    }
    public String(String box) : base(box)
    {
        StringField = box.StringField;
    }
    public void Print()
    {
        base.Print();
        Console.WriteLine($"[String] символ:{StringField}");
    }
}
class Int : String
{
    public int IntField;

    public Int(char C, string S, int I) : base(C, S)
    {
        IntField = I;
    }
    public Int(Int box) : base(box)
    {
        IntField = box.IntField;
    }
    public void Print()
    {
        base.Print();
        Console.WriteLine($"[Int] символ:{IntField}");
    }
}