---
title: POST Agents/Ticket/GetDefaultMessageContentWithOptions
uid: v1TicketAgent_GetDefaultMessageContentWithOptions
generated: true
---

# POST Agents/Ticket/GetDefaultMessageContentWithOptions

```http
POST /api/v1/Agents/Ticket/GetDefaultMessageContentWithOptions
```

Generate a default message content with option to exclude signature: attachments and body as sanitized HTML







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetDefaultMessageContentWithOptions?$select=name,department,category/id
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

## Request Body: request 

TicketId, MessageActionType, TicketMessageId, TicketTypeId, ExcludeSignature 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |
| MessageActionType | String |  |
| TicketMessageId | Integer |  |
| TicketTypeId | Integer |  |
| ExcludeSignature | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketMessageContent

| Property Name | Type |  Description |
|----------------|------|--------------|
| Body | string | Body (including default editor content, content from template, user signature, quoted message content) as sanitized HTML |
| AttachmentsInfo | array | Message attachments information |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetDefaultMessageContentWithOptions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 309,
  "MessageActionType": "Forward",
  "TicketMessageId": 799,
  "TicketTypeId": 850,
  "ExcludeSignature": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Body": "consequuntur",
  "AttachmentsInfo": [
    {
      "AttachmentId": 153,
      "Name": "Yost Group",
      "ContentType": "aut",
      "AttSize": 285,
      "InlineImage": true,
      "ContentId": "cupiditate",
      "AuthKey": "perspiciatis",
      "IsSafeFileExtension": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ]
}
```