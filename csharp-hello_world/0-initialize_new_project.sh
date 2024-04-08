#!/usr/bin/env bash
# initializes a new C# project inside a folder titled 0-new_project.
project="0-new_project"
mkdir "$project"

cd "$project"

dotnet new console
