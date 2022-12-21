---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: entity  

The ContactEntity to be saved. 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 2,
  "Name": "Considine-Mueller",
  "Department": "",
  "OrgNr": "611473",
  "Number1": "996227",
  "Number2": "1387610",
  "UpdatedDate": "2011-10-30T02:49:50.7765657+01:00",
  "CreatedDate": "2007-07-29T02:49:50.7765657+02:00",
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "sunt",
      "Description": "Object-based asynchronous solution"
    },
    {
      "Value": "dolores",
      "StrippedValue": "sunt",
      "Description": "Object-based asynchronous solution"
    }
  ],
  "Interests": [
    {
      "Id": 473,
      "Name": "Jacobi, Crooks and Collier",
      "ToolTip": "Est magni eligendi non maxime.",
      "Deleted": true,
      "Rank": 168,
      "Type": "debitis",
      "ColorBlock": 661,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2003-10-19T02:49:50.7765657+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "odit",
      "Hidden": false,
      "FullName": "Kirsten Bartoletti"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "assumenda",
      "Description": "Fully-configurable tertiary Graphical User Interface"
    },
    {
      "Value": "aut",
      "StrippedValue": "assumenda",
      "Description": "Fully-configurable tertiary Graphical User Interface"
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "est",
      "Description": "Compatible 24 hour encoding"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "est",
      "Description": "Compatible 24 hour encoding"
    }
  ],
  "Faxes": [
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Horizontal holistic migration"
    },
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Horizontal holistic migration"
    }
  ],
  "Description": "Total client-server functionalities",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "illo",
      "PersonId": 242,
      "Mrmrs": "quos",
      "Firstname": "Rosalia",
      "Lastname": "Oberbrunner",
      "MiddleName": "Abbott-Tromp",
      "Title": "amet",
      "Description": "Vision-oriented bi-directional approach",
      "Email": "mireille.bauch@borer.name",
      "FullName": "Wilhelm Hagenes",
      "DirectPhone": "764.959.0101 x806",
      "FormalName": "O'Hara-Boyle",
      "CountryId": 206,
      "ContactId": 135,
      "ContactName": "Nader, Buckridge and Schumm",
      "Retired": 901,
      "Rank": 122,
      "ActiveInterests": 437,
      "ContactDepartment": "",
      "ContactCountryId": 929,
      "ContactOrgNr": "579052",
      "FaxPhone": "(005)392-1717 x84899",
      "MobilePhone": "616-119-5455 x1654",
      "ContactPhone": "(422)874-7941 x192",
      "AssociateName": "Boehm LLC",
      "AssociateId": 443,
      "UsePersonAddress": false,
      "ContactFax": "doloremque",
      "Kanafname": "minima",
      "Kanalname": "nesciunt",
      "Post1": "fuga",
      "Post2": "nobis",
      "Post3": "nulla",
      "EmailName": "marvin.renner@emard.us",
      "ContactFullName": "Ms. Manuela Schuster I",
      "ActiveErpLinks": 337,
      "TicketPriorityId": 498,
      "SupportLanguageId": 727,
      "SupportAssociateId": 17,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 370,
  "GroupId": 559,
  "ActiveStatusMonitorId": 940,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 133,
  "DbiAgentId": 709,
  "DbiLastSyncronized": "2020-08-12T02:49:50.7765657+02:00",
  "DbiKey": "quod",
  "DbiLastModified": "2014-03-05T02:49:50.7765657+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 823,
  "ActiveErpLinks": 424,
  "BounceEmails": [
    "jared_corwin@lowebradtke.us",
    "landen@beer.info"
  ],
  "Domains": [
    "est",
    "aliquid"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Donnell Jaren Kemmer",
    "SuperOffice:2": "Freddy Delphia Willms PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "dolores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 27,
  "Name": "Cormier, O'Conner and Lemke",
  "Department": "",
  "OrgNr": "181144",
  "Number1": "1227414",
  "Number2": "544628",
  "UpdatedDate": "2019-12-12T02:49:50.7921817+01:00",
  "CreatedDate": "2006-06-06T02:49:50.7921817+02:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "labore",
      "Description": "Reverse-engineered real-time knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "labore",
      "Description": "Reverse-engineered real-time knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 145,
      "Name": "Pfeffer-Mante",
      "ToolTip": "Tempore et.",
      "Deleted": false,
      "Rank": 417,
      "Type": "nemo",
      "ColorBlock": 896,
      "IconHint": "reiciendis",
      "Selected": false,
      "LastChanged": "2010-12-15T02:49:50.7921817+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Mr. Johan Frami IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quam",
      "StrippedValue": "quam",
      "Description": "Persevering assymetric software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "quam",
      "Description": "Persevering assymetric software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "possimus",
      "Description": "Persistent impactful definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "possimus",
      "Description": "Persistent impactful definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "iste",
      "Description": "Monitored empowering data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "iste",
      "Description": "Monitored empowering data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Description": "Front-line maximized paradigm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 66,
      "Mrmrs": "aut",
      "Firstname": "Lottie",
      "Lastname": "Bruen",
      "MiddleName": "O'Kon, Mills and Eichmann",
      "Title": "expedita",
      "Description": "Cross-group system-worthy Graphical User Interface",
      "Email": "ayden@adams.biz",
      "FullName": "Prof. Kristin Shaun Hilpert V",
      "DirectPhone": "108-922-4859 x2702",
      "FormalName": "Carter, Jakubowski and Leannon",
      "CountryId": 259,
      "ContactId": 827,
      "ContactName": "Bergstrom, Keeling and Rowe",
      "Retired": 441,
      "Rank": 507,
      "ActiveInterests": 11,
      "ContactDepartment": "",
      "ContactCountryId": 666,
      "ContactOrgNr": "1198185",
      "FaxPhone": "078-626-2221 x088",
      "MobilePhone": "655-741-4851",
      "ContactPhone": "1-113-464-6384 x05101",
      "AssociateName": "Thompson, Doyle and Herman",
      "AssociateId": 413,
      "UsePersonAddress": false,
      "ContactFax": "vel",
      "Kanafname": "amet",
      "Kanalname": "quasi",
      "Post1": "eos",
      "Post2": "voluptatem",
      "Post3": "est",
      "EmailName": "greg@deckowrenner.com",
      "ContactFullName": "Miss Wiley Stokes Sr.",
      "ActiveErpLinks": 347,
      "TicketPriorityId": 12,
      "SupportLanguageId": 47,
      "SupportAssociateId": 854,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 578
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sit",
  "Xstop": false,
  "ActiveInterests": 373,
  "GroupId": 747,
  "ActiveStatusMonitorId": 250,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 131,
  "DbiAgentId": 788,
  "DbiLastSyncronized": "2004-04-27T02:49:50.7921817+02:00",
  "DbiKey": "necessitatibus",
  "DbiLastModified": "2001-06-09T02:49:50.7921817+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 815,
  "ActiveErpLinks": 157,
  "BounceEmails": [
    "oceane.gleichner@williamson.uk",
    "keagan.brekke@beier.name"
  ],
  "Domains": [
    "voluptas",
    "ullam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "894357093",
    "SuperOffice:2": "Kameron Schimmel"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "eum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 351
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```