---
title: PUT List/{udListDefinitionName}/Items/{id}/Headings
id: v1ListItemEntity_SaveHeadingsForListItemFromListName
---

# PUT List/{udListDefinitionName}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
```

Saves the headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update. **Required** |
| listItemId | int32 | The identity of the list item **Required** |



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

## Request Body: headings  

The headings to save. 

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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 43,
    "Name": "Hyatt Group",
    "ToolTip": "Ad quaerat ut et.",
    "Deleted": true,
    "Rank": 319,
    "Type": "commodi",
    "ColorBlock": 703,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2015-07-16T18:25:51.5912945+02:00",
    "ChildItems": [
      {
        "Id": 192,
        "Name": "Wiegand, Rippin and Green",
        "ToolTip": "Accusantium earum non vero error.",
        "Deleted": false,
        "Rank": 860,
        "Type": "deleniti",
        "ColorBlock": 323,
        "IconHint": "sapiente",
        "Selected": false,
        "LastChanged": "1997-02-13T18:25:51.5912945+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "labore",
        "StyleHint": "ut",
        "Hidden": true,
        "FullName": "Russ Kub"
      }
    ],
    "ExtraInfo": "quod",
    "StyleHint": "eum",
    "Hidden": false,
    "FullName": "Millie Abshire"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 770,
    "Name": "Hansen, Koch and Osinski",
    "ToolTip": "Nesciunt reiciendis.",
    "Deleted": true,
    "Rank": 900,
    "Type": "qui",
    "ColorBlock": 586,
    "IconHint": "necessitatibus",
    "Selected": false,
    "LastChanged": "2007-03-20T18:25:51.5932943+01:00",
    "ChildItems": [
      {
        "Id": 451,
        "Name": "Tillman-Schaefer",
        "ToolTip": "Deserunt id provident quibusdam.",
        "Deleted": true,
        "Rank": 486,
        "Type": "similique",
        "ColorBlock": 267,
        "IconHint": "illum",
        "Selected": false,
        "LastChanged": "2016-08-20T18:25:51.5942944+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatibus",
        "StyleHint": "ex",
        "Hidden": true,
        "FullName": "Hailee Crona",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 926
          }
        }
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "blanditiis",
    "Hidden": false,
    "FullName": "Dino Pollich",
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
        "FieldLength": 68
      }
    }
  }
]
```