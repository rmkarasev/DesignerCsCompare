@echo off

SET SCRIPT_ROOT=%~dp0
echo.
echo Starting from %SCRIPT_ROOT%

if not exist "C:\Program Files\dotnet\dotnet.exe" (
    echo ERROR - dotnet.exe not found.
    exit /b
)

set SOLUTION_PATH=%SCRIPT_ROOT%DesignerCsCompare.sln
set CONFIGURATION=Debug
echo %SOLUTION_PATH%

echo.
echo Clean project...
dotnet clean "%SOLUTION_PATH%" -c %CONFIGURATION% -v:m
echo.
echo Build project...
dotnet build "%SOLUTION_PATH%" -c %CONFIGURATION%
echo.
echo Building done
echo.