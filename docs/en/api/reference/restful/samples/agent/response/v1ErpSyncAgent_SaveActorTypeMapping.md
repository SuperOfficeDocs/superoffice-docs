```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 543,
  "IsActive": true,
  "FieldMappings": [
    {
      "ErpFieldId": 79,
      "CrmFieldKey": "contact/department",
      "CrmDisplayName": "Department",
      "CrmDisplayTooltip": "Department within the company",
      "ErpFieldKey": "customer_department",
      "FieldType": "Text",
      "ErpDisplayName": "Customer Department",
      "ErpDisplayTooltip": "Department field in ERP",
      "SyncToCrm": true,
      "SyncToErp": true,
      "ShowInGui": true,
      "ShowInSearch": true,
      "AlreadyMapped": true,
      "MissingInERP": false,
      "MissingInCRM": false,
      "Access": "Normal",
      "ListReference": "",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 855
        }
      }
    }
  ],
  "ActorTypeErp": "Customer",
  "ActorTypeCrm": "Contact",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 689
    }
  }
}
```
