// Коробка спичек: 
// -	фирма изготовитель; 
// -	число спичек в коробке; 
// -	время горения одной спички (с). 
//     Q = (число спичек) · время 

// P: средний % бракованных 
// спичек в коробке 
//  
//     Qp = ( 100-Р)Q / 100 


using task4;

class Program
{
    static void Main(string[] args)
    {
        Matchbox matchbox = new Matchbox("First Company", 100, 5.5);
        Console.WriteLine(matchbox.ToString());
        Console.WriteLine(matchbox.GetQ() + "\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        MatchBoxChild matchBoxChild = new MatchBoxChild("Second Company", 110, 6.1, 15);
        Console.WriteLine(matchBoxChild.ToString());
        Console.WriteLine(matchBoxChild.GetQ());
        Console.WriteLine();
        
    }
}