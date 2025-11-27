```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 347,
    "Name": "TempFileCleanup",
    "AssociateId": 998,
    "DetailsTable": 712,
    "DetailsRecord": 475,
    "IsSystemTask": true,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "retentionDays=7",
      "ParameterObject2": "location=temp"
    },
    "LastStarted": "2024-11-27T04:00:00+01:00",
    "Created": "2024-01-01T00:00:00+01:00",
    "StartCount": 331,
    "DatabaseSerialNumber": "459953",
    "Context": "System Maintenance",
    "Result": "Completed",
    "State": "Succeeded",
    "Description": "Remove temporary files and exports older than 7 days to free up disk space",
    "Response": "Cleaned up 2.8 GB of temporary files",
    "Request": "Automated temporary file cleanup",
    "ProgressDescription": "Cleanup completed - disk space recovered",
    "ProgressPercent": 100,
    "FileName": "cleanup_log_2024-11-27.txt",
    "CancellationBehaviour": "CannotCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 826
      }
    }
  }
]
```
