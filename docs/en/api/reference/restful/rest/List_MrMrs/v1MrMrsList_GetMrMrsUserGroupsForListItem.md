---
title: GET List/MrMrs/Items/{id}/UserGroups
uid: v1MrMrsList_GetMrMrsUserGroupsForListItem
---

# GET List/MrMrs/Items/{id}/UserGroups

```http
GET /api/v1/List/MrMrs/Items/{itemId}/UserGroups
```

Gets user groups visible for the MrMrs list's item.


Calls the List agent service GetHeadings.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to get. **Required** |



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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/List/MrMrs/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 463,
    "Name": "Dach Group",
    "ToolTip": "Quibusdam et recusandae ex quos recusandae ab.",
    "Deleted": true,
    "Rank": 502,
    "Type": "fugit",
    "ColorBlock": 743,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2016-07-17T15:29:31.303478+02:00",
    "ChildItems": [
      {
        "Id": 879,
        "Name": "Witting Group",
        "ToolTip": "Enim omnis quia nobis amet et distinctio.",
        "Deleted": true,
        "Rank": 994,
        "Type": "ut",
        "ColorBlock": 280,
        "IconHint": "autem",
        "Selected": true,
        "LastChanged": "2015-03-29T15:29:31.303478+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nihil",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Domenic Howell",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 822
          }
        }
      }
    ],
    "ExtraInfo": "quis",
    "StyleHint": "inventore",
    "Hidden": true,
    "FullName": "Alisha Morissette",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 449
      }
    }
  }
]
```