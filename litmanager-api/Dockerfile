FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["litmanager-api/litmanager-api.csproj", "litmanager-api/"]
RUN dotnet restore "litmanager-api/litmanager-api.csproj"
COPY . .
WORKDIR "/src/litmanager-api"
RUN dotnet build "litmanager-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "litmanager-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "litmanager-api.dll"]