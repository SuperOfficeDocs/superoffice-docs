---
title: POST Agents/Archive/GetActivityFilter
id: v1ArchiveAgent_GetActivityFilter
---

# POST Agents/Archive/GetActivityFilter

```http
POST /api/v1/Agents/Archive/GetActivityFilter
```

Get activity filter for the specified list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetActivityFilter?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Activity list filter information.



Carrier object for ActivityFilter.
Services for the ActivityFilter Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">Archive Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | date-time | The filtering From date |
| ToDate | date-time | The filtering To date |
| AssociateList | array | The list of associates to filter on |
| GroupList | array | The list of groups to filter on |
| FutureDateList | array | The list of future date selections. This is a static MDO list with standard values. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/GetActivityFilter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2009-08-02T18:28:48.0898508+02:00",
  "ToDate": "1998-05-28T18:28:48.0898508+02:00",
  "AssociateList": [
    {
      "Id": 936,
      "Name": "Swift-Borer",
      "ToolTip": "Debitis impedit.",
      "Deleted": true,
      "Rank": 289,
      "Type": "sed",
      "ColorBlock": 802,
      "IconHint": "fugit",
      "Selected": false,
      "LastChanged": "2003-08-14T18:28:48.0898508+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "ab",
      "Hidden": false,
      "FullName": "Ms. Dylan Kshlerin",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 153
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 826,
      "Name": "Ziemann LLC",
      "ToolTip": "Ex perferendis nesciunt.",
      "Deleted": true,
      "Rank": 581,
      "Type": "quae",
      "ColorBlock": 758,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "1998-04-21T18:28:48.0898508+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perferendis",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Delia Jacobi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 595
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 607,
      "Name": "Hand Group",
      "ToolTip": "Laudantium minus quia.",
      "Deleted": true,
      "Rank": 498,
      "Type": "eos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "animi",
      "ColorBlock": 207,
      "ExtraInfo": "alias",
      "StyleHint": "in",
      "FullName": "Monique Mraz DDS",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 111
        }
      }
    }
  ],
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
      "FieldLength": 24
    }
  }
}
```