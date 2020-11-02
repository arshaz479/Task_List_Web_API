using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_List_Web_API.BusinessModel;

namespace Task_List_Web_API.Models
{
    //Links the database schema and the business moel classes.
    public class Task_List_Web_APIDataContext : DbContext
    {
        public Task_List_Web_APIDataContext (DbContextOptions<Task_List_Web_APIDataContext> options)
            : base(options)
        {
        }

        public DbSet<Task_List_Web_API.BusinessModel.Task> Task { get; set; }
    }
}
