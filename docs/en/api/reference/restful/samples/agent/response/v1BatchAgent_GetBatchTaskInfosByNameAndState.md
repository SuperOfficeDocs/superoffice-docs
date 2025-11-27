```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 917,
    "Name": "RenewalNotifications",
    "AssociateId": 441,
    "DetailsTable": 408,
    "DetailsRecord": 762,
    "IsSystemTask": false,
    "IsInternalTask": false,
    "ParameterObject": {
      "ParameterObject1": "notificationDays=30",
      "ParameterObject2": "channel=email"
    },
    "LastStarted": "2024-11-27T06:00:00+01:00",
    "Created": "2024-11-27T06:00:00+01:00",
    "StartCount": 1,
    "DatabaseSerialNumber": "1812539",
    "Context": "Customer Communication",
    "Result": "Success",
    "State": "Succeeded",
    "Description": "Send 30-day renewal reminder notifications to customers with expiring contracts",
    "Response": "Sent 42 renewal notifications successfully",
    "Request": "Send contract renewal reminders for December expirations",
    "ProgressDescription": "Notification delivery completed",
    "ProgressPercent": 100,
    "FileName": "renewal_notifications_2024-11-27.log",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 541
      }
    }
  }
]
```
