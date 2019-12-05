﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wabbajack.Common.StatusFeed
{
    /// <summary>
    /// Defines a message that requires user interaction. The user must perform some action
    /// or make a choice. 
    /// </summary>
    public interface IUserIntervention : IStatusMessage
    {
        /// <summary>
        /// The user didn't make a choice, so this action should be aborted
        /// </summary>
        void Cancel();
    }
}
