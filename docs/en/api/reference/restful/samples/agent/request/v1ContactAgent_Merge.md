```http!
POST /api/v1/Agents/Contact/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 893,
  "DestinationContactId": 439,
  "MergeIdenticalPersons": false,
  "ReplaceEmptyFieldsOnDestination": false
}
```