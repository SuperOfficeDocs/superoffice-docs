```http!
POST /api/v1/Agents/Document/GetPersonDocumentsByTemplateHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 372,
  "IncludeProjectDocuments": false,
  "StartTime": "2020-11-15T10:10:59.6938524+01:00",
  "EndTime": "2017-02-22T10:10:59.6938524+01:00",
  "Count": 868,
  "TemplateHeadingId": 74
}
```