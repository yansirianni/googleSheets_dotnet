using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Google_Sheets_API_.NET_Quickstart.Write
{
    class deleteExample
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets API .NET Quickstart";

        public void deleteData()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            SheetsService sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // The ID of the spreadsheet to update.
            string spreadsheetId = "YOUR SPREADSHEET ID";  // TODO: Update placeholder value.

            // The A1 notation of the values to update.
            string range = "YOUR SPREADSHEET RANGE";  // TODO: Update placeholder value.

            // TODO: Assign values to desired properties of `requestBody`. All existing
            // properties will be replaced:
            var requestBody = new ClearValuesRequest();

            var deleteRequest = sheetsService.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);
            var deleteReponse = deleteRequest.Execute();
        }
    }
}
