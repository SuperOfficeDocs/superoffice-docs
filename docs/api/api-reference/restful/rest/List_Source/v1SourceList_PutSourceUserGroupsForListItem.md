---
title: PUT List/Source/Items/{id}/UserGroups
id: v1SourceList_PutSourceUserGroupsForListItem
---

# PUT List/Source/Items/{id}/UserGroups

```http
PUT /api/v1/List/Source/Items/{itemId}/UserGroups
```

Saves user groups visible for the Source list's item.

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
PUT /api/v1/List/Source/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 201,
    "Name": "Auer-Hettinger",
    "ToolTip": "Impedit quia fuga ullam omnis ipsum pariatur.",
    "Deleted": false,
    "Rank": 997,
    "Type": "dolorum",
    "ColorBlock": 178,
    "IconHint": "perferendis",
    "Selected": true,
    "LastChanged": "2005-01-18T15:05:43.8311173+01:00",
    "ChildItems": [
      {
        "Id": 152,
        "Name": "Lynch, Gorczany and Jacobson",
        "ToolTip": "Explicabo culpa recusandae.",
        "Deleted": true,
        "Rank": 654,
        "Type": "minima",
        "ColorBlock": 372,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2008-07-08T15:05:43.8321168+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptates",
        "StyleHint": "ipsum",
        "Hidden": false,
        "FullName": "Anna Boyle"
      }
    ],
    "ExtraInfo": "minima",
    "StyleHint": "ea",
    "Hidden": false,
    "FullName": "Lon Heathcote"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 847,
    "Name": "Kerluke Inc and Sons",
    "ToolTip": "Est voluptas totam ducimus dolorum.",
    "Deleted": true,
    "Rank": 176,
    "Type": "voluptatem",
    "ColorBlock": 390,
    "IconHint": "aspernatur",
    "Selected": true,
    "LastChanged": "2008-06-03T15:05:43.8331171+02:00",
    "ChildItems": [
      {
        "Id": 428,
        "Name": "Douglas Group",
        "ToolTip": "Magnam vel.",
        "Deleted": true,
        "Rank": 10,
        "Type": "voluptatibus",
        "ColorBlock": 563,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "2006-10-29T15:05:43.8331171+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nostrum",
        "StyleHint": "ipsum",
        "Hidden": true,
        "FullName": "Theo Bahringer",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 155
          }
        }
      }
    ],
    "ExtraInfo": "atque",
    "StyleHint": "reiciendis",
    "Hidden": true,
    "FullName": "Fredrick Ryan",
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
        "FieldLength": 141
      }
    }
  }
]
```