﻿namespace Entities
{
    public class EmployeeEntity: BaseEntity
    {
        public PersonEntity Person { get; set; }
        
        public string Position { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
