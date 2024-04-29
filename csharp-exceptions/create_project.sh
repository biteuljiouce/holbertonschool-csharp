#!/usr/bin/env bash

# Vérifiez s'il y a au moins un argument
if [ $# -lt 1 ]; then
    echo "Usage: $0 <filename>"
    exit 1
fi

# Extraire le premier caractère de la chaîne d'argument
first_char=${1:0:1}
first_number=${1%%-*}

mkdir "$1"
cd "$1"
dotnet new console
mv Program.cs "$1.cs"
touch "$first_number-main.cs"