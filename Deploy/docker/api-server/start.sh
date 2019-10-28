#!/bin/bash
set -e

echo "======= API SERVER STARTED ========"
dotnet publish/APIServer.dll
echo "======= API SERVER COMPLETE ======="