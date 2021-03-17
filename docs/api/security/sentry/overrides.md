---
title: sentry_overrides
description: Sentry overrides
author: {github-id}
so.date: 02.06.2007
keywords:
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Sentry overrides

The standard system consists of 6 user-levels, and each level has a set of access rights, which decrease from all rights on level 0 down to read-only on level 5. These rights apply universally to all tables and all records.

There are additional rules that restrict access to data, such as private appointments and contacts that own Satellites. All these rules are implemented by the **Sentry** system. The problem, then, comes down to the need to add an override function to the Sentry system so that external modules can in some way instruct the Sentry system to grant fewer rights than would otherwise be the case.

> [!NOTE]
> The override can only **remove** rights. You cannot use it to circumvent existing rules.

## Technical limitations

The override is implemented using the **preference system**, which takes care of **who** part of the problem (*who* is allowed to do *what* with *which* data). This imposes constraints on the granularity of the actual use – defining separate access rights for each field of each record for each user is theoretically possible, but should be avoided to maintain performance.

The override only applies to the SuperOffice GUI. It is not enforced by the OLE DB Provider and certainly not by direct ODBC access.

> [!NOTE]
> There may be combinations of rights that don't make sense or that render SuperOffice useless. There are no checks to ensure that overrides are not misused. There may also be instances where Sentry checks in the GUI are imperfect because we did not foresee that anyone would place restrictions on certain fields. Reports of such occurrences will be treated as "requests" rather than bugs.

## Override levels (**what** is allowed)

Overrides can be performed at 2 levels:

* Table level
* Field level

The **table** level controls whole-record operations, such as the right to insert new records, update existing records or delete records. By setting overrides at this level it is possible, for instance, to prevent a particular user from adding new contacts, even though he is otherwise a level 1 user.

At the **field** level, read and write accesses are controlled for individual fields. By removing the write access to a field, updates to this field will be blocked, even though the rest of the record remains updateable. If read access is removed from a field, the whole field (though not its label) will disappear from the GUI!

## Override granularity – functions (**which** data)

Overrides at each level (table or field) can be set for

* All records
* All existing records
* New records
* Any particular record, identified by its ID

For instance, supposing a certain field can be entered only when a record is created, such as the code field in the contact card. By setting an override for all existing records to remove the write access field, all users will be able to fill in the field on new contacts, but not change it later. In this case, it would be wise to include another override for one particular user or group of users to enable them to edit the field in case any mistakes are made.

By addressing single records, it is possible to protect data of particular value, such as a contact that "owns" the link to the accounting system, etc.

## Override granularity – users (**who** can do it)

Since overrides are specified via the preference system, they can be specified at any level of that system:

* System-wide, applies to the whole installation including travelers, satellites.
* Database, applies to the given database (satellite) only
* Group, applies to all users in a group
* Individual, applies to a single user

Preferences set at a level close to the user (such as group) will override preferences set at a high level (such as system-wide). The same applies to the sentry overrides. It is, therefore, possible to set a system-wide override that removes update rights from a certain field (from all users, since it is system-wide), and then override it with another setting for a single user (typically, the supervisor) to enable him to fix mistakes.

## Management GUI

There is no GUI to check or set preferences for sentry overrides. This has to be done directly though ISQL or the OLE DB Provider (the last is strongly recommended since all caches will be updated correctly). The lack of a GUI is intentional as this function is only intended for developers and consultants who know what they are doing and is too complicated and powerful to be let loose among normal users.

## Preference format - section names

Override preferences are organized into sections. The section name declares it is a right by specifying "Rights-" and then the main table name:

`Rights-`

The main table is the main table name (taken from the dictionary) of the main table for the intended sentry. An example would be "Rights-contact", without the quotes.

The section name, as given above, specifies that the override applies to **all** records in the given table, both new and existing. The section name can be qualified further by adding one of the following suffixes:

* `-New`
* `-Existing`
* `-<record ID>`

For example, "Rights-contact-New" would specify an override for new contact records, while "Rights-person-34" would specify a field-level override for record 34 of the person table.

> [!NOTE]
> The table name is case sensitive, so Rights-Contact-New will not work, but TableRight-contact-New will.

## Table rights

This section should contain a single preference, with the key "Rights" (again, no quotes in the database). The value of the preference should either be a number, or a number followed by a comma and some text. Examples:

`15`
`15, This record is protected against updates`

The text, if present, is used as an explanatory tooltip in the appropriate place in the GUI. The general rule is that you should supply a text, since the user may wonder why he is not allowed to perform an operation, especially if the protection applies to only one or a few records.

Possible rights flags (you can add the values to get the rights you want) are:

| Right | Value | Description |
|---|---|---|
| Select | 1 | |
| Update | 2 | |
| Insert | 4 | |
| Delete | 8 | |
| Filtered read | 16 | Gives advance warning that there are also field-level restrictions on reading |
| Filtered update | 32 | Gives advance warning that there are field-level restrictions on updates |
| UIHintMandatory | 64 | Field must no be blank |
| UIHintReadOnly | 128 | Field can only be read, not updated, in the user interface. |
| UIHints | 192 | Rights only applied in the user interface. These rights are treated as deny rights. |

The rights granted are given by the sum of the value set. If you set 0, no rights will be granted, which would be a bit drastic.

For example: Read-only access = 17  (1 + 16)

* If you remove Insert rights, the NEW button is disabled.
* If you remove Delete rights, the Delete option is disabled in the menu.
* If you remove Update rights, then the Edit button is disabled.

## Field rights

This section can contain one or more preferences. Each preference has a key of the form `<table>.<field>`, and a value formatted like the one for the Table rights (number, optionally followed by a comma and some text describing the reason for the override). `<table>` and `<field>` must be the names of either the main table or a valid sub-table, and a field within that table, for example:

```text
Section: Rights-contact-Existing
Key: email.address
Value: 1, E-mail addresses are automatically added by our global LDAP daemon
```

This would specify that the e-mail address field of existing contact records cannot be changed and produces text to be displayed as a tooltip over the field.

Possible rights flags:

```text
Read:  1
Write: 2
```

Removing the read right makes fields disappear from dialogs and go blank in lists.

## Tooltips

You can add an explanation to the changed access rights by adding a comma and the tooltip text to the preference.

## Examples

* [COM][1]
* [SQL][2]

<!-- Referenced links -->
[1]: com/set-override-com.md
[2]: sql/set-override-sql.md
