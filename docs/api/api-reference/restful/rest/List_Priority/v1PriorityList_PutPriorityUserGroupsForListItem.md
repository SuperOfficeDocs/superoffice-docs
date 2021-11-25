---
title: PUT List/Priority/Items/{id}/UserGroups
id: v1PriorityList_PutPriorityUserGroupsForListItem
---

# PUT List/Priority/Items/{id}/UserGroups

```http
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
```

Saves user groups visible for the Priority list's item.

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
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 979,
    "Name": "Eichmann Group",
    "ToolTip": "Earum sit magni excepturi fuga sint placeat.",
    "Deleted": false,
    "Rank": 931,
    "Type": "quis",
    "ColorBlock": 808,
    "IconHint": "fugit",
    "Selected": true,
    "LastChanged": "2009-08-25T18:25:51.9832519+02:00",
    "ChildItems": [
      {
        "Id": 35,
        "Name": "Hammes Group",
        "ToolTip": "Sunt vel et.",
        "Deleted": false,
        "Rank": 282,
        "Type": "atque",
        "ColorBlock": 625,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2020-04-12T18:25:51.9832519+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "at",
        "StyleHint": "fugit",
        "Hidden": false,
        "FullName": "Savion Harber"
      }
    ],
    "ExtraInfo": "commodi",
    "StyleHint": "suscipit",
    "Hidden": false,
    "FullName": "Anahi Pollich"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 915,
    "Name": "Pfannerstill, Raynor and Cormier",
    "ToolTip": "Id aut beatae.",
    "Deleted": false,
    "Rank": 499,
    "Type": "velit",
    "ColorBlock": 314,
    "IconHint": "sequi",
    "Selected": true,
    "LastChanged": "1998-03-15T18:25:51.9842456+01:00",
    "ChildItems": [
      {
        "Id": 740,
        "Name": "Crona-Hamill",
        "ToolTip": "Blanditiis rem vero aut illo aliquam.",
        "Deleted": false,
        "Rank": 443,
        "Type": "deserunt",
        "ColorBlock": 421,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2019-04-26T18:25:51.9842456+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perspiciatis",
        "StyleHint": "laudantium",
        "Hidden": false,
        "FullName": "Tyreek Considine II",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 885
          }
        }
      }
    ],
    "ExtraInfo": "facilis",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Dario Frami",
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
        "FieldLength": 499
      }
    }
  }
]
```