using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<Value> Values {get; set;}


        //you have to call higher lvl class and inherit this DataContext li this

        //in this <> we are given the type of our context
        //then add base clss (dbcontext) == base and say again options

        // then we have to say to the entity framework were is our properties are  as a property (prop) in here.





        //property datatype is DbSet and its type Value.  our value class
        //and tell the class in using section. and mgive the property name like Valuse in this case. and this property  name used to create its table in databse
        // EF use this name as a table name.




    }
}
