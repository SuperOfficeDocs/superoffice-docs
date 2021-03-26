---
title: GET List/{id}/Items/{id}/Headings
id: v1ListItemEntity_GetHeadings
---

# GET List/{id}/Items/{id}/Headings

```http
GET /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
```

Gets a selectable MDO list of the headings for this list item






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The id of the list item **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| showDeleted | bool |  Set to true if you want deleted headings |

```http
GET /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings?showDeleted=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 838,
    "Name": "O'Connell-Hettinger",
    "ToolTip": "Reiciendis eos.",
    "Deleted": true,
    "Rank": 702,
    "Type": "placeat",
    "ColorBlock": 649,
    "IconHint": "cupiditate",
    "Selected": true,
    "LastChanged": "2009-11-13T09:41:00.1383609+01:00",
    "ChildItems": [
      {
        "Id": 859,
        "Name": "Ratke-Johns",
        "ToolTip": "Itaque consequatur adipisci.",
        "Deleted": true,
        "Rank": 389,
        "Type": "et",
        "ColorBlock": 912,
        "IconHint": "consequuntur",
        "Selected": true,
        "LastChanged": "2004-10-02T09:41:00.1383609+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "esse",
        "StyleHint": "molestiae",
        "Hidden": true,
        "FullName": "Leora Kuhn",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 837
          }
        }
      }
    ],
    "ExtraInfo": "minus",
    "StyleHint": "at",
    "Hidden": false,
    "FullName": "Waino Fadel IV",
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
        "FieldLength": 744
      }
    }
  }
]
```