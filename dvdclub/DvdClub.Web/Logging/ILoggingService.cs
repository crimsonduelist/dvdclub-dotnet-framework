﻿using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdClub.Web.Logging {
    public interface ILoggingService {
        ILogger Writer { get; }
    }
}