---
title: PUT List/ProjectType/Items/{id}/Headings
uid: v1ProjectTypeList_PutProjectTypeHeadingsForListItem
---

# PUT List/ProjectType/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
```

Saves headings for the ProjectType list's item.


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
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 154,
    "Name": "O'Conner, Eichmann and Kreiger",
    "ToolTip": "Voluptas doloremque ipsum blanditiis temporibus soluta sed et.",
    "Deleted": false,
    "Rank": 284,
    "Type": "impedit",
    "ColorBlock": 115,
    "IconHint": "natus",
    "Selected": false,
    "LastChanged": "2010-08-31T14:19:11.4149038+02:00",
    "ChildItems": [
      {
        "Id": 768,
        "Name": "Volkman Group",
        "ToolTip": "Voluptatem enim fugiat exercitationem.",
        "Deleted": false,
        "Rank": 229,
        "Type": "similique",
        "ColorBlock": 37,
        "IconHint": "dolores",
        "Selected": true,
        "LastChanged": "2002-04-26T14:19:11.4149038+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quidem",
        "StyleHint": "veniam",
        "Hidden": false,
        "FullName": "Oceane Thompson"
      }
    ],
    "ExtraInfo": "ea",
    "StyleHint": "consectetur",
    "Hidden": false,
    "FullName": "Mrs. Orville Ankunding MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 606,
    "Name": "Abernathy-Kohler",
    "ToolTip": "Assumenda iure aliquam.",
    "Deleted": false,
    "Rank": 955,
    "Type": "inventore",
    "ColorBlock": 607,
    "IconHint": "velit",
    "Selected": false,
    "LastChanged": "2020-05-10T14:19:11.4149038+02:00",
    "ChildItems": [
      {
        "Id": 328,
        "Name": "Daniel Inc and Sons",
        "ToolTip": "Voluptatem illo.",
        "Deleted": false,
        "Rank": 21,
        "Type": "et",
        "ColorBlock": 941,
        "IconHint": "nulla",
        "Selected": false,
        "LastChanged": "2000-09-03T14:19:11.4149038+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nulla",
        "StyleHint": "incidunt",
        "Hidden": false,
        "FullName": "Dr. Allie Christ Rutherford IV",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 200
          }
        }
      }
    ],
    "ExtraInfo": "in",
    "StyleHint": "aperiam",
    "Hidden": true,
    "FullName": "Edd Cronin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  }
]
```