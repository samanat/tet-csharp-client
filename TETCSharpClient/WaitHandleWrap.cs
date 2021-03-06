﻿/*
 * Copyright (c) 2013-present, The Eye Tribe. 
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the LICENSE file in the root directory of this source tree. 
 *
 */

using System.Threading;

namespace TETCSharpClient
{
    internal class WaitHandleWrap
    {
        private const int EVENT_KILL = 0;
        private const int EVENT_UPDATE = 1;

        private readonly EventWaitHandle[] events;

        public WaitHandleWrap()
        {
            events = new EventWaitHandle[]
                         {
                             new ManualResetEvent(false), //kill
                             new AutoResetEvent(false) //update
                         };
        }

        public EventWaitHandle GetKillHandle()
        {
            return events[EVENT_KILL];
        }

        public EventWaitHandle GetUpdateHandle()
        {
            return events[EVENT_UPDATE];
        }

        public EventWaitHandle[] GetHandles()
        {
            return events;
        }
    }

}
