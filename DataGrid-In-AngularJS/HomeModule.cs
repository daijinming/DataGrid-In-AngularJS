using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace DataGrid_In_AngularJS
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get[@"/"] = _ => {

                return this.View["Home.html"];
            };

            this.Post[@"/API/DataGrid"] = _ => {

                PostItem item = this.Bind<PostItem>();

                var pagesize = item.pagesize;
                var pageno = item.pageno;

                return Response.AsFile("Content/data.txt", "application/json"); ;
            };
        }
    }

    public class PostItem
    {
        public int pagesize { get; set; }
        public int pageno { get; set; }
    }
}