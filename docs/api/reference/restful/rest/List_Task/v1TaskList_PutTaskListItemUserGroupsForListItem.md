---
title: PUT List/Task/Items/{id}/UserGroups
id: v1TaskList_PutTaskListItemUserGroupsForListItem
---

# PUT List/Task/Items/{id}/UserGroups

```http
PUT /api/v1/List/Task/Items/{itemId}/UserGroups
```

Saves user groups visible for the TaskListItem list's item.

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
PUT /api/v1/List/Task/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 703,
    "Name": "Cole, Kerluke and Stokes",
    "ToolTip": "Repellendus quos ut voluptatem quo placeat.",
    "Deleted": false,
    "Rank": 672,
    "Type": "rerum",
    "ColorBlock": 644,
    "IconHint": "ea",
    "Selected": false,
    "LastChanged": "1995-04-20T18:25:52.282637+02:00",
    "ChildItems": [
      {
        "Id": 214,
        "Name": "Hilpert-Leannon",
        "ToolTip": "Temporibus voluptate qui vel.",
        "Deleted": false,
        "Rank": 541,
        "Type": "natus",
        "ColorBlock": 802,
        "IconHint": "accusamus",
        "Selected": true,
        "LastChanged": "2009-05-25T18:25:52.282637+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ea",
        "StyleHint": "animi",
        "Hidden": true,
        "FullName": "Salvador Rempel"
      }
    ],
    "ExtraInfo": "deserunt",
    "StyleHint": "quibusdam",
    "Hidden": true,
    "FullName": "Ms. Talon Kuhic"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 909,
    "Name": "Kihn-Aufderhar",
    "ToolTip": "Ipsa eveniet illo voluptatem veritatis.",
    "Deleted": true,
    "Rank": 426,
    "Type": "quis",
    "ColorBlock": 395,
    "IconHint": "eligendi",
    "Selected": false,
    "LastChanged": "2010-09-01T18:25:52.2836371+02:00",
    "ChildItems": [
      {
        "Id": 435,
        "Name": "Beahan, Streich and Bartell",
        "ToolTip": "Quam omnis.",
        "Deleted": true,
        "Rank": 724,
        "Type": "eius",
        "ColorBlock": 734,
        "IconHint": "quae",
        "Selected": true,
        "LastChanged": "2002-08-27T18:25:52.2836371+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "velit",
        "Hidden": false,
        "FullName": "Nathanael Dicki",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 707
          }
        }
      }
    ],
    "ExtraInfo": "itaque",
    "StyleHint": "sint",
    "Hidden": true,
    "FullName": "Reinhold Stokes V",
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
        "FieldLength": 333
      }
    }
  }
]
```
