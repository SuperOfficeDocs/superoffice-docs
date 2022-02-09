---
title: PUT List/Currency/Items/{id}/UserGroups
id: v1CurrencyList_PutCurrencyEntityUserGroupsForListItem
---

# PUT List/Currency/Items/{id}/UserGroups

```http
PUT /api/v1/List/Currency/Items/{itemId}/UserGroups
```

Saves user groups visible for the CurrencyEntity list's item.

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
PUT /api/v1/List/Currency/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 412,
    "Name": "Fahey, McKenzie and Schmeler",
    "ToolTip": "Error facere quae quia suscipit veritatis.",
    "Deleted": true,
    "Rank": 342,
    "Type": "quis",
    "ColorBlock": 701,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2004-04-18T18:25:51.782332+02:00",
    "ChildItems": [
      {
        "Id": 796,
        "Name": "Johns, Marvin and Jacobson",
        "ToolTip": "Aliquam vel temporibus qui velit.",
        "Deleted": false,
        "Rank": 592,
        "Type": "sed",
        "ColorBlock": 523,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "2016-10-26T18:25:51.782332+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestias",
        "StyleHint": "velit",
        "Hidden": false,
        "FullName": "Rosalinda Effertz"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "voluptatum",
    "Hidden": true,
    "FullName": "Lew Auer"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 608,
    "Name": "Jerde, Johnson and Gibson",
    "ToolTip": "Voluptates dolores ea.",
    "Deleted": true,
    "Rank": 590,
    "Type": "nobis",
    "ColorBlock": 32,
    "IconHint": "nesciunt",
    "Selected": false,
    "LastChanged": "2002-09-20T18:25:51.7852933+02:00",
    "ChildItems": [
      {
        "Id": 967,
        "Name": "Dooley Inc and Sons",
        "ToolTip": "Quia delectus.",
        "Deleted": true,
        "Rank": 390,
        "Type": "consequuntur",
        "ColorBlock": 166,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2000-07-05T18:25:51.7852933+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quo",
        "StyleHint": "hic",
        "Hidden": true,
        "FullName": "Savannah Bartoletti",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 380
          }
        }
      }
    ],
    "ExtraInfo": "ullam",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Graham Abbott",
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
        "FieldLength": 101
      }
    }
  }
]
```