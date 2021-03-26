---
title: PUT List/Rating/Items/{id}/Headings
id: v1RatingList_PutSaleStageEntityHeadingsForListItem
---

# PUT List/Rating/Items/{id}/Headings

```http
PUT /api/v1/List/Rating/Items/{itemId}/Headings
```

Saves headings for the SaleStageEntity list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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

## Request Body: entities  

The headings to be saved. 

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
PUT /api/v1/List/Rating/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 833,
    "Name": "Adams Group",
    "ToolTip": "Id sed amet repellat.",
    "Deleted": false,
    "Rank": 636,
    "Type": "sint",
    "ColorBlock": 902,
    "IconHint": "accusamus",
    "Selected": true,
    "LastChanged": "2016-11-28T09:41:00.674388+01:00",
    "ChildItems": [
      {
        "Id": 197,
        "Name": "Bashirian, McDermott and Olson",
        "ToolTip": "Et culpa consequatur.",
        "Deleted": true,
        "Rank": 222,
        "Type": "autem",
        "ColorBlock": 117,
        "IconHint": "libero",
        "Selected": true,
        "LastChanged": "1994-12-30T09:41:00.674388+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perspiciatis",
        "StyleHint": "rerum",
        "Hidden": true,
        "FullName": "Kianna Reinger"
      }
    ],
    "ExtraInfo": "ipsum",
    "StyleHint": "autem",
    "Hidden": true,
    "FullName": "Tomasa Green"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 591,
    "Name": "Treutel-Bartoletti",
    "ToolTip": "Ut aliquam consequuntur provident ratione porro ea.",
    "Deleted": false,
    "Rank": 883,
    "Type": "et",
    "ColorBlock": 755,
    "IconHint": "sit",
    "Selected": true,
    "LastChanged": "2011-06-17T09:41:00.6763881+02:00",
    "ChildItems": [
      {
        "Id": 801,
        "Name": "Carter LLC",
        "ToolTip": "Iure est qui consequatur ut dignissimos rerum.",
        "Deleted": false,
        "Rank": 165,
        "Type": "asperiores",
        "ColorBlock": 192,
        "IconHint": "cupiditate",
        "Selected": false,
        "LastChanged": "1994-05-10T09:41:00.6763881+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "commodi",
        "StyleHint": "omnis",
        "Hidden": false,
        "FullName": "Ms. Darien Herzog",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 28
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "sed",
    "Hidden": true,
    "FullName": "Lynn Gutmann",
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
        "FieldLength": 719
      }
    }
  }
]
```