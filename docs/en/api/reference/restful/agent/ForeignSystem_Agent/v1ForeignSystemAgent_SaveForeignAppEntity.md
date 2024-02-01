---
title: POST Agents/ForeignSystem/SaveForeignAppEntity
uid: v1ForeignSystemAgent_SaveForeignAppEntity
generated: true
---

# POST Agents/ForeignSystem/SaveForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
```

Updates the existing ForeignAppEntity or creates a new ForeignAppEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The ForeignAppEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | Integer | Primary key |
| Name | String | Name of foreign application |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the foreign application. |
| UpdatedBy | Associate | The person that last updated this foreign application. |
| Devices | Array | The devices that belong to this foreign app. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignAppEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the foreign application. |
| UpdatedBy | Associate | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 356,
  "Name": "Becker-Hermann",
  "CreatedDate": "2015-05-22T23:03:56.0986272+02:00",
  "UpdatedDate": "2005-12-07T23:03:56.0986272+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 921,
      "Name": "Doyle, Kling and Quitzon",
      "CreatedDate": "2018-01-28T23:03:56.0996296+01:00",
      "UpdatedDate": "2005-11-05T23:03:56.0996296+01:00",
      "AssociateFullName": "Ms. Angelita Nickolas Glover Sr.",
      "CreatedBy": "voluptatem",
      "UpdatedBy": "eaque",
      "DeviceIdentifier": "et",
      "ForeignAppId": 267
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 958,
  "Name": "Bogisich, Lesch and Cronin",
  "CreatedDate": "2000-05-23T23:03:56.1021275+02:00",
  "UpdatedDate": "2003-05-05T23:03:56.1021275+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 350,
      "Name": "Nikolaus, DuBuque and Lebsack",
      "CreatedDate": "2021-08-18T23:03:56.1026273+02:00",
      "UpdatedDate": "1997-08-22T23:03:56.1026273+02:00",
      "AssociateFullName": "Dr. Lyric Haley Sr.",
      "CreatedBy": "nulla",
      "UpdatedBy": "consectetur",
      "DeviceIdentifier": "quaerat",
      "ForeignAppId": 583,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 512
    }
  }
}
```