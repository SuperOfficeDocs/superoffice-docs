```http!
POST /api/v1/Agents/ErpSync/CreateErpActorFromCrm
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ConnectionId": 54,
  "CrmEntityId": 894,
  "ErpActorType": "Customer",
  "CrmActorType": "Contact",
  "ErpFieldKeyValues": {
    "ErpFieldKeyValues1": "quidem",
    "ErpFieldKeyValues2": "laboriosam"
  }
}
```