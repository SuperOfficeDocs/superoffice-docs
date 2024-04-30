---
title: POST Agents/List/SaveHeadingsForListItemFromListName
uid: v1ListAgent_SaveHeadingsForListItemFromListName
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Hansen LLC",
  "ListItemId": 717,
  "Headings": [
    {
      "Id": 549,
      "Name": "Aufderhar-Feil",
      "ToolTip": "Vitae quasi adipisci et odit eos.",
      "Deleted": true,
      "Rank": 289,
      "Type": "deserunt",
      "ColorBlock": 310,
      "IconHint": "neque",
      "Selected": false,
      "LastChanged": "2006-04-01T11:44:33.8534097+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "sunt",
      "Hidden": false,
      "FullName": "Miss Clifford Lysanne Ondricka III"
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
    "Id": 787,
    "Name": "Barton, Johns and Wintheiser",
    "ToolTip": "Saepe facere rerum quod nihil mollitia.",
    "Deleted": false,
    "Rank": 864,
    "Type": "ea",
    "ColorBlock": 450,
    "IconHint": "officiis",
    "Selected": true,
    "LastChanged": "2002-02-03T11:44:33.8534097+01:00",
    "ChildItems": [
      {
        "Id": 51,
        "Name": "Monahan Inc and Sons",
        "ToolTip": "Velit molestiae doloribus possimus qui delectus sint.",
        "Deleted": true,
        "Rank": 97,
        "Type": "commodi",
        "ColorBlock": 332,
        "IconHint": "dolores",
        "Selected": true,
        "LastChanged": "2000-05-23T11:44:33.8534097+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iure",
        "StyleHint": "labore",
        "Hidden": false,
        "FullName": "Providenci Ankunding",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 416
          }
        }
      }
    ],
    "ExtraInfo": "necessitatibus",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Lane Price",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 737
      }
    }
  }
]
```