FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["HelloWorldWorkerService/HelloWorldWorkerService.csproj", "HelloWorldWorkerService/"]
RUN dotnet restore "HelloWorldWorkerService/HelloWorldWorkerService.csproj"
COPY . .
WORKDIR "/src/HelloWorldWorkerService"
RUN dotnet build "HelloWorldWorkerService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloWorldWorkerService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWorldWorkerService.dll"]
