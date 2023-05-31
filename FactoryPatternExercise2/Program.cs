namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Data Base of Interest? ('sql','mongo', or 'list'");

            var dbType= Console.ReadLine();

            var dataAccess = DataAccessFactory.GetDataBase(dbType);

            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}
