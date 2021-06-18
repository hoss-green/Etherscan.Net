FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BscScanNet.Test/BscScanNet.Test.csproj", "BscScanNet.Test/"]
RUN dotnet restore "BscScanNet.Test/BscScanNet.Test.csproj"
COPY . .
WORKDIR "/src/BscScanNet.Test"
RUN dotnet build "BscScanNet.Test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BscScanNet.Test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BscScanNet.Test.dll"]
