---
title: PUT List/ConsentSource/Items/{id}/Headings
id: v1ConsentSourceList_PutConsentSourceHeadingsForListItem
---

# PUT List/ConsentSource/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
```

Saves headings for the ConsentSource list's item.

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
PUT /api/v1/List/ConsentSource/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 710,
    "Name": "Lehner-Glover",
    "ToolTip": "Quisquam vitae repellendus quas et.",
    "Deleted": true,
    "Rank": 784,
    "Type": "alias",
    "ColorBlock": 337,
    "IconHint": "tempora",
    "Selected": false,
    "LastChanged": "1997-12-19T15:05:43.3585128+01:00",
    "ChildItems": [
      {
        "Id": 673,
        "Name": "Gottlieb Group",
        "ToolTip": "Officiis rerum consequatur iure quia qui exercitationem.",
        "Deleted": false,
        "Rank": 985,
        "Type": "omnis",
        "ColorBlock": 380,
        "IconHint": "nostrum",
        "Selected": false,
        "LastChanged": "2005-11-19T15:05:43.3585128+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "ipsa",
        "Hidden": true,
        "FullName": "Ms. Elsa Zboncak"
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "eos",
    "Hidden": false,
    "FullName": "Hilda Nienow"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 218,
    "Name": "Bauch Inc and Sons",
    "ToolTip": "Animi possimus dolores deleniti.",
    "Deleted": true,
    "Rank": 667,
    "Type": "voluptas",
    "ColorBlock": 366,
    "IconHint": "optio",
    "Selected": false,
    "LastChanged": "2002-12-01T15:05:43.3605126+01:00",
    "ChildItems": [
      {
        "Id": 436,
        "Name": "Fisher-Ankunding",
        "ToolTip": "Consequatur sit nulla necessitatibus.",
        "Deleted": false,
        "Rank": 162,
        "Type": "veniam",
        "ColorBlock": 723,
        "IconHint": "provident",
        "Selected": false,
        "LastChanged": "2003-06-17T15:05:43.3605126+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "culpa",
        "StyleHint": "veniam",
        "Hidden": false,
        "FullName": "Delilah Towne",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 935
          }
        }
      }
    ],
    "ExtraInfo": "adipisci",
    "StyleHint": "iste",
    "Hidden": true,
    "FullName": "Asa Doyle",
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
        "FieldLength": 45
      }
    }
  }
]
```