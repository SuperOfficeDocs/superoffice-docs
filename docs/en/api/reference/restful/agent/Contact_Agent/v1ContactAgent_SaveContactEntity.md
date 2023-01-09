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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 725,
  "Name": "Bosco-Hessel",
  "Department": "",
  "OrgNr": "1126729",
  "Number1": "754470",
  "Number2": "510380",
  "UpdatedDate": "2021-12-06T17:37:17.156242+01:00",
  "CreatedDate": "2004-05-27T17:37:17.156242+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "magnam",
      "Description": "Open-source well-modulated project"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "magnam",
      "Description": "Open-source well-modulated project"
    }
  ],
  "Interests": [
    {
      "Id": 62,
      "Name": "Bradtke-Eichmann",
      "ToolTip": "Vel provident soluta illum velit in est.",
      "Deleted": false,
      "Rank": 466,
      "Type": "consequatur",
      "ColorBlock": 413,
      "IconHint": "quod",
      "Selected": true,
      "LastChanged": "2013-12-02T17:37:17.156242+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "occaecati",
      "StyleHint": "asperiores",
      "Hidden": false,
      "FullName": "Thea Ortiz"
    }
  ],
  "Urls": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "quibusdam",
      "Description": "Universal zero defect database"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "quibusdam",
      "Description": "Universal zero defect database"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "inventore",
      "Description": "Innovative zero tolerance superstructure"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "inventore",
      "Description": "Innovative zero tolerance superstructure"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "est",
      "Description": "Optional tangible throughput"
    },
    {
      "Value": "et",
      "StrippedValue": "est",
      "Description": "Optional tangible throughput"
    }
  ],
  "Description": "Re-engineered interactive knowledge base",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "fuga",
      "PersonId": 634,
      "Mrmrs": "doloribus",
      "Firstname": "Cassidy",
      "Lastname": "Rogahn",
      "MiddleName": "Jast-Nolan",
      "Title": "temporibus",
      "Description": "Synchronised radical time-frame",
      "Email": "vernon.wyman@runte.ca",
      "FullName": "Dejuan Lind",
      "DirectPhone": "278.297.2537",
      "FormalName": "D'Amore, McDermott and Rempel",
      "CountryId": 242,
      "ContactId": 239,
      "ContactName": "Leuschke-Spencer",
      "Retired": 936,
      "Rank": 643,
      "ActiveInterests": 194,
      "ContactDepartment": "",
      "ContactCountryId": 32,
      "ContactOrgNr": "1295165",
      "FaxPhone": "(967)001-0802 x684",
      "MobilePhone": "1-431-732-8918",
      "ContactPhone": "1-458-269-7736 x13469",
      "AssociateName": "Torphy LLC",
      "AssociateId": 467,
      "UsePersonAddress": true,
      "ContactFax": "tempora",
      "Kanafname": "voluptatem",
      "Kanalname": "est",
      "Post1": "est",
      "Post2": "neque",
      "Post3": "voluptatem",
      "EmailName": "manuela@hessel.us",
      "ContactFullName": "Adolfo Block",
      "ActiveErpLinks": 274,
      "TicketPriorityId": 541,
      "SupportLanguageId": 688,
      "SupportAssociateId": 575,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 491,
  "GroupId": 607,
  "ActiveStatusMonitorId": 598,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 675,
  "DbiAgentId": 584,
  "DbiLastSyncronized": "1995-12-15T17:37:17.1602415+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2006-04-08T17:37:17.1602415+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 917,
  "ActiveErpLinks": 395,
  "BounceEmails": [
    "chadd@doyle.ca",
    "orion.kovacek@schneidercassin.us"
  ],
  "Domains": [
    "asperiores",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Maurice Kuhn",
    "SuperOffice:2": "Ernesto Herbert Spencer IV"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "neque"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 689,
  "Name": "West-Lind",
  "Department": "",
  "OrgNr": "416593",
  "Number1": "249520",
  "Number2": "967113",
  "UpdatedDate": "2009-10-15T17:37:17.1702418+02:00",
  "CreatedDate": "2005-06-19T17:37:17.1702418+02:00",
  "Emails": [
    {
      "Value": "earum",
      "StrippedValue": "sed",
      "Description": "Advanced human-resource array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 366
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "sed",
      "Description": "Advanced human-resource array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 366
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 782,
      "Name": "Hackett Inc and Sons",
      "ToolTip": "Et placeat itaque dolore facere.",
      "Deleted": true,
      "Rank": 552,
      "Type": "et",
      "ColorBlock": 289,
      "IconHint": "consectetur",
      "Selected": false,
      "LastChanged": "2022-02-19T17:37:17.1712419+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "molestias",
      "Hidden": true,
      "FullName": "Prof. Jeffrey Considine MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "libero",
      "Description": "Up-sized high-level moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "libero",
      "Description": "Up-sized high-level moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "enim",
      "StrippedValue": "nam",
      "Description": "Pre-emptive incremental hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "nam",
      "Description": "Pre-emptive incremental hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nisi",
      "StrippedValue": "id",
      "Description": "Stand-alone bottom-line policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "id",
      "Description": "Stand-alone bottom-line policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "Description": "Diverse well-modulated capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eveniet",
      "PersonId": 725,
      "Mrmrs": "explicabo",
      "Firstname": "Susana",
      "Lastname": "Rodriguez",
      "MiddleName": "Kessler Inc and Sons",
      "Title": "quia",
      "Description": "Front-line global protocol",
      "Email": "maud@jacobi.us",
      "FullName": "Randal Thompson",
      "DirectPhone": "051-878-6591 x8359",
      "FormalName": "Koelpin LLC",
      "CountryId": 440,
      "ContactId": 294,
      "ContactName": "Mayert-Wisoky",
      "Retired": 248,
      "Rank": 268,
      "ActiveInterests": 829,
      "ContactDepartment": "",
      "ContactCountryId": 127,
      "ContactOrgNr": "535567",
      "FaxPhone": "402.532.6910",
      "MobilePhone": "(026)768-7873",
      "ContactPhone": "(224)298-9126",
      "AssociateName": "Waelchi, Trantow and Runolfsson",
      "AssociateId": 215,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "consequatur",
      "Kanalname": "perferendis",
      "Post1": "officiis",
      "Post2": "soluta",
      "Post3": "quos",
      "EmailName": "dillan.monahan@lehner.ca",
      "ContactFullName": "Frederic Goldner",
      "ActiveErpLinks": 635,
      "TicketPriorityId": 968,
      "SupportLanguageId": 112,
      "SupportAssociateId": 281,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "laborum",
  "Xstop": false,
  "ActiveInterests": 468,
  "GroupId": 145,
  "ActiveStatusMonitorId": 348,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 257,
  "DbiAgentId": 55,
  "DbiLastSyncronized": "2013-10-22T17:37:17.1752417+02:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2009-06-07T17:37:17.1752417+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 328,
  "ActiveErpLinks": 877,
  "BounceEmails": [
    "efren.hilpert@torpkonopelski.info",
    "troy_schowalter@ondricka.co.uk"
  ],
  "Domains": [
    "qui",
    "quidem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Rosalyn Aufderhar Sr.",
    "SuperOffice:2": "Estel Lucinda Koss DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "tempore"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 974
    }
  }
}
```