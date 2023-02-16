using System;
using System.Collections.Generic;

namespace Taco_Bell_API.Models;

public partial class Burrito
{

    public int Id { get; set; }

    public string? Name { get; set; }

    public float? Cost { get; set; }

    public bool? Bean { get; set; }
    //public Burrito(string name, float cost, bool bean)
    //{
    //    Name = name;
    //    Cost = cost;
    //    Bean = bean;
    //}
}
