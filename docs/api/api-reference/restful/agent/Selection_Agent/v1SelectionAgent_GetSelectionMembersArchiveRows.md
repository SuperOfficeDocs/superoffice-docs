---
title: POST Agents/Selection/GetSelectionMembersArchiveRows
id: v1SelectionAgent_GetSelectionMembersArchiveRows
---

# POST Agents/Selection/GetSelectionMembersArchiveRows

```http
POST /api/v1/Agents/Selection/GetSelectionMembersArchiveRows
```

Get the list of members in this selection.

The type of members depends on the target table of the selection.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetSelectionMembersArchiveRows?$select=name,department,category/id
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

SelectionId, Select 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| Select | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| EntityName | string | The entity name of the ArchiveListItem. An ArchiveList may contain rows from different entities. |
| PrimaryKey | int32 | The  primary key for the row |
| ColumnData | object | Dictionary of column name - column data items. Each column data item contains a display value, a tooltip hint, a link hint, and an orderby value. &lt;para/&gt;The display value is encoded by the CultureDataFormatter and can be decoded / localized by that class; all other values are optional. &lt;para/&gt;Tooltip hints can be passed to the TooltipProvider (Tooltip service) to be translated into an actual tootip. |
| LinkHint | string | Link hint for the row, indicating things like navigation links that can be presented as clickable hyperlinks |
| StyleHint | string | Style hint for the row, for instance 'retired' for associates or 'private' for appointments. Presentation layers can interpret the style hints as they see fit. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/GetSelectionMembersArchiveRows
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 60,
  "Select": "laborum"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "EntityName": "Kunze-Romaguera",
    "PrimaryKey": 205,
    "ColumnData": {
      "fieldName": {
        "DisplayValue": "similique",
        "TooltipHint": "expedita",
        "LinkHint": "eos"
      }
    },
    "LinkHint": "non",
    "StyleHint": "ipsum",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 725
      }
    }
  }
]
```