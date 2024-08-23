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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 904,
  "Name": "Lindgren, Prohaska and Tromp",
  "CreatedDate": "2023-09-13T13:28:22.8354083+02:00",
  "UpdatedDate": "2024-06-29T13:28:22.8354083+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 405,
      "Name": "Ritchie, Frami and Mitchell",
      "CreatedDate": "2003-05-21T13:28:22.8354083+02:00",
      "UpdatedDate": "2023-07-15T13:28:22.8354083+02:00",
      "AssociateFullName": "Ibrahim Emil Boehm PhD",
      "CreatedBy": "labore",
      "UpdatedBy": "fugit",
      "DeviceIdentifier": "repellendus",
      "ForeignAppId": 214
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 214,
  "Name": "Hand-Marks",
  "CreatedDate": "2014-06-08T13:28:22.8354083+02:00",
  "UpdatedDate": "2023-04-04T13:28:22.8354083+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 637,
      "Name": "Collier-Goldner",
      "CreatedDate": "2011-03-03T13:28:22.8354083+01:00",
      "UpdatedDate": "2012-08-12T13:28:22.8354083+02:00",
      "AssociateFullName": "Dr. Hector Towne Sr.",
      "CreatedBy": "similique",
      "UpdatedBy": "culpa",
      "DeviceIdentifier": "sunt",
      "ForeignAppId": 697,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 775
    }
  }
}
```