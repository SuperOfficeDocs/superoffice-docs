---
title: PUT List/Business/Items/{id}/Headings
id: v1BusinessList_PutBusinessHeadingsForListItem
---

# PUT List/Business/Items/{id}/Headings

```http
PUT /api/v1/List/Business/Items/{itemId}/Headings
```

Saves headings for the Business list's item.

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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 735,
    "Name": "Balistreri-Wyman",
    "ToolTip": "Vitae sit voluptas illum voluptatum et.",
    "Deleted": true,
    "Rank": 482,
    "Type": "et",
    "ColorBlock": 44,
    "IconHint": "omnis",
    "Selected": false,
    "LastChanged": "2006-10-05T09:41:00.1793337+02:00",
    "ChildItems": [
      {
        "Id": 864,
        "Name": "Smitham-Hills",
        "ToolTip": "Natus dolor et aperiam voluptas eum.",
        "Deleted": false,
        "Rank": 986,
        "Type": "in",
        "ColorBlock": 40,
        "IconHint": "ad",
        "Selected": true,
        "LastChanged": "2008-03-08T09:41:00.1793337+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "atque",
        "StyleHint": "rem",
        "Hidden": false,
        "FullName": "Chase Bednar"
      }
    ],
    "ExtraInfo": "dolores",
    "StyleHint": "odit",
    "Hidden": false,
    "FullName": "Mya Herzog MD"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 159,
    "Name": "Welch Group",
    "ToolTip": "Libero labore dolorum saepe voluptatibus.",
    "Deleted": false,
    "Rank": 78,
    "Type": "odio",
    "ColorBlock": 13,
    "IconHint": "non",
    "Selected": false,
    "LastChanged": "2012-09-27T09:41:00.1803686+02:00",
    "ChildItems": [
      {
        "Id": 712,
        "Name": "Kutch-Williamson",
        "ToolTip": "Modi aspernatur autem voluptatem error corporis error.",
        "Deleted": true,
        "Rank": 687,
        "Type": "cupiditate",
        "ColorBlock": 70,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2020-03-02T09:41:00.1803686+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "id",
        "StyleHint": "autem",
        "Hidden": false,
        "FullName": "Laila Hauck",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 209
          }
        }
      }
    ],
    "ExtraInfo": "quibusdam",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Miss Helene Terry",
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
        "FieldLength": 393
      }
    }
  }
]
```