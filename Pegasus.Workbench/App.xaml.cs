﻿// -----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="(none)">
//   Copyright © 2014 John Gietzen.  All Rights Reserved.
//   This source is subject to the MIT license.
//   Please see license.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Pegasus.Workbench
{
    using System.Windows;
    using ICSharpCode.TextEditor.Document;

    /// <summary>
    /// Interaction logic for the workbench application.
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            HighlightingManager.Manager.AddHighlightingStrategy(new PegasusHighlightingStrategy());
        }
    }
}
