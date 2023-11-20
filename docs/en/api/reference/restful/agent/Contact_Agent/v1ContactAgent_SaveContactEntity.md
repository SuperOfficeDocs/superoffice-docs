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
  "ContactId": 984,
  "Name": "Keebler-Macejkovic",
  "Department": "",
  "OrgNr": "751585",
  "Number1": "1290152",
  "Number2": "1705267",
  "UpdatedDate": "2020-12-03T13:38:13.2802712+01:00",
  "CreatedDate": "2008-09-24T13:38:13.2802712+02:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "est",
      "Description": "Balanced zero defect groupware"
    },
    {
      "Value": "aut",
      "StrippedValue": "est",
      "Description": "Balanced zero defect groupware"
    }
  ],
  "Interests": [
    {
      "Id": 260,
      "Name": "Gibson LLC",
      "ToolTip": "Et illum dolores aliquid quae ipsa commodi iste.",
      "Deleted": false,
      "Rank": 521,
      "Type": "voluptatem",
      "ColorBlock": 209,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2012-04-25T13:38:13.2802712+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nisi",
      "StyleHint": "facere",
      "Hidden": false,
      "FullName": "Rozella Austin Cruickshank Sr."
    }
  ],
  "Urls": [
    {
      "Value": "perferendis",
      "StrippedValue": "sunt",
      "Description": "Intuitive holistic forecast"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "sunt",
      "Description": "Intuitive holistic forecast"
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "velit",
      "Description": "Streamlined coherent open architecture"
    },
    {
      "Value": "in",
      "StrippedValue": "velit",
      "Description": "Streamlined coherent open architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "deserunt",
      "StrippedValue": "reiciendis",
      "Description": "Down-sized executive service-desk"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "reiciendis",
      "Description": "Down-sized executive service-desk"
    }
  ],
  "Description": "Inverse optimizing function",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rem",
      "PersonId": 529,
      "Mrmrs": "explicabo",
      "Firstname": "Adeline",
      "Lastname": "Mertz",
      "MiddleName": "Ratke LLC",
      "Title": "aut",
      "Description": "Universal uniform capacity",
      "Email": "randy@jewess.com",
      "FullName": "Ms. Amaya Walsh DDS",
      "DirectPhone": "683-437-2536 x24058",
      "FormalName": "Schulist-Cummings",
      "CountryId": 539,
      "ContactId": 110,
      "ContactName": "Schuppe-Carter",
      "Retired": 125,
      "Rank": 314,
      "ActiveInterests": 137,
      "ContactDepartment": "",
      "ContactCountryId": 780,
      "ContactOrgNr": "1394693",
      "FaxPhone": "921-721-1169",
      "MobilePhone": "(050)058-6008 x82423",
      "ContactPhone": "735.088.8769 x76621",
      "AssociateName": "Simonis-Cartwright",
      "AssociateId": 830,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "provident",
      "Kanalname": "est",
      "Post1": "vero",
      "Post2": "nostrum",
      "Post3": "voluptas",
      "EmailName": "osbaldo_reynolds@krajcikbreitenberg.com",
      "ContactFullName": "Joanne O'Conner",
      "ActiveErpLinks": 610,
      "TicketPriorityId": 761,
      "SupportLanguageId": 152,
      "SupportAssociateId": 448,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "illo",
  "Xstop": false,
  "ActiveInterests": 368,
  "GroupId": 854,
  "ActiveStatusMonitorId": 917,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 642,
  "DbiAgentId": 702,
  "DbiLastSyncronized": "2016-02-14T13:38:13.2802712+01:00",
  "DbiKey": "ex",
  "DbiLastModified": "2017-08-24T13:38:13.2802712+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 523,
  "ActiveErpLinks": 210,
  "BounceEmails": [
    "gaston@homenick.info",
    "roscoe_towne@gutkowski.info"
  ],
  "Domains": [
    "aut",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "572718404",
    "SuperOffice:2": "Dr. Sheridan Billie Schiller Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "mollitia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 449,
  "Name": "Hintz Group",
  "Department": "",
  "OrgNr": "1377946",
  "Number1": "1189119",
  "Number2": "1802723",
  "UpdatedDate": "1998-03-16T13:38:13.2958954+01:00",
  "CreatedDate": "2023-01-12T13:38:13.2958954+01:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "ea",
      "Description": "Centralized content-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ea",
      "Description": "Centralized content-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 712,
      "Name": "Waelchi, Gibson and Kerluke",
      "ToolTip": "Vel perferendis eius sit voluptatem et.",
      "Deleted": false,
      "Rank": 907,
      "Type": "necessitatibus",
      "ColorBlock": 409,
      "IconHint": "labore",
      "Selected": false,
      "LastChanged": "2014-04-04T13:38:13.2958954+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "ipsum",
      "Hidden": true,
      "FullName": "Prof. Sonia Heloise Walsh",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 176
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rem",
      "StrippedValue": "quia",
      "Description": "Sharable next generation open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "quia",
      "Description": "Sharable next generation open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Business-focused client-driven infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Business-focused client-driven infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptates",
      "StrippedValue": "minima",
      "Description": "Pre-emptive motivating task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "minima",
      "Description": "Pre-emptive motivating task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "Description": "Universal multimedia protocol",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eum",
      "PersonId": 824,
      "Mrmrs": "sint",
      "Firstname": "Avis",
      "Lastname": "O'Kon",
      "MiddleName": "Mayer-Hodkiewicz",
      "Title": "dolores",
      "Description": "Profound systemic pricing structure",
      "Email": "charley.bergstrom@stanton.ca",
      "FullName": "Lillie Stark",
      "DirectPhone": "704.772.4956 x536",
      "FormalName": "Cummings Group",
      "CountryId": 976,
      "ContactId": 597,
      "ContactName": "Schroeder-Casper",
      "Retired": 713,
      "Rank": 521,
      "ActiveInterests": 523,
      "ContactDepartment": "",
      "ContactCountryId": 71,
      "ContactOrgNr": "1096631",
      "FaxPhone": "693-609-3745 x73082",
      "MobilePhone": "1-029-818-0949 x60544",
      "ContactPhone": "721.934.4814 x284",
      "AssociateName": "Paucek, Kessler and Kemmer",
      "AssociateId": 185,
      "UsePersonAddress": false,
      "ContactFax": "a",
      "Kanafname": "dignissimos",
      "Kanalname": "cum",
      "Post1": "quisquam",
      "Post2": "soluta",
      "Post3": "modi",
      "EmailName": "alisha.borer@schuppe.biz",
      "ContactFullName": "Dr. Lucile Robyn Howe",
      "ActiveErpLinks": 243,
      "TicketPriorityId": 658,
      "SupportLanguageId": 980,
      "SupportAssociateId": 429,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 10
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "natus",
  "Xstop": true,
  "ActiveInterests": 380,
  "GroupId": 216,
  "ActiveStatusMonitorId": 574,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 302,
  "DbiAgentId": 419,
  "DbiLastSyncronized": "2008-09-01T13:38:13.2958954+02:00",
  "DbiKey": "eveniet",
  "DbiLastModified": "1999-05-15T13:38:13.2958954+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 741,
  "ActiveErpLinks": 661,
  "BounceEmails": [
    "casey_jaskolski@johnston.uk",
    "clint@mertz.com"
  ],
  "Domains": [
    "minus",
    "recusandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 886
    }
  }
}
```