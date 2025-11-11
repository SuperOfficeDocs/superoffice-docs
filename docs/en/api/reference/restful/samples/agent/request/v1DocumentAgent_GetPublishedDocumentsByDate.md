```http!
POST /api/v1/Agents/Document/GetPublishedDocumentsByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 44,
  "IncludeProjectDocuments": true,
  "StartTime": "2021-07-28T10:10:59.8746268+02:00",
  "EndTime": "2002-05-29T10:10:59.8746268+02:00",
  "Count": 998
}
```