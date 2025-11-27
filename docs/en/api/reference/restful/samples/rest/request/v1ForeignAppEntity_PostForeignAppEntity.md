```http!
POST /api/v1/ForeignApp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 88,
  "Name": "Kautzer Group",
  "CreatedDate": "1999-01-06T14:35:43.7616537+01:00",
  "UpdatedDate": "2015-04-12T14:35:43.7616537+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 743,
      "Name": "Herman Inc and Sons",
      "CreatedDate": "1999-12-24T14:35:43.7626527+01:00",
      "UpdatedDate": "2010-12-29T14:35:43.7626527+01:00",
      "AssociateFullName": "Nina Jakubowski",
      "CreatedBy": "aperiam",
      "UpdatedBy": "fugiat",
      "DeviceIdentifier": "nobis",
      "ForeignAppId": 498
    }
  ]
}
```