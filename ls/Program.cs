using System;
using System.Net.Mime;

string cmdExe = ("cmd.exe");
string dirCommand = ("/c dir");
System.Diagnostics.Process.Start(cmdExe, dirCommand);
Environment.Exit(0);