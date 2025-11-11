```http!
POST /api/v1/Agents/Document/GetPersonDocumentsByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 410,
  "IncludeProjectDocuments": false,
  "StartTime": "2008-12-26T10:10:59.6938524+01:00",
  "EndTime": "2017-08-09T10:10:59.6938524+02:00",
  "Count": 612
}
```