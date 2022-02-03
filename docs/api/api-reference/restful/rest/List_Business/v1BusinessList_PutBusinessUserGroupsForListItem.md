---
title: PUT List/Business/Items/{id}/UserGroups
id: v1BusinessList_PutBusinessUserGroupsForListItem
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
PUT /api/v1/List/Business/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 648,
    "Name": "Dach-Olson",
    "ToolTip": "Minima facere.",
    "Deleted": false,
    "Rank": 610,
    "Type": "ullam",
    "ColorBlock": 606,
    "IconHint": "sequi",
    "Selected": true,
    "LastChanged": "2019-09-10T18:25:51.6222945+02:00",
    "ChildItems": [
      {
        "Id": 727,
        "Name": "Buckridge-Oberbrunner",
        "ToolTip": "Aperiam consequatur aut aliquid asperiores doloribus.",
        "Deleted": false,
        "Rank": 919,
        "Type": "commodi",
        "ColorBlock": 813,
        "IconHint": "unde",
        "Selected": false,
        "LastChanged": "2006-09-14T18:25:51.6222945+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illo",
        "StyleHint": "eaque",
        "Hidden": false,
        "FullName": "Declan Gutkowski"
      }
    ],
    "ExtraInfo": "aliquid",
    "StyleHint": "possimus",
    "Hidden": true,
    "FullName": "Mrs. Clementine O'Reilly"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 894,
    "Name": "Olson-Schneider",
    "ToolTip": "Unde sed non libero voluptas voluptatem vero.",
    "Deleted": false,
    "Rank": 826,
    "Type": "modi",
    "ColorBlock": 696,
    "IconHint": "quos",
    "Selected": false,
    "LastChanged": "2010-01-27T18:25:51.6232945+01:00",
    "ChildItems": [
      {
        "Id": 27,
        "Name": "Morissette-Feeney",
        "ToolTip": "Quia sed et non optio.",
        "Deleted": false,
        "Rank": 674,
        "Type": "ut",
        "ColorBlock": 684,
        "IconHint": "commodi",
        "Selected": false,
        "LastChanged": "2020-03-18T18:25:51.6232945+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "expedita",
        "StyleHint": "quaerat",
        "Hidden": true,
        "FullName": "Dr. Esta Davis",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 560
          }
        }
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "repellendus",
    "Hidden": true,
    "FullName": "Giovani Hilpert",
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
        "FieldLength": 186
      }
    }
  }
]
```