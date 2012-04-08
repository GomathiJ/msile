@ECHO OFF
REM As always, batch is C++ bastard child in my eyes so I use all-caps because they represent the eye bleed.

REM Store current directory, go to where the script is.
FOR /F "TOKENS=*" %%D IN ('CD') DO SET PWD=%%D
CD /D %~DP0

REM Parse the XMLDoc for the project.
..\tools\NDoc3\NDoc3Console.exe -documenter=XML -project=..\solution\msile.ndoc

REM Return to previous working directory.
CD /D %PWD%
