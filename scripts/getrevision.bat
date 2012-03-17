@ECHO OFF
REM By the way, did I ever mention I hate batch files? They are truly ugly, aren't they?
REM I'm using horrible SCREAMING CAPS in batch because what is wrong should look wrong.

FOR /F "TOKENS=*" %%D IN ('CD') DO SET PWD=%%D
CD /D %~DP0
FOR /F "TOKENS=4" %%I IN ('SVN info ^| FIND /I "Last Changed Rev:"') DO SET REVISION=%%I
ECHO %REVISION%
CD /D %PWD%