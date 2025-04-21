
namespace DelegateUseCase
{
    public class ClassOne {
        private int key=12;
        public int PrintPrivateProperty()
        {
            return key;
        }
        public static void Main()
        {
            ClassTwo obj2 = new ClassTwo();
            ClassOne obj = new ClassOne();
            var before = obj.PrintPrivateProperty();
            Console.WriteLine("Before: " + before);
            var after = obj2.ChangePrivateProperty(ref obj.key);  
            Console.WriteLine("After: " + after);   


        }
    }
    public class ClassTwo
    {
        public int ChangePrivateProperty(ref int key)
        {
            key = 10;
            return key;
        }

    }
    

    


}