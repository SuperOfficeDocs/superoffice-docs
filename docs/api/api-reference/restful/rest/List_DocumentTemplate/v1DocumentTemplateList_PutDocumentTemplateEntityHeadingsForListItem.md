---
title: PUT List/DocumentTemplate/Items/{id}/Headings
id: v1DocumentTemplateList_PutDocumentTemplateEntityHeadingsForListItem
---

# PUT List/DocumentTemplate/Items/{id}/Headings

```http
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/Headings
```

Saves headings for the DocumentTemplateEntity list's item.

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
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 987,
    "Name": "Murazik Inc and Sons",
    "ToolTip": "Nesciunt cumque voluptas.",
    "Deleted": true,
    "Rank": 701,
    "Type": "rerum",
    "ColorBlock": 216,
    "IconHint": "cum",
    "Selected": false,
    "LastChanged": "2011-02-19T15:05:43.4945116+01:00",
    "ChildItems": [
      {
        "Id": 184,
        "Name": "Thiel, Bartoletti and Balistreri",
        "ToolTip": "Voluptatem saepe ab rerum nulla.",
        "Deleted": true,
        "Rank": 235,
        "Type": "nisi",
        "ColorBlock": 730,
        "IconHint": "debitis",
        "Selected": false,
        "LastChanged": "2004-07-12T15:05:43.4945116+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "vitae",
        "Hidden": true,
        "FullName": "Astrid Walter"
      }
    ],
    "ExtraInfo": "corrupti",
    "StyleHint": "harum",
    "Hidden": false,
    "FullName": "Imani Sipes"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 621,
    "Name": "Considine, Gutkowski and Pouros",
    "ToolTip": "Iusto quis enim dolorum.",
    "Deleted": true,
    "Rank": 283,
    "Type": "laborum",
    "ColorBlock": 1000,
    "IconHint": "maiores",
    "Selected": true,
    "LastChanged": "1994-12-21T15:05:43.4960265+01:00",
    "ChildItems": [
      {
        "Id": 542,
        "Name": "Jast, Leuschke and Orn",
        "ToolTip": "Quas molestiae.",
        "Deleted": true,
        "Rank": 588,
        "Type": "sit",
        "ColorBlock": 737,
        "IconHint": "deserunt",
        "Selected": true,
        "LastChanged": "2001-07-27T15:05:43.4960265+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "magnam",
        "Hidden": false,
        "FullName": "Ayana Goyette DDS",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "synthesize sexy communities"
            },
            "FieldType": "System.String",
            "FieldLength": 791
          }
        }
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "non",
    "Hidden": true,
    "FullName": "Consuelo Dicki",
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
        "FieldLength": 420
      }
    }
  }
]
```