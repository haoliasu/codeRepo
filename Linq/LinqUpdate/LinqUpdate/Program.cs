using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LinqUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (linqToSqlDemoDataContext context = new linqToSqlDemoDataContext())
            {
                

                //var jobToUpdate = (from j in context.jobs
                //             where j.job_id == 17
                //             select j).First();
               // jobToUpdate.max_lvl = 16;

               

//context.GetChangeSet();
//context.Log = Console.Out;

               // context.SubmitChanges();

                job newJob = new job();
                newJob.job_desc = "dsf";
                newJob.min_lvl = 60;
                newJob.max_lvl = 100;
                context.jobs.InsertOnSubmit(newJob);
               // jobToUpdate.max_lvl = 17;

              //  context.jobs.DeleteOnSubmit(jobToUpdate);

                context.SubmitChanges();
               
            }
        }
    }
}
