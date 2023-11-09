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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 289,
  "Name": "Kassulke Group",
  "Department": "",
  "OrgNr": "1039316",
  "Number1": "1242847",
  "Number2": "1108360",
  "UpdatedDate": "2016-10-16T11:06:34.0964784+02:00",
  "CreatedDate": "2016-02-10T11:06:34.0964784+01:00",
  "Emails": [
    {
      "Value": "sapiente",
      "StrippedValue": "esse",
      "Description": "Centralized coherent capacity"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "esse",
      "Description": "Centralized coherent capacity"
    }
  ],
  "Interests": [
    {
      "Id": 508,
      "Name": "Hand, Halvorson and Ankunding",
      "ToolTip": "Quia eum.",
      "Deleted": false,
      "Rank": 728,
      "Type": "et",
      "ColorBlock": 241,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2016-06-30T11:06:34.1121029+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Torey Labadie"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Operative tangible benchmark"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Operative tangible benchmark"
    }
  ],
  "Phones": [
    {
      "Value": "incidunt",
      "StrippedValue": "ex",
      "Description": "Business-focused impactful capacity"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "ex",
      "Description": "Business-focused impactful capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "incidunt",
      "Description": "Ergonomic clear-thinking conglomeration"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "incidunt",
      "Description": "Ergonomic clear-thinking conglomeration"
    }
  ],
  "Description": "Realigned neutral firmware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eos",
      "PersonId": 726,
      "Mrmrs": "quo",
      "Firstname": "Gillian",
      "Lastname": "Witting",
      "MiddleName": "Blanda LLC",
      "Title": "itaque",
      "Description": "Future-proofed explicit pricing structure",
      "Email": "jorge.runolfsdottir@hermiston.ca",
      "FullName": "Diana D'Amore",
      "DirectPhone": "088.745.9379",
      "FormalName": "Klein Group",
      "CountryId": 209,
      "ContactId": 397,
      "ContactName": "Schimmel, Beatty and Ankunding",
      "Retired": 205,
      "Rank": 645,
      "ActiveInterests": 808,
      "ContactDepartment": "",
      "ContactCountryId": 167,
      "ContactOrgNr": "209848",
      "FaxPhone": "621.340.2260 x7013",
      "MobilePhone": "820.377.8051 x5493",
      "ContactPhone": "215-415-8614",
      "AssociateName": "Price Inc and Sons",
      "AssociateId": 631,
      "UsePersonAddress": true,
      "ContactFax": "veritatis",
      "Kanafname": "quasi",
      "Kanalname": "aut",
      "Post1": "qui",
      "Post2": "doloremque",
      "Post3": "at",
      "EmailName": "lawson@klockohuel.ca",
      "ContactFullName": "Mrs. Jaquan Georgianna Kris I",
      "ActiveErpLinks": 726,
      "TicketPriorityId": 239,
      "SupportLanguageId": 565,
      "SupportAssociateId": 987,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "non",
  "Xstop": false,
  "ActiveInterests": 855,
  "GroupId": 910,
  "ActiveStatusMonitorId": 37,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 705,
  "DbiAgentId": 44,
  "DbiLastSyncronized": "2014-03-29T11:06:34.1121029+01:00",
  "DbiKey": "iste",
  "DbiLastModified": "2018-02-14T11:06:34.1121029+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 966,
  "ActiveErpLinks": 967,
  "BounceEmails": [
    "general@altenwerthspinka.name",
    "steve_skiles@cummings.ca"
  ],
  "Domains": [
    "ipsam",
    "architecto"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Clifton Kilback",
    "SuperOffice:2": "Alana Green"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "vel"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 581,
  "Name": "Vandervort-Runolfsdottir",
  "Department": "",
  "OrgNr": "879260",
  "Number1": "1655253",
  "Number2": "867610",
  "UpdatedDate": "2015-11-27T11:06:34.1121029+01:00",
  "CreatedDate": "2007-10-30T11:06:34.1121029+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Expanded background middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Expanded background middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 191,
      "Name": "Cartwright-Rutherford",
      "ToolTip": "Porro hic accusamus est.",
      "Deleted": true,
      "Rank": 815,
      "Type": "dicta",
      "ColorBlock": 26,
      "IconHint": "tempora",
      "Selected": false,
      "LastChanged": "2014-05-13T11:06:34.1121029+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Viva Bergnaum",
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
      "Value": "harum",
      "StrippedValue": "repudiandae",
      "Description": "Realigned zero tolerance synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "repudiandae",
      "Description": "Realigned zero tolerance synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "hic",
      "Description": "Fundamental holistic structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "hic",
      "Description": "Fundamental holistic structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "nisi",
      "Description": "Multi-channelled national Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nisi",
      "Description": "Multi-channelled national Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "Description": "Secured client-server hierarchy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 537,
      "Mrmrs": "omnis",
      "Firstname": "Odie",
      "Lastname": "Pfannerstill",
      "MiddleName": "D'Amore Inc and Sons",
      "Title": "vel",
      "Description": "Upgradable multi-tasking encryption",
      "Email": "ewell@towne.biz",
      "FullName": "Deron Metz",
      "DirectPhone": "(567)846-3208 x2412",
      "FormalName": "Hammes Group",
      "CountryId": 626,
      "ContactId": 799,
      "ContactName": "Pollich, Walker and Lang",
      "Retired": 160,
      "Rank": 871,
      "ActiveInterests": 715,
      "ContactDepartment": "",
      "ContactCountryId": 84,
      "ContactOrgNr": "841169",
      "FaxPhone": "238-075-4246 x14024",
      "MobilePhone": "316.402.5657",
      "ContactPhone": "455.240.2617",
      "AssociateName": "Douglas, Green and Kuvalis",
      "AssociateId": 689,
      "UsePersonAddress": false,
      "ContactFax": "accusamus",
      "Kanafname": "et",
      "Kanalname": "impedit",
      "Post1": "et",
      "Post2": "minima",
      "Post3": "asperiores",
      "EmailName": "richmond.weimann@powlowskikuphal.info",
      "ContactFullName": "Mrs. Bruce Connelly",
      "ActiveErpLinks": 751,
      "TicketPriorityId": 413,
      "SupportLanguageId": 874,
      "SupportAssociateId": 681,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aliquam",
  "Xstop": true,
  "ActiveInterests": 716,
  "GroupId": 985,
  "ActiveStatusMonitorId": 104,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 817,
  "DbiAgentId": 307,
  "DbiLastSyncronized": "2008-02-24T11:06:34.1121029+01:00",
  "DbiKey": "tenetur",
  "DbiLastModified": "1998-05-27T11:06:34.1121029+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 982,
  "ActiveErpLinks": 353,
  "BounceEmails": [
    "alta.dickens@cormier.co.uk",
    "garrett@webermaggio.com"
  ],
  "Domains": [
    "maiores",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Kennedy Dare",
    "SuperOffice:2": "Mrs. Brad Wisoky DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "maxime",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 229
    }
  }
}
```