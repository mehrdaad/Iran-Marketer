﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Diagnostics;
using Sahra.MutualFund.IdentityAdmin.Core.App_Packages.LibLog._1._4;

namespace Sahra.MutualFund.IdentityAdmin.Core.Logging
{
    internal class LibLogTraceListener : TraceListener
    {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public override void WriteLine(string message)
        {
            Logger.Debug(message);
        }

        public override void Write(string message)
        { }
    }
}