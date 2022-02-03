---
title: POST Agents/List/SetVisibleForUserGroupsFromListName
id: v1ListAgent_SetVisibleForUserGroupsFromListName
---

# POST Agents/List/SetVisibleForUserGroupsFromListName

```http
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
```

Update User groups that this list item is visible for







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName?$select=name,department,category/id
```


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

## Request Body: request  

UdListDefinitionName, ListItemId, UserGroups 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionName | string |  |
| ListItemId | int32 |  |
| UserGroups | array |  |


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
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Jacobs-Rohan",
  "ListItemId": 414,
  "UserGroups": [
    {
      "Id": 278,
      "Name": "Cartwright Group",
      "ToolTip": "Vero quisquam aliquid veritatis ut.",
      "Deleted": false,
      "Rank": 560,
      "Type": "porro",
      "ColorBlock": 199,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2003-05-26T18:28:49.3101182+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "nihil",
      "Hidden": true,
      "FullName": "Darby Monahan"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 595,
    "Name": "Metz-Terry",
    "ToolTip": "Aliquid voluptate.",
    "Deleted": false,
    "Rank": 799,
    "Type": "earum",
    "ColorBlock": 555,
    "IconHint": "omnis",
    "Selected": true,
    "LastChanged": "2008-04-25T18:28:49.3131223+02:00",
    "ChildItems": [
      {
        "Id": 82,
        "Name": "Walter-Labadie",
        "ToolTip": "Dicta rem qui aliquam.",
        "Deleted": false,
        "Rank": 912,
        "Type": "non",
        "ColorBlock": 969,
        "IconHint": "minus",
        "Selected": false,
        "LastChanged": "2006-11-02T18:28:49.3131223+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deleniti",
        "StyleHint": "architecto",
        "Hidden": false,
        "FullName": "Mrs. Laurianne Bailey",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 812
          }
        }
      }
    ],
    "ExtraInfo": "iure",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Nestor Muller",
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
        "FieldLength": 441
      }
    }
  }
]
```