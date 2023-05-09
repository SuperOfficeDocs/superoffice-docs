---
title: POST Agents/Archive/GetActivityFilter
uid: v1ArchiveAgent_GetActivityFilter
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
  "FromDate": "2006-01-26T03:51:26.5531332+01:00",
  "ToDate": "2022-09-24T03:51:26.5531332+02:00",
  "AssociateList": [
    {
      "Id": 258,
      "Name": "Kovacek, Pouros and Pouros",
      "ToolTip": "Dolorum unde quaerat neque perferendis eum repellendus.",
      "Deleted": false,
      "Rank": 686,
      "Type": "et",
      "ColorBlock": 338,
      "IconHint": "ipsum",
      "Selected": false,
      "LastChanged": "2020-02-06T03:51:26.5531332+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "in",
      "Hidden": false,
      "FullName": "Kariane Camille Wilkinson I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 178
        }
      }
    }
  ],
  "GroupList": [
    {
      "Id": 420,
      "Name": "Heathcote-Leannon",
      "ToolTip": "Ipsum qui veritatis.",
      "Deleted": false,
      "Rank": 827,
      "Type": "eligendi",
      "ColorBlock": 876,
      "IconHint": "veniam",
      "Selected": false,
      "LastChanged": "2022-01-27T03:51:26.5531332+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iure",
      "StyleHint": "doloribus",
      "Hidden": false,
      "FullName": "Judd Runolfsdottir",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 348
        }
      }
    }
  ],
  "FutureDateList": [
    {
      "Id": 872,
      "Name": "Mante-Kiehn",
      "ToolTip": "Ut iure eaque voluptatibus autem nisi beatae voluptas.",
      "Deleted": false,
      "Rank": 593,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "at",
      "ColorBlock": 779,
      "ExtraInfo": "sit",
      "StyleHint": "minima",
      "FullName": "Mr. Bridie Shanahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 11
    }
  }
}
```