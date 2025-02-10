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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 986,
  "Name": "Raynor LLC",
  "ProjectNumber": "1362214",
  "ProjectMembers": [
    {
      "ProjectmemberId": 251,
      "ContactId": 105,
      "ProjectId": 276,
      "ContactName": "Lueilwitz Group",
      "ContactDepartment": "",
      "ProjectName": "Legros Group",
      "EmailId": 671,
      "EmailAddress": "matilde_heaney@volkmankling.info",
      "CountryId": 29,
      "Firstname": "Lula",
      "MiddleName": "Jacobson, Quigley and Luettgen",
      "Lastname": "Monahan",
      "PersonId": 679,
      "Mrmrs": "unde",
      "ProjectMemberTypeName": "Lindgren, Beatty and Orn",
      "Phone": "132-147-6817",
      "PhoneId": 731,
      "ProjectMemberTypeId": 446,
      "EmailAddressName": "dominic@gusikowskimoen.biz",
      "Comment": "quia",
      "FullName": "Prof. Marguerite Greg Yundt MD"
    }
  ],
  "Urls": [
    {
      "Value": "excepturi",
      "StrippedValue": "sint",
      "Description": "Multi-channelled actuating strategy"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "sint",
      "Description": "Multi-channelled actuating strategy"
    }
  ],
  "CreatedDate": "2005-01-28T12:01:28.1346745+01:00",
  "UpdatedDate": "2004-11-29T12:01:28.1346745+01:00",
  "Description": "De-engineered exuding moratorium",
  "Postit": "commodi",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Progressive eco-centric protocol",
  "ActiveStatusMonitorId": 125,
  "Links": [
    {
      "EntityName": "Metz, Flatley and Parisian",
      "Id": 16,
      "Description": "Front-line methodical collaboration",
      "ExtraInfo": "et",
      "LinkId": 745
    },
    {
      "EntityName": "Metz, Flatley and Parisian",
      "Id": 16,
      "Description": "Front-line methodical collaboration",
      "ExtraInfo": "et",
      "LinkId": 745
    }
  ],
  "ActiveLinks": 335,
  "Completed": true,
  "NextMilestoneDate": "1997-12-20T12:01:28.1346745+01:00",
  "NmdAppointmentId": 99,
  "EndDate": "2008-11-24T12:01:28.1346745+01:00",
  "ActiveErpLinks": 191,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1146582283"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "quibusdam",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2018-09-08T12:01:28.1346745+02:00",
  "PublishTo": "2009-11-03T12:01:28.1346745+01:00",
  "PublishFrom": "2013-06-05T12:01:28.1346745+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 59,
  "Name": "Hartmann-Schulist",
  "ProjectNumber": "1178799",
  "ProjectMembers": [
    {
      "ProjectmemberId": 818,
      "ContactId": 565,
      "ProjectId": 285,
      "ContactName": "Reynolds, Barrows and Pagac",
      "ContactDepartment": "",
      "ProjectName": "Balistreri, Legros and Wolf",
      "EmailId": 879,
      "EmailAddress": "precious@durgan.com",
      "CountryId": 773,
      "Firstname": "Asha",
      "MiddleName": "Lesch-Abshire",
      "Lastname": "VonRueden",
      "PersonId": 205,
      "Mrmrs": "ducimus",
      "ProjectMemberTypeName": "Auer, Carter and Durgan",
      "Phone": "1-266-662-4442 x52151",
      "PhoneId": 795,
      "ProjectMemberTypeId": 866,
      "EmailAddressName": "eliza_koepp@runteschaden.info",
      "Comment": "aut",
      "FullName": "Lottie Hoeger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestias",
      "StrippedValue": "adipisci",
      "Description": "Reactive user-facing installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "adipisci",
      "Description": "Reactive user-facing installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    }
  ],
  "CreatedDate": "1998-04-08T12:01:28.1346745+02:00",
  "UpdatedDate": "1999-10-21T12:01:28.1346745+02:00",
  "Description": "Networked uniform budgetary management",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Innovative methodical encoding",
  "ActiveStatusMonitorId": 267,
  "Links": [
    {
      "EntityName": "Emard-Willms",
      "Id": 18,
      "Description": "Secured multi-state model",
      "ExtraInfo": "est",
      "LinkId": 754,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 590
        }
      }
    }
  ],
  "ActiveLinks": 27,
  "Completed": false,
  "NextMilestoneDate": "2010-12-14T12:01:28.1346745+01:00",
  "NmdAppointmentId": 465,
  "EndDate": "2009-05-09T12:01:28.1346745+02:00",
  "ActiveErpLinks": 90,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Tomasa Olson",
    "SuperOffice:2": "1964943079"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "nostrum"
  },
  "PublishEventDate": "2020-12-15T12:01:28.1346745+01:00",
  "PublishTo": "2018-06-01T12:01:28.1346745+02:00",
  "PublishFrom": "2009-08-28T12:01:28.1346745+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 567
    }
  }
}
```