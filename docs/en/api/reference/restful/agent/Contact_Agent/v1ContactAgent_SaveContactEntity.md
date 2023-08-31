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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 617,
  "Name": "Yundt-Treutel",
  "Department": "",
  "OrgNr": "281559",
  "Number1": "1087774",
  "Number2": "1310985",
  "UpdatedDate": "2005-07-26T03:31:25.8384743+02:00",
  "CreatedDate": "2009-03-06T03:31:25.8384743+01:00",
  "Emails": [
    {
      "Value": "consequuntur",
      "StrippedValue": "dicta",
      "Description": "Ameliorated demand-driven strategy"
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "dicta",
      "Description": "Ameliorated demand-driven strategy"
    }
  ],
  "Interests": [
    {
      "Id": 308,
      "Name": "Kilback LLC",
      "ToolTip": "Corrupti ut quam.",
      "Deleted": true,
      "Rank": 391,
      "Type": "molestias",
      "ColorBlock": 755,
      "IconHint": "incidunt",
      "Selected": true,
      "LastChanged": "2002-06-26T03:31:25.8384743+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Prof. Maximus Maggio"
    }
  ],
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "ducimus",
      "Description": "Multi-tiered coherent capacity"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "ducimus",
      "Description": "Multi-tiered coherent capacity"
    }
  ],
  "Phones": [
    {
      "Value": "laborum",
      "StrippedValue": "fugiat",
      "Description": "Multi-channelled well-modulated policy"
    },
    {
      "Value": "laborum",
      "StrippedValue": "fugiat",
      "Description": "Multi-channelled well-modulated policy"
    }
  ],
  "Faxes": [
    {
      "Value": "odit",
      "StrippedValue": "ad",
      "Description": "Streamlined modular framework"
    },
    {
      "Value": "odit",
      "StrippedValue": "ad",
      "Description": "Streamlined modular framework"
    }
  ],
  "Description": "Synchronised systemic array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 673,
      "Mrmrs": "ad",
      "Firstname": "Lynn",
      "Lastname": "Veum",
      "MiddleName": "Lowe LLC",
      "Title": "asperiores",
      "Description": "Public-key national function",
      "Email": "keven.hodkiewicz@kulas.name",
      "FullName": "Reagan Reinger",
      "DirectPhone": "401.773.3326",
      "FormalName": "Willms-Stoltenberg",
      "CountryId": 94,
      "ContactId": 71,
      "ContactName": "Johnston, Batz and Cummerata",
      "Retired": 339,
      "Rank": 899,
      "ActiveInterests": 405,
      "ContactDepartment": "",
      "ContactCountryId": 344,
      "ContactOrgNr": "220592",
      "FaxPhone": "579-698-5749",
      "MobilePhone": "386-717-3500",
      "ContactPhone": "1-747-373-1034",
      "AssociateName": "Kohler-Christiansen",
      "AssociateId": 82,
      "UsePersonAddress": true,
      "ContactFax": "fugit",
      "Kanafname": "molestias",
      "Kanalname": "quasi",
      "Post1": "eum",
      "Post2": "reprehenderit",
      "Post3": "nisi",
      "EmailName": "winifred_waters@schowalter.name",
      "ContactFullName": "Therese Buckridge",
      "ActiveErpLinks": 995,
      "TicketPriorityId": 600,
      "SupportLanguageId": 959,
      "SupportAssociateId": 292,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "cumque",
  "Xstop": true,
  "ActiveInterests": 57,
  "GroupId": 870,
  "ActiveStatusMonitorId": 690,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 797,
  "DbiAgentId": 871,
  "DbiLastSyncronized": "2005-12-11T03:31:25.8540863+01:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "1997-12-20T03:31:25.8540863+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 761,
  "ActiveErpLinks": 724,
  "BounceEmails": [
    "ronny.tillman@lehnerhowell.us",
    "chelsie@ryanbechtelar.info"
  ],
  "Domains": [
    "omnis",
    "tempore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kaela Ullrich",
    "SuperOffice:2": "Vicente Kihn"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "incidunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 767,
  "Name": "Tillman, Crona and Dicki",
  "Department": "",
  "OrgNr": "977620",
  "Number1": "1231707",
  "Number2": "1552719",
  "UpdatedDate": "2004-12-30T03:31:25.8540863+01:00",
  "CreatedDate": "2016-05-26T03:31:25.8540863+02:00",
  "Emails": [
    {
      "Value": "temporibus",
      "StrippedValue": "mollitia",
      "Description": "Right-sized fault-tolerant analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "mollitia",
      "Description": "Right-sized fault-tolerant analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 254,
      "Name": "Kassulke Group",
      "ToolTip": "Tempora eos porro omnis ea ad aperiam.",
      "Deleted": false,
      "Rank": 235,
      "Type": "consequatur",
      "ColorBlock": 605,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2001-11-10T03:31:25.8540863+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "labore",
      "Hidden": true,
      "FullName": "Maybelle Klocko",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "qui",
      "Description": "Ergonomic intangible knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "qui",
      "Description": "Ergonomic intangible knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "cumque",
      "Description": "Multi-channelled fresh-thinking groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 598
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "cumque",
      "Description": "Multi-channelled fresh-thinking groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 598
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "ea",
      "Description": "Focused solution-oriented process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "ea",
      "Description": "Focused solution-oriented process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "Description": "Versatile assymetric parallelism",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolore",
      "PersonId": 127,
      "Mrmrs": "quam",
      "Firstname": "Teresa",
      "Lastname": "Klein",
      "MiddleName": "Kihn Group",
      "Title": "quibusdam",
      "Description": "Upgradable eco-centric data-warehouse",
      "Email": "sonny.blick@hermiston.uk",
      "FullName": "Mrs. Bailee Runolfsdottir",
      "DirectPhone": "(866)972-8949",
      "FormalName": "Wisozk, Kautzer and Heaney",
      "CountryId": 531,
      "ContactId": 346,
      "ContactName": "Luettgen Group",
      "Retired": 571,
      "Rank": 381,
      "ActiveInterests": 465,
      "ContactDepartment": "",
      "ContactCountryId": 225,
      "ContactOrgNr": "258344",
      "FaxPhone": "916-301-3547 x3758",
      "MobilePhone": "958.163.6807",
      "ContactPhone": "926.436.5773 x363",
      "AssociateName": "Stark Group",
      "AssociateId": 211,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "architecto",
      "Kanalname": "ex",
      "Post1": "voluptatem",
      "Post2": "consequatur",
      "Post3": "ducimus",
      "EmailName": "trycia_koepp@hegmann.com",
      "ContactFullName": "Elissa Gerardo Abshire Jr.",
      "ActiveErpLinks": 908,
      "TicketPriorityId": 909,
      "SupportLanguageId": 974,
      "SupportAssociateId": 404,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 644
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "nulla",
  "Xstop": true,
  "ActiveInterests": 618,
  "GroupId": 216,
  "ActiveStatusMonitorId": 678,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 431,
  "DbiAgentId": 986,
  "DbiLastSyncronized": "1996-10-24T03:31:25.8540863+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2006-10-06T03:31:25.8540863+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 443,
  "ActiveErpLinks": 898,
  "BounceEmails": [
    "oran@heller.name",
    "keven_stark@gerlachrutherford.com"
  ],
  "Domains": [
    "omnis",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Audie Moen"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "blanditiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 269
    }
  }
}
```