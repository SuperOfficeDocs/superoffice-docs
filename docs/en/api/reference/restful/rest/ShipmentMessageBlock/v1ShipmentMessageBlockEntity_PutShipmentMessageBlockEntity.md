---
title: PUT ShipmentMessageBlock/{id}
uid: v1ShipmentMessageBlockEntity_PutShipmentMessageBlockEntity
generated: true
content_type: reference
---

# PUT ShipmentMessageBlock/{id}

```http
PUT /api/v1/ShipmentMessageBlock/{id}
```

Updates the existing ShipmentMessageBlockEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ShipmentMessageBlockEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ShipmentMessageBlock/{id}?$select=name,department,category/id
```


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

ShipmentMessageBlockEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ShipmentMessageBlockEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/ShipmentMessageBlock/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 861,
  "AssociateId": 482,
  "Block": "dignissimos",
  "Registered": "2006-09-28T03:41:59.0273773+02:00",
  "RegisteredAssociateId": 587,
  "Updated": "2016-09-24T03:41:59.0273773+02:00",
  "UpdatedAssociateId": 183,
  "UpdatedCount": 226
}
```

## Sample response

```http_
HTTP/1.1 200 ShipmentMessageBlockEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 896,
  "AssociateId": 764,
  "Block": "placeat",
  "Registered": "2014-02-06T03:41:59.0273773+01:00",
  "RegisteredAssociateId": 54,
  "Updated": "2000-05-23T03:41:59.0273773+02:00",
  "UpdatedAssociateId": 901,
  "UpdatedCount": 714,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 917
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```