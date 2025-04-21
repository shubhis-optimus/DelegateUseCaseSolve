using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUseCase
{
    public class ClassOnee
    {
        private int key { get; set; } = 12;

        public int GetKey()
        {
            return key;
        }

        public void SetKey(int value)
        {
            key = value;
        }

        public int PrintPrivateProperty()
        {
            return key;
        }

        public static void Main()
        {
            ClassTwoo obj2 = new ClassTwoo();
            ClassOnee obj = new ClassOnee();
            var before = obj.PrintPrivateProperty();
            Console.WriteLine("Before: " + before);
            var after = obj2.ChangePrivateProperty(obj);
            Console.WriteLine("After: " + after);
        }
    }
    public class ClassTwoo
    {
        public int ChangePrivateProperty(ClassOnee obj)
        {
            int change = int.Parse(Console.ReadLine());

            obj.SetKey(change);
            return obj.GetKey();
        }
    }

}
