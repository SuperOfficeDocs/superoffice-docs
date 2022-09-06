---
title: PUT List/ProjectType/Items/{id}/UserGroups
uid: v1ProjectTypeList_PutProjectTypeUserGroupsForListItem
---

# PUT List/ProjectType/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectType list's item.

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
PUT /api/v1/List/ProjectType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 279,
    "Name": "McGlynn-Spinka",
    "ToolTip": "Voluptatum eligendi.",
    "Deleted": false,
    "Rank": 384,
    "Type": "nihil",
    "ColorBlock": 215,
    "IconHint": "eius",
    "Selected": false,
    "LastChanged": "2016-10-10T11:10:54.4869298+02:00",
    "ChildItems": [
      {
        "Id": 851,
        "Name": "Skiles, Gislason and Considine",
        "ToolTip": "Quia ea id possimus.",
        "Deleted": false,
        "Rank": 356,
        "Type": "ea",
        "ColorBlock": 79,
        "IconHint": "minima",
        "Selected": false,
        "LastChanged": "2004-12-16T11:10:54.4869298+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "reprehenderit",
        "Hidden": false,
        "FullName": "Keaton Kemmer"
      }
    ],
    "ExtraInfo": "quos",
    "StyleHint": "nulla",
    "Hidden": false,
    "FullName": "Dr. Beryl Gusikowski III"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 367,
    "Name": "Harber-Zulauf",
    "ToolTip": "Qui necessitatibus accusamus dolores dignissimos illum aspernatur.",
    "Deleted": false,
    "Rank": 254,
    "Type": "omnis",
    "ColorBlock": 315,
    "IconHint": "possimus",
    "Selected": false,
    "LastChanged": "2009-08-29T11:10:54.48993+02:00",
    "ChildItems": [
      {
        "Id": 230,
        "Name": "Gusikowski-Block",
        "ToolTip": "Rem enim qui impedit tempore consectetur eum hic.",
        "Deleted": false,
        "Rank": 77,
        "Type": "atque",
        "ColorBlock": 542,
        "IconHint": "repudiandae",
        "Selected": true,
        "LastChanged": "2019-08-31T11:10:54.48993+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nesciunt",
        "StyleHint": "nemo",
        "Hidden": true,
        "FullName": "Santiago Eliseo Kiehn PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 357
          }
        }
      }
    ],
    "ExtraInfo": "dolore",
    "StyleHint": "laboriosam",
    "Hidden": false,
    "FullName": "Mr. Golda Altenwerth",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 667
      }
    }
  }
]
```
