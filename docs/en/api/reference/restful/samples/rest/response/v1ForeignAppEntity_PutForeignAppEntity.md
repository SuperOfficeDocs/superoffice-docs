```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 246,
  "Name": "Rolfson Group",
  "CreatedDate": "2004-10-20T14:35:43.7696551+02:00",
  "UpdatedDate": "2010-01-03T14:35:43.7696551+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 766,
      "Name": "Lubowitz, Barrows and Mills",
      "CreatedDate": "2023-12-12T14:35:43.7716896+01:00",
      "UpdatedDate": "2009-05-23T14:35:43.7716896+02:00",
      "AssociateFullName": "Dr. Earnestine Thiel",
      "CreatedBy": "aperiam",
      "UpdatedBy": "aut",
      "DeviceIdentifier": "totam",
      "ForeignAppId": 224,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 669
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```