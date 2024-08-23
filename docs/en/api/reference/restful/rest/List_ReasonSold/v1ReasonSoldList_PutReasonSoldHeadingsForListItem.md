---
title: PUT List/ReasonSold/Items/{id}/Headings
uid: v1ReasonSoldList_PutReasonSoldHeadingsForListItem
generated: true
---

# PUT List/ReasonSold/Items/{id}/Headings

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
```

Saves headings for the ReasonSold list's item.


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
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 131,
    "Name": "Lockman, Schmidt and Reynolds",
    "ToolTip": "Ratione laudantium repellendus.",
    "Deleted": false,
    "Rank": 367,
    "Type": "consequatur",
    "ColorBlock": 546,
    "IconHint": "quasi",
    "Selected": true,
    "LastChanged": "2002-01-12T13:28:33.1009254+01:00",
    "ChildItems": [
      {
        "Id": 289,
        "Name": "Goldner, Gleichner and Gibson",
        "ToolTip": "Et in ut est.",
        "Deleted": false,
        "Rank": 607,
        "Type": "in",
        "ColorBlock": 347,
        "IconHint": "voluptates",
        "Selected": true,
        "LastChanged": "1999-04-09T13:28:33.1165466+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "veritatis",
        "Hidden": true,
        "FullName": "Mr. Lonnie Colton Willms II"
      }
    ],
    "ExtraInfo": "optio",
    "StyleHint": "culpa",
    "Hidden": false,
    "FullName": "Dustin Conroy"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 839,
    "Name": "Jerde-Bergstrom",
    "ToolTip": "Ullam velit sed totam et soluta sint aliquid.",
    "Deleted": false,
    "Rank": 283,
    "Type": "ratione",
    "ColorBlock": 391,
    "IconHint": "quae",
    "Selected": true,
    "LastChanged": "2023-05-07T13:28:33.1165466+02:00",
    "ChildItems": [
      {
        "Id": 277,
        "Name": "Kessler Group",
        "ToolTip": "Mollitia adipisci quae earum odio fugit ducimus.",
        "Deleted": false,
        "Rank": 551,
        "Type": "voluptatem",
        "ColorBlock": 293,
        "IconHint": "veniam",
        "Selected": false,
        "LastChanged": "2010-03-26T13:28:33.1165466+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perspiciatis",
        "StyleHint": "facere",
        "Hidden": false,
        "FullName": "Karolann Smitham DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 950
          }
        }
      }
    ],
    "ExtraInfo": "vel",
    "StyleHint": "sed",
    "Hidden": false,
    "FullName": "Eliane Pfannerstill",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 879
      }
    }
  }
]
```