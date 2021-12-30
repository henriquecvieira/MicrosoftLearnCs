namespace ExercisesCs
{
    public class StringNames
    {
        public void stringName()
        {
            Console.WriteLine("______________________________________");

            string[] names = { "Theodoro", "Arthur", "Aurora" };
            foreach (string name in names)            
            {               
               Console.WriteLine(name);
            }

               Console.WriteLine("______________________________________");
               Console.WriteLine("\n");
        }
    }
}