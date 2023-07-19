using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UseCases.Queries.Users.DTO
{
    public class UserDto
    {
        public UserDto(string fullName, byte[] photo, DateTime birthDate, string photoUri)
        {
            FullName = fullName;
            Photo = photo;
            BirthDate = birthDate;
            PhotoUri = photoUri;    
        }

        public string FullName { get; private set; }
        public byte[] Photo { get; private set; }
        public DateTime BirthDate { get; private set; }

        public string PhotoUri { get; private set; }

    }
}
