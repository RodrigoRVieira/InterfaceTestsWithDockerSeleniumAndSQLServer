#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Dockerfile.coresdkseleniumdebug
FROM rrvieira/core-sdk-selenium-debug:1.0 AS build 

WORKDIR /SomeWebApplicationInterfaceTests

COPY ./SomeWebApplicationInterfaceTests.csproj ./
COPY ./BaseTest.cs ./BaseTest.cs
COPY ./MainPageInterfaceTests.cs ./MainPageInterfaceTests.cs

RUN dotnet restore