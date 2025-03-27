---
title: GET License/User/MdoList
uid: v1License_GetUserLicensesMDOList
generated: true
---

# GET License/User/MdoList

```http
GET /api/v1/License/User/MdoList
```

Get all licenses in a MDOListItem structure.








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/License/User/MdoList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 74,
    "Name": "Terry, Hickle and Runolfsson",
    "ToolTip": "Esse ad doloremque ut fugit voluptatum neque repudiandae.",
    "Deleted": false,
    "Rank": 58,
    "Type": "earum",
    "ColorBlock": 76,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2015-08-09T02:38:26.5578869+02:00",
    "ChildItems": [
      {
        "Id": 671,
        "Name": "Stehr-Gutmann",
        "ToolTip": "Quidem natus quod adipisci veritatis voluptas a nobis.",
        "Deleted": false,
        "Rank": 949,
        "Type": "asperiores",
        "ColorBlock": 893,
        "IconHint": "soluta",
        "Selected": true,
        "LastChanged": "2014-11-06T02:38:26.5578869+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quidem",
        "StyleHint": "dolores",
        "Hidden": false,
        "FullName": "Clotilde Wilkinson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 263
          }
        }
      }
    ],
    "ExtraInfo": "porro",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Alejandrin Emmerich",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 153
      }
    }
  }
]
```