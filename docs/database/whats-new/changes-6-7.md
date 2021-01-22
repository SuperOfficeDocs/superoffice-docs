---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title | changes_6_to_7       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description | Table changes from SIX to Seven # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author | {github-id}             # Your GitHub alias.
keywords | database
so.topic | reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir | onsite           # cloud or onsite
# so.client |                    # online, web, win, pocket, or mobile
---

# Table changes from SIX to Seven

## Renamed tables

| Table no | SIX | Seven |
|---|---|---|
| 37 | recordlink | [MergeMoveLog](../Tables/MERGEMOVELOG.md) |
| 115 | OptCat | [ReasonSold](../Tables/ReasonSold.md) |
| 116 | OptCatGroupLink | [ReasonSoldGroupLink](../Tables/ReasonSoldGroupLink.md) |
| 117 | OptCatHeadingLink | [ReasonSoldHeadingLink](../Tables/ReasonSoldHeadingLink.md) |
| 118 | OptType | [SaleTypeCat](../Tables/SaleTypeCat.md) |
| 119 | OptTypeGroupLink | [SaleTypeCatGroupLink](../Tables/SaleTypeCatGroupLink.md) |
| 120 | OptTypeHeadingLink | [SaleTypeCatHeadingLink](../Tables/SaleTypeCatHeadingLink.md) |
| 121 | OptState | [SaleStakeholder](../Tables/SaleStakeholder.md) |
| 122 | OptStateGroupLink | [StakeholderRole](../Tables/StakeholderRole.md) |
| 123 | OptStateHeadingLink | [StakeholderRoleGroupLink](../Tables/StakeholderRoleGroupLink.md) |
| 124 | OptInt | [StakeholderRoleHeadingLink](../Tables/StakeholderRoleHeadingLink.md) |
| 125 | OptIntGroupLink | [SuggestedAppointment](../Tables/SuggestedAppointment.md) |
| 126 | OptIntHeadingLink | [SuggestedDocument](../Tables/SuggestedDocument.md) |
| 149 | Opportunity | [SaleType](../Tables/SaleType.md) |
| 150 | OptItem | [SaleTypeGroupLink](../Tables/SaleTypeGroupLink.md) |
| 151 | OptPlan | [SaleTypeHeadingLink](../Tables/SaleTypeHeadingLink.md) |
| 152 | OptPlanItem | [TabOrder](../Tables/TabOrder.md) |
| 154 | SelCriterion | [ReasonStalled](../Tables/ReasonStalled.md) |
| 155 | SelOpChain | [ReasonStalledGroupLink](../Tables/ReasonStalledGroupLink.md) |
| 156 | SelOp | [ReasonStalledHeadingLink](../Tables/ReasonStalledHeadingLink.md) |
| 160 | DocumentLink | [SaleTypeStageLink](../Tables/SaleTypeStageLink.md) |
| 212 | TimeZone | [ModuleOwner](../Tables/ModuleOwner.md) |
| 213 | TimeZoneCountry | [ProjectTypeStatusLink](../Tables/ProjectTypeStatusLink.md) |
| 237 | ModuleLicence | [ModuleLicense](../Tables/ModuleLicense.md) |
| 238 | LicenceAssocLink | [LicenseAssocLink](../Tables/LicenseAssocLink.md) |
| 239 | LicenceSatlLink | [LicenseSatlLink](../Tables/LicenseSatlLink.md)

## Obsolete database tables

| Table no | SIX | Seven |
|---|---|---|
| 25 | selectionTask | obsolete\_1 |
| 26 | selTaskChain | obsolete\_2 |
| 27 | PDALink | obsolete\_3 |
| 34 | TrgdbAssocLink | obsolete\_4 |
| 39 | AreaCatLink | obsolete\_9 |
| 47 | freetextsynonyms | obsolete\_5 |
| 127 | OptDec | obsolete\_6 |
| 128 | OptDecGroupLink | obsolete\_7 |
| 129 | OptDecHeadingLink | obsolete\_8 |

These are now single-field tables in the dictionary, but they are not physically created in the database. This keeps the table numbers unchanged.

## New tables for eJournal

