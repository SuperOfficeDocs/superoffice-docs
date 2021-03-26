---
title: GET List/DocumentTemplate/Plugin/{id}/DocumentTypes
id: v1DocumentTemplateList_GetDocumentTypesForPlugin
---

# GET List/DocumentTemplate/Plugin/{id}/DocumentTypes

```http
GET /api/v1/List/DocumentTemplate/Plugin/{pluginId}/DocumentTypes
```

Get a list of document types supported by a given document plugin.

Use the document template type when creating a new template.




| Path Part | Type | Description |
|-----------|------|-------------|
| pluginId | int32 | Numeric document plugin id, corresponding to the doctmpl.AutoeventId, doctmpl.LoadTemplateFromPlugin. **Required** |



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
GET /api/v1/List/DocumentTemplate/Plugin/{pluginId}/DocumentTypes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "inventore",
  "2": "dolore"
}
```