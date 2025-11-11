```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 672,
  "Name": "Harris, Hauck and Volkman",
  "CreatedDate": "2025-09-13T14:34:02.0027636+02:00",
  "UpdatedDate": "2019-12-24T14:34:02.0027636+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 926,
      "Name": "Hilpert Inc and Sons",
      "CreatedDate": "2001-03-31T14:34:02.0027636+02:00",
      "UpdatedDate": "2011-09-20T14:34:02.0027636+02:00",
      "AssociateFullName": "Daron Kassulke",
      "CreatedBy": "quaerat",
      "UpdatedBy": "impedit",
      "DeviceIdentifier": "alias",
      "ForeignAppId": 306,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 780
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 884
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```