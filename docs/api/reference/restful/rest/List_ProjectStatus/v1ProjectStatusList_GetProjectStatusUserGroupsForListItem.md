---
title: GET List/ProjectStatus/Items/{id}/UserGroups
id: v1ProjectStatusList_GetProjectStatusUserGroupsForListItem
---

# GET List/ProjectStatus/Items/{id}/UserGroups

```http
GET /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
```

Gets user groups visible for the ProjectStatus list's item.

Calls the List agent service GetHeadings.

| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to get. **Required** |

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
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| Selected | bool | True if the ListItem is selected |
| LastChanged | date-time | Time of last change. |
| ChildItems | array | The child items of the SelectableMDOListItem |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | bool | True if the ListItem is hidden |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 981,
    "Name": "Stiedemann-Hessel",
    "ToolTip": "Vero eos ipsa ut illo.",
    "Deleted": false,
    "Rank": 296,
    "Type": "temporibus",
    "ColorBlock": 762,
    "IconHint": "vitae",
    "Selected": true,
    "LastChanged": "2009-02-08T18:25:52.0870216+01:00",
    "ChildItems": [
      {
        "Id": 821,
        "Name": "O'Hara Inc and Sons",
        "ToolTip": "Sed perferendis vel ad perspiciatis fugiat.",
        "Deleted": false,
        "Rank": 805,
        "Type": "ut",
        "ColorBlock": 203,
        "IconHint": "officia",
        "Selected": false,
        "LastChanged": "2005-11-29T18:25:52.0870216+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iste",
        "StyleHint": "rerum",
        "Hidden": true,
        "FullName": "Mathew King",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "embrace wireless niches"
            },
            "FieldType": "System.String",
            "FieldLength": 926
          }
        }
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "ipsa",
    "Hidden": true,
    "FullName": "Alize Stoltenberg",
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
        "FieldLength": 477
      }
    }
  }
]
```
