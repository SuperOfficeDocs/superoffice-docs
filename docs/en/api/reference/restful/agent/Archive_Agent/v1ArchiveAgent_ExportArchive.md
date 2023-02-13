---
title: POST Agents/Archive/ExportArchive
uid: v1ArchiveAgent_ExportArchive
---

# POST Agents/Archive/ExportArchive

```http
POST /api/v1/Agents/Archive/ExportArchive
```

Exports the target archive to a downloadable format.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/ExportArchive?$select=name,department,category/id
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

ProviderName, Context, DesiredEntities, Columns, SortOrder, Restrictions, ExportType, SelectedRowIds, EstimatedRowCount 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | String |  |
| Context | String |  |
| DesiredEntities | Array |  |
| Columns | Array |  |
| SortOrder | Array |  |
| Restrictions | Array |  |
| ExportType | String |  |
| SelectedRowIds | Array |  |
| EstimatedRowCount | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ExportArchiveResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| BatchTaskId | int32 | Id of the BatchTask created. &lt;=0 if no BatchTask was created. |
| FileName | string | The path to the output file created, if it exists. Will be an empty string if no file was created. |
| Message | string | Descriptive messages; errors, etc. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Archive/ExportArchive
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Parker-Streich",
  "Context": "ex",
  "DesiredEntities": [
    "recusandae",
    "aspernatur"
  ],
  "Columns": [
    "inventore",
    "eveniet"
  ],
  "SortOrder": [
    {
      "Name": "Pouros, Rolfson and Leffler",
      "Direction": "ASC"
    },
    {
      "Name": "Pouros, Rolfson and Leffler",
      "Direction": "ASC"
    }
  ],
  "Restrictions": [
    {
      "Name": "Gutmann, Metz and Parisian",
      "Operator": "et",
      "Values": [
        "odit",
        "incidunt"
      ],
      "DisplayValues": [
        "est",
        "saepe"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 337,
      "InterOperator": "And",
      "UniqueHash": 176
    }
  ],
  "ExportType": "aut",
  "SelectedRowIds": [
    "velit",
    "quia"
  ],
  "EstimatedRowCount": 220
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BatchTaskId": 492,
  "FileName": "Shields, Kirlin and McKenzie",
  "Message": "in",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 956
    }
  }
}
```