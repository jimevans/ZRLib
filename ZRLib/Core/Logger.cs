﻿/*
 *  "ZRLib", Roguelike games development Library.
 *  Copyright (C) 2015 by Serg V. Zhdanovskih.
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.IO;
using System.Text;

namespace ZRLib.Core
{
    public static class Logger
    {
        private static readonly object fLock = new object();
        private static string fLogFilename;

        public static void LogInit(string fileName)
        {
            fLogFilename = fileName;
        }

        public static void Write(string msg)
        {
            try {
                lock (fLock) {
                    using (StreamWriter log = new StreamWriter(fLogFilename, true, Encoding.UTF8))
                    {
                        log.WriteLine("[" + DateTime.Now.ToString() + "] -> " + msg);
                        log.Flush();
                        log.Close();
                    }
                }
            } catch {
                // dummy
            }
        }
    }
}
