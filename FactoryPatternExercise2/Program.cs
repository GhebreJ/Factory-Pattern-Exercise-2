namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? :");

            var db = DataAccessFactory.GetDataAccessType(Console.ReadLine());

            db.SaveData();
            db.LoadData();
        }
    }
}
