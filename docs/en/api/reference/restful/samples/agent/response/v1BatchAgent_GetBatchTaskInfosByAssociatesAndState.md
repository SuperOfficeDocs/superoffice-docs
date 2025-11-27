```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 231,
    "Name": "LeadImport",
    "AssociateId": 424,
    "DetailsTable": 206,
    "DetailsRecord": 867,
    "IsSystemTask": false,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "source=TradeshowLeads.csv",
      "ParameterObject2": "mappingProfile=StandardLead"
    },
    "LastStarted": "2024-11-27T13:15:00+01:00",
    "Created": "2024-11-27T13:00:00+01:00",
    "StartCount": 1,
    "DatabaseSerialNumber": "962279",
    "Context": "Data Import",
    "Result": "In Progress",
    "State": "InProgress",
    "Description": "Import leads from tradeshow event into CRM system",
    "Response": "Importing lead records",
    "Request": "Import 850 leads from TechExpo 2024",
    "ProgressDescription": "Importing leads: 620 of 850 processed",
    "ProgressPercent": 73,
    "FileName": "TradeshowLeads_TechExpo2024.csv",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 923
      }
    }
  }
]
```
