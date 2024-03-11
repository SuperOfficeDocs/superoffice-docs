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
  "ProjectId": 985,
  "Name": "Considine Inc and Sons",
  "ProjectNumber": "798103",
  "ProjectMembers": [
    {
      "ProjectmemberId": 238,
      "ContactId": 667,
      "ProjectId": 896,
      "ContactName": "Kautzer, Hoeger and Thiel",
      "ContactDepartment": "",
      "ProjectName": "Roob-Grady",
      "EmailId": 103,
      "EmailAddress": "stephanie@bode.us",
      "CountryId": 689,
      "Firstname": "Kayla",
      "MiddleName": "Jewess Inc and Sons",
      "Lastname": "Runolfsson",
      "PersonId": 185,
      "Mrmrs": "accusantium",
      "ProjectMemberTypeName": "Kozey Group",
      "Phone": "988-821-6346",
      "PhoneId": 78,
      "ProjectMemberTypeId": 774,
      "EmailAddressName": "jeramy_braun@hahn.uk",
      "Comment": "quod",
      "FullName": "Greg Grant"
    }
  ],
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "nulla",
      "Description": "Vision-oriented maximized pricing structure"
    },
    {
      "Value": "numquam",
      "StrippedValue": "nulla",
      "Description": "Vision-oriented maximized pricing structure"
    }
  ],
  "CreatedDate": "2000-11-23T14:23:47.1286345+01:00",
  "UpdatedDate": "2009-02-17T14:23:47.1286345+01:00",
  "Description": "Fundamental systematic website",
  "Postit": "ducimus",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Up-sized 4th generation process improvement",
  "ActiveStatusMonitorId": 272,
  "Links": [
    {
      "EntityName": "Smitham-Orn",
      "Id": 335,
      "Description": "Virtual needs-based extranet",
      "ExtraInfo": "voluptas",
      "LinkId": 970
    },
    {
      "EntityName": "Smitham-Orn",
      "Id": 335,
      "Description": "Virtual needs-based extranet",
      "ExtraInfo": "voluptas",
      "LinkId": 970
    }
  ],
  "ActiveLinks": 427,
  "Completed": false,
  "NextMilestoneDate": "2001-10-30T14:23:47.1286345+01:00",
  "NmdAppointmentId": 544,
  "EndDate": "2006-09-05T14:23:47.1286345+02:00",
  "ActiveErpLinks": 229,
  "UserDefinedFields": {
    "SuperOffice:1": "Boris Jerel Lubowitz IV",
    "SuperOffice:2": "Prof. Triston Raynor"
  },
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "dolores"
  },
  "PublishEventDate": "2021-04-01T14:23:47.1442591+02:00",
  "PublishTo": "2003-09-29T14:23:47.1442591+02:00",
  "PublishFrom": "2022-02-15T14:23:47.1442591+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 475,
  "Name": "Kris, Spencer and Koepp",
  "ProjectNumber": "1319325",
  "ProjectMembers": [
    {
      "ProjectmemberId": 996,
      "ContactId": 159,
      "ProjectId": 511,
      "ContactName": "Predovic Group",
      "ContactDepartment": "",
      "ProjectName": "Hyatt Inc and Sons",
      "EmailId": 805,
      "EmailAddress": "daren_lueilwitz@millsrowe.uk",
      "CountryId": 634,
      "Firstname": "Reginald",
      "MiddleName": "Koss Group",
      "Lastname": "Schiller",
      "PersonId": 141,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Reynolds Group",
      "Phone": "844.657.2591 x8680",
      "PhoneId": 616,
      "ProjectMemberTypeId": 821,
      "EmailAddressName": "terry@wuckertorn.us",
      "Comment": "accusamus",
      "FullName": "Miss Daphnee Hoppe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 514
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "repellendus",
      "Description": "Phased scalable support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "repellendus",
      "Description": "Phased scalable support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 435
        }
      }
    }
  ],
  "CreatedDate": "2023-12-27T14:23:47.1442591+01:00",
  "UpdatedDate": "2016-03-04T14:23:47.1442591+01:00",
  "Description": "Profit-focused well-modulated workforce",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Synchronised impactful matrix",
  "ActiveStatusMonitorId": 959,
  "Links": [
    {
      "EntityName": "Kerluke-Lesch",
      "Id": 900,
      "Description": "Operative local encryption",
      "ExtraInfo": "officia",
      "LinkId": 916,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "ActiveLinks": 1002,
  "Completed": true,
  "NextMilestoneDate": "2014-09-12T14:23:47.1442591+02:00",
  "NmdAppointmentId": 641,
  "EndDate": "2002-09-07T14:23:47.1442591+02:00",
  "ActiveErpLinks": 739,
  "UserDefinedFields": {
    "SuperOffice:1": "1879632854",
    "SuperOffice:2": "Eileen Nitzsche"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "hic"
  },
  "PublishEventDate": "2011-11-17T14:23:47.1442591+01:00",
  "PublishTo": "1998-06-09T14:23:47.1442591+02:00",
  "PublishFrom": "2009-09-01T14:23:47.1442591+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 518
    }
  }
}
```