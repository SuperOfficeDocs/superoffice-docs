---
title: POST Agents/Marketing/SaveShipmentMessageEntity
uid: v1MarketingAgent_SaveShipmentMessageEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Marketing/SaveShipmentMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 914,
  "PlainMessage": "a",
  "HtmlMessage": "perferendis",
  "SmsMessage": "omnis",
  "Description": "Multi-lateral actuating framework",
  "Subject": "rerum",
  "FolderId": 53,
  "HeaderField": "laudantium",
  "Design": "voluptate",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": false,
  "LongDescription": "User-friendly optimizing policy",
  "AccessKey": "debitis",
  "DocumentMessage": 883,
  "Registered": "1996-09-13T17:37:18.3192412+02:00",
  "RegisteredAssociateId": 472,
  "Updated": "1999-01-27T17:37:18.3192412+01:00",
  "UpdatedAssociateId": 190,
  "UpdatedCount": 882
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 477,
  "PlainMessage": "similique",
  "HtmlMessage": "et",
  "SmsMessage": "quia",
  "Description": "Profit-focused 24/7 software",
  "Subject": "voluptatem",
  "FolderId": 970,
  "HeaderField": "eveniet",
  "Design": "minima",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": false,
  "LongDescription": "Managed zero tolerance superstructure",
  "AccessKey": "magni",
  "DocumentMessage": 557,
  "Registered": "1999-11-24T17:37:18.3202415+01:00",
  "RegisteredAssociateId": 878,
  "Updated": "2019-08-06T17:37:18.3202415+02:00",
  "UpdatedAssociateId": 494,
  "UpdatedCount": 690,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 136
    }
  }
}
```