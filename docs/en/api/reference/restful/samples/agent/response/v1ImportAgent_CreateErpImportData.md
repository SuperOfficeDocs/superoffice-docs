```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ImportLines": [
    {
      "Values": [
        "CUST-10523",
        "Acme Corporation",
        "Manufacturing",
        "New York",
        "USA"
      ],
      "Selected": true,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "ERP-CUSTOMER-10523",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 540
        }
      }
    }
  ],
  "ColumnInfos": [
    {
      "Name": "customer_id",
      "DisplayName": "Customer ID",
      "Locked": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    },
    {
      "Name": "company_name",
      "DisplayName": "Company Name",
      "Locked": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 200
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 236
    }
  }
}
```
