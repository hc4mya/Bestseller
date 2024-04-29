using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace HelloWorld.Dnn.Dnn.HelloWorld.Models
{
        [TableName("Válaszok")]
        //setup the primary key for table
        [PrimaryKey("AnswerID", AutoIncrement = true)]
        //configure caching using PetaPoco
        [Cacheable("Válaszok", CacheItemPriority.Default, 20)]
        //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
        [Scope("ModuleId")]
        public class Answers
        {
            public int AnswerID { get; set; }

            public int QuestionID { get; set; }
            
            public string AnswerText { get; set; }

            public int NextQuestionID { get; set; }
        }
 }
