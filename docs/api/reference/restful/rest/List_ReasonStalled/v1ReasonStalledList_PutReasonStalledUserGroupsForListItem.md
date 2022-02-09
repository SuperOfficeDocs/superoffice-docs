---
title: PUT List/ReasonStalled/Items/{id}/UserGroups
id: v1ReasonStalledList_PutReasonStalledUserGroupsForListItem
---

# PUT List/ReasonStalled/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonStalled list's item.

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
PUT /api/v1/List/ReasonStalled/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 814,
    "Name": "Green, Rowe and Howell",
    "ToolTip": "Quos voluptatem error aliquid doloribus.",
    "Deleted": false,
    "Rank": 723,
    "Type": "aliquid",
    "ColorBlock": 995,
    "IconHint": "doloribus",
    "Selected": true,
    "LastChanged": "1996-12-25T18:25:52.1680187+01:00",
    "ChildItems": [
      {
        "Id": 232,
        "Name": "Jewess-Rippin",
        "ToolTip": "Ut accusantium voluptatem excepturi magnam.",
        "Deleted": true,
        "Rank": 952,
        "Type": "aut",
        "ColorBlock": 611,
        "IconHint": "eos",
        "Selected": true,
        "LastChanged": "2021-09-06T18:25:52.1680187+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ex",
        "StyleHint": "voluptatibus",
        "Hidden": true,
        "FullName": "Justice Walker"
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Golden Johns I"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 904,
    "Name": "Hirthe, Graham and Bernier",
    "ToolTip": "Non aliquam eum non magni assumenda consequatur.",
    "Deleted": false,
    "Rank": 929,
    "Type": "aut",
    "ColorBlock": 49,
    "IconHint": "accusamus",
    "Selected": false,
    "LastChanged": "2010-02-01T18:25:52.1690195+01:00",
    "ChildItems": [
      {
        "Id": 143,
        "Name": "Robel, Pfannerstill and Schuppe",
        "ToolTip": "Enim ipsa est perferendis vel et.",
        "Deleted": false,
        "Rank": 804,
        "Type": "quia",
        "ColorBlock": 860,
        "IconHint": "animi",
        "Selected": true,
        "LastChanged": "2004-03-28T18:25:52.1690195+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "voluptatum",
        "Hidden": true,
        "FullName": "Erna Hoeger",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 630
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "perspiciatis",
    "Hidden": true,
    "FullName": "Miss Tyrese Schaden",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "productize bricks-and-clicks infomediaries"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 190
      }
    }
  }
]
```