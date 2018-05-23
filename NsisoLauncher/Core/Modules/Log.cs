﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NsisoLauncher.Core.Modules
{
    public enum LogLevel
    {
        GAME,
        DEBUG,
        INFO,
        WARN,
        ERROR,
        FATAL
    }

    public class Log : EventArgs
    {
        /// <summary>
        /// 日志等级
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// LOG信息
        /// </summary>
        public string Message { get; set; }
    }
}
