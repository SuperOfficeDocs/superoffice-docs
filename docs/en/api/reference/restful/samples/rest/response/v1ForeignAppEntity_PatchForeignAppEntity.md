```http_
HTTP/1.1 200 ForeignAppEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 607,
  "Name": "Mohr Inc and Sons",
  "CreatedDate": "1999-08-26T14:35:43.772689+02:00",
  "UpdatedDate": "2021-12-06T14:35:43.772689+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 20,
      "Name": "Stehr Group",
      "CreatedDate": "2003-11-23T14:35:43.7736888+01:00",
      "UpdatedDate": "2007-03-23T14:35:43.7736888+01:00",
      "AssociateFullName": "Adelia Hansen DDS",
      "CreatedBy": "qui",
      "UpdatedBy": "nisi",
      "DeviceIdentifier": "perferendis",
      "ForeignAppId": 727,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 974
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```