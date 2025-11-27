```http!
POST /api/v1/Agents/DocumentMigration/GetForDateRange
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentPluginId": 356,
  "MinDate": "2004-06-06T10:10:59.8786266+02:00",
  "MaxDate": "2004-09-28T10:10:59.8786266+02:00",
  "IncludeEmails": true
}
```