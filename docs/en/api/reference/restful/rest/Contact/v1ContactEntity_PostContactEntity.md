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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 109,
  "Name": "Olson-Stark",
  "Department": "",
  "OrgNr": "872782",
  "Number1": "523027",
  "Number2": "1311321",
  "UpdatedDate": "2006-04-19T03:31:32.3945891+02:00",
  "CreatedDate": "2011-12-24T03:31:32.3945891+01:00",
  "Emails": [
    {
      "Value": "quibusdam",
      "StrippedValue": "dolor",
      "Description": "Programmable systematic approach"
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "dolor",
      "Description": "Programmable systematic approach"
    }
  ],
  "Interests": [
    {
      "Id": 700,
      "Name": "Sporer-Rau",
      "ToolTip": "Molestiae autem.",
      "Deleted": false,
      "Rank": 182,
      "Type": "dolorum",
      "ColorBlock": 770,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2015-02-22T03:31:32.3945891+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "quod",
      "Hidden": false,
      "FullName": "Dayton Eichmann"
    }
  ],
  "Urls": [
    {
      "Value": "architecto",
      "StrippedValue": "ut",
      "Description": "Intuitive 3rd generation monitoring"
    },
    {
      "Value": "architecto",
      "StrippedValue": "ut",
      "Description": "Intuitive 3rd generation monitoring"
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "dolorem",
      "Description": "Operative upward-trending matrices"
    },
    {
      "Value": "qui",
      "StrippedValue": "dolorem",
      "Description": "Operative upward-trending matrices"
    }
  ],
  "Faxes": [
    {
      "Value": "optio",
      "StrippedValue": "perferendis",
      "Description": "Face to face next generation standardization"
    },
    {
      "Value": "optio",
      "StrippedValue": "perferendis",
      "Description": "Face to face next generation standardization"
    }
  ],
  "Description": "Devolved client-server internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 523,
      "Mrmrs": "sunt",
      "Firstname": "Georgiana",
      "Lastname": "Macejkovic",
      "MiddleName": "Kovacek Group",
      "Title": "aut",
      "Description": "Ameliorated heuristic toolset",
      "Email": "charity.reynolds@cummeratadenesik.name",
      "FullName": "Jovan Marquardt I",
      "DirectPhone": "(043)174-4008",
      "FormalName": "Abshire LLC",
      "CountryId": 950,
      "ContactId": 269,
      "ContactName": "Donnelly Group",
      "Retired": 194,
      "Rank": 516,
      "ActiveInterests": 333,
      "ContactDepartment": "",
      "ContactCountryId": 221,
      "ContactOrgNr": "931296",
      "FaxPhone": "114.691.4944 x0616",
      "MobilePhone": "751.294.3973 x9772",
      "ContactPhone": "1-728-444-6957",
      "AssociateName": "Rolfson-Parisian",
      "AssociateId": 973,
      "UsePersonAddress": false,
      "ContactFax": "debitis",
      "Kanafname": "sunt",
      "Kanalname": "voluptatem",
      "Post1": "dignissimos",
      "Post2": "dolorem",
      "Post3": "ab",
      "EmailName": "alanna_corwin@goyette.us",
      "ContactFullName": "Mr. Pete Zachery Hahn",
      "ActiveErpLinks": 528,
      "TicketPriorityId": 825,
      "SupportLanguageId": 399,
      "SupportAssociateId": 796,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "accusantium",
  "Xstop": true,
  "ActiveInterests": 735,
  "GroupId": 848,
  "ActiveStatusMonitorId": 505,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 943,
  "DbiAgentId": 692,
  "DbiLastSyncronized": "1999-02-08T03:31:32.4102115+01:00",
  "DbiKey": "eum",
  "DbiLastModified": "2010-11-10T03:31:32.4102115+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 688,
  "ActiveErpLinks": 732,
  "BounceEmails": [
    "alexane_kozey@breitenberg.us",
    "candice@hansen.biz"
  ],
  "Domains": [
    "similique",
    "tenetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Columbus Brain Mosciski Jr.",
    "SuperOffice:2": "Carlotta Nakia Cassin MD"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "sed"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 628,
  "Name": "Hand Group",
  "Department": "",
  "OrgNr": "627603",
  "Number1": "1468610",
  "Number2": "1100423",
  "UpdatedDate": "2018-01-09T03:31:32.4102115+01:00",
  "CreatedDate": "1997-09-03T03:31:32.4102115+02:00",
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "dolores",
      "Description": "Synergized discrete productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 908
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "dolores",
      "Description": "Synergized discrete productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 908
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 157,
      "Name": "Shanahan-Rutherford",
      "ToolTip": "Non et magni ullam.",
      "Deleted": false,
      "Rank": 511,
      "Type": "cumque",
      "ColorBlock": 149,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2005-05-20T03:31:32.4102115+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "eligendi",
      "Hidden": false,
      "FullName": "Elnora Morissette IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "quia",
      "Description": "Expanded systematic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 639
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "quia",
      "Description": "Expanded systematic application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 639
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "perferendis",
      "Description": "Grass-roots dedicated complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 233
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "perferendis",
      "Description": "Grass-roots dedicated complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 233
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "et",
      "Description": "Organic holistic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "et",
      "Description": "Organic holistic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    }
  ],
  "Description": "Organized dynamic capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolores",
      "PersonId": 272,
      "Mrmrs": "voluptate",
      "Firstname": "Jett",
      "Lastname": "Hills",
      "MiddleName": "Boyer Inc and Sons",
      "Title": "et",
      "Description": "De-engineered leading edge architecture",
      "Email": "eva_vonrueden@dickinson.biz",
      "FullName": "Miss Trey Dillon Bruen DVM",
      "DirectPhone": "046-630-9907 x021",
      "FormalName": "Yost LLC",
      "CountryId": 676,
      "ContactId": 776,
      "ContactName": "Dach-Ziemann",
      "Retired": 532,
      "Rank": 167,
      "ActiveInterests": 358,
      "ContactDepartment": "",
      "ContactCountryId": 232,
      "ContactOrgNr": "524282",
      "FaxPhone": "1-120-338-3355",
      "MobilePhone": "709.911.0466 x6177",
      "ContactPhone": "1-173-083-6390",
      "AssociateName": "Jakubowski-Bednar",
      "AssociateId": 627,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "quae",
      "Kanalname": "recusandae",
      "Post1": "fugit",
      "Post2": "labore",
      "Post3": "ut",
      "EmailName": "maryam_rowe@boganbruen.ca",
      "ContactFullName": "Hollis Bogisich",
      "ActiveErpLinks": 280,
      "TicketPriorityId": 590,
      "SupportLanguageId": 654,
      "SupportAssociateId": 30,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dolor",
  "Xstop": false,
  "ActiveInterests": 661,
  "GroupId": 195,
  "ActiveStatusMonitorId": 182,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 787,
  "DbiAgentId": 957,
  "DbiLastSyncronized": "2001-11-10T03:31:32.4102115+01:00",
  "DbiKey": "optio",
  "DbiLastModified": "2008-11-27T03:31:32.4102115+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 186,
  "ActiveErpLinks": 257,
  "BounceEmails": [
    "lucie.larkin@schumm.info",
    "chase_schroeder@kihn.ca"
  ],
  "Domains": [
    "corrupti",
    "explicabo"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Norval Melba Hegmann Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "ducimus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 248
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```