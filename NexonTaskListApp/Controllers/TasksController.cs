using Newtonsoft.Json;
using NexonTaskListApp.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NexonTaskListApp.Controllers
{
    public class TasksController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            try
            {
                TaskManager taskManager = new TaskManager();
                return Request.CreateResponse(HttpStatusCode.OK, taskManager.Tasks);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}