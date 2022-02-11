---
title: PUT List/ProductFamily/Items/{id}/Headings
id: v1ProductFamilyList_PutProductFamilyHeadingsForListItem
---

# PUT List/ProductFamily/Items/{id}/Headings

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/Headings
```

Saves headings for the ProductFamily list's item.

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
PUT /api/v1/List/ProductFamily/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 959,
    "Name": "Schiller, Shields and Bayer",
    "ToolTip": "Fugit nisi voluptas.",
    "Deleted": false,
    "Rank": 683,
    "Type": "autem",
    "ColorBlock": 366,
    "IconHint": "consequatur",
    "Selected": true,
    "LastChanged": "2010-06-20T18:25:52.0172124+02:00",
    "ChildItems": [
      {
        "Id": 956,
        "Name": "Jakubowski, Mitchell and Green",
        "ToolTip": "Est ipsam dolore non qui corrupti.",
        "Deleted": false,
        "Rank": 455,
        "Type": "magnam",
        "ColorBlock": 68,
        "IconHint": "itaque",
        "Selected": false,
        "LastChanged": "2003-09-03T18:25:52.0182122+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eum",
        "StyleHint": "harum",
        "Hidden": false,
        "FullName": "Karianne Considine"
      }
    ],
    "ExtraInfo": "ipsa",
    "StyleHint": "rerum",
    "Hidden": false,
    "FullName": "Gregory Durgan"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 739,
    "Name": "Stokes Inc and Sons",
    "ToolTip": "Tenetur atque aut illum et.",
    "Deleted": true,
    "Rank": 547,
    "Type": "fugit",
    "ColorBlock": 471,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2005-09-12T18:25:52.0192128+02:00",
    "ChildItems": [
      {
        "Id": 302,
        "Name": "Christiansen-Kemmer",
        "ToolTip": "Quia voluptas ipsa corrupti.",
        "Deleted": true,
        "Rank": 373,
        "Type": "eveniet",
        "ColorBlock": 637,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2008-03-08T18:25:52.0202124+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "modi",
        "Hidden": true,
        "FullName": "Lori O'Hara II",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 454
          }
        }
      }
    ],
    "ExtraInfo": "praesentium",
    "StyleHint": "saepe",
    "Hidden": false,
    "FullName": "Rashad Kohler",
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
        "FieldType": "System.String",
        "FieldLength": 447
      }
    }
  }
]
```