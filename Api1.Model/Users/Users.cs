﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api0.Models
{
    
   public  class Users
    {
     public string  Id                    {get;set;}
     public string  Email                 {get;set;}
     public string  EmailConfirmed        {get;set;}
     public string  PasswordHash          {get;set;}
     public string  SecurityStamp         {get;set;}
     public string  PhoneNumber           {get;set;}
     public string  PhoneNumberConfirmed  { get; set; }
     public string  TwoFactorEnabled    {get;set;}
     public string  LockoutEndDateUtc   {get;set;}
     public string  LockoutEnabled      {get;set;}
     public string  AccessFailedCount   {get;set;}
     public string UserName { get; set; }
    }
}
