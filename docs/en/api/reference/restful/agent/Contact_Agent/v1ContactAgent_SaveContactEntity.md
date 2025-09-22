---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is 0.








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

## Request Body: contactEntity 

The ContactEntity that is saved 

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 667,
  "Name": "Reichert, Schmitt and Bartell",
  "Department": "",
  "OrgNr": "1161255",
  "Number1": "1421990",
  "Number2": "997236",
  "UpdatedDate": "2009-10-13T11:24:47.7345473+02:00",
  "CreatedDate": "2007-10-05T11:24:47.7345473+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "voluptatem",
      "Description": "Customer-focused multimedia emulation"
    },
    {
      "Value": "omnis",
      "StrippedValue": "voluptatem",
      "Description": "Customer-focused multimedia emulation"
    }
  ],
  "Interests": [
    {
      "Id": 474,
      "Name": "Bode Inc and Sons",
      "ToolTip": "Ullam et alias dignissimos natus pariatur id debitis.",
      "Deleted": false,
      "Rank": 369,
      "Type": "et",
      "ColorBlock": 139,
      "IconHint": "a",
      "Selected": true,
      "LastChanged": "2012-11-05T11:24:47.7345473+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corrupti",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Mr. Krystal Harber DVM"
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "quas",
      "Description": "Exclusive explicit flexibility"
    },
    {
      "Value": "et",
      "StrippedValue": "quas",
      "Description": "Exclusive explicit flexibility"
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "ut",
      "Description": "Customer-focused executive synergy"
    },
    {
      "Value": "in",
      "StrippedValue": "ut",
      "Description": "Customer-focused executive synergy"
    }
  ],
  "Faxes": [
    {
      "Value": "minus",
      "StrippedValue": "tempore",
      "Description": "Ameliorated actuating implementation"
    },
    {
      "Value": "minus",
      "StrippedValue": "tempore",
      "Description": "Ameliorated actuating implementation"
    }
  ],
  "Description": "Grass-roots tangible implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequatur",
      "PersonId": 735,
      "Mrmrs": "vel",
      "Firstname": "Ottilie",
      "Lastname": "Kub",
      "MiddleName": "Fay-Labadie",
      "Title": "eaque",
      "Description": "Open-architected explicit website",
      "Email": "gardner@hayes.biz",
      "FullName": "America Goldner DVM",
      "DirectPhone": "1-112-607-5443",
      "FormalName": "Schumm Inc and Sons",
      "CountryId": 789,
      "ContactId": 5,
      "ContactName": "Nitzsche Group",
      "Retired": 865,
      "Rank": 178,
      "ActiveInterests": 93,
      "ContactDepartment": "",
      "ContactCountryId": 115,
      "ContactOrgNr": "750103",
      "FaxPhone": "670-168-7677 x2008",
      "MobilePhone": "(663)905-1316",
      "ContactPhone": "(554)188-2759 x9964",
      "AssociateName": "Sanford, Johnson and Bruen",
      "AssociateId": 742,
      "UsePersonAddress": false,
      "ContactFax": "accusantium",
      "Kanafname": "aut",
      "Kanalname": "rerum",
      "Post1": "dolores",
      "Post2": "dicta",
      "Post3": "ipsam",
      "EmailName": "onie.mcdermott@schinner.biz",
      "ContactFullName": "Dixie Shields Jr.",
      "ActiveErpLinks": 282,
      "TicketPriorityId": 874,
      "SupportLanguageId": 839,
      "SupportAssociateId": 757,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1653686"
    }
  ],
  "NoMailing": true,
  "Kananame": "architecto",
  "Xstop": false,
  "ActiveInterests": 182,
  "GroupId": 134,
  "ActiveStatusMonitorId": 225,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 614,
  "DbiAgentId": 60,
  "DbiLastSyncronized": "2008-11-21T11:24:47.7345473+01:00",
  "DbiKey": "praesentium",
  "DbiLastModified": "2001-07-02T11:24:47.7345473+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 995,
  "ActiveErpLinks": 918,
  "BounceEmails": [
    "claudia.kuhic@luettgen.info",
    "malachi@fahey.com"
  ],
  "Domains": [
    "inventore",
    "sint"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Suzanne Bergstrom III",
    "SuperOffice:2": "1075984316"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 441,
  "Name": "Lakin Group",
  "Department": "",
  "OrgNr": "614640",
  "Number1": "1526883",
  "Number2": "612601",
  "UpdatedDate": "2025-07-24T11:24:47.7501716+02:00",
  "CreatedDate": "2023-10-18T11:24:47.7501716+02:00",
  "Emails": [
    {
      "Value": "totam",
      "StrippedValue": "fugit",
      "Description": "Intuitive responsive instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "fugit",
      "Description": "Intuitive responsive instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 525,
      "Name": "Hand, Wolff and Murazik",
      "ToolTip": "Ut quasi enim sed ea voluptas voluptatum.",
      "Deleted": false,
      "Rank": 972,
      "Type": "suscipit",
      "ColorBlock": 896,
      "IconHint": "quibusdam",
      "Selected": false,
      "LastChanged": "2019-12-14T11:24:47.7501716+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Mable Wyatt Waelchi I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 472
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "repellendus",
      "StrippedValue": "eos",
      "Description": "Fundamental even-keeled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "eos",
      "Description": "Fundamental even-keeled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "delectus",
      "Description": "Adaptive foreground matrices",
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
      "Value": "ut",
      "StrippedValue": "delectus",
      "Description": "Adaptive foreground matrices",
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
  "Faxes": [
    {
      "Value": "dolor",
      "StrippedValue": "nemo",
      "Description": "Visionary systematic collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "nemo",
      "Description": "Visionary systematic collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "Description": "Integrated needs-based migration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "neque",
      "PersonId": 72,
      "Mrmrs": "iusto",
      "Firstname": "Buster",
      "Lastname": "Mills",
      "MiddleName": "Armstrong-Cronin",
      "Title": "ab",
      "Description": "Pre-emptive asynchronous standardization",
      "Email": "magnolia.mueller@schimmel.uk",
      "FullName": "Prof. Icie Quinton Kohler",
      "DirectPhone": "083.464.5360 x75847",
      "FormalName": "Howell-Windler",
      "CountryId": 290,
      "ContactId": 154,
      "ContactName": "Pollich-Douglas",
      "Retired": 138,
      "Rank": 342,
      "ActiveInterests": 647,
      "ContactDepartment": "",
      "ContactCountryId": 349,
      "ContactOrgNr": "765838",
      "FaxPhone": "850-200-0917 x57863",
      "MobilePhone": "441.744.2614 x45233",
      "ContactPhone": "716.388.5165 x004",
      "AssociateName": "Cremin, Klein and Rath",
      "AssociateId": 723,
      "UsePersonAddress": true,
      "ContactFax": "pariatur",
      "Kanafname": "magnam",
      "Kanalname": "quibusdam",
      "Post1": "quam",
      "Post2": "voluptate",
      "Post3": "soluta",
      "EmailName": "jonas@prohaskakutch.com",
      "ContactFullName": "Mrs. Elise Collier MD",
      "ActiveErpLinks": 942,
      "TicketPriorityId": 783,
      "SupportLanguageId": 889,
      "SupportAssociateId": 713,
      "CategoryName": "VIP Customer",
      "PersonNumber": "261942",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 728
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "impedit",
  "Xstop": false,
  "ActiveInterests": 412,
  "GroupId": 242,
  "ActiveStatusMonitorId": 881,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 321,
  "DbiAgentId": 385,
  "DbiLastSyncronized": "2020-09-09T11:24:47.7501716+02:00",
  "DbiKey": "iste",
  "DbiLastModified": "2016-11-19T11:24:47.7501716+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 887,
  "ActiveErpLinks": 382,
  "BounceEmails": [
    "beau_harris@ritchierenner.us",
    "hayden@kochwest.ca"
  ],
  "Domains": [
    "inventore",
    "voluptatem"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Cassie Brekke Jr.",
    "SuperOffice:2": "915154282"
  },
  "ExtraFields": {
    "ExtraFields1": "debitis",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "voluptates"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 331
    }
  }
}
```