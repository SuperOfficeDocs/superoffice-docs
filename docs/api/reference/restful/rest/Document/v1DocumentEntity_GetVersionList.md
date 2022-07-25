---
title: GET Document/{id}/Version
id: v1DocumentEntity_GetVersionList
---

# GET Document/{id}/Version

```http
GET /api/v1/Document/{documentId}/Version
```

Get a list of existing, committed  versions for a given document

| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document Id **Required** |

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

## Response: array

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ExternalReference | string |  |
| DocumentId | int32 |  |
| VersionId | string |  |
| CheckedInDate | date-time |  |
| CheckedInByName | string |  |
| CheckedInByAssociateId | int32 |  |
| Description | string |  |
| DisplayText | string |  |
| ExtraFields | array |  |

## Sample Request

```http!
GET /api/v1/Document/{documentId}/Version
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ExternalReference": "illum",
    "DocumentId": 55,
    "VersionId": "sapiente",
    "CheckedInDate": "2012-05-29T18:25:50.5276242+02:00",
    "CheckedInByName": "Reinger-Sauer",
    "CheckedInByAssociateId": 858,
    "Description": "Seamless disintermediate strategy",
    "DisplayText": "aut",
    "ExtraFields": [
      "inventore",
      "a"
    ]
  }
]
```
