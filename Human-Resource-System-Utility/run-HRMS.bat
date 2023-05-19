@ECHO OFF 
ECHO Please wait...
SET filedir=%~dp0
ECHO ============================
ECHO Running files in:
ECHO %filedir%
ECHO DO NOT CLOSE WINDOW YET!
ECHO ============================
START %filedir%\HRMS\HRMS\bin\Debug\HRMS.exe
EXIT