---
title: GET Selection/{id}/ShadowMembers
id: v1SelectionEntity_GetSelectionShadowMembersArchiveRows
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

## Response: object

Easy to use archive results - just a flat list of values.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| odata.metadata | string |  |
| odata.nextLink | string |  |
| value | array |  |

## Sample Request

```http!
GET /api/v1/Selection/{selectionId}/ShadowMembers
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "et",
  "value": [
    {
      "PrimaryKey": 9064,
      "EntityName": "sale",
      "saleId": 9064,
      "contactId": 3294,
      "name": "Klein-Hackett"
    },
    {
      "PrimaryKey": 7126,
      "EntityName": "sale",
      "saleId": 7126,
      "contactId": 4554,
      "name": "Cummings-Zemlak"
    }
  ]
}
```
