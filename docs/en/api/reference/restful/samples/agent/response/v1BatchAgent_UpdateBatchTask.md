```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 226,
  "Name": "ERPSync",
  "AssociateId": 820,
  "DetailsTable": 220,
  "DetailsRecord": 751,
  "IsSystemTask": false,
  "IsInternalTask": true,
  "ParameterObject": {
    "ParameterObject1": "source=SAP",
    "ParameterObject2": "syncType=incremental"
  },
  "LastStarted": "2024-11-27T14:00:00+01:00",
  "Created": "2024-11-27T14:00:00+01:00",
  "StartCount": 1,
  "DatabaseSerialNumber": "374817",
  "Context": "ERP Integration",
  "Result": "In Progress",
  "State": "InProgress",
  "Description": "Synchronize customer and order data from SAP ERP system",
  "Response": "Syncing data from ERP",
  "Request": "Sync updated customer records from SAP",
  "ProgressDescription": "Synchronizing records: 450 of 650 processed",
  "ProgressPercent": 69,
  "FileName": "erp_sync_2024-11-27.log",
  "CancellationBehaviour": "CanCancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 323
    }
  }
}
```
