```http!
POST /api/v1/Agents/ErpSync/TryConnectActor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 23,
  "CrmRecordId": 64,
  "CrmActorType": "Contact",
  "ErpKey": "similique",
  "ErpActorType": "Customer",
  "FieldValues": [
    {
      "DisplayName": "Maggio-Johns",
      "CrmFieldKey": "dolorem",
      "Value": "aut",
      "DisplayValue": "qui",
      "SyncToCrm": false,
      "SyncToErp": false
    },
    {
      "DisplayName": "Maggio-Johns",
      "CrmFieldKey": "dolorem",
      "Value": "aut",
      "DisplayValue": "qui",
      "SyncToCrm": false,
      "SyncToErp": false
    }
  ]
}
```