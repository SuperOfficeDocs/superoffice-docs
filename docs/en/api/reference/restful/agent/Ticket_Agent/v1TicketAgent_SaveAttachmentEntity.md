---
title: POST Agents/Ticket/SaveAttachmentEntity
uid: v1TicketAgent_SaveAttachmentEntity
generated: true
content_type: reference
---

# POST Agents/Ticket/SaveAttachmentEntity

```http
POST /api/v1/Agents/Ticket/SaveAttachmentEntity
```

Updates the existing AttachmentEntity or creates a new AttachmentEntity if the id parameter is 0.








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

## Request Body: attachmentEntity 

The AttachmentEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | Integer | The primary key (auto-incremented) |
| Name | String | The filename for the attachment. |
| ContentType | String | The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;). |
| AttSize | Integer | The size (in bytes) for the attachment. |
| InlineImage | Boolean | True if this attachment is inlined in the html_body. |
| ContentId | String | The content_id of this attachment, used for inline images |
| AuthKey | String | The key used for authenticating access to this attachment. |
| IsSafeFileExtension | Boolean | Is file considered to be safe (based on extension and settings) |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AttachmentEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | int32 | The primary key (auto-incremented) |
| Name | string | The filename for the attachment. |
| ContentType | string | The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;). |
| AttSize | int32 | The size (in bytes) for the attachment. |
| InlineImage | bool | True if this attachment is inlined in the html_body. |
| ContentId | string | The content_id of this attachment, used for inline images |
| AuthKey | string | The key used for authenticating access to this attachment. |
| IsSafeFileExtension | bool | Is file considered to be safe (based on extension and settings) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveAttachmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 317,
  "Name": "Shanahan-Pacocha",
  "ContentType": "velit",
  "AttSize": 579,
  "InlineImage": true,
  "ContentId": "aut",
  "AuthKey": "aut",
  "IsSafeFileExtension": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 256,
  "Name": "Quigley Inc and Sons",
  "ContentType": "odio",
  "AttSize": 698,
  "InlineImage": false,
  "ContentId": "rerum",
  "AuthKey": "magnam",
  "IsSafeFileExtension": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 691
    }
  }
}
```