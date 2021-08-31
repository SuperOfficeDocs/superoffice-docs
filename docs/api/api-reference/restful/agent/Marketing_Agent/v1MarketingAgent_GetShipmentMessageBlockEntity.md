---
title: GetShipmentMessageBlockEntity
id: v1MarketingAgent_GetShipmentMessageBlockEntity
---

# GetShipmentMessageBlockEntity

```http
POST /api/v1/Agents/Marketing/GetShipmentMessageBlockEntity
```

Gets a ShipmentMessageBlockEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| shipmentMessageBlockEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Marketing/GetShipmentMessageBlockEntity?shipmentMessageBlockEntityId=427
POST /api/v1/Agents/Marketing/GetShipmentMessageBlockEntity?$select=name,department,category/id
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


## Response: object

This entity contains information about design blocks that can be used in a shipment/mailing message



Carrier object for ShipmentMessageBlockEntity.
Services for the ShipmentMessageBlockEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IMarketingAgent">Marketing Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Marketing/GetShipmentMessageBlockEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 270,
  "AssociateId": 903,
  "Block": "dignissimos",
  "Registered": "2016-01-15T14:58:04.4994654+01:00",
  "RegisteredAssociateId": 760,
  "Updated": "2005-05-15T14:58:04.4994654+02:00",
  "UpdatedAssociateId": 862,
  "UpdatedCount": 483,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "drive cutting-edge infrastructures"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 511
    }
  }
}
```