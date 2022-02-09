---
title: GET List/DocumentTemplate/Items/{id}/Content/{languageCode}
id: v1DocumentTemplateList_GetDocumentTemplateStreamFromId
---

# GET List/DocumentTemplate/Items/{id}/Content/{languageCode}

```http
GET /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}
```

Retrieve a stream to a document template based on its id






| Path Part | Type | Description |
|-----------|------|-------------|
| documentTemplateId | int32 | Id of template to retrieve **Required** |
| languageCode | string | Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang". **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/json-patch+json`, `application/merge-patch+json`, `application/pdf`, `text/html`, `text/plain`, `multipart/related` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 


## Sample Request

```http!
GET /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}
Authorization: Basic dGplMDpUamUw
Accept: binary/octet-stream
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: binary/octet-stream

GIF89....File contents as raw bytes...
```