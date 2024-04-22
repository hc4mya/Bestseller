#region License

// Distributed under the MIT License
// ============================================================
// Copyright (c) 2019 Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.

#endregion

using System;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;

namespace ApiSample
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        //private static void Main(string[] args)
        //{


        //    Console.WriteLine("This is an API Sample Program for Hotcakes");
        //    Console.WriteLine();

        //    var url = string.Empty;
        //    var key = string.Empty;

        //    if (args.Length > 0)
        //    {
        //        foreach (var arg in args)
        //        {
        //            url = args[0];
        //            key = args[1];
        //        }
        //    }

        //    if (url == string.Empty) url = "http://20.234.113.211:8086/";
        //    if (key == string.Empty) key = "1-2fa07268-d07a-4bd6-9719-5af01cd8b808";

        //    var proxy = new Api(url, key);

        //    var productSnaps = proxy.ProductsFindAll();

        //    if (productSnaps.Content != null)
        //    {
        //        Console.WriteLine("Found " + productSnaps.Content.Count + " products");
        //        Console.WriteLine("-- First 20 products --");

        //        for (var i = 0; i < 20; i++)
        //        {
        //            if (i < productSnaps.Content.Count)
        //            {
        //                Console.WriteLine(i + ") " + productSnaps.Content[i].ProductName + " [" + productSnaps.Content[i].Bvin + "]");

        //                var prod = proxy.ProductsFind(productSnaps.Content[i].Bvin);
        //                if (prod.Errors.Count > 0)
        //                {
        //                    foreach (var err in prod.Errors)
        //                    {
        //                        Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("By Bvin: " + prod.Content.ProductName + " | " + prod.Content.ShortDescription);
        //                }
        //            }
        //        }
        //    }
    }
}
//        var snaps = proxy.CategoriesFindAll();
//            if (snaps.Content != null)
//            {
//                Console.WriteLine("Found " + snaps.Content.Count + " categories");
//                Console.WriteLine("-- First 5 --");
//                for (var i = 0; i< 5; i++)
//                {
//                    if (i<snaps.Content.Count)
//                    {
//                        Console.WriteLine(i + ") " + snaps.Content[i].Name + " [" + snaps.Content[i].Bvin + "]");
//                        var cat = proxy.CategoriesFind(snaps.Content[i].Bvin);
//                        if (cat.Errors.Count > 0)
//                        {
//                            foreach (var err in cat.Errors)
//                            {
//                                Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
//                            }
//}
//                        else
//{
//    Console.WriteLine("By Bvin: " + cat.Content.Name + " | " + cat.Content.Description);
//}

//var catSlug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
//if (catSlug.Errors.Count > 0)
//{
//    foreach (var err in catSlug.Errors)
//    {
//        Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
//    }
//}
//else
//{
//    Console.WriteLine("By Slug: " + cat.Content.Name + " | " + cat.Content.Description);
//}
//                    }
//                }
//            }

//            Console.WriteLine("Done - Press a key to continue");
//Console.ReadKey();
//            }
//        }
//    }
//}