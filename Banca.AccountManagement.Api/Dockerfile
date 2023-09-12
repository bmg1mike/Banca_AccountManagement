FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Banca.AccountManagement.Api/Banca.AccountManagement.Api.csproj", "Banca.AccountManagement.Api/"]
RUN dotnet restore "Banca.AccountManagement.Api/Banca.AccountManagement.Api.csproj"
COPY . .
WORKDIR "/src/Banca.AccountManagement.Api"
RUN dotnet build "Banca.AccountManagement.Api.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Banca.AccountManagement.Api.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Banca.AccountManagement.Api.dll"]
