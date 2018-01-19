// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

namespace SymphonyOSS.RestApiClient.Factories
{
    using SymphonyOSS.RestApiClient.Entities;
    using System.Collections.Generic;
    using UserAppEntitlement = Entities.UserAppEntitlement;

    public class UserAppEntitlementFactory
    {
        public static UserAppEntitlement Create(Generated.OpenApi.PodApi.UserAppEntitlement userAppEntitlement)
        {
            List<Product> products = null;
            if (userAppEntitlement.Products != null)
            {
                products = new List<Product>(userAppEntitlement.Products.Count);
                foreach (var product in userAppEntitlement.Products)
                {
                    products.Add(ProductFactory.Create(product));
                }
            }
            return new UserAppEntitlement(userAppEntitlement.AppId, userAppEntitlement.AppName, userAppEntitlement.Install, userAppEntitlement.Listed, products);
        }
    }
}
