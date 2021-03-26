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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 375,
    "Name": "Mueller, Goodwin and Feeney",
    "ToolTip": "Quam quibusdam velit.",
    "Deleted": true,
    "Rank": 620,
    "Type": "illo",
    "ColorBlock": 269,
    "IconHint": "odio",
    "Selected": false,
    "LastChanged": "2021-01-04T09:41:00.3313819+01:00",
    "ChildItems": [
      {
        "Id": 488,
        "Name": "Huel-Kemmer",
        "ToolTip": "Ut facere consequatur autem expedita officiis.",
        "Deleted": true,
        "Rank": 504,
        "Type": "veniam",
        "ColorBlock": 512,
        "IconHint": "soluta",
        "Selected": true,
        "LastChanged": "2017-11-18T09:41:00.3313819+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ullam",
        "StyleHint": "rem",
        "Hidden": true,
        "FullName": "Camille Reichert"
      }
    ],
    "ExtraInfo": "necessitatibus",
    "StyleHint": "atque",
    "Hidden": false,
    "FullName": "Vicente Klocko"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 665,
    "Name": "Cartwright-McDermott",
    "ToolTip": "Sunt debitis doloribus ducimus.",
    "Deleted": false,
    "Rank": 33,
    "Type": "aut",
    "ColorBlock": 458,
    "IconHint": "aliquam",
    "Selected": false,
    "LastChanged": "1995-08-23T09:41:00.3323815+02:00",
    "ChildItems": [
      {
        "Id": 456,
        "Name": "Adams LLC",
        "ToolTip": "Tempora quia fugit eligendi unde odit.",
        "Deleted": true,
        "Rank": 939,
        "Type": "perferendis",
        "ColorBlock": 769,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2019-08-08T09:41:00.3323815+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "corrupti",
        "StyleHint": "non",
        "Hidden": false,
        "FullName": "Kenyatta Gibson",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 242
          }
        }
      }
    ],
    "ExtraInfo": "quas",
    "StyleHint": "excepturi",
    "Hidden": true,
    "FullName": "Lysanne Tremblay I",
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
        "FieldLength": 873
      }
    }
  }
]
```