using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Task_List_Web_API.BusinessModel
{
    //Task details
    public class Task
    {
        //Task id
        public int Id { get; set; }


        //Task title
        public string Title { get; set; }

        //The person who is responsible for  the task 
        public string Assignee { get; set; }

        //Task status
        public string Status { get; set; }


    }

   
  
}
