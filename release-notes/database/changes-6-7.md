---
title: changes_6_to_7
description: Table changes from SuperOffice 6 to 7
author: {github-id}
keywords: database
so.topic: reference
so.envir: onsite
# so.client:
so.version: 7
---

# Table changes from SuperOffice 6.3 to 7.0

## Renamed tables

| Table no | v.6 | v.7 |
|---|---|---|
| 37 | recordlink | [MergeMoveLog](../../docs/database/tables/mergemovelog.md) |
| 115 | OptCat | [ReasonSold](../../docs/database/tables/reasonsold.md) |
| 116 | OptCatGroupLink | [ReasonSoldGroupLink](../../docs/database/tables/reasonsoldgrouplink.md) |
| 117 | OptCatHeadingLink | [ReasonSoldHeadingLink](../../docs/database/tables/reasonsoldheadinglink.md) |
| 118 | OptType | [SaleTypeCat](../../docs/database/tables/saletypecat.md) |
| 119 | OptTypeGroupLink | [SaleTypeCatGroupLink](../../docs/database/tables/saletypecatgrouplink.md) |
| 120 | OptTypeHeadingLink | [SaleTypeCatHeadingLink](../../docs/database/tables/saletypecatheadinglink.md) |
| 121 | OptState | [SaleStakeholder](../../docs/database/tables/salestakeholder.md) |
| 122 | OptStateGroupLink | [StakeholderRole](../../docs/database/tables/stakeholderrole.md) |
| 123 | OptStateHeadingLink | [StakeholderRoleGroupLink](../../docs/database/tables/stakeholderrolegrouplink.md) |
| 124 | OptInt | [StakeholderRoleHeadingLink](../../docs/database/tables/stakeholderroleheadinglink.md) |
| 125 | OptIntGroupLink | [SuggestedAppointment](../../docs/database/tables/suggestedappointment.md) |
| 126 | OptIntHeadingLink | [SuggestedDocument](../../docs/database/tables/suggesteddocument.md) |
| 149 | Opportunity | [SaleType](../../docs/database/tables/saletype.md) |
| 150 | OptItem | [SaleTypeGroupLink](../../docs/database/tables/saletypegrouplink.md) |
| 151 | OptPlan | [SaleTypeHeadingLink](../../docs/database/tables/saletypeheadinglink.md) |
| 152 | OptPlanItem | [TabOrder](../../docs/database/tables/taborder.md) |
| 154 | SelCriterion | [ReasonStalled](../../docs/database/tables/reasonstalled.md) |
| 155 | SelOpChain | [ReasonStalledGroupLink](../../docs/database/tables/reasonstalledgrouplink.md) |
| 156 | SelOp | [ReasonStalledHeadingLink](../../docs/database/tables/reasonstalledheadinglink.md) |
| 160 | DocumentLink | [SaleTypeStageLink](../../docs/database/tables/saletypestagelink.md) |
| 212 | TimeZone | [ModuleOwner](../../docs/database/tables/moduleowner.md) |
| 213 | TimeZoneCountry | [ProjectTypeStatusLink](../../docs/database/tables/projecttypestatuslink.md) |
| 237 | ModuleLicence | [ModuleLicense](../../docs/database/tables/modulelicense.md) |
| 238 | LicenceAssocLink | [LicenseAssocLink](../../docs/database/tables/licenseassoclink.md) |
| 239 | LicenceSatlLink | [LicenseSatlLink](../../docs/database/tables/licensesatllink.md)

## Obsolete database tables

| Table no | v.6 | v.7 |
|---|---|---|
| 25 | selectionTask | `obsolete_1` |
| 26 | selTaskChain | `obsolete_2` |
| 27 | PDALink | `obsolete_3` |
| 34 | TrgdbAssocLink | `obsolete_4` |
| 39 | AreaCatLink | `obsolete_9` |
| 47 | freetextsynonyms | `obsolete_5` |
| 127 | OptDec | `obsolete_6` |
| 128 | OptDecGroupLink | `obsolete_7` |
| 129 | OptDecHeadingLink | `obsolete_8` |

These are now single-field tables in the dictionary, but they are not physically created in the database. This keeps the table numbers unchanged.

## New tables for eJournal

