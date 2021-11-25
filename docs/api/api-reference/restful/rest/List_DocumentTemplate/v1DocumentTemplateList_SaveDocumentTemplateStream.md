---
title: PUT List/DocumentTemplate/Items/{id}/Content/{languageCode}
id: v1DocumentTemplateList_SaveDocumentTemplateStream
---

# PUT List/DocumentTemplate/Items/{id}/Content/{languageCode}

```http
PUT /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}
```

Writes content in stream to document template file






| Path Part | Type | Description |
|-----------|------|-------------|
| documentTemplateId | int32 | Identifier for document template **Required** |
| languageCode | string | Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang". **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| pluginId | int32 |  Plugin to use for storing document content. 0 = SOARC. Use -1 to use the plugin specified in the template. |

```http
PUT /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}?pluginId=748
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `multipart/form-data`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: content  

Stream containing content to be saved to document template file 



## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| Description | string |  |
| ExternalReference | string |  |
| MimeType | string |  |
| PluginId | int32 |  |

## Sample Request

```http!
PUT /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Content/{languageCode}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Name": "DuBuque, Harber and Braun",
  "Description": "Adaptive value-added instruction set",
  "ExternalReference": "ad",
  "MimeType": "quaerat",
  "PluginId": 788
}
```