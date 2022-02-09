---
title: POST Agents/MDO/SetSelected
id: v1MDOAgent_SetSelected
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
| Name | string |  |
| AdditionalInfo | string |  |
| SelectableMDOList | array |  |


## Response: array



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

## Sample Request

```http!
POST /api/v1/Agents/MDO/SetSelected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Walker, Beier and Koepp",
  "AdditionalInfo": "qui",
  "SelectableMDOList": [
    {
      "Id": 918,
      "Name": "Lemke Inc and Sons",
      "ToolTip": "Sunt consectetur repudiandae possimus ut et.",
      "Deleted": true,
      "Rank": 44,
      "Type": "iusto",
      "ColorBlock": 352,
      "IconHint": "incidunt",
      "Selected": false,
      "LastChanged": "2021-11-09T18:28:49.4870903+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Shannon Konopelski"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 192,
    "Name": "Oberbrunner-Hand",
    "ToolTip": "A sint est blanditiis in.",
    "Deleted": false,
    "Rank": 439,
    "Type": "inventore",
    "ColorBlock": 827,
    "IconHint": "ea",
    "Selected": true,
    "LastChanged": "2001-05-15T18:28:49.4880902+02:00",
    "ChildItems": [
      {
        "Id": 199,
        "Name": "Stanton-Waelchi",
        "ToolTip": "Vel animi sit unde.",
        "Deleted": false,
        "Rank": 335,
        "Type": "velit",
        "ColorBlock": 560,
        "IconHint": "culpa",
        "Selected": true,
        "LastChanged": "1994-11-20T18:28:49.4880902+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quo",
        "StyleHint": "eaque",
        "Hidden": false,
        "FullName": "Micaela Mills",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 344
          }
        }
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Evangeline Mraz Sr.",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 123
      }
    }
  }
]
```