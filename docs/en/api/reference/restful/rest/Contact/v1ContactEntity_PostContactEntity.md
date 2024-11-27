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
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 394,
  "Name": "Rippin-Williamson",
  "Department": "",
  "OrgNr": "1472935",
  "Number1": "373182",
  "Number2": "945356",
  "UpdatedDate": "2007-11-09T14:45:12.6307355+01:00",
  "CreatedDate": "2023-04-11T14:45:12.6307355+02:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "iure",
      "Description": "Networked zero administration collaboration"
    },
    {
      "Value": "ea",
      "StrippedValue": "iure",
      "Description": "Networked zero administration collaboration"
    }
  ],
  "Interests": [
    {
      "Id": 510,
      "Name": "Nolan, Kuhic and Keebler",
      "ToolTip": "Corporis dolores beatae.",
      "Deleted": false,
      "Rank": 203,
      "Type": "dignissimos",
      "ColorBlock": 615,
      "IconHint": "possimus",
      "Selected": false,
      "LastChanged": "2006-11-04T14:45:12.6307355+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "doloribus",
      "Hidden": true,
      "FullName": "Amira Padberg DDS"
    }
  ],
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "repellendus",
      "Description": "Self-enabling logistical infrastructure"
    },
    {
      "Value": "totam",
      "StrippedValue": "repellendus",
      "Description": "Self-enabling logistical infrastructure"
    }
  ],
  "Phones": [
    {
      "Value": "eveniet",
      "StrippedValue": "delectus",
      "Description": "Pre-emptive 6th generation protocol"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "delectus",
      "Description": "Pre-emptive 6th generation protocol"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "saepe",
      "Description": "Synchronised motivating solution"
    },
    {
      "Value": "et",
      "StrippedValue": "saepe",
      "Description": "Synchronised motivating solution"
    }
  ],
  "Description": "Profit-focused mission-critical concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 371,
      "Mrmrs": "tempore",
      "Firstname": "Ralph",
      "Lastname": "Bruen",
      "MiddleName": "Rosenbaum Inc and Sons",
      "Title": "aut",
      "Description": "Intuitive neutral approach",
      "Email": "carmine@faheybrakus.com",
      "FullName": "Christop Koch",
      "DirectPhone": "736-533-1501",
      "FormalName": "Bechtelar, Baumbach and Leffler",
      "CountryId": 680,
      "ContactId": 545,
      "ContactName": "Hudson-Effertz",
      "Retired": 476,
      "Rank": 453,
      "ActiveInterests": 604,
      "ContactDepartment": "",
      "ContactCountryId": 282,
      "ContactOrgNr": "1310731",
      "FaxPhone": "1-443-680-6535",
      "MobilePhone": "473.723.3261 x2760",
      "ContactPhone": "1-628-567-0386",
      "AssociateName": "Bailey Inc and Sons",
      "AssociateId": 33,
      "UsePersonAddress": false,
      "ContactFax": "nemo",
      "Kanafname": "et",
      "Kanalname": "ut",
      "Post1": "velit",
      "Post2": "velit",
      "Post3": "autem",
      "EmailName": "noemie@hauck.info",
      "ContactFullName": "Prof. Kiera Armstrong",
      "ActiveErpLinks": 668,
      "TicketPriorityId": 921,
      "SupportLanguageId": 901,
      "SupportAssociateId": 314,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "earum",
  "Xstop": false,
  "ActiveInterests": 621,
  "GroupId": 736,
  "ActiveStatusMonitorId": 181,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 867,
  "DbiAgentId": 14,
  "DbiLastSyncronized": "1999-12-15T14:45:12.6307355+01:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2003-01-15T14:45:12.6307355+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 359,
  "ActiveErpLinks": 555,
  "BounceEmails": [
    "terrell@johnstonweissnat.uk",
    "tamia@schmidtherzog.uk"
  ],
  "Domains": [
    "explicabo",
    "veritatis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1335665670",
    "SuperOffice:2": "332533128"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "tempora"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 95,
  "Name": "Mills, Kihn and Krajcik",
  "Department": "",
  "OrgNr": "947188",
  "Number1": "1217900",
  "Number2": "235602",
  "UpdatedDate": "2008-12-24T14:45:12.6463559+01:00",
  "CreatedDate": "2001-10-30T14:45:12.6463559+01:00",
  "Emails": [
    {
      "Value": "impedit",
      "StrippedValue": "fuga",
      "Description": "User-centric web-enabled archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "fuga",
      "Description": "User-centric web-enabled archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 171,
      "Name": "Hirthe LLC",
      "ToolTip": "Amet sunt voluptatum sint at officiis sed.",
      "Deleted": true,
      "Rank": 966,
      "Type": "et",
      "ColorBlock": 509,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2021-09-27T14:45:12.6463559+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "porro",
      "Hidden": false,
      "FullName": "Eldon Moen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "amet",
      "Description": "Ameliorated object-oriented firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "amet",
      "Description": "Ameliorated object-oriented firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "quaerat",
      "Description": "Automated zero administration application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "quaerat",
      "Description": "Automated zero administration application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 216
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "aliquid",
      "Description": "Fully-configurable intermediate local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "aliquid",
      "Description": "Fully-configurable intermediate local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    }
  ],
  "Description": "Cross-group multimedia project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 847,
      "Mrmrs": "quos",
      "Firstname": "Marshall",
      "Lastname": "Cassin",
      "MiddleName": "Zieme, Nicolas and Jast",
      "Title": "aliquid",
      "Description": "Optimized zero tolerance analyzer",
      "Email": "carolyn@quigley.co.uk",
      "FullName": "Prof. Mya Noemy Kuhic",
      "DirectPhone": "(071)555-4611",
      "FormalName": "Davis, Turcotte and Thiel",
      "CountryId": 696,
      "ContactId": 603,
      "ContactName": "Senger LLC",
      "Retired": 255,
      "Rank": 219,
      "ActiveInterests": 906,
      "ContactDepartment": "transform sexy applications",
      "ContactCountryId": 524,
      "ContactOrgNr": "539679",
      "FaxPhone": "036-058-1236",
      "MobilePhone": "(696)920-8161 x8680",
      "ContactPhone": "480.028.4340 x250",
      "AssociateName": "Ratke, Stokes and Bergstrom",
      "AssociateId": 374,
      "UsePersonAddress": false,
      "ContactFax": "voluptas",
      "Kanafname": "magnam",
      "Kanalname": "vel",
      "Post1": "animi",
      "Post2": "animi",
      "Post3": "vero",
      "EmailName": "aubree@willms.com",
      "ContactFullName": "Mr. Maribel Kunde I",
      "ActiveErpLinks": 51,
      "TicketPriorityId": 274,
      "SupportLanguageId": 154,
      "SupportAssociateId": 123,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 344
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 569,
  "GroupId": 770,
  "ActiveStatusMonitorId": 310,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 654,
  "DbiAgentId": 56,
  "DbiLastSyncronized": "2022-12-28T14:45:12.6463559+01:00",
  "DbiKey": "velit",
  "DbiLastModified": "2017-02-17T14:45:12.6463559+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 734,
  "ActiveErpLinks": 43,
  "BounceEmails": [
    "freeman@denesik.ca",
    "kacey@balistreri.info"
  ],
  "Domains": [
    "nulla",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Selmer Cormier",
    "SuperOffice:2": "Isai Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "dolorem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 22
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```