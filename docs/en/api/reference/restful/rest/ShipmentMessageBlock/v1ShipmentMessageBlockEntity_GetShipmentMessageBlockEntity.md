---
title: GET ShipmentMessageBlock/{id}
uid: v1ShipmentMessageBlockEntity_GetShipmentMessageBlockEntity
---

# GET ShipmentMessageBlock/{id}

```http
GET /api/v1/ShipmentMessageBlock/{id}
```

Gets a ShipmentMessageBlockEntity object.


Calls the Marketing agent service GetShipmentMessageBlockEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ShipmentMessageBlockEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/ShipmentMessageBlock/{id}?$select=name,department,category/id
```


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

ShipmentMessageBlockEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ShipmentMessageBlockEntity found. |
| 404 | Not Found. |

### Response body: ShipmentMessageBlockEntityWithLinks

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/ShipmentMessageBlock/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ShipmentMessageBlockEntity found.
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 594,
  "AssociateId": 802,
  "Block": "commodi",
  "Registered": "2004-12-07T14:19:10.7873511+01:00",
  "RegisteredAssociateId": 153,
  "Updated": "2002-11-24T14:19:10.7873511+01:00",
  "UpdatedAssociateId": 71,
  "UpdatedCount": 957,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 29
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```