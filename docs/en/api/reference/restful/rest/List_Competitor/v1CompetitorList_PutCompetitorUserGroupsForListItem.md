---
title: PUT List/Competitor/Items/{id}/UserGroups
uid: v1CompetitorList_PutCompetitorUserGroupsForListItem
generated: true
---

# PUT List/Competitor/Items/{id}/UserGroups

```http
PUT /api/v1/List/Competitor/Items/{itemId}/UserGroups
```

Saves user groups visible for the Competitor list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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
PUT /api/v1/List/Competitor/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 980,
    "Name": "Prosacco, Prohaska and Mertz",
    "ToolTip": "Iste pariatur eligendi.",
    "Deleted": false,
    "Rank": 183,
    "Type": "enim",
    "ColorBlock": 641,
    "IconHint": "eos",
    "Selected": false,
    "LastChanged": "2019-08-05T12:57:43.3552036+02:00",
    "ChildItems": [
      {
        "Id": 882,
        "Name": "Schowalter, Berge and Bogan",
        "ToolTip": "Sint voluptas quo autem.",
        "Deleted": true,
        "Rank": 506,
        "Type": "numquam",
        "ColorBlock": 448,
        "IconHint": "modi",
        "Selected": true,
        "LastChanged": "2020-12-07T12:57:43.3552036+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "voluptatem",
        "Hidden": true,
        "FullName": "Gillian Rutherford"
      }
    ],
    "ExtraInfo": "minus",
    "StyleHint": "veritatis",
    "Hidden": false,
    "FullName": "Marcia Kovacek"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 514,
    "Name": "Franecki-Kshlerin",
    "ToolTip": "Ut minus quibusdam et eum cum.",
    "Deleted": false,
    "Rank": 733,
    "Type": "accusantium",
    "ColorBlock": 652,
    "IconHint": "beatae",
    "Selected": false,
    "LastChanged": "2020-03-01T12:57:43.3552036+01:00",
    "ChildItems": [
      {
        "Id": 644,
        "Name": "Shanahan LLC",
        "ToolTip": "Voluptates eum laboriosam enim accusamus totam.",
        "Deleted": true,
        "Rank": 521,
        "Type": "fugit",
        "ColorBlock": 203,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "2021-08-24T12:57:43.3552036+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "reprehenderit",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Domingo Grimes",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 267
          }
        }
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "quos",
    "Hidden": false,
    "FullName": "Andreanne Stanton",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 38
      }
    }
  }
]
```