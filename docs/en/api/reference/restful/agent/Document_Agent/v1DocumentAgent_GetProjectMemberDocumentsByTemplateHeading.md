---
title: POST Agents/Document/GetProjectMemberDocumentsByTemplateHeading
uid: v1DocumentAgent_GetProjectMemberDocumentsByTemplateHeading
generated: true
content_type: reference
---

# POST Agents/Document/GetProjectMemberDocumentsByTemplateHeading

```http
POST /api/v1/Agents/Document/GetProjectMemberDocumentsByTemplateHeading
```

Method that returns a specified number of document appointments within a time range, filtered by document template heading.


The document appointments belong to the project member specified. The heading represents a grouping or filtering of document templates.
NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetProjectMemberDocumentsByTemplateHeading?$select=name,department,category/id
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

PersonId, StartTime, EndTime, Count, TemplateHeadingId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
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
POST /api/v1/Agents/Document/GetProjectMemberDocumentsByTemplateHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 929,
  "StartTime": "2007-06-17T02:30:47.0850878+02:00",
  "EndTime": "1999-04-15T02:30:47.0850878+02:00",
  "Count": 825,
  "TemplateHeadingId": 567
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DocumentId": 307,
    "Attention": "quos",
    "Header": "et",
    "Name": "Bins-Becker",
    "OurRef": "labore",
    "YourRef": "harum",
    "Description": "Managed global alliance",
    "DocumentTemplate": "ut",
    "IsPublished": false,
    "PersonId": 478,
    "PersonFullName": "Dayna Bartoletti",
    "AssociateFullName": "Mr. Lorenz Yvette Nicolas Jr.",
    "ContactId": 428,
    "ContactName": "Moen-Bashirian",
    "ProjectId": 726,
    "ProjectName": "Wyman, Hoeger and Moore",
    "AssociateId": 351,
    "Snum": 784,
    "SaleId": 25,
    "SaleName": "Thiel Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 370
      }
    }
  }
]
```