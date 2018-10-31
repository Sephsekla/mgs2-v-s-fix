﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgs2_v_s_fix
{
    class Flags
    {

        public enum UPDATE_AVAILABILITY
        {
            ResponseMismatch = 0,
            NetworkError,
            NoUpdates,
            UpdateAvailable,
        };

        public enum ADD2STEAMSTATUS
        {
            SteamIsRunning = 0,
            CantFindNecessaryPaths,
            CantFindVdfFile,
            AddedForOneUser,
            AddedForMoreUsers,
            NothingDone,
            AccessError

        };


    }
}
