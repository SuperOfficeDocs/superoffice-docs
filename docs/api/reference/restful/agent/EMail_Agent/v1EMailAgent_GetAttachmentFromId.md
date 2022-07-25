---
title: POST Agents/EMail/GetAttachmentFromId
id: v1EMailAgent_GetAttachmentFromId
---

# POST Agents/EMail/GetAttachmentFromId

```http
POST /api/v1/Agents/EMail/GetAttachmentFromId
```

Retrieve an attachment from an e-mail

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetAttachmentFromId?$select=name,department,category/id
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

MailItemId, AttachmentId

| Property Name | Type |  Description |
|----------------|------|--------------|
| MailItemId | int32 |  |
| AttachmentId | string |  |

## Response: object

Information about an attachment

Carrier object for EMailAttachment.
Services for the EMailAttachment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Description | string | Name/description |
| Filename | string | Filename |
| Size | int32 | Size of attachment |
| Type | string | Attachment Content-Type |
| Encoding | string | Content-Transfer-Encoding |
| Id | string | Content-ID |
| Disposition | string | Content-Disposition |
| Stream | byte | Binary stream for outgoing attachments. This property will not be populated for existing e-mail items. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetAttachmentFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "MailItemId": 918,
  "AttachmentId": "minima"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Description": "Polarised responsive contingency",
  "Filename": "veniam",
  "Size": 942,
  "Type": "voluptatem",
  "Encoding": "commodi",
  "Id": "soluta",
  "Disposition": "est",
  "Stream": "GIF89....File contents as raw bytes...",
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
      "FieldType": "System.Int32",
      "FieldLength": 287
    }
  }
}
```
