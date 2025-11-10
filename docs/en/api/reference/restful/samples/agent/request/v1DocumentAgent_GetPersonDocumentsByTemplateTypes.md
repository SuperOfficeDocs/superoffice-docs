```http!
POST /api/v1/Agents/Document/GetPersonDocumentsByTemplateTypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 405,
  "IncludeProjectDocuments": true,
  "StartTime": "2003-10-10T10:10:59.6938524+02:00",
  "EndTime": "2017-01-03T10:10:59.6938524+01:00",
  "Count": 904,
  "DocumentTemplateIds": [
    523,
    886
  ]
}
```