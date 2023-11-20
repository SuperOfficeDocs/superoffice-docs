---
title: POST Agents/Ticket/SaveAttachmentEntity
uid: v1TicketAgent_SaveAttachmentEntity
generated: true
---

# POST Agents/Ticket/SaveAttachmentEntity

```http
POST /api/v1/Agents/Ticket/SaveAttachmentEntity
```

Updates the existing AttachmentEntity or creates a new AttachmentEntity if the id parameter is empty








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

The AttachmentEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | Integer | The primary key (auto-incremented) |
| Name | String | The filename for the attachment. |
| ContentType | String | The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;). |
| AttSize | Integer | The size (in bytes) for the attachment. |
| InlineImage | Boolean | True if this attachment is inlined in the html_body. |
| ContentId | String | The content_id of this attachment, used for inline images |
| AuthKey | String | The key used for authenticating access to this attachment. |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveAttachmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 33,
  "Name": "Brown, Lubowitz and Schneider",
  "ContentType": "fuga",
  "AttSize": 89,
  "InlineImage": true,
  "ContentId": "omnis",
  "AuthKey": "est"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 681,
  "Name": "Thompson, Jacobson and Kuhic",
  "ContentType": "eum",
  "AttSize": 8,
  "InlineImage": false,
  "ContentId": "ut",
  "AuthKey": "sapiente",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 74
    }
  }
}
```