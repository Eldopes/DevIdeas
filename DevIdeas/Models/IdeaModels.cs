using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.ComponentModel.DataAnnotations; // for validation
/*
 * Model for user ideas data 
 * 
 * */

namespace DevIdeas.Models
{
   public class Idea
    {      
        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public virtual ApplicationUser Author { get; set; } // points to ApplicationUser.User property

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int Rating { get; set; }

        public virtual Genre Genre { get; set; } // TODO: Points to Genre.Title

        public virtual Game Game { get; set; } // TODO: Points to Game.Genre
    }

    public class IdeaContext : DbContext // context for Entity Framework
    {
        public IdeaContext() : base("DefaultConnection") // to use Default Connection in web.config connection strings in this db
        { }
        public DbSet<Idea> Ideas { get; set; }        
    }

}