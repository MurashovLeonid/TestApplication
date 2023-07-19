using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApplication.UseCases.Queries.Users.DTO
{
    public enum OrderType
    {
        [JsonPropertyName("Восходящая")]
        Asc,
        [JsonPropertyName("Нисходящая")]
        Desc
    }
}
