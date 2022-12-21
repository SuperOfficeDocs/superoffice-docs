---
title: PUT List/Country/Items/{id}/UserGroups
uid: v1CountryList_PutCountryUserGroupsForListItem
---

# PUT List/Country/Items/{id}/UserGroups

```http
PUT /api/v1/List/Country/Items/{itemId}/UserGroups
```

Saves user groups visible for the Country list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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

OK

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

## Sample request

```http!
PUT /api/v1/List/Country/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 164,
    "Name": "Bergnaum-Koelpin",
    "ToolTip": "Ut similique non non suscipit repudiandae consequuntur.",
    "Deleted": true,
    "Rank": 784,
    "Type": "velit",
    "ColorBlock": 924,
    "IconHint": "numquam",
    "Selected": true,
    "LastChanged": "2010-07-14T02:49:52.1721908+02:00",
    "ChildItems": [
      {
        "Id": 595,
        "Name": "Cruickshank, Greenholt and Wuckert",
        "ToolTip": "Odit qui ex qui nihil et corrupti quo.",
        "Deleted": false,
        "Rank": 528,
        "Type": "similique",
        "ColorBlock": 172,
        "IconHint": "accusamus",
        "Selected": true,
        "LastChanged": "2012-02-21T02:49:52.1721908+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "id",
        "Hidden": true,
        "FullName": "Anastacio Schaefer III"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "inventore",
    "Hidden": false,
    "FullName": "Heber Alanna Schaefer PhD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 423,
    "Name": "Watsica Inc and Sons",
    "ToolTip": "Optio quo consequatur commodi dolores.",
    "Deleted": false,
    "Rank": 676,
    "Type": "aut",
    "ColorBlock": 681,
    "IconHint": "repudiandae",
    "Selected": true,
    "LastChanged": "2013-06-02T02:49:52.1721908+02:00",
    "ChildItems": [
      {
        "Id": 768,
        "Name": "Hintz LLC",
        "ToolTip": "Illum soluta excepturi voluptas sint vel.",
        "Deleted": false,
        "Rank": 316,
        "Type": "iure",
        "ColorBlock": 371,
        "IconHint": "corrupti",
        "Selected": false,
        "LastChanged": "1999-07-09T02:49:52.1721908+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "nemo",
        "Hidden": false,
        "FullName": "Mr. Clotilde Cynthia Lind",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 291
          }
        }
      }
    ],
    "ExtraInfo": "deserunt",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Ms. Arnulfo Prohaska",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  }
]
```