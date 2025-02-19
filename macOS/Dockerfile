# Use official .NET SDK image as build environment
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /source

# Copy csproj và restore dependencies
COPY HelloWordApp/*.csproj ./HelloWordApp/
RUN dotnet restore HelloWordApp/*.csproj

# Copy toàn bộ source code và build
COPY HelloWordApp/. ./HelloWordApp/
RUN dotnet publish HelloWordApp -c Release -o /app --no-restore

# Use .NET runtime as base image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS runtime
WORKDIR /app
COPY --from=build /app ./

# Command to run the application
ENTRYPOINT ["dotnet", "HelloWordApp.dll"]
