# Logging and Monitoring in ASP.NET Core 6

Repo URL: [https://github.com/dahlsailrunner/logging-monitoring-aspnet6](https://github.com/dahlsailrunner/logging-monitoring-aspnet6)

## VS Code Setup

The `C#` extension is required to use this repo.  I have some other settings that you may be curious about
and they are described in my [VS Code gist](https://gist.github.com/dahlsailrunner/1765b807940e29951ea6bdfb36cd85dd).


--------------------------------

To add razor web app:
dotnet new razor -o CarvedRock.WebApp -f net6.0

-------------------------------

To add into solutions 

dotnet new sln
dotnet new console --output folder1/folder2/myapp
dotnet sln add folder1/folder2/myapp


----------------------------------

To run multiple start up projects 

1. add configuration with unique name like .NET Core Launch APP,.NET Core Launch (web) in launch json
2. add this after configuration object :
    "compounds": [
        {
            "name": "Run multiple projects",
            "configurations": [".NET Core Launch APP", ".NET Core Launch (web)"]
        }
    ]