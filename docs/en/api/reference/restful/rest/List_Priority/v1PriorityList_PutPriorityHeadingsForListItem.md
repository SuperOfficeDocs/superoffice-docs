---
title: PUT List/Priority/Items/{id}/Headings
uid: v1PriorityList_PutPriorityHeadingsForListItem
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
PUT /api/v1/List/Priority/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 167,
    "Name": "Nienow-Kertzmann",
    "ToolTip": "Veniam eos corporis culpa sint facilis perferendis odit.",
    "Deleted": false,
    "Rank": 450,
    "Type": "laborum",
    "ColorBlock": 222,
    "IconHint": "beatae",
    "Selected": true,
    "LastChanged": "2013-03-10T11:22:46.0066565+01:00",
    "ChildItems": [
      {
        "Id": 908,
        "Name": "Gorczany Inc and Sons",
        "ToolTip": "Ut inventore dolores iure neque qui est commodi.",
        "Deleted": true,
        "Rank": 631,
        "Type": "ipsam",
        "ColorBlock": 853,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "2008-04-08T11:22:46.0066565+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "eaque",
        "Hidden": false,
        "FullName": "Ms. Cooper Humberto Mohr"
      }
    ],
    "ExtraInfo": "sit",
    "StyleHint": "animi",
    "Hidden": true,
    "FullName": "Christelle Ryan"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 780,
    "Name": "Abbott Inc and Sons",
    "ToolTip": "Est dolorem et rerum et et beatae ipsa.",
    "Deleted": false,
    "Rank": 771,
    "Type": "et",
    "ColorBlock": 696,
    "IconHint": "ea",
    "Selected": false,
    "LastChanged": "2022-01-16T11:22:46.0222797+01:00",
    "ChildItems": [
      {
        "Id": 763,
        "Name": "Bosco, Hintz and Goyette",
        "ToolTip": "Vel voluptatum similique provident quis quas aspernatur sapiente.",
        "Deleted": false,
        "Rank": 869,
        "Type": "vel",
        "ColorBlock": 959,
        "IconHint": "doloremque",
        "Selected": true,
        "LastChanged": "2010-12-11T11:22:46.0222797+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "eveniet",
        "Hidden": false,
        "FullName": "Hyman Miller",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 312
          }
        }
      }
    ],
    "ExtraInfo": "temporibus",
    "StyleHint": "magnam",
    "Hidden": false,
    "FullName": "Ms. Alena Streich",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 464
      }
    }
  }
]
```