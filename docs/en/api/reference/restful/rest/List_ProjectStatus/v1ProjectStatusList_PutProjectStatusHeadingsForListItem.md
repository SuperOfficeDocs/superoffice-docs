---
title: PUT List/ProjectStatus/Items/{id}/Headings
uid: v1ProjectStatusList_PutProjectStatusHeadingsForListItem
---

# PUT List/ProjectStatus/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
```

Saves headings for the ProjectStatus list's item.


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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/ProjectStatus/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 458,
    "Name": "Lemke-Mueller",
    "ToolTip": "Dolorum pariatur nihil cumque ipsam eaque et optio.",
    "Deleted": false,
    "Rank": 815,
    "Type": "qui",
    "ColorBlock": 598,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2011-09-06T14:19:11.3992772+02:00",
    "ChildItems": [
      {
        "Id": 692,
        "Name": "Schumm-Schumm",
        "ToolTip": "Sed voluptates rerum excepturi consequatur dolores.",
        "Deleted": false,
        "Rank": 935,
        "Type": "doloremque",
        "ColorBlock": 344,
        "IconHint": "dicta",
        "Selected": true,
        "LastChanged": "2019-07-04T14:19:11.3992772+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "molestiae",
        "Hidden": false,
        "FullName": "Miss Martina Hettinger"
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "ducimus",
    "Hidden": false,
    "FullName": "Mrs. Abraham Feest DDS"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 324,
    "Name": "Shields, Jacobson and Labadie",
    "ToolTip": "Voluptas odio eius perferendis qui eos.",
    "Deleted": false,
    "Rank": 702,
    "Type": "dicta",
    "ColorBlock": 570,
    "IconHint": "soluta",
    "Selected": false,
    "LastChanged": "2019-12-05T14:19:11.3992772+01:00",
    "ChildItems": [
      {
        "Id": 412,
        "Name": "Kreiger LLC",
        "ToolTip": "Perspiciatis impedit debitis.",
        "Deleted": true,
        "Rank": 220,
        "Type": "a",
        "ColorBlock": 330,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2012-12-08T14:19:11.3992772+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "numquam",
        "Hidden": false,
        "FullName": "Thaddeus Bernier",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 373
          }
        }
      }
    ],
    "ExtraInfo": "error",
    "StyleHint": "natus",
    "Hidden": true,
    "FullName": "Ramon Towne",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 489
      }
    }
  }
]
```