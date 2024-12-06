---
title: PUT List/Source/Items/{id}/Headings
uid: v1SourceList_PutSourceHeadingsForListItem
generated: true
---

# PUT List/Source/Items/{id}/Headings

```http
PUT /api/v1/List/Source/Items/{itemId}/Headings
```

Saves headings for the Source list's item.


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
PUT /api/v1/List/Source/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 552,
    "Name": "Mante LLC",
    "ToolTip": "Non sunt laborum qui.",
    "Deleted": true,
    "Rank": 307,
    "Type": "ut",
    "ColorBlock": 61,
    "IconHint": "aut",
    "Selected": true,
    "LastChanged": "2024-03-19T10:18:01.1762521+01:00",
    "ChildItems": [
      {
        "Id": 225,
        "Name": "Padberg Inc and Sons",
        "ToolTip": "Autem a nihil quia et odio ut.",
        "Deleted": false,
        "Rank": 287,
        "Type": "at",
        "ColorBlock": 204,
        "IconHint": "maxime",
        "Selected": true,
        "LastChanged": "2017-08-30T10:18:01.1762521+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "nisi",
        "Hidden": false,
        "FullName": "Pearlie Streich"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "aliquam",
    "Hidden": false,
    "FullName": "Gregoria Quitzon Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 729,
    "Name": "Ziemann, Braun and Wilkinson",
    "ToolTip": "Et optio nostrum voluptatem et eligendi sunt.",
    "Deleted": true,
    "Rank": 295,
    "Type": "quam",
    "ColorBlock": 10,
    "IconHint": "excepturi",
    "Selected": false,
    "LastChanged": "1998-05-14T10:18:01.1762521+02:00",
    "ChildItems": [
      {
        "Id": 714,
        "Name": "Schuppe Group",
        "ToolTip": "Nostrum voluptatem.",
        "Deleted": true,
        "Rank": 24,
        "Type": "nihil",
        "ColorBlock": 1001,
        "IconHint": "voluptas",
        "Selected": true,
        "LastChanged": "2005-03-02T10:18:01.1762521+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vel",
        "StyleHint": "neque",
        "Hidden": true,
        "FullName": "Golda Ledner",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 928
          }
        }
      }
    ],
    "ExtraInfo": "placeat",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Bernardo Prosacco",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 299
      }
    }
  }
]
```