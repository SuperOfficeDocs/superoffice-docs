---
title: PUT List/ReasonSold/Items/{id}/Headings
uid: v1ReasonSoldList_PutReasonSoldHeadingsForListItem
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 947,
    "Name": "Schoen, Beatty and Cruickshank",
    "ToolTip": "Incidunt dolor.",
    "Deleted": true,
    "Rank": 658,
    "Type": "aut",
    "ColorBlock": 599,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2015-02-21T15:29:31.5524751+01:00",
    "ChildItems": [
      {
        "Id": 737,
        "Name": "Lakin Inc and Sons",
        "ToolTip": "Doloribus eveniet sed adipisci.",
        "Deleted": false,
        "Rank": 877,
        "Type": "ipsum",
        "ColorBlock": 889,
        "IconHint": "nobis",
        "Selected": false,
        "LastChanged": "2013-01-16T15:29:31.5529744+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "numquam",
        "StyleHint": "alias",
        "Hidden": false,
        "FullName": "Garry Jakubowski"
      }
    ],
    "ExtraInfo": "earum",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Maritza Mann"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 187,
    "Name": "McDermott LLC",
    "ToolTip": "Eum corrupti consequatur.",
    "Deleted": false,
    "Rank": 303,
    "Type": "debitis",
    "ColorBlock": 311,
    "IconHint": "dolorem",
    "Selected": false,
    "LastChanged": "2002-10-22T15:29:31.5549769+02:00",
    "ChildItems": [
      {
        "Id": 531,
        "Name": "Renner-Mayert",
        "ToolTip": "Aut odio veniam est.",
        "Deleted": true,
        "Rank": 344,
        "Type": "quasi",
        "ColorBlock": 419,
        "IconHint": "eos",
        "Selected": true,
        "LastChanged": "2014-10-11T15:29:31.5549769+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ratione",
        "StyleHint": "eveniet",
        "Hidden": false,
        "FullName": "Crawford Thiel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 549
          }
        }
      }
    ],
    "ExtraInfo": "deserunt",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Maxime Kling",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 759
      }
    }
  }
]
```