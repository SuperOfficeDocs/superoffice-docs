---
title: PUT List/Category/Items/{id}/Headings
id: v1CategoryList_PutCategoryHeadingsForListItem
---

# PUT List/Category/Items/{id}/Headings

```http
PUT /api/v1/List/Category/Items/{itemId}/Headings
```

Saves headings for the Category list's item.

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
PUT /api/v1/List/Category/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 717,
    "Name": "Streich Inc and Sons",
    "ToolTip": "Possimus reprehenderit velit.",
    "Deleted": true,
    "Rank": 41,
    "Type": "et",
    "ColorBlock": 22,
    "IconHint": "veniam",
    "Selected": false,
    "LastChanged": "2002-03-28T18:25:51.6412945+01:00",
    "ChildItems": [
      {
        "Id": 225,
        "Name": "Wehner LLC",
        "ToolTip": "Praesentium atque dolorem culpa.",
        "Deleted": false,
        "Rank": 994,
        "Type": "veritatis",
        "ColorBlock": 801,
        "IconHint": "aliquid",
        "Selected": false,
        "LastChanged": "2011-03-29T18:25:51.6412945+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "iure",
        "Hidden": false,
        "FullName": "Loraine Corwin PhD"
      }
    ],
    "ExtraInfo": "consequuntur",
    "StyleHint": "alias",
    "Hidden": true,
    "FullName": "Selena Heathcote"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 875,
    "Name": "Jacobi, Smitham and Doyle",
    "ToolTip": "Eum laborum.",
    "Deleted": true,
    "Rank": 155,
    "Type": "et",
    "ColorBlock": 456,
    "IconHint": "perferendis",
    "Selected": true,
    "LastChanged": "2008-08-20T18:25:51.6422945+02:00",
    "ChildItems": [
      {
        "Id": 481,
        "Name": "Rempel, Ortiz and Cruickshank",
        "ToolTip": "Nihil nulla voluptas saepe assumenda et mollitia.",
        "Deleted": false,
        "Rank": 280,
        "Type": "optio",
        "ColorBlock": 219,
        "IconHint": "rerum",
        "Selected": false,
        "LastChanged": "2018-10-29T18:25:51.6422945+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tenetur",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Vita Bechtelar",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "engage extensible technologies"
            },
            "FieldType": "System.String",
            "FieldLength": 159
          }
        }
      }
    ],
    "ExtraInfo": "impedit",
    "StyleHint": "optio",
    "Hidden": false,
    "FullName": "Blaise Beier",
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
        "FieldType": "System.String",
        "FieldLength": 758
      }
    }
  }
]
```