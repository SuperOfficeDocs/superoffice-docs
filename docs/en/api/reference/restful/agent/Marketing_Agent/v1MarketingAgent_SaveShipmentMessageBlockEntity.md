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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 275,
  "AssociateId": 285,
  "Block": "soluta",
  "Registered": "2003-10-22T03:45:23.6235756+02:00",
  "RegisteredAssociateId": 752,
  "Updated": "2013-08-04T03:45:23.6235756+02:00",
  "UpdatedAssociateId": 418,
  "UpdatedCount": 782
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 325,
  "AssociateId": 931,
  "Block": "veniam",
  "Registered": "2017-10-11T03:45:23.6235756+02:00",
  "RegisteredAssociateId": 115,
  "Updated": "2013-07-21T03:45:23.6235756+02:00",
  "UpdatedAssociateId": 365,
  "UpdatedCount": 907,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 528
    }
  }
}
```