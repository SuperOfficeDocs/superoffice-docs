---
title: GetSelectableListWithRestriction
id: v1MDOAgent_GetSelectableListWithRestriction
---

# GetSelectableListWithRestriction

```http
POST /api/v1/Agents/MDO/GetSelectableListWithRestriction
```

Method to get a Selectable MDO list with restrictions.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/GetSelectableListWithRestriction?$select=name,department,category/id
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

Name, AdditionalInfo, SearchValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| AdditionalInfo | string |  |
| SearchValue | string |  |


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
POST /api/v1/Agents/MDO/GetSelectableListWithRestriction
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Thiel-Hoppe",
  "AdditionalInfo": "iste",
  "SearchValue": "ipsa"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 217,
    "Name": "Lindgren, Hirthe and Ledner",
    "ToolTip": "In ullam quia dolorem.",
    "Deleted": true,
    "Rank": 27,
    "Type": "veritatis",
    "ColorBlock": 373,
    "IconHint": "non",
    "Selected": true,
    "LastChanged": "2005-05-06T14:58:04.5144677+02:00",
    "ChildItems": [
      {
        "Id": 270,
        "Name": "Roberts, Koss and Marquardt",
        "ToolTip": "Aut quis fugiat quam.",
        "Deleted": false,
        "Rank": 425,
        "Type": "quaerat",
        "ColorBlock": 509,
        "IconHint": "explicabo",
        "Selected": false,
        "LastChanged": "2000-09-23T14:58:04.5144677+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eum",
        "StyleHint": "libero",
        "Hidden": true,
        "FullName": "Vida Denesik III",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 675
          }
        }
      }
    ],
    "ExtraInfo": "quaerat",
    "StyleHint": "cum",
    "Hidden": true,
    "FullName": "Walter Zulauf",
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
        "FieldLength": 745
      }
    }
  }
]
```