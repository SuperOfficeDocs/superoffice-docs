---
title: POST Agents/MDO/SetSelected
uid: v1MDOAgent_SetSelected
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/MDO/SetSelected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Graham, Russel and Dare",
  "AdditionalInfo": "quis",
  "SelectableMDOList": [
    {
      "Id": 784,
      "Name": "Pacocha LLC",
      "ToolTip": "Dolor tempora.",
      "Deleted": true,
      "Rank": 561,
      "Type": "dolor",
      "ColorBlock": 758,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "1998-01-11T14:19:03.7332495+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "velit",
      "Hidden": true,
      "FullName": "Lindsey Goodwin"
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
    "Id": 270,
    "Name": "Leffler-Mertz",
    "ToolTip": "Cum dolorem.",
    "Deleted": true,
    "Rank": 597,
    "Type": "ullam",
    "ColorBlock": 363,
    "IconHint": "dicta",
    "Selected": true,
    "LastChanged": "2018-09-21T14:19:03.7332495+02:00",
    "ChildItems": [
      {
        "Id": 198,
        "Name": "Doyle-Mayert",
        "ToolTip": "Qui voluptatem.",
        "Deleted": false,
        "Rank": 266,
        "Type": "dolorem",
        "ColorBlock": 954,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2021-05-29T14:19:03.7332495+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "sed",
        "Hidden": true,
        "FullName": "Dr. Kali Pietro Smitham DVM",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 949
          }
        }
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "similique",
    "Hidden": false,
    "FullName": "Emely O'Connell",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 21
      }
    }
  }
]
```