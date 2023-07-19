using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Infrastructure.EFCore.Entities
{
    public class ApplicationUserPhoto
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public int ApplicationUserId { get; set; }
    }
}
