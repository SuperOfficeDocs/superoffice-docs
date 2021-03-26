---
title: PUT List/Rating/Items/{id}/UserGroups
id: v1RatingList_PutSaleStageEntityUserGroupsForListItem
---

# PUT List/Rating/Items/{id}/UserGroups

```http
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleStageEntity list's item.

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
PUT /api/v1/List/Rating/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 249,
    "Name": "Strosin, Kautzer and Cartwright",
    "ToolTip": "Ad sunt.",
    "Deleted": true,
    "Rank": 582,
    "Type": "aspernatur",
    "ColorBlock": 133,
    "IconHint": "distinctio",
    "Selected": false,
    "LastChanged": "1998-11-03T09:41:00.6683874+01:00",
    "ChildItems": [
      {
        "Id": 64,
        "Name": "Emard, Kihn and Flatley",
        "ToolTip": "Dolores omnis quos quisquam repellendus illum.",
        "Deleted": false,
        "Rank": 178,
        "Type": "nostrum",
        "ColorBlock": 194,
        "IconHint": "dolor",
        "Selected": true,
        "LastChanged": "2016-04-29T09:41:00.6683874+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "pariatur",
        "Hidden": true,
        "FullName": "Stephanie McClure"
      }
    ],
    "ExtraInfo": "earum",
    "StyleHint": "ea",
    "Hidden": true,
    "FullName": "Sidney Hartmann"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 861,
    "Name": "Upton, VonRueden and Stanton",
    "ToolTip": "Cupiditate autem incidunt aut repellat dolorum.",
    "Deleted": true,
    "Rank": 17,
    "Type": "dicta",
    "ColorBlock": 188,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2012-09-02T09:41:00.6703869+02:00",
    "ChildItems": [
      {
        "Id": 656,
        "Name": "Legros LLC",
        "ToolTip": "Voluptas eaque.",
        "Deleted": true,
        "Rank": 916,
        "Type": "molestiae",
        "ColorBlock": 248,
        "IconHint": "quisquam",
        "Selected": false,
        "LastChanged": "2016-03-28T09:41:00.6703869+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "rerum",
        "Hidden": true,
        "FullName": "Milan Wisozk",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 436
          }
        }
      }
    ],
    "ExtraInfo": "ipsam",
    "StyleHint": "libero",
    "Hidden": true,
    "FullName": "Mrs. Jaiden Hodkiewicz",
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
        "FieldLength": 317
      }
    }
  }
]
```