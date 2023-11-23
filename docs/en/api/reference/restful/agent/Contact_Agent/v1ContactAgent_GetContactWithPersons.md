---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 48
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 758,
  "Name": "Lubowitz, Hand and Kertzmann",
  "Department": "",
  "OrgNr": "1795433",
  "Number1": "928696",
  "Number2": "1152087",
  "UpdatedDate": "2018-06-09T13:38:13.3115228+02:00",
  "CreatedDate": "2021-01-26T13:38:13.3115228+01:00",
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "corporis",
      "Description": "Distributed assymetric superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 429
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "corporis",
      "Description": "Distributed assymetric superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 429
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 480,
      "Name": "O'Keefe, Langworth and Moore",
      "ToolTip": "Neque accusantium culpa.",
      "Deleted": false,
      "Rank": 230,
      "Type": "esse",
      "ColorBlock": 51,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2003-05-23T13:38:13.3115228+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "a",
      "StyleHint": "quisquam",
      "Hidden": true,
      "FullName": "Rhiannon Brandt Schaefer IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "libero",
      "StrippedValue": "molestiae",
      "Description": "Assimilated optimizing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "molestiae",
      "Description": "Assimilated optimizing monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "blanditiis",
      "Description": "Mandatory 5th generation hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "blanditiis",
      "Description": "Mandatory 5th generation hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 423
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "saepe",
      "Description": "Down-sized multi-tasking matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "saepe",
      "Description": "Down-sized multi-tasking matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    }
  ],
  "Description": "Persevering content-based initiative",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "error",
      "PersonId": 778,
      "Mrmrs": "non",
      "Firstname": "Bridie",
      "Lastname": "Leffler",
      "MiddleName": "Bashirian, Goodwin and Ernser",
      "Title": "accusamus",
      "Description": "Enhanced regional archive",
      "Email": "waino@wisozk.ca",
      "FullName": "Hector Dibbert",
      "DirectPhone": "1-514-451-1561",
      "FormalName": "Tromp Inc and Sons",
      "CountryId": 358,
      "ContactId": 721,
      "ContactName": "Crooks Group",
      "Retired": 477,
      "Rank": 31,
      "ActiveInterests": 16,
      "ContactDepartment": "",
      "ContactCountryId": 42,
      "ContactOrgNr": "473160",
      "FaxPhone": "(883)857-9310",
      "MobilePhone": "189-520-4536",
      "ContactPhone": "054.184.2296",
      "AssociateName": "Kerluke-Bins",
      "AssociateId": 870,
      "UsePersonAddress": true,
      "ContactFax": "sunt",
      "Kanafname": "corrupti",
      "Kanalname": "sint",
      "Post1": "sapiente",
      "Post2": "ut",
      "Post3": "itaque",
      "EmailName": "jaida.dickens@vandervortjaskolski.info",
      "ContactFullName": "Brannon Nathanael Cassin PhD",
      "ActiveErpLinks": 155,
      "TicketPriorityId": 200,
      "SupportLanguageId": 283,
      "SupportAssociateId": 934,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "impedit",
  "Xstop": true,
  "ActiveInterests": 848,
  "GroupId": 661,
  "ActiveStatusMonitorId": 307,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 740,
  "DbiAgentId": 122,
  "DbiLastSyncronized": "2020-12-30T13:38:13.3115228+01:00",
  "DbiKey": "et",
  "DbiLastModified": "2000-05-22T13:38:13.3115228+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 448,
  "ActiveErpLinks": 72,
  "BounceEmails": [
    "scarlett@cole.biz",
    "june@huel.ca"
  ],
  "Domains": [
    "mollitia",
    "incidunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Marjolaine Carroll Prosacco PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "laudantium",
    "CustomFields2": "dolorum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 65
    }
  }
}
```