---
title: POST Agents/MDO/GetSelectableSimpleList
uid: v1MDOAgent_GetSelectableSimpleList
generated: true
---

# POST Agents/MDO/GetSelectableSimpleList

```http
POST /api/v1/Agents/MDO/GetSelectableSimpleList
```

Method returns a flat Selectable MDO List.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/GetSelectableSimpleList?$select=name,department,category/id
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

Name 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String |  |

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
POST /api/v1/Agents/MDO/GetSelectableSimpleList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Name": "Rosenbaum-Wiegand"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 356,
    "Name": "Hauck, Upton and Kuhic",
    "ToolTip": "Neque qui modi ratione.",
    "Deleted": false,
    "Rank": 381,
    "Type": "veritatis",
    "ColorBlock": 438,
    "IconHint": "reprehenderit",
    "Selected": true,
    "LastChanged": "1999-05-24T03:45:23.6391999+02:00",
    "ChildItems": [
      {
        "Id": 352,
        "Name": "Padberg LLC",
        "ToolTip": "Odio rerum et explicabo consequatur iste.",
        "Deleted": false,
        "Rank": 924,
        "Type": "esse",
        "ColorBlock": 75,
        "IconHint": "ex",
        "Selected": true,
        "LastChanged": "2000-02-28T03:45:23.6391999+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facilis",
        "StyleHint": "nesciunt",
        "Hidden": false,
        "FullName": "Miss Arvel Marks Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 807
          }
        }
      }
    ],
    "ExtraInfo": "incidunt",
    "StyleHint": "cupiditate",
    "Hidden": false,
    "FullName": "Arely Reynolds",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 565
      }
    }
  }
]
```