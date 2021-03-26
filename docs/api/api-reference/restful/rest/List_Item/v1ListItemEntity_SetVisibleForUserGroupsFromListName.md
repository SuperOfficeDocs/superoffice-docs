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
    "Id": 845,
    "Name": "Howell-Schaden",
    "ToolTip": "Odit ducimus asperiores exercitationem enim sit.",
    "Deleted": false,
    "Rank": 416,
    "Type": "eum",
    "ColorBlock": 345,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2003-12-08T09:41:00.1353619+01:00",
    "ChildItems": [
      {
        "Id": 172,
        "Name": "Barrows-Walsh",
        "ToolTip": "Laudantium debitis iusto asperiores.",
        "Deleted": true,
        "Rank": 415,
        "Type": "adipisci",
        "ColorBlock": 988,
        "IconHint": "quis",
        "Selected": true,
        "LastChanged": "2014-09-30T09:41:00.1353619+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "reprehenderit",
        "Hidden": false,
        "FullName": "Coy Lebsack"
      }
    ],
    "ExtraInfo": "ab",
    "StyleHint": "sit",
    "Hidden": true,
    "FullName": "Giles Stiedemann"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 385,
    "Name": "Dach, Prohaska and Strosin",
    "ToolTip": "Quas fuga.",
    "Deleted": true,
    "Rank": 759,
    "Type": "aut",
    "ColorBlock": 36,
    "IconHint": "sequi",
    "Selected": false,
    "LastChanged": "1996-01-06T09:41:00.1363619+01:00",
    "ChildItems": [
      {
        "Id": 50,
        "Name": "Pagac, Miller and Torp",
        "ToolTip": "Accusamus voluptas consequatur maxime facere nesciunt.",
        "Deleted": true,
        "Rank": 283,
        "Type": "eos",
        "ColorBlock": 514,
        "IconHint": "doloribus",
        "Selected": false,
        "LastChanged": "2016-01-22T09:41:00.1363619+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsa",
        "StyleHint": "fugit",
        "Hidden": false,
        "FullName": "Zachery Streich",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 408
          }
        }
      }
    ],
    "ExtraInfo": "iure",
    "StyleHint": "nostrum",
    "Hidden": false,
    "FullName": "Abbie Gulgowski",
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
        "FieldLength": 178
      }
    }
  }
]
```