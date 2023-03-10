---
title: PUT Sale/{id}
uid: v1SaleEntity_PutSaleEntity
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "tempore",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2008-04-03T12:15:27.2946332+02:00",
  "Amount": 22834.324,
  "SaleId": 918,
  "Earning": 12363.63,
  "EarningPercent": 25799.088,
  "Heading": "accusantium",
  "Number": "1270568",
  "Probability": 234,
  "CreatedDate": "2000-07-01T12:15:27.2946332+02:00",
  "UpdatedDate": "2019-03-12T12:15:27.2946332+01:00",
  "Completed": "Completed",
  "ActiveLinks": 780,
  "Links": [
    {
      "EntityName": "O'Connell-Marvin",
      "Id": 62,
      "Description": "Profit-focused foreground service-desk",
      "ExtraInfo": "quia",
      "LinkId": 998
    },
    {
      "EntityName": "O'Connell-Marvin",
      "Id": 62,
      "Description": "Profit-focused foreground service-desk",
      "ExtraInfo": "quia",
      "LinkId": 998
    }
  ],
  "NextDueDate": "2020-01-16T12:15:27.2946332+01:00",
  "Postit": "hic",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2013-07-25T12:15:27.2956411+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Walter Group",
      "Comment": "possimus",
      "StakeholderRoleId": 362,
      "CountryId": 172,
      "PersonId": 849,
      "EmailDescription": "taya.jewess@marvincollier.biz",
      "EmailId": 720,
      "EmailAddress": "liliana_hermann@langworthkshlerin.ca",
      "PhoneId": 338,
      "ContactName": "Runolfsson-Krajcik",
      "ContactId": 208,
      "SaleId": 836,
      "Mrmrs": "nulla",
      "Firstname": "Christian",
      "MiddleName": "Greenholt, Kessler and O'Kon",
      "Lastname": "Kassulke",
      "SaleStakeholderId": 699,
      "Rank": 763,
      "Phone": "(832)576-6253"
    }
  ],
  "ActiveErpLinks": 51,
  "UserDefinedFields": {
    "SuperOffice:1": "Etha Altenwerth",
    "SuperOffice:2": "Cristina Vandervort Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "porro"
  },
  "PublishEventDate": "2017-03-07T12:15:27.2966306+01:00",
  "PublishTo": "2011-05-21T12:15:27.2966306+02:00",
  "PublishFrom": "2022-09-09T12:15:27.2966306+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 194,
      "Visibility": "All",
      "DisplayValue": "autem"
    },
    {
      "VisibleId": 194,
      "Visibility": "All",
      "DisplayValue": "autem"
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
  "SaleText": "vel",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2001-11-29T12:15:27.3096331+01:00",
  "Amount": 9668.39,
  "SaleId": 481,
  "Earning": 15281.384,
  "EarningPercent": 14751.738,
  "Heading": "fugit",
  "Number": "1079508",
  "Probability": 130,
  "CreatedDate": "2002-10-24T12:15:27.3096331+02:00",
  "UpdatedDate": "2014-07-13T12:15:27.3096331+02:00",
  "Completed": "Completed",
  "ActiveLinks": 664,
  "Links": [
    {
      "EntityName": "VonRueden-Emmerich",
      "Id": 500,
      "Description": "Persistent multi-tasking core",
      "ExtraInfo": "sequi",
      "LinkId": 874,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    }
  ],
  "NextDueDate": "2010-02-03T12:15:27.3096331+01:00",
  "Postit": "id",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2015-09-15T12:15:27.310631+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Dicki LLC",
      "Comment": "autem",
      "StakeholderRoleId": 477,
      "CountryId": 205,
      "PersonId": 139,
      "EmailDescription": "maynard_yundt@schaefer.com",
      "EmailId": 419,
      "EmailAddress": "kariane@conngulgowski.info",
      "PhoneId": 716,
      "ContactName": "Dare, Green and Wyman",
      "ContactId": 878,
      "SaleId": 76,
      "Mrmrs": "eaque",
      "Firstname": "Skyla",
      "MiddleName": "Moen-Bauch",
      "Lastname": "Zulauf",
      "SaleStakeholderId": 77,
      "Rank": 20,
      "Phone": "(153)192-2468",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    }
  ],
  "ActiveErpLinks": 155,
  "UserDefinedFields": {
    "SuperOffice:1": "Wilfred Klocko",
    "SuperOffice:2": "Janick Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "sit"
  },
  "PublishEventDate": "2007-07-10T12:15:27.3116309+02:00",
  "PublishTo": "1996-01-12T12:15:27.3116309+01:00",
  "PublishFrom": "2000-03-25T12:15:27.3116309+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 991,
      "Visibility": "All",
      "DisplayValue": "mollitia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 583
        }
      }
    },
    {
      "VisibleId": 991,
      "Visibility": "All",
      "DisplayValue": "mollitia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 583
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 248
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```