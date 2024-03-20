---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=False
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


## Response:

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 28 Mar 2001 12:19:53 G3T

{
  "ContactId": 565,
  "Name": "Marks Group",
  "Department": "",
  "OrgNr": "1467807",
  "Number1": "1347469",
  "Number2": "1372085",
  "UpdatedDate": "2001-03-28T12:19:53.2274553+02:00",
  "CreatedDate": "2005-04-23T12:19:53.2274553+02:00",
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "est",
      "Description": "Horizontal stable productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "est",
      "Description": "Horizontal stable productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 61,
      "Name": "Kling, Fay and Brown",
      "ToolTip": "Cupiditate cumque possimus accusantium qui similique adipisci et.",
      "Deleted": false,
      "Rank": 167,
      "Type": "sed",
      "ColorBlock": 825,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2003-05-28T12:19:53.2274553+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "dignissimos",
      "Hidden": false,
      "FullName": "Lamont Will",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Object-based national firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Object-based national firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "facilis",
      "StrippedValue": "numquam",
      "Description": "Mandatory even-keeled firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "numquam",
      "Description": "Mandatory even-keeled firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eius",
      "StrippedValue": "labore",
      "Description": "Upgradable modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "labore",
      "Description": "Upgradable modular process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    }
  ],
  "Description": "Adaptive zero administration application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 886,
      "Mrmrs": "vero",
      "Firstname": "Merl",
      "Lastname": "VonRueden",
      "MiddleName": "Ortiz LLC",
      "Title": "consequatur",
      "Description": "Automated full-range budgetary management",
      "Email": "green@halvorson.ca",
      "FullName": "Clark Ondricka",
      "DirectPhone": "112.900.5046 x1075",
      "FormalName": "Rice-Windler",
      "CountryId": 565,
      "ContactId": 587,
      "ContactName": "Armstrong LLC",
      "Retired": 797,
      "Rank": 118,
      "ActiveInterests": 158,
      "ContactDepartment": "",
      "ContactCountryId": 998,
      "ContactOrgNr": "1118330",
      "FaxPhone": "(096)283-3720",
      "MobilePhone": "1-119-136-1727",
      "ContactPhone": "(271)829-9664",
      "AssociateName": "Oberbrunner Group",
      "AssociateId": 283,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "suscipit",
      "Kanalname": "qui",
      "Post1": "aut",
      "Post2": "voluptate",
      "Post3": "quo",
      "EmailName": "gonzalo@bauch.uk",
      "ContactFullName": "Brenda Bechtelar",
      "ActiveErpLinks": 532,
      "TicketPriorityId": 404,
      "SupportLanguageId": 141,
      "SupportAssociateId": 223,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 976
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolor",
  "Xstop": true,
  "ActiveInterests": 103,
  "GroupId": 307,
  "ActiveStatusMonitorId": 306,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 274,
  "DbiAgentId": 593,
  "DbiLastSyncronized": "2005-11-10T12:19:53.2274553+01:00",
  "DbiKey": "voluptate",
  "DbiLastModified": "2007-11-22T12:19:53.2274553+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 825,
  "ActiveErpLinks": 252,
  "BounceEmails": [
    "kennedy_hoppe@bogisich.biz",
    "devan.runolfsdottir@rohanhills.biz"
  ],
  "Domains": [
    "illum",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Conor Ruby Smith IV",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 850
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```