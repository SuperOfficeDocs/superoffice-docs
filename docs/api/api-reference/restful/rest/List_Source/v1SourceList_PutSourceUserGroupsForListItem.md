---
title: PUT List/Source/Items/{id}/UserGroups
id: v1SourceList_PutSourceUserGroupsForListItem
---

# PUT List/Source/Items/{id}/UserGroups

```http
PUT /api/v1/List/Source/Items/{itemId}/UserGroups
```

Saves user groups visible for the Source list's item.

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
PUT /api/v1/List/Source/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 90,
    "Name": "Koss, McLaughlin and Harvey",
    "ToolTip": "Voluptatum eum delectus laborum sed.",
    "Deleted": false,
    "Rank": 207,
    "Type": "molestiae",
    "ColorBlock": 501,
    "IconHint": "in",
    "Selected": true,
    "LastChanged": "1995-10-15T18:25:52.2190197+02:00",
    "ChildItems": [
      {
        "Id": 408,
        "Name": "Friesen Group",
        "ToolTip": "Vel culpa rem vero quia.",
        "Deleted": false,
        "Rank": 560,
        "Type": "labore",
        "ColorBlock": 487,
        "IconHint": "voluptatum",
        "Selected": false,
        "LastChanged": "2013-06-08T18:25:52.2190197+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ducimus",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Karianne Russel V"
      }
    ],
    "ExtraInfo": "non",
    "StyleHint": "omnis",
    "Hidden": true,
    "FullName": "Jeff Swift"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 279,
    "Name": "Rippin Group",
    "ToolTip": "Molestiae fugit.",
    "Deleted": true,
    "Rank": 891,
    "Type": "aut",
    "ColorBlock": 783,
    "IconHint": "sit",
    "Selected": false,
    "LastChanged": "1996-10-29T18:25:52.2380179+01:00",
    "ChildItems": [
      {
        "Id": 357,
        "Name": "Cummerata, Mayert and Beer",
        "ToolTip": "Aperiam aut iste velit autem.",
        "Deleted": true,
        "Rank": 340,
        "Type": "assumenda",
        "ColorBlock": 596,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "1994-09-28T18:25:52.2520268+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "nam",
        "Hidden": false,
        "FullName": "Fausto Ondricka",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 588
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "magni",
    "Hidden": true,
    "FullName": "Mara Russel",
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
        "FieldLength": 969
      }
    }
  }
]
```