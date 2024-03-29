﻿using OnlineShop.Models;
using System.Net;
using System;
using Microsoft.AspNetCore.Http;

namespace OnlineShop.Dto.UserDTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public IFormFile ImageUri { get; set; }
        public UserType UserType { get; set; }
    }
}
