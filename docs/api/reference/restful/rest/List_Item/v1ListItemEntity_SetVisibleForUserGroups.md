---
title: PUT List/{id}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroups
---

# PUT List/{id}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for

| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 220,
    "Name": "Pouros LLC",
    "ToolTip": "Cum tempora harum quos voluptas et ut non.",
    "Deleted": false,
    "Rank": 69,
    "Type": "nihil",
    "ColorBlock": 969,
    "IconHint": "quidem",
    "Selected": true,
    "LastChanged": "2015-03-30T11:10:53.8882129+02:00",
    "ChildItems": [
      {
        "Id": 934,
        "Name": "Rodriguez-Lesch",
        "ToolTip": "Rerum libero ut saepe rem.",
        "Deleted": false,
        "Rank": 412,
        "Type": "magnam",
        "ColorBlock": 770,
        "IconHint": "ex",
        "Selected": false,
        "LastChanged": "2001-03-03T11:10:53.8882129+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quibusdam",
        "StyleHint": "ut",
        "Hidden": true,
        "FullName": "Tanya Wiegand"
      }
    ],
    "ExtraInfo": "impedit",
    "StyleHint": "non",
    "Hidden": true,
    "FullName": "Abelardo Morar PhD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 191,
    "Name": "Funk Group",
    "ToolTip": "Velit sed hic voluptatum maxime.",
    "Deleted": true,
    "Rank": 544,
    "Type": "illo",
    "ColorBlock": 778,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "2011-02-06T11:10:53.8892151+01:00",
    "ChildItems": [
      {
        "Id": 137,
        "Name": "Pagac-Thiel",
        "ToolTip": "Eum exercitationem perspiciatis.",
        "Deleted": false,
        "Rank": 520,
        "Type": "iusto",
        "ColorBlock": 374,
        "IconHint": "tempora",
        "Selected": true,
        "LastChanged": "2008-07-17T11:10:53.8892151+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "temporibus",
        "StyleHint": "est",
        "Hidden": true,
        "FullName": "Royal Kemmer DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 94
          }
        }
      }
    ],
    "ExtraInfo": "architecto",
    "StyleHint": "quis",
    "Hidden": false,
    "FullName": "Assunta Thomas Lesch I",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 962
      }
    }
  }
]
```
