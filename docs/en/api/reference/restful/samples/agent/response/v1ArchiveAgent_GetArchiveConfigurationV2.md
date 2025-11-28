```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Sale Amount",
      "DisplayTooltip": "Total sale amount",
      "DisplayType": "decimal",
      "CanOrderBy": true,
      "Name": "amount",
      "CanRestrictBy": true,
      "RestrictionType": "decimal",
      "RestrictionListName": "",
      "IsVisible": true,
      "ExtraInfo": "sale.amount",
      "Width": "120",
      "IconHint": "currency",
      "HeadingIconHint": "money"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 745,
      "Name": "Sale",
      "ToolTip": "Sales and opportunities archive",
      "Deleted": false,
      "Rank": 1,
      "Type": "ArchiveProvider",
      "ColorBlock": 323,
      "IconHint": "sale",
      "Selected": true,
      "LastChanged": "2024-11-20T10:00:00+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "SaleArchive",
      "StyleHint": "entity",
      "Hidden": false,
      "FullName": "Sale Archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 342
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "saleDate",
      "Direction": "DESC"
    },
    {
      "Name": "amount",
      "Direction": "DESC"
    }
  ],
  "OwnerKeys": "sale=400,contact=123",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 85
    }
  }
}
```