| Table no | Name |
|---|---|
| 253 | [registry](../Tables/registry.md) |
| 254 | [session\_object](../Tables/session_object.md) |
| 255 | [config](../Tables/config.md) |
| 256 | [ticket\_attachment](../Tables/ticket_attachment.md) |
| 257 | [ej\_category](../Tables/ej_category.md) |
| 258 | [ej\_message](../Tables/ej_message.md) |
| 259 | [message\_header](../Tables/message_header.md) |
| 260 | [message\_customers](../Tables/message_customers.md) |
| 261 | [ticket\_status\_history](../Tables/ticket_status_history.md) |
| 262 | [ticket](../Tables/ticket.md) |
| 263 | [ticket\_status](../Tables/ticket_status.md) |
| 264 | [ticket\_customers](../Tables/ticket_customers.md) |
| 265 | [invoice](../Tables/invoice.md) |
| 266 | [invoice\_sum](../Tables/invoice_sum.md) |
| 267 | [ticket\_log](../Tables/ticket_log.md) |
| 268 | [ticket\_log\_change](../Tables/ticket_log_change.md) |
| 269 | [ticket\_log\_action](../Tables/ticket_log_action.md) |
| 270 | [category\_membership](../Tables/category_membership.md) |
| 271 | [mail\_in\_filter](../Tables/mail_in_filter.md) |
| 272 | [mail\_in\_uidl](../Tables/mail_in_uidl.md) |
| 273 | [mail\_alias](../Tables/mail_alias.md) |
| 274 | [ticket\_alert](../Tables/ticket_alert.md) |
| 275 | [ticket\_priority](../Tables/ticket_priority.md) |
| 276 | [reply\_template\_folder](../Tables/reply_template_folder.md) |
| 277 | [reply\_template](../Tables/reply_template.md) |
| 278 | [reply\_template\_attachment](../Tables/reply_template_attachment.md) |
| 279 | [reply\_template\_body](../Tables/reply_template_body.md) |
| 280 | [doc\_document](../Tables/doc_document.md) |
| 281 | [doc\_folder](../Tables/doc_folder.md) |
| 282 | [kb\_entry](../Tables/kb_entry.md) |
| 283 | [kb\_category](../Tables/kb_category.md) |
| 284 | [kb\_attachment](../Tables/kb_attachment.md) |
| 285 | [kb\_http\_link](../Tables/kb_http_link.md) |
| 286 | [kb\_group](../Tables/kb_group.md) |
| 287 | [kb\_group\_entry](../Tables/kb_group_entry.md) |
| 288 | [kb\_entry\_keyword](../Tables/kb_entry_keyword.md) |
| 289 | [kb\_entry\_comment](../Tables/kb_entry_comment.md) |
| 290 | [kb\_entry\_log](../Tables/kb_entry_log.md) |
| 291 | [kb\_category\_log](../Tables/kb_category_log.md) |
| 292 | [kb\_workflow](../Tables/kb_workflow.md) |
| 293 | [kb\_workflow\_access](../Tables/kb_workflow_access.md) |
| 294 | [kb\_solution\_finder](../Tables/kb_solution_finder.md) |
| 295 | [kb\_solution\_finder\_entry](../Tables/kb_solution_finder_entry.md) |
| 296 | [attachment](../Tables/attachment.md) |
| 297 | [login](../Tables/login.md) |
| 298 | [login\_customer](../Tables/login_customer.md) |
| 299 | [ejuser](../Tables/ejuser.md) |
| 300 | [timestamps](../Tables/timestamps.md) |
| 301 | [notify](../Tables/notify.md) |
| 302 | [help](../Tables/help.md) |
| 303 | [company\_domain](../Tables/company_domain.md) |
| 304 | [extra\_fields](../Tables/extra_fields.md) |
| 305 | [extra\_tables](../Tables/extra_tables.md) |
| 306 | [hierarchy](../Tables/hierarchy.md) |
| 307 | [extra\_menus](../Tables/extra_menus.md) |
| 308 | [extra\_tables\_result](../Tables/extra_tables_result.md) |
| 309 | [extra\_tables\_entry](../Tables/extra_tables_entry.md) |
| 310 | [ms\_filter](../Tables/ms_filter.md) |
| 311 | [ms\_filter\_mail](../Tables/ms_filter_mail.md) |
| 312 | [ms\_trashbin](../Tables/ms_trashbin.md) |
| 313 | [ms\_substitute](../Tables/ms_substitute.md) |
| 314 | [eab\_folder](../Tables/eab_folder.md) |
| 315 | [eab\_entry](../Tables/eab_entry.md) |
| 316 | [mail\_block](../Tables/mail_block.md) |
| 317 | [ext\_datasource](../Tables/ext_datasource.md) |
| 318 | [ext\_table](../Tables/ext_table.md) |
| 319 | [ext\_field](../Tables/ext_field.md) |
| 320 | [cust\_lang](../Tables/cust_lang.md) |
| 321 | [cust\_category](../Tables/cust_category.md) |
| 322 | [password\_rules](../Tables/password_rules.md) |
| 323 | [ej\_role](../Tables/ej_role.md) |
| 324 | [role\_member](../Tables/role_member.md) |
| 325 | [role\_category](../Tables/role_category.md) |
| 326 | [role\_element](../Tables/role_element.md) |
| 327 | [role\_workflow](../Tables/role_workflow.md) |
| 328 | [element\_profile](../Tables/element_profile.md) |
| 329 | [profile](../Tables/profile.md) |
| 330 | [chat\_topic](../Tables/chat_topic.md) |
| 331 | [chat\_topic\_user](../Tables/chat_topic_user.md) |
| 332 | [chat\_session](../Tables/chat_session.md) |
| 333 | [chat\_message](../Tables/chat_message.md) |
| 334 | [s\_shipment](../Tables/s_shipment.md) |
| 335 | [s\_message](../Tables/s_message.md) |
| 336 | [s\_link](../Tables/s_link.md) |
| 337 | [s\_link\_customer](../Tables/s_link_customer.md) |
| 338 | [s\_link\_customer\_statical](../Tables/s_link_customer_statical.md) |
| 339 | [s\_picture\_folder](../Tables/s_picture_folder.md) |
| 340 | [s\_picture\_entry](../Tables/s_picture_entry.md) |
| 341 | [s\_washing](../Tables/s_washing.md) |
| 342 | [s\_bounce\_shipment](../Tables/s_bounce_shipment.md) |
| 343 | [s\_washing\_list](../Tables/s_washing_list.md) |
| 344 | [s\_list](../Tables/s_list.md) |
| 345 | [s\_list\_element](../Tables/s_list_element.md) |
| 346 | [s\_list\_customer](../Tables/s_list_customer.md) |
| 347 | [s\_shipment\_addr](../Tables/s_shipment_addr.md) |
| 348 | [s\_list\_shipment](../Tables/s_list_shipment.md) |
| 349 | [s\_attachment](../Tables/s_attachment.md) |
| 350 | [s\_dyn\_criteria](../Tables/s_dyn_criteria.md) |
| 351 | [outbox](../Tables/outbox.md) |
| 352 | [inbox](../Tables/inbox.md) |
| 353 | [legal\_html\_tags](../Tables/legal_html_tags.md) |
| 354 | [kb\_entry\_words](../Tables/kb_entry_words.md) |
| 355 | [word\_relations](../Tables/word_relations.md) |
| 356 | [temporary\_words](../Tables/temporary_words.md) |
| 357 | [wsdl\_description](../Tables/wsdl_description.md) |
| 358 | [dictionary](../Tables/dictionary.md) |
| 359 | [dictionary\_base](../Tables/dictionary_base.md) |
| 360 | [invoice\_entry](../Tables/invoice_entry.md) |
| 361 | [invoice\_type](../Tables/invoice_type.md) |
| 362 | [soap\_access](../Tables/soap_access.md) |
| 363 | [hotlist](../Tables/hotlist.md) |
| 364 | [log\_events](../Tables/log_events.md) |
| 365 | [log\_debug](../Tables/log_debug.md) |
| 366 | [form\_keys](../Tables/form_keys.md) |
| 367 | [sms\_hysteria](../Tables/sms_hysteria.md) |
| 368 | [item\_config](../Tables/item_config.md) |
| 369 | [snapshot](../Tables/snapshot.md) |
| 370 | [screen\_definition](../Tables/screen_definition.md) |
| 371 | [screen\_definition\_action](../Tables/screen_definition_action.md) |
| 372 | [screen\_definition\_element](../Tables/screen_definition_element.md) |
| 373 | [screen\_definition\_hidden](../Tables/screen_definition_hidden.md) |
| 374 | [screen\_definition\_language](../Tables/screen_definition_language.md) |
| 375 | [screen\_chooser](../Tables/screen_chooser.md) |
| 376 | [scheduled\_task](../Tables/scheduled_task.md) |
| 377 | [ejscript](../Tables/ejscript.md) |
| 378 | [system\_script](../Tables/system_script.md) |
| 379 | [schedule](../Tables/schedule.md) |
| 380 | [locking](../Tables/locking.md) |
| 381 | [dbi\_agent](../Tables/dbi_agent.md) |
| 382 | [dbi\_agent\_field](../Tables/dbi_agent_field.md) |
| 383 | [dbi\_agent\_schedule](../Tables/dbi_agent_schedule.md) |
| 384 | [ejpackage](../Tables/ejpackage.md) |
| 385 | [ejpackage\_item](../Tables/ejpackage_item.md) |
| 386 | [message\_id](../Tables/message_id.md) |
| 387 | [ejscript\_debug](../Tables/ejscript_debug.md) |
| 388 | [sms](../Tables/sms.md) |
| 389 | [user\_candidate](../Tables/user_candidate.md) |
| 390 | [s\_smtp\_servers](../Tables/s_smtp_servers.md) |
| 391 | [ejselection](../Tables/ejselection.md) |
| 392 | [ejsel\_ejsel](../Tables/ejsel_ejsel.md) |
| 393 | [ejsel\_source\_idlist](../Tables/ejsel_source_idlist.md) |
| 394 | [ejsel\_source\_script](../Tables/ejsel_source_script.md) |
| 395 | [ejsel\_source\_xml](../Tables/ejsel_source_xml.md) |
| 396 | [static\_list\_ref](../Tables/static_list_ref.md) |
| 397 | [ejsel\_meta\_result](../Tables/ejsel_meta_result.md) |
| 398 | [ejsel\_result\_set](../Tables/ejsel_result_set.md) |
| 399 | [tree\_explorer\_entry](../Tables/tree_explorer_entry.md) |
| 400 | [tree\_explorer\_link](../Tables/tree_explorer_link.md) |
| 401 | [external\_document](../Tables/external_document.md) |
| 402 | [autosave](../Tables/autosave.md) |
| 403 | [user\_attribute](../Tables/user_attribute.md) |
| 404 | [notice\_frame](../Tables/notice_frame.md) |
| 405 | [s\_sent\_message](../Tables/s_sent_message.md) |
| 406 | [access\_script](../Tables/access_script.md) |
