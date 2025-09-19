---
title: POST Agents/ForeignSystem/CreateDefaultForeignAppEntity
uid: v1ForeignSystemAgent_CreateDefaultForeignAppEntity
generated: true
content_type: reference
---

# POST Agents/ForeignSystem/CreateDefaultForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/CreateDefaultForeignAppEntity
```

Loading default values into a new ForeignAppEntity.








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
POST /api/v1/Agents/ForeignSystem/CreateDefaultForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 832,
  "Name": "Emard, Lubowitz and Mosciski",
  "CreatedDate": "2008-10-30T03:41:53.5744803+01:00",
  "UpdatedDate": "2011-04-03T03:41:53.5744803+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 906,
      "Name": "O'Conner-Littel",
      "CreatedDate": "2001-11-17T03:41:53.5744803+01:00",
      "UpdatedDate": "2002-04-09T03:41:53.5744803+02:00",
      "AssociateFullName": "Pietro Jewess",
      "CreatedBy": "soluta",
      "UpdatedBy": "beatae",
      "DeviceIdentifier": "et",
      "ForeignAppId": 427,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 381
    }
  }
}
```