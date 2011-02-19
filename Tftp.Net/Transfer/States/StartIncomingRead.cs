﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tftp.Net.Transfer.States
{
    class StartIncomingRead : BaseState
    {
        public StartIncomingRead(TftpTransfer context)
            : base(context) {}

        public override void OnStart()
        {
            Context.SetState(new Sending(Context));
        }

        public override void OnCancel()
        {
            Context.SetState(new CancelledByUser(Context));
        }
    }
}
