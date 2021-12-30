namespace ExercisesCs
{
    public class ChallengeStartsWith
    {
        public void StartWith()

        {
            Console.WriteLine("\n");
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }                
            }
        }
    }
}