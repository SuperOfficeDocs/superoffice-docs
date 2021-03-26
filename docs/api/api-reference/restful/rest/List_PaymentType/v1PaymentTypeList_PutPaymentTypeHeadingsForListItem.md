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
    "Id": 682,
    "Name": "Beier Inc and Sons",
    "ToolTip": "Eligendi molestiae ut hic.",
    "Deleted": false,
    "Rank": 148,
    "Type": "corporis",
    "ColorBlock": 70,
    "IconHint": "aut",
    "Selected": true,
    "LastChanged": "2011-08-19T09:41:00.4983817+02:00",
    "ChildItems": [
      {
        "Id": 125,
        "Name": "Stanton LLC",
        "ToolTip": "Soluta quod.",
        "Deleted": false,
        "Rank": 317,
        "Type": "quia",
        "ColorBlock": 315,
        "IconHint": "veritatis",
        "Selected": true,
        "LastChanged": "1995-10-10T09:41:00.4983817+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sint",
        "StyleHint": "quia",
        "Hidden": true,
        "FullName": "Hubert Rice"
      }
    ],
    "ExtraInfo": "cumque",
    "StyleHint": "quia",
    "Hidden": true,
    "FullName": "Sofia Gaylord"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 644,
    "Name": "Stoltenberg-Heaney",
    "ToolTip": "Ab eveniet nisi sed.",
    "Deleted": true,
    "Rank": 374,
    "Type": "quo",
    "ColorBlock": 666,
    "IconHint": "ullam",
    "Selected": false,
    "LastChanged": "2002-10-31T09:41:00.4993817+01:00",
    "ChildItems": [
      {
        "Id": 341,
        "Name": "Ondricka, Witting and Windler",
        "ToolTip": "Labore inventore molestiae et eligendi dolorem ducimus.",
        "Deleted": false,
        "Rank": 1000,
        "Type": "itaque",
        "ColorBlock": 280,
        "IconHint": "autem",
        "Selected": true,
        "LastChanged": "2008-07-25T09:41:00.4993817+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "repudiandae",
        "Hidden": false,
        "FullName": "Cassidy Haag",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 503
          }
        }
      }
    ],
    "ExtraInfo": "voluptatem",
    "StyleHint": "tempore",
    "Hidden": false,
    "FullName": "Bell Hoeger",
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
        "FieldLength": 711
      }
    }
  }
]
```