---
title: PUT List/PaymentTerm/Items/{id}/Headings
id: v1PaymentTermsList_PutPaymentTermHeadingsForListItem
---

# PUT List/PaymentTerm/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentTerm/Items/{itemId}/Headings
```

Saves headings for the PaymentTerm list's item.

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
PUT /api/v1/List/PaymentTerm/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 922,
    "Name": "Homenick-Bogan",
    "ToolTip": "Nesciunt rerum qui et vel.",
    "Deleted": false,
    "Rank": 43,
    "Type": "autem",
    "ColorBlock": 470,
    "IconHint": "hic",
    "Selected": false,
    "LastChanged": "2020-01-08T18:25:51.9302417+01:00",
    "ChildItems": [
      {
        "Id": 580,
        "Name": "Howell, Wiegand and Mante",
        "ToolTip": "Velit ut possimus dolores debitis consequatur.",
        "Deleted": true,
        "Rank": 794,
        "Type": "delectus",
        "ColorBlock": 882,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "1995-04-09T18:25:51.931244+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsa",
        "StyleHint": "minus",
        "Hidden": false,
        "FullName": "Alexzander Dickens"
      }
    ],
    "ExtraInfo": "incidunt",
    "StyleHint": "enim",
    "Hidden": false,
    "FullName": "Miss Justina Jones"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 335,
    "Name": "Cole-Douglas",
    "ToolTip": "Quam quae sint mollitia amet atque.",
    "Deleted": false,
    "Rank": 76,
    "Type": "nobis",
    "ColorBlock": 402,
    "IconHint": "quibusdam",
    "Selected": true,
    "LastChanged": "2000-08-10T18:25:51.9322398+02:00",
    "ChildItems": [
      {
        "Id": 609,
        "Name": "Volkman Inc and Sons",
        "ToolTip": "Quos quod quia et reprehenderit voluptatem.",
        "Deleted": true,
        "Rank": 905,
        "Type": "non",
        "ColorBlock": 969,
        "IconHint": "sequi",
        "Selected": true,
        "LastChanged": "1997-02-11T18:25:51.9322398+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Guiseppe Ziemann",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 764
          }
        }
      }
    ],
    "ExtraInfo": "suscipit",
    "StyleHint": "aspernatur",
    "Hidden": true,
    "FullName": "Haleigh Ernser",
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
        "FieldLength": 262
      }
    }
  }
]
```