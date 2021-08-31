---
title: PUT List/PaymentTerm/Items/{id}/UserGroups
id: v1PaymentTermsList_PutPaymentTermUserGroupsForListItem
---

# PUT List/PaymentTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentTerm list's item.

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
PUT /api/v1/List/PaymentTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 875,
    "Name": "Kunze, Kris and Weimann",
    "ToolTip": "Fugiat sit nam.",
    "Deleted": true,
    "Rank": 61,
    "Type": "quidem",
    "ColorBlock": 596,
    "IconHint": "omnis",
    "Selected": true,
    "LastChanged": "2005-02-11T15:05:43.5420797+01:00",
    "ChildItems": [
      {
        "Id": 495,
        "Name": "Osinski-Casper",
        "ToolTip": "Dolor voluptates ut deserunt autem itaque.",
        "Deleted": true,
        "Rank": 667,
        "Type": "ea",
        "ColorBlock": 55,
        "IconHint": "rerum",
        "Selected": false,
        "LastChanged": "2006-11-02T15:05:43.5430796+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "enim",
        "StyleHint": "occaecati",
        "Hidden": true,
        "FullName": "Hilbert Pfannerstill"
      }
    ],
    "ExtraInfo": "ad",
    "StyleHint": "minus",
    "Hidden": false,
    "FullName": "May Donnelly"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 13,
    "Name": "Robel Group",
    "ToolTip": "Accusantium quo rerum omnis debitis.",
    "Deleted": false,
    "Rank": 523,
    "Type": "non",
    "ColorBlock": 580,
    "IconHint": "non",
    "Selected": false,
    "LastChanged": "2001-02-15T15:05:43.5440795+01:00",
    "ChildItems": [
      {
        "Id": 502,
        "Name": "Purdy, McDermott and Mueller",
        "ToolTip": "Ut laboriosam natus numquam.",
        "Deleted": true,
        "Rank": 928,
        "Type": "omnis",
        "ColorBlock": 214,
        "IconHint": "totam",
        "Selected": true,
        "LastChanged": "2002-05-29T15:05:43.5440795+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "eum",
        "Hidden": true,
        "FullName": "Giuseppe Kulas",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "empower turn-key markets"
            },
            "FieldType": "System.String",
            "FieldLength": 465
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "sunt",
    "Hidden": true,
    "FullName": "Evie Pfannerstill",
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
        "FieldLength": 971
      }
    }
  }
]
```