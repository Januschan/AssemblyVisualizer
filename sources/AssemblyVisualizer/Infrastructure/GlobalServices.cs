// Copyright 2011 Denis Markelov
// This code is distributed under Microsoft Public License 
// (for details please see \docs\Ms-PL)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AssemblyVisualizer.Infrastructure
{
    static class GlobalServices
    {
        private const string SourcesUrl = @"http://denismarkelov.github.com/AssemblyVisualizer";
        private const string AuthorUrl = @"http://www.delphinon.com";

        public static void NavigateToSources()
        {
            Process.Start(SourcesUrl);
        }

        public static void NavigateToAuthor()
        {
            Process.Start(AuthorUrl);
        }
    }
}
