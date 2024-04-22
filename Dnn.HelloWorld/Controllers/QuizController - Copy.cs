﻿/*
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

using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using HelloWorld.Dnn.Dnn.HelloWorld.Components;
using HelloWorld.Dnn.Dnn.HelloWorld.Models;
using System;
using System.Linq;
using System.Web.Mvc;

using DotNetNuke.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace HelloWorld.Dnn.Dnn.HelloWorld.Controllers
{
    [DnnHandleError]
    public class RandomController : DnnController
    {

        public ActionResult Index()
        {
            var data = MyDataAccess.GetMyData();
            return View(data);
        }

    }
}
