# Deploy using docker-compose, Dockerfile

## build api server 
*  **Resume-API-Server/APIServer$** dotnet publish -c Release
*  **Resume-API-Server/APIServer$** copy bin/Release/netcoreapp3.0/publish Resume-API-Server/Deploy/docker/api-server/publish

## Deploy docker 
* **Resume-API-Server/Deploy/docker$** docker-compse build
* **Resume-API-Server/Deploy/docker$** docker-compose up  (if you don't want to attach docker terminal, use -d option)

## Undeploy docker
* **Resume-API-Server/Deploy/docker$** docker-compose down
