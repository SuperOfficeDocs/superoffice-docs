---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
content_type: reference
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
GET /api/v1/Contact/{id}?fk=True
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 22 Dec 2011 11:24:53 G12T

{
  "ContactId": 331,
  "Name": "Medhurst, Weimann and Lesch",
  "Department": "",
  "OrgNr": "1439374",
  "Number1": "1767510",
  "Number2": "392891",
  "UpdatedDate": "2011-12-22T11:24:53.1093279+01:00",
  "CreatedDate": "2003-08-23T11:24:53.1093279+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "sint",
      "Description": "Mandatory tertiary knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "sint",
      "Description": "Mandatory tertiary knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 575,
      "Name": "Williamson, Bernier and Beahan",
      "ToolTip": "Quasi velit ratione quia.",
      "Deleted": false,
      "Rank": 262,
      "Type": "omnis",
      "ColorBlock": 311,
      "IconHint": "corporis",
      "Selected": false,
      "LastChanged": "2023-01-30T11:24:53.1093279+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Ahmed Maggie Jewess DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "ut",
      "Description": "Fundamental discrete open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 469
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "ut",
      "Description": "Fundamental discrete open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 469
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestiae",
      "StrippedValue": "in",
      "Description": "Phased intermediate secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "in",
      "Description": "Phased intermediate secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "voluptas",
      "Description": "Customizable system-worthy internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "voluptas",
      "Description": "Customizable system-worthy internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "Description": "Intuitive motivating task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 688,
      "Mrmrs": "quidem",
      "Firstname": "Nelda",
      "Lastname": "McGlynn",
      "MiddleName": "Hermann-Hettinger",
      "Title": "vitae",
      "Description": "Function-based methodical hardware",
      "Email": "wilber.gorczany@walshgerhold.us",
      "FullName": "Shawn Garfield Padberg DVM",
      "DirectPhone": "(190)116-4870",
      "FormalName": "Powlowski LLC",
      "CountryId": 544,
      "ContactId": 374,
      "ContactName": "Ziemann, Schamberger and Swaniawski",
      "Retired": 762,
      "Rank": 548,
      "ActiveInterests": 470,
      "ContactDepartment": "",
      "ContactCountryId": 838,
      "ContactOrgNr": "1160006",
      "FaxPhone": "701.294.7223 x51752",
      "MobilePhone": "(191)518-6971",
      "ContactPhone": "1-658-832-1055",
      "AssociateName": "Olson, Stoltenberg and Anderson",
      "AssociateId": 571,
      "UsePersonAddress": true,
      "ContactFax": "quos",
      "Kanafname": "eligendi",
      "Kanalname": "similique",
      "Post1": "ut",
      "Post2": "sint",
      "Post3": "non",
      "EmailName": "nasir.emard@hane.uk",
      "ContactFullName": "Prof. Alexandra Kassulke",
      "ActiveErpLinks": 961,
      "TicketPriorityId": 420,
      "SupportLanguageId": 168,
      "SupportAssociateId": 873,
      "CategoryName": "VIP Customer",
      "PersonNumber": "827800",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 996
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": true,
  "ActiveInterests": 512,
  "GroupId": 211,
  "ActiveStatusMonitorId": 790,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 703,
  "DbiAgentId": 317,
  "DbiLastSyncronized": "1999-09-16T11:24:53.1093279+02:00",
  "DbiKey": "non",
  "DbiLastModified": "2005-03-31T11:24:53.1093279+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 818,
  "ActiveErpLinks": 173,
  "BounceEmails": [
    "asa.labadie@schulist.ca",
    "noel@jastdooley.com"
  ],
  "Domains": [
    "mollitia",
    "dignissimos"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1425378120"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "quibusdam",
    "CustomFields2": "culpa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 370
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```