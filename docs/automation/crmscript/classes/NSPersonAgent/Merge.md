---
title: crmscript_ref_NSPersonAgent_Merge_Integer_p_0_Integer_p_1_DateTime_p_2_Bool_p_3_Bool_p_4
description: NSPersonAgent.Merge(Integer p_0, Integer p_1, DateTime p_2, Bool p_3, Bool p_4)
intellisense: NSPersonAgent.Merge
keywords: Merge(Integer,Integer,DateTime,Bool,Bool)
so.topic: reference
---


Merge two persons. The destination person will remain. You must specify the date after which activities will be moved along with the person.



* **sourcePersonId:** The identifier for the person which will be merged into the destination person. The source person is deleted/marked retired after the merge.
* **destinationPersonId:** The identifier for the person which will remain after the merge. The target person is updated.
* **moveAfterDate:** Merge activites after this date. Activities before this date are left alone.
* **deleteSource:** If true, the source person will be deleted after the merge. If false, it will have its retired flag set
* **replaceEmptyFieldsOnDestination:** If true, empty fields on destination will be replaced by values from source.


