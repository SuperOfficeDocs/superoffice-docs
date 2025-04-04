---
title: POST Agents/Ticket/GetAttachmentPreview
uid: v1TicketAgent_GetAttachmentPreview
generated: true
---

# POST Agents/Ticket/GetAttachmentPreview

```http
POST /api/v1/Agents/Ticket/GetAttachmentPreview
```

Retrieve an attachment from ticket message.


The returned data is intended to be used for a preview. The returned data is sanitized.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetAttachmentPreview?$select=name,department,category/id
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

AttachmentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AttachmentPreview

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Name of the attachment file |
| MimeType | string | The mimetype of the attachment |
| Size | int32 | Size of the attachment in bytes |
| Content | byte | Attachment data |
| EmailSubject | string | Subject of the attached RFC822 email. Null for non-RFC822 attachment |
| EmailFrom | string | From field of the attached RFC822 email. Null for non-RFC822 attachment |
| EmailTo | string | To field of the attached RFC822 email. Null for non-RFC822 attachment |
| EmailCc | string | Cc field of the attached RFC822 email. Null for non-RFC822 attachment |
| EmailDate | date-time | Date of the attached RFC822 email. Default DateTime value for non-RFC822 attachment |
| EmailAttachmentsInfo | array | The attachments inside the attached RFC822 email. Empty array for non-RFC822 attachment |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetAttachmentPreview
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 173
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Name": "Wisoky, Reynolds and Romaguera",
  "MimeType": "voluptas",
  "Size": 970,
  "Content": "GIF89....File contents as raw bytes...",
  "EmailSubject": "dallas.steuber@witting.info",
  "EmailFrom": "kyla_rogahn@kovacek.com",
  "EmailTo": "murphy@hintzthompson.biz",
  "EmailCc": "angie@mcglynn.com",
  "EmailDate": "2006-05-09T13:14:01.6131905+02:00",
  "EmailAttachmentsInfo": [
    {
      "AttachmentId": 641,
      "Name": "Auer Inc and Sons",
      "ContentType": "quia",
      "AttSize": 256,
      "InlineImage": false,
      "ContentId": "vel",
      "AuthKey": "quibusdam",
      "IsSafeFileExtension": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 901
    }
  }
}
```