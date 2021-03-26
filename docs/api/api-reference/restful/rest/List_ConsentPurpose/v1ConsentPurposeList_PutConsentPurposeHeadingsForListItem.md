---
title: PUT List/ConsentPurpose/Items/{id}/Headings
id: v1ConsentPurposeList_PutConsentPurposeHeadingsForListItem
---

# PUT List/ConsentPurpose/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
```

Saves headings for the ConsentPurpose list's item.

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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 336,
    "Name": "Renner Inc and Sons",
    "ToolTip": "Ullam nesciunt voluptas quas rem est.",
    "Deleted": false,
    "Rank": 637,
    "Type": "qui",
    "ColorBlock": 898,
    "IconHint": "eaque",
    "Selected": false,
    "LastChanged": "1994-12-01T09:41:00.2693665+01:00",
    "ChildItems": [
      {
        "Id": 705,
        "Name": "Jewess Group",
        "ToolTip": "Numquam amet recusandae consequatur alias quod.",
        "Deleted": false,
        "Rank": 669,
        "Type": "minima",
        "ColorBlock": 847,
        "IconHint": "ratione",
        "Selected": true,
        "LastChanged": "2015-02-07T09:41:00.2703667+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "provident",
        "StyleHint": "voluptas",
        "Hidden": false,
        "FullName": "Samson Doyle"
      }
    ],
    "ExtraInfo": "adipisci",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Elouise Glover"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 763,
    "Name": "Kuhlman Group",
    "ToolTip": "Corrupti rerum incidunt tempore excepturi facere voluptatum.",
    "Deleted": true,
    "Rank": 499,
    "Type": "sed",
    "ColorBlock": 1000,
    "IconHint": "blanditiis",
    "Selected": true,
    "LastChanged": "1995-07-03T09:41:00.2713718+02:00",
    "ChildItems": [
      {
        "Id": 790,
        "Name": "Mertz Group",
        "ToolTip": "Deleniti eum.",
        "Deleted": false,
        "Rank": 738,
        "Type": "neque",
        "ColorBlock": 671,
        "IconHint": "fugiat",
        "Selected": true,
        "LastChanged": "2003-12-07T09:41:00.2723338+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "dolorem",
        "Hidden": false,
        "FullName": "Adelia Jenkins",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 581
          }
        }
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "quis",
    "Hidden": true,
    "FullName": "Wava Bogan",
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
        "FieldType": "System.Int32",
        "FieldLength": 370
      }
    }
  }
]
```