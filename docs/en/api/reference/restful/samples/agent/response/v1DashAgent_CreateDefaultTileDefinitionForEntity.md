```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileDefinitionId": 167,
  "Name": "Upcoming Appointments",
  "Description": "List of scheduled meetings and appointments for the next 7 days",
  "DefaultHeight": 2,
  "DefaultWidth": 2,
  "TileType": "List",
  "EntityType": "Appointment",
  "EntityName": "Appointments",
  "SelectionId": 87,
  "CurrencyMode": "Base",
  "CurrencyCode": "USD",
  "Measure": "Count",
  "MeasureField": "AppointmentId",
  "SortBy": "StartDate",
  "LayoutConfig": "{\"showTime\":true,\"showLocation\":true}",
  "SecondarySelectionId": 620,
  "MeasureByField": "Type",
  "Usage": "Dashboard",
  "ProviderName": "AppointmentProvider",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 469
    }
  }
}
```
