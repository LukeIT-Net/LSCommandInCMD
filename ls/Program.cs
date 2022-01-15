#define System
string cmdExe = ("cmd.exe");
string dirCommand = ("/c dir");
System.Diagnostics.Process.Start(cmdExe, dirCommand);