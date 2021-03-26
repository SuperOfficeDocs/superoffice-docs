---
title: POST Agents/FreeText/GetSuggestedStopWords
id: v1FreeTextAgent_GetSuggestedStopWords
---

# POST Agents/FreeText/GetSuggestedStopWords

```http
POST /api/v1/Agents/FreeText/GetSuggestedStopWords
```

Returns the top used words in the freetext index table, sorted as most used first







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/FreeText/GetSuggestedStopWords?$select=name,department,category/id
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

CountWords 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CountWords | int32 |  |


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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/FreeText/GetSuggestedStopWords
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CountWords": 376
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 844,
    "Name": "Corwin, Goyette and Kihn",
    "ToolTip": "Autem optio quibusdam eos sit.",
    "Deleted": true,
    "Rank": 316,
    "Type": "reiciendis",
    "ChildItems": [
      {
        "Id": 11,
        "Name": "D'Amore, Walker and Purdy",
        "ToolTip": "Est quod voluptatum.",
        "Deleted": true,
        "Rank": 717,
        "Type": "facilis",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "accusantium",
        "ColorBlock": 981,
        "ExtraInfo": "ipsam",
        "StyleHint": "soluta",
        "FullName": "Mrs. Heaven Lueilwitz",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 325
          }
        }
      }
    ],
    "IconHint": "non",
    "ColorBlock": 910,
    "ExtraInfo": "soluta",
    "StyleHint": "aut",
    "FullName": "Mrs. Nia Stanton",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "matrix open-source applications"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 120
      }
    }
  }
]
```