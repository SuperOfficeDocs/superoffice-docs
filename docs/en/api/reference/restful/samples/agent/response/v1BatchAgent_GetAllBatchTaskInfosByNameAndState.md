```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 609,
    "Name": "SalesAnalytics",
    "AssociateId": 705,
    "DetailsTable": 298,
    "DetailsRecord": 439,
    "IsSystemTask": false,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "timeframe=YTD",
      "ParameterObject2": "metrics=conversion,revenue,pipeline"
    },
    "LastStarted": "2024-11-27T07:00:00+01:00",
    "Created": "2024-11-27T07:00:00+01:00",
    "StartCount": 1,
    "DatabaseSerialNumber": "1327099",
    "Context": "Business Intelligence",
    "Result": "Success",
    "State": "Succeeded",
    "Description": "Calculate year-to-date sales analytics and KPIs for dashboard",
    "Response": "Analytics computed successfully - 15 metrics calculated",
    "Request": "Run YTD sales analytics for executive dashboard",
    "ProgressDescription": "Analytics calculation completed",
    "ProgressPercent": 100,
    "FileName": "sales_analytics_YTD_2024.json",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 532
      }
    }
  }
]
```
