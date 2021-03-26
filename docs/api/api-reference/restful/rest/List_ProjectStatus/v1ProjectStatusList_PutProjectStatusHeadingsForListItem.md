---
title: PUT List/ProjectStatus/Items/{id}/Headings
id: v1ProjectStatusList_PutProjectStatusHeadingsForListItem
---

# PUT List/ProjectStatus/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
```

Saves headings for the ProjectStatus list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 205,
    "Name": "Bins-Ruecker",
    "ToolTip": "At nobis est deserunt sed vel libero.",
    "Deleted": true,
    "Rank": 959,
    "Type": "reprehenderit",
    "ColorBlock": 198,
    "IconHint": "assumenda",
    "Selected": true,
    "LastChanged": "2001-04-24T09:41:00.6413869+02:00",
    "ChildItems": [
      {
        "Id": 122,
        "Name": "Goodwin, Barton and Christiansen",
        "ToolTip": "Eos laboriosam aut.",
        "Deleted": false,
        "Rank": 411,
        "Type": "suscipit",
        "ColorBlock": 377,
        "IconHint": "quos",
        "Selected": true,
        "LastChanged": "2004-07-13T09:41:00.6413869+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "esse",
        "StyleHint": "occaecati",
        "Hidden": false,
        "FullName": "Jeremie Upton"
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Cordie Hermann"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 291,
    "Name": "Douglas-Murphy",
    "ToolTip": "Itaque ea.",
    "Deleted": true,
    "Rank": 662,
    "Type": "vitae",
    "ColorBlock": 919,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "1994-07-18T09:41:00.6423867+02:00",
    "ChildItems": [
      {
        "Id": 402,
        "Name": "Schuster LLC",
        "ToolTip": "Aut eum officiis ut.",
        "Deleted": true,
        "Rank": 695,
        "Type": "autem",
        "ColorBlock": 37,
        "IconHint": "dicta",
        "Selected": true,
        "LastChanged": "2003-12-26T09:41:00.6423867+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corrupti",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Sincere Harris",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 269
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "facere",
    "Hidden": false,
    "FullName": "Winifred Welch",
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
        "FieldLength": 660
      }
    }
  }
]
```