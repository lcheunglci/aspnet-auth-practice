// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "67063840-6A99-4DA4-8DEA-AE2E3F3F0996",
                        Username = "Allen",
                        Password = "password",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.GivenName, "Allen"),
                            new Claim(JwtClaimTypes.FamilyName, "Doe"),
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "A1BCA27D-3401-4B6C-8030-A5779FA17DD5",
                        Username = "Brian",
                        Password = "password",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.GivenName, "Brian"),
                            new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        }
                    }
                };
            }
        }
    }
}