---
title: PUT List/Priority/Items/{id}/UserGroups
uid: v1PriorityList_PutPriorityUserGroupsForListItem
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

OK

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

## Sample request

```http!
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 27,
    "Name": "Fritsch-Beatty",
    "ToolTip": "Fuga dolores repellat aliquam.",
    "Deleted": true,
    "Rank": 221,
    "Type": "tenetur",
    "ColorBlock": 161,
    "IconHint": "ullam",
    "Selected": true,
    "LastChanged": "2020-07-29T11:10:54.3989027+02:00",
    "ChildItems": [
      {
        "Id": 988,
        "Name": "Watsica LLC",
        "ToolTip": "Autem et eaque quo excepturi tempore.",
        "Deleted": true,
        "Rank": 262,
        "Type": "vero",
        "ColorBlock": 914,
        "IconHint": "dolorem",
        "Selected": false,
        "LastChanged": "2016-12-08T11:10:54.3989027+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "occaecati",
        "StyleHint": "odio",
        "Hidden": true,
        "FullName": "Blanche Gibson"
      }
    ],
    "ExtraInfo": "mollitia",
    "StyleHint": "dolorem",
    "Hidden": false,
    "FullName": "Margaretta Murazik"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 97,
    "Name": "O'Kon-Pfannerstill",
    "ToolTip": "Rem aut et.",
    "Deleted": true,
    "Rank": 719,
    "Type": "ad",
    "ColorBlock": 13,
    "IconHint": "unde",
    "Selected": false,
    "LastChanged": "1995-12-28T11:10:54.3999023+01:00",
    "ChildItems": [
      {
        "Id": 855,
        "Name": "Dibbert LLC",
        "ToolTip": "Quidem praesentium ut.",
        "Deleted": false,
        "Rank": 955,
        "Type": "nihil",
        "ColorBlock": 698,
        "IconHint": "velit",
        "Selected": false,
        "LastChanged": "2011-12-03T11:10:54.3999023+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perferendis",
        "StyleHint": "ab",
        "Hidden": false,
        "FullName": "Jerry Ritchie",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 24
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "magni",
    "Hidden": false,
    "FullName": "Madison Larson III",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 674
      }
    }
  }
]
```
