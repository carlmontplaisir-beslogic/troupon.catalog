﻿using MediatR;
using System;
using System.Threading.Tasks;

namespace Troupon.Catalog.Core.Application.Events
{
    public static class DomainEvents
    {
        public static Func<IMediator> Mediator { get; set; }
        public static async Task Raise<T>(T args) where T : INotification
        {
            var mediator = Mediator.Invoke();
            await mediator.Publish<T>(args);
        }
    }
}
