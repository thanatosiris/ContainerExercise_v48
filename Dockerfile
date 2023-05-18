# Start a container from the base SDK container 
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
# Set the working directory in the build container
WORKDIR /project
# Copy the project into the build container
COPY . .
# Restore nuget packages
RUN nuget restore
# use msbuild to publish project in /FramworkApp folder to c:\publish, which includes only binaries and content files (no sources)
RUN msbuild "WebApplication\WebApplication.csproj" /p:DeployOnBuild=true /p:PublishUrl="publish" /p:WebPublishMethod=FileSystem /p:DeployDefaultTarget=WebPublish
 
# Start a container from a base .NET Framework runtime with IIS
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
# Set the working directory of the runtime container
WORKDIR /inetpub/wwwroot
# Copy all the files from the build
COPY --from=build /project/WebApplication/publish. ./