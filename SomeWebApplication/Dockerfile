#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Dockerfile.aspnetcoresdk
FROM rrvieira/aspnetcore-sdk:1.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src

COPY ["SomeWebApplication/SomeWebApplication.csproj", "SomeWebApplication/"]
RUN dotnet restore "SomeWebApplication/SomeWebApplication.csproj"
COPY . .
WORKDIR "/src/SomeWebApplication"
RUN dotnet build "SomeWebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SomeWebApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .