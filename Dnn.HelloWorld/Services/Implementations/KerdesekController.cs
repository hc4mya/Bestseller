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
    public class KerdesekController : Controller
    {
        
        public Kérdések FindKerdesByID(int questionid)
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

        public Answers[] FindValaszokByQuestion(int questionid)
        {
            using (var ctx = DataContext.Instance())
            {
                return ctx.GetRepository<Answers>()
                    .Find("WHERE QuestionID = @0", questionid)
                    .ToArray();
            }
        }






        [HttpPost]
        public JsonResult FindKerdesByIDJson(int sorszam)
        {
            var question = GetQuestionByID(sorszam); // Replace with actual method to fetch question
            var answers = GetAnswersByQuestionID(sorszam); // Replace with actual method to fetch answers
            return Json(new { QuestionText = question.QuestionText, Answers = answers });
        }

        // Dummy methods for example purposes
        private Kérdések GetQuestionByID(int questionid)
        {
            using (var ctx = DataContext.Instance())
            {
                var r = ctx.GetRepository<Kérdések>();
                return r.GetById(questionid);
            }
        }
        private Answers[] GetAnswersByQuestionID(int questionid)
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