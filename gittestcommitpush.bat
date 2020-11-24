@echo off
dotnet format --check --exclude *.Tests **/Migrations --verbosity quiet
if NOT %ERRORLEVEL% == 0 (
  GOTO EOF
)
dotnet build
if NOT %ERRORLEVEL% == 0 (
  GOTO EOF
)
dotnet test -warnaserror --filter Category!=Service
if NOT %ERRORLEVEL% == 0 (
  echo.
  echo Tests failed!
  GOTO EOF
)
echo.
git add --verbose :/ .
git commit -m %*
git pull
git push --verbose
:EOF
