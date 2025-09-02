---
title: POST ShipmentMessage
uid: v1ShipmentMessageEntity_PostShipmentMessageEntity
generated: true
content_type: reference
---

# POST ShipmentMessage

```http
POST /api/v1/ShipmentMessage
```

Creates a new ShipmentMessageEntity


Calls the Marketing agent service SaveShipmentMessageEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ShipmentMessage?$select=name,department,category/id
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

## Request Body: newEntity 

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
POST /api/v1/ShipmentMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 486,
  "PlainMessage": "cumque",
  "HtmlMessage": "fugit",
  "SmsMessage": "a",
  "Description": "Managed methodical toolset",
  "Subject": "occaecati",
  "FolderId": 592,
  "HeaderField": "excepturi",
  "Design": "culpa",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": true,
  "InlineImages": false,
  "LongDescription": "Centralized real-time encoding",
  "AccessKey": "facere",
  "DocumentMessage": 651,
  "Registered": "2007-01-18T03:47:00.3005605+01:00",
  "RegisteredAssociateId": 133,
  "Updated": "2013-11-17T03:47:00.3005605+01:00",
  "UpdatedAssociateId": 626,
  "UpdatedCount": 454
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 599,
  "PlainMessage": "asperiores",
  "HtmlMessage": "esse",
  "SmsMessage": "sequi",
  "Description": "Fully-configurable bifurcated open system",
  "Subject": "ex",
  "FolderId": 273,
  "HeaderField": "et",
  "Design": "rerum",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": false,
  "LongDescription": "Front-line systemic matrices",
  "AccessKey": "voluptatem",
  "DocumentMessage": 519,
  "Registered": "2020-01-08T03:47:00.3005605+01:00",
  "RegisteredAssociateId": 659,
  "Updated": "2010-01-16T03:47:00.3005605+01:00",
  "UpdatedAssociateId": 902,
  "UpdatedCount": 253,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 672
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```