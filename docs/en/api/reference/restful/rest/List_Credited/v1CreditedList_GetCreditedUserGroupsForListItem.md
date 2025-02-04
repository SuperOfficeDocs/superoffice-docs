---
title: GET List/Credited/Items/{id}/UserGroups
uid: v1CreditedList_GetCreditedUserGroupsForListItem
generated: true
---

# GET List/Credited/Items/{id}/UserGroups

```http
GET /api/v1/List/Credited/Items/{itemId}/UserGroups
```

Gets user groups visible for the Credited list's item.


Calls the List agent service GetHeadings.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to get. **Required** |



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
GET /api/v1/List/Credited/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 138,
    "Name": "Spencer, Stoltenberg and Kertzmann",
    "ToolTip": "Dolor neque perferendis saepe fugiat ad.",
    "Deleted": false,
    "Rank": 295,
    "Type": "quod",
    "ColorBlock": 597,
    "IconHint": "maiores",
    "Selected": false,
    "LastChanged": "2010-12-03T13:13:32.9799092+01:00",
    "ChildItems": [
      {
        "Id": 555,
        "Name": "Mitchell, Pagac and Ondricka",
        "ToolTip": "Et est nemo blanditiis alias magnam.",
        "Deleted": true,
        "Rank": 929,
        "Type": "id",
        "ColorBlock": 480,
        "IconHint": "ex",
        "Selected": false,
        "LastChanged": "2018-05-09T13:13:32.9799092+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "veniam",
        "StyleHint": "veritatis",
        "Hidden": false,
        "FullName": "Tianna Williamson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 6
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "assumenda",
    "Hidden": true,
    "FullName": "Prof. Ludwig Denesik",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 317
      }
    }
  }
]
```