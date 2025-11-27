```http!
POST /api/v1/Agents/ErpSync/ConnectActor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 929,
  "CrmRecordId": 809,
  "CrmActorType": "Contact",
  "ErpKey": "id",
  "ErpActorType": "Customer",
  "FieldValues": [
    {
      "DisplayName": "Bergstrom-Douglas",
      "CrmFieldKey": "quis",
      "Value": "doloremque",
      "DisplayValue": "aperiam",
      "SyncToCrm": false,
      "SyncToErp": false
    },
    {
      "DisplayName": "Bergstrom-Douglas",
      "CrmFieldKey": "quis",
      "Value": "doloremque",
      "DisplayValue": "aperiam",
      "SyncToCrm": false,
      "SyncToErp": false
    }
  ]
}
```