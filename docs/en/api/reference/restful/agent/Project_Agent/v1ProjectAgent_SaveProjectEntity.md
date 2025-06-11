---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 389,
  "Name": "Fadel, Buckridge and Schoen",
  "ProjectNumber": "998950",
  "ProjectMembers": [
    {
      "ProjectmemberId": 344,
      "ContactId": 677,
      "ProjectId": 250,
      "ContactName": "Skiles-Rutherford",
      "ContactDepartment": "",
      "ProjectName": "Hilll, Ryan and Bailey",
      "EmailId": 165,
      "EmailAddress": "millie.graham@gutmann.uk",
      "CountryId": 924,
      "Firstname": "Davonte",
      "MiddleName": "Haley, Johnson and Jaskolski",
      "Lastname": "Robel",
      "PersonId": 876,
      "Mrmrs": "provident",
      "ProjectMemberTypeName": "Braun Inc and Sons",
      "Phone": "1-774-592-0306",
      "PhoneId": 40,
      "ProjectMemberTypeId": 152,
      "EmailAddressName": "carmel@morissette.co.uk",
      "Comment": "autem",
      "FullName": "Lesly Schneider"
    }
  ],
  "Urls": [
    {
      "Value": "quod",
      "StrippedValue": "aut",
      "Description": "User-centric zero administration algorithm"
    },
    {
      "Value": "quod",
      "StrippedValue": "aut",
      "Description": "User-centric zero administration algorithm"
    }
  ],
  "CreatedDate": "2017-08-10T17:54:03.4608148+02:00",
  "UpdatedDate": "2015-01-29T17:54:03.4608148+01:00",
  "Description": "Programmable 24 hour hardware",
  "Postit": "facere",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "De-engineered mission-critical matrix",
  "ActiveStatusMonitorId": 348,
  "Links": [
    {
      "EntityName": "Breitenberg-Mertz",
      "Id": 922,
      "Description": "Cross-group directional Graphic Interface",
      "ExtraInfo": "ut",
      "LinkId": 185
    },
    {
      "EntityName": "Breitenberg-Mertz",
      "Id": 922,
      "Description": "Cross-group directional Graphic Interface",
      "ExtraInfo": "ut",
      "LinkId": 185
    }
  ],
  "ActiveLinks": 682,
  "Completed": true,
  "NextMilestoneDate": "2009-10-09T17:54:03.4608148+02:00",
  "NmdAppointmentId": 139,
  "EndDate": "2014-08-05T17:54:03.4608148+02:00",
  "ActiveErpLinks": 850,
  "UserDefinedFields": {
    "SuperOffice:1": "Clark Dolly Konopelski Sr.",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "molestias"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "2006-03-21T17:54:03.4608148+01:00",
  "PublishTo": "2020-09-28T17:54:03.4608148+02:00",
  "PublishFrom": "2001-11-02T17:54:03.4608148+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 137,
  "Name": "Gutkowski, Green and Gottlieb",
  "ProjectNumber": "1248564",
  "ProjectMembers": [
    {
      "ProjectmemberId": 465,
      "ContactId": 230,
      "ProjectId": 807,
      "ContactName": "Jenkins-Crona",
      "ContactDepartment": "",
      "ProjectName": "Eichmann, Howe and Dickinson",
      "EmailId": 80,
      "EmailAddress": "herminia_predovic@thompson.com",
      "CountryId": 141,
      "Firstname": "Mabel",
      "MiddleName": "Glover, Swaniawski and Dibbert",
      "Lastname": "Johnston",
      "PersonId": 798,
      "Mrmrs": "temporibus",
      "ProjectMemberTypeName": "Muller Group",
      "Phone": "(534)787-3611 x87518",
      "PhoneId": 352,
      "ProjectMemberTypeId": 901,
      "EmailAddressName": "hope_rice@marks.ca",
      "Comment": "delectus",
      "FullName": "Sim Murphy Schimmel PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 403
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "excepturi",
      "StrippedValue": "omnis",
      "Description": "Down-sized 3rd generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "omnis",
      "Description": "Down-sized 3rd generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "CreatedDate": "2015-06-11T17:54:03.4608148+02:00",
  "UpdatedDate": "2012-11-05T17:54:03.4608148+01:00",
  "Description": "Profit-focused zero tolerance initiative",
  "Postit": "nemo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Progressive transitional synergy",
  "ActiveStatusMonitorId": 198,
  "Links": [
    {
      "EntityName": "Pouros-Hegmann",
      "Id": 492,
      "Description": "Robust secondary encryption",
      "ExtraInfo": "hic",
      "LinkId": 607,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "ActiveLinks": 57,
  "Completed": false,
  "NextMilestoneDate": "2019-12-10T17:54:03.4608148+01:00",
  "NmdAppointmentId": 331,
  "EndDate": "2016-03-19T17:54:03.4608148+01:00",
  "ActiveErpLinks": 83,
  "UserDefinedFields": {
    "SuperOffice:1": "1334850991",
    "SuperOffice:2": "Dr. Maurine Larson II"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "iusto"
  },
  "PublishEventDate": "2024-08-13T17:54:03.4608148+02:00",
  "PublishTo": "2023-03-26T17:54:03.4608148+02:00",
  "PublishFrom": "2018-12-07T17:54:03.4608148+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 119
    }
  }
}
```