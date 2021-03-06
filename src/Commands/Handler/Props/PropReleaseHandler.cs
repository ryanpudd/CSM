﻿using CSM.Commands.Data.Props;
using CSM.Helpers;

namespace CSM.Commands.Handler.Props
{
    public class PropReleaseHandler : CommandHandler<PropReleaseCommand>
    {
        protected override void Handle(PropReleaseCommand command)
        {
            IgnoreHelper.StartIgnore();
            PropManager.instance.ReleaseProp(command.PropId);
            IgnoreHelper.EndIgnore();
        }
    }
}
