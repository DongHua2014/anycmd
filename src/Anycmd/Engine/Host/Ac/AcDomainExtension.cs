﻿
namespace Anycmd.Engine.Host.Ac
{
    using Engine.Ac.Messages.Identity;
    using Engine.Ac.Messages.Infra;
    using System;

    public static class AcDomainExtension
    {
        public static void RemoveAppSystem(this IAcDomain acDomain, IAcSession acSession, Guid appSystemId)
        {
            acDomain.Handle(new RemoveAppSystemCommand(acSession, appSystemId));
        }

        public static void RemoveAccount(this IAcDomain acDomain, IAcSession acSession, Guid accountId)
        {
            acDomain.Handle(new RemoveAccountCommand(acSession, accountId));
        }

        public static void RemoveButton(this IAcDomain acDomain, IAcSession acSession, Guid buttonId)
        {
            acDomain.Handle(new RemoveButtonCommand(acSession, buttonId));
        }

        public static void RemoveDic(this IAcDomain acDomain, IAcSession acSession, Guid dicId)
        {
            acDomain.Handle(new RemoveDicCommand(acSession, dicId));
        }

        public static void RemoveDicItem(this IAcDomain acDomain, IAcSession acSession, Guid dicItemId)
        {
            acDomain.Handle(new RemoveDicItemCommand(acSession, dicItemId));
        }

        public static void RemoveEntityType(this IAcDomain acDomain, IAcSession acSession, Guid entityTypeId)
        {
            acDomain.Handle(new RemoveEntityTypeCommand(acSession, entityTypeId));
        }
    }
}
