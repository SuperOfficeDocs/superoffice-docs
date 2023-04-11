---
title: POST Agents/List/SaveHeadingsForListItemFromListDefinition
uid: v1ListAgent_SaveHeadingsForListItemFromListDefinition
---

# POST Agents/List/SaveHeadingsForListItemFromListDefinition

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListDefinition
```

Saves the active headings for the list item.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListDefinition?$select=name,department,category/id
```


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

## Request Body: request 

UdListDefinitionId, ListItemId, Headings 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | Integer |  |
| ListItemId | Integer |  |
| Headings | Array |  |

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
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 111,
  "ListItemId": 327,
  "Headings": [
    {
      "Id": 766,
      "Name": "Beer Inc and Sons",
      "ToolTip": "Unde eius omnis.",
      "Deleted": true,
      "Rank": 708,
      "Type": "minus",
      "ColorBlock": 409,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2014-08-23T15:29:22.0222718+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "esse",
      "Hidden": false,
      "FullName": "Joy McClure"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 962,
    "Name": "Lebsack-Gleason",
    "ToolTip": "Exercitationem velit.",
    "Deleted": false,
    "Rank": 962,
    "Type": "est",
    "ColorBlock": 758,
    "IconHint": "dolor",
    "Selected": false,
    "LastChanged": "2001-03-23T15:29:22.0227723+01:00",
    "ChildItems": [
      {
        "Id": 465,
        "Name": "Denesik Inc and Sons",
        "ToolTip": "Tempore nulla qui aut quia.",
        "Deleted": false,
        "Rank": 387,
        "Type": "dicta",
        "ColorBlock": 82,
        "IconHint": "error",
        "Selected": false,
        "LastChanged": "2021-01-09T15:29:22.0232718+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "atque",
        "StyleHint": "aliquid",
        "Hidden": true,
        "FullName": "Mrs. Skye Osinski IV",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 404
          }
        }
      }
    ],
    "ExtraInfo": "soluta",
    "StyleHint": "dicta",
    "Hidden": false,
    "FullName": "Ms. Frida Juanita Konopelski",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  }
]
```