---
title: GET List/{id}/Items/{id}/UserGroups
uid: v1ListItemEntity_GetVisibleForUserGroups
---

# GET List/{id}/Items/{id}/UserGroups

```http
GET /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
```

List of User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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
GET /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 160,
    "Name": "Ziemann LLC",
    "ToolTip": "Nihil quam expedita dolorem rerum vel.",
    "Deleted": true,
    "Rank": 245,
    "Type": "ullam",
    "ColorBlock": 769,
    "IconHint": "distinctio",
    "Selected": false,
    "LastChanged": "2015-11-12T14:19:11.0855578+01:00",
    "ChildItems": [
      {
        "Id": 18,
        "Name": "Kshlerin-Ebert",
        "ToolTip": "Aut dolores illo recusandae maxime quae.",
        "Deleted": true,
        "Rank": 697,
        "Type": "consequatur",
        "ColorBlock": 95,
        "IconHint": "eum",
        "Selected": true,
        "LastChanged": "2004-01-01T14:19:11.0855578+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "blanditiis",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Deanna Crona",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 371
          }
        }
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "enim",
    "Hidden": true,
    "FullName": "Prof. Tomasa Stokes",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 802
      }
    }
  }
]
```