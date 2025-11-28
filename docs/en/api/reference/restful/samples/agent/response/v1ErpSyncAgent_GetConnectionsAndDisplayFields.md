```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ErpConnectionId": 301,
    "ConnectionName": "SAP Business One Connection",
    "Connected": true,
    "ErpFields": [
      {
        "FieldKey": "erp_customer_id",
        "Rank": 1,
        "DisplayName": "Customer ID",
        "DisplayDescription": "Unique customer identifier in SAP Business One",
        "FieldType": "Text",
        "ListName": "",
        "DefaultValue": "",
        "MaxLength": 50,
        "Access": "Mandatory",
        "ShowInSearch": true,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 721
          }
        }
      }
    ],
    "CrmActorType": "Contact",
    "ErpActorType": "Customer",
    "ErpActorTypes": [
      "Customer",
      "Supplier"
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 783
      }
    }
  }
]
```
