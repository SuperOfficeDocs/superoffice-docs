```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 547,
  "Name": "ContactExport",
  "AssociateId": 426,
  "DetailsTable": 202,
  "DetailsRecord": 91,
  "IsSystemTask": false,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "format=xlsx",
    "ParameterObject2": "includePersons=true"
  },
  "LastStarted": "2024-11-27T09:15:00+01:00",
  "Created": "2024-11-27T09:00:00+01:00",
  "StartCount": 1,
  "DatabaseSerialNumber": "459952",
  "Context": "User Export Request",
  "Result": "Success",
  "State": "Succeeded",
  "Description": "Export contact list to Excel with related person records",
  "Response": "Successfully exported 1,245 contacts",
  "Request": "Export all active contacts from North region",
  "ProgressDescription": "Export completed - file ready for download",
  "ProgressPercent": 100,
  "FileName": "ContactExport_2024-11-27.xlsx",
  "CancellationBehaviour": "CanCancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 300
    }
  }
}
```
