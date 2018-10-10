﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GradeAnalysis
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            Application.Run(new MainForm());
        }
    }
}
