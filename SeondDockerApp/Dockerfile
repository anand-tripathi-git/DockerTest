FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["SeondDockerApp/SeondDockerApp.csproj", "SeondDockerApp/"]
RUN dotnet restore "SeondDockerApp/SeondDockerApp.csproj"
COPY . .
WORKDIR "/src/SeondDockerApp"
RUN dotnet build "SeondDockerApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SeondDockerApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SeondDockerApp.dll"]
