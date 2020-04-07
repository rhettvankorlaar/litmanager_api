FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

COPY litmanager-api.csproj ./build/
RUN dotnet restore "./build/litmanager-api.csproj"

COPY . /build/

RUN dotnet build "build/litmanager-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "build/litmanager-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "litmanager-api.dll"]