---
title: PUT List/SaleType/Items/{id}/UserGroups
id: v1SaleTypeList_PutSaleTypeEntityUserGroupsForListItem
---

# PUT List/SaleType/Items/{id}/UserGroups

```http
PUT /api/v1/List/SaleType/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleTypeEntity list's item.

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
PUT /api/v1/List/SaleType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 650,
    "Name": "Hudson-Brakus",
    "ToolTip": "Mollitia voluptate culpa quis facilis consequatur.",
    "Deleted": false,
    "Rank": 871,
    "Type": "officia",
    "ColorBlock": 279,
    "IconHint": "assumenda",
    "Selected": false,
    "LastChanged": "1997-06-19T09:41:00.7373888+02:00",
    "ChildItems": [
      {
        "Id": 925,
        "Name": "DuBuque-Harber",
        "ToolTip": "Quis saepe minima cumque odit qui.",
        "Deleted": true,
        "Rank": 454,
        "Type": "ut",
        "ColorBlock": 420,
        "IconHint": "quo",
        "Selected": true,
        "LastChanged": "2020-08-07T09:41:00.7373888+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perferendis",
        "StyleHint": "architecto",
        "Hidden": true,
        "FullName": "Elijah Kerluke"
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "temporibus",
    "Hidden": false,
    "FullName": "Devante Gleason I"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 617,
    "Name": "Friesen-Sanford",
    "ToolTip": "Quia nam.",
    "Deleted": true,
    "Rank": 271,
    "Type": "repudiandae",
    "ColorBlock": 368,
    "IconHint": "blanditiis",
    "Selected": false,
    "LastChanged": "2006-07-12T09:41:00.7383866+02:00",
    "ChildItems": [
      {
        "Id": 682,
        "Name": "Christiansen-Ernser",
        "ToolTip": "Quia beatae.",
        "Deleted": true,
        "Rank": 244,
        "Type": "facere",
        "ColorBlock": 298,
        "IconHint": "ipsum",
        "Selected": false,
        "LastChanged": "2017-06-14T09:41:00.7393871+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facere",
        "StyleHint": "eum",
        "Hidden": true,
        "FullName": "Kattie Will",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 835
          }
        }
      }
    ],
    "ExtraInfo": "cupiditate",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Santina Armstrong",
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
        "FieldLength": 121
      }
    }
  }
]
```