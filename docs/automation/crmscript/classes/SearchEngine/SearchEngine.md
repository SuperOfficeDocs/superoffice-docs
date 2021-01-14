---
title: SearchEngine
path: /EJScript/Classes/SearchEngine
intellisense: 1
classref: 1
---

The SearchEngine is originally made for searching and fetching data from the eJournal database. Thereby its name.
Has later been extended with features for inserting and updating rows.
The SearchEngine is a tool for building up sql-queries, by adding fields, criteria and data.

###The fields must be given on the following form:###
starttablename.fieldname, for example "ticket.title"


###For tables that have foreign keys to other tables, you can reach them with the following notation:###
starttablename.fieldname.fieldname


###For example the firstname of the primary customer of a ticket is:###
"ticket.cust\_id.firstname".


###The company name of the primary customer of a ticket is:###
"ticket.cust\_id.company.name".

Make sure that all fields you use start with the same table, for example ticket, or else you will recieve a big join that you probably do not want.

For many-to-many relations there is a special notation:
table1.(table2->field2a).field2b Where field2a is field in table2 that has a foreign key to table1.



###An example:###
    "ticket.(ticket_customers->ticket_id).cust_id"
    

From CS version 7, the aggregate functions are no longer supported, since the query is sent to NetServer instead of directly to the database.
It is possible to circumvent this by setting the reg\_id 235 to 1 and explicitly use `bypassNetserver(true)` in the searchengine. Be aware of any security implications this might cause.




1. autolist

