```http!
POST /api/v1/Agents/Person/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourcePersonId": 94,
  "DestinationPersonId": 24,
  "MoveAfterDate": "1999-12-15T10:11:00.6752119+01:00",
  "DeleteSource": false,
  "ReplaceEmptyFieldsOnDestination": false
}
```