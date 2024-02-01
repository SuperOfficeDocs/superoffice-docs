---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 185,
  "Name": "Larkin LLC",
  "Department": "",
  "OrgNr": "1713230",
  "Number1": "1012838",
  "Number2": "954652",
  "UpdatedDate": "2010-02-12T23:03:55.353138+01:00",
  "CreatedDate": "2021-07-14T23:03:55.353138+02:00",
  "Emails": [
    {
      "Value": "suscipit",
      "StrippedValue": "sit",
      "Description": "Decentralized dynamic throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "sit",
      "Description": "Decentralized dynamic throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 708,
      "Name": "Kertzmann, Toy and Tromp",
      "ToolTip": "Est non.",
      "Deleted": false,
      "Rank": 83,
      "Type": "voluptatem",
      "ColorBlock": 259,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2004-02-27T23:03:55.353138+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Keyon Alysha Lueilwitz I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "consectetur",
      "Description": "Robust exuding data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "consectetur",
      "Description": "Robust exuding data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "omnis",
      "StrippedValue": "ea",
      "Description": "Extended bandwidth-monitored workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ea",
      "Description": "Extended bandwidth-monitored workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "enim",
      "StrippedValue": "vero",
      "Description": "Profound national internet solution",
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
      "Value": "enim",
      "StrippedValue": "vero",
      "Description": "Profound national internet solution",
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
  "Description": "Cloned user-facing internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "facere",
      "PersonId": 569,
      "Mrmrs": "exercitationem",
      "Firstname": "Octavia",
      "Lastname": "Collins",
      "MiddleName": "Dickens, Miller and Quitzon",
      "Title": "atque",
      "Description": "Reactive human-resource customer loyalty",
      "Email": "leone@schumm.name",
      "FullName": "Owen Torp",
      "DirectPhone": "624.550.9032",
      "FormalName": "Maggio Inc and Sons",
      "CountryId": 894,
      "ContactId": 162,
      "ContactName": "Carroll Inc and Sons",
      "Retired": 438,
      "Rank": 619,
      "ActiveInterests": 590,
      "ContactDepartment": "",
      "ContactCountryId": 571,
      "ContactOrgNr": "414927",
      "FaxPhone": "1-213-245-3651 x9423",
      "MobilePhone": "1-439-843-1097 x708",
      "ContactPhone": "1-485-724-3549 x5318",
      "AssociateName": "Fahey-Kovacek",
      "AssociateId": 918,
      "UsePersonAddress": false,
      "ContactFax": "eos",
      "Kanafname": "tempore",
      "Kanalname": "vitae",
      "Post1": "fuga",
      "Post2": "qui",
      "Post3": "architecto",
      "EmailName": "brigitte.emard@pfeffer.info",
      "ContactFullName": "Petra Runte V",
      "ActiveErpLinks": 548,
      "TicketPriorityId": 771,
      "SupportLanguageId": 631,
      "SupportAssociateId": 645,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "unde",
  "Xstop": true,
  "ActiveInterests": 921,
  "GroupId": 834,
  "ActiveStatusMonitorId": 956,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 138,
  "DbiAgentId": 302,
  "DbiLastSyncronized": "2001-10-18T23:03:55.3576372+02:00",
  "DbiKey": "quam",
  "DbiLastModified": "1997-01-02T23:03:55.3576372+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 58,
  "ActiveErpLinks": 25,
  "BounceEmails": [
    "connie.donnelly@waterspadberg.us",
    "amanda@rolfson.info"
  ],
  "Domains": [
    "illum",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Maci Murphy Rogahn DDS",
    "SuperOffice:2": "Natalia Wuckert"
  },
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "distinctio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 64
    }
  }
}
```