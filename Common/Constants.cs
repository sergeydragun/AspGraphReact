using System;
using System.Diagnostics;

namespace Common
{
    public static class Constants
    {
        public static string ConfigurationName => "aspgraph";
        public static DBVersion DBVersion => new() { Major = 1, Minor = 1, Build = 1 };
    }

    public class DBVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
    }
}