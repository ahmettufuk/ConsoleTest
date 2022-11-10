using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Model
    {
        public List<string> Datas = new List<string>();

        public Model()
        {
            Datas.Add("Mail");
            Datas.Add("Sms");
            Datas.Add("Push");
        }

    }
}
