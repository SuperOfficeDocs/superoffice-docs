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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
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
  "ContactId": 595,
  "Name": "Bashirian-Schowalter",
  "Department": "",
  "OrgNr": "569507",
  "Number1": "315848",
  "Number2": "1557881",
  "UpdatedDate": "2016-04-20T02:49:50.7452861+02:00",
  "CreatedDate": "2021-01-05T02:49:50.7452861+01:00",
  "Emails": [
    {
      "Value": "quasi",
      "StrippedValue": "dolorum",
      "Description": "Synergized foreground approach"
    },
    {
      "Value": "quasi",
      "StrippedValue": "dolorum",
      "Description": "Synergized foreground approach"
    }
  ],
  "Interests": [
    {
      "Id": 612,
      "Name": "Stokes, Weimann and Flatley",
      "ToolTip": "Quos dicta.",
      "Deleted": false,
      "Rank": 561,
      "Type": "in",
      "ColorBlock": 504,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2002-07-10T02:49:50.7452861+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "molestias",
      "Hidden": false,
      "FullName": "Mrs. Colt Estefania Ullrich"
    }
  ],
  "Urls": [
    {
      "Value": "consectetur",
      "StrippedValue": "omnis",
      "Description": "Re-contextualized responsive leverage"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "omnis",
      "Description": "Re-contextualized responsive leverage"
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "beatae",
      "Description": "Innovative grid-enabled architecture"
    },
    {
      "Value": "non",
      "StrippedValue": "beatae",
      "Description": "Innovative grid-enabled architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "blanditiis",
      "StrippedValue": "provident",
      "Description": "Multi-layered motivating implementation"
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "provident",
      "Description": "Multi-layered motivating implementation"
    }
  ],
  "Description": "Virtual actuating artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nobis",
      "PersonId": 532,
      "Mrmrs": "et",
      "Firstname": "Gunner",
      "Lastname": "Hessel",
      "MiddleName": "Heidenreich Inc and Sons",
      "Title": "ut",
      "Description": "Universal global utilisation",
      "Email": "isaiah.quigley@schowalter.com",
      "FullName": "Prof. Mathias Will V",
      "DirectPhone": "600-447-3476 x83210",
      "FormalName": "Johnson-Okuneva",
      "CountryId": 18,
      "ContactId": 336,
      "ContactName": "Fisher-Ernser",
      "Retired": 55,
      "Rank": 886,
      "ActiveInterests": 981,
      "ContactDepartment": "",
      "ContactCountryId": 376,
      "ContactOrgNr": "1103436",
      "FaxPhone": "110-509-1458",
      "MobilePhone": "1-196-554-7925 x27239",
      "ContactPhone": "736-008-2079",
      "AssociateName": "Wolf, Ernser and Schaden",
      "AssociateId": 528,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "dolorem",
      "Kanalname": "delectus",
      "Post1": "veniam",
      "Post2": "accusamus",
      "Post3": "delectus",
      "EmailName": "tod@bayerbashirian.ca",
      "ContactFullName": "Della Kozey",
      "ActiveErpLinks": 213,
      "TicketPriorityId": 180,
      "SupportLanguageId": 191,
      "SupportAssociateId": 846,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 233,
  "GroupId": 811,
  "ActiveStatusMonitorId": 558,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 939,
  "DbiAgentId": 736,
  "DbiLastSyncronized": "2011-10-28T02:49:50.7452861+02:00",
  "DbiKey": "dolore",
  "DbiLastModified": "2022-08-24T02:49:50.7452861+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 101,
  "ActiveErpLinks": 610,
  "BounceEmails": [
    "earline@mayert.ca",
    "jennings@champlin.us"
  ],
  "Domains": [
    "omnis",
    "omnis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Tressie Simonis I",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "temporibus"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "tempore"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 23,
  "Name": "Wiegand-Legros",
  "Department": "",
  "OrgNr": "845361",
  "Number1": "709982",
  "Number2": "1393373",
  "UpdatedDate": "2019-03-25T02:49:50.7609112+01:00",
  "CreatedDate": "2000-01-03T02:49:50.7609112+01:00",
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "alias",
      "Description": "Cloned reciprocal attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "alias",
      "Description": "Cloned reciprocal attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 477,
      "Name": "Heathcote-Cummings",
      "ToolTip": "Consequatur neque error distinctio totam.",
      "Deleted": false,
      "Rank": 85,
      "Type": "molestias",
      "ColorBlock": 839,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "2020-04-15T02:49:50.7609112+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "porro",
      "StyleHint": "doloribus",
      "Hidden": false,
      "FullName": "Tod Hand",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 51
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "odit",
      "Description": "Devolved modular workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "odit",
      "Description": "Devolved modular workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ex",
      "StrippedValue": "consequatur",
      "Description": "Managed intermediate groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "consequatur",
      "Description": "Managed intermediate groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "saepe",
      "Description": "Multi-layered dynamic knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "saepe",
      "Description": "Multi-layered dynamic knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 370
        }
      }
    }
  ],
  "Description": "Total responsive knowledge base",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "perferendis",
      "PersonId": 79,
      "Mrmrs": "officiis",
      "Firstname": "Aurelia",
      "Lastname": "Brakus",
      "MiddleName": "Gulgowski, Collier and Gerhold",
      "Title": "dolor",
      "Description": "Virtual actuating support",
      "Email": "donald@wuckertstehr.biz",
      "FullName": "Eleonore Braun Jr.",
      "DirectPhone": "337-607-3547",
      "FormalName": "Fadel LLC",
      "CountryId": 561,
      "ContactId": 237,
      "ContactName": "Schaefer-Streich",
      "Retired": 540,
      "Rank": 396,
      "ActiveInterests": 846,
      "ContactDepartment": "",
      "ContactCountryId": 594,
      "ContactOrgNr": "885006",
      "FaxPhone": "1-665-473-0040",
      "MobilePhone": "(979)903-6560",
      "ContactPhone": "791.375.9848 x347",
      "AssociateName": "Pouros LLC",
      "AssociateId": 290,
      "UsePersonAddress": true,
      "ContactFax": "nobis",
      "Kanafname": "officia",
      "Kanalname": "eaque",
      "Post1": "consequatur",
      "Post2": "quos",
      "Post3": "velit",
      "EmailName": "heloise.lang@kuphaldonnelly.info",
      "ContactFullName": "Trent Treutel",
      "ActiveErpLinks": 794,
      "TicketPriorityId": 898,
      "SupportLanguageId": 553,
      "SupportAssociateId": 808,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 227
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "adipisci",
  "Xstop": true,
  "ActiveInterests": 257,
  "GroupId": 897,
  "ActiveStatusMonitorId": 25,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 339,
  "DbiAgentId": 443,
  "DbiLastSyncronized": "1997-03-22T02:49:50.7609112+01:00",
  "DbiKey": "unde",
  "DbiLastModified": "1998-09-01T02:49:50.7609112+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 354,
  "ActiveErpLinks": 661,
  "BounceEmails": [
    "carleton.king@wuckertkemmer.info",
    "bruce_kovacek@balistreri.ca"
  ],
  "Domains": [
    "velit",
    "perferendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1191442240",
    "SuperOffice:2": "Miss Della Mackenzie Kuvalis"
  },
  "ExtraFields": {
    "ExtraFields1": "deleniti",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "corporis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 894
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```