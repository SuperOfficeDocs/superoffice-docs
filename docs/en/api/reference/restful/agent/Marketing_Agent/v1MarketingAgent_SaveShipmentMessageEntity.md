---
title: POST Agents/Marketing/SaveShipmentMessageEntity
uid: v1MarketingAgent_SaveShipmentMessageEntity
generated: true
---

# POST Agents/Marketing/SaveShipmentMessageEntity

```http
POST /api/v1/Agents/Marketing/SaveShipmentMessageEntity
```

Updates the existing ShipmentMessageEntity or creates a new ShipmentMessageEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ShipmentMessageEntity

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

## Sample request

```http!
POST /api/v1/Agents/Marketing/SaveShipmentMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 443,
  "PlainMessage": "sed",
  "HtmlMessage": "nulla",
  "SmsMessage": "eius",
  "Description": "Robust bottom-line hardware",
  "Subject": "omnis",
  "FolderId": 596,
  "HeaderField": "et",
  "Design": "consectetur",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": true,
  "LongDescription": "Organized intermediate focus group",
  "AccessKey": "saepe",
  "DocumentMessage": 307,
  "Registered": "2001-03-19T13:38:13.7333439+01:00",
  "RegisteredAssociateId": 372,
  "Updated": "1998-02-28T13:38:13.7333439+01:00",
  "UpdatedAssociateId": 515,
  "UpdatedCount": 285
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 692,
  "PlainMessage": "pariatur",
  "HtmlMessage": "qui",
  "SmsMessage": "ab",
  "Description": "Triple-buffered multi-state challenge",
  "Subject": "qui",
  "FolderId": 930,
  "HeaderField": "qui",
  "Design": "possimus",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": false,
  "LongDescription": "Operative coherent solution",
  "AccessKey": "culpa",
  "DocumentMessage": 609,
  "Registered": "2010-10-11T13:38:13.7333439+02:00",
  "RegisteredAssociateId": 427,
  "Updated": "2003-09-19T13:38:13.7333439+02:00",
  "UpdatedAssociateId": 214,
  "UpdatedCount": 792,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 797
    }
  }
}
```