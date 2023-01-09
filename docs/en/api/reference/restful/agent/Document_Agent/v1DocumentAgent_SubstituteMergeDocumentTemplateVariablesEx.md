---
title: POST Agents/Document/SubstituteMergeDocumentTemplateVariablesEx
uid: v1DocumentAgent_SubstituteMergeDocumentTemplateVariablesEx
---

# POST Agents/Document/SubstituteMergeDocumentTemplateVariablesEx

```http
POST /api/v1/Agents/Document/SubstituteMergeDocumentTemplateVariablesEx
```

Parse the source document, and replace any template variable tags with their values, based on the provided identifiers.


&lt;p/&gt; The source document should be of type MergeDraft. This method also takes a pair of arrays specifying custom tags and their values; these tags will be available during substitution in addition to all the existing tags. Custom values will override values otherwise set.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/SubstituteMergeDocumentTemplateVariablesEx?$select=name,department,category/id
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

MergeDocumentId, ContactId, PersonId, ProjectId, SelectionId, AppointmentId, DocumentId, SaleId, CustomTags, CustomValues 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergeDocumentId | Integer |  |
| ContactId | Integer |  |
| PersonId | Integer |  |
| ProjectId | Integer |  |
| SelectionId | Integer |  |
| AppointmentId | Integer |  |
| DocumentId | Integer |  |
| SaleId | Integer |  |
| CustomTags | Array |  |
| CustomValues | Array |  |

## Response:byte

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: byte


## Sample request

```http!
POST /api/v1/Agents/Document/SubstituteMergeDocumentTemplateVariablesEx
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MergeDocumentId": 75,
  "ContactId": 35,
  "PersonId": 269,
  "ProjectId": 75,
  "SelectionId": 476,
  "AppointmentId": 782,
  "DocumentId": 832,
  "SaleId": 580,
  "CustomTags": [
    "magnam",
    "ut"
  ],
  "CustomValues": [
    "odio",
    "molestias"
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"GIF89....File contents as raw bytes..."
```