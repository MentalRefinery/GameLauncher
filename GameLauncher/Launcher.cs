﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GameLauncher
{
    class Launcher
    {
        public static void PlayGame()
        {
            Process.Start("Cha-Cha.exe");
        }
        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }
}
