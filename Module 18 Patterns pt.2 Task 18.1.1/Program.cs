using System.Text;

namespace Module_18_Patterns_pt._2_Task_18._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Объект завода, который будет заниматься производством
            var carPlant = new CarPlant();

            // производство скутеров
            Conveyor builder = new ScooterConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            // производство автомобилей
            builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            // производство мотоциклов
            builder = new MotoConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();
        }
    }
}