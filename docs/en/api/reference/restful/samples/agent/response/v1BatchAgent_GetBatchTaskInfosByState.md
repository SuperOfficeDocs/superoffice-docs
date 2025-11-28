```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 483,
    "Name": "BulkEmailSend",
    "AssociateId": 611,
    "DetailsTable": 516,
    "DetailsRecord": 852,
    "IsSystemTask": false,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "campaign=Q4Newsletter",
      "ParameterObject2": "recipients=2500"
    },
    "LastStarted": "2024-11-27T10:30:00+01:00",
    "Created": "2024-11-27T10:00:00+01:00",
    "StartCount": 1,
    "DatabaseSerialNumber": "918244",
    "Context": "Marketing Campaign",
    "Result": "In Progress",
    "State": "InProgress",
    "Description": "Send Q4 newsletter to selected customer segment",
    "Response": "Processing batch email send",
    "Request": "Send marketing email to 2,500 active customers",
    "ProgressDescription": "Sending emails: 1,875 of 2,500 sent",
    "ProgressPercent": 75,
    "FileName": "EmailCampaign_Q4_2024.html",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 677
      }
    }
  }
]
```
