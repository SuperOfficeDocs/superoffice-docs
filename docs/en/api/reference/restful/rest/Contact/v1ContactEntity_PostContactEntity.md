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
  "ContactId": 411,
  "Name": "Becker LLC",
  "Department": "",
  "OrgNr": "1232507",
  "Number1": "835479",
  "Number2": "342603",
  "UpdatedDate": "2021-11-22T13:38:17.218095+01:00",
  "CreatedDate": "2023-06-24T13:38:17.218095+02:00",
  "Emails": [
    {
      "Value": "distinctio",
      "StrippedValue": "eum",
      "Description": "Decentralized discrete paradigm"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "eum",
      "Description": "Decentralized discrete paradigm"
    }
  ],
  "Interests": [
    {
      "Id": 551,
      "Name": "Pagac-Schimmel",
      "ToolTip": "Similique nihil suscipit dolorum.",
      "Deleted": false,
      "Rank": 301,
      "Type": "deleniti",
      "ColorBlock": 979,
      "IconHint": "ipsa",
      "Selected": true,
      "LastChanged": "2011-08-08T13:38:17.218095+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "distinctio",
      "StyleHint": "eaque",
      "Hidden": true,
      "FullName": "Chet Ritchie"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "omnis",
      "Description": "Realigned actuating model"
    },
    {
      "Value": "ut",
      "StrippedValue": "omnis",
      "Description": "Realigned actuating model"
    }
  ],
  "Phones": [
    {
      "Value": "natus",
      "StrippedValue": "veritatis",
      "Description": "Innovative logistical encoding"
    },
    {
      "Value": "natus",
      "StrippedValue": "veritatis",
      "Description": "Innovative logistical encoding"
    }
  ],
  "Faxes": [
    {
      "Value": "earum",
      "StrippedValue": "cumque",
      "Description": "Right-sized logistical neural-net"
    },
    {
      "Value": "earum",
      "StrippedValue": "cumque",
      "Description": "Right-sized logistical neural-net"
    }
  ],
  "Description": "Integrated local hierarchy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolore",
      "PersonId": 946,
      "Mrmrs": "et",
      "Firstname": "Alycia",
      "Lastname": "Durgan",
      "MiddleName": "Dibbert, Williamson and Flatley",
      "Title": "repellat",
      "Description": "Robust client-server toolset",
      "Email": "ernie@kutch.ca",
      "FullName": "Alexandre Dicki",
      "DirectPhone": "(069)358-0978",
      "FormalName": "Kshlerin, Abbott and Hansen",
      "CountryId": 450,
      "ContactId": 140,
      "ContactName": "Upton, Johnson and Beier",
      "Retired": 446,
      "Rank": 757,
      "ActiveInterests": 19,
      "ContactDepartment": "",
      "ContactCountryId": 444,
      "ContactOrgNr": "401182",
      "FaxPhone": "056.902.3908 x935",
      "MobilePhone": "932-913-8207 x6122",
      "ContactPhone": "(803)529-1205",
      "AssociateName": "O'Keefe Group",
      "AssociateId": 48,
      "UsePersonAddress": false,
      "ContactFax": "explicabo",
      "Kanafname": "quis",
      "Kanalname": "est",
      "Post1": "mollitia",
      "Post2": "omnis",
      "Post3": "totam",
      "EmailName": "glennie@wilderman.biz",
      "ContactFullName": "Vernice Corkery",
      "ActiveErpLinks": 179,
      "TicketPriorityId": 459,
      "SupportLanguageId": 846,
      "SupportAssociateId": 221,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "architecto",
  "Xstop": false,
  "ActiveInterests": 649,
  "GroupId": 416,
  "ActiveStatusMonitorId": 215,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 709,
  "DbiAgentId": 178,
  "DbiLastSyncronized": "2014-07-11T13:38:17.218095+02:00",
  "DbiKey": "nisi",
  "DbiLastModified": "2023-08-09T13:38:17.218095+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 636,
  "ActiveErpLinks": 554,
  "BounceEmails": [
    "aletha@bernierlangworth.name",
    "viviane@lueilwitzgottlieb.us"
  ],
  "Domains": [
    "optio",
    "repudiandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Norwood Schulist",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "nostrum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 248,
  "Name": "Fahey-Hartmann",
  "Department": "",
  "OrgNr": "297240",
  "Number1": "543671",
  "Number2": "954623",
  "UpdatedDate": "2010-12-21T13:38:17.218095+01:00",
  "CreatedDate": "2018-08-21T13:38:17.218095+02:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "et",
      "Description": "Implemented bifurcated software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "et",
      "Description": "Implemented bifurcated software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 787,
      "Name": "Paucek-Weber",
      "ToolTip": "Quae consequatur fugiat dolorum debitis reiciendis.",
      "Deleted": false,
      "Rank": 321,
      "Type": "vero",
      "ColorBlock": 947,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2007-12-24T13:38:17.218095+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "aperiam",
      "Hidden": false,
      "FullName": "Leilani Reilly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "laudantium",
      "Description": "Right-sized stable moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 666
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "laudantium",
      "Description": "Right-sized stable moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 666
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "esse",
      "Description": "Secured dynamic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "esse",
      "Description": "Secured dynamic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "aut",
      "Description": "Open-architected needs-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "aut",
      "Description": "Open-architected needs-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 323
        }
      }
    }
  ],
  "Description": "Pre-emptive next generation collaboration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "animi",
      "PersonId": 451,
      "Mrmrs": "qui",
      "Firstname": "Garfield",
      "Lastname": "Vandervort",
      "MiddleName": "Pfannerstill-Goldner",
      "Title": "nesciunt",
      "Description": "Object-based intangible installation",
      "Email": "alysa@predovic.ca",
      "FullName": "Giovani Ethel Prosacco V",
      "DirectPhone": "050-239-2233",
      "FormalName": "Ratke-Bode",
      "CountryId": 471,
      "ContactId": 631,
      "ContactName": "Flatley LLC",
      "Retired": 76,
      "Rank": 259,
      "ActiveInterests": 407,
      "ContactDepartment": "",
      "ContactCountryId": 146,
      "ContactOrgNr": "1080575",
      "FaxPhone": "1-159-352-5984 x51839",
      "MobilePhone": "1-953-176-8379 x9020",
      "ContactPhone": "427.459.6303 x178",
      "AssociateName": "Rath-West",
      "AssociateId": 922,
      "UsePersonAddress": false,
      "ContactFax": "cumque",
      "Kanafname": "sit",
      "Kanalname": "perferendis",
      "Post1": "eum",
      "Post2": "perferendis",
      "Post3": "repellendus",
      "EmailName": "madisyn@leuschke.us",
      "ContactFullName": "Miss Amber Amos Hoppe Sr.",
      "ActiveErpLinks": 593,
      "TicketPriorityId": 149,
      "SupportLanguageId": 145,
      "SupportAssociateId": 492,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ex",
  "Xstop": true,
  "ActiveInterests": 931,
  "GroupId": 237,
  "ActiveStatusMonitorId": 894,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 307,
  "DbiAgentId": 700,
  "DbiLastSyncronized": "1996-08-17T13:38:17.2337227+02:00",
  "DbiKey": "neque",
  "DbiLastModified": "2001-02-19T13:38:17.2337227+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 937,
  "ActiveErpLinks": 580,
  "BounceEmails": [
    "jaycee@luettgen.us",
    "flavio.roob@harveypurdy.us"
  ],
  "Domains": [
    "at",
    "eum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1219785894",
    "SuperOffice:2": "Jessika Watsica"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "nesciunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 916
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```