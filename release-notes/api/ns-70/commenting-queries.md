---
title: NewSelect
uid: whats_new_70_newselect
description: NetServer 7.0
author: SuperOffice Product and Engineering
date: 11.05.2016
keywords:
content_type: release-note
---

# NetServer 7.0

The code says

```SQL
Select q = S.NewSelect(”comment”);
```

The generated SQL will start with

```SQL
/* comment */
```

This can be a powerful debugging/forensic tool. "Where is this query coming from" is suddenly easier to answer.

Please use this feature!
