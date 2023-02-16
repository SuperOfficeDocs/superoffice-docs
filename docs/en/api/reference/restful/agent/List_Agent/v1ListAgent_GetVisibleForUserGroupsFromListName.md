---
title: POST Agents/List/GetVisibleForUserGroupsFromListName
uid: v1ListAgent_GetVisibleForUserGroupsFromListName
---

# POST Agents/List/GetVisibleForUserGroupsFromListName

```http
POST /api/v1/Agents/List/GetVisibleForUserGroupsFromListName
```

List of User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetVisibleForUserGroupsFromListName?$select=name,department,category/id
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

UdListDefinitionName, ListItemId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | String |  |
| ListItemId | Integer |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/GetVisibleForUserGroupsFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Hilll, Cremin and Maggio",
  "ListItemId": 103
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 363,
    "Name": "Paucek-Kunze",
    "ToolTip": "Ratione unde id debitis id quam.",
    "Deleted": false,
    "Rank": 924,
    "Type": "debitis",
    "ColorBlock": 686,
    "IconHint": "ipsam",
    "Selected": true,
    "LastChanged": "2009-09-13T14:19:03.6238736+02:00",
    "ChildItems": [
      {
        "Id": 168,
        "Name": "Swaniawski, Corwin and Harber",
        "ToolTip": "Sapiente mollitia laboriosam ratione voluptatibus.",
        "Deleted": false,
        "Rank": 535,
        "Type": "numquam",
        "ColorBlock": 67,
        "IconHint": "laborum",
        "Selected": true,
        "LastChanged": "2002-12-31T14:19:03.6238736+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquam",
        "StyleHint": "eos",
        "Hidden": false,
        "FullName": "Muriel Cummerata",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 387
          }
        }
      }
    ],
    "ExtraInfo": "facilis",
    "StyleHint": "repellat",
    "Hidden": true,
    "FullName": "Emiliano Leannon",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 508
      }
    }
  }
]
```