---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
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

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 947,
  "Name": "Schmeler Group",
  "Department": "",
  "OrgNr": "166749",
  "Number1": "1053070",
  "Number2": "999573",
  "UpdatedDate": "2006-02-15T03:45:23.1550919+01:00",
  "CreatedDate": "2023-11-17T03:45:23.1550919+01:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "blanditiis",
      "Description": "Synchronised scalable extranet"
    },
    {
      "Value": "autem",
      "StrippedValue": "blanditiis",
      "Description": "Synchronised scalable extranet"
    }
  ],
  "Interests": [
    {
      "Id": 675,
      "Name": "Koelpin Inc and Sons",
      "ToolTip": "Soluta nobis dignissimos incidunt.",
      "Deleted": false,
      "Rank": 580,
      "Type": "vitae",
      "ColorBlock": 783,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2003-06-28T03:45:23.1550919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "perferendis",
      "Hidden": true,
      "FullName": "Willis Jacobson"
    }
  ],
  "Urls": [
    {
      "Value": "atque",
      "StrippedValue": "hic",
      "Description": "Polarised modular concept"
    },
    {
      "Value": "atque",
      "StrippedValue": "hic",
      "Description": "Polarised modular concept"
    }
  ],
  "Phones": [
    {
      "Value": "incidunt",
      "StrippedValue": "sint",
      "Description": "Seamless high-level matrix"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "sint",
      "Description": "Seamless high-level matrix"
    }
  ],
  "Faxes": [
    {
      "Value": "ab",
      "StrippedValue": "et",
      "Description": "Intuitive dedicated moderator"
    },
    {
      "Value": "ab",
      "StrippedValue": "et",
      "Description": "Intuitive dedicated moderator"
    }
  ],
  "Description": "Future-proofed demand-driven middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "saepe",
      "PersonId": 592,
      "Mrmrs": "totam",
      "Firstname": "Alexa",
      "Lastname": "Gaylord",
      "MiddleName": "Feeney, O'Conner and Kovacek",
      "Title": "quo",
      "Description": "Stand-alone multi-tasking flexibility",
      "Email": "sigmund.rogahn@robelschiller.biz",
      "FullName": "Prof. Kenyon Kreiger",
      "DirectPhone": "(253)752-4484 x85053",
      "FormalName": "Mayert, Prohaska and Hoppe",
      "CountryId": 81,
      "ContactId": 846,
      "ContactName": "Goldner-Kutch",
      "Retired": 100,
      "Rank": 943,
      "ActiveInterests": 278,
      "ContactDepartment": "",
      "ContactCountryId": 487,
      "ContactOrgNr": "1360292",
      "FaxPhone": "(492)136-0947",
      "MobilePhone": "306-285-7754",
      "ContactPhone": "1-700-837-6950",
      "AssociateName": "Frami Group",
      "AssociateId": 678,
      "UsePersonAddress": false,
      "ContactFax": "atque",
      "Kanafname": "enim",
      "Kanalname": "dolorem",
      "Post1": "dignissimos",
      "Post2": "quaerat",
      "Post3": "itaque",
      "EmailName": "kole@hillsmaggio.name",
      "ContactFullName": "Augustus Kassulke PhD",
      "ActiveErpLinks": 706,
      "TicketPriorityId": 976,
      "SupportLanguageId": 274,
      "SupportAssociateId": 901,
      "CategoryName": "VIP Customer",
      "PersonNumber": "673179"
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": false,
  "ActiveInterests": 633,
  "GroupId": 404,
  "ActiveStatusMonitorId": 251,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 257,
  "DbiAgentId": 25,
  "DbiLastSyncronized": "2020-08-11T03:45:23.1550919+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2008-11-23T03:45:23.1550919+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 382,
  "ActiveErpLinks": 590,
  "BounceEmails": [
    "sigrid_schimmel@johns.ca",
    "jerome@runolfsdottir.name"
  ],
  "Domains": [
    "voluptates",
    "porro"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "889526185",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "soluta"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 270,
  "Name": "Kling LLC",
  "Department": "",
  "OrgNr": "621982",
  "Number1": "1360702",
  "Number2": "843242",
  "UpdatedDate": "2011-08-10T03:45:23.1550919+02:00",
  "CreatedDate": "2018-12-03T03:45:23.1550919+01:00",
  "Emails": [
    {
      "Value": "neque",
      "StrippedValue": "voluptatem",
      "Description": "Extended hybrid structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "voluptatem",
      "Description": "Extended hybrid structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 173,
      "Name": "Feil, Cartwright and Stiedemann",
      "ToolTip": "Maiores eum ut consequatur.",
      "Deleted": true,
      "Rank": 730,
      "Type": "officia",
      "ColorBlock": 634,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2016-07-18T03:45:23.1550919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "itaque",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Ms. Pat Don Bashirian",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "temporibus",
      "Description": "Persevering context-sensitive process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "temporibus",
      "Description": "Persevering context-sensitive process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "et",
      "Description": "Function-based client-driven definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "et",
      "Description": "Function-based client-driven definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "est",
      "Description": "Enterprise-wide local forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "est",
      "Description": "Enterprise-wide local forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "Description": "Operative dynamic definition",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "pariatur",
      "PersonId": 867,
      "Mrmrs": "nisi",
      "Firstname": "Tatyana",
      "Lastname": "Wiza",
      "MiddleName": "Muller Group",
      "Title": "voluptatem",
      "Description": "Re-contextualized discrete workforce",
      "Email": "oswaldo@pfefferemard.biz",
      "FullName": "Claudia Huel",
      "DirectPhone": "1-073-684-0827",
      "FormalName": "Herman-Kessler",
      "CountryId": 782,
      "ContactId": 11,
      "ContactName": "Ratke, Krajcik and Friesen",
      "Retired": 17,
      "Rank": 546,
      "ActiveInterests": 99,
      "ContactDepartment": "",
      "ContactCountryId": 286,
      "ContactOrgNr": "983570",
      "FaxPhone": "(383)071-1590 x248",
      "MobilePhone": "1-716-628-4814 x9942",
      "ContactPhone": "1-145-343-2648 x94988",
      "AssociateName": "Zboncak LLC",
      "AssociateId": 213,
      "UsePersonAddress": false,
      "ContactFax": "incidunt",
      "Kanafname": "explicabo",
      "Kanalname": "et",
      "Post1": "provident",
      "Post2": "est",
      "Post3": "qui",
      "EmailName": "russ_goodwin@kunzewilkinson.com",
      "ContactFullName": "Prof. William Collins",
      "ActiveErpLinks": 97,
      "TicketPriorityId": 487,
      "SupportLanguageId": 253,
      "SupportAssociateId": 311,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1088051",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 431
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eligendi",
  "Xstop": false,
  "ActiveInterests": 747,
  "GroupId": 730,
  "ActiveStatusMonitorId": 946,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 534,
  "DbiAgentId": 929,
  "DbiLastSyncronized": "2002-02-22T03:45:23.1704803+01:00",
  "DbiKey": "provident",
  "DbiLastModified": "2021-04-01T03:45:23.1704803+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 145,
  "ActiveErpLinks": 481,
  "BounceEmails": [
    "keshawn@barrows.com",
    "glen.collins@kuhic.uk"
  ],
  "Domains": [
    "sunt",
    "id"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1362803707",
    "SuperOffice:2": "Iliana Skiles I"
  },
  "ExtraFields": {
    "ExtraFields1": "in",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 369
    }
  }
}
```