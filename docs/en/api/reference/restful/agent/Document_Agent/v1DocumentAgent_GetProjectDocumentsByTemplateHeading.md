---
title: POST Agents/Document/GetProjectDocumentsByTemplateHeading
uid: v1DocumentAgent_GetProjectDocumentsByTemplateHeading
generated: true
---

# POST Agents/Document/GetProjectDocumentsByTemplateHeading

```http
POST /api/v1/Agents/Document/GetProjectDocumentsByTemplateHeading
```

Method that returns a specified number of document appointments within a time range, filtered by document template heading.


The document appointments belong to the project specified. The heading represents a grouping or filtering of document templates.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetProjectDocumentsByTemplateHeading?$select=name,department,category/id
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

ProjectId, StartTime, EndTime, Count, TemplateHeadingId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer |  |
| StartTime | String |  |
| EndTime | String |  |
| Count | Integer |  |
| TemplateHeadingId | Integer |  |

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
POST /api/v1/Agents/Document/GetProjectDocumentsByTemplateHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 722,
  "StartTime": "2018-04-10T13:38:13.4208858+02:00",
  "EndTime": "2009-05-12T13:38:13.4208858+02:00",
  "Count": 70,
  "TemplateHeadingId": 242
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DocumentId": 256,
    "Attention": "atque",
    "Header": "nam",
    "Name": "Wiegand-Greenfelder",
    "OurRef": "at",
    "YourRef": "omnis",
    "Description": "Pre-emptive asynchronous collaboration",
    "DocumentTemplate": "iusto",
    "IsPublished": true,
    "PersonId": 63,
    "PersonFullName": "Ms. Bonnie Bernhard",
    "AssociateFullName": "Miss Adan Wisoky IV",
    "ContactId": 805,
    "ContactName": "Rowe, Wiegand and Haag",
    "ProjectId": 395,
    "ProjectName": "Corwin-Wiza",
    "AssociateId": 415,
    "Snum": 326,
    "SaleId": 747,
    "SaleName": "Stroman-DuBuque",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 864
      }
    }
  }
]
```