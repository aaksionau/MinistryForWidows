#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MinistryForWidows/MinistryForWidows.csproj", "MinistryForWidows/"]
COPY ["MinistryForWidows.Persistence/MinistryForWidows.Persistence.csproj", "MinistryForWidows.Persistence/"]
COPY ["MinistryForWidows.Domain/MinistryForWidows.Domain.csproj", "MinistryForWidows.Domain/"]
COPY ["MinistryForWidows.Contracts/MinistryForWidows.Contracts.csproj", "MinistryForWidows.Contracts/"]
RUN dotnet restore "./MinistryForWidows/MinistryForWidows.csproj"
COPY . .
WORKDIR "/src/MinistryForWidows"
RUN dotnet build "./MinistryForWidows.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MinistryForWidows.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinistryForWidows.dll"]