---
title: PUT List/PaymentType/Items/{id}/UserGroups
id: v1PaymentTypeList_PutPaymentTypeUserGroupsForListItem
---

# PUT List/PaymentType/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentType list's item.

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
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 324,
    "Name": "Murphy, Krajcik and Oberbrunner",
    "ToolTip": "Dolorem consequatur.",
    "Deleted": true,
    "Rank": 878,
    "Type": "iste",
    "ColorBlock": 363,
    "IconHint": "dolore",
    "Selected": true,
    "LastChanged": "2015-12-30T15:05:43.5600799+01:00",
    "ChildItems": [
      {
        "Id": 156,
        "Name": "Roberts, Hackett and Goodwin",
        "ToolTip": "Corporis qui adipisci nisi.",
        "Deleted": false,
        "Rank": 456,
        "Type": "excepturi",
        "ColorBlock": 141,
        "IconHint": "expedita",
        "Selected": true,
        "LastChanged": "1998-07-31T15:05:43.5610799+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolor",
        "StyleHint": "dolorem",
        "Hidden": true,
        "FullName": "Helen Cassin"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Heath Cummerata"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 81,
    "Name": "Boehm Inc and Sons",
    "ToolTip": "Ut eligendi error aut officia quas.",
    "Deleted": true,
    "Rank": 786,
    "Type": "magni",
    "ColorBlock": 4,
    "IconHint": "alias",
    "Selected": false,
    "LastChanged": "1997-09-03T15:05:43.5620794+02:00",
    "ChildItems": [
      {
        "Id": 960,
        "Name": "Oberbrunner-Boyer",
        "ToolTip": "Totam quia dolores quasi et est.",
        "Deleted": false,
        "Rank": 863,
        "Type": "nihil",
        "ColorBlock": 592,
        "IconHint": "quod",
        "Selected": false,
        "LastChanged": "1996-12-10T15:05:43.5620794+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "numquam",
        "StyleHint": "quidem",
        "Hidden": false,
        "FullName": "Leatha Purdy DDS",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 988
          }
        }
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Emmanuel Bailey",
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
        "FieldLength": 578
      }
    }
  }
]
```