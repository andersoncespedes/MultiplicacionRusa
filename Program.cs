using System.Security.Principal;

public static class Program{
    public static int MultiplicacionRusa(int Multiplicador, int Multiplicando){
        int sum = 0;
        while(Multiplicador >= 1){
            if(Multiplicador % 2 != 0){
                sum += Multiplicando;
            }
            Multiplicador = (int)Math.Floor((double)Multiplicador / 2);
            Multiplicando *= 2;
            
        };
        return sum;
    }
    public static void Main(string[] args){
        Console.Write("Ingrese Multiplicador ->");
        int Multiplicador = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el Multiplicando -> ");
        int Multiplicando = int.Parse(Console.ReadLine());
        Console.WriteLine("Resultado :" +MultiplicacionRusa(Multiplicador,Multiplicando));
    }
       
}
