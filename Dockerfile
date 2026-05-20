FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY EduTech.sln .
COPY EduTech/EduTech.csproj EduTech/
RUN dotnet restore EduTech/EduTech.csproj

COPY . .
RUN dotnet publish EduTech/EduTech.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "EduTech.dll"]
