@ECHO OFF
REM Well yes, I do hate batch files. They are truly ugly.
REM I'm using horrible SCREAMING CAPS in batch because what is wrong should look wrong.

REM We need the third parameter or we'll update every AssemblyInfo.cs in the whole computer!
IF [%3]==[] GOTO EOF

REM Store current directory, go to where the script is.
FOR /F "TOKENS=*" %%D IN ('CD') DO SET PWD=%%D
CD /D %~DP0

REM Get the HEAD revision number, increment and it.
FOR /F "TOKENS=*" %%R IN ('get-head-revision.bat') DO SET REVISION=%%R
SET /A REVISION+=1 > NUL

REM Update each AssemblyInfo.cs found in whatever directory (and subdirectories) you're checking in.
REM Please do note that AssemblyInfo.cs must be accessible BELOW whatever you're checking in.
REM So if you are checking in files in a directory below the solution this WON'T WORK.
REM TL;DR: use the "SVN Commit" context menu entry in the solution directory or a file in it, not in a subdirectory.
FOR /F "TOKENS=*" %%A IN ('DIR /B /S %3\*AssemblyInfo.cs 2^> NUL') DO (
	..\TOOLS\SED.EXE -i -r "s/^\[assembly: AssemblyVersion\(\"([0-9]+^)\.([0-9]+^)\.[0-9]+\"\)\]$/\[assembly: AssemblyVersion\(\"\1\.\2\.%REVISION%\"\)\]/g" "%%A"
	..\TOOLS\SED.EXE -i -r "s/^\[assembly: AssemblyFileVersion\(\"([0-9]+^)\.([0-9]+^)\.[0-9]+\"\)\]$/\[assembly: AssemblyFileVersion\(\"\1\.\2\.%REVISION%\"\)\]/g" "%%A"
)

REM Clean up because this port of sed poops a temp file in the directory where you are.
DEL sed*

REM Return to previous working directory.
CD /D %PWD%

:EOF
