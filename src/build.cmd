@echo off

:CheckOS
IF EXIST "%PROGRAMFILES(X86)%" (GOTO 64BIT) ELSE (GOTO 32BIT)

:64BIT
"%programfiles(x86)%\MSBuild\12.0\Bin\msbuild.exe" MZMemoize.sln /m:8 /t:clean
"%programfiles(x86)%\MSBuild\12.0\Bin\msbuild.exe" MZMemoize.sln /m:8 /p:Configuration=Release /p:Platform="Any CPU"
GOTO END

:32BIT
"%programfiles%\MSBuild\12.0\Bin\msbuild.exe" MZMemoize.sln /m:8 /t:clean
"%programfiles%\MSBuild\12.0\Bin\msbuild.exe" MZMemoize.sln /m:8 /p:Configuration=Release /p:Platform="Any CPU"
GOTO END

:END
pause