@ECHO OFF
REM By the way, did I ever mention I hate batch files? They are truly ugly, aren't they?
REM I'm using horrible SCREAMING CAPS in batch because what is wrong should look wrong.

REM Store current directory, go to where the script is.
FOR /F "TOKENS=*" %%D IN ('CD') DO SET PWD=%%D
CD /D %~DP0

REM Get the current revision of this working copy and echo it.
FOR /F "TOKENS=2" %%I IN ('SVN info --revision HEAD ^| FIND /I "Revision:"') DO SET REVISION=%%I
ECHO %REVISION%

REM Return to previous working directory.
CD /D %PWD%