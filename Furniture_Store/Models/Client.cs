using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Furniture_Store.Data;

namespace Furniture_Store.Models
{
    [Table("Client")]
    public class Client : IEntity
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int OrderId { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}
