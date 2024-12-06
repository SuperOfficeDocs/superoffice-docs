---
title: POST Agents/List/GetTicketCategoriesForUserGroups
uid: v1ListAgent_GetTicketCategoriesForUserGroups
generated: true
---

# POST Agents/List/GetTicketCategoriesForUserGroups

```http
POST /api/v1/Agents/List/GetTicketCategoriesForUserGroups
```

Ticket categories for user groups







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetTicketCategoriesForUserGroups?$select=name,department,category/id
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

UserGroupIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserGroupIds | Array |  |

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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/GetTicketCategoriesForUserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UserGroupIds": [
    40,
    897
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 797,
    "Name": "Nicolas, Corkery and Weber",
    "ToolTip": "Ducimus in facilis.",
    "Deleted": false,
    "Rank": 462,
    "Type": "similique",
    "ChildItems": [
      {
        "Id": 862,
        "Name": "Quitzon Inc and Sons",
        "ToolTip": "Vitae inventore et nam non maiores eaque voluptas.",
        "Deleted": true,
        "Rank": 577,
        "Type": "velit",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "sunt",
        "ColorBlock": 432,
        "ExtraInfo": "velit",
        "StyleHint": "similique",
        "FullName": "Mr. Jade Kris",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 422
          }
        }
      }
    ],
    "IconHint": "eos",
    "ColorBlock": 758,
    "ExtraInfo": "dolor",
    "StyleHint": "aperiam",
    "FullName": "Treva Kulas DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 700
      }
    }
  }
]
```