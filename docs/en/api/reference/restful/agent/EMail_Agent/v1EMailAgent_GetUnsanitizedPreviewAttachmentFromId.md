---
title: POST Agents/EMail/GetUnsanitizedPreviewAttachmentFromId
uid: v1EMailAgent_GetUnsanitizedPreviewAttachmentFromId
generated: true
---

# POST Agents/EMail/GetUnsanitizedPreviewAttachmentFromId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedPreviewAttachmentFromId
```

Retrieve an attachment from an e-mail.


The returned data is intended to be use for a preview. The returned data is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedPreviewAttachmentFromId?$select=name,department,category/id
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

MailItemId, AttachmentId, AttachmentType, AttachmentFilename 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailItemId | Integer |  |
| AttachmentId | String |  |
| AttachmentType | String |  |
| AttachmentFilename | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailAttachment

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | string | Name/description |
| Filename | string | Filename |
| Size | int32 | Size of attachment |
| Type | string | Attachment Content-Type |
| Encoding | string | Content-Transfer-Encoding |
| Id | string | Content-ID |
| Disposition | string | Content-Disposition |
| IsSafeFileExtension | bool | If the user should be allowed to download and perform other actions on the attachment. |
| Stream | byte | Binary stream for outgoing attachments. This property will not be populated for existing e-mail items. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetUnsanitizedPreviewAttachmentFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MailItemId": 632,
  "AttachmentId": "perspiciatis",
  "AttachmentType": "expedita",
  "AttachmentFilename": "ut"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Cross-platform value-added orchestration",
  "Filename": "exercitationem",
  "Size": 134,
  "Type": "quo",
  "Encoding": "tempore",
  "Id": "illum",
  "Disposition": "et",
  "IsSafeFileExtension": false,
  "Stream": "GIF89....File contents as raw bytes...",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 261
    }
  }
}
```