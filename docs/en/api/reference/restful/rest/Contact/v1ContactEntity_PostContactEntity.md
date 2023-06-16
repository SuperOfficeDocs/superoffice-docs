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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 894,
  "Name": "Hilll Group",
  "Department": "optimize interactive schemas",
  "OrgNr": "1085682",
  "Number1": "275722",
  "Number2": "829939",
  "UpdatedDate": "2011-04-19T16:00:47.711605+02:00",
  "CreatedDate": "2011-08-08T16:00:47.711605+02:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "odit",
      "Description": "Right-sized zero defect instruction set"
    },
    {
      "Value": "similique",
      "StrippedValue": "odit",
      "Description": "Right-sized zero defect instruction set"
    }
  ],
  "Interests": [
    {
      "Id": 202,
      "Name": "O'Keefe Group",
      "ToolTip": "Necessitatibus nulla fuga id autem recusandae.",
      "Deleted": false,
      "Rank": 801,
      "Type": "aperiam",
      "ColorBlock": 57,
      "IconHint": "totam",
      "Selected": false,
      "LastChanged": "1997-04-13T16:00:47.711605+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "commodi",
      "StyleHint": "at",
      "Hidden": false,
      "FullName": "Ms. Lyric Antonia Bayer IV"
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "cupiditate",
      "Description": "Function-based exuding productivity"
    },
    {
      "Value": "quo",
      "StrippedValue": "cupiditate",
      "Description": "Function-based exuding productivity"
    }
  ],
  "Phones": [
    {
      "Value": "ipsam",
      "StrippedValue": "architecto",
      "Description": "Ameliorated bifurcated strategy"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "architecto",
      "Description": "Ameliorated bifurcated strategy"
    }
  ],
  "Faxes": [
    {
      "Value": "perferendis",
      "StrippedValue": "error",
      "Description": "Programmable empowering initiative"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "error",
      "Description": "Programmable empowering initiative"
    }
  ],
  "Description": "Diverse human-resource groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "a",
      "PersonId": 516,
      "Mrmrs": "voluptatem",
      "Firstname": "Tremayne",
      "Lastname": "Hessel",
      "MiddleName": "Roob, Spencer and Mann",
      "Title": "quo",
      "Description": "Customer-focused tangible parallelism",
      "Email": "jaquelin_waters@schneiderwisoky.name",
      "FullName": "Ronaldo Kessler",
      "DirectPhone": "(403)147-9212",
      "FormalName": "Schmeler-Strosin",
      "CountryId": 276,
      "ContactId": 379,
      "ContactName": "McGlynn, Brown and Pollich",
      "Retired": 591,
      "Rank": 474,
      "ActiveInterests": 400,
      "ContactDepartment": "",
      "ContactCountryId": 498,
      "ContactOrgNr": "1379568",
      "FaxPhone": "1-834-091-5989",
      "MobilePhone": "052.713.0491 x726",
      "ContactPhone": "1-911-354-8327",
      "AssociateName": "Predovic, Altenwerth and Koepp",
      "AssociateId": 834,
      "UsePersonAddress": false,
      "ContactFax": "odit",
      "Kanafname": "ut",
      "Kanalname": "quo",
      "Post1": "iure",
      "Post2": "et",
      "Post3": "velit",
      "EmailName": "ricky@kozey.co.uk",
      "ContactFullName": "Shane Cummerata",
      "ActiveErpLinks": 283,
      "TicketPriorityId": 551,
      "SupportLanguageId": 602,
      "SupportAssociateId": 982,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "assumenda",
  "Xstop": false,
  "ActiveInterests": 433,
  "GroupId": 226,
  "ActiveStatusMonitorId": 502,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 553,
  "DbiAgentId": 523,
  "DbiLastSyncronized": "2008-10-11T16:00:47.7272259+02:00",
  "DbiKey": "tempore",
  "DbiLastModified": "1996-08-16T16:00:47.7272259+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 176,
  "ActiveErpLinks": 720,
  "BounceEmails": [
    "dennis.cormier@gislason.biz",
    "sienna_cummings@mclaughlinkessler.ca"
  ],
  "Domains": [
    "adipisci",
    "numquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "243935898",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "voluptatem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 841,
  "Name": "Ratke, Kautzer and Waelchi",
  "Department": "",
  "OrgNr": "1198263",
  "Number1": "816905",
  "Number2": "830699",
  "UpdatedDate": "2022-04-09T16:00:47.7272259+02:00",
  "CreatedDate": "2010-11-13T16:00:47.7272259+01:00",
  "Emails": [
    {
      "Value": "ipsum",
      "StrippedValue": "culpa",
      "Description": "Face to face global benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    },
    {
      "Value": "ipsum",
      "StrippedValue": "culpa",
      "Description": "Face to face global benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 622,
      "Name": "Wyman Group",
      "ToolTip": "Officiis doloremque laboriosam perspiciatis eius.",
      "Deleted": false,
      "Rank": 512,
      "Type": "reiciendis",
      "ColorBlock": 572,
      "IconHint": "id",
      "Selected": true,
      "LastChanged": "2021-04-01T16:00:47.7272259+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Andre Batz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 500
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "sed",
      "Description": "Switchable bottom-line hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "sed",
      "Description": "Switchable bottom-line hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "assumenda",
      "StrippedValue": "ut",
      "Description": "Streamlined empowering parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "ut",
      "Description": "Streamlined empowering parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quaerat",
      "StrippedValue": "porro",
      "Description": "Integrated local access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "porro",
      "Description": "Integrated local access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Description": "Re-engineered empowering analyzer",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quisquam",
      "PersonId": 342,
      "Mrmrs": "repudiandae",
      "Firstname": "Aimee",
      "Lastname": "Weber",
      "MiddleName": "Jewess-Kirlin",
      "Title": "nobis",
      "Description": "Synchronised solution-oriented parallelism",
      "Email": "katlyn@schulistupton.info",
      "FullName": "Maymie Terry",
      "DirectPhone": "(513)196-9591 x5062",
      "FormalName": "Koelpin Inc and Sons",
      "CountryId": 18,
      "ContactId": 360,
      "ContactName": "Runte, Kozey and Abbott",
      "Retired": 934,
      "Rank": 377,
      "ActiveInterests": 914,
      "ContactDepartment": "",
      "ContactCountryId": 478,
      "ContactOrgNr": "1122510",
      "FaxPhone": "798.602.2268 x325",
      "MobilePhone": "796.119.4158 x61590",
      "ContactPhone": "(213)799-9939",
      "AssociateName": "Cassin-Schmeler",
      "AssociateId": 776,
      "UsePersonAddress": false,
      "ContactFax": "quas",
      "Kanafname": "sint",
      "Kanalname": "qui",
      "Post1": "deleniti",
      "Post2": "rerum",
      "Post3": "quis",
      "EmailName": "duncan@kautzer.ca",
      "ContactFullName": "Aurelia Lesch",
      "ActiveErpLinks": 366,
      "TicketPriorityId": 487,
      "SupportLanguageId": 595,
      "SupportAssociateId": 261,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "at",
  "Xstop": true,
  "ActiveInterests": 267,
  "GroupId": 966,
  "ActiveStatusMonitorId": 271,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 456,
  "DbiAgentId": 810,
  "DbiLastSyncronized": "2016-11-20T16:00:47.7428547+01:00",
  "DbiKey": "pariatur",
  "DbiLastModified": "1999-05-08T16:00:47.7428547+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 598,
  "ActiveErpLinks": 890,
  "BounceEmails": [
    "eriberto_wisoky@bogan.ca",
    "susan_rau@dicki.co.uk"
  ],
  "Domains": [
    "saepe",
    "magnam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Laury Schaden",
    "SuperOffice:2": "206414792"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 980
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```