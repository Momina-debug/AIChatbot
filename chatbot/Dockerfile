# STEP 1: Build the app using the .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy everything and restore dependencies
COPY . ./
RUN dotnet restore

# Build and publish a Release
RUN dotnet publish -c Release -o out

# STEP 2: Runtime Stage
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# IMPORTANT: Change 'chatbot.dll' if your project name is different!
ENTRYPOINT ["dotnet", "chatbot.dll"]