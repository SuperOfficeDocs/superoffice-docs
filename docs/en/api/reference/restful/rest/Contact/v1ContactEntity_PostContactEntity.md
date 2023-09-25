---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 171,
  "Name": "Schmidt, Hessel and Rippin",
  "Department": "",
  "OrgNr": "1235465",
  "Number1": "1255463",
  "Number2": "1094748",
  "UpdatedDate": "2010-10-11T03:24:51.4743263+02:00",
  "CreatedDate": "2004-04-29T03:24:51.4743263+02:00",
  "Emails": [
    {
      "Value": "totam",
      "StrippedValue": "tempora",
      "Description": "Organic full-range leverage"
    },
    {
      "Value": "totam",
      "StrippedValue": "tempora",
      "Description": "Organic full-range leverage"
    }
  ],
  "Interests": [
    {
      "Id": 958,
      "Name": "Predovic-Hilll",
      "ToolTip": "Ad aut ratione et est commodi.",
      "Deleted": false,
      "Rank": 551,
      "Type": "laudantium",
      "ColorBlock": 504,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2004-12-31T03:24:51.4743263+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "provident",
      "Hidden": true,
      "FullName": "Telly Adele Zemlak III"
    }
  ],
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "odit",
      "Description": "Configurable 24/7 strategy"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "odit",
      "Description": "Configurable 24/7 strategy"
    }
  ],
  "Phones": [
    {
      "Value": "harum",
      "StrippedValue": "ad",
      "Description": "Customizable dynamic matrices"
    },
    {
      "Value": "harum",
      "StrippedValue": "ad",
      "Description": "Customizable dynamic matrices"
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "doloremque",
      "Description": "Secured maximized initiative"
    },
    {
      "Value": "quia",
      "StrippedValue": "doloremque",
      "Description": "Secured maximized initiative"
    }
  ],
  "Description": "Face to face directional data-warehouse",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minima",
      "PersonId": 386,
      "Mrmrs": "exercitationem",
      "Firstname": "Arjun",
      "Lastname": "Jenkins",
      "MiddleName": "Miller-Bins",
      "Title": "voluptatem",
      "Description": "Profound dynamic structure",
      "Email": "elwyn@boyer.uk",
      "FullName": "Mollie Legros",
      "DirectPhone": "1-263-025-3897 x1343",
      "FormalName": "Auer, Stiedemann and Willms",
      "CountryId": 666,
      "ContactId": 785,
      "ContactName": "Bernier Inc and Sons",
      "Retired": 963,
      "Rank": 825,
      "ActiveInterests": 247,
      "ContactDepartment": "",
      "ContactCountryId": 694,
      "ContactOrgNr": "1013610",
      "FaxPhone": "402.707.0741 x48476",
      "MobilePhone": "(584)177-8465 x131",
      "ContactPhone": "(751)267-2574 x6441",
      "AssociateName": "Reilly-Gottlieb",
      "AssociateId": 538,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "voluptatem",
      "Kanalname": "eius",
      "Post1": "quia",
      "Post2": "nobis",
      "Post3": "ducimus",
      "EmailName": "marvin@predovic.biz",
      "ContactFullName": "Martine Nolan",
      "ActiveErpLinks": 742,
      "TicketPriorityId": 759,
      "SupportLanguageId": 325,
      "SupportAssociateId": 210,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "ratione",
  "Xstop": false,
  "ActiveInterests": 122,
  "GroupId": 403,
  "ActiveStatusMonitorId": 794,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 149,
  "DbiAgentId": 700,
  "DbiLastSyncronized": "2001-07-12T03:24:51.4743263+02:00",
  "DbiKey": "a",
  "DbiLastModified": "2009-05-31T03:24:51.4743263+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 898,
  "ActiveErpLinks": 595,
  "BounceEmails": [
    "anne_hickle@damoreparker.info",
    "heber.bahringer@kihn.uk"
  ],
  "Domains": [
    "velit",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Johanna Katelynn Kuphal MD",
    "SuperOffice:2": "111783638"
  },
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "saepe"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 438,
  "Name": "Marquardt-O'Reilly",
  "Department": "",
  "OrgNr": "793699",
  "Number1": "744778",
  "Number2": "1311136",
  "UpdatedDate": "2017-04-22T03:24:51.4743263+02:00",
  "CreatedDate": "2007-03-05T03:24:51.4743263+01:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "dolor",
      "Description": "Stand-alone eco-centric adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "dolor",
      "Description": "Stand-alone eco-centric adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 725,
      "Name": "Hagenes-Cremin",
      "ToolTip": "Consequuntur ut et tempora qui dolorem et explicabo.",
      "Deleted": false,
      "Rank": 836,
      "Type": "corrupti",
      "ColorBlock": 96,
      "IconHint": "labore",
      "Selected": true,
      "LastChanged": "2010-09-19T03:24:51.4743263+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "commodi",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Miss Stanton Macejkovic",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "sit",
      "Description": "Innovative systemic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "sit",
      "Description": "Innovative systemic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "recusandae",
      "Description": "Face to face responsive intranet",
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
      "Value": "aut",
      "StrippedValue": "recusandae",
      "Description": "Face to face responsive intranet",
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
  "Faxes": [
    {
      "Value": "esse",
      "StrippedValue": "illo",
      "Description": "Digitized web-enabled emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 993
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "illo",
      "Description": "Digitized web-enabled emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 993
        }
      }
    }
  ],
  "Description": "Focused leading edge encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quasi",
      "PersonId": 853,
      "Mrmrs": "consequuntur",
      "Firstname": "Craig",
      "Lastname": "Casper",
      "MiddleName": "Osinski-Herman",
      "Title": "minus",
      "Description": "Vision-oriented multi-tasking access",
      "Email": "mona.schoen@kuhn.info",
      "FullName": "Ms. Raheem Kilback Jr.",
      "DirectPhone": "(293)596-1411 x983",
      "FormalName": "Becker-Raynor",
      "CountryId": 708,
      "ContactId": 285,
      "ContactName": "O'Reilly LLC",
      "Retired": 138,
      "Rank": 769,
      "ActiveInterests": 731,
      "ContactDepartment": "",
      "ContactCountryId": 814,
      "ContactOrgNr": "1058868",
      "FaxPhone": "585-631-6931 x20982",
      "MobilePhone": "733-138-2708 x74867",
      "ContactPhone": "079-723-0180 x11754",
      "AssociateName": "Renner-Mayert",
      "AssociateId": 504,
      "UsePersonAddress": false,
      "ContactFax": "incidunt",
      "Kanafname": "distinctio",
      "Kanalname": "aut",
      "Post1": "blanditiis",
      "Post2": "accusantium",
      "Post3": "voluptas",
      "EmailName": "lenna.baumbach@tremblay.ca",
      "ContactFullName": "Tiana Renner",
      "ActiveErpLinks": 496,
      "TicketPriorityId": 507,
      "SupportLanguageId": 506,
      "SupportAssociateId": 359,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 785
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 256,
  "GroupId": 46,
  "ActiveStatusMonitorId": 797,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 459,
  "DbiAgentId": 681,
  "DbiLastSyncronized": "2016-05-02T03:24:51.4743263+02:00",
  "DbiKey": "in",
  "DbiLastModified": "2000-02-25T03:24:51.4743263+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 855,
  "ActiveErpLinks": 953,
  "BounceEmails": [
    "norval.ritchie@koepp.info",
    "eva@stracke.biz"
  ],
  "Domains": [
    "fugit",
    "ipsam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Manuel Keven Larson II",
    "SuperOffice:2": "107379528"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "debitis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 154
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```