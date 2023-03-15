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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 822,
  "Name": "Mertz, Ortiz and Hamill",
  "Department": "",
  "OrgNr": "788226",
  "Number1": "1003998",
  "Number2": "979024",
  "UpdatedDate": "2010-10-04T12:15:18.4557611+02:00",
  "CreatedDate": "2012-03-29T12:15:18.4557611+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "reprehenderit",
      "Description": "Object-based 6th generation product"
    },
    {
      "Value": "qui",
      "StrippedValue": "reprehenderit",
      "Description": "Object-based 6th generation product"
    }
  ],
  "Interests": [
    {
      "Id": 557,
      "Name": "Wisozk, Bogan and McLaughlin",
      "ToolTip": "Non doloribus dolorem et sint deleniti praesentium qui.",
      "Deleted": false,
      "Rank": 75,
      "Type": "eius",
      "ColorBlock": 553,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2001-05-22T12:15:18.4567593+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Stevie Hills"
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "suscipit",
      "Description": "Operative dedicated project"
    },
    {
      "Value": "enim",
      "StrippedValue": "suscipit",
      "Description": "Operative dedicated project"
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "laudantium",
      "Description": "Centralized demand-driven adapter"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "laudantium",
      "Description": "Centralized demand-driven adapter"
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "voluptatum",
      "Description": "Object-based coherent contingency"
    },
    {
      "Value": "eaque",
      "StrippedValue": "voluptatum",
      "Description": "Object-based coherent contingency"
    }
  ],
  "Description": "Stand-alone mobile support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 44,
      "Mrmrs": "quia",
      "Firstname": "Taurean",
      "Lastname": "Schuster",
      "MiddleName": "Schulist LLC",
      "Title": "dicta",
      "Description": "Programmable multi-state website",
      "Email": "juvenal@crooks.info",
      "FullName": "Ms. Bridie Mauricio Mills II",
      "DirectPhone": "1-266-776-0215 x92694",
      "FormalName": "Hayes-Wuckert",
      "CountryId": 137,
      "ContactId": 310,
      "ContactName": "O'Hara, Kertzmann and Schuppe",
      "Retired": 434,
      "Rank": 93,
      "ActiveInterests": 940,
      "ContactDepartment": "",
      "ContactCountryId": 289,
      "ContactOrgNr": "1567521",
      "FaxPhone": "(390)009-6488",
      "MobilePhone": "1-173-946-1056 x279",
      "ContactPhone": "(780)279-5851 x474",
      "AssociateName": "Olson-Graham",
      "AssociateId": 573,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "modi",
      "Kanalname": "numquam",
      "Post1": "et",
      "Post2": "illum",
      "Post3": "voluptatem",
      "EmailName": "lily@okonkunde.ca",
      "ContactFullName": "Miss Jaquan Dicki",
      "ActiveErpLinks": 222,
      "TicketPriorityId": 601,
      "SupportLanguageId": 263,
      "SupportAssociateId": 887,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "eius",
  "Xstop": false,
  "ActiveInterests": 910,
  "GroupId": 938,
  "ActiveStatusMonitorId": 28,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 627,
  "DbiAgentId": 870,
  "DbiLastSyncronized": "2001-02-05T12:15:18.4607643+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2007-09-28T12:15:18.4607643+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 712,
  "ActiveErpLinks": 690,
  "BounceEmails": [
    "reece@pacocha.com",
    "kaia@mayert.name"
  ],
  "Domains": [
    "praesentium",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Tess Koelpin",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "sit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 568,
  "Name": "Cormier, Klocko and Durgan",
  "Department": "",
  "OrgNr": "789052",
  "Number1": "1288874",
  "Number2": "1145138",
  "UpdatedDate": "1999-02-20T12:15:18.4697589+01:00",
  "CreatedDate": "1997-05-19T12:15:18.4697589+02:00",
  "Emails": [
    {
      "Value": "veniam",
      "StrippedValue": "sint",
      "Description": "Front-line reciprocal help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "sint",
      "Description": "Front-line reciprocal help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 916,
      "Name": "Greenfelder-Cormier",
      "ToolTip": "Numquam repellat aliquam a dolore similique.",
      "Deleted": true,
      "Rank": 612,
      "Type": "similique",
      "ColorBlock": 723,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "1998-12-06T12:15:18.4707589+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cum",
      "StyleHint": "libero",
      "Hidden": true,
      "FullName": "Filiberto Terry",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 827
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "facilis",
      "Description": "Exclusive global migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 293
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "facilis",
      "Description": "Exclusive global migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 293
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "ut",
      "Description": "Centralized exuding time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "ut",
      "Description": "Centralized exuding time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Profit-focused web-enabled flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 496
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Profit-focused web-enabled flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 496
        }
      }
    }
  ],
  "Description": "Pre-emptive explicit groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "incidunt",
      "PersonId": 813,
      "Mrmrs": "minima",
      "Firstname": "Ethyl",
      "Lastname": "Ortiz",
      "MiddleName": "Cremin LLC",
      "Title": "fugiat",
      "Description": "Innovative web-enabled support",
      "Email": "deja@gaylord.info",
      "FullName": "Ona Dach MD",
      "DirectPhone": "412-804-8491",
      "FormalName": "Goyette, Willms and Little",
      "CountryId": 981,
      "ContactId": 130,
      "ContactName": "Moen, Von and Parisian",
      "Retired": 80,
      "Rank": 470,
      "ActiveInterests": 555,
      "ContactDepartment": "",
      "ContactCountryId": 562,
      "ContactOrgNr": "721694",
      "FaxPhone": "221-684-4094",
      "MobilePhone": "005-143-0459",
      "ContactPhone": "(603)966-8314 x75094",
      "AssociateName": "Harris Group",
      "AssociateId": 713,
      "UsePersonAddress": false,
      "ContactFax": "provident",
      "Kanafname": "explicabo",
      "Kanalname": "sunt",
      "Post1": "et",
      "Post2": "est",
      "Post3": "ut",
      "EmailName": "newell.ward@hoeger.us",
      "ContactFullName": "Golda Robel",
      "ActiveErpLinks": 355,
      "TicketPriorityId": 373,
      "SupportLanguageId": 780,
      "SupportAssociateId": 680,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 947
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "iure",
  "Xstop": true,
  "ActiveInterests": 226,
  "GroupId": 415,
  "ActiveStatusMonitorId": 876,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 578,
  "DbiAgentId": 751,
  "DbiLastSyncronized": "2012-10-28T12:15:18.4747625+01:00",
  "DbiKey": "saepe",
  "DbiLastModified": "2022-09-24T12:15:18.4747625+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 807,
  "ActiveErpLinks": 311,
  "BounceEmails": [
    "geovanni@murray.biz",
    "jordyn@jones.biz"
  ],
  "Domains": [
    "aut",
    "provident"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "294074484",
    "SuperOffice:2": "Dr. Otis Gabriella Runte DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "ducimus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 133
    }
  }
}
```