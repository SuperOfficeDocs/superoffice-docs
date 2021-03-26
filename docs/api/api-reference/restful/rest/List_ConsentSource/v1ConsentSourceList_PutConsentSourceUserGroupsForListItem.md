---
title: PUT List/ConsentSource/Items/{id}/UserGroups
id: v1ConsentSourceList_PutConsentSourceUserGroupsForListItem
---

# PUT List/ConsentSource/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentSource list's item.

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
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 176,
    "Name": "Moen, Simonis and Steuber",
    "ToolTip": "Officiis atque nam ipsam et.",
    "Deleted": false,
    "Rank": 706,
    "Type": "totam",
    "ColorBlock": 535,
    "IconHint": "sit",
    "Selected": false,
    "LastChanged": "2010-01-06T09:41:00.2813684+01:00",
    "ChildItems": [
      {
        "Id": 165,
        "Name": "Wilkinson LLC",
        "ToolTip": "Aspernatur fugit sed.",
        "Deleted": true,
        "Rank": 779,
        "Type": "aut",
        "ColorBlock": 674,
        "IconHint": "amet",
        "Selected": false,
        "LastChanged": "2013-10-01T09:41:00.2823667+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "itaque",
        "StyleHint": "enim",
        "Hidden": true,
        "FullName": "Lolita Erdman"
      }
    ],
    "ExtraInfo": "fugiat",
    "StyleHint": "magni",
    "Hidden": false,
    "FullName": "Aidan Waelchi Jr."
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 712,
    "Name": "Hettinger-Marks",
    "ToolTip": "Deserunt veritatis culpa sed saepe aut quisquam.",
    "Deleted": true,
    "Rank": 107,
    "Type": "earum",
    "ColorBlock": 498,
    "IconHint": "nihil",
    "Selected": true,
    "LastChanged": "2004-01-03T09:41:00.2833739+01:00",
    "ChildItems": [
      {
        "Id": 688,
        "Name": "Kemmer-Hilll",
        "ToolTip": "Natus nobis dolorem aut distinctio voluptas.",
        "Deleted": false,
        "Rank": 201,
        "Type": "quasi",
        "ColorBlock": 437,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2001-10-12T09:41:00.2833739+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iure",
        "StyleHint": "distinctio",
        "Hidden": false,
        "FullName": "Rocky Swaniawski",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "innovate ubiquitous ROI"
            },
            "FieldType": "System.Int32",
            "FieldLength": 26
          }
        }
      }
    ],
    "ExtraInfo": "non",
    "StyleHint": "nostrum",
    "Hidden": true,
    "FullName": "Harold Ledner",
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
        "FieldLength": 553
      }
    }
  }
]
```