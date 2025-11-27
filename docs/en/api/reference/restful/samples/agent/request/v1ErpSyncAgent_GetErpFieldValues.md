```http!
POST /api/v1/Agents/ErpSync/GetErpFieldValues
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 929,
  "CrmActorType": "Contact",
  "EntityId": 392,
  "FieldKeys": [
    "rerum",
    "ipsum"
  ]
}
```