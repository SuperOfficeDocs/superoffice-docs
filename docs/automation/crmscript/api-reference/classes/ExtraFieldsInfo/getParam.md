---
uid: crmscript_ref_ExtraFieldsInfo_getParam_String_p_0
title: ExtraFieldsInfo.getParam(String p_0)
intellisense: ExtraFieldsInfo.getParam
sortOrder: 308
keywords: getParam(String)
so.topic: reference
---

# ExtraFieldsInfo.getParam(String p_0)

This function returns the value of the given parameter.

## Parameters

The following parameters are available for the various field types:

 - Available for all types:
     - <b>"defaultNow"</b> - use current time and date as default value
     - <b>"defaultActiveUser"</b> - use active user as default value
 - Contact relation, Company relation, Request relation:
     - <b>"targetLabel"</b> - header
 - Extra table relation:
     - <b>"targetLabel"</b> - header
     - <b>"useDropDown"</b> - choose values from list
     - <b>"onlyLeafNode"</b>
 - Float:
    - <b>"precision"</b> - number of decimals
 - Text long:
    - <b>"option"</b>
    - <b>"useTextArea"</b>
    - <b>"height"</b>
 - Text short:
    - <b>"option"</b>
 - Dynamic link:
    - <b>"linkName"</b>
    - <b>"linkValue"</b> - url
 - Timespan:
    - <b>"useDays"</b>
    - <b>"useHours"</b>
    - <b>"useMinutes"</b>
    - <b>"fields"</b> - number of fields

