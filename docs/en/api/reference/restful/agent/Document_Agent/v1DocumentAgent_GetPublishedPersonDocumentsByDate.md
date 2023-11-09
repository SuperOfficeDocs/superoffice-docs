---
title: POST Agents/Document/GetPublishedPersonDocumentsByDate
uid: v1DocumentAgent_GetPublishedPersonDocumentsByDate
generated: true
---

# POST Agents/Document/GetPublishedPersonDocumentsByDate

```http
POST /api/v1/Agents/Document/GetPublishedPersonDocumentsByDate
```

Method that returns a specified number of published document appointments within a time range.


The document appointments belong to the person specified or the document is in a project the person belongs to.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetPublishedPersonDocumentsByDate?$select=name,department,category/id
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

PersonId, IncludeProjectDocuments, StartTime, EndTime, Count 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| IncludeProjectDocuments | Boolean |  |
| StartTime | String |  |
| EndTime | String |  |
| Count | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 | Primary key |
| Attention | string | Attention/salutation |
| Header | string | Visible document name |
| Name | string | File name |
| OurRef | string | Our reference, searchable field from freetext search |
| YourRef | string | Your reference |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| DocumentTemplate | string |  |
| IsPublished | bool | True if document have an entry in published table |
| PersonId | int32 | Person ID of person the appointment is with, may be 0 |
| PersonFullName | string | The full name of the person this document belongs to. |
| AssociateFullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| ContactId | int32 | Contact ID of owning contact, may be 0 |
| ContactName | string | Contact name |
| ProjectId | int32 | ID of project referred to, may be 0 |
| ProjectName | string | Project name |
| AssociateId | int32 | ID of associate whose diary the appointment is in, REQUIRED |
| Snum | int32 | The sequence number allocated from refcount on used template when creating the document |
| SaleId | int32 | Owning sale, if any (may be 0) |
| SaleName | string | Heading of Owning sale, if any. (may be blank) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Document/GetPublishedPersonDocumentsByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 771,
  "IncludeProjectDocuments": false,
  "StartTime": "1996-09-08T11:06:34.3008382+02:00",
  "EndTime": "1996-11-18T11:06:34.3008382+01:00",
  "Count": 951
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DocumentId": 990,
    "Attention": "architecto",
    "Header": "consequuntur",
    "Name": "Schmeler, Dibbert and Schmitt",
    "OurRef": "quod",
    "YourRef": "non",
    "Description": "Cross-platform maximized challenge",
    "DocumentTemplate": "ea",
    "IsPublished": false,
    "PersonId": 805,
    "PersonFullName": "Sabrina Feeney",
    "AssociateFullName": "Dorothea Gulgowski",
    "ContactId": 177,
    "ContactName": "Shanahan-Torphy",
    "ProjectId": 339,
    "ProjectName": "Gaylord-Rippin",
    "AssociateId": 159,
    "Snum": 966,
    "SaleId": 880,
    "SaleName": "Schimmel-Runolfsdottir",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 87
      }
    }
  }
]
```