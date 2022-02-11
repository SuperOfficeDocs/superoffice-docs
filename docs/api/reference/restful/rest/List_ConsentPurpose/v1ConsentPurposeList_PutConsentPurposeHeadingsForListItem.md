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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 368,
    "Name": "Kerluke, Murazik and Greenfelder",
    "ToolTip": "Excepturi totam enim qui.",
    "Deleted": true,
    "Rank": 667,
    "Type": "consequuntur",
    "ColorBlock": 271,
    "IconHint": "suscipit",
    "Selected": false,
    "LastChanged": "1995-07-27T18:25:51.6752934+02:00",
    "ChildItems": [
      {
        "Id": 410,
        "Name": "Kassulke LLC",
        "ToolTip": "Sunt earum aspernatur.",
        "Deleted": true,
        "Rank": 123,
        "Type": "minus",
        "ColorBlock": 317,
        "IconHint": "amet",
        "Selected": true,
        "LastChanged": "2008-02-28T18:25:51.6763332+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "pariatur",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Mose Predovic"
      }
    ],
    "ExtraInfo": "totam",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Rosanna Gerlach V"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 216,
    "Name": "Torp, Wiza and Oberbrunner",
    "ToolTip": "Ipsum reiciendis omnis et labore in sunt.",
    "Deleted": true,
    "Rank": 845,
    "Type": "expedita",
    "ColorBlock": 413,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2004-09-17T18:25:51.6932913+02:00",
    "ChildItems": [
      {
        "Id": 618,
        "Name": "Stoltenberg LLC",
        "ToolTip": "Ea dolor totam.",
        "Deleted": false,
        "Rank": 937,
        "Type": "asperiores",
        "ColorBlock": 783,
        "IconHint": "tenetur",
        "Selected": true,
        "LastChanged": "2014-04-19T18:25:51.6932913+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "amet",
        "StyleHint": "excepturi",
        "Hidden": false,
        "FullName": "Dr. Lane Hirthe",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 741
          }
        }
      }
    ],
    "ExtraInfo": "dolorem",
    "StyleHint": "officia",
    "Hidden": true,
    "FullName": "Bertram DuBuque",
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
        "FieldLength": 304
      }
    }
  }
]
```