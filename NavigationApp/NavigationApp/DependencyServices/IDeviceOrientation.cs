﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationApp.DependencyServices
{
    public interface IDeviceOrientation
    {
        void LockOrientationPortrait();
        void LockOrientationLandscape();
        void UnlockOrientation();
    }
}
