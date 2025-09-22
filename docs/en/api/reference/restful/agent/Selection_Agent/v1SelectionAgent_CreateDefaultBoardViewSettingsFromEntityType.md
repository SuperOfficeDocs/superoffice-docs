---
title: POST Agents/Selection/CreateDefaultBoardViewSettingsFromEntityType
uid: v1SelectionAgent_CreateDefaultBoardViewSettingsFromEntityType
generated: true
content_type: reference
---

# POST Agents/Selection/CreateDefaultBoardViewSettingsFromEntityType

```http
POST /api/v1/Agents/Selection/CreateDefaultBoardViewSettingsFromEntityType
```

Creates a new carrier from the entity type given, with the right kind of properties, defaults set.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/CreateDefaultBoardViewSettingsFromEntityType?$select=name,department,category/id
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

EntityType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EntityType | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: BoardViewSettingsBase

| Property Name | Type |  Description |
|----------------|------|--------------|
| BoardViewSettingsId | int32 | Primary key |
| EntityType | string | The kind of board view entity these settings belong to |
| AssociateId | int32 | The associate this board view settings belongs to (0 for all) |
| SelectionId | int32 | The selection this board view settings belongs to |
| HideEmptyGroups | bool | Do not show groups with no members/elements if this is true |
| GroupBy | string | Column name to group on |
| SubGroupBy | string | Column name to group on |
| SortBy | string | Column name to sort on |
| SortDesc | bool | True if the sort is descending |
| SumBy | string | Column name to sum on |
| ColorBy | string | Column name to color on |
| Filters | string | Column names to filter on, comma separated |

## Sample request

```http!
POST /api/v1/Agents/Selection/CreateDefaultBoardViewSettingsFromEntityType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EntityType": "None"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BoardViewSettingsId": 343,
  "EntityType": "None",
  "AssociateId": 989,
  "SelectionId": 15,
  "HideEmptyGroups": true,
  "GroupBy": "laboriosam",
  "SubGroupBy": "unde",
  "SortBy": "porro",
  "SortDesc": false,
  "SumBy": "illum",
  "ColorBy": "officiis",
  "Filters": "neque"
}
```