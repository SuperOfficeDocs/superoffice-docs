---
title: PUT ShipmentMessage/{id}
uid: v1ShipmentMessageEntity_PutShipmentMessageEntity
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


## Response: 

ShipmentMessageEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ShipmentMessageEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: 

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

## Sample request

```http!
PUT /api/v1/ShipmentMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 713,
  "PlainMessage": "quaerat",
  "HtmlMessage": "perspiciatis",
  "SmsMessage": "vel",
  "Description": "Customizable intermediate service-desk",
  "Subject": "sunt",
  "FolderId": 881,
  "HeaderField": "voluptatum",
  "Design": "quia",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": true,
  "InlineImages": true,
  "LongDescription": "Reverse-engineered fault-tolerant model",
  "AccessKey": "qui",
  "DocumentMessage": 599,
  "Registered": "2007-02-28T02:49:51.536309+01:00",
  "RegisteredAssociateId": 200,
  "Updated": "2021-07-29T02:49:51.536309+02:00",
  "UpdatedAssociateId": 392,
  "UpdatedCount": 380
}
```

## Sample response

```http_
HTTP/1.1 200 ShipmentMessageEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageId": 75,
  "PlainMessage": "ut",
  "HtmlMessage": "et",
  "SmsMessage": "et",
  "Description": "Reduced radical solution",
  "Subject": "libero",
  "FolderId": 392,
  "HeaderField": "voluptas",
  "Design": "culpa",
  "Designtype": "SOEditor",
  "Flags": "Document",
  "RegisterViews": false,
  "InlineImages": false,
  "LongDescription": "Centralized empowering functionalities",
  "AccessKey": "ea",
  "DocumentMessage": 487,
  "Registered": "2002-08-14T02:49:51.536309+02:00",
  "RegisteredAssociateId": 674,
  "Updated": "2007-09-17T02:49:51.536309+02:00",
  "UpdatedAssociateId": 703,
  "UpdatedCount": 473,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 451
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```