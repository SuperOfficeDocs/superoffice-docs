---
title: PUT List/{id}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroups
generated: true
content_type: reference
---

# PUT List/{id}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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

## Request Body: userGroups 

The selectable user groups. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 58,
    "Name": "Lesch, Fay and Feil",
    "ToolTip": "Ad et.",
    "Deleted": false,
    "Rank": 480,
    "Type": "soluta",
    "ColorBlock": 140,
    "IconHint": "aspernatur",
    "Selected": false,
    "LastChanged": "2012-12-03T03:47:00.5505518+01:00",
    "ChildItems": [
      {
        "Id": 881,
        "Name": "Kilback Group",
        "ToolTip": "Ipsam sunt.",
        "Deleted": false,
        "Rank": 478,
        "Type": "reiciendis",
        "ColorBlock": 572,
        "IconHint": "recusandae",
        "Selected": true,
        "LastChanged": "2020-08-03T03:47:00.5505518+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "a",
        "StyleHint": "minima",
        "Hidden": true,
        "FullName": "Santiago Treutel"
      }
    ],
    "ExtraInfo": "nisi",
    "StyleHint": "iure",
    "Hidden": false,
    "FullName": "Winona Prudence Gerlach V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 920,
    "Name": "Rath LLC",
    "ToolTip": "Consequatur rerum similique animi perferendis.",
    "Deleted": true,
    "Rank": 983,
    "Type": "incidunt",
    "ColorBlock": 832,
    "IconHint": "veritatis",
    "Selected": false,
    "LastChanged": "2010-10-05T03:47:00.5505518+02:00",
    "ChildItems": [
      {
        "Id": 758,
        "Name": "Cassin LLC",
        "ToolTip": "Alias amet officia qui ab voluptatem facere voluptas.",
        "Deleted": false,
        "Rank": 132,
        "Type": "quidem",
        "ColorBlock": 127,
        "IconHint": "quam",
        "Selected": false,
        "LastChanged": "2007-07-26T03:47:00.5505518+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "aliquid",
        "Hidden": false,
        "FullName": "Theodore McDermott",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 659
          }
        }
      }
    ],
    "ExtraInfo": "eligendi",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Aurelio Rippin DDS",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  }
]
```