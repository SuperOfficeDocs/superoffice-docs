---
title: POST Agents/Selection/ExportSelectionMembersWithOrderBy
uid: v1SelectionAgent_ExportSelectionMembersWithOrderBy
generated: true
---

# POST Agents/Selection/ExportSelectionMembersWithOrderBy

```http
POST /api/v1/Agents/Selection/ExportSelectionMembersWithOrderBy
```

ExportSelectionMembers will generate a string that is the result of substituting the template variables with values from selectionmembers.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/ExportSelectionMembersWithOrderBy?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/json-patch+json`, `application/merge-patch+json`, `application/pdf`, `text/html`, `text/plain`, `multipart/related` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

SelectionId, TemplateName, UseContacts, OrderBy 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | Integer |  |
| TemplateName | String |  |
| UseContacts | Boolean |  |
| OrderBy | String |  |

## Response:byte

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: byte


## Sample request

```http!
POST /api/v1/Agents/Selection/ExportSelectionMembersWithOrderBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 299,
  "TemplateName": "Nolan, Reilly and O'Hara",
  "UseContacts": true,
  "OrderBy": "incidunt"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"GIF89....File contents as raw bytes..."
```