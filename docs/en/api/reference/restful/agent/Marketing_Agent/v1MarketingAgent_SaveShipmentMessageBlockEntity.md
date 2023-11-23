---
title: POST Agents/Marketing/SaveShipmentMessageBlockEntity
uid: v1MarketingAgent_SaveShipmentMessageBlockEntity
generated: true
---

# POST Agents/Marketing/SaveShipmentMessageBlockEntity

```http
POST /api/v1/Agents/Marketing/SaveShipmentMessageBlockEntity
```

Updates the existing ShipmentMessageBlockEntity or creates a new ShipmentMessageBlockEntity if the id parameter is empty








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

The ShipmentMessageBlockEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageBlockId | Integer | Primary key |
| AssociateId | Integer | The associate that owns this block |
| Block | String | The block definition. Normally this will be a json structure |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |
| UpdatedCount | Integer | Number of updates made to this record |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ShipmentMessageBlockEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageBlockId | int32 | Primary key |
| AssociateId | int32 | The associate that owns this block |
| Block | string | The block definition. Normally this will be a json structure |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Marketing/SaveShipmentMessageBlockEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 9,
  "AssociateId": 367,
  "Block": "repellendus",
  "Registered": "2001-01-04T13:38:13.7333439+01:00",
  "RegisteredAssociateId": 815,
  "Updated": "2001-05-07T13:38:13.7333439+02:00",
  "UpdatedAssociateId": 368,
  "UpdatedCount": 303
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 670,
  "AssociateId": 99,
  "Block": "illum",
  "Registered": "2017-04-22T13:38:13.7333439+02:00",
  "RegisteredAssociateId": 390,
  "Updated": "2020-11-07T13:38:13.7333439+01:00",
  "UpdatedAssociateId": 344,
  "UpdatedCount": 603,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 440
    }
  }
}
```