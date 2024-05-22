---
title: POST Agents/List/GetHeadings
uid: v1ListAgent_GetHeadings
generated: true
---

# POST Agents/List/GetHeadings

```http
POST /api/v1/Agents/List/GetHeadings
```

Gets a selectable MDO list of the headings for this list item







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetHeadings?$select=name,department,category/id
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

UdListDefinitionId, ListItemId, ShowDeleted 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | Integer |  |
| ListItemId | Integer |  |
| ShowDeleted | Boolean |  |

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
POST /api/v1/Agents/List/GetHeadings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 655,
  "ListItemId": 676,
  "ShowDeleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 247,
    "Name": "Dach, Jaskolski and Bernier",
    "ToolTip": "Et delectus sunt ipsum quae.",
    "Deleted": true,
    "Rank": 148,
    "Type": "deserunt",
    "ColorBlock": 663,
    "IconHint": "iusto",
    "Selected": false,
    "LastChanged": "1997-12-20T12:57:34.1492269+01:00",
    "ChildItems": [
      {
        "Id": 7,
        "Name": "Pagac LLC",
        "ToolTip": "Animi quae.",
        "Deleted": false,
        "Rank": 112,
        "Type": "exercitationem",
        "ColorBlock": 11,
        "IconHint": "eum",
        "Selected": false,
        "LastChanged": "2010-10-05T12:57:34.1492269+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "incidunt",
        "StyleHint": "sunt",
        "Hidden": false,
        "FullName": "Prof. Gertrude Corine Hodkiewicz V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 972
          }
        }
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "occaecati",
    "Hidden": false,
    "FullName": "Abdullah Fisher PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 84
      }
    }
  }
]
```