FROM mcr.microsoft.com/dotnet/runtime:7.0.0-alpine3.16-amd64 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0.100-alpine3.16-amd64 AS build
WORKDIR /src
COPY "UA-home-assistant-server.csproj" .
RUN dotnet restore "UA-home-assistant-server.csproj"
COPY . .
RUN dotnet build "UA-home-assistant-server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UA-home-assistant-server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeAssistantOPCUAServer.dll"]
