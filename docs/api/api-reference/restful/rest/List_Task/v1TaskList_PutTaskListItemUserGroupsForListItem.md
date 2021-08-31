---
title: PUT List/Task/Items/{id}/UserGroups
id: v1TaskList_PutTaskListItemUserGroupsForListItem
---

# PUT List/Task/Items/{id}/UserGroups

```http
PUT /api/v1/List/Task/Items/{itemId}/UserGroups
```

Saves user groups visible for the TaskListItem list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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

## Request Body: entities  

The headings to be saved. 

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
PUT /api/v1/List/Task/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 156,
    "Name": "Klocko Inc and Sons",
    "ToolTip": "Eaque voluptas facere.",
    "Deleted": true,
    "Rank": 270,
    "Type": "dolorem",
    "ColorBlock": 480,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "1994-09-09T15:05:43.8931228+02:00",
    "ChildItems": [
      {
        "Id": 233,
        "Name": "Sporer, Yundt and Frami",
        "ToolTip": "Voluptate at autem voluptatem vel.",
        "Deleted": false,
        "Rank": 311,
        "Type": "dolor",
        "ColorBlock": 225,
        "IconHint": "consequuntur",
        "Selected": true,
        "LastChanged": "1994-08-19T15:05:43.8931228+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "id",
        "StyleHint": "illo",
        "Hidden": true,
        "FullName": "Lexi Zulauf"
      }
    ],
    "ExtraInfo": "ex",
    "StyleHint": "cum",
    "Hidden": false,
    "FullName": "Emilie Bartell"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 867,
    "Name": "Ortiz Inc and Sons",
    "ToolTip": "Est voluptatem.",
    "Deleted": true,
    "Rank": 476,
    "Type": "soluta",
    "ColorBlock": 796,
    "IconHint": "ipsam",
    "Selected": false,
    "LastChanged": "2014-06-19T15:05:43.8941251+02:00",
    "ChildItems": [
      {
        "Id": 179,
        "Name": "Hammes LLC",
        "ToolTip": "Aliquid consequatur molestiae quibusdam.",
        "Deleted": false,
        "Rank": 249,
        "Type": "non",
        "ColorBlock": 137,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "1998-06-20T15:05:43.8941251+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "non",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Monty Torphy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 255
          }
        }
      }
    ],
    "ExtraInfo": "consequuntur",
    "StyleHint": "voluptates",
    "Hidden": false,
    "FullName": "Dr. Arvel Schroeder",
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
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  }
]
```