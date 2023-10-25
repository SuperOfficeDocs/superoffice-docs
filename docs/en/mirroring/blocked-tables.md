---
title: Database mirroring blocked tables
uid: mirroring_blocked_tables
description: Lists the tables that are not mirrored.
author: AnthonyYates
keywords: mirroring, blocked tables, database, schema
so.topic: reference
so.envir: cloud
so.client: online
---

# Blocked tables list

All tables, except those explicitly set as “blocked” below, will be mirrored. This means that new tables in new versions of SuperOffice, as well as any customer-defined tables made in the Service product, will automatically be added.

Note that customer-defined tables can be deleted. In beta, this is not propagated. In the released version deletions will be propagated; however it is possible to create, mirror, delete, recreate and mirror a table in such a way that the schema cannot be properly updated. If that happens then the mirror will drop the table entirely and request a full repopulation.

Tables not mirrored might have a reason specified in the "reason” field. This is to help us understand why the table is not mirrored. If you have a table that is not mirrored, and you think it should be, please contact us.

| Table                          | Reason |
|--------------------------------|--------|
| sequence                       | Internal primary-key counters, irrelevant and with extreme change volume       |
| activeuser                     | Not used in Online       |
| area                           | Part of Travel       |
| areauserassignment             | Part of Travel       |
| areauserinclusion              | Part of Travel       |
| audienceconfig                 | Part of Audience       |
| audiencelayout                 | Part of Audience       |
| audiencelayoutlink             | Part of Audience       |
| audiencevisibility             | Part of Audience       |
| batchtask                      | Internal, not user data       |
| batchtaskdefinition            | Internal, not user data       |
| cachetables                    | Internal, not user data       |
| cacheinvalidation              |        |
| cc_template                    |        |
| config                         | Internal, not user data       |
| configurablescreendelta        | Internal, not user data       |
| connectionconfigfield          | Internal, not user data       |
| countervalue                   | SAINT data, very large table       |
| credentials                    | Credential information       |
| cust_config                    |        |
| dashboard                      |        |
| dashboard_theme                |        |
| dashboard_tile                 |        |
| dashboard_tile_definition      |        |
| dashboard_tile_field           |        |
| dbi_agent                      | Not used in Online       |
| dbi_agent_field                | Not used in Online       |
| dbi_agent_schedule             | Not used in Online       |
| email_account                  | Private information       |
| email_folder                   | Private information       |
| service_auth                   |        |
| email_item                     | Private information       |
| email_attachment               | Private information       |
| erpsynclog                     | Configuration, not user data       |
| foreignapp                     | Internal, not user data       |
| foreigndevice                  | Internal, not user data       |
| foreignkey                     | Internal, not user data       |
| form_keys                      |        |
| freetextindex                  | Search index, high volume, internal       |
| freetextstopwords              | Search index, high volume, internal       |
| freetextwords                  | Search index, high volume, internal       |
| history                        | User state, internal       |
| importdefault                  | Internal configuration, not user data       |
| importfield                    | Internal configuration, not user data       |
| importobject                   | Internal configuration, not user data       |
| importrelation                 | Internal configuration, not user data       |
| item_config                    |        |
| inbox                          | Internal, not user data       |
| licenseassoclink               | Internal configuration, not user data       |
| licenssatllink                 | Internal configuration, not user data       |
| locking                        | Internal, not user data       |
| log_events                     |        |
| login                          | Internal session info, not user data. Sensitive.       |
| login_customer                 | Internal session info, not user data. Sensitive.       |
| kb_entry_words                 |        |
| mergemovelog                   | Internal operation tracking, not user data. Merge and Move operation consequences are mirrored       |
| message                        | Internal configuration, not user data       |
| messagehandler                 | Internal configuration, not user data       |
| modulelicense                  | Internal configuration, not user data       |
| moduleowner                    | Internal configuration, not user data       |
| notice_frame                   |        |
| notify                         |        |
| olefield                       | Internal configuration, not user data       |
| olefieldtext                   | Internal configuration, not user data       |
| olesubject                     | Internal configuration, not user data       |
| olesubjecttext                 | Internal configuration, not user data       |
| oleview                        | Internal configuration, not user data       |
| oleviewtext                    | Internal configuration, not user data       |
| outbox                         | Internal, not user data       |
| prefdesc                       | Internal configuration, not user data       |
| prefdescline                   | Internal configuration, not user data       |
| registry                       | Internal, not user data       |
| satellite                      | Part of travel       |
| script_run_trace               |        |
| searchcriteria                 | Internal configuration, not user data       |
| searchcriteriagroup            | Internal configuration, not user data       |
| searchcriterion                | Internal configuration, not user data       |
| searchcriterionvalue           | Internal configuration, not user data       |
| session_object                 | Internal, not user data       |
| sorcriteria                    | Internal configuration, not user data       |
| sorfct                         | Internal configuration, not user data       |
| sorfield                       | Internal configuration, not user data       |
| sorlabellayout                 | Internal configuration, not user data       |
| soroperators                   | Internal configuration, not user data       |
| sorpublish                     | Internal configuration, not user data       |
| sorpublishgrouplink            | Internal configuration, not user data       |
| sorsection                     | Internal configuration, not user data       |
| sortemplate                    | Internal configuration, not user data       |
| statusvalue                    | SAINT search data, very large table and large turnover       |
| superlistcolumnsize            | Internal configuration, not user data       |
| systemevent                    | Internal configuration, not user data       |
| taborder                       | Internal configuration, not user data       |
| ticket_log_action              |        |
| ticket_log_change              |        |
| timestamps                     | Internal configuration, not user data       |
| travelcurrent                  | Part of Travel       |
| travelgenerateddatabase        | Part of Travel       |
| travelgeneratedtransaction     | Part of Travel       |
| travelidmapping                | Part of Travel       |
| traveller                      | Part of Travel       |
| traveltransactionlog           | Part of Travel       |
| trayapp                        | Internal configuration, not user data       |
| udtempsmall                    | Temporary table for udef moves, not needed       |
| udtemplarge                    | Temporary table for udef moves, not needed       |
| usagestats                     |        |
| userpreference                 | Very high change volume and generally internal. Implement the OnReplicationCompleted method in IMirrorAdmin, and call PreferenceAgent on the customer site to obtain those preferences that are needed.       |
| user_attribute                 | Internal configuration, not user data       |
| user_candidate                 | Internal configuration, not user data       |
| webappusage                    | Internal configuration, not user data       |
| webhook                        | Internal configuration, not user data       |
| winpossize                     | Internal configuration, not user data       |
| word_relations                 | Internal configuration, not user data       |
