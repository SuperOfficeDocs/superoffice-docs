---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 149,
  "Name": "Predovic Group",
  "ProjectNumber": "275736",
  "ProjectMembers": [
    {
      "ProjectmemberId": 260,
      "ContactId": 751,
      "ProjectId": 941,
      "ContactName": "Ward, Green and Gleichner",
      "ContactDepartment": "scale compelling web services",
      "ProjectName": "Dooley-Bartoletti",
      "EmailId": 364,
      "EmailAddress": "ellie_cummings@rippin.us",
      "CountryId": 383,
      "Firstname": "Hadley",
      "MiddleName": "Kihn Inc and Sons",
      "Lastname": "Halvorson",
      "PersonId": 856,
      "Mrmrs": "voluptatibus",
      "ProjectMemberTypeName": "O'Keefe-Smith",
      "Phone": "304.966.8652 x6594",
      "PhoneId": 663,
      "ProjectMemberTypeId": 718,
      "EmailAddressName": "janie@heathcote.name",
      "Comment": "aut",
      "FullName": "Llewellyn Kallie Becker MD"
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "blanditiis",
      "Description": "Exclusive clear-thinking customer loyalty"
    },
    {
      "Value": "sit",
      "StrippedValue": "blanditiis",
      "Description": "Exclusive clear-thinking customer loyalty"
    }
  ],
  "CreatedDate": "2014-06-13T12:15:19.80074+02:00",
  "UpdatedDate": "2009-08-16T12:15:19.80074+02:00",
  "Description": "Adaptive national definition",
  "Postit": "nihil",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Monitored explicit Graphical User Interface",
  "ActiveStatusMonitorId": 458,
  "Links": [
    {
      "EntityName": "Halvorson LLC",
      "Id": 99,
      "Description": "Open-architected motivating website",
      "ExtraInfo": "quasi",
      "LinkId": 541
    },
    {
      "EntityName": "Halvorson LLC",
      "Id": 99,
      "Description": "Open-architected motivating website",
      "ExtraInfo": "quasi",
      "LinkId": 541
    }
  ],
  "ActiveLinks": 113,
  "Completed": true,
  "NextMilestoneDate": "2015-08-05T12:15:19.8017394+02:00",
  "NmdAppointmentId": 546,
  "EndDate": "2002-03-13T12:15:19.8017394+01:00",
  "ActiveErpLinks": 718,
  "UserDefinedFields": {
    "SuperOffice:1": "Aletha Earlene Weissnat V",
    "SuperOffice:2": "2078656254"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "commodi",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2005-01-07T12:15:19.8027393+01:00",
  "PublishTo": "2010-11-12T12:15:19.8027393+01:00",
  "PublishFrom": "2000-05-28T12:15:19.8027393+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 176,
  "Name": "Emard-Conroy",
  "ProjectNumber": "761026",
  "ProjectMembers": [
    {
      "ProjectmemberId": 636,
      "ContactId": 555,
      "ProjectId": 429,
      "ContactName": "Macejkovic LLC",
      "ContactDepartment": "",
      "ProjectName": "Johnston-Crona",
      "EmailId": 834,
      "EmailAddress": "rowland@turcottehaley.co.uk",
      "CountryId": 682,
      "Firstname": "Mary",
      "MiddleName": "Lakin-Nolan",
      "Lastname": "Runolfsdottir",
      "PersonId": 867,
      "Mrmrs": "similique",
      "ProjectMemberTypeName": "Renner Inc and Sons",
      "Phone": "326-562-3759 x34890",
      "PhoneId": 574,
      "ProjectMemberTypeId": 776,
      "EmailAddressName": "adolf.hegmann@rice.biz",
      "Comment": "repellendus",
      "FullName": "Buster Schmidt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "occaecati",
      "StrippedValue": "sunt",
      "Description": "Secured logistical portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "sunt",
      "Description": "Secured logistical portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "CreatedDate": "2005-11-22T12:15:19.8067395+01:00",
  "UpdatedDate": "2014-06-13T12:15:19.8067395+02:00",
  "Description": "Seamless didactic alliance",
  "Postit": "ea",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Ameliorated context-sensitive solution",
  "ActiveStatusMonitorId": 34,
  "Links": [
    {
      "EntityName": "Kunze Inc and Sons",
      "Id": 56,
      "Description": "Innovative encompassing complexity",
      "ExtraInfo": "sapiente",
      "LinkId": 1001,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    }
  ],
  "ActiveLinks": 311,
  "Completed": true,
  "NextMilestoneDate": "2006-05-27T12:15:19.8077391+02:00",
  "NmdAppointmentId": 537,
  "EndDate": "1997-03-14T12:15:19.8077391+01:00",
  "ActiveErpLinks": 559,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Raoul Thompson"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "sint"
  },
  "PublishEventDate": "2003-10-11T12:15:19.8087395+02:00",
  "PublishTo": "2019-12-23T12:15:19.8087395+01:00",
  "PublishFrom": "2012-02-06T12:15:19.8087395+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 204
    }
  }
}
```