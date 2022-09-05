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


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/ReasonSold/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 200,
    "Name": "Pfannerstill Group",
    "ToolTip": "Ea deserunt in assumenda.",
    "Deleted": true,
    "Rank": 716,
    "Type": "omnis",
    "ColorBlock": 800,
    "IconHint": "expedita",
    "Selected": false,
    "LastChanged": "2001-06-25T11:10:54.5729377+02:00",
    "ChildItems": [
      {
        "Id": 566,
        "Name": "O'Reilly, Schumm and Lehner",
        "ToolTip": "Illum qui mollitia occaecati doloribus vero consectetur possimus.",
        "Deleted": false,
        "Rank": 938,
        "Type": "est",
        "ColorBlock": 393,
        "IconHint": "dolorem",
        "Selected": true,
        "LastChanged": "2016-06-26T11:10:54.5729377+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "vel",
        "Hidden": false,
        "FullName": "Dr. Baylee Brown"
      }
    ],
    "ExtraInfo": "ea",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Irving Schaefer"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 271,
    "Name": "Carter, Schulist and Grimes",
    "ToolTip": "Ad fugit totam qui occaecati iste maxime commodi.",
    "Deleted": true,
    "Rank": 235,
    "Type": "porro",
    "ColorBlock": 303,
    "IconHint": "reprehenderit",
    "Selected": false,
    "LastChanged": "1998-05-11T11:10:54.5759387+02:00",
    "ChildItems": [
      {
        "Id": 856,
        "Name": "Kuvalis Inc and Sons",
        "ToolTip": "Debitis ut vel laudantium laudantium.",
        "Deleted": false,
        "Rank": 67,
        "Type": "consequatur",
        "ColorBlock": 374,
        "IconHint": "facilis",
        "Selected": false,
        "LastChanged": "2020-08-20T11:10:54.5759387+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fugit",
        "StyleHint": "corporis",
        "Hidden": true,
        "FullName": "Dr. Letitia Abigale Zemlak Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 431
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "perferendis",
    "Hidden": false,
    "FullName": "Miss Santiago Schoen II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 236
      }
    }
  }
]
```