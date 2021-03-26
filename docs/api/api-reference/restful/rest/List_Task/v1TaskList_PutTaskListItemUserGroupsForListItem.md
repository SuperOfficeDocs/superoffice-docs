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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 378,
    "Name": "Kuvalis-VonRueden",
    "ToolTip": "Eum consequuntur.",
    "Deleted": true,
    "Rank": 337,
    "Type": "asperiores",
    "ColorBlock": 431,
    "IconHint": "pariatur",
    "Selected": false,
    "LastChanged": "2008-07-11T09:41:00.8293877+02:00",
    "ChildItems": [
      {
        "Id": 520,
        "Name": "Padberg-Lebsack",
        "ToolTip": "Explicabo pariatur.",
        "Deleted": false,
        "Rank": 800,
        "Type": "minima",
        "ColorBlock": 604,
        "IconHint": "dolore",
        "Selected": false,
        "LastChanged": "2013-07-31T09:41:00.8293877+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorum",
        "StyleHint": "omnis",
        "Hidden": false,
        "FullName": "Ford Keeling"
      }
    ],
    "ExtraInfo": "neque",
    "StyleHint": "minima",
    "Hidden": true,
    "FullName": "Dameon Schneider"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 958,
    "Name": "Parker Inc and Sons",
    "ToolTip": "Error nemo.",
    "Deleted": true,
    "Rank": 893,
    "Type": "autem",
    "ColorBlock": 199,
    "IconHint": "earum",
    "Selected": false,
    "LastChanged": "2021-02-24T09:41:00.8313868+01:00",
    "ChildItems": [
      {
        "Id": 458,
        "Name": "Haley-Auer",
        "ToolTip": "Eius quisquam repellat neque.",
        "Deleted": true,
        "Rank": 514,
        "Type": "cumque",
        "ColorBlock": 701,
        "IconHint": "qui",
        "Selected": true,
        "LastChanged": "2007-09-28T09:41:00.8313868+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "doloremque",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Margaret Bogisich",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 2
          }
        }
      }
    ],
    "ExtraInfo": "quas",
    "StyleHint": "ipsum",
    "Hidden": false,
    "FullName": "Hans Sanford",
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
        "FieldLength": 914
      }
    }
  }
]
```