---
title: PUT List/SelectionCategory/Items/{id}/Headings
id: v1SelectionCategoryList_PutSelectionCategoryHeadingsForListItem
---

# PUT List/SelectionCategory/Items/{id}/Headings

```http
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
```

Saves headings for the SelectionCategory list's item.

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
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 114,
    "Name": "Kuhn Inc and Sons",
    "ToolTip": "Consequatur officiis corporis pariatur tempora.",
    "Deleted": true,
    "Rank": 510,
    "Type": "tempore",
    "ColorBlock": 726,
    "IconHint": "nisi",
    "Selected": false,
    "LastChanged": "2020-12-21T09:41:00.7563871+01:00",
    "ChildItems": [
      {
        "Id": 746,
        "Name": "Zulauf, Kuhn and Bergnaum",
        "ToolTip": "Qui deserunt et laudantium accusantium dolorum.",
        "Deleted": false,
        "Rank": 483,
        "Type": "perspiciatis",
        "ColorBlock": 606,
        "IconHint": "quia",
        "Selected": true,
        "LastChanged": "2010-07-11T09:41:00.7563871+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quibusdam",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Arno Kuhic"
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "totam",
    "Hidden": false,
    "FullName": "Maurice Buckridge"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 477,
    "Name": "Price Inc and Sons",
    "ToolTip": "Sed officia alias dignissimos ipsa.",
    "Deleted": true,
    "Rank": 925,
    "Type": "delectus",
    "ColorBlock": 645,
    "IconHint": "consequatur",
    "Selected": false,
    "LastChanged": "2013-09-20T09:41:00.7573875+02:00",
    "ChildItems": [
      {
        "Id": 146,
        "Name": "Bartell, Nolan and Lubowitz",
        "ToolTip": "Similique veniam praesentium.",
        "Deleted": false,
        "Rank": 686,
        "Type": "facere",
        "ColorBlock": 536,
        "IconHint": "commodi",
        "Selected": true,
        "LastChanged": "2003-02-23T09:41:00.7583912+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "nihil",
        "Hidden": true,
        "FullName": "Miss Kieran Shields",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 930
          }
        }
      }
    ],
    "ExtraInfo": "animi",
    "StyleHint": "corporis",
    "Hidden": true,
    "FullName": "Marianne Considine",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline enterprise ROI"
        },
        "FieldType": "System.String",
        "FieldLength": 390
      }
    }
  }
]
```