---
title: PUT List/ProductCategory/Items/{id}/UserGroups
id: v1ProductCategoryList_PutProductCategoryUserGroupsForListItem
---

# PUT List/ProductCategory/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProductCategory list's item.

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
PUT /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 42,
    "Name": "Beatty-Aufderhar",
    "ToolTip": "Tempore assumenda facere.",
    "Deleted": true,
    "Rank": 844,
    "Type": "cupiditate",
    "ColorBlock": 321,
    "IconHint": "fugit",
    "Selected": true,
    "LastChanged": "2003-08-16T18:25:51.9982128+02:00",
    "ChildItems": [
      {
        "Id": 25,
        "Name": "Turcotte, Huels and Turcotte",
        "ToolTip": "Animi nostrum velit nesciunt.",
        "Deleted": true,
        "Rank": 693,
        "Type": "et",
        "ColorBlock": 797,
        "IconHint": "ratione",
        "Selected": true,
        "LastChanged": "2006-01-26T18:25:51.9982128+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laborum",
        "StyleHint": "corporis",
        "Hidden": true,
        "FullName": "Alyce Ankunding"
      }
    ],
    "ExtraInfo": "minus",
    "StyleHint": "quia",
    "Hidden": true,
    "FullName": "Kennith Herman"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 640,
    "Name": "Little Inc and Sons",
    "ToolTip": "Quia quis mollitia ut id.",
    "Deleted": false,
    "Rank": 318,
    "Type": "quia",
    "ColorBlock": 605,
    "IconHint": "in",
    "Selected": false,
    "LastChanged": "1996-08-18T18:25:51.9992125+02:00",
    "ChildItems": [
      {
        "Id": 959,
        "Name": "Bode, Crist and Streich",
        "ToolTip": "Nesciunt porro ab voluptatem eos aliquid.",
        "Deleted": true,
        "Rank": 738,
        "Type": "porro",
        "ColorBlock": 812,
        "IconHint": "perspiciatis",
        "Selected": false,
        "LastChanged": "2012-09-12T18:25:51.9992125+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "ea",
        "Hidden": true,
        "FullName": "Ken Williamson",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 323
          }
        }
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "iste",
    "Hidden": false,
    "FullName": "Dejon Kuphal",
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
        "FieldLength": 579
      }
    }
  }
]
```