﻿
namespace Anycmd.Engine.Ac.Messages.Infra
{
    using InOuts;


    public class UpdateEntityTypeCommand : UpdateEntityCommand<IEntityTypeUpdateIo>, IAnycmdCommand
    {
        public UpdateEntityTypeCommand(IAcSession acSession, IEntityTypeUpdateIo input)
            : base(acSession, input)
        {

        }
    }
}