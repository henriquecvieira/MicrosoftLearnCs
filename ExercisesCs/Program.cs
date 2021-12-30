using System;

namespace ExercisesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            StringNames names = new StringNames();
            names.stringName();        

            Inventory obj = new Inventory();
            obj.Invent();
               
            ChallengeStartsWith ID = new ChallengeStartsWith();
            ID.StartWith();
             
            
        }

       
       

    }       
}