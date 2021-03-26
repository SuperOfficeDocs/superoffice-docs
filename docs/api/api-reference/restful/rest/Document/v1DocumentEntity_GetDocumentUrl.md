---
title: GET Document/{id}/Url
id: v1DocumentEntity_GetDocumentUrl
---

# GET Document/{id}/Url

```http
GET /api/v1/Document/{documentId}/Url
```

Get a URL referring to the given document content.

&lt;para/&gt;This URL may be passed to the ultimate client (text editor of some kind?), which is then responsible for all further operations.&lt;para/&gt;The returned string is a fully qualified URL.&lt;para/&gt;Not all documents and document plugins support this feature.




| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document primary key **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| versionId | string |  Version ID if applicable/desired; a blank value implies "latest" version and is always acceptable. |
| writeableUrl | bool |  If true, then a URL that supports saving is requested. Som edocument plugins may not support read-only URLs, so there is no guarantee that a False value will actually yield a read-only URL, and vice versa. |

```http
GET /api/v1/Document/{documentId}/Url?versionId=consequuntur
GET /api/v1/Document/{documentId}/Url?writeableUrl=False
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
GET /api/v1/Document/{documentId}/Url
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"http://www.example.com/"
```