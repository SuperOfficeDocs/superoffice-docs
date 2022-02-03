---
title: GET List/Task/Items/{id}/UserGroups
id: v1TaskList_GetTaskListItemUserGroupsForListItem
---

# GET List/Task/Items/{id}/UserGroups

```http
GET /api/v1/List/Task/Items/{itemId}/UserGroups
```

Gets user groups visible for the TaskListItem list's item.

Calls the Appointment agent service GetHeadings.




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
GET /api/v1/List/Task/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 345,
    "Name": "Watsica-Willms",
    "ToolTip": "Consequatur omnis consequatur.",
    "Deleted": false,
    "Rank": 561,
    "Type": "dolor",
    "ColorBlock": 680,
    "IconHint": "sunt",
    "Selected": false,
    "LastChanged": "2014-07-25T18:25:52.2806371+02:00",
    "ChildItems": [
      {
        "Id": 431,
        "Name": "Bogisich-Dach",
        "ToolTip": "Qui quia quia maiores rerum fugit.",
        "Deleted": true,
        "Rank": 233,
        "Type": "omnis",
        "ColorBlock": 81,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "1995-11-01T18:25:52.2806371+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facilis",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Willa Kessler",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 474
          }
        }
      }
    ],
    "ExtraInfo": "eum",
    "StyleHint": "temporibus",
    "Hidden": false,
    "FullName": "Johnny Moore",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deploy sticky vortals"
        },
        "FieldType": "System.String",
        "FieldLength": 884
      }
    }
  }
]
```