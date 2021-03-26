---
title: POST Agents/Marketing/SaveShipmentMessageEntity
id: v1MarketingAgent_SaveShipmentMessageEntity
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



Carrier object for ShipmentMessageEntity.
Services for the ShipmentMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IMarketingAgent">Marketing Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
POST /api/v1/Agents/Marketing/SaveShipmentMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 206,
  "PlainMessage": "dignissimos",
  "HtmlMessage": "officiis",
  "SmsMessage": "itaque",
  "Description": "Customizable neutral success",
  "Subject": "similique",
  "FolderId": 266,
  "HeaderField": "aut",
  "Design": "vel",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": true,
  "LongDescription": "Ergonomic user-facing core",
  "AccessKey": "suscipit",
  "DocumentMessage": 202,
  "Registered": "1998-03-20T16:48:29.9549322+01:00",
  "RegisteredAssociateId": 865,
  "Updated": "2009-10-31T16:48:29.9549322+01:00",
  "UpdatedAssociateId": 641,
  "UpdatedCount": 3
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 808,
  "PlainMessage": "quam",
  "HtmlMessage": "ab",
  "SmsMessage": "distinctio",
  "Description": "Down-sized leading edge core",
  "Subject": "rerum",
  "FolderId": 856,
  "HeaderField": "velit",
  "Design": "mollitia",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": true,
  "LongDescription": "User-centric static function",
  "AccessKey": "maxime",
  "DocumentMessage": 464,
  "Registered": "2012-12-30T16:48:29.9549322+01:00",
  "RegisteredAssociateId": 468,
  "Updated": "2003-04-11T16:48:29.9549322+02:00",
  "UpdatedAssociateId": 638,
  "UpdatedCount": 656,
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
      "FieldType": "System.String",
      "FieldLength": 246
    }
  }
}
```