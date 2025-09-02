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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
Last-Modified: Fri, 24 Jun 2016 03:46:59 G6T

{
  "ContactId": 708,
  "Name": "Prohaska Inc and Sons",
  "Department": "",
  "OrgNr": "862545",
  "Number1": "1042252",
  "Number2": "948292",
  "UpdatedDate": "2016-06-24T03:46:59.8474445+02:00",
  "CreatedDate": "2001-04-14T03:46:59.8474445+02:00",
  "Emails": [
    {
      "Value": "quasi",
      "StrippedValue": "vel",
      "Description": "Compatible needs-based extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "vel",
      "Description": "Compatible needs-based extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 624,
      "Name": "Herman Inc and Sons",
      "ToolTip": "Maxime hic nulla nulla inventore.",
      "Deleted": false,
      "Rank": 740,
      "Type": "quidem",
      "ColorBlock": 615,
      "IconHint": "expedita",
      "Selected": false,
      "LastChanged": "2010-11-06T03:46:59.8474445+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Hortense Langworth PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "optio",
      "StrippedValue": "id",
      "Description": "Distributed grid-enabled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "id",
      "Description": "Distributed grid-enabled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "sequi",
      "Description": "Inverse systematic circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "sequi",
      "Description": "Inverse systematic circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 206
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "libero",
      "Description": "Advanced bottom-line core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "libero",
      "Description": "Advanced bottom-line core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    }
  ],
  "Description": "Universal mission-critical middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "exercitationem",
      "PersonId": 703,
      "Mrmrs": "facilis",
      "Firstname": "Raven",
      "Lastname": "Bartoletti",
      "MiddleName": "Ratke, Gutmann and Walsh",
      "Title": "sed",
      "Description": "Cross-group explicit middleware",
      "Email": "fidel@greenholt.ca",
      "FullName": "Jefferey Yundt",
      "DirectPhone": "(151)353-9723 x527",
      "FormalName": "O'Conner-Wolff",
      "CountryId": 320,
      "ContactId": 186,
      "ContactName": "Stanton-Kuhic",
      "Retired": 499,
      "Rank": 695,
      "ActiveInterests": 33,
      "ContactDepartment": "",
      "ContactCountryId": 815,
      "ContactOrgNr": "820114",
      "FaxPhone": "661.331.8947 x71128",
      "MobilePhone": "013.438.9376 x52456",
      "ContactPhone": "(456)982-0001",
      "AssociateName": "VonRueden Group",
      "AssociateId": 333,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "molestiae",
      "Kanalname": "molestiae",
      "Post1": "omnis",
      "Post2": "alias",
      "Post3": "vitae",
      "EmailName": "jamie@manngibson.info",
      "ContactFullName": "Freeda Wolff",
      "ActiveErpLinks": 973,
      "TicketPriorityId": 365,
      "SupportLanguageId": 667,
      "SupportAssociateId": 547,
      "CategoryName": "VIP Customer",
      "PersonNumber": "822384",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "distinctio",
  "Xstop": false,
  "ActiveInterests": 624,
  "GroupId": 737,
  "ActiveStatusMonitorId": 402,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 848,
  "DbiAgentId": 507,
  "DbiLastSyncronized": "2011-09-09T03:46:59.8474445+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2017-07-22T03:46:59.8474445+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 347,
  "ActiveErpLinks": 146,
  "BounceEmails": [
    "ruben@yost.name",
    "emile@gusikowski.us"
  ],
  "Domains": [
    "ipsam",
    "ut"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Charley Howell Sr.",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 773
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```