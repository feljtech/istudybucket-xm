﻿using System;
using istudybucket.Models.Embedded;

namespace istudybucket.Models
{
    
    public class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public int UserRole { get; set; }
        public Address UserAddress { get; set; }
    }
}