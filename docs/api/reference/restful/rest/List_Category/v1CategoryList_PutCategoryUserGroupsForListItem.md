---
title: PUT List/Category/Items/{id}/UserGroups
id: v1CategoryList_PutCategoryUserGroupsForListItem
---

# PUT List/Category/Items/{id}/UserGroups

```http
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
```

Saves user groups visible for the Category list's item.

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
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 213,
    "Name": "Wilkinson LLC",
    "ToolTip": "Voluptas molestiae non qui ratione eos.",
    "Deleted": false,
    "Rank": 266,
    "Type": "ab",
    "ColorBlock": 50,
    "IconHint": "sint",
    "Selected": false,
    "LastChanged": "2003-12-30T18:25:51.6372945+01:00",
    "ChildItems": [
      {
        "Id": 647,
        "Name": "Moen, Swaniawski and McClure",
        "ToolTip": "Id qui.",
        "Deleted": true,
        "Rank": 196,
        "Type": "ipsum",
        "ColorBlock": 911,
        "IconHint": "ducimus",
        "Selected": true,
        "LastChanged": "2002-03-25T18:25:51.6372945+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "corporis",
        "Hidden": true,
        "FullName": "Miss Joshua Hayes"
      }
    ],
    "ExtraInfo": "modi",
    "StyleHint": "dignissimos",
    "Hidden": true,
    "FullName": "Caroline Donnelly"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 415,
    "Name": "Parker, Corkery and Torphy",
    "ToolTip": "Voluptas optio eum unde.",
    "Deleted": false,
    "Rank": 339,
    "Type": "recusandae",
    "ColorBlock": 304,
    "IconHint": "possimus",
    "Selected": true,
    "LastChanged": "2001-06-27T18:25:51.6382946+02:00",
    "ChildItems": [
      {
        "Id": 749,
        "Name": "Quitzon, Hoeger and Waelchi",
        "ToolTip": "Quia exercitationem illo et impedit deleniti sint.",
        "Deleted": false,
        "Rank": 96,
        "Type": "placeat",
        "ColorBlock": 147,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "1996-11-20T18:25:51.6382946+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "ducimus",
        "Hidden": false,
        "FullName": "Odell Feest I",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 554
          }
        }
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "omnis",
    "Hidden": true,
    "FullName": "Carolanne Goldner",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "streamline synergistic e-commerce"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 382
      }
    }
  }
]
```