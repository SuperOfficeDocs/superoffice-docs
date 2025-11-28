```http_
HTTP/1.1 200 ForeignAppEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 704,
  "Name": "Lowe Group",
  "CreatedDate": "2008-05-24T14:34:02.0027636+02:00",
  "UpdatedDate": "2014-07-22T14:34:02.0027636+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 364,
      "Name": "Google Sync",
      "CreatedDate": "2013-11-16T14:34:02.0027636+01:00",
      "UpdatedDate": "1998-10-02T14:34:02.0027636+02:00",
      "AssociateFullName": "Tanner Eichmann",
      "CreatedBy": "aliquid",
      "UpdatedBy": "aperiam",
      "DeviceIdentifier": "aut",
      "ForeignAppId": 736,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 610
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```