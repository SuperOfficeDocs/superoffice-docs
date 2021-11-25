---
title: PUT List/ProductType/Items/{id}/Headings
id: v1ProductTypeList_PutProductTypeHeadingsForListItem
---

# PUT List/ProductType/Items/{id}/Headings

```http
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
```

Saves headings for the ProductType list's item.

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
PUT /api/v1/List/ProductType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 118,
    "Name": "Frami-Schaden",
    "ToolTip": "Non minima.",
    "Deleted": false,
    "Rank": 339,
    "Type": "ullam",
    "ColorBlock": 483,
    "IconHint": "vitae",
    "Selected": false,
    "LastChanged": "2004-12-15T18:25:52.0342124+01:00",
    "ChildItems": [
      {
        "Id": 248,
        "Name": "Zemlak Group",
        "ToolTip": "Eius eum dolor.",
        "Deleted": true,
        "Rank": 109,
        "Type": "in",
        "ColorBlock": 920,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "1995-02-12T18:25:52.0342124+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempora",
        "StyleHint": "eos",
        "Hidden": true,
        "FullName": "Selina Volkman"
      }
    ],
    "ExtraInfo": "autem",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Justine Herzog"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 419,
    "Name": "Zboncak LLC",
    "ToolTip": "Voluptate sunt dolores saepe id dolorem.",
    "Deleted": false,
    "Rank": 447,
    "Type": "voluptatum",
    "ColorBlock": 720,
    "IconHint": "sit",
    "Selected": false,
    "LastChanged": "2015-09-02T18:25:52.0364717+02:00",
    "ChildItems": [
      {
        "Id": 273,
        "Name": "Hickle LLC",
        "ToolTip": "Excepturi sunt illum.",
        "Deleted": true,
        "Rank": 906,
        "Type": "dolores",
        "ColorBlock": 259,
        "IconHint": "consectetur",
        "Selected": false,
        "LastChanged": "2020-07-30T18:25:52.0364717+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "suscipit",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Christa Crist",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 627
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "molestiae",
    "Hidden": false,
    "FullName": "Hailie Stehr",
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
        "FieldLength": 954
      }
    }
  }
]
```