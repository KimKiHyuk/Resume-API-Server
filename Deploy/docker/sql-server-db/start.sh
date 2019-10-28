#!/bin/bash
set -e

echo "======= 30MSSQL SERVER STARTED ========"

sleep 25 && /opt/mssql-tools/bin/sqlcmd -S localHost -U sa -P 1Secure*Password1 -i setup.sql & /opt/mssql/bin/sqlservr
# Run the setup script to create the DB and the schema in the DB
echo "======= MSSQL CONFIG COMPLETE ======="