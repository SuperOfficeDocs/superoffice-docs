---
uid: table-person
title: person table
description: Persons in a company or an organizations. All associates have a corresponding person record
so.generated: true
keywords:
  - "database"
  - "person"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# person Table (6)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|person\_id|Primary key|PK| |
|contact\_id|Owning contact ID|FK [contact](contact.md)| |
|rank|Display sort sequence for default sort order|UShort| |
|lastname|Last name|String(99)|&#x25CF;|
|firstname|First name|String(99)| |
|mrmrs|e.g. Mrs   sex_title|String(239)|&#x25CF;|
|title|Title|String(239)|&#x25CF;|
|text\_id|Info tab contents|FK [text](text.md)|&#x25CF;|
|position\_idx|Link to Position list|FK [perspos](perspos.md)|&#x25CF;|
|year\_of\_birth|Birth year (4 digit)|UShort|&#x25CF;|
|month\_of\_birth|Birth month|UShort|&#x25CF;|
|day\_of\_birth|Birth date (day of month)|UShort|&#x25CF;|
|phone\_present|flag to show there are phone registrations |UShort|&#x25CF;|
|userdef\_id|User defined table record 1|FK [udpersonsmall](udpersonsmall.md)|&#x25CF;|
|registered|Registered date|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated date|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|person\_number|Alphanumeric user field|String(49)|&#x25CF;|
|kanalname|Kana last name, used in Japanese versions only|String(99)|&#x25CF;|
|kanafname|Kana last name, used in Japanese versions only|String(99)|&#x25CF;|
|post1|Postal address, used in Japanese versions only|String(99)|&#x25CF;|
|post2|Postal address, used in Japanese versions only|String(99)|&#x25CF;|
|post3|Postal address, used in Japanese versions only|String(99)|&#x25CF;|
|usepersonaddress|If 1, use person&apos;s address for mailing instead of company address|UShort|&#x25CF;|
|middleName|Middle name or &apos;van&apos; etc.|String(99)|&#x25CF;|
|source|How did we get this person? For future integration needs|UShort|&#x25CF;|
|nomailing|Do not send DM&apos;s to this person|Bool|&#x25CF;|
|country\_id|Country|FK [country](country.md)| |
|userdef2\_id|User defined table record 2|FK [udpersonlarge](udpersonlarge.md)|&#x25CF;|
|retired|1 = the user is retired and should have no rights, not appear in lists, etc.|UShort|&#x25CF;|
|activeInterests|Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true|UShort|&#x25CF;|
|updatedCount|Number of times updated|UShort| |
|associate\_id|Our contact, if this is a B2C person, otherwise mirror of contact.assoc_id|Id|&#x25CF;|
|group\_id|Our contact&apos;s original group, if this is a B2C person, otherwise mirror of contact.group_id|Id|&#x25CF;|
|salutation|Academic title, populated from Salutation list but can be overwritten with anything at all|String(239)|&#x25CF;|
|department|Internal department address|String(254)|&#x25CF;|
|initials|Where Pierre van Mever becomes P. van Mever.  Actually, initials to be used in formal addresses, mostly in the Ducth market|String(63)|&#x25CF;|
|gender|Male/female. No jokes please.  To be used for selecting correct salutations &amp; grammar. 0 = unknown, 1 = female, 2 = male|Enum [persongender](enums/persongender.md)|&#x25CF;|
|business\_idx|Business if this is a B2C person, otherwise mirror of contact.business_idx|FK [business](business.md)| |
|category\_idx|Category if this is a B2C person, otherwise mirror of contact.category_idx|FK [category](category.md)| |
|tzLocationId|Default timezone location for this person|FK [tzlocation](tzlocation.md)|&#x25CF;|
|sentInfo|Has information on username/password been sent (ejournal)|UShort|&#x25CF;|
|showContactTickets|Should tickets related to the company be shown to this person|UShort|&#x25CF;|
|ticketPriorityId|Default ticket priority for new tickets|FK [ticket-priority](ticket-priority.md)|&#x25CF;|
|supportLanguageId|Customers language (does not necessarily map to ISO languages)|FK [cust-lang](cust-lang.md)|&#x25CF;|
|supportAssociateId|Our contact, but for support context, not sales/primary contact|FK [associate](associate.md)|&#x25CF;|
|dbi\_agent\_id|Integration agent (eJournal)|FK [dbi-agent](dbi-agent.md)|&#x25CF;|
|dbi\_key|The primary key for the integrated entry in the external datasource.|String(255)|&#x25CF;|
|dbi\_last\_syncronized|Last external syncronization.|DateTime|&#x25CF;|
|dbi\_last\_modified|When the entry was last modified.|DateTime|&#x25CF;|
|blockEmarketing|Do not send E-marketing materials to this person|Bool|&#x25CF;|
|activeErpLinks|The number of Erp Sync connections this record is synced with; count of the ErpExternalKey+ErpInternalKey relations|Int|&#x25CF;|
|DeletedDate|Datetime (utc) when this record was soft-deleted; if this value is set then the record should not be shown|UtcDateTime|&#x25CF;|


![person table relationship diagram](./media/person.png)

[!include[details](./includes/person.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|person\_id |PK |Clustered, Unique |
|contact\_id |FK |Index |
|lastname |String(99) |Index |
|firstname |String(99) |Index |
|userdef\_id |FK |Index |
|person\_number |String(49) |Index |
|kanalname |String(99) |Index |
|kanafname |String(99) |Index |
|source |UShort |Index |
|userdef2\_id |FK |Index |
|business\_idx |FK |Index |
|category\_idx |FK |Index |
|dbi\_agent\_id |FK |Index |
|dbi\_key |String(255) |Index |
|dbi\_last\_syncronized |DateTime |Index |
|dbi\_last\_modified |DateTime |Index |
|contact\_id, rank |FK, UShort |Index |
|middleName |String(99) |Index |
|DeletedDate |UtcDateTime |Index |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.
* Cache table during filtering.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix.

