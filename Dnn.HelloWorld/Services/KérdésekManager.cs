using HelloWorld.Dnn.Dnn.HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Dnn.Dnn.HelloWorld.Services
{
    internal interface KérdésekManager
    {
        Kérdések FindKérdésByID(int questionid);

        Answers[] FindVálaszokByQuestion(int questionid);
    }
}
