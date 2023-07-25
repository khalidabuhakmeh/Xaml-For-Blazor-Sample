FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["XamlMadness/XamlMadness.csproj", "XamlMadness/"]
RUN dotnet restore "XamlMadness/XamlMadness.csproj"
COPY . .
WORKDIR "/src/XamlMadness"
RUN dotnet build "XamlMadness.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XamlMadness.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XamlMadness.dll"]
