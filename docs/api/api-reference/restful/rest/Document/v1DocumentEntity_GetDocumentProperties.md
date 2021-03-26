---
title: GET Document/{id}/Property
id: v1DocumentEntity_GetDocumentProperties
---

# GET Document/{id}/Property

```http
GET /api/v1/Document/{documentId}/Property
```

Get plugin-dependent properties for the document.

A number of standard properties that should be supported by all plugins are defined in SuperOffice.CRM.Documents.Constants.Properties.




| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document ID **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| requestedProperties | array |  Array of property names whose values are being requested. |

```http
GET /api/v1/Document/{documentId}/Property?requestedProperties=Path
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
GET /api/v1/Document/{documentId}/Property
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "assumenda",
  "2": "ea"
}
```