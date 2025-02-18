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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 814,
  "Name": "Spencer-Olson",
  "Department": "",
  "OrgNr": "1459889",
  "Number1": "774497",
  "Number2": "998999",
  "UpdatedDate": "2014-06-26T14:32:11.2708286+02:00",
  "CreatedDate": "2014-10-22T14:32:11.2708286+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "similique",
      "Description": "Balanced exuding encoding"
    },
    {
      "Value": "ut",
      "StrippedValue": "similique",
      "Description": "Balanced exuding encoding"
    }
  ],
  "Interests": [
    {
      "Id": 976,
      "Name": "Gutmann-Reynolds",
      "ToolTip": "Quasi dolor sunt.",
      "Deleted": true,
      "Rank": 530,
      "Type": "est",
      "ColorBlock": 553,
      "IconHint": "voluptate",
      "Selected": true,
      "LastChanged": "2004-05-03T14:32:11.2708286+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Dr. Giovanny Schneider II"
    }
  ],
  "Urls": [
    {
      "Value": "esse",
      "StrippedValue": "iste",
      "Description": "Synchronised composite archive"
    },
    {
      "Value": "esse",
      "StrippedValue": "iste",
      "Description": "Synchronised composite archive"
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "rem",
      "Description": "Profound content-based approach"
    },
    {
      "Value": "sed",
      "StrippedValue": "rem",
      "Description": "Profound content-based approach"
    }
  ],
  "Faxes": [
    {
      "Value": "consectetur",
      "StrippedValue": "rerum",
      "Description": "Assimilated maximized groupware"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "rerum",
      "Description": "Assimilated maximized groupware"
    }
  ],
  "Description": "Vision-oriented leading edge product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "minus",
      "PersonId": 578,
      "Mrmrs": "quibusdam",
      "Firstname": "Tre",
      "Lastname": "Dach",
      "MiddleName": "Hickle-Roberts",
      "Title": "consequatur",
      "Description": "Sharable coherent policy",
      "Email": "savanna@sauer.com",
      "FullName": "Mr. Domenic Beer",
      "DirectPhone": "1-895-224-6202 x218",
      "FormalName": "Hackett, Sawayn and Reynolds",
      "CountryId": 605,
      "ContactId": 127,
      "ContactName": "Hessel LLC",
      "Retired": 54,
      "Rank": 907,
      "ActiveInterests": 936,
      "ContactDepartment": "",
      "ContactCountryId": 400,
      "ContactOrgNr": "861067",
      "FaxPhone": "1-938-080-7655 x0363",
      "MobilePhone": "756-984-7451 x9664",
      "ContactPhone": "507.451.6846 x013",
      "AssociateName": "Hermann-Rolfson",
      "AssociateId": 647,
      "UsePersonAddress": false,
      "ContactFax": "fuga",
      "Kanafname": "occaecati",
      "Kanalname": "dolor",
      "Post1": "occaecati",
      "Post2": "sit",
      "Post3": "ad",
      "EmailName": "bryana.sipes@okuneva.biz",
      "ContactFullName": "Marge O'Kon",
      "ActiveErpLinks": 404,
      "TicketPriorityId": 695,
      "SupportLanguageId": 723,
      "SupportAssociateId": 851,
      "CategoryName": "VIP Customer",
      "PersonNumber": "937897"
    }
  ],
  "NoMailing": true,
  "Kananame": "atque",
  "Xstop": false,
  "ActiveInterests": 655,
  "GroupId": 483,
  "ActiveStatusMonitorId": 642,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 768,
  "DbiAgentId": 945,
  "DbiLastSyncronized": "2017-08-13T14:32:11.2708286+02:00",
  "DbiKey": "quam",
  "DbiLastModified": "2016-09-23T14:32:11.2708286+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 79,
  "ActiveErpLinks": 643,
  "BounceEmails": [
    "vern@goldner.info",
    "ruth@rempelprohaska.ca"
  ],
  "Domains": [
    "minus",
    "deleniti"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "a"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 852,
  "Name": "Kiehn-Lynch",
  "Department": "",
  "OrgNr": "841305",
  "Number1": "1239360",
  "Number2": "1360081",
  "UpdatedDate": "2000-02-24T14:32:11.2864498+01:00",
  "CreatedDate": "2010-12-21T14:32:11.2864498+01:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "velit",
      "Description": "Public-key heuristic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "velit",
      "Description": "Public-key heuristic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 572,
      "Name": "Jakubowski-Cassin",
      "ToolTip": "Dolor eum eum numquam iste enim.",
      "Deleted": true,
      "Rank": 57,
      "Type": "occaecati",
      "ColorBlock": 647,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2011-11-21T14:32:11.2864498+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quam",
      "StyleHint": "a",
      "Hidden": true,
      "FullName": "Durward Rubie Weimann V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eum",
      "StrippedValue": "aut",
      "Description": "Profit-focused empowering emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "aut",
      "Description": "Profit-focused empowering emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "delectus",
      "StrippedValue": "et",
      "Description": "Upgradable radical encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "et",
      "Description": "Upgradable radical encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "perferendis",
      "Description": "Public-key cohesive strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "perferendis",
      "Description": "Public-key cohesive strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "Description": "Universal high-level project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatum",
      "PersonId": 707,
      "Mrmrs": "id",
      "Firstname": "Destiney",
      "Lastname": "Baumbach",
      "MiddleName": "Grimes-Kassulke",
      "Title": "quidem",
      "Description": "User-friendly uniform website",
      "Email": "fletcher.parker@rempel.biz",
      "FullName": "Brody Mante",
      "DirectPhone": "649-622-9691 x039",
      "FormalName": "Prosacco, Adams and Romaguera",
      "CountryId": 643,
      "ContactId": 65,
      "ContactName": "Lind-Gaylord",
      "Retired": 824,
      "Rank": 114,
      "ActiveInterests": 274,
      "ContactDepartment": "optimize real-time e-tailers",
      "ContactCountryId": 625,
      "ContactOrgNr": "1386713",
      "FaxPhone": "1-662-541-4105",
      "MobilePhone": "(419)598-6223 x66924",
      "ContactPhone": "(700)392-7394 x092",
      "AssociateName": "Stroman-Schultz",
      "AssociateId": 680,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "ipsum",
      "Kanalname": "corporis",
      "Post1": "cupiditate",
      "Post2": "autem",
      "Post3": "magnam",
      "EmailName": "annamarie@haleyadams.ca",
      "ContactFullName": "Mrs. Marjolaine Grimes DVM",
      "ActiveErpLinks": 599,
      "TicketPriorityId": 689,
      "SupportLanguageId": 310,
      "SupportAssociateId": 94,
      "CategoryName": "VIP Customer",
      "PersonNumber": "918424",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nihil",
  "Xstop": true,
  "ActiveInterests": 534,
  "GroupId": 107,
  "ActiveStatusMonitorId": 5,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 609,
  "DbiAgentId": 542,
  "DbiLastSyncronized": "2017-03-07T14:32:11.2864498+01:00",
  "DbiKey": "cum",
  "DbiLastModified": "2024-04-02T14:32:11.2864498+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 80,
  "ActiveErpLinks": 781,
  "BounceEmails": [
    "karson.cruickshank@kunzestehr.biz",
    "corrine_jacobi@carter.name"
  ],
  "Domains": [
    "ratione",
    "quam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "tempore"
  },
  "CustomFields": {
    "CustomFields1": "odit",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 791
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```