---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty

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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 605,
  "Name": "Zemlak Inc and Sons",
  "Department": "",
  "OrgNr": "1142582",
  "Number1": "690290",
  "Number2": "1065516",
  "UpdatedDate": "2003-12-18T11:10:26.2325556+01:00",
  "CreatedDate": "2018-05-09T11:10:26.2325556+02:00",
  "Emails": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "ut",
      "Description": "Automated content-based hub"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "ut",
      "Description": "Automated content-based hub"
    }
  ],
  "Interests": [
    {
      "Id": 548,
      "Name": "Leffler Inc and Sons",
      "ToolTip": "Quis sed inventore excepturi.",
      "Deleted": false,
      "Rank": 287,
      "Type": "enim",
      "ColorBlock": 721,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2020-12-27T11:10:26.2325556+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "nostrum",
      "Hidden": false,
      "FullName": "Shanon Zemlak"
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "atque",
      "Description": "Right-sized 24 hour superstructure"
    },
    {
      "Value": "facilis",
      "StrippedValue": "atque",
      "Description": "Right-sized 24 hour superstructure"
    }
  ],
  "Phones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "ut",
      "Description": "Profound cohesive database"
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "ut",
      "Description": "Profound cohesive database"
    }
  ],
  "Faxes": [
    {
      "Value": "nulla",
      "StrippedValue": "dicta",
      "Description": "Front-line logistical info-mediaries"
    },
    {
      "Value": "nulla",
      "StrippedValue": "dicta",
      "Description": "Front-line logistical info-mediaries"
    }
  ],
  "Description": "User-friendly stable frame",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 547,
      "Mrmrs": "sequi",
      "Firstname": "Angelita",
      "Lastname": "Jacobson",
      "MiddleName": "Hegmann, Hagenes and Swift",
      "Title": "perferendis",
      "Description": "Reactive 5th generation knowledge user",
      "Email": "maximilian@corwindenesik.name",
      "FullName": "Nicholas Quigley",
      "DirectPhone": "1-010-289-8476",
      "FormalName": "Graham Inc and Sons",
      "CountryId": 539,
      "ContactId": 929,
      "ContactName": "Tromp Inc and Sons",
      "Retired": 562,
      "Rank": 587,
      "ActiveInterests": 761,
      "ContactDepartment": "",
      "ContactCountryId": 480,
      "ContactOrgNr": "580265",
      "FaxPhone": "725.099.7041 x723",
      "MobilePhone": "553-616-7467",
      "ContactPhone": "482.175.3927 x81389",
      "AssociateName": "Lesch, Grant and O'Reilly",
      "AssociateId": 560,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "suscipit",
      "Kanalname": "qui",
      "Post1": "voluptatibus",
      "Post2": "nisi",
      "Post3": "natus",
      "EmailName": "jayson@heathcote.uk",
      "ContactFullName": "Merl Bergnaum",
      "ActiveErpLinks": 997,
      "TicketPriorityId": 856,
      "SupportLanguageId": 605,
      "SupportAssociateId": 833,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "explicabo",
  "Xstop": true,
  "ActiveInterests": 515,
  "GroupId": 772,
  "ActiveStatusMonitorId": 15,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 498,
  "DbiAgentId": 780,
  "DbiLastSyncronized": "2006-10-03T11:10:26.2365527+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2016-11-02T11:10:26.2365527+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 720,
  "ActiveErpLinks": 394,
  "BounceEmails": [
    "hilbert@conroy.biz",
    "gustave.prosacco@mraz.biz"
  ],
  "Domains": [
    "alias",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Glenna Jonatan Maggio PhD",
    "SuperOffice:2": "Erin Denesik"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "est"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 960,
  "Name": "Jewess-Breitenberg",
  "Department": "",
  "OrgNr": "813288",
  "Number1": "993753",
  "Number2": "558256",
  "UpdatedDate": "2016-10-31T11:10:26.2455614+01:00",
  "CreatedDate": "2019-03-01T11:10:26.2455614+01:00",
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "voluptates",
      "Description": "Cross-group zero tolerance success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "voluptates",
      "Description": "Cross-group zero tolerance success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 717,
      "Name": "Veum Group",
      "ToolTip": "Labore atque et non neque.",
      "Deleted": false,
      "Rank": 218,
      "Type": "ab",
      "ColorBlock": 722,
      "IconHint": "cumque",
      "Selected": false,
      "LastChanged": "2009-07-30T11:10:26.2455614+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatibus",
      "StyleHint": "perspiciatis",
      "Hidden": false,
      "FullName": "Wallace Bashirian",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 180
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloremque",
      "StrippedValue": "autem",
      "Description": "Monitored needs-based algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "autem",
      "Description": "Monitored needs-based algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eos",
      "StrippedValue": "quia",
      "Description": "Face to face bandwidth-monitored challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 234
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "quia",
      "Description": "Face to face bandwidth-monitored challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 234
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "voluptates",
      "Description": "Customer-focused interactive knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "voluptates",
      "Description": "Customer-focused interactive knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    }
  ],
  "Description": "Versatile fault-tolerant infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 503,
      "Mrmrs": "aut",
      "Firstname": "Kara",
      "Lastname": "Bednar",
      "MiddleName": "Miller-Emmerich",
      "Title": "aut",
      "Description": "Enterprise-wide multimedia implementation",
      "Email": "rollin_oreilly@rau.ca",
      "FullName": "Ms. Benjamin Pierce Kovacek PhD",
      "DirectPhone": "1-639-530-1537 x995",
      "FormalName": "McLaughlin-Aufderhar",
      "CountryId": 55,
      "ContactId": 558,
      "ContactName": "Hermann, Carter and Bogisich",
      "Retired": 433,
      "Rank": 730,
      "ActiveInterests": 67,
      "ContactDepartment": "",
      "ContactCountryId": 59,
      "ContactOrgNr": "819070",
      "FaxPhone": "330.543.4084",
      "MobilePhone": "1-208-256-4810 x9965",
      "ContactPhone": "319.700.5828 x7417",
      "AssociateName": "Durgan-West",
      "AssociateId": 461,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "beatae",
      "Kanalname": "cumque",
      "Post1": "odit",
      "Post2": "sunt",
      "Post3": "perspiciatis",
      "EmailName": "deion.effertz@lowe.ca",
      "ContactFullName": "Ike Greenholt",
      "ActiveErpLinks": 927,
      "TicketPriorityId": 826,
      "SupportLanguageId": 705,
      "SupportAssociateId": 345,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 630
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "vel",
  "Xstop": true,
  "ActiveInterests": 325,
  "GroupId": 767,
  "ActiveStatusMonitorId": 632,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 85,
  "DbiAgentId": 778,
  "DbiLastSyncronized": "2004-01-03T11:10:26.2495246+01:00",
  "DbiKey": "molestias",
  "DbiLastModified": "2004-09-05T11:10:26.2495246+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 631,
  "ActiveErpLinks": 142,
  "BounceEmails": [
    "demario@lindgrensauer.uk",
    "makenna@williamson.co.uk"
  ],
  "Domains": [
    "consequatur",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1734339546",
    "SuperOffice:2": "Shaina Grady III"
  },
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 805
    }
  }
}
```
