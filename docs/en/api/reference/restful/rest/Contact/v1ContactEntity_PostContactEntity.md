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
  "ContactId": 987,
  "Name": "Collier, Ledner and Kessler",
  "Department": "",
  "OrgNr": "866016",
  "Number1": "1153065",
  "Number2": "1607535",
  "UpdatedDate": "2020-08-18T13:57:18.5909312+02:00",
  "CreatedDate": "1999-10-15T13:57:18.5909312+02:00",
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "saepe",
      "Description": "Front-line 24 hour superstructure"
    },
    {
      "Value": "eius",
      "StrippedValue": "saepe",
      "Description": "Front-line 24 hour superstructure"
    }
  ],
  "Interests": [
    {
      "Id": 500,
      "Name": "Stark, Douglas and Prohaska",
      "ToolTip": "Quos adipisci eius non nam.",
      "Deleted": true,
      "Rank": 575,
      "Type": "rem",
      "ColorBlock": 697,
      "IconHint": "impedit",
      "Selected": false,
      "LastChanged": "2017-11-30T13:57:18.5909312+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "blanditiis",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Miss Conner Predovic"
    }
  ],
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "delectus",
      "Description": "Down-sized optimizing leverage"
    },
    {
      "Value": "vitae",
      "StrippedValue": "delectus",
      "Description": "Down-sized optimizing leverage"
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "officia",
      "Description": "Customer-focused assymetric matrix"
    },
    {
      "Value": "aut",
      "StrippedValue": "officia",
      "Description": "Customer-focused assymetric matrix"
    }
  ],
  "Faxes": [
    {
      "Value": "distinctio",
      "StrippedValue": "numquam",
      "Description": "Devolved interactive hub"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "numquam",
      "Description": "Devolved interactive hub"
    }
  ],
  "Description": "Innovative multi-state function",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatibus",
      "PersonId": 739,
      "Mrmrs": "ipsa",
      "Firstname": "Gardner",
      "Lastname": "Pagac",
      "MiddleName": "Langworth Inc and Sons",
      "Title": "est",
      "Description": "Object-based background challenge",
      "Email": "albertha@reichert.com",
      "FullName": "Mrs. Nicholas Winifred Harvey",
      "DirectPhone": "361-503-7867 x4060",
      "FormalName": "McCullough, Cassin and Carter",
      "CountryId": 727,
      "ContactId": 167,
      "ContactName": "Hills-Willms",
      "Retired": 182,
      "Rank": 138,
      "ActiveInterests": 256,
      "ContactDepartment": "",
      "ContactCountryId": 805,
      "ContactOrgNr": "937853",
      "FaxPhone": "577-700-1441 x28133",
      "MobilePhone": "(819)673-4038",
      "ContactPhone": "262.282.8361 x3285",
      "AssociateName": "Waelchi Group",
      "AssociateId": 806,
      "UsePersonAddress": false,
      "ContactFax": "enim",
      "Kanafname": "tempora",
      "Kanalname": "quo",
      "Post1": "nulla",
      "Post2": "sed",
      "Post3": "pariatur",
      "EmailName": "madalyn@runolfsdottir.co.uk",
      "ContactFullName": "Daniella Jeromy Kuhn Jr.",
      "ActiveErpLinks": 10,
      "TicketPriorityId": 28,
      "SupportLanguageId": 360,
      "SupportAssociateId": 845,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "perferendis",
  "Xstop": false,
  "ActiveInterests": 353,
  "GroupId": 719,
  "ActiveStatusMonitorId": 926,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 653,
  "DbiAgentId": 976,
  "DbiLastSyncronized": "2011-11-11T13:57:18.5909312+01:00",
  "DbiKey": "suscipit",
  "DbiLastModified": "2007-05-08T13:57:18.5909312+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 996,
  "ActiveErpLinks": 232,
  "BounceEmails": [
    "brandon@quitzon.com",
    "ronaldo.oberbrunner@keelingturcotte.us"
  ],
  "Domains": [
    "sint",
    "nam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Ocie Edison Boyer MD",
    "SuperOffice:2": "Kylie Greenholt"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 496,
  "Name": "Conroy-Von",
  "Department": "",
  "OrgNr": "980164",
  "Number1": "820773",
  "Number2": "484861",
  "UpdatedDate": "2018-07-26T13:57:18.5909312+02:00",
  "CreatedDate": "2013-11-23T13:57:18.5909312+01:00",
  "Emails": [
    {
      "Value": "earum",
      "StrippedValue": "omnis",
      "Description": "Fundamental national focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "omnis",
      "Description": "Fundamental national focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 307,
      "Name": "Muller, O'Conner and Bradtke",
      "ToolTip": "In voluptatem vel dolor ducimus aliquid sit at.",
      "Deleted": false,
      "Rank": 975,
      "Type": "repudiandae",
      "ColorBlock": 118,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "1998-07-17T13:57:18.5909312+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "a",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Prof. Cleo Samanta Kuphal V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "delectus",
      "Description": "Vision-oriented cohesive framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "delectus",
      "Description": "Vision-oriented cohesive framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 47
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "atque",
      "Description": "Extended systematic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 281
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "atque",
      "Description": "Extended systematic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 281
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "qui",
      "Description": "Multi-channelled secondary extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "qui",
      "Description": "Multi-channelled secondary extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    }
  ],
  "Description": "Secured non-volatile groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 748,
      "Mrmrs": "ea",
      "Firstname": "Nellie",
      "Lastname": "Gaylord",
      "MiddleName": "Greenholt, Hamill and Mosciski",
      "Title": "quisquam",
      "Description": "Customer-focused system-worthy policy",
      "Email": "quinten@jenkinsherzog.biz",
      "FullName": "Dagmar Auer",
      "DirectPhone": "800.778.0537 x535",
      "FormalName": "Connelly-Langosh",
      "CountryId": 676,
      "ContactId": 240,
      "ContactName": "Bernhard Group",
      "Retired": 419,
      "Rank": 778,
      "ActiveInterests": 849,
      "ContactDepartment": "",
      "ContactCountryId": 621,
      "ContactOrgNr": "304359",
      "FaxPhone": "071.351.3683",
      "MobilePhone": "396-299-7978 x577",
      "ContactPhone": "(988)717-4329",
      "AssociateName": "Vandervort, Paucek and Batz",
      "AssociateId": 404,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "nostrum",
      "Kanalname": "deserunt",
      "Post1": "nostrum",
      "Post2": "consectetur",
      "Post3": "atque",
      "EmailName": "jaren@boyer.info",
      "ContactFullName": "Katarina Bergstrom",
      "ActiveErpLinks": 680,
      "TicketPriorityId": 576,
      "SupportLanguageId": 401,
      "SupportAssociateId": 793,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": true,
  "ActiveInterests": 695,
  "GroupId": 878,
  "ActiveStatusMonitorId": 89,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 38,
  "DbiAgentId": 475,
  "DbiLastSyncronized": "2011-12-02T13:57:18.6065583+01:00",
  "DbiKey": "harum",
  "DbiLastModified": "2020-06-04T13:57:18.6065583+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 87,
  "ActiveErpLinks": 278,
  "BounceEmails": [
    "cletus_heidenreich@kessler.co.uk",
    "domingo_krajcik@kundelehner.co.uk"
  ],
  "Domains": [
    "enim",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Weldon Zieme",
    "SuperOffice:2": "Ben Torphy"
  },
  "ExtraFields": {
    "ExtraFields1": "quibusdam",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "tenetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 729
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```