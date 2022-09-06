---
title: POST ForeignApp/{appName}
uid: v1ForeignAppEntity_PostForeignApp
---

# POST ForeignApp/{appName}

```http
POST /api/v1/ForeignApp/{appName}
```

Creates a new ForeignApp

Calls the ForeignSystem agent service SaveForeignAppEntity.

| Path Part | Type | Description |
|-----------|------|-------------|
| appName | string | The ForeignApp to be saved. **Required** |

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
POST /api/v1/ForeignApp/{appName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 690,
  "Name": "Torphy, Thompson and Bednar",
  "CreatedDate": "1999-06-10T11:10:52.8801753+02:00",
  "UpdatedDate": "2021-07-06T11:10:52.8801753+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 317,
      "Name": "Oberbrunner-Stracke",
      "CreatedDate": "2005-07-15T11:10:52.881174+02:00",
      "UpdatedDate": "2013-08-26T11:10:52.881174+02:00",
      "AssociateFullName": "Sienna Watsica",
      "CreatedBy": "saepe",
      "UpdatedBy": "consectetur",
      "DeviceIdentifier": "atque",
      "ForeignAppId": 737,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 973
    }
  }
}
```
