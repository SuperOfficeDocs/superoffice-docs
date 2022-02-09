---
title: PUT List/LegalBase/Items/{id}/Headings
id: v1LegalBaseList_PutLegalBaseHeadingsForListItem
---

# PUT List/LegalBase/Items/{id}/Headings

```http
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
```

Saves headings for the LegalBase list's item.

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
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 424,
    "Name": "Maggio-Shanahan",
    "ToolTip": "Esse praesentium qui nostrum et non.",
    "Deleted": true,
    "Rank": 393,
    "Type": "fugit",
    "ColorBlock": 229,
    "IconHint": "laudantium",
    "Selected": false,
    "LastChanged": "2000-06-30T18:25:51.879509+02:00",
    "ChildItems": [
      {
        "Id": 510,
        "Name": "Friesen Group",
        "ToolTip": "Placeat nam incidunt.",
        "Deleted": false,
        "Rank": 402,
        "Type": "doloremque",
        "ColorBlock": 896,
        "IconHint": "voluptas",
        "Selected": false,
        "LastChanged": "2016-08-18T18:25:51.879509+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "debitis",
        "StyleHint": "omnis",
        "Hidden": false,
        "FullName": "Phoebe Koepp"
      }
    ],
    "ExtraInfo": "totam",
    "StyleHint": "illum",
    "Hidden": false,
    "FullName": "Fausto Torp"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 482,
    "Name": "Herman LLC",
    "ToolTip": "Odio iste culpa vitae dolor nulla.",
    "Deleted": true,
    "Rank": 330,
    "Type": "molestias",
    "ColorBlock": 397,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "2000-02-09T18:25:51.8964853+01:00",
    "ChildItems": [
      {
        "Id": 273,
        "Name": "Smith Group",
        "ToolTip": "Inventore eaque quo vitae.",
        "Deleted": true,
        "Rank": 20,
        "Type": "qui",
        "ColorBlock": 780,
        "IconHint": "nobis",
        "Selected": false,
        "LastChanged": "2013-11-06T18:25:51.8964853+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "excepturi",
        "StyleHint": "magni",
        "Hidden": true,
        "FullName": "Jonathan Schiller",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 981
          }
        }
      }
    ],
    "ExtraInfo": "facilis",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Helene Mann",
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
        "FieldLength": 861
      }
    }
  }
]
```