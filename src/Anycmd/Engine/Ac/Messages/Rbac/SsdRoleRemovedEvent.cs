﻿
namespace Anycmd.Engine.Ac.Messages.Rbac
{
    using Abstractions.Rbac;
    using Events;

    public class SsdRoleRemovedEvent : DomainEvent
    {
        public SsdRoleRemovedEvent(SsdRoleBase source)
            : base(source)
        {
        }
    }
}