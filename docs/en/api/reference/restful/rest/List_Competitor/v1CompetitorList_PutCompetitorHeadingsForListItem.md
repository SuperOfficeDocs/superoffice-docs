---
title: PUT List/Competitor/Items/{id}/Headings
uid: v1CompetitorList_PutCompetitorHeadingsForListItem
generated: true
---

# PUT List/Competitor/Items/{id}/Headings

```http
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
```

Saves headings for the Competitor list's item.


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
PUT /api/v1/List/Competitor/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 278,
    "Name": "Veum Inc and Sons",
    "ToolTip": "Sint ex.",
    "Deleted": true,
    "Rank": 385,
    "Type": "incidunt",
    "ColorBlock": 826,
    "IconHint": "vel",
    "Selected": false,
    "LastChanged": "2020-10-08T12:01:33.448849+02:00",
    "ChildItems": [
      {
        "Id": 269,
        "Name": "Hilll, Grady and King",
        "ToolTip": "Fugit ea vel officiis non dolorem et.",
        "Deleted": false,
        "Rank": 970,
        "Type": "dolor",
        "ColorBlock": 610,
        "IconHint": "sunt",
        "Selected": true,
        "LastChanged": "2002-11-28T12:01:33.448849+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "cumque",
        "StyleHint": "corporis",
        "Hidden": true,
        "FullName": "Laisha Goodwin Sr."
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "dolorem",
    "Hidden": false,
    "FullName": "Candice Weber"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 936,
    "Name": "Dibbert LLC",
    "ToolTip": "Sunt qui dolor et.",
    "Deleted": false,
    "Rank": 637,
    "Type": "aut",
    "ColorBlock": 677,
    "IconHint": "nostrum",
    "Selected": true,
    "LastChanged": "2023-01-22T12:01:33.448849+01:00",
    "ChildItems": [
      {
        "Id": 821,
        "Name": "Larkin, Hessel and Bernier",
        "ToolTip": "Omnis voluptas.",
        "Deleted": false,
        "Rank": 883,
        "Type": "et",
        "ColorBlock": 441,
        "IconHint": "voluptates",
        "Selected": true,
        "LastChanged": "2023-09-19T12:01:33.448849+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illo",
        "StyleHint": "necessitatibus",
        "Hidden": true,
        "FullName": "Miss Augustine Avis Carter V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 271
          }
        }
      }
    ],
    "ExtraInfo": "temporibus",
    "StyleHint": "consequuntur",
    "Hidden": true,
    "FullName": "Agustin Leannon",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 82
      }
    }
  }
]
```