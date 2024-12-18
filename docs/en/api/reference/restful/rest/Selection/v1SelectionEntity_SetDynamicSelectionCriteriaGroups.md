---
title: PUT Selection/{id}/CriteriaGroups
uid: v1SelectionEntity_SetDynamicSelectionCriteriaGroups
generated: true
---

# PUT Selection/{id}/CriteriaGroups

```http
PUT /api/v1/Selection/{selectionId}/CriteriaGroups
```

Update the criteria for this dynamic selection.


Replaces existing criteria with the new values. This call supports multiple criteria groups.





| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |



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

## Request Body: criteria 

Criteria groups defining the selection result. Empty array is legal, simply means no criteria have been set 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String | Name of the group |
| Description | String | Description of the group |
| Rank | Integer | Rank of group among groups |
| Restrictions | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Name of the group |
| Description | string | Description of the group |
| Rank | int32 | Rank of group among groups |
| Restrictions | array |  |

## Sample request

```http!
PUT /api/v1/Selection/{selectionId}/CriteriaGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Kuhlman, Tremblay and Kessler",
    "Description": "Visionary secondary knowledge user",
    "Rank": 158,
    "Restrictions": [
      {
        "Name": "Breitenberg-Jacobi",
        "Operator": "quia",
        "Values": [
          "non",
          "praesentium"
        ],
        "DisplayValues": [
          "fugiat",
          "quia"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 40,
        "InterOperator": "And",
        "UniqueHash": 633
      }
    ]
  },
  {
    "Name": "Kuhlman, Tremblay and Kessler",
    "Description": "Visionary secondary knowledge user",
    "Rank": 158,
    "Restrictions": [
      {
        "Name": "Breitenberg-Jacobi",
        "Operator": "quia",
        "Values": [
          "non",
          "praesentium"
        ],
        "DisplayValues": [
          "fugiat",
          "quia"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 40,
        "InterOperator": "And",
        "UniqueHash": 633
      }
    ]
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Heathcote Group",
    "Description": "Horizontal client-server emulation",
    "Rank": 372,
    "Restrictions": [
      {
        "Name": "Cruickshank LLC",
        "Operator": "ab",
        "Values": [
          "qui",
          "itaque"
        ],
        "DisplayValues": [
          "aut",
          "sint"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 843,
        "InterOperator": "And",
        "UniqueHash": 462
      }
    ]
  },
  {
    "Name": "Heathcote Group",
    "Description": "Horizontal client-server emulation",
    "Rank": 372,
    "Restrictions": [
      {
        "Name": "Cruickshank LLC",
        "Operator": "ab",
        "Values": [
          "qui",
          "itaque"
        ],
        "DisplayValues": [
          "aut",
          "sint"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 843,
        "InterOperator": "And",
        "UniqueHash": 462
      }
    ]
  }
]
```