﻿FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Chapter1/Part1/Chapter1Part1/Chapter1Part1.csproj", "Chapter1/Part1/Chapter1Part1/"]
RUN dotnet restore "Chapter1/Part1/Chapter1Part1/Chapter1Part1.csproj"
COPY . .
WORKDIR "/src/Chapter1/Part1/Chapter1Part1"
RUN dotnet build "./Chapter1Part1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Chapter1Part1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chapter1Part1.dll"]
