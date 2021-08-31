---
title: PUT List/PaymentType/Items/{id}/Headings
id: v1PaymentTypeList_PutPaymentTypeHeadingsForListItem
---

# PUT List/PaymentType/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
```

Saves headings for the PaymentType list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 411,
    "Name": "McLaughlin-Schaefer",
    "ToolTip": "Modi dolores modi repellendus saepe.",
    "Deleted": true,
    "Rank": 952,
    "Type": "velit",
    "ColorBlock": 698,
    "IconHint": "ea",
    "Selected": true,
    "LastChanged": "2020-01-17T15:05:43.5640793+01:00",
    "ChildItems": [
      {
        "Id": 956,
        "Name": "Schmeler, Mohr and Hermann",
        "ToolTip": "Dolor sequi magni architecto.",
        "Deleted": false,
        "Rank": 680,
        "Type": "doloremque",
        "ColorBlock": 806,
        "IconHint": "quis",
        "Selected": true,
        "LastChanged": "1999-02-10T15:05:43.5640793+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "modi",
        "StyleHint": "aliquam",
        "Hidden": false,
        "FullName": "Jarrod Dare"
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "nihil",
    "Hidden": true,
    "FullName": "Fletcher Brakus"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 716,
    "Name": "Cassin, Langworth and Feil",
    "ToolTip": "Error veniam facere voluptas sit eum soluta.",
    "Deleted": true,
    "Rank": 450,
    "Type": "aut",
    "ColorBlock": 557,
    "IconHint": "velit",
    "Selected": false,
    "LastChanged": "2000-06-15T15:05:43.5670791+02:00",
    "ChildItems": [
      {
        "Id": 347,
        "Name": "Crona, Huels and Hickle",
        "ToolTip": "Libero sapiente.",
        "Deleted": true,
        "Rank": 153,
        "Type": "illum",
        "ColorBlock": 696,
        "IconHint": "quod",
        "Selected": false,
        "LastChanged": "2019-05-08T15:05:43.5680796+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fuga",
        "StyleHint": "omnis",
        "Hidden": true,
        "FullName": "Carolina Spencer",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "architect turn-key schemas"
            },
            "FieldType": "System.Int32",
            "FieldLength": 261
          }
        }
      }
    ],
    "ExtraInfo": "earum",
    "StyleHint": "ipsum",
    "Hidden": true,
    "FullName": "Linnie Legros",
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
        "FieldLength": 865
      }
    }
  }
]
```