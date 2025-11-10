```http!
POST /api/v1/Agents/Document/GetProjectDocumentsByTemplateTypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 801,
  "StartTime": "2003-07-08T10:10:59.6907906+02:00",
  "EndTime": "2015-05-09T10:10:59.6907906+02:00",
  "Count": 166,
  "DocumentTemplateIds": [
    334,
    485
  ]
}
```