# .NET starter pack to Google Sheets API V4

Complete the steps described in the rest of this page to create a simple .NET console application that makes requests to the Google Sheets API.

Prerequisites
To run this quickstart, you need the following prerequisites:

* Visual Studio 2013 or later
* A Google account

## Step 1: Turn on the Google Sheets API

Create a new Cloud Platform project and automatically enable the Google Sheets API: https://developers.google.com/sheets/api/quickstart/dotnet

In resulting dialog click DOWNLOAD CLIENT CONFIGURATION and save the file credentials.json to your working directory.

## Step 2: Prepare the project
* Create a new Visual C# Console Application project in Visual Studio.
* Open the NuGet Package Manager Console, select the package source nuget.org, and run the following command:

    Install-Package Google.Apis.Sheets.v4

## Step 3: Set up the sample
* Drag credentials.json (downloaded in Step 1) into your Visual Studio Solution Explorer.
* Select credentials.json, and then go to the Properties window and set the Copy to Output Directory field to Copy always.
* download the repository and open the solution.

## Step 4: Run the sample
Build and run the sample by clicking Start in the Visual Studio toolbar.
The first time you run the sample, it will prompt you to authorize access:
* The sample will attempt to open a new window or tab in your default browser. If this fails, copy the URL from the console and manually open it in your browser.
* If you are not already logged into your Google account, you will be prompted to log in. If you are logged into multiple Google accounts, you will be asked to select one account to use for the authorization.
* Click the Accept button.
* The sample will proceed automatically, and you may close the window/tab.

## Notes
* Authorization information is stored on the file system, so subsequent executions will not prompt for authorization.
* The authorization flow in this example is designed for a command-line application. For information on how to perform authorization in a web application, see the web applications section of the library's OAuth 2.0 guide.




