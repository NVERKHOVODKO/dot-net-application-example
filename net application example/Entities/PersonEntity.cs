﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PersonEntity: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string SecondPhone { get; set; }
    }
}