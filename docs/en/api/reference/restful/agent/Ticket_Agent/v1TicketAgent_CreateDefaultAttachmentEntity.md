---
title: POST Agents/Ticket/CreateDefaultAttachmentEntity
uid: v1TicketAgent_CreateDefaultAttachmentEntity
generated: true
---

# POST Agents/Ticket/CreateDefaultAttachmentEntity

```http
POST /api/v1/Agents/Ticket/CreateDefaultAttachmentEntity
```

Set default values into a new AttachmentEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Ticket/CreateDefaultAttachmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 677,
  "Name": "Farrell LLC",
  "ContentType": "totam",
  "AttSize": 794,
  "InlineImage": false,
  "ContentId": "id",
  "AuthKey": "magni",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 525
    }
  }
}
```