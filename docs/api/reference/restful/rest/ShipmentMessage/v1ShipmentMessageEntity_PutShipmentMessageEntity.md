---
title: PUT ShipmentMessage/{id}
id: v1ShipmentMessageEntity_PutShipmentMessageEntity
---

# PUT ShipmentMessage/{id}

```http
PUT /api/v1/ShipmentMessage/{id}
```

Updates the existing ShipmentMessageEntity

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ShipmentMessageEntity id to update. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ShipmentMessage/{id}?$select=name,department,category/id
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

The ShipmentMessageEntity to be saved.

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageId | int32 | Primary key |
| PlainMessage | string | Plain message text of this message |
| HtmlMessage | string | HTML formatted text of this message |
| SmsMessage | string | SMS version of this message |
| Description | string | Describes this message |
| Subject | string | The mail subject field of the message |
| FolderId | int32 | The folder which this message belongs to. -1 indicates that the message is on the root |
| HeaderField | string | Extra header fields added to mail. Must be formatted correctly |
| Design | string | Will contain the design part of a message. The format will vary based on the type of designer used to create the message |
| Designtype | string | Enum containing the type of the design |
| Flags | string | Identifies if HTML or plain message is included in message. |
| RegisterViews | bool | Register message views? |
| InlineImages | bool | Should images be included inline? |
| LongDescription | string | A field for a long description of this template |
| AccessKey | string | Key used for access verification |
| DocumentMessage | int32 | The SM document used as template for this mailing |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |

## Response: object

A shipment message, that contains the actual message being sent out in a mailing

ShipmentMessageEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ShipmentMessageEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageId | int32 | Primary key |
| PlainMessage | string | Plain message text of this message |
| HtmlMessage | string | HTML formatted text of this message |
| SmsMessage | string | SMS version of this message |
| Description | string | Describes this message |
| Subject | string | The mail subject field of the message |
| FolderId | int32 | The folder which this message belongs to. -1 indicates that the message is on the root |
| HeaderField | string | Extra header fields added to mail. Must be formatted correctly |
| Design | string | Will contain the design part of a message. The format will vary based on the type of designer used to create the message |
| Designtype | string | Enum containing the type of the design |
| Flags | string | Identifies if HTML or plain message is included in message. |
| RegisterViews | bool | Register message views? |
| InlineImages | bool | Should images be included inline? |
| LongDescription | string | A field for a long description of this template |
| AccessKey | string | Key used for access verification |
| DocumentMessage | int32 | The SM document used as template for this mailing |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/ShipmentMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 256,
  "PlainMessage": "est",
  "HtmlMessage": "excepturi",
  "SmsMessage": "et",
  "Description": "Focused client-server product",
  "Subject": "nihil",
  "FolderId": 926,
  "HeaderField": "et",
  "Design": "consequuntur",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": true,
  "LongDescription": "Expanded mission-critical encryption",
  "AccessKey": "rerum",
  "DocumentMessage": 562,
  "Registered": "2018-05-31T18:25:51.1129096+02:00",
  "RegisteredAssociateId": 748,
  "Updated": "1996-04-15T18:25:51.1129096+02:00",
  "UpdatedAssociateId": 756,
  "UpdatedCount": 519
}
```

```http_
HTTP/1.1 200 ShipmentMessageEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 489,
  "PlainMessage": "odio",
  "HtmlMessage": "rerum",
  "SmsMessage": "sint",
  "Description": "Synchronised attitude-oriented moderator",
  "Subject": "et",
  "FolderId": 708,
  "HeaderField": "eos",
  "Design": "aliquid",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": true,
  "InlineImages": false,
  "LongDescription": "Face to face zero administration customer loyalty",
  "AccessKey": "a",
  "DocumentMessage": 711,
  "Registered": "1999-01-15T18:25:51.1149499+01:00",
  "RegisteredAssociateId": 374,
  "Updated": "1998-07-13T18:25:51.1149499+02:00",
  "UpdatedAssociateId": 149,
  "UpdatedCount": 587,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 633
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
