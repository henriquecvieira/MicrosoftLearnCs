namespace ExercisesCs
{
    public class Inventory
    {
        public void Invent()
        {
            int[] invent = { 200, 450, 700, 175, 650, 580, 890, };
            int sum = 0;
            int bin = 0;
            foreach (int items in invent)
            {
               sum += items;
               bin++;
               Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in invent.");    
            Console.WriteLine("______________________________________");
         


        }
       
    }
    
}





    

