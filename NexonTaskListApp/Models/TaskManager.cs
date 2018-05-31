using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace NexonTaskListApp.Models
{
    public class TaskManager
    {
        public IEnumerable<Task> Tasks
        {
            get
            {
                List<Task> tasks = new List<Task>();

                try
                {
                    string filePath = System.Web.Hosting.HostingEnvironment.MapPath(ConfigurationManager.AppSettings["JSONFile"]);
                    if (File.Exists(filePath))
                    {
                        using (StreamReader r = new StreamReader(filePath))
                        {
                            string json = r.ReadToEnd();
                            tasks = JsonConvert.DeserializeObject<List<Task>>(json);
                        }
                    }
                }
                catch(IOException IOErr)
                {

                }
                catch (Exception Err)
                {

                }
                
                return tasks;
            }
        }
    }
}