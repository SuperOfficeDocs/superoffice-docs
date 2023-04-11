---
title: POST Agents/List/GetListItemsForUserGroupFromListName
uid: v1ListAgent_GetListItemsForUserGroupFromListName
---

# POST Agents/List/GetListItemsForUserGroupFromListName

```http
POST /api/v1/Agents/List/GetListItemsForUserGroupFromListName
```

List of list items that is visible in the usergroup







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetListItemsForUserGroupFromListName?$select=name,department,category/id
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

UdListDefinitionName, GroupId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | String |  |
| GroupId | Integer |  |

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
POST /api/v1/Agents/List/GetListItemsForUserGroupFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Johns, Dare and Rau",
  "GroupId": 777
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 127,
    "Name": "Batz, Langosh and Maggio",
    "ToolTip": "Nostrum dolor dolorem et.",
    "Deleted": false,
    "Rank": 832,
    "Type": "dolores",
    "ColorBlock": 543,
    "IconHint": "velit",
    "Selected": true,
    "LastChanged": "2014-12-04T15:29:22.0172716+01:00",
    "ChildItems": [
      {
        "Id": 48,
        "Name": "Gutmann-Hintz",
        "ToolTip": "Id consequuntur pariatur.",
        "Deleted": false,
        "Rank": 530,
        "Type": "quam",
        "ColorBlock": 109,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "1998-03-09T15:29:22.0172716+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sequi",
        "StyleHint": "quam",
        "Hidden": false,
        "FullName": "Garrett Dickinson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 179
          }
        }
      }
    ],
    "ExtraInfo": "molestias",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Ms. Marcus Keeling II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 592
      }
    }
  }
]
```