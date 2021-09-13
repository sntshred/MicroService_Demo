FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

#  COPYING THIE FILES FROM .CSPROJ TO /app, TO KNOW YOUR PACKAGES NEEDS TO RUN

COPY *.csproj /app
RUN dotnet restore 

COPY . ./

RUN dotnet publish -c Release -o out

from mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out/ .

entrypoint ["dotnet", "CommandsService.dll"]




