using static DelegateUseCase.ClassOne;

namespace DelegateUseCase
{
    

    public class ClassOne
    {
        static void Main(string[] args)
        {
            var classOne = new ClassOne();
            var classTwo = new ClassTwo();
            ChangePropertyDelegate delegateMethod = classOne.SetMyProperty;
            classOne.ShowValue();
            classTwo.InvokeDelegate(delegateMethod);
            classOne.ShowValue();
        }
        private int MyProperty { get; set; }
        public void SetMyProperty(int value)
        {
            MyProperty = value;
        }
        public void ShowValue()
        {
            Console.WriteLine($"MyProperty = {MyProperty}");
        }
        public delegate void ChangePropertyDelegate(int value);

    }
    public class ClassTwo
    {
        public void InvokeDelegate(ChangePropertyDelegate delegateMethod)
        {
            int i = int.Parse(Console.ReadLine());
            delegateMethod(i);
        }
         
    }


}