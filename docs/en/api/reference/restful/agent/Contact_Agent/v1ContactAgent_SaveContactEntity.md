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


NsApiSlow threshold: 2000 ms.







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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 340,
  "Name": "Stoltenberg, Stark and Treutel",
  "Department": "",
  "OrgNr": "1208576",
  "Number1": "1473884",
  "Number2": "1404470",
  "UpdatedDate": "2024-08-18T03:40:46.2800664+02:00",
  "CreatedDate": "2021-02-12T03:40:46.2800664+01:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "at",
      "Description": "Secured content-based initiative"
    },
    {
      "Value": "ut",
      "StrippedValue": "at",
      "Description": "Secured content-based initiative"
    }
  ],
  "Interests": [
    {
      "Id": 244,
      "Name": "King Group",
      "ToolTip": "Sunt perspiciatis rerum quidem.",
      "Deleted": false,
      "Rank": 746,
      "Type": "et",
      "ColorBlock": 990,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2005-02-23T03:40:46.2800664+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ad",
      "StyleHint": "eveniet",
      "Hidden": false,
      "FullName": "Estelle Murazik"
    }
  ],
  "Urls": [
    {
      "Value": "consectetur",
      "StrippedValue": "sapiente",
      "Description": "Multi-lateral attitude-oriented concept"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "sapiente",
      "Description": "Multi-lateral attitude-oriented concept"
    }
  ],
  "Phones": [
    {
      "Value": "voluptas",
      "StrippedValue": "minima",
      "Description": "Multi-lateral zero defect pricing structure"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "minima",
      "Description": "Multi-lateral zero defect pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "occaecati",
      "Description": "Ergonomic regional application"
    },
    {
      "Value": "non",
      "StrippedValue": "occaecati",
      "Description": "Ergonomic regional application"
    }
  ],
  "Description": "Robust optimal emulation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "est",
      "PersonId": 789,
      "Mrmrs": "repudiandae",
      "Firstname": "Maeve",
      "Lastname": "Bartoletti",
      "MiddleName": "Bogan Group",
      "Title": "sed",
      "Description": "Monitored next generation pricing structure",
      "Email": "cassie@stokes.co.uk",
      "FullName": "Hazel Trever Lubowitz I",
      "DirectPhone": "963.469.9696 x2725",
      "FormalName": "Thiel Group",
      "CountryId": 554,
      "ContactId": 109,
      "ContactName": "Okuneva, Wehner and Lueilwitz",
      "Retired": 42,
      "Rank": 452,
      "ActiveInterests": 32,
      "ContactDepartment": "",
      "ContactCountryId": 425,
      "ContactOrgNr": "867207",
      "FaxPhone": "1-746-548-1773 x10791",
      "MobilePhone": "665-042-1773",
      "ContactPhone": "1-379-744-0466",
      "AssociateName": "Anderson, Koepp and Friesen",
      "AssociateId": 112,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "et",
      "Kanalname": "tempora",
      "Post1": "qui",
      "Post2": "debitis",
      "Post3": "doloribus",
      "EmailName": "joelle.bahringer@nitzschebeer.biz",
      "ContactFullName": "Lydia Gussie Mann Sr.",
      "ActiveErpLinks": 107,
      "TicketPriorityId": 712,
      "SupportLanguageId": 270,
      "SupportAssociateId": 313,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1042909"
    }
  ],
  "NoMailing": true,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 549,
  "GroupId": 773,
  "ActiveStatusMonitorId": 451,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 313,
  "DbiAgentId": 241,
  "DbiLastSyncronized": "2019-09-11T03:40:46.3587267+02:00",
  "DbiKey": "autem",
  "DbiLastModified": "2008-08-18T03:40:46.3587267+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 630,
  "ActiveErpLinks": 103,
  "BounceEmails": [
    "quinten_klein@hoeger.uk",
    "elmira@langosh.info"
  ],
  "Domains": [
    "voluptas",
    "aliquam"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Carmelo Klein",
    "SuperOffice:2": "Dr. Mariane Hudson MD"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "architecto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 267,
  "Name": "Prohaska, O'Hara and Hoeger",
  "Department": "revolutionize scalable functionalities",
  "OrgNr": "686069",
  "Number1": "1294939",
  "Number2": "356032",
  "UpdatedDate": "2017-09-01T03:40:46.3587267+02:00",
  "CreatedDate": "2008-04-21T03:40:46.3587267+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "adipisci",
      "Description": "Quality-focused encompassing forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 9
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "adipisci",
      "Description": "Quality-focused encompassing forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 9
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 757,
      "Name": "Lockman LLC",
      "ToolTip": "Minima dicta adipisci ut voluptas sit.",
      "Deleted": true,
      "Rank": 147,
      "Type": "officia",
      "ColorBlock": 38,
      "IconHint": "consectetur",
      "Selected": false,
      "LastChanged": "2017-04-27T03:40:46.3587267+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Lura Pfannerstill",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "adipisci",
      "StrippedValue": "odit",
      "Description": "Horizontal interactive monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "odit",
      "Description": "Horizontal interactive monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "omnis",
      "Description": "Upgradable client-driven throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "omnis",
      "Description": "Upgradable client-driven throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "doloribus",
      "Description": "Function-based demand-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1002
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "doloribus",
      "Description": "Function-based demand-driven software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1002
        }
      }
    }
  ],
  "Description": "Operative background encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cumque",
      "PersonId": 577,
      "Mrmrs": "praesentium",
      "Firstname": "Everardo",
      "Lastname": "Corwin",
      "MiddleName": "Cremin, Gutkowski and Hahn",
      "Title": "inventore",
      "Description": "Team-oriented client-driven matrix",
      "Email": "westley@champlin.com",
      "FullName": "Jaylin Watsica",
      "DirectPhone": "394-670-5670",
      "FormalName": "Simonis LLC",
      "CountryId": 814,
      "ContactId": 315,
      "ContactName": "Wehner-Gislason",
      "Retired": 164,
      "Rank": 284,
      "ActiveInterests": 983,
      "ContactDepartment": "",
      "ContactCountryId": 678,
      "ContactOrgNr": "553919",
      "FaxPhone": "176-002-3658",
      "MobilePhone": "1-683-904-2952",
      "ContactPhone": "(012)911-4585",
      "AssociateName": "Adams, Barrows and Kerluke",
      "AssociateId": 686,
      "UsePersonAddress": true,
      "ContactFax": "occaecati",
      "Kanafname": "quia",
      "Kanalname": "suscipit",
      "Post1": "consequuntur",
      "Post2": "omnis",
      "Post3": "magnam",
      "EmailName": "sandrine@jerde.name",
      "ContactFullName": "Jody Nitzsche",
      "ActiveErpLinks": 514,
      "TicketPriorityId": 101,
      "SupportLanguageId": 622,
      "SupportAssociateId": 166,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1111794",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 535
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quod",
  "Xstop": false,
  "ActiveInterests": 769,
  "GroupId": 75,
  "ActiveStatusMonitorId": 563,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 1000,
  "DbiAgentId": 163,
  "DbiLastSyncronized": "2022-03-05T03:40:46.3743647+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2004-11-09T03:40:46.3743647+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 64,
  "ActiveErpLinks": 165,
  "BounceEmails": [
    "reynold@carter.info",
    "carlotta_stroman@huels.com"
  ],
  "Domains": [
    "animi",
    "eaque"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Davon Erna Wolff Jr.",
    "SuperOffice:2": "Ilene Odie Kilback MD"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "nulla"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 858
    }
  }
}
```