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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Name": "Morar-Dietrich",
  "AdditionalInfo": "illo",
  "SelectableMDOList": [
    {
      "Id": 924,
      "Name": "Schulist-Parisian",
      "ToolTip": "Possimus in molestias voluptas illo eaque quam laudantium.",
      "Deleted": false,
      "Rank": 156,
      "Type": "et",
      "ColorBlock": 654,
      "IconHint": "quod",
      "Selected": true,
      "LastChanged": "2020-10-30T03:41:53.7619726+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "quisquam",
      "Hidden": true,
      "FullName": "Rhea McLaughlin"
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
    "Id": 325,
    "Name": "Blanda Group",
    "ToolTip": "Consectetur omnis nisi deleniti exercitationem occaecati voluptates quis.",
    "Deleted": false,
    "Rank": 979,
    "Type": "illo",
    "ColorBlock": 572,
    "IconHint": "deleniti",
    "Selected": true,
    "LastChanged": "2017-08-25T03:41:53.7619726+02:00",
    "ChildItems": [
      {
        "Id": 400,
        "Name": "Kirlin, Gerlach and Cole",
        "ToolTip": "Nihil ipsum et quae consequatur occaecati consequatur.",
        "Deleted": true,
        "Rank": 936,
        "Type": "laborum",
        "ColorBlock": 463,
        "IconHint": "dolore",
        "Selected": true,
        "LastChanged": "2015-10-30T03:41:53.7619726+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "sapiente",
        "Hidden": false,
        "FullName": "Mr. Layla Glover",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 178
          }
        }
      }
    ],
    "ExtraInfo": "consectetur",
    "StyleHint": "quae",
    "Hidden": true,
    "FullName": "Mr. Bernard Adrienne Mann DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  }
]
```