---
title: PUT ShipmentMessage/{id}
uid: v1ShipmentMessageEntity_PutShipmentMessageEntity
generated: true
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
| ShipmentMessageId | Integer | Primary key |
| PlainMessage | String | Plain message text of this message |
| HtmlMessage | String | HTML formatted text of this message |
| SmsMessage | String | SMS version of this message |
| Description | String | Describes this message |
| Subject | String | The mail subject field of the message |
| FolderId | Integer | The folder which this message belongs to. -1 indicates that the message is on the root |
| HeaderField | String | Extra header fields added to mail. Must be formatted correctly |
| Design | String | Will contain the design part of a message. The format will vary based on the type of designer used to create the message |
| Designtype | String | Enum containing the type of the design |
| Flags | String | Identifies if HTML or plain message is included in message. |
| RegisterViews | Boolean | Register message views? |
| InlineImages | Boolean | Should images be included inline? |
| LongDescription | String | A field for a long description of this template |
| AccessKey | String | Key used for access verification |
| DocumentMessage | Integer | The SM document used as template for this mailing |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |
| UpdatedCount | Integer | Number of updates made to this record |

## Response:

ShipmentMessageEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ShipmentMessageEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ShipmentMessageEntityWithLinks

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/ShipmentMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 628,
  "PlainMessage": "dolorem",
  "HtmlMessage": "sint",
  "SmsMessage": "et",
  "Description": "Stand-alone didactic solution",
  "Subject": "deserunt",
  "FolderId": 727,
  "HeaderField": "voluptatum",
  "Design": "qui",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": false,
  "LongDescription": "Distributed 24/7 archive",
  "AccessKey": "ipsa",
  "DocumentMessage": 955,
  "Registered": "1999-06-02T13:38:17.6711737+02:00",
  "RegisteredAssociateId": 211,
  "Updated": "2013-05-17T13:38:17.6711737+02:00",
  "UpdatedAssociateId": 695,
  "UpdatedCount": 796
}
```

## Sample response

```http_
HTTP/1.1 200 ShipmentMessageEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 729,
  "PlainMessage": "facere",
  "HtmlMessage": "suscipit",
  "SmsMessage": "hic",
  "Description": "Sharable uniform capability",
  "Subject": "ea",
  "FolderId": 837,
  "HeaderField": "qui",
  "Design": "voluptas",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": true,
  "LongDescription": "Down-sized bottom-line architecture",
  "AccessKey": "sunt",
  "DocumentMessage": 915,
  "Registered": "2010-10-02T13:38:17.6711737+02:00",
  "RegisteredAssociateId": 790,
  "Updated": "2012-12-21T13:38:17.6711737+01:00",
  "UpdatedAssociateId": 528,
  "UpdatedCount": 530,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 782
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```