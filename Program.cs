
internal class Program
{
    private static void Main(string[] args)
    {   Console.Clear();
        Snake.Point p1 = new Snake.Point(1, 3, '*');
        /*p1.x = 1;
        p1.y = 3;
        p1.sym = '*'; */
        p1.Draw();

        Snake.Point p2 = new Snake.Point(4, 5, '#');
        /*p2.x = 4;
        p2.y = 5;
        p2.sym = '#'; */
        p2.Draw(); 
        
    }
    
}
