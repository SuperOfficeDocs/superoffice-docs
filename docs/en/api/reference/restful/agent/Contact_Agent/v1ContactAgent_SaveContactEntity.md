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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 732,
  "Name": "McDermott, Parker and Jaskolski",
  "Department": "",
  "OrgNr": "1373368",
  "Number1": "900257",
  "Number2": "439815",
  "UpdatedDate": "2013-12-18T12:19:44.8673486+01:00",
  "CreatedDate": "2000-01-17T12:19:44.8673486+01:00",
  "Emails": [
    {
      "Value": "rem",
      "StrippedValue": "amet",
      "Description": "Switchable neutral capacity"
    },
    {
      "Value": "rem",
      "StrippedValue": "amet",
      "Description": "Switchable neutral capacity"
    }
  ],
  "Interests": [
    {
      "Id": 157,
      "Name": "Stroman Inc and Sons",
      "ToolTip": "Laboriosam expedita quibusdam id nam placeat voluptas omnis.",
      "Deleted": false,
      "Rank": 47,
      "Type": "ea",
      "ColorBlock": 397,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2005-10-20T12:19:44.8673486+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "dolorum",
      "Hidden": false,
      "FullName": "Kaitlyn Dach"
    }
  ],
  "Urls": [
    {
      "Value": "nam",
      "StrippedValue": "molestiae",
      "Description": "Open-source fault-tolerant matrices"
    },
    {
      "Value": "nam",
      "StrippedValue": "molestiae",
      "Description": "Open-source fault-tolerant matrices"
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "quo",
      "Description": "Triple-buffered zero tolerance productivity"
    },
    {
      "Value": "est",
      "StrippedValue": "quo",
      "Description": "Triple-buffered zero tolerance productivity"
    }
  ],
  "Faxes": [
    {
      "Value": "at",
      "StrippedValue": "nulla",
      "Description": "Synergistic responsive open system"
    },
    {
      "Value": "at",
      "StrippedValue": "nulla",
      "Description": "Synergistic responsive open system"
    }
  ],
  "Description": "Total bifurcated hierarchy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 791,
      "Mrmrs": "deleniti",
      "Firstname": "Daija",
      "Lastname": "Spinka",
      "MiddleName": "Fisher-Botsford",
      "Title": "odit",
      "Description": "Organic executive array",
      "Email": "lillie.leannon@walter.name",
      "FullName": "Bell Keeling",
      "DirectPhone": "(696)990-6173",
      "FormalName": "Stoltenberg Inc and Sons",
      "CountryId": 575,
      "ContactId": 618,
      "ContactName": "Kerluke, Kozey and Hane",
      "Retired": 299,
      "Rank": 754,
      "ActiveInterests": 477,
      "ContactDepartment": "",
      "ContactCountryId": 917,
      "ContactOrgNr": "806920",
      "FaxPhone": "1-985-657-5239 x08267",
      "MobilePhone": "1-254-017-8150",
      "ContactPhone": "(110)055-5201 x978",
      "AssociateName": "McDermott-Mills",
      "AssociateId": 788,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "aperiam",
      "Kanalname": "qui",
      "Post1": "illo",
      "Post2": "quia",
      "Post3": "ut",
      "EmailName": "kendall_doyle@keeling.com",
      "ContactFullName": "Mr. Floyd Paucek III",
      "ActiveErpLinks": 403,
      "TicketPriorityId": 796,
      "SupportLanguageId": 284,
      "SupportAssociateId": 478,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "aperiam",
  "Xstop": false,
  "ActiveInterests": 225,
  "GroupId": 770,
  "ActiveStatusMonitorId": 755,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 894,
  "DbiAgentId": 870,
  "DbiLastSyncronized": "2000-06-23T12:19:44.8673486+02:00",
  "DbiKey": "quibusdam",
  "DbiLastModified": "2019-04-11T12:19:44.8673486+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 910,
  "ActiveErpLinks": 256,
  "BounceEmails": [
    "kimberly@rau.ca",
    "arne.gaylord@harris.com"
  ],
  "Domains": [
    "voluptatibus",
    "quaerat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Lonnie Lindgren",
    "SuperOffice:2": "Odessa Lakin DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "quaerat"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 573,
  "Name": "Hermann LLC",
  "Department": "",
  "OrgNr": "943940",
  "Number1": "397031",
  "Number2": "1051416",
  "UpdatedDate": "1998-01-29T12:19:44.8829726+01:00",
  "CreatedDate": "2012-09-06T12:19:44.8829726+02:00",
  "Emails": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "aliquid",
      "Description": "Optimized 24/7 attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "aliquid",
      "Description": "Optimized 24/7 attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 63,
      "Name": "Koelpin-Hackett",
      "ToolTip": "Consequatur et reprehenderit consequatur.",
      "Deleted": false,
      "Rank": 476,
      "Type": "alias",
      "ColorBlock": 527,
      "IconHint": "laboriosam",
      "Selected": true,
      "LastChanged": "2013-08-02T12:19:44.8829726+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "libero",
      "StyleHint": "ea",
      "Hidden": false,
      "FullName": "Uriel Flatley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 850
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "architecto",
      "StrippedValue": "fuga",
      "Description": "Networked radical focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "fuga",
      "Description": "Networked radical focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "adipisci",
      "Description": "Implemented mobile archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "adipisci",
      "Description": "Implemented mobile archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "temporibus",
      "StrippedValue": "omnis",
      "Description": "Re-engineered methodical database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "omnis",
      "Description": "Re-engineered methodical database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "Description": "Self-enabling transitional projection",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequuntur",
      "PersonId": 708,
      "Mrmrs": "itaque",
      "Firstname": "Joany",
      "Lastname": "Runolfsdottir",
      "MiddleName": "Braun-Oberbrunner",
      "Title": "quis",
      "Description": "Cloned 5th generation concept",
      "Email": "milford_franecki@wilkinson.ca",
      "FullName": "Karlee Rodriguez",
      "DirectPhone": "285-609-2843 x2349",
      "FormalName": "Brakus, McCullough and Hirthe",
      "CountryId": 652,
      "ContactId": 637,
      "ContactName": "Gutmann, Ratke and West",
      "Retired": 816,
      "Rank": 269,
      "ActiveInterests": 431,
      "ContactDepartment": "",
      "ContactCountryId": 792,
      "ContactOrgNr": "1118059",
      "FaxPhone": "102-750-2845",
      "MobilePhone": "(215)288-1972 x8520",
      "ContactPhone": "024-970-4088 x79835",
      "AssociateName": "Weimann Inc and Sons",
      "AssociateId": 190,
      "UsePersonAddress": true,
      "ContactFax": "impedit",
      "Kanafname": "quo",
      "Kanalname": "quo",
      "Post1": "sed",
      "Post2": "unde",
      "Post3": "quo",
      "EmailName": "jackeline@rath.com",
      "ContactFullName": "Prof. Madison Funk I",
      "ActiveErpLinks": 518,
      "TicketPriorityId": 520,
      "SupportLanguageId": 159,
      "SupportAssociateId": 199,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": false,
  "ActiveInterests": 399,
  "GroupId": 676,
  "ActiveStatusMonitorId": 60,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 867,
  "DbiAgentId": 832,
  "DbiLastSyncronized": "2003-04-21T12:19:44.8829726+02:00",
  "DbiKey": "ea",
  "DbiLastModified": "2007-03-16T12:19:44.8829726+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 539,
  "ActiveErpLinks": 477,
  "BounceEmails": [
    "ford.bashirian@mcclurebeer.info",
    "gerald.kreiger@kuhlman.ca"
  ],
  "Domains": [
    "culpa",
    "enim"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Elena DuBuque",
    "SuperOffice:2": "1745106007"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "saepe",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 579
    }
  }
}
```