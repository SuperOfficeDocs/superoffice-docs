```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Name",
      "DisplayTooltip": "Contact name",
      "DisplayType": "string",
      "CanOrderBy": true,
      "Name": "name",
      "CanRestrictBy": true,
      "RestrictionType": "string",
      "RestrictionListName": "",
      "IsVisible": true,
      "ExtraInfo": "",
      "Width": "200",
      "IconHint": "person",
      "HeadingIconHint": "person"
    },
    {
      "DisplayName": "Company",
      "DisplayTooltip": "Company name",
      "DisplayType": "string",
      "CanOrderBy": true,
      "Name": "contactAssociate/company",
      "CanRestrictBy": true,
      "RestrictionType": "string",
      "RestrictionListName": "",
      "IsVisible": true,
      "ExtraInfo": "",
      "Width": "200",
      "IconHint": "building",
      "HeadingIconHint": "building"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "contact",
      "PrimaryKey": 237,
      "ColumnData": {
        "name": {
          "DisplayValue": "John Anderson",
          "TooltipHint": "Sales Manager",
          "LinkHint": "contact.main?contact_id=237"
        },
        "contactAssociate/company": {
          "DisplayValue": "Acme Corporation",
          "TooltipHint": "Manufacturing",
          "LinkHint": "company.main?company_id=123"
        }
      },
      "LinkHint": "contact.main?contact_id=237",
      "StyleHint": "",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 548
        }
      }
    }
  ],
  "RowCount": 1,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 138
    }
  }
}
```
