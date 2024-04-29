#!/usr/bin/env bash
# initializes, builds, and runs a new C# project from a folder titled 2-new_project.

dotnet new console -n 2-new_project -o 2-new_project
cd 2-new_project
dotnet build
dotnet run
