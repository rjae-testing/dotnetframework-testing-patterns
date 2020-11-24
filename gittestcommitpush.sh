#!/bin/bash

dotnet format --check --exclude *.Tests **/Migrations --verbosity quiet; || exit 1
dotnet build; || exit 1
dotnet test -warnaserror --filter Category!=Service; || exit 1
git add --verbose .
git commit -m "$1"
git pull
git push --verbose origin master
