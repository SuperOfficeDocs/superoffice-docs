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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 621,
    "Name": "Blick, Stark and Prohaska",
    "ToolTip": "Aliquid unde cumque aut saepe.",
    "Deleted": false,
    "Rank": 944,
    "Type": "dolorem",
    "ColorBlock": 271,
    "IconHint": "eligendi",
    "Selected": false,
    "LastChanged": "2015-08-12T11:16:14.512052+02:00",
    "ChildItems": [
      {
        "Id": 271,
        "Name": "Ortiz LLC",
        "ToolTip": "Corporis debitis iste at quaerat esse officiis.",
        "Deleted": true,
        "Rank": 359,
        "Type": "quibusdam",
        "ColorBlock": 540,
        "IconHint": "fugit",
        "Selected": true,
        "LastChanged": "2021-02-21T11:16:14.512052+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "quod",
        "Hidden": false,
        "FullName": "Gordon Champlin"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "corporis",
    "Hidden": true,
    "FullName": "Elmore Davis PhD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 768,
    "Name": "Bruen, Schneider and Gusikowski",
    "ToolTip": "Temporibus saepe et exercitationem.",
    "Deleted": true,
    "Rank": 710,
    "Type": "asperiores",
    "ColorBlock": 529,
    "IconHint": "quis",
    "Selected": false,
    "LastChanged": "2007-12-24T11:16:14.512052+01:00",
    "ChildItems": [
      {
        "Id": 769,
        "Name": "Marquardt Inc and Sons",
        "ToolTip": "Ut est temporibus.",
        "Deleted": true,
        "Rank": 548,
        "Type": "eum",
        "ColorBlock": 352,
        "IconHint": "illo",
        "Selected": false,
        "LastChanged": "2012-03-01T11:16:14.512052+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Anya Schimmel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 857
          }
        }
      }
    ],
    "ExtraInfo": "necessitatibus",
    "StyleHint": "sint",
    "Hidden": false,
    "FullName": "Bud Bartoletti",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 304
      }
    }
  }
]
```