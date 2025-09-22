---
title: PUT List/Position/Items/{id}/Headings
uid: v1PositionList_PutPositionHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/Position/Items/{id}/Headings

```http
PUT /api/v1/List/Position/Items/{itemId}/Headings
```

Saves headings for the Position list's item.


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
PUT /api/v1/List/Position/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 110,
    "Name": "Gerlach-Schimmel",
    "ToolTip": "Sed ea culpa provident voluptates non sint voluptatem.",
    "Deleted": false,
    "Rank": 526,
    "Type": "cum",
    "ColorBlock": 882,
    "IconHint": "sit",
    "Selected": true,
    "LastChanged": "2019-09-27T11:24:53.9842923+02:00",
    "ChildItems": [
      {
        "Id": 871,
        "Name": "Fadel, Keeling and Gibson",
        "ToolTip": "Dolor suscipit illum voluptatum dolorem vero beatae.",
        "Deleted": true,
        "Rank": 688,
        "Type": "labore",
        "ColorBlock": 818,
        "IconHint": "blanditiis",
        "Selected": false,
        "LastChanged": "2021-03-20T11:24:53.9842923+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "modi",
        "StyleHint": "corrupti",
        "Hidden": false,
        "FullName": "Glenda Reichert"
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "officiis",
    "Hidden": true,
    "FullName": "Ms. Elenor Pollich"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 944,
    "Name": "Dickinson Group",
    "ToolTip": "Aut et recusandae cumque.",
    "Deleted": false,
    "Rank": 158,
    "Type": "sequi",
    "ColorBlock": 164,
    "IconHint": "dicta",
    "Selected": false,
    "LastChanged": "2019-07-09T11:24:53.9842923+02:00",
    "ChildItems": [
      {
        "Id": 543,
        "Name": "Beier, Volkman and Ondricka",
        "ToolTip": "Asperiores accusamus quae delectus.",
        "Deleted": false,
        "Rank": 106,
        "Type": "vero",
        "ColorBlock": 279,
        "IconHint": "commodi",
        "Selected": false,
        "LastChanged": "2005-01-20T11:24:53.9842923+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "a",
        "StyleHint": "accusamus",
        "Hidden": false,
        "FullName": "Carolyn Russel PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 38
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "praesentium",
    "Hidden": false,
    "FullName": "Osvaldo Abshire",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 757
      }
    }
  }
]
```