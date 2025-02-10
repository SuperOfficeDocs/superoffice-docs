---
title: POST Agents/List/SetVisibleForUserGroupsFromListName
uid: v1ListAgent_SetVisibleForUserGroupsFromListName
generated: true
---

# POST Agents/List/SetVisibleForUserGroupsFromListName

```http
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
```

Update User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName?$select=name,department,category/id
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

UdListDefinitionName, ListItemId, UserGroups 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | String |  |
| ListItemId | Integer |  |
| UserGroups | Array |  |

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
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Aufderhar-Feeney",
  "ListItemId": 250,
  "UserGroups": [
    {
      "Id": 296,
      "Name": "Zemlak Group",
      "ToolTip": "Est sed consequatur non non quia.",
      "Deleted": true,
      "Rank": 92,
      "Type": "autem",
      "ColorBlock": 3,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2008-06-23T12:01:27.9471677+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "provident",
      "Hidden": false,
      "FullName": "Dr. Stan Fernando Lindgren Jr."
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
    "Id": 263,
    "Name": "Kunde, Spencer and Wiegand",
    "ToolTip": "Quia laudantium sed assumenda et.",
    "Deleted": false,
    "Rank": 693,
    "Type": "voluptatem",
    "ColorBlock": 587,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2024-02-26T12:01:27.9471677+01:00",
    "ChildItems": [
      {
        "Id": 543,
        "Name": "Haley-Williamson",
        "ToolTip": "Ut quos saepe beatae dignissimos.",
        "Deleted": false,
        "Rank": 721,
        "Type": "vitae",
        "ColorBlock": 174,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2002-05-14T12:01:27.9471677+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iure",
        "StyleHint": "eos",
        "Hidden": false,
        "FullName": "Kurtis Lemke DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 297
          }
        }
      }
    ],
    "ExtraInfo": "suscipit",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Ms. August Kurtis Schuppe II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 47
      }
    }
  }
]
```