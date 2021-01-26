---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title:  changes_6_to_7       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:  Table changes from SuperOffice 6 to 7 # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author:  {github-id}             # Your GitHub alias.
keywords:  database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:  onsite           # cloud or onsite
# so.client :                     # online, web, win, pocket, or mobile
---

# Table changes from SuperOffice 6 to 7

## Renamed tables

| Table no | v.6 | v.7 |
|---|---|---|
| 37 | recordlink | [MergeMoveLog](../tables/mergemovelog.md) |
| 115 | OptCat | [ReasonSold](../tables/reasonsold.md) |
| 116 | OptCatGroupLink | [ReasonSoldGroupLink](../tables/reasonsoldgrouplink.md) |
| 117 | OptCatHeadingLink | [ReasonSoldHeadingLink](../tables/reasonsoldheadinglink.md) |
| 118 | OptType | [SaleTypeCat](../tables/saletypecat.md) |
| 119 | OptTypeGroupLink | [SaleTypeCatGroupLink](../tables/saletypecatgrouplink.md) |
| 120 | OptTypeHeadingLink | [SaleTypeCatHeadingLink](../tables/saletypecatheadinglink.md) |
| 121 | OptState | [SaleStakeholder](../tables/salestakeholder.md) |
| 122 | OptStateGroupLink | [StakeholderRole](../tables/stakeholderrole.md) |
| 123 | OptStateHeadingLink | [StakeholderRoleGroupLink](../tables/stakeholderrolegrouplink.md) |
| 124 | OptInt | [StakeholderRoleHeadingLink](../tables/stakeholderroleheadinglink.md) |
| 125 | OptIntGroupLink | [SuggestedAppointment](../tables/suggestedappointment.md) |
| 126 | OptIntHeadingLink | [SuggestedDocument](../tables/suggesteddocument.md) |
| 149 | Opportunity | [SaleType](../tables/saletype.md) |
| 150 | OptItem | [SaleTypeGroupLink](../tables/saletypegrouplink.md) |
| 151 | OptPlan | [SaleTypeHeadingLink](../tables/saletypeheadinglink.md) |
| 152 | OptPlanItem | [TabOrder](../tables/taborder.md) |
| 154 | SelCriterion | [ReasonStalled](../tables/reasonstalled.md) |
| 155 | SelOpChain | [ReasonStalledGroupLink](../tables/reasonstalledgrouplink.md) |
| 156 | SelOp | [ReasonStalledHeadingLink](../tables/reasonstalledheadinglink.md) |
| 160 | DocumentLink | [SaleTypeStageLink](../tables/saletypestagelink.md) |
| 212 | TimeZone | [ModuleOwner](../tables/moduleowner.md) |
| 213 | TimeZoneCountry | [ProjectTypeStatusLink](../tables/projecttypestatuslink.md) |
| 237 | ModuleLicence | [ModuleLicense](../tables/modulelicense.md) |
| 238 | LicenceAssocLink | [LicenseAssocLink](../tables/licenseassoclink.md) |
| 239 | LicenceSatlLink | [LicenseSatlLink](../tables/licensesatllink.md)

## Obsolete database tables

