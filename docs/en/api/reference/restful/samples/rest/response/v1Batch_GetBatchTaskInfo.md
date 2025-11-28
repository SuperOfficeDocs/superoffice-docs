```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 212,
  "Name": "Email Campaign Export",
  "AssociateId": 113,
  "DetailsTable": 633,
  "DetailsRecord": 137,
  "IsSystemTask": false,
  "IsInternalTask": true,
  "ParameterObject": {
    "ParameterObject1": "selectionId=1234",
    "ParameterObject2": "format=csv"
  },
  "LastStarted": "2009-09-21T14:34:02.7132229+02:00",
  "Created": "2019-10-02T14:34:02.7132229+02:00",
  "StartCount": 383,
  "DatabaseSerialNumber": "1358843",
  "Context": "Marketing",
  "Result": "Completed successfully",
  "State": "All",
  "Description": "Export email campaign recipients to CSV file",
  "Response": "Export completed with 1500 records",
  "Request": "ExportSelection",
  "ProgressDescription": "Processing records...",
  "ProgressPercent": 100,
  "FileName": "campaign_export_2024.csv",
  "CancellationBehaviour": "CanCancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 217
    }
  }
}
```