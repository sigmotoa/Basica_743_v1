FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["IntroC_Sharp/IntroC_Sharp.csproj", "IntroC_Sharp/"]
RUN dotnet restore "IntroC_Sharp/IntroC_Sharp.csproj"
COPY . .
WORKDIR "/src/IntroC_Sharp"
RUN dotnet build "IntroC_Sharp.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "IntroC_Sharp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IntroC_Sharp.dll"]
