FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903
WORKDIR /app
COPY  DevOpsSupportPOC/app/publish .
ENTRYPOINT ["dotnet", "DevOpsSupportPOC.dll"]
EXPOSE 80
EXPOSE 443