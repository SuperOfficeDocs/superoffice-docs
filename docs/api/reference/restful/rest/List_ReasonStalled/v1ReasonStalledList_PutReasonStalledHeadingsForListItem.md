---
title: PUT List/ReasonStalled/Items/{id}/Headings
uid: v1ReasonStalledList_PutReasonStalledHeadingsForListItem
---

# PUT List/ReasonStalled/Items/{id}/Headings

```http
PUT /api/v1/List/ReasonStalled/Items/{itemId}/Headings
```

Saves headings for the ReasonStalled list's item.

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
PUT /api/v1/List/ReasonStalled/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 484,
    "Name": "Baumbach-Barrows",
    "ToolTip": "Et et facere delectus necessitatibus ipsum.",
    "Deleted": true,
    "Rank": 496,
    "Type": "nostrum",
    "ColorBlock": 983,
    "IconHint": "laboriosam",
    "Selected": false,
    "LastChanged": "2014-11-04T11:10:54.5899365+01:00",
    "ChildItems": [
      {
        "Id": 845,
        "Name": "Champlin-Ebert",
        "ToolTip": "Cupiditate delectus dolor odit eos voluptatem et.",
        "Deleted": true,
        "Rank": 890,
        "Type": "amet",
        "ColorBlock": 703,
        "IconHint": "odit",
        "Selected": false,
        "LastChanged": "1998-10-12T11:10:54.5899365+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "labore",
        "StyleHint": "molestiae",
        "Hidden": false,
        "FullName": "Miss Noble Clifton Kiehn PhD"
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "voluptate",
    "Hidden": false,
    "FullName": "Dasia Corkery"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 943,
    "Name": "Rau LLC",
    "ToolTip": "Optio voluptatum velit reprehenderit ea autem fugit odit.",
    "Deleted": false,
    "Rank": 646,
    "Type": "quam",
    "ColorBlock": 485,
    "IconHint": "reprehenderit",
    "Selected": false,
    "LastChanged": "2015-05-22T11:10:54.5919351+02:00",
    "ChildItems": [
      {
        "Id": 867,
        "Name": "Beatty Group",
        "ToolTip": "Voluptas ad minima aliquam.",
        "Deleted": false,
        "Rank": 728,
        "Type": "reprehenderit",
        "ColorBlock": 115,
        "IconHint": "facere",
        "Selected": true,
        "LastChanged": "2007-11-03T11:10:54.5919351+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "non",
        "Hidden": true,
        "FullName": "Kayli Walsh",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 778
          }
        }
      }
    ],
    "ExtraInfo": "neque",
    "StyleHint": "voluptatem",
    "Hidden": true,
    "FullName": "Lera Schumm",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  }
]
```
