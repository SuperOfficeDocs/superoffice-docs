```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 322,
  "Name": "Revenue This Month",
  "Description": "Total revenue generated in the current month with trend comparison",
  "DefaultHeight": 1,
  "DefaultWidth": 2,
  "TileType": "Bignum",
  "EntityType": "Sale",
  "EntityName": "Sales",
  "SelectionId": 350,
  "CurrencyMode": "Base",
  "CurrencyCode": "USD",
  "Measure": "Sum",
  "MeasureField": "Amount",
  "SortBy": "RegisteredDate",
  "LayoutConfig": "{\"showTrend\":true,\"comparisonPeriod\":\"lastMonth\"}",
  "SecondarySelectionId": 783,
  "MeasureByField": "SaleDate",
  "Usage": "Dashboard",
  "ProviderName": "SaleProvider",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 90
    }
  }
}
```
