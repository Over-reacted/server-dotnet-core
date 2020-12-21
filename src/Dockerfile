FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app
COPY *.sln .
COPY JobBoard.Api/*.csproj ./JobBoard.Api/
COPY JobBoard.Data/*.csproj ./JobBoard.Data/

RUN dotnet restore
COPY . .

# Publish API
FROM build AS publish
WORKDIR /app/JobBoard.Api
RUN dotnet publish -c Release -o out

# RUN
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=publish /app/JobBoard.Api/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "JobBoard.Api.dll"]