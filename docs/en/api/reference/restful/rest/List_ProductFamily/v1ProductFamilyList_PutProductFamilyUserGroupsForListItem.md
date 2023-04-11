---
title: PUT List/ProductFamily/Items/{id}/UserGroups
uid: v1ProductFamilyList_PutProductFamilyUserGroupsForListItem
---

# PUT List/ProductFamily/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductFamily list's item.


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
PUT /api/v1/List/ProductFamily/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 32,
    "Name": "Hodkiewicz, Towne and Littel",
    "ToolTip": "Itaque minima ut cupiditate repudiandae odit qui.",
    "Deleted": false,
    "Rank": 702,
    "Type": "quia",
    "ColorBlock": 202,
    "IconHint": "vel",
    "Selected": false,
    "LastChanged": "2018-06-14T15:29:31.4144765+02:00",
    "ChildItems": [
      {
        "Id": 311,
        "Name": "Barrows LLC",
        "ToolTip": "Quia quo facere sed.",
        "Deleted": false,
        "Rank": 253,
        "Type": "omnis",
        "ColorBlock": 933,
        "IconHint": "harum",
        "Selected": true,
        "LastChanged": "2004-08-27T15:29:31.4149777+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deserunt",
        "StyleHint": "ducimus",
        "Hidden": false,
        "FullName": "Miss Dale Heaney"
      }
    ],
    "ExtraInfo": "dolorum",
    "StyleHint": "rerum",
    "Hidden": true,
    "FullName": "Ruthie Kemmer"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 926,
    "Name": "Marvin, Mann and Douglas",
    "ToolTip": "Et quia quis enim omnis cupiditate temporibus nam.",
    "Deleted": true,
    "Rank": 579,
    "Type": "fuga",
    "ColorBlock": 174,
    "IconHint": "omnis",
    "Selected": true,
    "LastChanged": "1999-08-12T15:29:31.4159771+02:00",
    "ChildItems": [
      {
        "Id": 819,
        "Name": "Sipes Inc and Sons",
        "ToolTip": "Et minus omnis velit voluptas eum enim quas.",
        "Deleted": true,
        "Rank": 589,
        "Type": "suscipit",
        "ColorBlock": 719,
        "IconHint": "quidem",
        "Selected": false,
        "LastChanged": "2011-01-23T15:29:31.4159771+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "distinctio",
        "StyleHint": "vero",
        "Hidden": false,
        "FullName": "Maynard Will",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 601
          }
        }
      }
    ],
    "ExtraInfo": "magni",
    "StyleHint": "magnam",
    "Hidden": false,
    "FullName": "Mrs. Eleonore Zackary Buckridge",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 234
      }
    }
  }
]
```