---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
generated: true
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ActivityFilter

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | date-time | The filtering From date |
| ToDate | date-time | The filtering To date |
| AssociateList | array | The list of associates to filter on |
| GroupList | array | The list of groups to filter on |
| FutureDateList | array | The list of future date selections. This is a static MDO list with standard values. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetActivityFilter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2013-07-02T17:54:02.6483551+02:00",
  "ToDate": "2005-08-09T17:54:02.6483551+02:00",
  "AssociateList": [
    {
      "Id": 905,
      "Name": "Franecki-Walker",
      "ToolTip": "Voluptatem omnis itaque doloremque.",
      "Deleted": true,
      "Rank": 801,
      "Type": "eaque",
      "ColorBlock": 303,
      "IconHint": "maiores",
      "Selected": false,
      "LastChanged": "2000-09-23T17:54:02.6483551+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "corrupti",
      "Hidden": false,
      "FullName": "Sigurd Bechtelar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 661
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 526,
      "Name": "Sipes, Haley and Hodkiewicz",
      "ToolTip": "Qui corrupti sapiente odit veritatis officiis.",
      "Deleted": false,
      "Rank": 97,
      "Type": "facilis",
      "ColorBlock": 11,
      "IconHint": "sapiente",
      "Selected": true,
      "LastChanged": "2024-07-04T17:54:02.6483551+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "totam",
      "Hidden": false,
      "FullName": "Ms. Alfreda Volkman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 579
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 775,
      "Name": "Koelpin, Stamm and O'Keefe",
      "ToolTip": "Voluptate dolor ea natus sed ab.",
      "Deleted": true,
      "Rank": 306,
      "Type": "eos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "harum",
      "ColorBlock": 936,
      "ExtraInfo": "quo",
      "StyleHint": "consectetur",
      "FullName": "Brigitte Crist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 736
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 589
    }
  }
}
```