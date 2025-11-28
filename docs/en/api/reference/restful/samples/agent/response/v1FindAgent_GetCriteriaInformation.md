```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "name",
      "Operator": "contains",
      "Values": [
        "Anderson"
      ],
      "DisplayValues": [
        "Anderson"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 0,
      "InterOperator": "And",
      "UniqueHash": 769
    }
  ],
  "CriteriaArchiveColumns": [
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
    }
  ],
  "CriteriaArchiveRows": [
    {
      "EntityName": "contact",
      "PrimaryKey": 411,
      "ColumnData": {
        "name": {
          "DisplayValue": "John Anderson",
          "TooltipHint": "Sales Manager",
          "LinkHint": "contact.main?contact_id=411"
        }
      },
      "LinkHint": "contact.main?contact_id=411",
      "StyleHint": "",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 790
        }
      }
    }
  ],
  "RestrictionGroups": [
    {
      "Name": "Active Contacts",
      "Description": "Search for active contacts in the system",
      "Rank": 1,
      "Restrictions": [
        {},
        {}
      ]
    },
    {
      "Name": "Recent Customers",
      "Description": "Contacts created in the last 30 days",
      "Rank": 2,
      "Restrictions": [
        {},
        {}
      ]
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 529
    }
  }
}
```