| Table no | Name |
|---|---|
| 253 | [registry](../../docs/database/tables/registry.md) |
| 254 | [session\_object](../../docs/database/tables/session-object.md) |
| 255 | [config](../../docs/database/tables/config.md) |
| 256 | [ticket\_attachment](../../docs/database/tables/ticket-attachment.md) |
| 257 | [ej\_category](../../docs/database/tables/ej-category.md) |
| 258 | [ej\_message](../../docs/database/tables/ej-message.md) |
| 259 | [message\_header](../../docs/database/tables/message-header.md) |
| 260 | [message\_customers](../../docs/database/tables/message-customers.md) |
| 261 | [ticket\_status\_history](../../docs/database/tables/ticket-status-history.md) |
| 262 | [ticket](../../docs/database/tables/ticket.md) |
| 263 | [ticket\_status](../../docs/database/tables/ticket-status.md) |
| 264 | [ticket\_customers](../../docs/database/tables/ticket-customers.md) |
| 265 | [invoice](../../docs/database/tables/invoice.md) |
| 266 | [invoice\_sum](../../docs/database/tables/invoice-sum.md) |
| 267 | [ticket\_log](../../docs/database/tables/ticket-log.md) |
| 268 | [ticket\_log\_change](../../docs/database/tables/ticket-log-change.md) |
| 269 | [ticket\_log\_action](../../docs/database/tables/ticket-log-action.md) |
| 270 | [category\_membership](../../docs/database/tables/category-membership.md) |
| 271 | [mail\_in\_filter](../../docs/database/tables/mail-in-filter.md) |
| 272 | [mail\_in\_uidl](../../docs/database/tables/mail-in-uidl.md) |
| 273 | [mail\_alias](../../docs/database/tables/mail-alias.md) |
| 274 | [ticket\_alert](../../docs/database/tables/ticket-alert.md) |
| 275 | [ticket\_priority](../../docs/database/tables/ticket-priority.md) |
| 276 | [reply\_template\_folder](../../docs/database/tables/reply-template-folder.md) |
| 277 | [reply\_template](../../docs/database/tables/reply-template.md) |
| 278 | [reply\_template\_attachment](../../docs/database/tables/reply-template-attachment.md) |
| 279 | [reply\_template\_body](../../docs/database/tables/reply-template-body.md) |
| 280 | [doc\_document](../../docs/database/tables/doc-document.md) |
| 281 | [doc\_folder](../../docs/database/tables/doc-folder.md) |
| 282 | [kb\_entry](../../docs/database/tables/kb-entry.md) |
| 283 | [kb\_category](../../docs/database/tables/kb-category.md) |
| 284 | [kb\_attachment](../../docs/database/tables/kb-attachment.md) |
| 285 | [kb\_http\_link](../../docs/database/tables/kb-http-link.md) |
| 286 | [kb\_group](../../docs/database/tables/kb-group.md) |
| 287 | [kb\_group\_entry](../../docs/database/tables/kb-group-entry.md) |
| 288 | [kb\_entry\_keyword](../../docs/database/tables/kb-entry-keyword.md) |
| 289 | [kb\_entry\_comment](../../docs/database/tables/kb-entry-comment.md) |
| 290 | [kb\_entry\_log](../../docs/database/tables/kb-entry-log.md) |
| 291 | [kb\_category\_log](../../docs/database/tables/kb-category-log.md) |
| 292 | [kb\_workflow](../../docs/database/tables/kb-workflow.md) |
| 293 | [kb\_workflow\_access](../../docs/database/tables/kb-workflow-access.md) |
| 294 | [kb\_solution\_finder](../../docs/database/tables/kb-solution-finder.md) |
| 295 | [kb\_solution\_finder\_entry](../../docs/database/tables/kb-solution-finder-entry.md) |
| 296 | [attachment](../../docs/database/tables/attachment.md) |
| 297 | [login](../../docs/database/tables/login.md) |
| 298 | [login\_customer](../../docs/database/tables/login-customer.md) |
| 299 | [ejuser](../../docs/database/tables/ejuser.md) |
| 300 | [timestamps](../../docs/database/tables/timestamps.md) |
| 301 | [notify](../../docs/database/tables/notify.md) |
| 302 | [help](../../docs/database/tables/help.md) |
| 303 | [company\_domain](../../docs/database/tables/company-domain.md) |
| 304 | [extra\_fields](../../docs/database/tables/extra-fields.md) |
| 305 | [extra\_tables](../../docs/database/tables/extra-tables.md) |
| 306 | [hierarchy](../../docs/database/tables/hierarchy.md) |
| 307 | [extra\_menus](../../docs/database/tables/extra-menus.md) |
| 308 | [extra\_tables\_result](../../docs/database/tables/extra-tables-result.md) |
| 309 | [extra\_tables\_entry](../../docs/database/tables/extra-tables-entry.md) |
| 310 | [ms\_filter](../../docs/database/tables/ms-filter.md) |
| 311 | [ms\_filter\_mail](../../docs/database/tables/ms-filter-mail.md) |
| 312 | [ms\_trashbin](../../docs/database/tables/ms-trashbin.md) |
| 313 | [ms\_substitute](../../docs/database/tables/ms-substitute.md) |
| 314 | [eab\_folder](../../docs/database/tables/eab-folder.md) |
| 315 | [eab\_entry](../../docs/database/tables/eab-entry.md) |
| 316 | [mail\_block](../../docs/database/tables/mail-block.md) |
| 317 | [ext\_datasource](../../docs/database/tables/ext-datasource.md) |
| 318 | [ext\_table](../../docs/database/tables/ext-table.md) |
| 319 | [ext\_field](../../docs/database/tables/ext-field.md) |
| 320 | [cust\_lang](../../docs/database/tables/cust-lang.md) |
| 321 | [cust\_category](../../docs/database/tables/cust-category.md) |
| 322 | [password\_rules](../../docs/database/tables/password-rules.md) |
| 323 | [ej\_role](../../docs/database/tables/ej-role.md) |
| 324 | [role\_member](../../docs/database/tables/role-member.md) |
| 325 | [role\_category](../../docs/database/tables/role-category.md) |
| 326 | [role\_element](../../docs/database/tables/role-element.md) |
| 327 | [role\_workflow](../../docs/database/tables/role-workflow.md) |
| 328 | [element\_profile](../../docs/database/tables/element-profile.md) |
| 329 | [profile](../../docs/database/tables/profile.md) |
| 330 | [chat\_topic](../../docs/database/tables/chat-topic.md) |
| 331 | [chat\_topic\_user](../../docs/database/tables/chat-topic-user.md) |
| 332 | [chat\_session](../../docs/database/tables/chat-session.md) |
| 333 | [chat\_message](../../docs/database/tables/chat-message.md) |
| 334 | [s\_shipment](../../docs/database/tables/s-shipment.md) |
| 335 | [s\_message](../../docs/database/tables/s-message.md) |
| 336 | [s\_link](../../docs/database/tables/s-link.md) |
| 337 | [s\_link\_customer](../../docs/database/tables/s-link-customer.md) |
| 338 | [s\_link\_customer\_statical](../../docs/database/tables/s-link-customer-statical.md) |
| 339 | [s\_picture\_folder](../../docs/database/tables/s-picture-folder.md) |
| 340 | [s\_picture\_entry](../../docs/database/tables/s-picture-entry.md) |
| 341 | [s\_washing](../../docs/database/tables/s-washing.md) |
| 342 | [s\_bounce\_shipment](../../docs/database/tables/s-bounce-shipment.md) |
| 343 | [s\_washing\_list](../../docs/database/tables/s-washing-list.md) |
| 344 | [s\_list](../../docs/database/tables/s-list.md) |
| 345 | [s\_list\_element](../../docs/database/tables/s-list-element.md) |
| 346 | [s\_list\_customer](../../docs/database/tables/s-list-customer.md) |
| 347 | [s\_shipment\_addr](../../docs/database/tables/s-shipment-addr.md) |
| 348 | [s\_list\_shipment](../../docs/database/tables/s-list-shipment.md) |
| 349 | [s\_attachment](../../docs/database/tables/s-attachment.md) |
| 350 | [s\_dyn\_criteria](../../docs/database/tables/s-dyn-criteria.md) |
| 351 | [outbox](../../docs/database/tables/outbox.md) |
| 352 | [inbox](../../docs/database/tables/inbox.md) |
| 353 | [legal\_html\_tags](../../docs/database/tables/legal-html-tags.md) |
| 354 | [kb\_entry\_words](../../docs/database/tables/kb-entry-words.md) |
| 355 | [word\_relations](../../docs/database/tables/word-relations.md) |
| 356 | [temporary\_words](../../docs/database/tables/temporary-words.md) |
| 357 | [wsdl\_description](../../docs/database/tables/wsdl-description.md) |
| 358 | [dictionary](../../docs/database/tables/dictionary.md) |
| 359 | [dictionary\_base](../../docs/database/tables/dictionary-base.md) |
| 360 | [invoice\_entry](../../docs/database/tables/invoice-entry.md) |
| 361 | [invoice\_type](../../docs/database/tables/invoice-type.md) |
| 362 | [soap\_access](../../docs/database/tables/soap-access.md) |
| 363 | [hotlist](../../docs/database/tables/hotlist.md) |
| 364 | [log\_events](../../docs/database/tables/log-events.md) |
| 365 | [log\_debug](../../docs/database/tables/log-debug.md) |
| 366 | [form\_keys](../../docs/database/tables/form-keys.md) |
| 367 | [sms\_hysteria](../../docs/database/tables/sms-hysteria.md) |
| 368 | [item\_config](../../docs/database/tables/item-config.md) |
| 369 | [snapshot](../../docs/database/tables/snapshot.md) |
| 370 | [screen\_definition](../../docs/database/tables/screen-definition.md) |
| 371 | [screen\_definition\_action](../../docs/database/tables/screen-definition-action.md) |
| 372 | [screen\_definition\_element](../../docs/database/tables/screen-definition-element.md) |
| 373 | [screen\_definition\_hidden](../../docs/database/tables/screen-definition-hidden.md) |
| 374 | [screen\_definition\_language](../../docs/database/tables/screen-definition-language.md) |
| 375 | [screen\_chooser](../../docs/database/tables/screen-chooser.md) |
| 376 | [scheduled\_task](../../docs/database/tables/scheduled-task.md) |
| 377 | [ejscript](../../docs/database/tables/ejscript.md) |
| 378 | [system\-script](../../docs/database/tables/system-script.md) |
| 379 | [schedule](../../docs/database/tables/schedule.md) |
| 380 | [locking](../../docs/database/tables/locking.md) |
| 381 | [dbi\_agent](../../docs/database/tables/dbi-agent.md) |
| 382 | [dbi\_agent\_field](../../docs/database/tables/dbi-agent-field.md) |
| 383 | [dbi\_agent\-schedule](../../docs/database/tables/dbi-agent-schedule.md) |
| 384 | [ejpackage](../../docs/database/tables/ejpackage.md) |
| 385 | [ejpackage\_item](../../docs/database/tables/ejpackage-item.md) |
| 386 | [message\_id](../../docs/database/tables/message-id.md) |
| 387 | [ejscript\_debug](../../docs/database/tables/ejscript-debug.md) |
| 388 | [sms](../../docs/database/tables/sms.md) |
| 389 | [user\_candidate](../../docs/database/tables/user-candidate.md) |
| 390 | [s\_smtp\_servers](../../docs/database/tables/s-smtp-servers.md) |
| 391 | [ejselection](../../docs/database/tables/ejselection.md) |
| 392 | [ejsel\_ejsel](../../docs/database/tables/ejsel-ejsel.md) |
| 393 | [ejsel\_source\_idlist](../../docs/database/tables/ejsel-source-idlist.md) |
| 394 | [ejsel\_source\-script](../../docs/database/tables/ejsel-source-script.md) |
| 395 | [ejsel\_source\_xml](../../docs/database/tables/ejsel-source-xml.md) |
| 396 | [static\_list\_ref](../../docs/database/tables/static-list-ref.md) |
| 397 | [ejsel\_meta\_result](../../docs/database/tables/ejsel-meta-result.md) |
| 398 | [ejsel\_result\_set](../../docs/database/tables/ejsel-result-set.md) |
| 399 | [tree\_explorer\_entry](../../docs/database/tables/tree-explorer-entry.md) |
| 400 | [tree\_explorer\_link](../../docs/database/tables/tree-explorer-link.md) |
| 401 | [external\_document](../../docs/database/tables/external-document.md) |
| 402 | [autosave](../../docs/database/tables/autosave.md) |
| 403 | [user\_attribute](../../docs/database/tables/user-attribute.md) |
| 404 | [notice\_frame](../../docs/database/tables/notice-frame.md) |
| 405 | [s\_sent\_message](../../docs/database/tables/s-sent-message.md) |
| 406 | [access\-script](../../docs/database/tables/access-script.md) |
