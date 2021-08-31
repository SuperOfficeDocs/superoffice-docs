---
title: Document
---

# Document

```http
/api/v1/Document
```




* [GET Document/default](v1DocumentEntity_DefaultDocumentEntity.md)

* [GET Document](v1DocumentEntity_GetAll.md)

* [POST Document](v1DocumentEntity_PostDocumentEntity.md)

* [GET Document/{id}](v1DocumentEntity_GetDocumentEntity.md)

* [PUT Document/{id}](v1DocumentEntity_PutDocumentEntity.md)

* [DEL Document/{id}](v1DocumentEntity_DeleteDocumentEntity.md)

* [PATCH Document/{id}](v1DocumentEntity_PatchDocumentEntity.md)

* [GET Document/{id}/Links](v1DocumentEntity_Links.md)

* [GET Document/{id}/Content](v1DocumentEntity_GetDocumentStream.md)

* [PUT Document/{id}/Content](v1DocumentEntity_SetDocumentStreamFromId.md)

* [POST Document/{id}/Content](v1DocumentEntity_CreateNewPhysicalDocumentFromTemplateWithCustomTags2.md)

* [DEL Document/{id}/Content](v1DocumentEntity_DeletePhysicalDocument.md)

* [GET Document/{id}/SanitizedContent](v1DocumentEntity_GetSanitizedDocumentStream.md)

* [GET Document/{id}/Url](v1DocumentEntity_GetDocumentUrl.md)

* [GET Document/{id}/Lock](v1DocumentEntity_GetCheckoutState.md)

* [PUT Document/{id}/Lock](v1DocumentEntity_CheckinDocument.md)

* [POST Document/{id}/Lock](v1DocumentEntity_CheckoutDocument.md)

* [DEL Document/{id}/Lock](v1DocumentEntity_UndoCheckoutDocument.md)

* [GET Document/{id}/Version](v1DocumentEntity_GetVersionList.md)

* [GET Document/Plugin](v1DocumentEntity_GetPluginList.md)

* [GET Document/Plugin/{id}](v1DocumentEntity_GetPluginCapabilities.md)

* [GET Document/{id}/Property](v1DocumentEntity_GetDocumentProperties.md)

* [GET Document/{id}/Command](v1DocumentEntity_GetDocumentCommands.md)

* [POST Document/{id}/Command/{command}](v1DocumentEntity_ExecuteDocumentCommand.md)

* [POST Document/Validate](v1DocumentEntity_ValidateDocumentEntity.md)

* [GET Document/{id}/Length](v1DocumentEntity_GetDocumentLength.md)

* [GET Document/CustomField](v1DocumentEntity_GetCustomFieldInfoList.md)

* [GET Document/CustomField/{fieldName}](v1DocumentEntity_GetCustomFieldInfo.md)

* [GET Document/UdefLayout](v1DocumentEntity_GetUdefLayout.md)

* [PUT Document/UdefLayout](v1DocumentEntity_SaveUdefLayout.md)

* [POST Document/UdefLayout](v1DocumentEntity_AddUdefField.md)

* [GET Document/UdefLayout/Published](v1DocumentEntity_GetPublishedUdefLayout.md)

* [GET Document/UdefLayout/{progidOrLabel}](v1DocumentEntity_GetUdefFieldInfo.md)

* [DEL Document/UdefLayout/{progidOrLabel}](v1DocumentEntity_DeleteUdefFieldInfo.md)

* [POST Document/UdefLayout/{progidOrLabel}/ChangeTo/{fieldType}](v1DocumentEntity_ChangeFieldType.md)

* [GET Document/UdefLayout/Published/{progidOrLabel}](v1DocumentEntity_GetPublishedUdefFieldInfo.md)

* [GET Document/UdefLayout/Changed](v1DocumentEntity_DetectUnpublishedChanges.md)

* [GET Document/UdefLayout/Publish](v1DocumentEntity_IsPublishUdefLayoutActive.md)

* [POST Document/UdefLayout/Publish](v1DocumentEntity_PublishUdefLayout.md)

* [POST Document/UdefLayout/Revert](v1DocumentEntity_RevertUdefLayout.md)

* [GET Document/{id}/ForeignKey](v1DocumentEntity_GetAllForeignKeysOnEntity.md)