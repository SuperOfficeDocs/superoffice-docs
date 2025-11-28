```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DisplayName": "Microsoft Dynamics 365 Sales",
  "DisplayDescription": "Active ERP integration synchronizing customers, products, and sales data",
  "Active": true,
  "Deleted": false,
  "LastSync": "2024-11-27T10:30:00+01:00",
  "Actors": [
    {
      "ActorType": "Customer",
      "HasMappings": true,
      "Defaults": "5 default field values configured",
      "Mappings": "12 fields mapped (Name, Address, VAT, etc.)",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    },
    {
      "ActorType": "Project",
      "HasMappings": true,
      "Defaults": "3 default field values configured",
      "Mappings": "8 fields mapped (Name, Status, Budget, etc.)",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 919
    }
  }
}
```
