---
title: PUT List/{id}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListDefinition
generated: true
---

# PUT List/{id}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
```

Saves the active headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The identity of the list item to delete **Required** |



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

## Request Body: headings 

The headings to save. 

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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 928,
    "Name": "Johnson, Treutel and Beer",
    "ToolTip": "Ut et molestiae neque.",
    "Deleted": true,
    "Rank": 42,
    "Type": "aut",
    "ColorBlock": 121,
    "IconHint": "ab",
    "Selected": true,
    "LastChanged": "2002-10-10T17:54:08.7730557+02:00",
    "ChildItems": [
      {
        "Id": 903,
        "Name": "Kris, Altenwerth and Cronin",
        "ToolTip": "Unde tenetur nobis porro vel beatae alias.",
        "Deleted": true,
        "Rank": 445,
        "Type": "neque",
        "ColorBlock": 690,
        "IconHint": "asperiores",
        "Selected": true,
        "LastChanged": "2009-03-21T17:54:08.7886801+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "beatae",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Wallace Kirlin"
      }
    ],
    "ExtraInfo": "tempore",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Triston Carter"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 70,
    "Name": "Lang, Kautzer and Zemlak",
    "ToolTip": "Doloremque et.",
    "Deleted": false,
    "Rank": 925,
    "Type": "ut",
    "ColorBlock": 732,
    "IconHint": "ratione",
    "Selected": true,
    "LastChanged": "2007-11-28T17:54:08.7886801+01:00",
    "ChildItems": [
      {
        "Id": 583,
        "Name": "White, Pollich and Rempel",
        "ToolTip": "Numquam et et earum officia dolorem et corporis.",
        "Deleted": true,
        "Rank": 618,
        "Type": "enim",
        "ColorBlock": 265,
        "IconHint": "omnis",
        "Selected": true,
        "LastChanged": "2011-05-14T17:54:08.7886801+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "laborum",
        "Hidden": false,
        "FullName": "Hulda Muller",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 5
          }
        }
      }
    ],
    "ExtraInfo": "molestias",
    "StyleHint": "porro",
    "Hidden": false,
    "FullName": "Noe Cartwright MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 283
      }
    }
  }
]
```