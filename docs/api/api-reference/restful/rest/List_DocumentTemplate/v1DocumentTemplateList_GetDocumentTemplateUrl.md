---
title: GET List/DocumentTemplate/Items/{id}/Url
id: v1DocumentTemplateList_GetDocumentTemplateUrl
---

# GET List/DocumentTemplate/Items/{id}/Url

```http
GET /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Url
```

Get a url to the document template






| Path Part | Type | Description |
|-----------|------|-------------|
| documentTemplateId | int32 | The id of the template **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| writableUrl | bool |  Get a writeable url to the document template? |
| languageCode | string |  The language code ('en-US', 'nb-NO', etc). Use empty string if not supported or used. |

```http
GET /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Url?writableUrl=False
GET /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Url?languageCode=aliquid
```


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


## Response: string



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: string


## Sample Request

```http!
GET /api/v1/List/DocumentTemplate/Items/{documentTemplateId}/Url
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"http://www.example.com/"
```