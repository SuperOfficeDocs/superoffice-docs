---
title: PUT List/ProductType/Items/{id}/UserGroups
id: v1ProductTypeList_PutProductTypeUserGroupsForListItem
---

# PUT List/ProductType/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductType/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductType list's item.

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
PUT /api/v1/List/ProductType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 63,
    "Name": "Runolfsson-Conroy",
    "ToolTip": "Eos rerum.",
    "Deleted": true,
    "Rank": 991,
    "Type": "quasi",
    "ColorBlock": 441,
    "IconHint": "eum",
    "Selected": false,
    "LastChanged": "2010-06-13T18:25:52.0292124+02:00",
    "ChildItems": [
      {
        "Id": 290,
        "Name": "Cronin, Johnson and Quigley",
        "ToolTip": "Praesentium eaque maiores unde.",
        "Deleted": true,
        "Rank": 560,
        "Type": "in",
        "ColorBlock": 534,
        "IconHint": "facere",
        "Selected": true,
        "LastChanged": "2015-01-04T18:25:52.0302124+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Lupe Kulas"
      }
    ],
    "ExtraInfo": "natus",
    "StyleHint": "sed",
    "Hidden": true,
    "FullName": "Veda Schoen"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 395,
    "Name": "Koss LLC",
    "ToolTip": "Quod aperiam minus ut omnis.",
    "Deleted": true,
    "Rank": 438,
    "Type": "consequatur",
    "ColorBlock": 215,
    "IconHint": "perspiciatis",
    "Selected": false,
    "LastChanged": "2021-10-12T18:25:52.0322125+02:00",
    "ChildItems": [
      {
        "Id": 112,
        "Name": "Cormier-Powlowski",
        "ToolTip": "Quo distinctio eius et repudiandae culpa.",
        "Deleted": true,
        "Rank": 536,
        "Type": "necessitatibus",
        "ColorBlock": 144,
        "IconHint": "ipsam",
        "Selected": false,
        "LastChanged": "2013-07-05T18:25:52.0322125+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nostrum",
        "StyleHint": "modi",
        "Hidden": true,
        "FullName": "Dr. Nils Hahn",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 813
          }
        }
      }
    ],
    "ExtraInfo": "reiciendis",
    "StyleHint": "dolore",
    "Hidden": true,
    "FullName": "Marcellus Wintheiser",
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
        "FieldLength": 752
      }
    }
  }
]
```