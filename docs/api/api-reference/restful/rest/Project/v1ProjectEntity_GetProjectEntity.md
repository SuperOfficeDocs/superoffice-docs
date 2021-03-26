---
title: GET Project/{id}
id: v1ProjectEntity_GetProjectEntity
---

# GET Project/{id}

```http
GET /api/v1/Project/{id}
```

Gets a ProjectEntity object.

Calls the Project agent service GetProjectEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ProjectEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Project/{id}?$select=name,department,category/id
GET /api/v1/Project/{id}?fk=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

The Project Service. The service implements all services working with the Project object



ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity found. |
| 304 | ProjectEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

Response body: object

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

## Sample Request

```http!
GET /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 05 Apr 2007 09:40:59 G4T

{
  "ProjectId": 273,
  "Name": "Christiansen Group",
  "ProjectNumber": "922290",
  "ProjectMembers": [
    {
      "ProjectmemberId": 782,
      "ContactId": 794,
      "ProjectId": 91,
      "ContactName": "Beatty Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Fay Inc and Sons",
      "EmailId": 905,
      "EmailAddress": "lance.gottlieb@sawayn.ca",
      "CountryId": 17,
      "Firstname": "Lauriane",
      "MiddleName": "Rath Inc and Sons",
      "Lastname": "Cronin",
      "PersonId": 935,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "O'Hara LLC",
      "Phone": "884-072-4476",
      "PhoneId": 602,
      "ProjectMemberTypeId": 204,
      "EmailAddressName": "rigoberto.jacobs@emmerich.name",
      "Comment": "aliquam",
      "FullName": "Miss Arlene Schumm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enhance front-end paradigms"
          },
          "FieldType": "System.String",
          "FieldLength": 722
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "est",
      "Description": "Extended didactic hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "est",
      "Description": "Extended didactic hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "CreatedDate": "2010-01-19T09:40:59.4596628+01:00",
  "UpdatedDate": "2007-04-05T09:40:59.4596628+02:00",
  "Description": "Function-based empowering superstructure",
  "Postit": "doloremque",
  "CreatedBy": {
    "AssociateId": 958,
    "Name": "Nienow Group",
    "PersonId": 722,
    "Rank": 842,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 319,
    "FullName": "Elaina Fritsch",
    "FormalName": "Bailey, Kris and Grant",
    "Deleted": true,
    "EjUserId": 346,
    "UserName": "Spencer-White",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize robust channels"
        },
        "FieldType": "System.Int32",
        "FieldLength": 571
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 490,
    "Name": "Erdman, Lockman and Lind",
    "PersonId": 93,
    "Rank": 317,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 854,
    "FullName": "Mrs. Elizabeth Conn",
    "FormalName": "Ratke-Wehner",
    "Deleted": true,
    "EjUserId": 386,
    "UserName": "Bauch Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 9
      }
    }
  },
  "Associate": {
    "AssociateId": 326,
    "Name": "Mertz-O'Kon",
    "PersonId": 639,
    "Rank": 394,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 123,
    "FullName": "Merritt Miller",
    "FormalName": "Jacobi, Lockman and Hilll",
    "Deleted": true,
    "EjUserId": 617,
    "UserName": "Oberbrunner-Schmeler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 39
      }
    }
  },
  "ProjectStatus": {
    "Id": 981,
    "Value": "ducimus",
    "Tooltip": "libero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 992
      }
    }
  },
  "ProjectType": {
    "Id": 588,
    "Value": "numquam",
    "Tooltip": "fuga",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 304
      }
    }
  },
  "HasImage": false,
  "ImageDescription": "Enhanced local neural-net",
  "ActiveStatusMonitorId": 631,
  "Links": [
    {
      "EntityName": "Raynor-Beier",
      "Id": 442,
      "Description": "Public-key executive interface",
      "ExtraInfo": "doloribus",
      "LinkId": 535,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    }
  ],
  "ActiveLinks": 38,
  "Completed": true,
  "NextMilestoneDate": "2014-05-25T09:40:59.4606627+02:00",
  "NmdAppointmentId": 361,
  "EndDate": "2007-02-16T09:40:59.4606627+01:00",
  "ActiveErpLinks": 720,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Rene Greenholt"
  },
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "debitis"
  },
  "PublishEventDate": "2004-08-18T09:40:59.4606627+02:00",
  "PublishTo": "2019-10-11T09:40:59.4606627+02:00",
  "PublishFrom": "2003-01-25T09:40:59.4606627+01:00",
  "IsPublished": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 212
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```