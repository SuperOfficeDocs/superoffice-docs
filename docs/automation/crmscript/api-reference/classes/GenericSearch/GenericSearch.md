---
uid: crmscript_ref_GenericSearch
title: GenericSearch
intellisense: Void.GenericSearch
sortOrder: 361
so.topic: reference
---

# GenericSearch

This class is obsolete.
Use SearchEngine instead.

Class for representing a generic database search.

The genericSearch is originally made for searching and fetching data from the
eJournal database. Thereby its name.
GenericSearch is a tool for building up sql-queries, by adding fields and criterias.

The fields must be given on the following form:

starttablename.fieldname, for example "ticket.title"
For tables that have foreign keys to other tables, you can reach them with the
following notation:
starttablename.fieldname.fieldname

For example the firstname of the primary customer of a ticket is:

"ticket.cust\_id.firstname".

The company name of the primary customer of a ticket is:

"ticket.cust\_id.company.name".

Make sure that all fields you use start with the same table, for example
ticket, or else you will recieve a big join that you probably do not want.

For many-to-many relations there is a special notation:
table1.(table2->field2a).field2b Where field2a is field in table2 that has a
foreign key to table1.

## Example

    "ticket.(ticket_customers->ticket_id).cust_id"

GenericSearch extends theSearchEngine class with options for how to list fields. Displayfields, datafields, idfields.
GenericSearch has less functionality for adding criterias than SearcjEngine
