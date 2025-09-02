---
title: GET List/ProductCategory/Items/{id}/UserGroups
uid: v1ProductCategoryList_GetProductCategoryUserGroupsForListItem
generated: true
content_type: reference
---

# GET List/ProductCategory/Items/{id}/UserGroups

```http
GET /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
```

Gets user groups visible for the ProductCategory list's item.


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
GET /api/v1/List/ProductCategory/Items/{itemId}/UserGroups
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
    "Id": 835,
    "Name": "Ferry, Luettgen and Jakubowski",
    "ToolTip": "At nesciunt necessitatibus sed.",
    "Deleted": false,
    "Rank": 484,
    "Type": "possimus",
    "ColorBlock": 335,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2000-01-17T03:47:00.7224209+01:00",
    "ChildItems": [
      {
        "Id": 643,
        "Name": "Sanford, Koch and Lesch",
        "ToolTip": "Et quasi.",
        "Deleted": false,
        "Rank": 631,
        "Type": "maxime",
        "ColorBlock": 505,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2009-10-04T03:47:00.7224209+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Elna Hilll II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 515
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "omnis",
    "Hidden": false,
    "FullName": "Adriel Carter",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 173
      }
    }
  }
]
```