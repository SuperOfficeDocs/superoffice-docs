---
title: POST Agents/MDO/SetSelected
uid: v1MDOAgent_SetSelected
generated: true
---

# POST Agents/MDO/SetSelected

```http
POST /api/v1/Agents/MDO/SetSelected
```

Saves the selected values as selected by their given list representation.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/SetSelected?$select=name,department,category/id
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

Name, AdditionalInfo, SelectableMDOList 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String |  |
| AdditionalInfo | String |  |
| SelectableMDOList | Array |  |

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
POST /api/v1/Agents/MDO/SetSelected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Schultz-Beatty",
  "AdditionalInfo": "temporibus",
  "SelectableMDOList": [
    {
      "Id": 385,
      "Name": "Trantow LLC",
      "ToolTip": "Enim maiores.",
      "Deleted": false,
      "Rank": 983,
      "Type": "molestiae",
      "ColorBlock": 796,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2014-07-23T11:16:09.3972026+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Helmer Gusikowski"
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
    "Id": 838,
    "Name": "Anderson-Smith",
    "ToolTip": "Quasi animi iste sed est id corrupti.",
    "Deleted": false,
    "Rank": 253,
    "Type": "rerum",
    "ColorBlock": 930,
    "IconHint": "in",
    "Selected": false,
    "LastChanged": "2001-02-20T11:16:09.3972026+01:00",
    "ChildItems": [
      {
        "Id": 612,
        "Name": "Bode-Schneider",
        "ToolTip": "Suscipit nisi aspernatur non et cumque.",
        "Deleted": true,
        "Rank": 975,
        "Type": "neque",
        "ColorBlock": 98,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2013-04-08T11:16:09.3972026+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "temporibus",
        "StyleHint": "laboriosam",
        "Hidden": true,
        "FullName": "Tristian Reynolds",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 503
          }
        }
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "libero",
    "Hidden": false,
    "FullName": "Michele Osinski",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 100
      }
    }
  }
]
```