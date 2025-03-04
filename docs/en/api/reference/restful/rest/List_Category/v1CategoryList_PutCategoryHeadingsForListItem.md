---
title: PUT List/Category/Items/{id}/Headings
uid: v1CategoryList_PutCategoryHeadingsForListItem
generated: true
---

# PUT List/Category/Items/{id}/Headings

```http
PUT /api/v1/List/Category/Items/{itemId}/Headings
```

Saves headings for the Category list's item.


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
PUT /api/v1/List/Category/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 819,
    "Name": "Bergnaum, Johnson and Cummings",
    "ToolTip": "Illum optio.",
    "Deleted": true,
    "Rank": 979,
    "Type": "sed",
    "ColorBlock": 366,
    "IconHint": "temporibus",
    "Selected": true,
    "LastChanged": "2022-02-16T14:13:49.6804997+01:00",
    "ChildItems": [
      {
        "Id": 383,
        "Name": "Hagenes Group",
        "ToolTip": "Est nam est magnam dolores quia.",
        "Deleted": false,
        "Rank": 515,
        "Type": "provident",
        "ColorBlock": 664,
        "IconHint": "consectetur",
        "Selected": false,
        "LastChanged": "2003-01-29T14:13:49.6804997+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "libero",
        "StyleHint": "dolor",
        "Hidden": false,
        "FullName": "Beryl Kerluke"
      }
    ],
    "ExtraInfo": "autem",
    "StyleHint": "nihil",
    "Hidden": false,
    "FullName": "Carlie Hermiston"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 536,
    "Name": "Stoltenberg Inc and Sons",
    "ToolTip": "Maxime quam molestias et perspiciatis cumque tenetur laudantium.",
    "Deleted": false,
    "Rank": 361,
    "Type": "harum",
    "ColorBlock": 914,
    "IconHint": "quo",
    "Selected": false,
    "LastChanged": "2024-09-09T14:13:49.6804997+02:00",
    "ChildItems": [
      {
        "Id": 227,
        "Name": "Schamberger, Schimmel and Berge",
        "ToolTip": "Omnis et tempora sed dolores.",
        "Deleted": false,
        "Rank": 256,
        "Type": "dignissimos",
        "ColorBlock": 719,
        "IconHint": "id",
        "Selected": true,
        "LastChanged": "2011-07-18T14:13:49.6804997+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "labore",
        "Hidden": true,
        "FullName": "Mrs. Sophie Rath Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 406
          }
        }
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "dolor",
    "Hidden": false,
    "FullName": "Ms. Mustafa Johnson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 377
      }
    }
  }
]
```