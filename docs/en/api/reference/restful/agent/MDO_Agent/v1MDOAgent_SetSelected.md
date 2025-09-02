---
title: POST Agents/MDO/SetSelected
uid: v1MDOAgent_SetSelected
generated: true
content_type: reference
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
  "Name": "Hermann LLC",
  "AdditionalInfo": "rerum",
  "SelectableMDOList": [
    {
      "Id": 284,
      "Name": "Jacobs-Goldner",
      "ToolTip": "Quia vitae ea.",
      "Deleted": false,
      "Rank": 592,
      "Type": "laborum",
      "ColorBlock": 472,
      "IconHint": "molestias",
      "Selected": false,
      "LastChanged": "2009-10-28T03:46:55.0194982+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Mrs. Royal Cassandra Lesch V"
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
    "Id": 961,
    "Name": "Rice LLC",
    "ToolTip": "Tempora quibusdam vitae.",
    "Deleted": true,
    "Rank": 579,
    "Type": "enim",
    "ColorBlock": 879,
    "IconHint": "explicabo",
    "Selected": false,
    "LastChanged": "2013-05-24T03:46:55.0194982+02:00",
    "ChildItems": [
      {
        "Id": 101,
        "Name": "White Group",
        "ToolTip": "Ut placeat reiciendis eius distinctio necessitatibus accusantium sit.",
        "Deleted": false,
        "Rank": 262,
        "Type": "quod",
        "ColorBlock": 569,
        "IconHint": "nihil",
        "Selected": true,
        "LastChanged": "2010-07-03T03:46:55.0194982+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "adipisci",
        "StyleHint": "necessitatibus",
        "Hidden": false,
        "FullName": "Hipolito Roob",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 100
          }
        }
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Carter Kshlerin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 249
      }
    }
  }
]
```