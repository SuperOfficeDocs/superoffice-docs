---
title: POST Agents/MDO/GetListItem
id: v1MDOAgent_GetListItem
---

# POST Agents/MDO/GetListItem

```http
POST /api/v1/Agents/MDO/GetListItem
```

Returns a single list item







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/MDO/GetListItem?$select=name,department,category/id
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

ListName, Id 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ListName | string |  |
| Id | int32 |  |


## Response: object

Carrier object for MDOListItem.
Services for the MDOListItem Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IMDOAgent">MDO Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
POST /api/v1/Agents/MDO/GetListItem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ListName": "Kassulke-Sawayn",
  "Id": 452
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 741,
  "Name": "Hoeger Group",
  "ToolTip": "Sed doloremque ipsam.",
  "Deleted": true,
  "Rank": 661,
  "Type": "quisquam",
  "ChildItems": [
    {
      "Id": 771,
      "Name": "Lakin LLC",
      "ToolTip": "Vero quia atque voluptatibus et totam aspernatur.",
      "Deleted": true,
      "Rank": 827,
      "Type": "dolorem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quod",
      "ColorBlock": 625,
      "ExtraInfo": "odit",
      "StyleHint": "doloribus",
      "FullName": "Jonas Koss",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 684
        }
      }
    }
  ],
  "IconHint": "harum",
  "ColorBlock": 925,
  "ExtraInfo": "quod",
  "StyleHint": "deserunt",
  "FullName": "Carli Hilll",
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
      "FieldLength": 282
    }
  }
}
```