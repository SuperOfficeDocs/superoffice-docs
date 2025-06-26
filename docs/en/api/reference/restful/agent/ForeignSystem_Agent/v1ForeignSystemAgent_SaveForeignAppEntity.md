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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 965,
  "Name": "Dooley-Walker",
  "CreatedDate": "2021-07-10T03:45:23.4829546+02:00",
  "UpdatedDate": "2009-08-15T03:45:23.4829546+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 204,
      "Name": "Mosciski, Abshire and Mayer",
      "CreatedDate": "2011-12-02T03:45:23.4829546+01:00",
      "UpdatedDate": "2010-07-20T03:45:23.4829546+02:00",
      "AssociateFullName": "Meda Littel DDS",
      "CreatedBy": "consectetur",
      "UpdatedBy": "velit",
      "DeviceIdentifier": "ad",
      "ForeignAppId": 663
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 374,
  "Name": "Bartell Inc and Sons",
  "CreatedDate": "1999-09-28T03:45:23.4829546+02:00",
  "UpdatedDate": "2016-02-27T03:45:23.4829546+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 305,
      "Name": "Koepp, Casper and Considine",
      "CreatedDate": "2018-11-16T03:45:23.4829546+01:00",
      "UpdatedDate": "2023-01-18T03:45:23.4829546+01:00",
      "AssociateFullName": "Dr. Dorothea O'Reilly IV",
      "CreatedBy": "est",
      "UpdatedBy": "labore",
      "DeviceIdentifier": "id",
      "ForeignAppId": 43,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 498
    }
  }
}
```