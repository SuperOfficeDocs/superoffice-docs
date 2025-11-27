```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 970,
  "IsActive": true,
  "FieldMappings": [
    {
      "ErpFieldId": 691,
      "CrmFieldKey": "contact/name",
      "CrmDisplayName": "Company Name",
      "CrmDisplayTooltip": "Name of the company in SuperOffice CRM",
      "ErpFieldKey": "customer_name",
      "FieldType": "Text",
      "ErpDisplayName": "Customer Name",
      "ErpDisplayTooltip": "Customer name in ERP system",
      "SyncToCrm": true,
      "SyncToErp": true,
      "ShowInGui": true,
      "ShowInSearch": true,
      "AlreadyMapped": true,
      "MissingInERP": false,
      "MissingInCRM": false,
      "Access": "Mandatory",
      "ListReference": "",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
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
      "FieldLength": 913
    }
  }
}
```
