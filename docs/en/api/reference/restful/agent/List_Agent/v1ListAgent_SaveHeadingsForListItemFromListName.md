---
title: POST Agents/List/SaveHeadingsForListItemFromListName
uid: v1ListAgent_SaveHeadingsForListItemFromListName
generated: true
content_type: reference
---

# POST Agents/List/SaveHeadingsForListItemFromListName

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListName
```

Saves the headings for the list item.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListName?$select=name,department,category/id
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

UdListDefinitionName, ListItemId, Headings 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | String |  |
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
POST /api/v1/Agents/List/SaveHeadingsForListItemFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Waelchi, Wolf and Feeney",
  "ListItemId": 361,
  "Headings": [
    {
      "Id": 862,
      "Name": "Kirlin LLC",
      "ToolTip": "Ut dignissimos a nihil aut.",
      "Deleted": false,
      "Rank": 583,
      "Type": "voluptatibus",
      "ColorBlock": 552,
      "IconHint": "odit",
      "Selected": false,
      "LastChanged": "2001-10-28T11:24:48.2032781+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempora",
      "StyleHint": "eum",
      "Hidden": false,
      "FullName": "Hosea Crist"
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
    "Id": 567,
    "Name": "Legros Group",
    "ToolTip": "Odit id.",
    "Deleted": false,
    "Rank": 629,
    "Type": "repellat",
    "ColorBlock": 585,
    "IconHint": "architecto",
    "Selected": false,
    "LastChanged": "2005-06-20T11:24:48.2189024+02:00",
    "ChildItems": [
      {
        "Id": 738,
        "Name": "Satterfield-Lang",
        "ToolTip": "Voluptatem aliquid consectetur quia.",
        "Deleted": false,
        "Rank": 532,
        "Type": "et",
        "ColorBlock": 196,
        "IconHint": "iste",
        "Selected": true,
        "LastChanged": "2007-08-23T11:24:48.2189024+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "occaecati",
        "StyleHint": "delectus",
        "Hidden": true,
        "FullName": "Roman Pouros",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 220
          }
        }
      }
    ],
    "ExtraInfo": "vero",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Robb Senger PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 825
      }
    }
  }
]
```