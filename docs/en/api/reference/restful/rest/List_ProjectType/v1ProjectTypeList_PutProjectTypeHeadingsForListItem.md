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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 449,
    "Name": "Blick Group",
    "ToolTip": "Aut optio magnam et omnis provident voluptate officia.",
    "Deleted": false,
    "Rank": 698,
    "Type": "nisi",
    "ColorBlock": 770,
    "IconHint": "ex",
    "Selected": true,
    "LastChanged": "2019-11-23T17:37:40.2184703+01:00",
    "ChildItems": [
      {
        "Id": 856,
        "Name": "Lubowitz Inc and Sons",
        "ToolTip": "Vero voluptatibus impedit sed molestiae vitae enim quam.",
        "Deleted": false,
        "Rank": 624,
        "Type": "quia",
        "ColorBlock": 7,
        "IconHint": "id",
        "Selected": false,
        "LastChanged": "2014-07-04T17:37:40.2184703+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "totam",
        "Hidden": false,
        "FullName": "Mr. Enrique Vena Kozey III"
      }
    ],
    "ExtraInfo": "adipisci",
    "StyleHint": "tempore",
    "Hidden": true,
    "FullName": "Mrs. Emerson Heathcote MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 597,
    "Name": "Bartell, Macejkovic and Rolfson",
    "ToolTip": "Quis maiores reprehenderit explicabo.",
    "Deleted": true,
    "Rank": 202,
    "Type": "natus",
    "ColorBlock": 542,
    "IconHint": "facere",
    "Selected": false,
    "LastChanged": "2010-05-26T17:37:40.2194703+02:00",
    "ChildItems": [
      {
        "Id": 484,
        "Name": "D'Amore, Stokes and Armstrong",
        "ToolTip": "Nisi unde hic repellendus iste quo maiores.",
        "Deleted": true,
        "Rank": 467,
        "Type": "quos",
        "ColorBlock": 855,
        "IconHint": "nihil",
        "Selected": true,
        "LastChanged": "2020-10-25T17:37:40.2204705+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deserunt",
        "StyleHint": "nesciunt",
        "Hidden": false,
        "FullName": "Sarai Batz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 70
          }
        }
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "voluptate",
    "Hidden": false,
    "FullName": "Miss Garrick Helena Goodwin DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  }
]
```