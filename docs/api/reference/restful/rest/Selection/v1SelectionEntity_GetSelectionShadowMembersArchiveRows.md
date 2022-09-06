---
title: GET Selection/{id}/ShadowMembers
uid: v1SelectionEntity_GetSelectionShadowMembersArchiveRows
---

# GET Selection/{id}/ShadowMembers

```http
GET /api/v1/Selection/{selectionId}/ShadowMembers
```

Get the list of members in this selection's shadow (i.

e. the list of contacts + persons referenced in the main selection).

| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The selectionId we want selection members for. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname,name', 'startTime,firstname,name' |
| $mode | string |  FULL (with raw values and hints for each value) or SLIM (just the display values) |
| $format | string |  Set XML or JSON output format; override the format determined from Accept header. |

```http
GET /api/v1/Selection/{selectionId}/ShadowMembers?$select=name,department,category/id
GET /api/v1/Selection/{selectionId}/ShadowMembers?$mode=FULL
GET /api/v1/Selection/{selectionId}/ShadowMembers?$format=JSON
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| odata.metadata | string |  |
| odata.nextLink | string |  |
| value | array |  |

## Sample request

```http!
GET /api/v1/Selection/{selectionId}/ShadowMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "quo",
  "value": [
    {
      "PrimaryKey": 1449,
      "EntityName": "person",
      "personId": 1449,
      "fullName": "Rozella Flatley"
    },
    {
      "PrimaryKey": 2355,
      "EntityName": "person",
      "personId": 2355,
      "fullName": "Mrs. Harrison Williamson"
    }
  ]
}
```
