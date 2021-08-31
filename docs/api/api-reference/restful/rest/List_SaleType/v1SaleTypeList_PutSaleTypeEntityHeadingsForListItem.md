---
title: PUT List/SaleType/Items/{id}/Headings
id: v1SaleTypeList_PutSaleTypeEntityHeadingsForListItem
---

# PUT List/SaleType/Items/{id}/Headings

```http
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
```

Saves headings for the SaleTypeEntity list's item.

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
PUT /api/v1/List/SaleType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 524,
    "Name": "Baumbach-Hettinger",
    "ToolTip": "Et neque.",
    "Deleted": true,
    "Rank": 498,
    "Type": "sit",
    "ColorBlock": 577,
    "IconHint": "ullam",
    "Selected": false,
    "LastChanged": "2007-05-13T15:05:43.801119+02:00",
    "ChildItems": [
      {
        "Id": 316,
        "Name": "Schimmel, Bechtelar and West",
        "ToolTip": "Quis suscipit aliquam et placeat ipsum aut.",
        "Deleted": false,
        "Rank": 401,
        "Type": "provident",
        "ColorBlock": 210,
        "IconHint": "expedita",
        "Selected": true,
        "LastChanged": "2016-02-12T15:05:43.8021246+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorem",
        "StyleHint": "iusto",
        "Hidden": true,
        "FullName": "Miss Orion Murazik"
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "nostrum",
    "Hidden": true,
    "FullName": "Deron Rutherford"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 883,
    "Name": "Bosco Group",
    "ToolTip": "Consequatur odit eum reiciendis maxime.",
    "Deleted": true,
    "Rank": 623,
    "Type": "dicta",
    "ColorBlock": 170,
    "IconHint": "quaerat",
    "Selected": true,
    "LastChanged": "2016-12-23T15:05:43.8031229+01:00",
    "ChildItems": [
      {
        "Id": 589,
        "Name": "Howell, Koepp and Bechtelar",
        "ToolTip": "Dolores laborum non eveniet.",
        "Deleted": false,
        "Rank": 973,
        "Type": "qui",
        "ColorBlock": 304,
        "IconHint": "neque",
        "Selected": false,
        "LastChanged": "2017-01-26T15:05:43.8041254+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eveniet",
        "StyleHint": "commodi",
        "Hidden": true,
        "FullName": "Geraldine Nolan",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 989
          }
        }
      }
    ],
    "ExtraInfo": "voluptate",
    "StyleHint": "dolorum",
    "Hidden": false,
    "FullName": "Kathryne Batz",
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
        "FieldLength": 992
      }
    }
  }
]
```