```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 853,
    "Name": "SalesReportGeneration",
    "AssociateId": 637,
    "DetailsTable": 522,
    "DetailsRecord": 223,
    "IsSystemTask": false,
    "IsInternalTask": false,
    "ParameterObject": {
      "ParameterObject1": "period=Q4-2024",
      "ParameterObject2": "format=PDF"
    },
    "LastStarted": "2024-11-27T08:00:00+01:00",
    "Created": "2024-11-27T08:00:00+01:00",
    "StartCount": 1,
    "DatabaseSerialNumber": "864937",
    "Context": "Quarterly Reporting",
    "Result": "Completed",
    "State": "Succeeded",
    "Description": "Generate comprehensive Q4 sales performance report with charts and analysis",
    "Response": "Report generated successfully - 45 pages",
    "Request": "Generate Q4 2024 sales report for executive team",
    "ProgressDescription": "Report generation completed",
    "ProgressPercent": 100,
    "FileName": "Q4_2024_Sales_Report.pdf",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 744
      }
    }
  }
]
```
