---
title: changes_6_to_7
description: Table changes from SuperOffice 6 to 7
author: {github-id}
keywords: database
topic: reference
envir: onsite
# client:
version: 7
---

# Table changes from SuperOffice 6.3 to 7.0

## Renamed tables

| Table no | v.6 | v.7 |
|---|---|---|
| 37 | recordlink | [MergeMoveLog](../../docs/en/database/tables/mergemovelog.md) |
| 115 | OptCat | [ReasonSold](../../docs/en/database/tables/reasonsold.md) |
| 116 | OptCatGroupLink | [ReasonSoldGroupLink](../../docs/en/database/tables/reasonsoldgrouplink.md) |
| 117 | OptCatHeadingLink | [ReasonSoldHeadingLink](../../docs/en/database/tables/reasonsoldheadinglink.md) |
| 118 | OptType | [SaleTypeCat](../../docs/en/database/tables/saletypecat.md) |
| 119 | OptTypeGroupLink | [SaleTypeCatGroupLink](../../docs/en/database/tables/saletypecatgrouplink.md) |
| 120 | OptTypeHeadingLink | [SaleTypeCatHeadingLink](../../docs/en/database/tables/saletypecatheadinglink.md) |
| 121 | OptState | [SaleStakeholder](../../docs/en/database/tables/salestakeholder.md) |
| 122 | OptStateGroupLink | [StakeholderRole](../../docs/en/database/tables/stakeholderrole.md) |
| 123 | OptStateHeadingLink | [StakeholderRoleGroupLink](../../docs/en/database/tables/stakeholderrolegrouplink.md) |
| 124 | OptInt | [StakeholderRoleHeadingLink](../../docs/en/database/tables/stakeholderroleheadinglink.md) |
| 125 | OptIntGroupLink | [SuggestedAppointment](../../docs/en/database/tables/suggestedappointment.md) |
| 126 | OptIntHeadingLink | [SuggestedDocument](../../docs/en/database/tables/suggesteddocument.md) |
| 149 | Opportunity | [SaleType](../../docs/en/database/tables/saletype.md) |
| 150 | OptItem | [SaleTypeGroupLink](../../docs/en/database/tables/saletypegrouplink.md) |
| 151 | OptPlan | [SaleTypeHeadingLink](../../docs/en/database/tables/saletypeheadinglink.md) |
| 152 | OptPlanItem | [TabOrder](../../docs/en/database/tables/taborder.md) |
| 154 | SelCriterion | [ReasonStalled](../../docs/en/database/tables/reasonstalled.md) |
| 155 | SelOpChain | [ReasonStalledGroupLink](../../docs/en/database/tables/reasonstalledgrouplink.md) |
| 156 | SelOp | [ReasonStalledHeadingLink](../../docs/en/database/tables/reasonstalledheadinglink.md) |
| 160 | DocumentLink | [SaleTypeStageLink](../../docs/en/database/tables/saletypestagelink.md) |
| 212 | TimeZone | [ModuleOwner](../../docs/en/database/tables/moduleowner.md) |
| 213 | TimeZoneCountry | [ProjectTypeStatusLink](../../docs/en/database/tables/projecttypestatuslink.md) |
| 237 | ModuleLicence | [ModuleLicense](../../docs/en/database/tables/modulelicense.md) |
| 238 | LicenceAssocLink | [LicenseAssocLink](../../docs/en/database/tables/licenseassoclink.md) |
| 239 | LicenceSatlLink | [LicenseSatlLink](../../docs/en/database/tables/licensesatllink.md)

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
| 253 | [registry](../../docs/en/database/tables/registry.md) |
| 254 | [session\_object](../../docs/en/database/tables/session-object.md) |
| 255 | [config](../../docs/en/database/tables/config.md) |
| 256 | [ticket\_attachment](../../docs/en/database/tables/ticket-attachment.md) |
| 257 | [ej\_category](../../docs/en/database/tables/ej-category.md) |
| 258 | [ej\_message](../../docs/en/database/tables/ej-message.md) |
| 259 | [message\_header](../../docs/en/database/tables/message-header.md) |
| 260 | [message\_customers](../../docs/en/database/tables/message-customers.md) |
| 261 | [ticket\_status\_history](../../docs/en/database/tables/ticket-status-history.md) |
| 262 | [ticket](../../docs/en/database/tables/ticket.md) |
| 263 | [ticket\_status](../../docs/en/database/tables/ticket-status.md) |
| 264 | [ticket\_customers](../../docs/en/database/tables/ticket-customers.md) |
| 265 | [invoice](../../docs/en/database/tables/invoice.md) |
| 266 | [invoice\_sum](../../docs/en/database/tables/invoice-sum.md) |
| 267 | [ticket\_log](../../docs/en/database/tables/ticket-log.md) |
| 268 | [ticket\_log\_change](../../docs/en/database/tables/ticket-log-change.md) |
| 269 | [ticket\_log\_action](../../docs/en/database/tables/ticket-log-action.md) |
| 270 | [category\_membership](../../docs/en/database/tables/category-membership.md) |
| 271 | [mail\_in\_filter](../../docs/en/database/tables/mail-in-filter.md) |
| 272 | [mail\_in\_uidl](../../docs/en/database/tables/mail-in-uidl.md) |
| 273 | [mail\_alias](../../docs/en/database/tables/mail-alias.md) |
| 274 | [ticket\_alert](../../docs/en/database/tables/ticket-alert.md) |
| 275 | [ticket\_priority](../../docs/en/database/tables/ticket-priority.md) |
| 276 | [reply\_template\_folder](../../docs/en/database/tables/reply-template-folder.md) |
| 277 | [reply\_template](../../docs/en/database/tables/reply-template.md) |
| 278 | [reply\_template\_attachment](../../docs/en/database/tables/reply-template-attachment.md) |
| 279 | [reply\_template\_body](../../docs/en/database/tables/reply-template-body.md) |
| 280 | [doc\_document](../../docs/en/database/tables/doc-document.md) |
| 281 | [doc\_folder](../../docs/en/database/tables/doc-folder.md) |
| 282 | [kb\_entry](../../docs/en/database/tables/kb-entry.md) |
| 283 | [kb\_category](../../docs/en/database/tables/kb-category.md) |
| 284 | [kb\_attachment](../../docs/en/database/tables/kb-attachment.md) |
| 285 | [kb\_http\_link](../../docs/en/database/tables/kb-http-link.md) |
| 286 | [kb\_group](../../docs/en/database/tables/kb-group.md) |
| 287 | [kb\_group\_entry](../../docs/en/database/tables/kb-group-entry.md) |
| 288 | [kb\_entry\_keyword](../../docs/en/database/tables/kb-entry-keyword.md) |
| 289 | [kb\_entry\_comment](../../docs/en/database/tables/kb-entry-comment.md) |
| 290 | [kb\_entry\_log](../../docs/en/database/tables/kb-entry-log.md) |
| 291 | [kb\_category\_log](../../docs/en/database/tables/kb-category-log.md) |
| 292 | [kb\_workflow](../../docs/en/database/tables/kb-workflow.md) |
| 293 | [kb\_workflow\_access](../../docs/en/database/tables/kb-workflow-access.md) |
| 294 | [kb\_solution\_finder](../../docs/en/database/tables/kb-solution-finder.md) |
| 295 | [kb\_solution\_finder\_entry](../../docs/en/database/tables/kb-solution-finder-entry.md) |
| 296 | [attachment](../../docs/en/database/tables/attachment.md) |
| 297 | [login](../../docs/en/database/tables/login.md) |
| 298 | [login\_customer](../../docs/en/database/tables/login-customer.md) |
| 299 | [ejuser](../../docs/en/database/tables/ejuser.md) |
| 300 | [timestamps](../../docs/en/database/tables/timestamps.md) |
| 301 | [notify](../../docs/en/database/tables/notify.md) |
| 302 | [help](../../docs/en/database/tables/help.md) |
| 303 | [company\_domain](../../docs/en/database/tables/company-domain.md) |
| 304 | [extra\_fields](../../docs/en/database/tables/extra-fields.md) |
| 305 | [extra\_tables](../../docs/en/database/tables/extra-tables.md) |
| 306 | [hierarchy](../../docs/en/database/tables/hierarchy.md) |
| 307 | [extra\_menus](../../docs/en/database/tables/extra-menus.md) |
| 308 | [extra\_tables\_result](../../docs/en/database/tables/extra-tables-result.md) |
| 309 | [extra\_tables\_entry](../../docs/en/database/tables/extra-tables-entry.md) |
| 310 | [ms\_filter](../../docs/en/database/tables/ms-filter.md) |
| 311 | [ms\_filter\_mail](../../docs/en/database/tables/ms-filter-mail.md) |
| 312 | [ms\_trashbin](../../docs/en/database/tables/ms-trashbin.md) |
| 313 | [ms\_substitute](../../docs/en/database/tables/ms-substitute.md) |
| 314 | [eab\_folder](../../docs/en/database/tables/eab-folder.md) |
| 315 | [eab\_entry](../../docs/en/database/tables/eab-entry.md) |
| 316 | [mail\_block](../../docs/en/database/tables/mail-block.md) |
| 317 | [ext\_datasource](../../docs/en/database/tables/ext-datasource.md) |
| 318 | [ext\_table](../../docs/en/database/tables/ext-table.md) |
| 319 | [ext\_field](../../docs/en/database/tables/ext-field.md) |
| 320 | [cust\_lang](../../docs/en/database/tables/cust-lang.md) |
| 321 | [cust\_category](../../docs/en/database/tables/cust-category.md) |
| 322 | [password\_rules](../../docs/en/database/tables/password-rules.md) |
| 323 | [ej\_role](../../docs/en/database/tables/ej-role.md) |
| 324 | [role\_member](../../docs/en/database/tables/role-member.md) |
| 325 | [role\_category](../../docs/en/database/tables/role-category.md) |
| 326 | [role\_element](../../docs/en/database/tables/role-element.md) |
| 327 | [role\_workflow](../../docs/en/database/tables/role-workflow.md) |
| 328 | [element\_profile](../../docs/en/database/tables/element-profile.md) |
| 329 | [profile](../../docs/en/database/tables/profile.md) |
| 330 | [chat\_topic](../../docs/en/database/tables/chat-topic.md) |
| 331 | [chat\_topic\_user](../../docs/en/database/tables/chat-topic-user.md) |
| 332 | [chat\_session](../../docs/en/database/tables/chat-session.md) |
| 333 | [chat\_message](../../docs/en/database/tables/chat-message.md) |
| 334 | [s\_shipment](../../docs/en/database/tables/s-shipment.md) |
| 335 | [s\_message](../../docs/en/database/tables/s-message.md) |
| 336 | [s\_link](../../docs/en/database/tables/s-link.md) |
| 337 | [s\_link\_customer](../../docs/en/database/tables/s-link-customer.md) |
| 338 | [s\_link\_customer\_statical](../../docs/en/database/tables/s-link-customer-statical.md) |
| 339 | [s\_picture\_folder](../../docs/en/database/tables/s-picture-folder.md) |
| 340 | [s\_picture\_entry](../../docs/en/database/tables/s-picture-entry.md) |
| 341 | [s\_washing](../../docs/en/database/tables/s-washing.md) |
| 342 | [s\_bounce\_shipment](../../docs/en/database/tables/s-bounce-shipment.md) |
| 343 | [s\_washing\_list](../../docs/en/database/tables/s-washing-list.md) |
| 344 | [s\_list](../../docs/en/database/tables/s-list.md) |
| 345 | [s\_list\_element](../../docs/en/database/tables/s-list-element.md) |
| 346 | [s\_list\_customer](../../docs/en/database/tables/s-list-customer.md) |
| 347 | [s\_shipment\_addr](../../docs/en/database/tables/s-shipment-addr.md) |
| 348 | [s\_list\_shipment](../../docs/en/database/tables/s-list-shipment.md) |
| 349 | [s\_attachment](../../docs/en/database/tables/s-attachment.md) |
| 350 | [s\_dyn\_criteria](../../docs/en/database/tables/s-dyn-criteria.md) |
| 351 | [outbox](../../docs/en/database/tables/outbox.md) |
| 352 | [inbox](../../docs/en/database/tables/inbox.md) |
| 353 | [legal\_html\_tags](../../docs/en/database/tables/legal-html-tags.md) |
| 354 | [kb\_entry\_words](../../docs/en/database/tables/kb-entry-words.md) |
| 355 | [word\_relations](../../docs/en/database/tables/word-relations.md) |
| 356 | [temporary\_words](../../docs/en/database/tables/temporary-words.md) |
| 357 | [wsdl\_description](../../docs/en/database/tables/wsdl-description.md) |
| 358 | [dictionary](../../docs/en/database/tables/dictionary.md) |
| 359 | [dictionary\_base](../../docs/en/database/tables/dictionary-base.md) |
| 360 | [invoice\_entry](../../docs/en/database/tables/invoice-entry.md) |
| 361 | [invoice\_type](../../docs/en/database/tables/invoice-type.md) |
| 362 | [soap\_access](../../docs/en/database/tables/soap-access.md) |
| 363 | [hotlist](../../docs/en/database/tables/hotlist.md) |
| 364 | [log\_events](../../docs/en/database/tables/log-events.md) |
| 365 | [log\_debug](../../docs/en/database/tables/log-debug.md) |
| 366 | [form\_keys](../../docs/en/database/tables/form-keys.md) |
| 367 | [sms\_hysteria](../../docs/en/database/tables/sms-hysteria.md) |
| 368 | [item\_config](../../docs/en/database/tables/item-config.md) |
| 369 | [snapshot](../../docs/en/database/tables/snapshot.md) |
| 370 | [screen\_definition](../../docs/en/database/tables/screen-definition.md) |
| 371 | [screen\_definition\_action](../../docs/en/database/tables/screen-definition-action.md) |
| 372 | [screen\_definition\_element](../../docs/en/database/tables/screen-definition-element.md) |
| 373 | [screen\_definition\_hidden](../../docs/en/database/tables/screen-definition-hidden.md) |
| 374 | [screen\_definition\_language](../../docs/en/database/tables/screen-definition-language.md) |
| 375 | [screen\_chooser](../../docs/en/database/tables/screen-chooser.md) |
| 376 | [scheduled\_task](../../docs/en/database/tables/scheduled-task.md) |
| 377 | [ejscript](../../docs/en/database/tables/ejscript.md) |
| 378 | [system\-script](../../docs/en/database/tables/system-script.md) |
| 379 | [schedule](../../docs/en/database/tables/schedule.md) |
| 380 | [locking](../../docs/en/database/tables/locking.md) |
| 381 | [dbi\_agent](../../docs/en/database/tables/dbi-agent.md) |
| 382 | [dbi\_agent\_field](../../docs/en/database/tables/dbi-agent-field.md) |
| 383 | [dbi\_agent\-schedule](../../docs/en/database/tables/dbi-agent-schedule.md) |
| 384 | [ejpackage](../../docs/en/database/tables/ejpackage.md) |
| 385 | [ejpackage\_item](../../docs/en/database/tables/ejpackage-item.md) |
| 386 | [message\_id](../../docs/en/database/tables/message-id.md) |
| 387 | [ejscript\_debug](../../docs/en/database/tables/ejscript-debug.md) |
| 388 | [sms](../../docs/en/database/tables/sms.md) |
| 389 | [user\_candidate](../../docs/en/database/tables/user-candidate.md) |
| 390 | [s\_smtp\_servers](../../docs/en/database/tables/s-smtp-servers.md) |
| 391 | [ejselection](../../docs/en/database/tables/ejselection.md) |
| 392 | [ejsel\_ejsel](../../docs/en/database/tables/ejsel-ejsel.md) |
| 393 | [ejsel\_source\_idlist](../../docs/en/database/tables/ejsel-source-idlist.md) |
| 394 | [ejsel\_source\-script](../../docs/en/database/tables/ejsel-source-script.md) |
| 395 | [ejsel\_source\_xml](../../docs/en/database/tables/ejsel-source-xml.md) |
| 396 | [static\_list\_ref](../../docs/en/database/tables/static-list-ref.md) |
| 397 | [ejsel\_meta\_result](../../docs/en/database/tables/ejsel-meta-result.md) |
| 398 | [ejsel\_result\_set](../../docs/en/database/tables/ejsel-result-set.md) |
| 399 | [tree\_explorer\_entry](../../docs/en/database/tables/tree-explorer-entry.md) |
| 400 | [tree\_explorer\_link](../../docs/en/database/tables/tree-explorer-link.md) |
| 401 | [external\_document](../../docs/en/database/tables/external-document.md) |
| 402 | [autosave](../../docs/en/database/tables/autosave.md) |
| 403 | [user\_attribute](../../docs/en/database/tables/user-attribute.md) |
| 404 | [notice\_frame](../../docs/en/database/tables/notice-frame.md) |
| 405 | [s\_sent\_message](../../docs/en/database/tables/s-sent-message.md) |
| 406 | [access\-script](../../docs/en/database/tables/access-script.md) |
