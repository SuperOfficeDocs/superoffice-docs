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
    "Id": 189,
    "Name": "Lind-Grady",
    "ToolTip": "Illum ut.",
    "Deleted": false,
    "Rank": 585,
    "Type": "modi",
    "ColorBlock": 108,
    "IconHint": "provident",
    "Selected": false,
    "LastChanged": "1996-03-03T15:05:43.2675455+01:00",
    "ChildItems": [
      {
        "Id": 178,
        "Name": "Heidenreich-Kris",
        "ToolTip": "Omnis deserunt placeat in blanditiis et.",
        "Deleted": true,
        "Rank": 372,
        "Type": "odio",
        "ColorBlock": 292,
        "IconHint": "deserunt",
        "Selected": true,
        "LastChanged": "1995-11-21T15:05:43.2675455+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "nobis",
        "Hidden": false,
        "FullName": "Kylee Rohan"
      }
    ],
    "ExtraInfo": "non",
    "StyleHint": "quis",
    "Hidden": true,
    "FullName": "Kole Collins II"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 922,
    "Name": "Gusikowski LLC",
    "ToolTip": "Ratione ipsam deleniti qui aperiam consequuntur in.",
    "Deleted": true,
    "Rank": 488,
    "Type": "in",
    "ColorBlock": 346,
    "IconHint": "cupiditate",
    "Selected": false,
    "LastChanged": "2018-10-16T15:05:43.2685449+02:00",
    "ChildItems": [
      {
        "Id": 672,
        "Name": "D'Amore-Conroy",
        "ToolTip": "A laborum placeat aut recusandae commodi.",
        "Deleted": true,
        "Rank": 163,
        "Type": "ut",
        "ColorBlock": 313,
        "IconHint": "rerum",
        "Selected": true,
        "LastChanged": "2000-08-29T15:05:43.2685449+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Laury Prohaska",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 110
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "optio",
    "Hidden": true,
    "FullName": "Alexane Dickens",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "unleash B2B eyeballs"
        },
        "FieldType": "System.Int32",
        "FieldLength": 316
      }
    }
  }
]
```