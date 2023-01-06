namespace Task_18._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
    abstract class BaseClass
    {
        protected int Imp { get; }

        public BaseClass(int imp)
        {
            Imp = imp;
        }
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Imp}");
        }
        public abstract BaseClass Clone();
    }
    class ImplementationOne : BaseClass
    {
        public ImplementationOne(int imp) : base(imp)
        { }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Imp);
        }
    }
    class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int imp) : base(imp)
        { }

        public override BaseClass Clone()
        {
            return new ImplementationTwo(Imp);
        }
    }
}