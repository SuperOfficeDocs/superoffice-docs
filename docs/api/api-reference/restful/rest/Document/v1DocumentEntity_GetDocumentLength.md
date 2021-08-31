---
title: GET Document/{id}/Length
id: v1DocumentEntity_GetDocumentLength
---

# GET Document/{id}/Length

```http
GET /api/v1/Document/{documentId}/Length
```

Get length of the document content in bytes.






| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document id **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| versionId | string |  Version ID if applicable; a blank value implies "latest" version and is always acceptable. |

```http
GET /api/v1/Document/{documentId}/Length?versionId=nesciunt
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


## Response: int64



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: int64


## Sample Request

```http!
GET /api/v1/Document/{documentId}/Length
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

99.99
```