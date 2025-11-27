```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 879,
  "Name": "Sales Pipeline Overview",
  "Description": "Visual representation of active sales opportunities by stage",
  "DefaultHeight": 2,
  "DefaultWidth": 2,
  "TileType": "Area",
  "EntityType": "Sale",
  "EntityName": "Sales",
  "SelectionId": 257,
  "CurrencyMode": "Base",
  "CurrencyCode": "USD",
  "Measure": "Sum",
  "MeasureField": "Amount",
  "SortBy": "Stage",
  "LayoutConfig": "{\"chartType\":\"funnel\",\"showLegend\":true}",
  "SecondarySelectionId": 603,
  "MeasureByField": "SaleStage",
  "Usage": "Dashboard",
  "ProviderName": "SaleProvider",
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
