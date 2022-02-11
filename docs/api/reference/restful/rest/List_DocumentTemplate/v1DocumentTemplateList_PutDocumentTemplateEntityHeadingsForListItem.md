---
title: PUT List/DocumentTemplate/Items/{id}/Headings
id: v1DocumentTemplateList_PutDocumentTemplateEntityHeadingsForListItem
---

# PUT List/DocumentTemplate/Items/{id}/Headings

```http
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/Headings
```

Saves headings for the DocumentTemplateEntity list's item.

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
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 623,
    "Name": "Herman, Barrows and Pacocha",
    "ToolTip": "Et ut eum ipsam.",
    "Deleted": false,
    "Rank": 688,
    "Type": "ea",
    "ColorBlock": 927,
    "IconHint": "sit",
    "Selected": false,
    "LastChanged": "2017-08-16T18:25:51.8404919+02:00",
    "ChildItems": [
      {
        "Id": 914,
        "Name": "Aufderhar-Auer",
        "ToolTip": "Ex aperiam dolor voluptatem doloribus.",
        "Deleted": false,
        "Rank": 1000,
        "Type": "nemo",
        "ColorBlock": 268,
        "IconHint": "sunt",
        "Selected": false,
        "LastChanged": "2013-12-15T18:25:51.8404919+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "officia",
        "StyleHint": "ipsam",
        "Hidden": false,
        "FullName": "Michelle Jaskolski DVM"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "neque",
    "Hidden": false,
    "FullName": "Alicia McKenzie"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 842,
    "Name": "Wilkinson-Pollich",
    "ToolTip": "Placeat laborum consequatur dolores.",
    "Deleted": false,
    "Rank": 285,
    "Type": "perferendis",
    "ColorBlock": 862,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2015-12-27T18:25:51.8424518+01:00",
    "ChildItems": [
      {
        "Id": 240,
        "Name": "Abshire-Klein",
        "ToolTip": "Atque itaque soluta eum harum optio dolores.",
        "Deleted": false,
        "Rank": 352,
        "Type": "a",
        "ColorBlock": 195,
        "IconHint": "saepe",
        "Selected": true,
        "LastChanged": "2004-05-22T18:25:51.8424518+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorum",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Arlie Terry",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 352
          }
        }
      }
    ],
    "ExtraInfo": "eius",
    "StyleHint": "atque",
    "Hidden": true,
    "FullName": "Janessa Romaguera",
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
        "FieldLength": 999
      }
    }
  }
]
```