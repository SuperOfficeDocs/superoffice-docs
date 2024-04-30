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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 952,
  "Name": "Mraz, Schumm and Cassin",
  "Department": "",
  "OrgNr": "1114561",
  "Number1": "741896",
  "Number2": "1356038",
  "UpdatedDate": "2005-01-28T11:16:08.8659714+01:00",
  "CreatedDate": "1999-09-13T11:16:08.8659714+02:00",
  "Emails": [
    {
      "Value": "suscipit",
      "StrippedValue": "deleniti",
      "Description": "Vision-oriented intangible hub"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "deleniti",
      "Description": "Vision-oriented intangible hub"
    }
  ],
  "Interests": [
    {
      "Id": 324,
      "Name": "Flatley, Shanahan and Hermiston",
      "ToolTip": "Qui blanditiis quia architecto non.",
      "Deleted": false,
      "Rank": 180,
      "Type": "voluptatem",
      "ColorBlock": 265,
      "IconHint": "animi",
      "Selected": true,
      "LastChanged": "2003-05-02T11:16:08.8659714+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Vaughn Beier"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "qui",
      "Description": "Extended well-modulated complexity"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "qui",
      "Description": "Extended well-modulated complexity"
    }
  ],
  "Phones": [
    {
      "Value": "ab",
      "StrippedValue": "temporibus",
      "Description": "Persistent web-enabled encryption"
    },
    {
      "Value": "ab",
      "StrippedValue": "temporibus",
      "Description": "Persistent web-enabled encryption"
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "laudantium",
      "Description": "Innovative multi-tasking definition"
    },
    {
      "Value": "ad",
      "StrippedValue": "laudantium",
      "Description": "Innovative multi-tasking definition"
    }
  ],
  "Description": "Fundamental empowering challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "culpa",
      "PersonId": 392,
      "Mrmrs": "debitis",
      "Firstname": "Corene",
      "Lastname": "Parker",
      "MiddleName": "Schneider Inc and Sons",
      "Title": "et",
      "Description": "Up-sized disintermediate middleware",
      "Email": "mya_stokes@goodwinhahn.co.uk",
      "FullName": "Ms. Rogelio Naomie Senger",
      "DirectPhone": "1-173-811-2949 x88341",
      "FormalName": "Bergstrom-Satterfield",
      "CountryId": 918,
      "ContactId": 548,
      "ContactName": "Kilback, Hermiston and Ritchie",
      "Retired": 260,
      "Rank": 539,
      "ActiveInterests": 289,
      "ContactDepartment": "",
      "ContactCountryId": 292,
      "ContactOrgNr": "1069037",
      "FaxPhone": "1-045-263-1008",
      "MobilePhone": "794-825-0435 x78877",
      "ContactPhone": "233.804.1837",
      "AssociateName": "Hansen-Rosenbaum",
      "AssociateId": 3,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "sapiente",
      "Kanalname": "quo",
      "Post1": "ea",
      "Post2": "repellat",
      "Post3": "hic",
      "EmailName": "richmond@hartmannbuckridge.com",
      "ContactFullName": "Mrs. Lee Jan Nitzsche Jr.",
      "ActiveErpLinks": 163,
      "TicketPriorityId": 184,
      "SupportLanguageId": 539,
      "SupportAssociateId": 365,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "illum",
  "Xstop": false,
  "ActiveInterests": 775,
  "GroupId": 960,
  "ActiveStatusMonitorId": 834,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 246,
  "DbiAgentId": 363,
  "DbiLastSyncronized": "2002-06-23T11:16:08.8659714+02:00",
  "DbiKey": "molestiae",
  "DbiLastModified": "1999-03-21T11:16:08.8659714+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 428,
  "ActiveErpLinks": 371,
  "BounceEmails": [
    "doyle.thompson@krajcik.info",
    "dominique.skiles@kshlerin.ca"
  ],
  "Domains": [
    "vero",
    "consequatur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Aiyana Leannon",
    "SuperOffice:2": "Dr. Jermey Windler"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "dolor"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 807,
  "Name": "Morar-Hegmann",
  "Department": "",
  "OrgNr": "545346",
  "Number1": "392390",
  "Number2": "1226338",
  "UpdatedDate": "2002-04-16T11:16:08.8659714+02:00",
  "CreatedDate": "2005-12-30T11:16:08.8659714+01:00",
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "perferendis",
      "Description": "Function-based leading edge access",
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
      "Value": "ullam",
      "StrippedValue": "perferendis",
      "Description": "Function-based leading edge access",
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
  "Interests": [
    {
      "Id": 726,
      "Name": "Legros-Dare",
      "ToolTip": "Tempora quidem sit laboriosam eum.",
      "Deleted": true,
      "Rank": 969,
      "Type": "eos",
      "ColorBlock": 223,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2004-02-16T11:16:08.8659714+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "aperiam",
      "Hidden": false,
      "FullName": "Dr. August McDermott MD",
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
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "veritatis",
      "Description": "Horizontal tertiary capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 516
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "veritatis",
      "Description": "Horizontal tertiary capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 516
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "est",
      "Description": "Virtual modular toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 92
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "est",
      "Description": "Virtual modular toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 92
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "amet",
      "StrippedValue": "optio",
      "Description": "Re-engineered composite initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 112
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "optio",
      "Description": "Re-engineered composite initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 112
        }
      }
    }
  ],
  "Description": "Visionary didactic forecast",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "a",
      "PersonId": 870,
      "Mrmrs": "iste",
      "Firstname": "Kellie",
      "Lastname": "Turner",
      "MiddleName": "Connelly, McLaughlin and Satterfield",
      "Title": "quia",
      "Description": "Implemented logistical ability",
      "Email": "buck_gaylord@bernierdach.name",
      "FullName": "Reginald Mayert",
      "DirectPhone": "(385)398-8421 x849",
      "FormalName": "Wuckert, Quitzon and Daniel",
      "CountryId": 685,
      "ContactId": 20,
      "ContactName": "Mosciski-Gusikowski",
      "Retired": 404,
      "Rank": 747,
      "ActiveInterests": 358,
      "ContactDepartment": "",
      "ContactCountryId": 76,
      "ContactOrgNr": "660783",
      "FaxPhone": "875.679.5648",
      "MobilePhone": "1-849-935-1297 x955",
      "ContactPhone": "(998)485-5438 x173",
      "AssociateName": "Jones-Dietrich",
      "AssociateId": 595,
      "UsePersonAddress": true,
      "ContactFax": "excepturi",
      "Kanafname": "fugit",
      "Kanalname": "non",
      "Post1": "dignissimos",
      "Post2": "velit",
      "Post3": "qui",
      "EmailName": "kavon.stanton@lesch.com",
      "ContactFullName": "Jeremy Keeling",
      "ActiveErpLinks": 33,
      "TicketPriorityId": 438,
      "SupportLanguageId": 702,
      "SupportAssociateId": 154,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 866,
  "GroupId": 321,
  "ActiveStatusMonitorId": 770,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 121,
  "DbiAgentId": 75,
  "DbiLastSyncronized": "2016-11-20T11:16:08.8659714+01:00",
  "DbiKey": "eaque",
  "DbiLastModified": "2005-07-15T11:16:08.8659714+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 996,
  "ActiveErpLinks": 472,
  "BounceEmails": [
    "catalina_kautzer@johnsfahey.us",
    "dion@romaguera.info"
  ],
  "Domains": [
    "dolor",
    "voluptatem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "56101960",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 867
    }
  }
}
```