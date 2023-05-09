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
  "ProjectId": 452,
  "Name": "Weimann, Grant and Rogahn",
  "ProjectNumber": "1619550",
  "ProjectMembers": [
    {
      "ProjectmemberId": 685,
      "ContactId": 733,
      "ProjectId": 816,
      "ContactName": "Medhurst Inc and Sons",
      "ContactDepartment": "morph visionary supply-chains",
      "ProjectName": "Larson, Torp and Parisian",
      "EmailId": 738,
      "EmailAddress": "flossie.boyle@howelldare.us",
      "CountryId": 54,
      "Firstname": "Adela",
      "MiddleName": "Conroy Inc and Sons",
      "Lastname": "Oberbrunner",
      "PersonId": 516,
      "Mrmrs": "saepe",
      "ProjectMemberTypeName": "Abernathy, Schiller and Collins",
      "Phone": "(581)440-5825",
      "PhoneId": 503,
      "ProjectMemberTypeId": 105,
      "EmailAddressName": "andreanne@sporer.info",
      "Comment": "sequi",
      "FullName": "Bobby Rodriguez"
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "minima",
      "Description": "Horizontal maximized alliance"
    },
    {
      "Value": "in",
      "StrippedValue": "minima",
      "Description": "Horizontal maximized alliance"
    }
  ],
  "CreatedDate": "2007-06-01T03:51:27.912192+02:00",
  "UpdatedDate": "2009-09-05T03:51:27.912192+02:00",
  "Description": "Function-based client-driven projection",
  "Postit": "facilis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Virtual systematic collaboration",
  "ActiveStatusMonitorId": 57,
  "Links": [
    {
      "EntityName": "Watsica-Bashirian",
      "Id": 326,
      "Description": "Customizable responsive framework",
      "ExtraInfo": "sit",
      "LinkId": 398
    },
    {
      "EntityName": "Watsica-Bashirian",
      "Id": 326,
      "Description": "Customizable responsive framework",
      "ExtraInfo": "sit",
      "LinkId": 398
    }
  ],
  "ActiveLinks": 700,
  "Completed": false,
  "NextMilestoneDate": "1998-06-08T03:51:27.912192+02:00",
  "NmdAppointmentId": 791,
  "EndDate": "2013-09-05T03:51:27.912192+02:00",
  "ActiveErpLinks": 539,
  "UserDefinedFields": {
    "SuperOffice:1": "Dannie Powlowski",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "illo"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "repudiandae"
  },
  "PublishEventDate": "2004-12-21T03:51:27.912192+01:00",
  "PublishTo": "2012-12-27T03:51:27.912192+01:00",
  "PublishFrom": "2014-11-24T03:51:27.912192+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 838,
  "Name": "Kshlerin-Weimann",
  "ProjectNumber": "935134",
  "ProjectMembers": [
    {
      "ProjectmemberId": 397,
      "ContactId": 427,
      "ProjectId": 663,
      "ContactName": "Murphy, Dickinson and Greenfelder",
      "ContactDepartment": "",
      "ProjectName": "Flatley-Jones",
      "EmailId": 422,
      "EmailAddress": "nina_langosh@cassinleannon.biz",
      "CountryId": 929,
      "Firstname": "Cicero",
      "MiddleName": "Schaefer-Veum",
      "Lastname": "Lindgren",
      "PersonId": 988,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Pollich LLC",
      "Phone": "796-368-5117 x0698",
      "PhoneId": 955,
      "ProjectMemberTypeId": 434,
      "EmailAddressName": "toby.heaney@block.name",
      "Comment": "debitis",
      "FullName": "Henry Fredy White PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "ut",
      "Description": "Centralized exuding internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "ut",
      "Description": "Centralized exuding internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "CreatedDate": "1997-04-17T03:51:27.912192+02:00",
  "UpdatedDate": "2016-07-03T03:51:27.912192+02:00",
  "Description": "Enhanced grid-enabled parallelism",
  "Postit": "sed",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Down-sized maximized architecture",
  "ActiveStatusMonitorId": 39,
  "Links": [
    {
      "EntityName": "Mills, Berge and Koepp",
      "Id": 706,
      "Description": "Versatile non-volatile Graphic Interface",
      "ExtraInfo": "expedita",
      "LinkId": 288,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "ActiveLinks": 124,
  "Completed": true,
  "NextMilestoneDate": "2012-06-16T03:51:27.912192+02:00",
  "NmdAppointmentId": 909,
  "EndDate": "2021-01-28T03:51:27.912192+01:00",
  "ActiveErpLinks": 775,
  "UserDefinedFields": {
    "SuperOffice:1": "Geraldine Samanta Koepp DDS",
    "SuperOffice:2": "Tillman Boehm"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "2014-06-07T03:51:27.912192+02:00",
  "PublishTo": "2009-10-09T03:51:27.912192+02:00",
  "PublishFrom": "1998-03-01T03:51:27.912192+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 325
    }
  }
}
```