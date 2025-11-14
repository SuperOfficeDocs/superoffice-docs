---
title: PUT List/Currency/Items/{id}/Headings
uid: v1CurrencyList_PutCurrencyEntityHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/Currency/Items/{id}/Headings

```http
PUT /api/v1/List/Currency/Items/{itemId}/Headings
```

Saves headings for the CurrencyEntity list's item.


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
PUT /api/v1/List/Currency/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 642,
    "Name": "Bogan Inc and Sons",
    "ToolTip": "Expedita assumenda culpa.",
    "Deleted": false,
    "Rank": 379,
    "Type": "nobis",
    "ColorBlock": 180,
    "IconHint": "natus",
    "Selected": true,
    "LastChanged": "2008-06-24T02:30:53.2723907+02:00",
    "ChildItems": [
      {
        "Id": 594,
        "Name": "Herzog, Bartell and Wunsch",
        "ToolTip": "Nihil facilis.",
        "Deleted": true,
        "Rank": 957,
        "Type": "itaque",
        "ColorBlock": 804,
        "IconHint": "quis",
        "Selected": false,
        "LastChanged": "2023-09-12T02:30:53.2723907+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "iure",
        "Hidden": true,
        "FullName": "Aaron Vandervort"
      }
    ],
    "ExtraInfo": "cumque",
    "StyleHint": "unde",
    "Hidden": false,
    "FullName": "Miss Jacky Bergstrom"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 56,
    "Name": "Schaden, Monahan and Skiles",
    "ToolTip": "Voluptate et.",
    "Deleted": true,
    "Rank": 233,
    "Type": "sapiente",
    "ColorBlock": 12,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2011-07-24T02:30:53.2723907+02:00",
    "ChildItems": [
      {
        "Id": 182,
        "Name": "Simonis Inc and Sons",
        "ToolTip": "Qui sint.",
        "Deleted": true,
        "Rank": 345,
        "Type": "alias",
        "ColorBlock": 775,
        "IconHint": "error",
        "Selected": false,
        "LastChanged": "2003-11-15T02:30:53.2723907+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "repellendus",
        "StyleHint": "ratione",
        "Hidden": true,
        "FullName": "Ms. Raleigh Dennis Kutch I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 700
          }
        }
      }
    ],
    "ExtraInfo": "provident",
    "StyleHint": "velit",
    "Hidden": false,
    "FullName": "Angelo Hyatt",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 529
      }
    }
  }
]
```