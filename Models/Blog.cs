﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task1.Models;

internal class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
