# DevOps Artifacts Cleaner
- Do you have an Azure DevOps Organization?
- Are you using Artifacts feature to store your NUGET packages?
- Are you publishing a lot of pre-release packages?
- Is the size of your Artifacts storage increasing every day?

Do you want to unlist or delete various packages to cleanup your storage but the web feature offered by Azure DevOps is too cumbersome?

DevOps Artifact Cleaner is a Windows Form application based on .NET8 that use the Azure DevOps API to perform some useful actions.<br>
Yeah, you can use Powershell to perform the same actions. Up to you!

## Features

- Configure and test the connection to your Azure DevOps organization's artifact repository.
- **View packages and their versions** (you can choose to view only latest version or all versions).
- Filter packages by name (you can use part of the package's name).
- Filter versions by official/pre release and/or listed/unlisted.
- View all packages that have the same selected version (this is the killer feature if you have a lot of different nuget packages representing you entire solution)
- **Perform following action to selected versions**:
  - **UNLIST**
  - **RELIST**
  - **DELETE**

Some useful sub-features:
- Persist (securely) you configuration into user settings (appdata) so you can reopen the app fastly.
- Persist the window's size and vertical/horizontal split size so you can reopen the app with the same size.

![image](https://github.com/lucaritossa/DevOpsArtifactsCleaner/assets/12578097/a9d7b3fc-5c8c-470e-9e0c-4218a6cde4b6)

## Installation
View the [Releases](https://github.com/lucaritossa/DevOpsArtifactsCleaner/releases) page. You can download the setup.exe or the portable edition.

At first run you have to set the options to correctly communicate with you Azure DevOps organization.<br>
![image](https://github.com/lucaritossa/DevOpsArtifactsCleaner/assets/12578097/2840619b-cd3c-4bfe-9e04-f91e41716497)

A PAT (Personal Access Token) is required to permit DevOps Artifacts Cleaner to correctly communicate via API with Azure DevOps. You have to create one from "Personal access tokens" feature from you Azure DevOps "User settings"
![image](https://github.com/lucaritossa/DevOpsArtifactsCleaner/assets/12578097/79c53aec-d241-40b7-af74-99d4a77eedf7)
<br>
Follow this example to create you PAT. The only **scope** you need is **Packaging's Read&Write**.
![image](https://github.com/lucaritossa/DevOpsArtifactsCleaner/assets/12578097/dea6f69b-960c-4e0f-989d-851249d98923)

## Contribute
Your help is welcome!

You need [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) and [.NET8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed.

To create the setup.exe it was used [Microsoft Visual Studio Installer Projects 2022](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2022InstallerProjects)
