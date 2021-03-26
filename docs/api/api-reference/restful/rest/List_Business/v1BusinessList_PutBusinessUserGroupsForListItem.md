---
title: PUT List/Business/Items/{id}/UserGroups
id: v1BusinessList_PutBusinessUserGroupsForListItem
---

# PUT List/Business/Items/{id}/UserGroups

```http
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
```

Saves user groups visible for the Business list's item.

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
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 685,
    "Name": "Gutmann-Shanahan",
    "ToolTip": "Aliquid incidunt at est nihil adipisci.",
    "Deleted": true,
    "Rank": 6,
    "Type": "quo",
    "ColorBlock": 627,
    "IconHint": "placeat",
    "Selected": false,
    "LastChanged": "2006-08-28T09:41:00.1743658+02:00",
    "ChildItems": [
      {
        "Id": 317,
        "Name": "Schmitt, Herzog and Mayer",
        "ToolTip": "Provident est.",
        "Deleted": true,
        "Rank": 694,
        "Type": "in",
        "ColorBlock": 518,
        "IconHint": "velit",
        "Selected": false,
        "LastChanged": "2004-08-26T09:41:00.1743658+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "pariatur",
        "StyleHint": "dolore",
        "Hidden": false,
        "FullName": "Chauncey Herman V"
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "eos",
    "Hidden": false,
    "FullName": "Wyman McGlynn Sr."
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 16,
    "Name": "Larkin LLC",
    "ToolTip": "Quisquam dolor reiciendis in.",
    "Deleted": false,
    "Rank": 436,
    "Type": "enim",
    "ColorBlock": 275,
    "IconHint": "non",
    "Selected": true,
    "LastChanged": "2001-07-01T09:41:00.1753623+02:00",
    "ChildItems": [
      {
        "Id": 199,
        "Name": "Beer, Mueller and Conn",
        "ToolTip": "Aut quisquam quia id.",
        "Deleted": false,
        "Rank": 15,
        "Type": "ipsum",
        "ColorBlock": 274,
        "IconHint": "nam",
        "Selected": false,
        "LastChanged": "1995-04-24T09:41:00.1763613+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deleniti",
        "StyleHint": "rem",
        "Hidden": false,
        "FullName": "Odell Romaguera",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 193
          }
        }
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "accusamus",
    "Hidden": false,
    "FullName": "Giovanna Waters",
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
        "FieldLength": 325
      }
    }
  }
]
```