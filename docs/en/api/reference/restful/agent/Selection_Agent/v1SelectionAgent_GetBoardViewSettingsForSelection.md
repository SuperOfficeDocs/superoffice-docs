---
title: POST Agents/Selection/GetBoardViewSettingsForSelection
uid: v1SelectionAgent_GetBoardViewSettingsForSelection
generated: true
content_type: reference
---

# POST Agents/Selection/GetBoardViewSettingsForSelection

```http
POST /api/v1/Agents/Selection/GetBoardViewSettingsForSelection
```

Get BoardViewSettings by selection id, associate id, and settings type







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetBoardViewSettingsForSelection?$select=name,department,category/id
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

AssociateId, SelectionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer |  |
| SelectionId | Integer |  |

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
POST /api/v1/Agents/Selection/GetBoardViewSettingsForSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 866,
  "SelectionId": 926
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BoardViewSettingsId": 895,
  "EntityType": "None",
  "AssociateId": 131,
  "SelectionId": 623,
  "HideEmptyGroups": false,
  "GroupBy": "nemo",
  "SubGroupBy": "rerum",
  "SortBy": "vel",
  "SortDesc": true,
  "SumBy": "aut",
  "ColorBy": "iusto",
  "Filters": "ut"
}
```