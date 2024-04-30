---
title: PUT List/Business/Items/{id}/UserGroups
uid: v1BusinessList_PutBusinessUserGroupsForListItem
generated: true
---

# PUT List/Business/Items/{id}/UserGroups

```http
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
```

Saves user groups visible for the Business list's item.


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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 162,
    "Name": "Luettgen-Kulas",
    "ToolTip": "Cupiditate eligendi odit alias sit totam.",
    "Deleted": false,
    "Rank": 724,
    "Type": "quidem",
    "ColorBlock": 8,
    "IconHint": "labore",
    "Selected": false,
    "LastChanged": "2000-02-09T11:44:42.9294253+01:00",
    "ChildItems": [
      {
        "Id": 744,
        "Name": "Nikolaus LLC",
        "ToolTip": "Necessitatibus totam.",
        "Deleted": false,
        "Rank": 403,
        "Type": "voluptas",
        "ColorBlock": 975,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "2012-03-08T11:44:42.9294253+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "delectus",
        "Hidden": true,
        "FullName": "Lauriane Micaela Becker DDS"
      }
    ],
    "ExtraInfo": "maxime",
    "StyleHint": "ab",
    "Hidden": false,
    "FullName": "Marcelle Barrows"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 635,
    "Name": "Feest, Leannon and Gaylord",
    "ToolTip": "Voluptate iusto quidem officiis accusantium expedita enim.",
    "Deleted": false,
    "Rank": 152,
    "Type": "omnis",
    "ColorBlock": 387,
    "IconHint": "similique",
    "Selected": true,
    "LastChanged": "2021-10-03T11:44:42.9294253+02:00",
    "ChildItems": [
      {
        "Id": 797,
        "Name": "Harber-Leuschke",
        "ToolTip": "Quia quia sunt.",
        "Deleted": true,
        "Rank": 491,
        "Type": "corporis",
        "ColorBlock": 268,
        "IconHint": "unde",
        "Selected": false,
        "LastChanged": "2015-06-17T11:44:42.9294253+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ratione",
        "StyleHint": "amet",
        "Hidden": true,
        "FullName": "Ardella Fay DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 143
          }
        }
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "aliquid",
    "Hidden": false,
    "FullName": "Ms. Krista Mariam Leffler",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 298
      }
    }
  }
]
```