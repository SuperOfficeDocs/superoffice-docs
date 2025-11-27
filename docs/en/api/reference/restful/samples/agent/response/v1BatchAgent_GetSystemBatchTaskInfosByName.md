```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 171,
    "Name": "DatabaseMaintenance",
    "AssociateId": 774,
    "DetailsTable": 347,
    "DetailsRecord": 603,
    "IsSystemTask": true,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "operation=reindex",
      "ParameterObject2": "tables=contact,person,sale"
    },
    "LastStarted": "2024-11-27T02:00:00+01:00",
    "Created": "2024-01-01T00:00:00+01:00",
    "StartCount": 327,
    "DatabaseSerialNumber": "1702311",
    "Context": "Scheduled Maintenance",
    "Result": "Completed",
    "State": "Succeeded",
    "Description": "Nightly database maintenance - rebuild indexes and update statistics",
    "Response": "All database indexes rebuilt successfully",
    "Request": "Automated system maintenance task",
    "ProgressDescription": "Database optimization completed",
    "ProgressPercent": 100,
    "FileName": "maintenance_log_2024-11-27.txt",
    "CancellationBehaviour": "CannotCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 388
      }
    }
  }
]
```