| Table no | v.6 | v.7 |
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
| 253 | [registry](../tables/registry.md) |
| 254 | [session\_object](../tables/session-object.md) |
| 255 | [config](../tables/config.md) |
| 256 | [ticket\_attachment](../tables/ticket-attachment.md) |
| 257 | [ej\_category](../tables/ej-category.md) |
| 258 | [ej\_message](../tables/ej-message.md) |
| 259 | [message\_header](../tables/message-header.md) |
| 260 | [message\_customers](../tables/message-customers.md) |
| 261 | [ticket\_status\_history](../tables/ticket-status-history.md) |
| 262 | [ticket](../tables/ticket.md) |
| 263 | [ticket\_status](../tables/ticket-status.md) |
| 264 | [ticket\_customers](../tables/ticket-customers.md) |
| 265 | [invoice](../tables/invoice.md) |
| 266 | [invoice\_sum](../tables/invoice-sum.md) |
| 267 | [ticket\_log](../tables/ticket-log.md) |
| 268 | [ticket\_log\_change](../tables/ticket-log-change.md) |
| 269 | [ticket\_log\_action](../tables/ticket-log-action.md) |
| 270 | [category\_membership](../tables/category-membership.md) |
| 271 | [mail\_in\_filter](../tables/mail-in-filter.md) |
| 272 | [mail\_in\_uidl](../tables/mail-in-uidl.md) |
| 273 | [mail\_alias](../tables/mail-alias.md) |
| 274 | [ticket\_alert](../tables/ticket-alert.md) |
| 275 | [ticket\_priority](../tables/ticket-priority.md) |
| 276 | [reply\_template\_folder](../tables/reply-template-folder.md) |
| 277 | [reply\_template](../tables/reply-template.md) |
| 278 | [reply\_template\_attachment](../tables/reply-template-attachment.md) |
| 279 | [reply\_template\_body](../tables/reply-template-body.md) |
| 280 | [doc\_document](../tables/doc-document.md) |
| 281 | [doc\_folder](../tables/doc-folder.md) |
| 282 | [kb\_entry](../tables/kb-entry.md) |
| 283 | [kb\_category](../tables/kb-category.md) |
| 284 | [kb\_attachment](../tables/kb-attachment.md) |
| 285 | [kb\_http\_link](../tables/kb-http-link.md) |
| 286 | [kb\_group](../tables/kb-group.md) |
| 287 | [kb\_group\_entry](../tables/kb-group-entry.md) |
| 288 | [kb\_entry\_keyword](../tables/kb-entry-keyword.md) |
| 289 | [kb\_entry\_comment](../tables/kb-entry-comment.md) |
| 290 | [kb\_entry\_log](../tables/kb-entry-log.md) |
| 291 | [kb\_category\_log](../tables/kb-category-log.md) |
| 292 | [kb\_workflow](../tables/kb-workflow.md) |
| 293 | [kb\_workflow\_access](../tables/kb-workflow-access.md) |
| 294 | [kb\_solution\_finder](../tables/kb-solution-finder.md) |
| 295 | [kb\_solution\_finder\_entry](../tables/kb-solution-finder-entry.md) |
| 296 | [attachment](../tables/attachment.md) |
| 297 | [login](../tables/login.md) |
| 298 | [login\_customer](../tables/login-customer.md) |
| 299 | [ejuser](../tables/ejuser.md) |
| 300 | [timestamps](../tables/timestamps.md) |
| 301 | [notify](../tables/notify.md) |
| 302 | [help](../tables/help.md) |
| 303 | [company\_domain](../tables/company-domain.md) |
| 304 | [extra\_fields](../tables/extra-fields.md) |
| 305 | [extra\_tables](../tables/extra-tables.md) |
| 306 | [hierarchy](../tables/hierarchy.md) |
| 307 | [extra\_menus](../tables/extra-menus.md) |
| 308 | [extra\_tables\_result](../tables/extra-tables-result.md) |
| 309 | [extra\_tables\_entry](../tables/extra-tables-entry.md) |
| 310 | [ms\_filter](../tables/ms-filter.md) |
| 311 | [ms\_filter\_mail](../tables/ms-filter-mail.md) |
| 312 | [ms\_trashbin](../tables/ms-trashbin.md) |
| 313 | [ms\_substitute](../tables/ms-substitute.md) |
| 314 | [eab\_folder](../tables/eab-folder.md) |
| 315 | [eab\_entry](../tables/eab-entry.md) |
| 316 | [mail\_block](../tables/mail-block.md) |
| 317 | [ext\_datasource](../tables/ext-datasource.md) |
| 318 | [ext\_table](../tables/ext-table.md) |
| 319 | [ext\_field](../tables/ext-field.md) |
| 320 | [cust\_lang](../tables/cust-lang.md) |
| 321 | [cust\_category](../tables/cust-category.md) |
| 322 | [password\_rules](../tables/password-rules.md) |
| 323 | [ej\_role](../tables/ej-role.md) |
| 324 | [role\_member](../tables/role-member.md) |
| 325 | [role\_category](../tables/role-category.md) |
| 326 | [role\_element](../tables/role-element.md) |
| 327 | [role\_workflow](../tables/role-workflow.md) |
| 328 | [element\_profile](../tables/element-profile.md) |
| 329 | [profile](../tables/profile.md) |
| 330 | [chat\_topic](../tables/chat-topic.md) |
| 331 | [chat\_topic\_user](../tables/chat-topic-user.md) |
| 332 | [chat\_session](../tables/chat-session.md) |
| 333 | [chat\_message](../tables/chat-message.md) |
| 334 | [s\_shipment](../tables/s-shipment.md) |
| 335 | [s\_message](../tables/s-message.md) |
| 336 | [s\_link](../tables/s-link.md) |
| 337 | [s\_link\_customer](../tables/s-link-customer.md) |
| 338 | [s\_link\_customer\_statical](../tables/s-link-customer-statical.md) |
| 339 | [s\_picture\_folder](../tables/s-picture-folder.md) |
| 340 | [s\_picture\_entry](../tables/s-picture-entry.md) |
| 341 | [s\_washing](../tables/s-washing.md) |
| 342 | [s\_bounce\_shipment](../tables/s-bounce-shipment.md) |
| 343 | [s\_washing\_list](../tables/s-washing-list.md) |
| 344 | [s\_list](../tables/s-list.md) |
| 345 | [s\_list\_element](../tables/s-list-element.md) |
| 346 | [s\_list\_customer](../tables/s-list-customer.md) |
| 347 | [s\_shipment\_addr](../tables/s-shipment-addr.md) |
| 348 | [s\_list\_shipment](../tables/s-list-shipment.md) |
| 349 | [s\_attachment](../tables/s-attachment.md) |
| 350 | [s\_dyn\_criteria](../tables/s-dyn-criteria.md) |
| 351 | [outbox](../tables/outbox.md) |
| 352 | [inbox](../tables/inbox.md) |
| 353 | [legal\_html\_tags](../tables/legal-html-tags.md) |
| 354 | [kb\_entry\_words](../tables/kb-entry-words.md) |
| 355 | [word\_relations](../tables/word-relations.md) |
| 356 | [temporary\_words](../tables/temporary-words.md) |
| 357 | [wsdl\_description](../tables/wsdl-description.md) |
| 358 | [dictionary](../tables/dictionary.md) |
| 359 | [dictionary\_base](../tables/dictionary-base.md) |
| 360 | [invoice\_entry](../tables/invoice-entry.md) |
| 361 | [invoice\_type](../tables/invoice-type.md) |
| 362 | [soap\_access](../tables/soap-access.md) |
| 363 | [hotlist](../tables/hotlist.md) |
| 364 | [log\_events](../tables/log-events.md) |
| 365 | [log\_debug](../tables/log-debug.md) |
| 366 | [form\_keys](../tables/form-keys.md) |
| 367 | [sms\_hysteria](../tables/sms-hysteria.md) |
| 368 | [item\_config](../tables/item-config.md) |
| 369 | [snapshot](../tables/snapshot.md) |
| 370 | [screen\_definition](../tables/screen-definition.md) |
| 371 | [screen\_definition\_action](../tables/screen-definition-action.md) |
| 372 | [screen\_definition\_element](../tables/screen-definition-element.md) |
| 373 | [screen\_definition\_hidden](../tables/screen-definition-hidden.md) |
| 374 | [screen\_definition\_language](../tables/screen-definition-language.md) |
| 375 | [screen\_chooser](../tables/screen-chooser.md) |
| 376 | [scheduled\_task](../tables/scheduled-task.md) |
| 377 | [ejscript](../tables/ejscript.md) |
| 378 | [system\-script](../tables/system-script.md) |
| 379 | [schedule](../tables/schedule.md) |
| 380 | [locking](../tables/locking.md) |
| 381 | [dbi\_agent](../tables/dbi-agent.md) |
| 382 | [dbi\_agent\_field](../tables/dbi-agent-field.md) |
| 383 | [dbi\_agent\-schedule](../tables/dbi-agent-schedule.md) |
| 384 | [ejpackage](../tables/ejpackage.md) |
| 385 | [ejpackage\_item](../tables/ejpackage-item.md) |
| 386 | [message\_id](../tables/message-id.md) |
| 387 | [ejscript\_debug](../tables/ejscript-debug.md) |
| 388 | [sms](../tables/sms.md) |
| 389 | [user\_candidate](../tables/user-candidate.md) |
| 390 | [s\_smtp\_servers](../tables/s-smtp-servers.md) |
| 391 | [ejselection](../tables/ejselection.md) |
| 392 | [ejsel\_ejsel](../tables/ejsel-ejsel.md) |
| 393 | [ejsel\_source\_idlist](../tables/ejsel-source-idlist.md) |
| 394 | [ejsel\_source\-script](../tables/ejsel-source-script.md) |
| 395 | [ejsel\_source\_xml](../tables/ejsel-source-xml.md) |
| 396 | [static\_list\_ref](../tables/static-list-ref.md) |
| 397 | [ejsel\_meta\_result](../tables/ejsel-meta-result.md) |
| 398 | [ejsel\_result\_set](../tables/ejsel-result-set.md) |
| 399 | [tree\_explorer\_entry](../tables/tree-explorer-entry.md) |
| 400 | [tree\_explorer\_link](../tables/tree-explorer-link.md) |
| 401 | [external\_document](../tables/external-document.md) |
| 402 | [autosave](../tables/autosave.md) |
| 403 | [user\_attribute](../tables/user-attribute.md) |
| 404 | [notice\_frame](../tables/notice-frame.md) |
| 405 | [s\_sent\_message](../tables/s-sent-message.md) |
| 406 | [access\-script](../tables/access-script.md) |
