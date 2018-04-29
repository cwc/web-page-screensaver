# web-page-screensaver

Display a web page as your screensaver

## Dependencies

[.NET Framework 4.6](https://www.microsoft.com/en-us/download/details.aspx?id=48130)

## Usage (Windows 7 & up)

1. Find Web-Page-Screensaver.scr on your computer, right click it
2. Select "Install" to install, or "Test" to test it out without installing
3. If installing, the Screen Saver Settings dialog will pop up with the correct screen saver selected
4. Use the `Settings...` button in the same dialog to change the web page(s) displayed by the screen saver

## Build instructions

0. Have the .NET Framework installed
1. Clone or Download the repository
2. Open a command prompt in the project folder and enter:

`C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe Web-Page-Screensaver.csproj`

3. In the folder bin\Debug\ rename Web-Page-Screensaver.exe to Web-Page-Screensaver.scr
4. Right click Web-Page-Screensaver.scr to Test or Install. 