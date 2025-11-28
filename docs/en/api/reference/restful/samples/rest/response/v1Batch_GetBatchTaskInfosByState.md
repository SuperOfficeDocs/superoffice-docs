```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 186,
    "Name": "Contact Data Import",
    "AssociateId": 972,
    "DetailsTable": 343,
    "DetailsRecord": 603,
    "IsSystemTask": false,
    "IsInternalTask": false,
    "ParameterObject": {
      "ParameterObject1": "sourceFile=contacts.xlsx",
      "ParameterObject2": "mapping=default"
    },
    "LastStarted": "2015-10-16T14:34:02.7210753+02:00",
    "Created": "2006-12-19T14:34:02.7210753+01:00",
    "StartCount": 51,
    "DatabaseSerialNumber": "1233454",
    "Context": "Import",
    "Result": "In progress",
    "State": "All",
    "Description": "Import contacts from Excel spreadsheet",
    "Response": "Processing row 500 of 2000",
    "Request": "ImportContacts",
    "ProgressDescription": "Importing contact records...",
    "ProgressPercent": 25,
    "FileName": "contacts_import_batch.xlsx",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 166
      }
    }
  }
]
```