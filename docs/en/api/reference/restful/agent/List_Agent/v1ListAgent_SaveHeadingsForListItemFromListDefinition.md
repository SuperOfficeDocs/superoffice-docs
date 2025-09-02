---
title: POST Agents/List/SaveHeadingsForListItemFromListDefinition
uid: v1ListAgent_SaveHeadingsForListItemFromListDefinition
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 464,
  "ListItemId": 468,
  "Headings": [
    {
      "Id": 567,
      "Name": "Shields, Balistreri and Tremblay",
      "ToolTip": "Ipsam sed sint aut enim.",
      "Deleted": true,
      "Rank": 575,
      "Type": "id",
      "ColorBlock": 841,
      "IconHint": "ex",
      "Selected": true,
      "LastChanged": "2008-03-08T03:46:54.9569999+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "nemo",
      "Hidden": true,
      "FullName": "Mr. Vincenza Raynor DDS"
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
    "Id": 947,
    "Name": "Daugherty LLC",
    "ToolTip": "Nesciunt repellat expedita.",
    "Deleted": false,
    "Rank": 397,
    "Type": "aliquam",
    "ColorBlock": 434,
    "IconHint": "perspiciatis",
    "Selected": true,
    "LastChanged": "1998-07-06T03:46:54.9569999+02:00",
    "ChildItems": [
      {
        "Id": 619,
        "Name": "Gaylord, Quigley and Volkman",
        "ToolTip": "Est quia.",
        "Deleted": false,
        "Rank": 488,
        "Type": "sed",
        "ColorBlock": 81,
        "IconHint": "eaque",
        "Selected": true,
        "LastChanged": "2001-08-14T03:46:54.9569999+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "illo",
        "StyleHint": "neque",
        "Hidden": false,
        "FullName": "Ike Grimes",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 732
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "accusantium",
    "Hidden": false,
    "FullName": "Adaline Fadel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 792
      }
    }
  }
]
```