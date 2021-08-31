---
title: PUT List/ConsentPurpose/Items/{id}/UserGroups
id: v1ConsentPurposeList_PutConsentPurposeUserGroupsForListItem
---

# PUT List/ConsentPurpose/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentPurpose list's item.

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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 485,
    "Name": "Beier, Blick and Lockman",
    "ToolTip": "Inventore culpa.",
    "Deleted": false,
    "Rank": 252,
    "Type": "neque",
    "ColorBlock": 624,
    "IconHint": "dolorum",
    "Selected": true,
    "LastChanged": "1996-01-01T15:05:43.3395395+01:00",
    "ChildItems": [
      {
        "Id": 910,
        "Name": "Stracke, Cremin and Bogisich",
        "ToolTip": "Ut placeat perspiciatis velit maiores qui pariatur.",
        "Deleted": true,
        "Rank": 637,
        "Type": "est",
        "ColorBlock": 118,
        "IconHint": "ullam",
        "Selected": false,
        "LastChanged": "1998-09-08T15:05:43.3395395+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quidem",
        "StyleHint": "nisi",
        "Hidden": false,
        "FullName": "Orval Schultz"
      }
    ],
    "ExtraInfo": "tempore",
    "StyleHint": "sed",
    "Hidden": false,
    "FullName": "Dion Krajcik"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 63,
    "Name": "Kihn, Cummerata and Zieme",
    "ToolTip": "Ut rem nam nihil inventore non.",
    "Deleted": true,
    "Rank": 670,
    "Type": "nobis",
    "ColorBlock": 57,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2003-08-07T15:05:43.3405403+02:00",
    "ChildItems": [
      {
        "Id": 382,
        "Name": "Bernhard, Keebler and Kuvalis",
        "ToolTip": "Omnis qui.",
        "Deleted": false,
        "Rank": 132,
        "Type": "id",
        "ColorBlock": 428,
        "IconHint": "sint",
        "Selected": true,
        "LastChanged": "2019-02-19T15:05:43.3405403+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quo",
        "StyleHint": "non",
        "Hidden": true,
        "FullName": "Laron Green",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 876
          }
        }
      }
    ],
    "ExtraInfo": "aperiam",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Carol Hodkiewicz",
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
        "FieldLength": 861
      }
    }
  }
]
```