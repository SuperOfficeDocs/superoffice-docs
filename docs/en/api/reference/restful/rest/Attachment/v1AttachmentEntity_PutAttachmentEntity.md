---
title: PUT Attachment/{id}
uid: v1AttachmentEntity_PutAttachmentEntity
---

# PUT Attachment/{id}

```http
PUT /api/v1/Attachment/{id}
```

Updates the existing AttachmentEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The AttachmentEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Attachment/{id}?$select=name,department,category/id
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

The AttachmentEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | Integer | The primary key (auto-incremented) |
| Name | String | The filename for the attachment. |
| ContentType | String | The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;). |
| AttSize | Integer | The size (in bytes) for the attachment. |
| InlineImage | Boolean | True if this attachment is inlined in the html_body. |
| ContentId | String | The content_id of this attachment, used for inline images |

## Response:

AttachmentEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | AttachmentEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: AttachmentEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | int32 | The primary key (auto-incremented) |
| Name | string | The filename for the attachment. |
| ContentType | string | The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;). |
| AttSize | int32 | The size (in bytes) for the attachment. |
| InlineImage | bool | True if this attachment is inlined in the html_body. |
| ContentId | string | The content_id of this attachment, used for inline images |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Attachment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 470,
  "Name": "Larkin, Hand and Blanda",
  "ContentType": "dicta",
  "AttSize": 771,
  "InlineImage": false,
  "ContentId": "consectetur"
}
```

## Sample response

```http_
HTTP/1.1 200 AttachmentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 20,
  "Name": "Bailey Group",
  "ContentType": "at",
  "AttSize": 770,
  "InlineImage": false,
  "ContentId": "mollitia",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 220
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```