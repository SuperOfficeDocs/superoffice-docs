---
title: POST Agents/List/SaveHeadingsForListItemFromListDefinition
uid: v1ListAgent_SaveHeadingsForListItemFromListDefinition
generated: true
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
  "UdListDefinitionId": 919,
  "ListItemId": 66,
  "Headings": [
    {
      "Id": 360,
      "Name": "Jones Inc and Sons",
      "ToolTip": "Sed atque dicta consectetur veniam.",
      "Deleted": false,
      "Rank": 449,
      "Type": "deleniti",
      "ColorBlock": 854,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2012-04-20T23:03:56.2216275+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquam",
      "StyleHint": "quod",
      "Hidden": false,
      "FullName": "Cory Stiedemann"
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
    "Id": 725,
    "Name": "Raynor Inc and Sons",
    "ToolTip": "Dolorum dolorem odio molestias aperiam illum.",
    "Deleted": false,
    "Rank": 969,
    "Type": "fugit",
    "ColorBlock": 820,
    "IconHint": "culpa",
    "Selected": false,
    "LastChanged": "2017-10-25T23:03:56.2226257+02:00",
    "ChildItems": [
      {
        "Id": 70,
        "Name": "Smitham Inc and Sons",
        "ToolTip": "Dolore quidem.",
        "Deleted": false,
        "Rank": 173,
        "Type": "temporibus",
        "ColorBlock": 488,
        "IconHint": "error",
        "Selected": false,
        "LastChanged": "2010-01-11T23:03:56.2231322+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quas",
        "StyleHint": "explicabo",
        "Hidden": true,
        "FullName": "Mr. Isabel Orn PhD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 593
          }
        }
      }
    ],
    "ExtraInfo": "vero",
    "StyleHint": "expedita",
    "Hidden": false,
    "FullName": "Domenico Barney Hand III",
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