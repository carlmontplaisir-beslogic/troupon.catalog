﻿using HotChocolate.Resolvers;
using HotChocolate.Types;
using Troupon.Catalog.Core.Domain.Dtos;

namespace Troupon.Catalog.Service.Api.Schema
{
    [ExtendObjectType(Name = nameof(DealDto))]
    public class DealResolvers
    {
        public MerchantDto Application(IResolverContext context)
        {
            return new MerchantDto { Name = "Test" };
        }
    }
}
