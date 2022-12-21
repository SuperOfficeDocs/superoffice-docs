---
title: GET Selection/{id}/Members
uid: v1SelectionEntity_GetSelectionMembersArchiveRows
---

# GET Selection/{id}/Members

```http
GET /api/v1/Selection/{selectionId}/Members
```

Get the list of members in this selection.


The type of members depends on the target table of the selection.





| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The selectionId we want selection members for. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname', 'startTime' |
| $mode | string |  FULL (with raw values and hints for each value) or SLIM (just the display values) |
| $format | string |  Set XML or JSON output format; override the format determined from Accept header. |

```http
GET /api/v1/Selection/{selectionId}/Members?$select=name,department,category/id
GET /api/v1/Selection/{selectionId}/Members?$mode=FULL
GET /api/v1/Selection/{selectionId}/Members?$format=JSON
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


## Response: 

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
GET /api/v1/Selection/{selectionId}/Members
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
  "odata.nextLink": "amet",
  "value": [
    {
      "PrimaryKey": 6112,
      "EntityName": "person",
      "personId": 6112,
      "fullName": "Miss Rusty Lavonne Fisher Jr."
    },
    {
      "PrimaryKey": 9483,
      "EntityName": "person",
      "personId": 9483,
      "fullName": "Melody Howe V"
    }
  ]
}
```