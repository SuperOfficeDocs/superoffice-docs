```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 5,
    "Name": "DataBackup",
    "AssociateId": 595,
    "DetailsTable": 359,
    "DetailsRecord": 583,
    "IsSystemTask": true,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "destination=Azure",
      "ParameterObject2": "compression=enabled"
    },
    "LastStarted": "2024-11-27T03:00:00+01:00",
    "Created": "2024-01-01T00:00:00+01:00",
    "StartCount": 331,
    "DatabaseSerialNumber": "1070177",
    "Context": "System Backup",
    "Result": "Success",
    "State": "Succeeded",
    "Description": "Automated nightly backup of all CRM data to Azure cloud storage",
    "Response": "Backup completed successfully - 15.2 GB backed up",
    "Request": "Scheduled system backup",
    "ProgressDescription": "Backup completed and verified",
    "ProgressPercent": 100,
    "FileName": "backup_2024-11-27_0300.bak",
    "CancellationBehaviour": "CannotCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 644
      }
    }
  }
]
```
