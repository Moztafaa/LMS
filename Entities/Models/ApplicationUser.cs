﻿using Microsoft.AspNetCore.Identity;

namespace Entities.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    
}