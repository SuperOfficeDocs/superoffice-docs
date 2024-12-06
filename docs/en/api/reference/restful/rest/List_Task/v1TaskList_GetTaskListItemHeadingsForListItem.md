---
title: GET List/Task/Items/{id}/Headings
uid: v1TaskList_GetTaskListItemHeadingsForListItem
generated: true
---

# GET List/Task/Items/{id}/Headings

```http
GET /api/v1/List/Task/Items/{itemId}/Headings
```

Gets headings for the TaskListItem list's item.


Calls the Appointment agent service GetHeadings.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be get. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| showDeleted | bool |  Whether to show deleted items or not. Default false. |

```http
GET /api/v1/List/Task/Items/{itemId}/Headings?showDeleted=False
```


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
GET /api/v1/List/Task/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 866,
    "Name": "Reilly-Fadel",
    "ToolTip": "Corporis dolor molestiae.",
    "Deleted": true,
    "Rank": 785,
    "Type": "nostrum",
    "ColorBlock": 280,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2009-01-29T10:18:01.1918781+01:00",
    "ChildItems": [
      {
        "Id": 801,
        "Name": "Weimann, Kerluke and Cruickshank",
        "ToolTip": "Ut aperiam ab veniam provident praesentium et praesentium.",
        "Deleted": true,
        "Rank": 293,
        "Type": "non",
        "ColorBlock": 972,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2021-04-06T10:18:01.1918781+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aperiam",
        "StyleHint": "corrupti",
        "Hidden": true,
        "FullName": "Prof. Rickey Wanda Bechtelar Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 756
          }
        }
      }
    ],
    "ExtraInfo": "omnis",
    "StyleHint": "voluptas",
    "Hidden": false,
    "FullName": "Melany Bahringer",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 68
      }
    }
  }
]
```