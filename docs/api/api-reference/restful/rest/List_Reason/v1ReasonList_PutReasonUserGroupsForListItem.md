---
title: PUT List/Reason/Items/{id}/UserGroups
id: v1ReasonList_PutReasonUserGroupsForListItem
---

# PUT List/Reason/Items/{id}/UserGroups

```http
PUT /api/v1/List/Reason/Items/{itemId}/UserGroups
```

Saves user groups visible for the Reason list's item.

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
PUT /api/v1/List/Reason/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 427,
    "Name": "Robel, Shields and Graham",
    "ToolTip": "Est pariatur et est eos quasi voluptatem.",
    "Deleted": true,
    "Rank": 845,
    "Type": "dolor",
    "ColorBlock": 249,
    "IconHint": "aspernatur",
    "Selected": true,
    "LastChanged": "2018-04-18T18:25:52.134019+02:00",
    "ChildItems": [
      {
        "Id": 7,
        "Name": "Russel Group",
        "ToolTip": "Dolor deleniti accusantium ut voluptatum atque rem.",
        "Deleted": true,
        "Rank": 428,
        "Type": "laboriosam",
        "ColorBlock": 544,
        "IconHint": "ipsum",
        "Selected": true,
        "LastChanged": "2009-11-24T18:25:52.134019+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minus",
        "StyleHint": "tenetur",
        "Hidden": false,
        "FullName": "Jada Tillman"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "aliquam",
    "Hidden": true,
    "FullName": "Kendra Beer"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 959,
    "Name": "Lang, Crooks and Runte",
    "ToolTip": "Libero suscipit distinctio.",
    "Deleted": false,
    "Rank": 101,
    "Type": "dolorum",
    "ColorBlock": 417,
    "IconHint": "in",
    "Selected": false,
    "LastChanged": "2021-05-31T18:25:52.1350215+02:00",
    "ChildItems": [
      {
        "Id": 69,
        "Name": "Wiza, Hickle and Bauch",
        "ToolTip": "Aut inventore aliquam.",
        "Deleted": true,
        "Rank": 323,
        "Type": "officiis",
        "ColorBlock": 580,
        "IconHint": "voluptatum",
        "Selected": false,
        "LastChanged": "2003-03-20T18:25:52.1350215+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minima",
        "StyleHint": "ipsam",
        "Hidden": true,
        "FullName": "Trevor Schuster",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 413
          }
        }
      }
    ],
    "ExtraInfo": "hic",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Miss Laron Nitzsche",
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
        "FieldLength": 17
      }
    }
  }
]
```