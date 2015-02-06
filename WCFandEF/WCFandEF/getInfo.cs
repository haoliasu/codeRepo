using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFandEF
{
    public class getInfo
    {
        public static string getPublisherName(int n)
        {
            using (pubsEntities context = new pubsEntities())
            {
                var result = (from pubName in context.publishers
                                where pubName.pub_id.Equals( n.ToString())
                                select pubName).First();
                return result.pub_name;
           }
        }
       
    

    
    }
}