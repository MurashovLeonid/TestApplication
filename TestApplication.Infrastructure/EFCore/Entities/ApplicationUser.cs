using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Infrastructure.EFCore.Entities
{
    public sealed class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhotoUri { get; set; }
        public ApplicationUserPhoto UserPhoto { get; set; }
    }
}
