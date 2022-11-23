FROM mcr.microsoft.com/dotnet/sdk:7.0.100-bullseye-slim-amd64 AS sdk
WORKDIR /fifa
COPY ["src/FIFAWorldCup.API/FIFAWorldCup.API.csproj", "src/FIFAWorldCup.API/"]
RUN dotnet restore "src/FIFAWorldCup.API/FIFAWorldCup.API.csproj"
COPY . .
RUN dotnet publish "src/FIFAWorldCup.API/FIFAWorldCup.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:7.0.0-bullseye-slim-amd64
WORKDIR /app
EXPOSE 80
COPY --from=sdk /app/publish .
ENTRYPOINT ["dotnet", "FIFAWorldCup.API.dll"]