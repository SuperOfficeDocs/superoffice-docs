---
title: PUT Sale/{id}
uid: v1SaleEntity_PutSaleEntity
generated: true
---

# PUT Sale/{id}

```http
PUT /api/v1/Sale/{id}
```

Updates the existing SaleEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Sale/{id}?$select=name,department,category/id
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

## Request Body: entity 

The SaleEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | Appointment | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate | Associate | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | String | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency | Currency | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor | Competitor | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited | Credited | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating | Rating | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason | Reason | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source | Source | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | String | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | String | (expected / lost / won) sales date |
| Amount | Number | Total sale amount |
| SaleId | Integer | Primary key |
| Earning | Number | Earning on sale |
| EarningPercent | Number | Earning as percent of total |
| Heading | String | Sale heading (short description?) |
| Number | String | Alphanumeric user field |
| Probability | Integer | Actual probability, may differ from the one in the list |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated  in UTC. |
| Completed | String | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | Integer | Number of active links to sale, document, appointment. |
| Links | Array | List of all elements linked to the sale. |
| NextDueDate | String | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType | SaleType | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold | ReasonSold | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled | ReasonStalled | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | String | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | Array |  |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

SaleEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity updated. |
| 412 | Update stopped because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "recusandae",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2006-11-03T13:14:09.1029925+01:00",
  "Amount": 16368.882,
  "SaleId": 154,
  "Earning": 25021.856,
  "EarningPercent": 10890.65,
  "Heading": "minima",
  "Number": "1161628",
  "Probability": 937,
  "CreatedDate": "2002-03-16T13:14:09.1029925+01:00",
  "UpdatedDate": "2009-05-04T13:14:09.1029925+02:00",
  "Completed": "Completed",
  "ActiveLinks": 376,
  "Links": [
    {
      "EntityName": "Cummerata, Blick and Senger",
      "Id": 852,
      "Description": "Customizable bifurcated analyzer",
      "ExtraInfo": "non",
      "LinkId": 909
    },
    {
      "EntityName": "Cummerata, Blick and Senger",
      "Id": 852,
      "Description": "Customizable bifurcated analyzer",
      "ExtraInfo": "non",
      "LinkId": 909
    }
  ],
  "NextDueDate": "2010-01-12T13:14:09.1029925+01:00",
  "Postit": "ratione",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2006-06-17T13:14:09.1029925+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Romaguera LLC",
      "Comment": "consequuntur",
      "StakeholderRoleId": 128,
      "CountryId": 342,
      "PersonId": 428,
      "EmailDescription": "alejandra_feeney@ryan.uk",
      "EmailId": 122,
      "EmailAddress": "orland@gaylord.ca",
      "PhoneId": 258,
      "ContactName": "Wehner Inc and Sons",
      "ContactId": 685,
      "SaleId": 57,
      "Mrmrs": "natus",
      "Firstname": "Adeline",
      "MiddleName": "Cronin, O'Keefe and Herzog",
      "Lastname": "Grimes",
      "SaleStakeholderId": 581,
      "Rank": 306,
      "Phone": "173.990.9006 x151"
    }
  ],
  "ActiveErpLinks": 888,
  "UserDefinedFields": {
    "SuperOffice:1": "Kaya Gottlieb",
    "SuperOffice:2": "Mr. Esta O'Kon"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "alias"
  },
  "PublishEventDate": "2015-11-12T13:14:09.1185073+01:00",
  "PublishTo": "2024-03-03T13:14:09.1185073+01:00",
  "PublishFrom": "2011-06-10T13:14:09.1185073+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 168,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 168,
      "Visibility": "All",
      "DisplayValue": "et"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 SaleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "nesciunt",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "1998-01-01T13:14:09.1185073+01:00",
  "Amount": 10006.862,
  "SaleId": 921,
  "Earning": 6424.7,
  "EarningPercent": 23761.987999999998,
  "Heading": "est",
  "Number": "788462",
  "Probability": 241,
  "CreatedDate": "1998-07-08T13:14:09.1185073+02:00",
  "UpdatedDate": "2010-10-16T13:14:09.1185073+02:00",
  "Completed": "Completed",
  "ActiveLinks": 931,
  "Links": [
    {
      "EntityName": "Brakus-Rath",
      "Id": 908,
      "Description": "Vision-oriented high-level knowledge base",
      "ExtraInfo": "officia",
      "LinkId": 292,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    }
  ],
  "NextDueDate": "2024-07-26T13:14:09.1185073+02:00",
  "Postit": "unde",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2005-05-14T13:14:09.1185073+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Ortiz, Lakin and Bogisich",
      "Comment": "ipsam",
      "StakeholderRoleId": 78,
      "CountryId": 939,
      "PersonId": 411,
      "EmailDescription": "jaclyn.dubuque@corwinmueller.biz",
      "EmailId": 183,
      "EmailAddress": "jaida_kautzer@murazik.info",
      "PhoneId": 347,
      "ContactName": "Bergnaum LLC",
      "ContactId": 599,
      "SaleId": 714,
      "Mrmrs": "velit",
      "Firstname": "Stephan",
      "MiddleName": "Ondricka-Gottlieb",
      "Lastname": "Zulauf",
      "SaleStakeholderId": 541,
      "Rank": 756,
      "Phone": "1-727-792-2407 x4741",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "ActiveErpLinks": 568,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Miles Feil"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "velit"
  },
  "PublishEventDate": "2020-12-10T13:14:09.1185073+01:00",
  "PublishTo": "2006-12-11T13:14:09.1185073+01:00",
  "PublishFrom": "2000-05-02T13:14:09.1185073+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 625,
      "Visibility": "All",
      "DisplayValue": "voluptate",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 757
        }
      }
    },
    {
      "VisibleId": 625,
      "Visibility": "All",
      "DisplayValue": "voluptate",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 757
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 606
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```