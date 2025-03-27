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
  "ContactId": 490,
  "Name": "Frami, Bashirian and Lynch",
  "Department": "engage killer mindshare",
  "OrgNr": "883929",
  "Number1": "859347",
  "Number2": "1546897",
  "UpdatedDate": "2010-09-16T02:38:21.0108341+02:00",
  "CreatedDate": "2022-03-16T02:38:21.0108341+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "excepturi",
      "Description": "Networked homogeneous matrices"
    },
    {
      "Value": "et",
      "StrippedValue": "excepturi",
      "Description": "Networked homogeneous matrices"
    }
  ],
  "Interests": [
    {
      "Id": 546,
      "Name": "King, Becker and Mohr",
      "ToolTip": "Reprehenderit eos maxime.",
      "Deleted": false,
      "Rank": 174,
      "Type": "rerum",
      "ColorBlock": 353,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2006-06-08T02:38:21.0108341+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quasi",
      "StyleHint": "enim",
      "Hidden": true,
      "FullName": "Darrel Schumm"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "deleniti",
      "Description": "Multi-layered stable database"
    },
    {
      "Value": "ut",
      "StrippedValue": "deleniti",
      "Description": "Multi-layered stable database"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "animi",
      "Description": "Progressive contextually-based secured line"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "animi",
      "Description": "Progressive contextually-based secured line"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "velit",
      "Description": "Object-based zero defect Graphic Interface"
    },
    {
      "Value": "qui",
      "StrippedValue": "velit",
      "Description": "Object-based zero defect Graphic Interface"
    }
  ],
  "Description": "Centralized regional hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sunt",
      "PersonId": 10,
      "Mrmrs": "sint",
      "Firstname": "Ceasar",
      "Lastname": "Ritchie",
      "MiddleName": "Terry-Shanahan",
      "Title": "est",
      "Description": "Re-engineered executive synergy",
      "Email": "keira@wilderman.co.uk",
      "FullName": "Kenton Abdiel Jerde MD",
      "DirectPhone": "748.679.1981",
      "FormalName": "Glover Group",
      "CountryId": 663,
      "ContactId": 11,
      "ContactName": "Wunsch, Hirthe and Thiel",
      "Retired": 912,
      "Rank": 191,
      "ActiveInterests": 699,
      "ContactDepartment": "",
      "ContactCountryId": 412,
      "ContactOrgNr": "883445",
      "FaxPhone": "1-615-416-3487 x7428",
      "MobilePhone": "897.681.3452 x8820",
      "ContactPhone": "1-267-760-6809",
      "AssociateName": "Connelly, Mohr and Franecki",
      "AssociateId": 434,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "ullam",
      "Kanalname": "voluptatem",
      "Post1": "harum",
      "Post2": "ipsum",
      "Post3": "voluptatem",
      "EmailName": "shea_ziemann@marks.ca",
      "ContactFullName": "Kaci McClure",
      "ActiveErpLinks": 563,
      "TicketPriorityId": 779,
      "SupportLanguageId": 763,
      "SupportAssociateId": 156,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1278123"
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 526,
  "GroupId": 74,
  "ActiveStatusMonitorId": 434,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 280,
  "DbiAgentId": 750,
  "DbiLastSyncronized": "2021-02-15T02:38:21.0108341+01:00",
  "DbiKey": "sed",
  "DbiLastModified": "1999-01-11T02:38:21.0108341+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 958,
  "ActiveErpLinks": 425,
  "BounceEmails": [
    "kasandra@mayertwiegand.co.uk",
    "ressie@rolfson.uk"
  ],
  "Domains": [
    "possimus",
    "ex"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Amya Schmitt",
    "SuperOffice:2": "Fidel Beier"
  },
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "maiores",
    "CustomFields2": "quae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 26,
  "Name": "Marks, Pagac and Heidenreich",
  "Department": "",
  "OrgNr": "775572",
  "Number1": "878937",
  "Number2": "272762",
  "UpdatedDate": "2012-09-19T02:38:21.0264152+02:00",
  "CreatedDate": "2020-03-08T02:38:21.0264152+01:00",
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "voluptates",
      "Description": "Organized holistic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "voluptates",
      "Description": "Organized holistic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 206,
      "Name": "Blanda, Nitzsche and Gottlieb",
      "ToolTip": "Qui quaerat ea amet.",
      "Deleted": false,
      "Rank": 856,
      "Type": "rerum",
      "ColorBlock": 137,
      "IconHint": "labore",
      "Selected": true,
      "LastChanged": "2012-02-20T02:38:21.0264152+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Spencer McKenzie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "cupiditate",
      "Description": "Profound 5th generation capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "cupiditate",
      "Description": "Profound 5th generation capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "maiores",
      "StrippedValue": "accusantium",
      "Description": "Monitored multimedia model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 578
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "accusantium",
      "Description": "Monitored multimedia model",
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
  "Faxes": [
    {
      "Value": "rem",
      "StrippedValue": "assumenda",
      "Description": "Switchable background benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "assumenda",
      "Description": "Switchable background benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "Description": "Fundamental global local area network",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "optio",
      "PersonId": 345,
      "Mrmrs": "sed",
      "Firstname": "Dallin",
      "Lastname": "Johnson",
      "MiddleName": "Gottlieb-Cassin",
      "Title": "nihil",
      "Description": "Synchronised heuristic protocol",
      "Email": "lilla@ledner.com",
      "FullName": "Sonya Maggio DVM",
      "DirectPhone": "531-672-5390",
      "FormalName": "Kreiger Inc and Sons",
      "CountryId": 374,
      "ContactId": 104,
      "ContactName": "Schaden Group",
      "Retired": 984,
      "Rank": 89,
      "ActiveInterests": 429,
      "ContactDepartment": "",
      "ContactCountryId": 707,
      "ContactOrgNr": "217723",
      "FaxPhone": "040.415.7051 x28828",
      "MobilePhone": "1-478-375-9727",
      "ContactPhone": "030.027.4672 x300",
      "AssociateName": "Mills-Weimann",
      "AssociateId": 905,
      "UsePersonAddress": true,
      "ContactFax": "exercitationem",
      "Kanafname": "atque",
      "Kanalname": "eius",
      "Post1": "ducimus",
      "Post2": "est",
      "Post3": "molestiae",
      "EmailName": "emmanuel_parker@olson.ca",
      "ContactFullName": "Gabrielle Gutkowski",
      "ActiveErpLinks": 553,
      "TicketPriorityId": 346,
      "SupportLanguageId": 757,
      "SupportAssociateId": 36,
      "CategoryName": "VIP Customer",
      "PersonNumber": "827567",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "perspiciatis",
  "Xstop": false,
  "ActiveInterests": 153,
  "GroupId": 272,
  "ActiveStatusMonitorId": 169,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 841,
  "DbiAgentId": 509,
  "DbiLastSyncronized": "2023-10-02T02:38:21.0264152+02:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2022-07-07T02:38:21.0264152+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 929,
  "ActiveErpLinks": 800,
  "BounceEmails": [
    "tito_treutel@pfeffer.uk",
    "lionel@mooreullrich.com"
  ],
  "Domains": [
    "temporibus",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Darion Kilback",
    "SuperOffice:2": "1377483029"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 800
    }
  }
}
```