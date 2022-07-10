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
                            new Claim(JwtClaimTypes.Address, "Avenue Way 48"),
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
                            new Claim(JwtClaimTypes.Address, "Main Road 2"),
                        }
                    },
                    new TestUser
                    {
                         SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                         Username = "Frank",
                         Password = "password",

                         Claims = new List<Claim>
                         {
                             new Claim("given_name", "Frank"),
                             new Claim("family_name", "Underwood"),
                             new Claim(JwtClaimTypes.Address, "Main Road 1"),
                         }
                     },
                     new TestUser
                     {
                         SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                         Username = "Claire",
                         Password = "password",

                         Claims = new List<Claim>
                         {
                             new Claim("given_name", "Claire"),
                             new Claim("family_name", "Underwood"),
                             new Claim(JwtClaimTypes.Address, "Big Street 2"),
                         }
                     }
                };
            }
        }
    }
}