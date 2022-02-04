#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ServerNet6/ServerNet6.csproj", "ServerNet6/"]
RUN dotnet restore "ServerNet6/ServerNet6.csproj"
COPY . .
WORKDIR "/src/ServerNet6"
RUN dotnet build "ServerNet6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServerNet6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServerNet6.dll"]