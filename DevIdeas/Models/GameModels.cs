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
 * Model for games & genre data
 * 
 * */

namespace DevIdeas.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int NumberOfIdeas { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual Genre Genre { get; set; } // TODO: Points to Genre.Title

        public int NumberOfIdeas { get; set; }
    }

 
}