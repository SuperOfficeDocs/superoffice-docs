```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 140,
  "Name": "Active Tickets by Priority",
  "Description": "Distribution of open support tickets categorized by priority level",
  "DefaultHeight": 2,
  "DefaultWidth": 2,
  "TileType": "Bignum",
  "EntityType": "Ticket",
  "EntityName": "Tickets",
  "SelectionId": 906,
  "CurrencyMode": "Base",
  "CurrencyCode": "USD",
  "Measure": "Count",
  "MeasureField": "TicketId",
  "SortBy": "Priority",
  "LayoutConfig": "{\"chartType\":\"pie\",\"showPercentage\":true}",
  "SecondarySelectionId": 878,
  "MeasureByField": "PriorityId",
  "Usage": "Dashboard",
  "ProviderName": "TicketProvider",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 690
    }
  }
}
```
