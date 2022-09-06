---
title: GET ForeignApp/default
uid: v1ForeignAppEntity_DefaultForeignAppEntity
---

# GET ForeignApp/default

```http
GET /api/v1/ForeignApp/default
```

Set default values into a new ForeignAppEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the ForeignSystem agent service CreateDefaultForeignAppEntity.

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/ForeignApp/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 09 Apr 1997 11:10:52 G4T

{
  "ForeignAppId": 756,
  "Name": "Waters LLC",
  "CreatedDate": "1995-05-07T11:10:52.8831799+02:00",
  "UpdatedDate": "1997-04-09T11:10:52.8831799+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 911,
      "Name": "Glover, Mosciski and Schroeder",
      "CreatedDate": "2017-11-28T11:10:52.8841739+01:00",
      "UpdatedDate": "2020-05-04T11:10:52.8841739+02:00",
      "AssociateFullName": "Monique Harris",
      "CreatedBy": "adipisci",
      "UpdatedBy": "pariatur",
      "DeviceIdentifier": "quos",
      "ForeignAppId": 264,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 383
    }
  }
}
```
