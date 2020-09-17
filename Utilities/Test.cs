using System;
namespace Utilities
{
    public interface iTest 
    {
        void Test1();
        int Test2();
        String Test3(String s, int y);
    };


    public class Test : iTest
    {
        public void Test1()
        {

        }
        public int Test2()
        {
            return 1;
        }
        public String Test3(String s, int y)
        {
            return s + y;
        }
    }
}
