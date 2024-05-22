---
title: PUT List/Priority/Items/{id}/Headings
uid: v1PriorityList_PutPriorityHeadingsForListItem
generated: true
---

# PUT List/Priority/Items/{id}/Headings

```http
PUT /api/v1/List/Priority/Items/{itemId}/Headings
```

Saves headings for the Priority list's item.


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
PUT /api/v1/List/Priority/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 510,
    "Name": "Pfannerstill Inc and Sons",
    "ToolTip": "Soluta suscipit aut voluptatem necessitatibus dicta sit.",
    "Deleted": false,
    "Rank": 739,
    "Type": "non",
    "ColorBlock": 967,
    "IconHint": "nemo",
    "Selected": false,
    "LastChanged": "2006-03-15T12:57:43.5739037+01:00",
    "ChildItems": [
      {
        "Id": 530,
        "Name": "Wilderman, Orn and White",
        "ToolTip": "Ut cumque sunt quibusdam ullam autem.",
        "Deleted": false,
        "Rank": 673,
        "Type": "enim",
        "ColorBlock": 723,
        "IconHint": "dolores",
        "Selected": true,
        "LastChanged": "2010-03-25T12:57:43.5739037+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "facere",
        "Hidden": false,
        "FullName": "Maximilian Carroll"
      }
    ],
    "ExtraInfo": "quam",
    "StyleHint": "aut",
    "Hidden": true,
    "FullName": "Willie Kemmer"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 664,
    "Name": "Bernier, Bartoletti and Jakubowski",
    "ToolTip": "Veritatis consequatur rerum velit id quam eveniet.",
    "Deleted": false,
    "Rank": 767,
    "Type": "sit",
    "ColorBlock": 531,
    "IconHint": "id",
    "Selected": false,
    "LastChanged": "1999-01-29T12:57:43.5739037+01:00",
    "ChildItems": [
      {
        "Id": 708,
        "Name": "Adams-Hills",
        "ToolTip": "Eveniet sunt corrupti nihil temporibus.",
        "Deleted": true,
        "Rank": 596,
        "Type": "ullam",
        "ColorBlock": 858,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "1997-05-07T12:57:43.5739037+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facilis",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Mrs. Jennifer Loma Spencer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 936
          }
        }
      }
    ],
    "ExtraInfo": "dolores",
    "StyleHint": "maiores",
    "Hidden": true,
    "FullName": "Miss Gordon Maxime Hansen",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 78
      }
    }
  }
]
```