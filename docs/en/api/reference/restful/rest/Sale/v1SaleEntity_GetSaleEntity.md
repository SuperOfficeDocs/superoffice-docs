---
title: GET Sale/{id}
uid: v1SaleEntity_GetSaleEntity
generated: true
content_type: reference
---

# GET Sale/{id}

```http
GET /api/v1/Sale/{id}
```

Gets a SaleEntity object.


Calls the Sale agent service GetSaleEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SaleEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Sale/{id}?$select=name,department,category/id
GET /api/v1/Sale/{id}?fk=True
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

SaleEntity found.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity found. |
| 304 | SaleEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: SaleEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | Appointment | Simple read-only appointment data.  Carrier object for Appointment. Services for the Appointment Carrier is available from the Appointment Agent. |
| Associate | Associate | The sale owner  Use MDO List name "associate" to get list items. |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  Use MDO List name "contact" to get list items. |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  Use MDO List name "project" to get list items. |
| SaleText | string | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  Use MDO List name "person" to get list items. |
| Currency | Currency | The currency the sale object was sold in  Use MDO List name "currency" to get list items. |
| Competitor | Competitor | List of all possible competitors.   Use MDO List name "comptr" to get list items. |
| Credited | Credited | List of who is to be credited for the sale.  Use MDO List name "credited" to get list items. |
| Rating | Rating | The sale rating  Use MDO List name "prob" to get list items. |
| Reason | Reason | The sale reason  Use MDO List name "reason" to get list items. |
| Source | Source | The sale source  Use MDO List name "source" to get list items. |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType | SaleType | Use MDO List name "saletype" to get list items. |
| ReasonSold | ReasonSold | Use MDO List name "reasonsold" to get list items. |
| ReasonStalled | ReasonStalled | Use MDO List name "reasonstalled" to get list items. |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 SaleEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 30 Jul 2005 11:24:53 G7T

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "quaerat",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2010-10-21T11:24:53.5155612+02:00",
  "Amount": 27215.656,
  "SaleId": 714,
  "Earning": 30995.26,
  "EarningPercent": 31039.136,
  "Heading": "impedit",
  "Number": "979437",
  "Probability": 598,
  "CreatedDate": "2008-04-04T11:24:53.5155612+02:00",
  "UpdatedDate": "2005-07-30T11:24:53.5155612+02:00",
  "Completed": "Completed",
  "ActiveLinks": 594,
  "Links": [
    {
      "EntityName": "Murphy-Mann",
      "Id": 350,
      "Description": "Horizontal holistic initiative",
      "ExtraInfo": "quis",
      "LinkId": 582,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "NextDueDate": "2012-04-26T11:24:53.5311857+02:00",
  "Postit": "ut",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "1998-06-28T11:24:53.5311857+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Shields-Balistreri",
      "Comment": "iste",
      "StakeholderRoleId": 55,
      "CountryId": 381,
      "PersonId": 663,
      "EmailDescription": "shana@grady.info",
      "EmailId": 990,
      "EmailAddress": "agustin@hauck.com",
      "PhoneId": 34,
      "ContactName": "Davis LLC",
      "ContactId": 447,
      "SaleId": 582,
      "Mrmrs": "qui",
      "Firstname": "Kenna",
      "MiddleName": "Rodriguez Inc and Sons",
      "Lastname": "Kuhn",
      "SaleStakeholderId": 29,
      "Rank": 180,
      "Phone": "670-552-1793",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 424
        }
      }
    }
  ],
  "ActiveErpLinks": 655,
  "UserDefinedFields": {
    "SuperOffice:1": "65458210",
    "SuperOffice:2": "Mr. Bryce Schroeder MD"
  },
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "veritatis"
  },
  "PublishEventDate": "2011-04-07T11:24:53.5311857+02:00",
  "PublishTo": "1998-12-14T11:24:53.5311857+01:00",
  "PublishFrom": "2004-03-29T11:24:53.5311857+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 369,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    },
    {
      "VisibleId": 369,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 155
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 749
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```