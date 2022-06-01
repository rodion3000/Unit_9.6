using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_9._6
{
    public class MyException:Exception
    {
        public MyException()
        {
            Exception exception1 = new Exception("Произошло новое исключение 1");
            exception1.Data.Add("Создание исключения:", DateTime.Now);
            exception1.HelpLink = "Новое исключение 1";
            
        }
    }
}
