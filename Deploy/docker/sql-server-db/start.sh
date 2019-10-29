#!/bin/bash
set -e

echo "======= MSSQL SERVER STARTED ========"
sleep 25 && /opt/mssql-tools/bin/sqlcmd -S localHost -U sa -P 1Secure*Password1 -i setup.sql & /opt/mssql/bin/sqlservr
echo "======= MSSQL CONFIG COMPLETE ======="