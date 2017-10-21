/*
 * Copyright 2015 Bert Hoorne, Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using IdentityServer3.EntityFramework.Entities;
using Sahra.MutualFund.IdentityAdmin.EntityFramework.Interfaces;

namespace Sahra.MutualFund.IdentityAdmin.EntityFramework.Entities
{
    public class IdentityScope : IScope<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClaimsRule { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Emphasize { get; set; }
        public bool Enabled { get; set; }
        public bool IncludeAllClaimsForUser { get; set; }
        public bool Required { get; set; }
        public ICollection<ScopeClaim> ScopeClaims { get; set; }
        public ICollection<ScopeSecret> ScopeSecrets { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public int Type { get; set; }
        public bool AllowUnrestrictedIntrospection { get; set; }
    }
}