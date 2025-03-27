---
title: POST Agents/FreeText/GetSuggestedStopWords
uid: v1FreeTextAgent_GetSuggestedStopWords
generated: true
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
| CountWords | Integer |  |

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
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/FreeText/GetSuggestedStopWords
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "CountWords": 502
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 756,
    "Name": "Kohler, Rolfson and Kertzmann",
    "ToolTip": "Delectus doloremque qui.",
    "Deleted": false,
    "Rank": 632,
    "Type": "quia",
    "ChildItems": [
      {
        "Id": 305,
        "Name": "Hermann-Hettinger",
        "ToolTip": "Perferendis sunt.",
        "Deleted": true,
        "Rank": 841,
        "Type": "sapiente",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "porro",
        "ColorBlock": 606,
        "ExtraInfo": "eligendi",
        "StyleHint": "exercitationem",
        "FullName": "Ms. Sheldon Carli Davis",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 438
          }
        }
      }
    ],
    "IconHint": "eum",
    "ColorBlock": 860,
    "ExtraInfo": "consequatur",
    "StyleHint": "ducimus",
    "FullName": "Mrs. Roscoe Jacobson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 339
      }
    }
  }
]
```