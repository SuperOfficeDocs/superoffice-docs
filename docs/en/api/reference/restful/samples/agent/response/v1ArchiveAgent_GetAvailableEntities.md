```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 693,
    "Name": "Contact",
    "ToolTip": "Company and organization records",
    "Deleted": false,
    "Rank": 1,
    "Type": "ArchiveProvider",
    "ChildItems": [
      {
        "Id": 830,
        "Name": "Person",
        "ToolTip": "Individual contact persons within companies",
        "Deleted": false,
        "Rank": 2,
        "Type": "ArchiveProvider",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "person",
        "ColorBlock": 751,
        "ExtraInfo": "PersonArchive",
        "StyleHint": "entity",
        "FullName": "Person Archive",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 137
          }
        }
      }
    ],
    "IconHint": "company",
    "ColorBlock": 71,
    "ExtraInfo": "ContactArchive",
    "StyleHint": "entity",
    "FullName": "Contact Archive",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 14
      }
    }
  }
]
```
