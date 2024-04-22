/*
' Copyright (c) 2024 Bestseller
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Data;
using DotNetNuke.Framework;
using HelloWorld.Dnn.Dnn.HelloWorld.Models;
using System.Collections.Generic;
using System.Reflection;

namespace HelloWorld.Dnn.Dnn.HelloWorld.Components
{
    internal interface IQuizManager
    {
        void CreateKérdés(Kérdések t);
        /*void DeleteKérdés(int itemId, int moduleId);*/
        void DeleteKérdés(Kérdések t);
        IEnumerable<Kérdések> GetKérdés(int QuestionID);

        /*Kérdések GetKérdés(int QuestionId, int moduleId);*/
        void UpdateKérdések(Kérdések t);
    }

    internal class QuizManager : ServiceLocator<IQuizManager, QuizManager>, IQuizManager
    {
        public void CreateKérdés(Kérdések t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Kérdések>();
                rep.Insert(t);
            }
        }

        public void DeleteKérdés(Kérdések t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Kérdések>();
                rep.Delete(t);
            }
        }

        /*public void CreateKérdés(Kérdések t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Kérdések>();
                rep.Insert(t);
            }
        }*/



        /*public void DeleteKérdés(int QuestionId, int moduleId)
        {
            var t = GetKérdés(QuestionId, moduleId);
            DeleteKérdés(t);
        }*/



        public IEnumerable<Kérdések> GetKérdés(int QuestionID, int moduleId)
        {
            IEnumerable<Kérdések> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Kérdések>();
                t = rep.Get(moduleId);
            }
            return t;
        }

        public IEnumerable<Kérdések> GetKérdés(int QuestionID)
        {
            IEnumerable<Kérdések> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Kérdések>();
                t = rep.Get(QuestionID);
            }
            return t;
        }

        /*public Item GetItem(int itemId, int moduleId)
        {
            Item t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Item>();
                t = rep.GetById(itemId, moduleId);
            }
            return t;
        }*/

        public void UpdateKérdések(Kérdések t)
        {
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Kérdések>();
                rep.Update(t);
            }
        }

        protected override System.Func<IQuizManager> GetFactory()
        {
            return () => new QuizManager();
        }
    }
}
