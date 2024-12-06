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
POST /api/v1/Sale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "delectus",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2005-12-06T10:18:00.5512142+01:00",
  "Amount": 16121.296,
  "SaleId": 681,
  "Earning": 3638.574,
  "EarningPercent": 24733.528,
  "Heading": "est",
  "Number": "1540625",
  "Probability": 241,
  "CreatedDate": "2012-11-01T10:18:00.5512142+01:00",
  "UpdatedDate": "2010-10-18T10:18:00.5512142+02:00",
  "Completed": "Completed",
  "ActiveLinks": 899,
  "Links": [
    {
      "EntityName": "Leuschke-Zulauf",
      "Id": 190,
      "Description": "Re-contextualized leading edge help-desk",
      "ExtraInfo": "facere",
      "LinkId": 306
    },
    {
      "EntityName": "Leuschke-Zulauf",
      "Id": 190,
      "Description": "Re-contextualized leading edge help-desk",
      "ExtraInfo": "facere",
      "LinkId": 306
    }
  ],
  "NextDueDate": "2006-05-09T10:18:00.5512142+02:00",
  "Postit": "officia",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2002-01-19T10:18:00.5668397+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Mueller, Conroy and Olson",
      "Comment": "rerum",
      "StakeholderRoleId": 977,
      "CountryId": 938,
      "PersonId": 141,
      "EmailDescription": "joesph@wyman.co.uk",
      "EmailId": 493,
      "EmailAddress": "shany_hauck@blickhuels.biz",
      "PhoneId": 643,
      "ContactName": "Okuneva Inc and Sons",
      "ContactId": 749,
      "SaleId": 827,
      "Mrmrs": "est",
      "Firstname": "Abigail",
      "MiddleName": "Nikolaus, Moore and Jakubowski",
      "Lastname": "Hodkiewicz",
      "SaleStakeholderId": 792,
      "Rank": 839,
      "Phone": "(247)050-6487"
    }
  ],
  "ActiveErpLinks": 113,
  "UserDefinedFields": {
    "SuperOffice:1": "Caterina Alexandrine Heidenreich II",
    "SuperOffice:2": "Rosalee Ondricka"
  },
  "ExtraFields": {
    "ExtraFields1": "aspernatur",
    "ExtraFields2": "esse"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "ex"
  },
  "PublishEventDate": "2016-11-21T10:18:00.5824656+01:00",
  "PublishTo": "2020-04-16T10:18:00.5824656+02:00",
  "PublishFrom": "2010-04-13T10:18:00.5824656+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 141,
      "Visibility": "All",
      "DisplayValue": "vel"
    },
    {
      "VisibleId": 141,
      "Visibility": "All",
      "DisplayValue": "vel"
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
  "SaleText": "labore",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2019-10-07T10:18:00.6605943+02:00",
  "Amount": 363.544,
  "SaleId": 150,
  "Earning": 16494.242,
  "EarningPercent": 7167.458,
  "Heading": "aliquam",
  "Number": "942911",
  "Probability": 283,
  "CreatedDate": "2009-01-13T10:18:00.6605943+01:00",
  "UpdatedDate": "2011-01-23T10:18:00.6605943+01:00",
  "Completed": "Completed",
  "ActiveLinks": 616,
  "Links": [
    {
      "EntityName": "Ankunding, Walsh and Schamberger",
      "Id": 468,
      "Description": "Proactive encompassing initiative",
      "ExtraInfo": "minima",
      "LinkId": 12,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    }
  ],
  "NextDueDate": "2000-02-24T10:18:00.6605943+01:00",
  "Postit": "est",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2014-09-01T10:18:00.6605943+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Schimmel LLC",
      "Comment": "quam",
      "StakeholderRoleId": 256,
      "CountryId": 360,
      "PersonId": 849,
      "EmailDescription": "veronica@little.com",
      "EmailId": 780,
      "EmailAddress": "alanis@kilback.name",
      "PhoneId": 869,
      "ContactName": "DuBuque-Russel",
      "ContactId": 299,
      "SaleId": 67,
      "Mrmrs": "eos",
      "Firstname": "Hans",
      "MiddleName": "Bauch, Homenick and Ziemann",
      "Lastname": "Fisher",
      "SaleStakeholderId": 870,
      "Rank": 345,
      "Phone": "107-661-6001 x788",
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
  "ActiveErpLinks": 525,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Karl Hellen Moore DVM",
    "SuperOffice:2": "1749818978"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "rerum"
  },
  "PublishEventDate": "1999-10-16T10:18:00.6605943+02:00",
  "PublishTo": "1998-01-03T10:18:00.6605943+01:00",
  "PublishFrom": "2018-05-13T10:18:00.6605943+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 728,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    },
    {
      "VisibleId": 728,
      "Visibility": "All",
      "DisplayValue": "dolorem",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 59
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```