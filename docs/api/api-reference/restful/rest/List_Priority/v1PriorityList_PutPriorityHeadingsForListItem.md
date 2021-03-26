---
title: PUT List/Priority/Items/{id}/Headings
id: v1PriorityList_PutPriorityHeadingsForListItem
---

# PUT List/Priority/Items/{id}/Headings

```http
PUT /api/v1/List/Priority/Items/{itemId}/Headings
```

Saves headings for the Priority list's item.

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
PUT /api/v1/List/Priority/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 375,
    "Name": "Metz, Wunsch and Lakin",
    "ToolTip": "Omnis illo.",
    "Deleted": false,
    "Rank": 454,
    "Type": "inventore",
    "ColorBlock": 330,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2017-10-22T09:41:00.5323817+02:00",
    "ChildItems": [
      {
        "Id": 949,
        "Name": "Herzog-Koepp",
        "ToolTip": "Exercitationem odio sed.",
        "Deleted": false,
        "Rank": 348,
        "Type": "qui",
        "ColorBlock": 128,
        "IconHint": "exercitationem",
        "Selected": false,
        "LastChanged": "1995-05-03T09:41:00.5323817+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "esse",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Mr. Karen Graham"
      }
    ],
    "ExtraInfo": "veniam",
    "StyleHint": "quasi",
    "Hidden": false,
    "FullName": "Aurelio Klein"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 687,
    "Name": "Dickinson Group",
    "ToolTip": "Sunt sit deserunt quae qui.",
    "Deleted": true,
    "Rank": 242,
    "Type": "cumque",
    "ColorBlock": 362,
    "IconHint": "tempora",
    "Selected": true,
    "LastChanged": "1998-12-09T09:41:00.5343816+01:00",
    "ChildItems": [
      {
        "Id": 51,
        "Name": "Kuhlman, Quitzon and Donnelly",
        "ToolTip": "Aut mollitia.",
        "Deleted": true,
        "Rank": 727,
        "Type": "non",
        "ColorBlock": 325,
        "IconHint": "odio",
        "Selected": false,
        "LastChanged": "2009-03-17T09:41:00.5343816+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "fugit",
        "Hidden": true,
        "FullName": "Ayla Feeney",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "monetize sexy experiences"
            },
            "FieldType": "System.String",
            "FieldLength": 780
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "et",
    "Hidden": true,
    "FullName": "Zechariah Ward",
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
        "FieldLength": 203
      }
    }
  }
]
```