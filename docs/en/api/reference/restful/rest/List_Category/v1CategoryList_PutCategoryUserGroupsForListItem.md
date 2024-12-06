---
title: PUT List/Category/Items/{id}/UserGroups
uid: v1CategoryList_PutCategoryUserGroupsForListItem
generated: true
---

# PUT List/Category/Items/{id}/UserGroups

```http
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
```

Saves user groups visible for the Category list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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
PUT /api/v1/List/Category/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 713,
    "Name": "Stamm, Schumm and Collins",
    "ToolTip": "Eveniet ut sed quisquam sit repudiandae.",
    "Deleted": false,
    "Rank": 115,
    "Type": "at",
    "ColorBlock": 478,
    "IconHint": "sequi",
    "Selected": false,
    "LastChanged": "2024-05-19T10:18:00.9418629+02:00",
    "ChildItems": [
      {
        "Id": 757,
        "Name": "Towne Inc and Sons",
        "ToolTip": "Et quia consequatur sed non quo qui maiores.",
        "Deleted": true,
        "Rank": 975,
        "Type": "mollitia",
        "ColorBlock": 344,
        "IconHint": "exercitationem",
        "Selected": false,
        "LastChanged": "2003-03-11T10:18:00.9418629+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsum",
        "StyleHint": "voluptatem",
        "Hidden": true,
        "FullName": "Ms. Austyn Rebekah Doyle"
      }
    ],
    "ExtraInfo": "alias",
    "StyleHint": "qui",
    "Hidden": true,
    "FullName": "Isac Harris"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 797,
    "Name": "Ledner Group",
    "ToolTip": "Placeat incidunt quibusdam in nihil quo possimus.",
    "Deleted": false,
    "Rank": 75,
    "Type": "perferendis",
    "ColorBlock": 765,
    "IconHint": "facere",
    "Selected": false,
    "LastChanged": "1999-04-04T10:18:00.9418629+02:00",
    "ChildItems": [
      {
        "Id": 362,
        "Name": "Harber, DuBuque and Pacocha",
        "ToolTip": "Qui dolores quam aliquid inventore doloribus expedita nam.",
        "Deleted": false,
        "Rank": 110,
        "Type": "nobis",
        "ColorBlock": 771,
        "IconHint": "deleniti",
        "Selected": true,
        "LastChanged": "2019-04-19T10:18:00.9418629+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minus",
        "StyleHint": "vel",
        "Hidden": true,
        "FullName": "Alta Corbin Greenholt II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 936
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "deserunt",
    "Hidden": true,
    "FullName": "Chanelle Marquardt",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 6
      }
    }
  }
]
```