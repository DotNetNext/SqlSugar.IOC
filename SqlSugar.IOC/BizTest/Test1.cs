using System;

namespace BizTest
{
    public class Test1:ITest  
    {
        public int Id { get; set; }
    }
    public interface ITest
    {
       int Id { get; set; }
    }
}
