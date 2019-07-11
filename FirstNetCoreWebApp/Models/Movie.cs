using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

// this is a datamodel for movies
// ID class is reuired by the database for the primary key
// [DataType(DataType.Date)] - the DataType attribute specifies the type of the dsts (Date), with this the user is not required to enter time info in the date field
// and only the date is displayed, not time information
namespace FirstNetCoreWebApp.Models {
    public class Movie {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
