﻿using System.ComponentModel.DataAnnotations;

namespace GraphQLHotChocolate.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
}
