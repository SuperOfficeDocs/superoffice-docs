```http!
POST /api/v1/Agents/Project/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SourceProjectId": 959,
  "DestinationProjectId": 225,
  "ReplaceEmptyFieldsOnDestination": true
}
```