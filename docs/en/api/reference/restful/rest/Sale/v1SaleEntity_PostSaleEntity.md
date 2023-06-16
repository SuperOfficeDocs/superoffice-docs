---
title: POST Sale
uid: v1SaleEntity_PostSaleEntity
generated: true
---

# POST Sale

```http
POST /api/v1/Sale
```

Creates a new SaleEntity


Calls the Sale agent service SaveSaleEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Sale?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaleEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | Appointment | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate | Associate | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency | Currency | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor | Competitor | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited | Credited | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating | Rating | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason | Reason | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source | Source | The sale source  <para>Use MDO List name "source" to get list items.</para> |
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
| SaleType | SaleType | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold | ReasonSold | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled | ReasonStalled | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
POST /api/v1/Sale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "nihil",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2012-06-02T16:00:48.22717+02:00",
  "Amount": 22289.007999999998,
  "SaleId": 264,
  "Earning": 30399.8,
  "EarningPercent": 29907.762,
  "Heading": "nesciunt",
  "Number": "889290",
  "Probability": 508,
  "CreatedDate": "2003-09-06T16:00:48.22717+02:00",
  "UpdatedDate": "1997-09-04T16:00:48.22717+02:00",
  "Completed": "Completed",
  "ActiveLinks": 244,
  "Links": [
    {
      "EntityName": "Adams-O'Conner",
      "Id": 783,
      "Description": "Devolved regional utilisation",
      "ExtraInfo": "aspernatur",
      "LinkId": 621
    },
    {
      "EntityName": "Adams-O'Conner",
      "Id": 783,
      "Description": "Devolved regional utilisation",
      "ExtraInfo": "aspernatur",
      "LinkId": 621
    }
  ],
  "NextDueDate": "2009-01-23T16:00:48.22717+01:00",
  "Postit": "molestiae",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2018-08-14T16:00:48.22717+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Halvorson-Hoppe",
      "Comment": "odit",
      "StakeholderRoleId": 337,
      "CountryId": 807,
      "PersonId": 174,
      "EmailDescription": "maci.wilkinson@kautzer.com",
      "EmailId": 215,
      "EmailAddress": "ollie@oreillywintheiser.biz",
      "PhoneId": 388,
      "ContactName": "Olson, Gusikowski and Becker",
      "ContactId": 136,
      "SaleId": 523,
      "Mrmrs": "sapiente",
      "Firstname": "Sabina",
      "MiddleName": "Tromp, Pagac and Thompson",
      "Lastname": "Flatley",
      "SaleStakeholderId": 121,
      "Rank": 600,
      "Phone": "838-114-9555 x912"
    }
  ],
  "ActiveErpLinks": 196,
  "UserDefinedFields": {
    "SuperOffice:1": "1969172795",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "1996-03-24T16:00:48.2427982+01:00",
  "PublishTo": "2021-01-06T16:00:48.2427982+01:00",
  "PublishFrom": "2022-04-21T16:00:48.2427982+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 259,
      "Visibility": "All",
      "DisplayValue": "est"
    },
    {
      "VisibleId": 259,
      "Visibility": "All",
      "DisplayValue": "est"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "doloribus",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "1996-10-19T16:00:48.2427982+02:00",
  "Amount": 20449.35,
  "SaleId": 824,
  "Earning": 21486.703999999998,
  "EarningPercent": 28810.861999999997,
  "Heading": "quia",
  "Number": "103593",
  "Probability": 343,
  "CreatedDate": "2012-12-21T16:00:48.2427982+01:00",
  "UpdatedDate": "1999-05-31T16:00:48.2427982+02:00",
  "Completed": "Completed",
  "ActiveLinks": 881,
  "Links": [
    {
      "EntityName": "Mann, Johnson and Howe",
      "Id": 864,
      "Description": "Fully-configurable static framework",
      "ExtraInfo": "aut",
      "LinkId": 926,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    }
  ],
  "NextDueDate": "2004-03-07T16:00:48.2427982+01:00",
  "Postit": "voluptates",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2013-01-16T16:00:48.2427982+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Dickens Group",
      "Comment": "doloribus",
      "StakeholderRoleId": 929,
      "CountryId": 979,
      "PersonId": 876,
      "EmailDescription": "amber@kuvalis.ca",
      "EmailId": 828,
      "EmailAddress": "carlotta.turcotte@macejkovic.ca",
      "PhoneId": 938,
      "ContactName": "Konopelski LLC",
      "ContactId": 280,
      "SaleId": 303,
      "Mrmrs": "aut",
      "Firstname": "Werner",
      "MiddleName": "Torp, Kohler and Feeney",
      "Lastname": "Schumm",
      "SaleStakeholderId": 469,
      "Rank": 267,
      "Phone": "360.705.8315",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "ActiveErpLinks": 260,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Litzy Robel DVM",
    "SuperOffice:2": "1532938956"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "quam"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2004-05-03T16:00:48.2427982+02:00",
  "PublishTo": "2005-07-01T16:00:48.2427982+02:00",
  "PublishFrom": "2020-06-09T16:00:48.2427982+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 452,
      "Visibility": "All",
      "DisplayValue": "nemo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    },
    {
      "VisibleId": 452,
      "Visibility": "All",
      "DisplayValue": "nemo",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 961
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```