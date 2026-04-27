# Sitecoredemo Docker Headless Starter Kit

## Prerequisites

- NodeJs 21.x
- .NET 6.0 SDK
- Visual Studio Code
- Docker for Windows, with Windows Containers enabled

See Sitecore Containers documentation for more information on system requirements.

if you want to read Japanese readme. please click [here](README_ja.md)

## Setup

The project will include all of the steps we have outlined in our blog series.

1. create .env file using .env.example
2. In an ADMIN terminal: Please change path for license file.

   ```ps1
   .\init.ps1 -InitEnv -LicenseXmlPath "C:\projects\license\license.xml" -AdminPassword "DesiredAdminPassword"
   ```

3. please execute script : `up.ps1`

   ```ps1
   .\up.ps1
   ```

you can access to Sitecore 10.4 with Headless SXA - Next.js environment.

The project will include all of the steps we have outlined in [my blog series](https://haramizu.com/en-US/).
