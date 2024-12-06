---
title: PUT List/Reason/Items/{id}/Headings
uid: v1ReasonList_PutReasonHeadingsForListItem
generated: true
---

# PUT List/Reason/Items/{id}/Headings

```http
PUT /api/v1/List/Reason/Items/{itemId}/Headings
```

Saves headings for the Reason list's item.


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
PUT /api/v1/List/Reason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 941,
    "Name": "Parisian-Leannon",
    "ToolTip": "Quas qui rerum.",
    "Deleted": false,
    "Rank": 656,
    "Type": "tempore",
    "ColorBlock": 81,
    "IconHint": "dolorem",
    "Selected": false,
    "LastChanged": "2000-04-27T10:18:01.1450002+02:00",
    "ChildItems": [
      {
        "Id": 280,
        "Name": "Cormier Group",
        "ToolTip": "Illum eum fuga.",
        "Deleted": true,
        "Rank": 464,
        "Type": "nihil",
        "ColorBlock": 162,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2016-07-30T10:18:01.1450002+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aspernatur",
        "StyleHint": "ullam",
        "Hidden": false,
        "FullName": "Ruby Emmett Powlowski III"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "iste",
    "Hidden": false,
    "FullName": "Dr. Travis Murray Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 932,
    "Name": "Heathcote LLC",
    "ToolTip": "Sed commodi cupiditate ab libero modi pariatur.",
    "Deleted": false,
    "Rank": 305,
    "Type": "voluptatum",
    "ColorBlock": 505,
    "IconHint": "tenetur",
    "Selected": true,
    "LastChanged": "2004-09-24T10:18:01.1450002+02:00",
    "ChildItems": [
      {
        "Id": 695,
        "Name": "Ferry Inc and Sons",
        "ToolTip": "Provident ut rerum voluptas voluptatem aliquid corrupti.",
        "Deleted": true,
        "Rank": 988,
        "Type": "accusamus",
        "ColorBlock": 223,
        "IconHint": "aliquam",
        "Selected": true,
        "LastChanged": "2015-12-17T10:18:01.1450002+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "reprehenderit",
        "StyleHint": "rerum",
        "Hidden": false,
        "FullName": "Johnny Botsford",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 560
          }
        }
      }
    ],
    "ExtraInfo": "veritatis",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Jena Schaden",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 549
      }
    }
  }
]
```