using DotNetNuke.Data;
using HelloWorld.Dnn.Dnn.HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace HelloWorld.Dnn.Dnn.HelloWorld.Services.Implementations
{
    public class KérdésekController : Controller
    {
        
        public Kérdések FindKérdésByID(int questionid)
        {
            using (var ctx = DataContext.Instance())
            {
                var r = ctx.GetRepository<Kérdések>();
                return r.GetById(questionid);
            }
        }

        public Kérdések FindKérdésByIDJson(int questionid)
        {
            using (var ctx = DataContext.Instance())
            {
                var r = ctx.GetRepository<Kérdések>();
                string stringjson = JsonConvert.SerializeObject(r.GetById(questionid));
                return r.GetById(questionid);
            }
        }

        public Answers[] FindVálaszokByQuestion(int questionid)
        {
            using (var ctx = DataContext.Instance())
            {
                return ctx.GetRepository<Answers>()
                    .Find("WHERE QuestionID = @0", questionid)
                    .ToArray();
            }
        }
    }
}