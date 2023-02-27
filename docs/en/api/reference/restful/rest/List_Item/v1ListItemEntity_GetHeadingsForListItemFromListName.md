---
title: GET List/{udListDefinitionName}/Items/{id}/Headings
uid: v1ListItemEntity_GetHeadingsForListItemFromListName
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
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings?showDeleted=False
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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 966,
    "Name": "Hodkiewicz-Gaylord",
    "ToolTip": "Aperiam et ducimus modi quae et veritatis et.",
    "Deleted": false,
    "Rank": 21,
    "Type": "dolorem",
    "ColorBlock": 23,
    "IconHint": "laboriosam",
    "Selected": true,
    "LastChanged": "2003-08-18T14:19:11.1012251+02:00",
    "ChildItems": [
      {
        "Id": 546,
        "Name": "Wolf Inc and Sons",
        "ToolTip": "Sint eos ut.",
        "Deleted": false,
        "Rank": 794,
        "Type": "voluptas",
        "ColorBlock": 727,
        "IconHint": "sit",
        "Selected": false,
        "LastChanged": "1996-12-21T14:19:11.1012251+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quod",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Zander Jovany Haag PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 111
          }
        }
      }
    ],
    "ExtraInfo": "dolore",
    "StyleHint": "aperiam",
    "Hidden": true,
    "FullName": "Kayli Eli McCullough V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 669
      }
    }
  }
]
```