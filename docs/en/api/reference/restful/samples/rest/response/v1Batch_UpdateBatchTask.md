```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 95,
  "Name": "Database Cleanup Task",
  "AssociateId": 617,
  "DetailsTable": 827,
  "DetailsRecord": 685,
  "IsSystemTask": false,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "daysOld=365",
    "ParameterObject2": "includeArchived=true"
  },
  "LastStarted": "2015-12-21T14:34:02.7223333+01:00",
  "Created": "2020-01-13T14:34:02.7223333+01:00",
  "StartCount": 198,
  "DatabaseSerialNumber": "891084",
  "Context": "Maintenance",
  "Result": "Pending",
  "State": "All",
  "Description": "Clean up old database records and optimize tables",
  "Response": "Waiting for scheduled time",
  "Request": "DatabaseCleanup",
  "ProgressDescription": "Scheduled for execution",
  "ProgressPercent": 0,
  "FileName": "cleanup_log_2024.txt",
  "CancellationBehaviour": "CanCancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 120
    }
  }
}
```