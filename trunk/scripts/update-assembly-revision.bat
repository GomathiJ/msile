@ECHO OFF
REM Well yes, I do hate batch files. They are truly ugly.
REM I'm using horrible SCREAMING CAPS in batch because what is wrong should look wrong.

REM Store current directory, go to where the script is.
FOR /F "TOKENS=*" %%D IN ('CD') DO SET PWD=%%D
CD /D %~DP0

REM Get the HEAD revision number, increment it and place it in the AssemblyInfo.
FOR /F "TOKENS=*" %%R IN ('get-head-revision.bat') DO SET REVISION=%%R
SET /A REVISION+=1 > NUL
..\TOOLS\SED.EXE -i -r "s/^\[assembly: AssemblyVersion\(\"([0-9]+)\.([0-9]+)\.[0-9]+\"\)\]$/\[assembly: AssemblyVersion\(\"\1\.\2\.%REVISION%\"\)\]/g" ..\solution\Properties\AssemblyInfo.cs
..\TOOLS\SED.EXE -i -r "s/^\[assembly: AssemblyFileVersion\(\"([0-9]+)\.([0-9]+)\.[0-9]+\"\)\]$/\[assembly: AssemblyFileVersion\(\"\1\.\2\.%REVISION%\"\)\]/g" ..\solution\Properties\AssemblyInfo.cs

REM Clean up because this port of sed poops a temp file in the directory where you are.
DEL sed*

REM Return to previous working directory.
CD /D %PWD%