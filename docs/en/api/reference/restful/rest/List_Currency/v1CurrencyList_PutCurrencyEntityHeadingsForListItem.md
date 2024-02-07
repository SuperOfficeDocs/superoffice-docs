---
title: PUT List/Currency/Items/{id}/Headings
uid: v1CurrencyList_PutCurrencyEntityHeadingsForListItem
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 977,
    "Name": "Ruecker-Hickle",
    "ToolTip": "Nihil hic.",
    "Deleted": false,
    "Rank": 632,
    "Type": "velit",
    "ColorBlock": 686,
    "IconHint": "animi",
    "Selected": true,
    "LastChanged": "2016-12-09T16:55:30.6392207+01:00",
    "ChildItems": [
      {
        "Id": 584,
        "Name": "Lebsack Inc and Sons",
        "ToolTip": "Voluptatem autem est voluptatem quia.",
        "Deleted": false,
        "Rank": 231,
        "Type": "ipsam",
        "ColorBlock": 662,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2014-05-18T16:55:30.6392207+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "explicabo",
        "StyleHint": "fugiat",
        "Hidden": false,
        "FullName": "Prof. Daren Goyette PhD"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "consequatur",
    "Hidden": false,
    "FullName": "Berniece O'Keefe"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 792,
    "Name": "Connelly, Rogahn and Schaden",
    "ToolTip": "Autem odio sed tempora voluptatem et architecto.",
    "Deleted": false,
    "Rank": 305,
    "Type": "error",
    "ColorBlock": 400,
    "IconHint": "sed",
    "Selected": true,
    "LastChanged": "2010-03-19T16:55:30.6402157+01:00",
    "ChildItems": [
      {
        "Id": 363,
        "Name": "Goodwin-Yundt",
        "ToolTip": "Eos facere corporis vitae officia molestias est quas.",
        "Deleted": false,
        "Rank": 549,
        "Type": "accusamus",
        "ColorBlock": 653,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2009-06-30T16:55:30.6402157+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eum",
        "StyleHint": "eum",
        "Hidden": true,
        "FullName": "Autumn Bergnaum",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 692
          }
        }
      }
    ],
    "ExtraInfo": "maxime",
    "StyleHint": "officia",
    "Hidden": false,
    "FullName": "Mrs. Norval Kathleen Kihn Sr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 811
      }
    }
  }
]
```