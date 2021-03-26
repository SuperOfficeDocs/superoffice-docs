---
title: GET List/{udListDefinitionName}/Items/{id}/Headings
id: v1ListItemEntity_GetHeadingsForListItemFromListName
---

# GET List/{udListDefinitionName}/Items/{id}/Headings

```http
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
```

Gets a selectable MDO list of the headings for this list item






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to delete the items from. **Required** |
| listItemId | int32 | The id of the list item **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| showDeleted | bool |  Set to true if you want deleted headings |

```http
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings?showDeleted=True
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
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 492,
    "Name": "Stracke LLC",
    "ToolTip": "Quia sit facilis aperiam.",
    "Deleted": true,
    "Rank": 610,
    "Type": "facilis",
    "ColorBlock": 334,
    "IconHint": "omnis",
    "Selected": true,
    "LastChanged": "2019-11-06T09:41:00.1423609+01:00",
    "ChildItems": [
      {
        "Id": 456,
        "Name": "Lynch, O'Reilly and Schumm",
        "ToolTip": "Eum incidunt.",
        "Deleted": true,
        "Rank": 361,
        "Type": "quisquam",
        "ColorBlock": 158,
        "IconHint": "voluptates",
        "Selected": true,
        "LastChanged": "2008-10-11T09:41:00.1433617+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "veritatis",
        "Hidden": false,
        "FullName": "Allene Considine",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "target cutting-edge applications"
            },
            "FieldType": "System.Int32",
            "FieldLength": 275
          }
        }
      }
    ],
    "ExtraInfo": "odit",
    "StyleHint": "officia",
    "Hidden": true,
    "FullName": "Colby Skiles",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "optimize world-class portals"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 471
      }
    }
  }
]
```