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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "velit",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "1998-01-19T12:57:42.6981992+01:00",
  "Amount": 7201.932,
  "SaleId": 946,
  "Earning": 4418.94,
  "EarningPercent": 4284.178,
  "Heading": "iste",
  "Number": "470994",
  "Probability": 77,
  "CreatedDate": "2000-02-09T12:57:42.6981992+01:00",
  "UpdatedDate": "2016-12-31T12:57:42.6981992+01:00",
  "Completed": "Completed",
  "ActiveLinks": 718,
  "Links": [
    {
      "EntityName": "Runolfsdottir Group",
      "Id": 156,
      "Description": "Adaptive web-enabled paradigm",
      "ExtraInfo": "eum",
      "LinkId": 744
    },
    {
      "EntityName": "Runolfsdottir Group",
      "Id": 156,
      "Description": "Adaptive web-enabled paradigm",
      "ExtraInfo": "eum",
      "LinkId": 744
    }
  ],
  "NextDueDate": "2010-10-13T12:57:42.6981992+02:00",
  "Postit": "est",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2006-01-12T12:57:42.6981992+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Lynch, Hamill and Simonis",
      "Comment": "aut",
      "StakeholderRoleId": 756,
      "CountryId": 5,
      "PersonId": 527,
      "EmailDescription": "eugenia@bergnaum.info",
      "EmailId": 167,
      "EmailAddress": "kaleigh@cassin.co.uk",
      "PhoneId": 456,
      "ContactName": "Littel, Emmerich and Wiegand",
      "ContactId": 942,
      "SaleId": 791,
      "Mrmrs": "dolore",
      "Firstname": "Hobart",
      "MiddleName": "Ziemann-Rempel",
      "Lastname": "Gusikowski",
      "SaleStakeholderId": 591,
      "Rank": 934,
      "Phone": "767.927.7609 x03973"
    }
  ],
  "ActiveErpLinks": 636,
  "UserDefinedFields": {
    "SuperOffice:1": "1488168135",
    "SuperOffice:2": "Jerel Balistreri"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "rerum"
  },
  "PublishEventDate": "2021-11-25T12:57:42.6981992+01:00",
  "PublishTo": "1999-12-25T12:57:42.6981992+01:00",
  "PublishFrom": "2015-11-22T12:57:42.6981992+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 465,
      "Visibility": "All",
      "DisplayValue": "id"
    },
    {
      "VisibleId": 465,
      "Visibility": "All",
      "DisplayValue": "id"
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
  "SaleText": "aut",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2006-07-25T12:57:42.7138204+02:00",
  "Amount": 144.164,
  "SaleId": 645,
  "Earning": 6051.754,
  "EarningPercent": 25915.046,
  "Heading": "ea",
  "Number": "1632063",
  "Probability": 439,
  "CreatedDate": "2000-01-03T12:57:42.7138204+01:00",
  "UpdatedDate": "2006-01-04T12:57:42.7138204+01:00",
  "Completed": "Completed",
  "ActiveLinks": 175,
  "Links": [
    {
      "EntityName": "Paucek, Gibson and Stroman",
      "Id": 223,
      "Description": "Triple-buffered leading edge moratorium",
      "ExtraInfo": "suscipit",
      "LinkId": 779,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    }
  ],
  "NextDueDate": "2022-04-27T12:57:42.7138204+02:00",
  "Postit": "minus",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2012-06-06T12:57:42.7138204+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Towne-Abbott",
      "Comment": "tempora",
      "StakeholderRoleId": 573,
      "CountryId": 915,
      "PersonId": 557,
      "EmailDescription": "letitia.okon@renner.com",
      "EmailId": 857,
      "EmailAddress": "laisha@cassin.ca",
      "PhoneId": 154,
      "ContactName": "Turcotte-Pfannerstill",
      "ContactId": 438,
      "SaleId": 209,
      "Mrmrs": "ullam",
      "Firstname": "Efrain",
      "MiddleName": "Heaney, Hauck and Nolan",
      "Lastname": "Powlowski",
      "SaleStakeholderId": 767,
      "Rank": 425,
      "Phone": "1-869-551-5646",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "ActiveErpLinks": 716,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1696434694"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "eos"
  },
  "PublishEventDate": "2004-04-13T12:57:42.7138204+02:00",
  "PublishTo": "1998-10-19T12:57:42.7138204+02:00",
  "PublishFrom": "2006-07-02T12:57:42.7138204+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 518,
      "Visibility": "All",
      "DisplayValue": "dolore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    },
    {
      "VisibleId": 518,
      "Visibility": "All",
      "DisplayValue": "dolore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 416
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```