```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Contact Name",
      "DisplayTooltip": "The name of the contact/company",
      "DisplayType": "string",
      "CanOrderBy": true,
      "Name": "contactName",
      "CanRestrictBy": true,
      "RestrictionType": "string",
      "RestrictionListName": "",
      "IsVisible": true,
      "ExtraInfo": "Primary contact field",
      "Width": "200",
      "IconHint": "company",
      "HeadingIconHint": "company"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 4,
      "Name": "Contact",
      "ToolTip": "Company/organization entity",
      "Deleted": false,
      "Rank": 1,
      "Type": "Entity",
      "ColorBlock": 538,
      "IconHint": "company",
      "Selected": true,
      "LastChanged": "2024-11-20T10:00:00+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "Company/Contact archive",
      "StyleHint": "entity",
      "Hidden": false,
      "FullName": "Contact Archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "name",
      "Direction": "ASC"
    },
    {
      "Name": "updatedDate",
      "Direction": "DESC"
    }
  ],
  "OwnerKeys": "contact=123,person=456",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 732
    }
  }
}
```
