using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ApiSample.Controllers
{
    public class TermekController
    {
        //public bool IsInteger(int mennyiseg, string inventory_id) 
        //{
            
        //    string url = "http://20.234.113.211:8086/";
        //    string key = "1-2fa07268-d07a-4bd6-9719-5af01cd8b808";

        //    Api proxy = new Api(url, key);

        //    var product = proxy.ProductsFind(inventory_id).Content;

        //    product.InventoryMode = mennyiseg;
            

        //    ApiResponse<ProductDTO> response = proxy.ProductsUpdate(product);

        //    if (response.Errors.Count == 0)
        //        return true;
        //    else
        //        return false;



        //}

        public bool IsInteger(string mennyiseg)
        {
            //Regex regex = new Regex(@"^(0|[1-9]\d*)$");
            //return isint;
            //try
            //{

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            return int.TryParse(mennyiseg, out _);
        }

        public bool MatchesItemList(string tb_szoveg, string lb_szoveg)
        {
            if(lb_szoveg.ToLower().Contains(tb_szoveg.ToLower())) 
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool RestoresOriginalValue(int eredeti, int uj)
        {
            if(eredeti == uj)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
