```http_
HTTP/1.1 200 ForeignAppEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 15 Mar 2017 14:34:01 G3T

{
  "ForeignAppId": 686,
  "Name": "Renner Inc and Sons",
  "CreatedDate": "2024-02-22T14:34:01.9870942+01:00",
  "UpdatedDate": "2017-03-15T14:34:01.9870942+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 878,
      "Name": "Weimann Inc and Sons",
      "CreatedDate": "2007-03-19T14:34:01.9870942+01:00",
      "UpdatedDate": "1999-03-28T14:34:01.9870942+02:00",
      "AssociateFullName": "Reggie Kunde",
      "CreatedBy": "occaecati",
      "UpdatedBy": "rem",
      "DeviceIdentifier": "maiores",
      "ForeignAppId": 29,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 32
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```