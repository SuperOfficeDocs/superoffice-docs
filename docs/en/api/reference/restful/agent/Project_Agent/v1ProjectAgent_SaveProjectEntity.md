---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is 0.








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

## Request Body: projectEntity 

The ProjectEntity that is saved 

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
  "ProjectId": 520,
  "Name": "Macejkovic Group",
  "ProjectNumber": "316806",
  "ProjectMembers": [
    {
      "ProjectmemberId": 458,
      "ContactId": 548,
      "ProjectId": 859,
      "ContactName": "Lind-Sanford",
      "ContactDepartment": "",
      "ProjectName": "Batz LLC",
      "EmailId": 862,
      "EmailAddress": "claud_walker@lehner.name",
      "CountryId": 676,
      "Firstname": "Josefa",
      "MiddleName": "Rice, Harris and Champlin",
      "Lastname": "Jacobson",
      "PersonId": 809,
      "Mrmrs": "quia",
      "ProjectMemberTypeName": "Hirthe, Dare and Gaylord",
      "Phone": "1-409-475-5232 x296",
      "PhoneId": 723,
      "ProjectMemberTypeId": 87,
      "EmailAddressName": "iva@oberbrunner.biz",
      "Comment": "cum",
      "FullName": "Lewis Lockman",
      "Registered": "2004-12-07T11:24:48.4688922+01:00",
      "Updated": "2010-04-27T11:24:48.4688922+02:00"
    }
  ],
  "Urls": [
    {
      "Value": "tenetur",
      "StrippedValue": "eum",
      "Description": "Universal even-keeled application"
    },
    {
      "Value": "tenetur",
      "StrippedValue": "eum",
      "Description": "Universal even-keeled application"
    }
  ],
  "CreatedDate": "2008-03-05T11:24:48.4688922+01:00",
  "UpdatedDate": "2015-01-03T11:24:48.4688922+01:00",
  "Description": "Versatile background interface",
  "Postit": "dolorum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Devolved heuristic approach",
  "ActiveStatusMonitorId": 620,
  "Links": [
    {
      "EntityName": "D'Amore, Franecki and Stroman",
      "Id": 125,
      "Description": "Diverse attitude-oriented focus group",
      "ExtraInfo": "tempore",
      "LinkId": 833
    },
    {
      "EntityName": "D'Amore, Franecki and Stroman",
      "Id": 125,
      "Description": "Diverse attitude-oriented focus group",
      "ExtraInfo": "tempore",
      "LinkId": 833
    }
  ],
  "ActiveLinks": 109,
  "Completed": true,
  "NextMilestoneDate": "2022-06-15T11:24:48.4688922+02:00",
  "NmdAppointmentId": 67,
  "EndDate": "2022-12-25T11:24:48.4688922+01:00",
  "ActiveErpLinks": 168,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "502699407"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "1999-05-23T11:24:48.4688922+02:00",
  "PublishTo": "2002-12-06T11:24:48.4688922+01:00",
  "PublishFrom": "2004-01-19T11:24:48.4688922+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 961,
  "Name": "Crooks-Farrell",
  "ProjectNumber": "1844222",
  "ProjectMembers": [
    {
      "ProjectmemberId": 306,
      "ContactId": 715,
      "ProjectId": 992,
      "ContactName": "Heidenreich, Monahan and Sanford",
      "ContactDepartment": "",
      "ProjectName": "Kuphal, Zemlak and Gleichner",
      "EmailId": 902,
      "EmailAddress": "wendell_reilly@hartmann.name",
      "CountryId": 680,
      "Firstname": "Kristofer",
      "MiddleName": "Vandervort-Maggio",
      "Lastname": "Ankunding",
      "PersonId": 729,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Nitzsche Group",
      "Phone": "644-580-0722 x861",
      "PhoneId": 281,
      "ProjectMemberTypeId": 399,
      "EmailAddressName": "dovie.crooks@gutkowski.ca",
      "Comment": "enim",
      "FullName": "Kenna Elizabeth Boyer DDS",
      "Registered": "2019-09-15T11:24:48.4688922+02:00",
      "Updated": "2014-10-19T11:24:48.4688922+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "voluptas",
      "Description": "Total needs-based hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 907
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "voluptas",
      "Description": "Total needs-based hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 907
        }
      }
    }
  ],
  "CreatedDate": "2016-08-27T11:24:48.4688922+02:00",
  "UpdatedDate": "2013-09-14T11:24:48.4688922+02:00",
  "Description": "Proactive holistic emulation",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Decentralized intermediate orchestration",
  "ActiveStatusMonitorId": 51,
  "Links": [
    {
      "EntityName": "Heller, Runolfsson and Tromp",
      "Id": 507,
      "Description": "Distributed static monitoring",
      "ExtraInfo": "non",
      "LinkId": 108,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 792
        }
      }
    }
  ],
  "ActiveLinks": 931,
  "Completed": true,
  "NextMilestoneDate": "2003-04-19T11:24:48.4688922+02:00",
  "NmdAppointmentId": 573,
  "EndDate": "2008-05-13T11:24:48.4688922+02:00",
  "ActiveErpLinks": 760,
  "UserDefinedFields": {
    "SuperOffice:1": "535389007",
    "SuperOffice:2": "Tiana Daugherty"
  },
  "ExtraFields": {
    "ExtraFields1": "accusantium",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "at"
  },
  "PublishEventDate": "2014-08-04T11:24:48.4688922+02:00",
  "PublishTo": "2023-07-11T11:24:48.4688922+02:00",
  "PublishFrom": "2008-03-27T11:24:48.4688922+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 517
    }
  }
}
```