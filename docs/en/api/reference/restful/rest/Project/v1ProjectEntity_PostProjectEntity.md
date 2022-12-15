---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

The ProjectEntity to be saved. 

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 663,
  "Name": "Larson-Hettinger",
  "ProjectNumber": "1275563",
  "ProjectMembers": [
    {
      "ProjectmemberId": 738,
      "ContactId": 172,
      "ProjectId": 242,
      "ContactName": "Borer Inc and Sons",
      "ContactDepartment": "transition out-of-the-box functionalities",
      "ProjectName": "Runolfsdottir Inc and Sons",
      "EmailId": 52,
      "EmailAddress": "eleanora.williamson@hahnprice.us",
      "CountryId": 609,
      "Firstname": "Lavon",
      "MiddleName": "Schaefer, Kuhic and Bruen",
      "Lastname": "Beier",
      "PersonId": 608,
      "Mrmrs": "at",
      "ProjectMemberTypeName": "Johns, Conn and Sauer",
      "Phone": "1-937-708-3939",
      "PhoneId": 330,
      "ProjectMemberTypeId": 753,
      "EmailAddressName": "chad@moorehegmann.name",
      "Comment": "est",
      "FullName": "Desmond Langosh"
    }
  ],
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "aut",
      "Description": "Robust optimizing protocol"
    },
    {
      "Value": "totam",
      "StrippedValue": "aut",
      "Description": "Robust optimizing protocol"
    }
  ],
  "CreatedDate": "2005-11-10T02:49:51.3234448+01:00",
  "UpdatedDate": "2022-04-18T02:49:51.3234448+02:00",
  "Description": "Decentralized regional challenge",
  "Postit": "deleniti",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Enhanced holistic instruction set",
  "ActiveStatusMonitorId": 562,
  "Links": [
    {
      "EntityName": "Runolfsson Inc and Sons",
      "Id": 234,
      "Description": "Phased uniform Graphical User Interface",
      "ExtraInfo": "quidem",
      "LinkId": 993
    },
    {
      "EntityName": "Runolfsson Inc and Sons",
      "Id": 234,
      "Description": "Phased uniform Graphical User Interface",
      "ExtraInfo": "quidem",
      "LinkId": 993
    }
  ],
  "ActiveLinks": 376,
  "Completed": false,
  "NextMilestoneDate": "2002-01-06T02:49:51.3234448+01:00",
  "NmdAppointmentId": 546,
  "EndDate": "2022-02-14T02:49:51.3234448+01:00",
  "ActiveErpLinks": 687,
  "UserDefinedFields": {
    "SuperOffice:1": "278288617",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "ipsam"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "2008-01-23T02:49:51.3234448+01:00",
  "PublishTo": "1997-01-16T02:49:51.3234448+01:00",
  "PublishFrom": "2021-02-11T02:49:51.3234448+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 60,
  "Name": "McKenzie-Bosco",
  "ProjectNumber": "787850",
  "ProjectMembers": [
    {
      "ProjectmemberId": 406,
      "ContactId": 271,
      "ProjectId": 853,
      "ContactName": "Reynolds-Nader",
      "ContactDepartment": "",
      "ProjectName": "Kohler Inc and Sons",
      "EmailId": 40,
      "EmailAddress": "domenica@haag.name",
      "CountryId": 483,
      "Firstname": "Dario",
      "MiddleName": "O'Keefe, Farrell and Keebler",
      "Lastname": "Heller",
      "PersonId": 444,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Watsica, Schmidt and Daniel",
      "Phone": "344-702-2261 x2911",
      "PhoneId": 419,
      "ProjectMemberTypeId": 313,
      "EmailAddressName": "terence@parisian.info",
      "Comment": "doloribus",
      "FullName": "Brandy Torp I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 602
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "commodi",
      "Description": "Pre-emptive bandwidth-monitored firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "commodi",
      "Description": "Pre-emptive bandwidth-monitored firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    }
  ],
  "CreatedDate": "2010-01-29T02:49:51.3234448+01:00",
  "UpdatedDate": "2001-04-04T02:49:51.3234448+02:00",
  "Description": "Persevering dynamic migration",
  "Postit": "similique",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Compatible system-worthy matrix",
  "ActiveStatusMonitorId": 990,
  "Links": [
    {
      "EntityName": "Stehr, Hansen and Sporer",
      "Id": 441,
      "Description": "Proactive zero defect extranet",
      "ExtraInfo": "dignissimos",
      "LinkId": 57,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "ActiveLinks": 425,
  "Completed": true,
  "NextMilestoneDate": "2001-01-20T02:49:51.3390666+01:00",
  "NmdAppointmentId": 861,
  "EndDate": "1998-07-15T02:49:51.3390666+02:00",
  "ActiveErpLinks": 175,
  "UserDefinedFields": {
    "SuperOffice:1": "Jules Marvin",
    "SuperOffice:2": "Adrianna Margarett Boyer IV"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2016-05-27T02:49:51.3390666+02:00",
  "PublishTo": "2018-01-10T02:49:51.3390666+01:00",
  "PublishFrom": "2016-02-27T02:49:51.3390666+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 67
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```