---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 451,
  "Name": "Schuster LLC",
  "Department": "",
  "OrgNr": "567194",
  "Number1": "1232174",
  "Number2": "625191",
  "UpdatedDate": "1999-07-22T17:37:38.3628327+02:00",
  "CreatedDate": "2014-02-09T17:37:38.3628327+01:00",
  "Emails": [
    {
      "Value": "iure",
      "StrippedValue": "facilis",
      "Description": "Adaptive background service-desk"
    },
    {
      "Value": "iure",
      "StrippedValue": "facilis",
      "Description": "Adaptive background service-desk"
    }
  ],
  "Interests": [
    {
      "Id": 496,
      "Name": "Schultz, Wolff and Jones",
      "ToolTip": "Atque quibusdam molestiae ut molestiae ullam.",
      "Deleted": true,
      "Rank": 242,
      "Type": "impedit",
      "ColorBlock": 74,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2003-12-26T17:37:38.3628327+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "ipsa",
      "Hidden": true,
      "FullName": "Nia Davis DVM"
    }
  ],
  "Urls": [
    {
      "Value": "at",
      "StrippedValue": "similique",
      "Description": "Re-contextualized bifurcated benchmark"
    },
    {
      "Value": "at",
      "StrippedValue": "similique",
      "Description": "Re-contextualized bifurcated benchmark"
    }
  ],
  "Phones": [
    {
      "Value": "at",
      "StrippedValue": "labore",
      "Description": "Synergistic empowering pricing structure"
    },
    {
      "Value": "at",
      "StrippedValue": "labore",
      "Description": "Synergistic empowering pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "mollitia",
      "StrippedValue": "pariatur",
      "Description": "Reverse-engineered scalable time-frame"
    },
    {
      "Value": "mollitia",
      "StrippedValue": "pariatur",
      "Description": "Reverse-engineered scalable time-frame"
    }
  ],
  "Description": "User-centric 5th generation capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 44,
      "Mrmrs": "voluptatem",
      "Firstname": "Guillermo",
      "Lastname": "Stamm",
      "MiddleName": "Schmidt Inc and Sons",
      "Title": "nulla",
      "Description": "Grass-roots intermediate knowledge base",
      "Email": "felicita_grimes@quitzon.biz",
      "FullName": "Mr. Ettie Kayli Abbott III",
      "DirectPhone": "1-714-777-4498 x95910",
      "FormalName": "Schneider-Marks",
      "CountryId": 247,
      "ContactId": 187,
      "ContactName": "Bayer-Durgan",
      "Retired": 880,
      "Rank": 42,
      "ActiveInterests": 126,
      "ContactDepartment": "",
      "ContactCountryId": 130,
      "ContactOrgNr": "1222545",
      "FaxPhone": "470-183-8378",
      "MobilePhone": "750-003-2343 x40867",
      "ContactPhone": "646-735-9880 x259",
      "AssociateName": "Christiansen Group",
      "AssociateId": 581,
      "UsePersonAddress": false,
      "ContactFax": "accusamus",
      "Kanafname": "aut",
      "Kanalname": "hic",
      "Post1": "repudiandae",
      "Post2": "eum",
      "Post3": "vero",
      "EmailName": "carmela.cummings@davis.co.uk",
      "ContactFullName": "Dayne Carter I",
      "ActiveErpLinks": 19,
      "TicketPriorityId": 250,
      "SupportLanguageId": 699,
      "SupportAssociateId": 112,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "reprehenderit",
  "Xstop": false,
  "ActiveInterests": 528,
  "GroupId": 302,
  "ActiveStatusMonitorId": 773,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 412,
  "DbiAgentId": 504,
  "DbiLastSyncronized": "2006-12-30T17:37:38.366833+01:00",
  "DbiKey": "rerum",
  "DbiLastModified": "2012-03-21T17:37:38.366833+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 437,
  "ActiveErpLinks": 751,
  "BounceEmails": [
    "frances_hansen@gleason.name",
    "christy.schoen@hermannabernathy.info"
  ],
  "Domains": [
    "ipsum",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Clay Zieme",
    "SuperOffice:2": "Flossie Fay"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "sit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 1000,
  "Name": "Skiles, O'Keefe and Volkman",
  "Department": "",
  "OrgNr": "663929",
  "Number1": "1424098",
  "Number2": "1026752",
  "UpdatedDate": "2012-04-08T17:37:38.3778648+02:00",
  "CreatedDate": "2015-04-15T17:37:38.3778648+02:00",
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "saepe",
      "Description": "Quality-focused next generation analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 986
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "saepe",
      "Description": "Quality-focused next generation analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 986
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 435,
      "Name": "Wisozk Group",
      "ToolTip": "Incidunt debitis saepe voluptatem.",
      "Deleted": true,
      "Rank": 812,
      "Type": "quasi",
      "ColorBlock": 656,
      "IconHint": "corrupti",
      "Selected": false,
      "LastChanged": "1996-06-08T17:37:38.3778648+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "id",
      "Hidden": true,
      "FullName": "Ciara Kertzmann I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 494
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "quisquam",
      "Description": "Public-key discrete neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "quisquam",
      "Description": "Public-key discrete neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "libero",
      "Description": "Advanced well-modulated installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "libero",
      "Description": "Advanced well-modulated installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "similique",
      "Description": "Profound 24/7 infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "similique",
      "Description": "Profound 24/7 infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Description": "Vision-oriented responsive interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "natus",
      "PersonId": 421,
      "Mrmrs": "incidunt",
      "Firstname": "Lysanne",
      "Lastname": "Wilderman",
      "MiddleName": "Cartwright, Friesen and Dietrich",
      "Title": "et",
      "Description": "Balanced discrete framework",
      "Email": "cristobal.lubowitz@stromanullrich.uk",
      "FullName": "Greyson Jaskolski IV",
      "DirectPhone": "(172)654-2133",
      "FormalName": "Langworth-Hilll",
      "CountryId": 166,
      "ContactId": 990,
      "ContactName": "Yost-Schmitt",
      "Retired": 18,
      "Rank": 113,
      "ActiveInterests": 664,
      "ContactDepartment": "",
      "ContactCountryId": 132,
      "ContactOrgNr": "637819",
      "FaxPhone": "882-086-2235",
      "MobilePhone": "819-283-3343 x32396",
      "ContactPhone": "747-750-8074 x046",
      "AssociateName": "Kertzmann, Hodkiewicz and Gottlieb",
      "AssociateId": 666,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "nemo",
      "Kanalname": "et",
      "Post1": "deleniti",
      "Post2": "rem",
      "Post3": "voluptatem",
      "EmailName": "josiah.satterfield@corkery.info",
      "ContactFullName": "Jaydon Roberts",
      "ActiveErpLinks": 134,
      "TicketPriorityId": 859,
      "SupportLanguageId": 213,
      "SupportAssociateId": 228,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quod",
  "Xstop": true,
  "ActiveInterests": 484,
  "GroupId": 184,
  "ActiveStatusMonitorId": 997,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 828,
  "DbiAgentId": 916,
  "DbiLastSyncronized": "1996-06-08T17:37:38.3818648+02:00",
  "DbiKey": "eos",
  "DbiLastModified": "2016-06-13T17:37:38.3818648+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 626,
  "ActiveErpLinks": 997,
  "BounceEmails": [
    "lilyan@feeney.uk",
    "kara.ryan@murray.co.uk"
  ],
  "Domains": [
    "veritatis",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "935276006",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "quibusdam",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 333
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```