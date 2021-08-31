---
title: PUT List/ConsentSource/Items/{id}/UserGroups
id: v1ConsentSourceList_PutConsentSourceUserGroupsForListItem
---

# PUT List/ConsentSource/Items/{id}/UserGroups

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
```

Saves user groups visible for the ConsentSource list's item.

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
PUT /api/v1/List/ConsentSource/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 530,
    "Name": "Jones-Schoen",
    "ToolTip": "Numquam in.",
    "Deleted": true,
    "Rank": 178,
    "Type": "magnam",
    "ColorBlock": 304,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2007-05-12T15:05:43.3545126+02:00",
    "ChildItems": [
      {
        "Id": 71,
        "Name": "O'Connell-Osinski",
        "ToolTip": "Eos nesciunt.",
        "Deleted": true,
        "Rank": 381,
        "Type": "iste",
        "ColorBlock": 678,
        "IconHint": "incidunt",
        "Selected": true,
        "LastChanged": "2004-03-20T15:05:43.3545126+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "error",
        "StyleHint": "distinctio",
        "Hidden": true,
        "FullName": "Ernestine Wehner"
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "aliquid",
    "Hidden": false,
    "FullName": "Elsie Muller"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 383,
    "Name": "Kohler Group",
    "ToolTip": "Quia voluptas dignissimos quibusdam cumque soluta.",
    "Deleted": true,
    "Rank": 366,
    "Type": "nesciunt",
    "ColorBlock": 122,
    "IconHint": "molestiae",
    "Selected": false,
    "LastChanged": "1997-03-26T15:05:43.3555129+01:00",
    "ChildItems": [
      {
        "Id": 461,
        "Name": "Rohan, Johnson and Hauck",
        "ToolTip": "Laboriosam consequatur.",
        "Deleted": true,
        "Rank": 887,
        "Type": "sequi",
        "ColorBlock": 10,
        "IconHint": "sunt",
        "Selected": true,
        "LastChanged": "1999-12-03T15:05:43.3555129+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iste",
        "StyleHint": "ad",
        "Hidden": false,
        "FullName": "Ezequiel Stoltenberg",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 549
          }
        }
      }
    ],
    "ExtraInfo": "quod",
    "StyleHint": "ducimus",
    "Hidden": true,
    "FullName": "Markus Johnston",
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
        "FieldLength": 281
      }
    }
  }
]
```