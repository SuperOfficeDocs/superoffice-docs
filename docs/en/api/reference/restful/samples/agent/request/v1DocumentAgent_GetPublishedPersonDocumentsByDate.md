```http!
POST /api/v1/Agents/Document/GetPublishedPersonDocumentsByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 786,
  "IncludeProjectDocuments": true,
  "StartTime": "1999-10-24T10:10:59.6421965+02:00",
  "EndTime": "2018-04-05T10:10:59.6421965+02:00",
  "Count": 576
}
```