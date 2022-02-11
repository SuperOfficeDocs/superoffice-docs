---
title: Databinding with SoListBox
uid: pb_databinding_solistbox
description: Databinding with SoListBox
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Databinding with SoListBox

The HTML code segment below shows how we can configure a SoListBox. This code segment is taken from the *SoProjectMemberPickPage.config* file. The SoListBox ID is set as a *leftListBox*. AddMembersDataHandler is the datahandler, which has been bound to the control, to retrieve the data.

```XML
<control id="leftListBox" type="SoListBox" position="absolute" top="30px" width="100%" bottom="0px">
  <datasource>AddMembersDataHandler.ContactPersonList</datasource>
  <config>
    <noupdatedatasource>true</noupdatedatasource>
    <multiselect>true</multiselect>
    <ondblclick>javascript:copySelectedProjectMemberRows(leftListBox_List_ListParser,SelectionMembersArchiveArchiveControl,'contactMDO','projectFuncMDO','desc','selectionMemberHidden');</ondblclick>
  </config>
</control>
```

1. When the user clicks the **Project** button, an **Add** button is shown in the ProjectMembers archive panel.
2. When we click on the **Add** button, a new window will open:

![02][img1]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image002.jpg
