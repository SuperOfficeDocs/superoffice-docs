---
title: POST Agents/List/GetVisibleForUserGroups
uid: v1ListAgent_GetVisibleForUserGroups
---

# POST Agents/List/GetVisibleForUserGroups

```http
POST /api/v1/Agents/List/GetVisibleForUserGroups
```

List of User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetVisibleForUserGroups?$select=name,department,category/id
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

UdListDefinitionId, ListItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | int32 |  |
| ListItemId | int32 |  |


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
POST /api/v1/Agents/List/GetVisibleForUserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 137,
  "ListItemId": 943
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 734,
    "Name": "Roberts Inc and Sons",
    "ToolTip": "Excepturi minima vitae nulla sed voluptatum ex.",
    "Deleted": true,
    "Rank": 929,
    "Type": "quod",
    "ColorBlock": 260,
    "IconHint": "cum",
    "Selected": false,
    "LastChanged": "2006-01-23T02:49:44.6079219+01:00",
    "ChildItems": [
      {
        "Id": 309,
        "Name": "Brown-Hermann",
        "ToolTip": "Quasi quaerat velit est consectetur et.",
        "Deleted": false,
        "Rank": 68,
        "Type": "itaque",
        "ColorBlock": 573,
        "IconHint": "quia",
        "Selected": true,
        "LastChanged": "2012-09-11T02:49:44.6079219+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempore",
        "StyleHint": "assumenda",
        "Hidden": false,
        "FullName": "Kimberly Oda Cruickshank Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 89
          }
        }
      }
    ],
    "ExtraInfo": "quod",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Nasir Satterfield",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 19
      }
    }
  }
]
```