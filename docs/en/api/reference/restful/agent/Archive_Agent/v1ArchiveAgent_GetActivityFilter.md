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
  "FromDate": "2003-05-20T11:06:33.7503955+02:00",
  "ToDate": "2018-01-20T11:06:33.7503955+01:00",
  "AssociateList": [
    {
      "Id": 175,
      "Name": "Klocko Group",
      "ToolTip": "Corrupti minima non quidem delectus ea ullam.",
      "Deleted": true,
      "Rank": 643,
      "Type": "dolore",
      "ColorBlock": 826,
      "IconHint": "veritatis",
      "Selected": false,
      "LastChanged": "2002-02-11T11:06:33.7503955+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Chelsea Lemke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 518,
      "Name": "Fritsch Inc and Sons",
      "ToolTip": "Qui eos reprehenderit inventore magni ut facere.",
      "Deleted": false,
      "Rank": 89,
      "Type": "molestiae",
      "ColorBlock": 622,
      "IconHint": "fuga",
      "Selected": true,
      "LastChanged": "2022-09-30T11:06:33.7503955+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Dr. Enrico Kreiger Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 592
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 269,
      "Name": "Harris-Ortiz",
      "ToolTip": "Modi nobis qui et doloremque autem.",
      "Deleted": true,
      "Rank": 673,
      "Type": "distinctio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "cupiditate",
      "ColorBlock": 322,
      "ExtraInfo": "repudiandae",
      "StyleHint": "aut",
      "FullName": "Fabiola Haley IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 451
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 121
    }
  }
}
```