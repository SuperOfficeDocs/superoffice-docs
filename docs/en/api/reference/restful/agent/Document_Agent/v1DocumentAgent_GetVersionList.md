---
title: POST Agents/Document/GetVersionList
uid: v1DocumentAgent_GetVersionList
generated: true
content_type: reference
---

# POST Agents/Document/GetVersionList

```http
POST /api/v1/Agents/Document/GetVersionList
```

Get a list of existing, committed  versions for a given document







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetVersionList?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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

## Sample request

```http!
POST /api/v1/Agents/Document/GetVersionList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 391
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ExternalReference": "natus",
    "DocumentId": 296,
    "VersionId": "est",
    "CheckedInDate": "2003-03-10T11:24:48.0001535+01:00",
    "CheckedInByName": "Predovic, Stehr and Quigley",
    "CheckedInByAssociateId": 156,
    "Description": "Versatile value-added workforce",
    "DisplayText": "dolorem",
    "ExtraFields": [
      "recusandae",
      "ex"
    ]
  }
]
```