---
title: PUT List/{udListDefinitionName}/Items/{id}/UserGroups
id: v1ListItemEntity_SetVisibleForUserGroupsFromListName
---

# PUT List/{udListDefinitionName}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update the items from. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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

## Request Body: userGroups  

The selectable user groups. 

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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 491,
    "Name": "Carroll LLC",
    "ToolTip": "Voluptatem voluptatem perspiciatis modi.",
    "Deleted": true,
    "Rank": 526,
    "Type": "vitae",
    "ColorBlock": 327,
    "IconHint": "a",
    "Selected": true,
    "LastChanged": "1998-06-09T15:05:43.2138996+02:00",
    "ChildItems": [
      {
        "Id": 647,
        "Name": "Pagac-Glover",
        "ToolTip": "Corporis aut non.",
        "Deleted": false,
        "Rank": 657,
        "Type": "mollitia",
        "ColorBlock": 257,
        "IconHint": "itaque",
        "Selected": true,
        "LastChanged": "2019-02-11T15:05:43.2138996+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deserunt",
        "StyleHint": "ea",
        "Hidden": true,
        "FullName": "Catharine Runolfsson"
      }
    ],
    "ExtraInfo": "nobis",
    "StyleHint": "ducimus",
    "Hidden": true,
    "FullName": "Bettye Smitham III"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 907,
    "Name": "Schuster-McDermott",
    "ToolTip": "Dolores veritatis culpa veniam ea.",
    "Deleted": true,
    "Rank": 782,
    "Type": "dicta",
    "ColorBlock": 483,
    "IconHint": "minus",
    "Selected": false,
    "LastChanged": "1996-04-18T15:05:43.2159008+02:00",
    "ChildItems": [
      {
        "Id": 8,
        "Name": "Rosenbaum, Crooks and Flatley",
        "ToolTip": "Itaque maiores quis ullam assumenda.",
        "Deleted": true,
        "Rank": 53,
        "Type": "ullam",
        "ColorBlock": 495,
        "IconHint": "tempore",
        "Selected": true,
        "LastChanged": "2015-08-19T15:05:43.2159008+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eligendi",
        "StyleHint": "aspernatur",
        "Hidden": true,
        "FullName": "Hazle Runte",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 724
          }
        }
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "non",
    "Hidden": true,
    "FullName": "Kody Abshire MD",
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
        "FieldLength": 298
      }
    }
  }
]
```