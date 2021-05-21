---
title: SOProtocol and web panels - web
uid: so_protocol_webpanel_web
description: SoProtocol and web panels - web
author:
so.date:
keywords:
so.topic: reference
---

# SOProtocol and web panels - web

<!-- TODO rewrite -->

[dialog=stop]

[mode=display|edit] (issues via crossmessaging, in app javascript)

* info[mode=edit]

[refresh=false]

[usesuperstatecopy=true] (disconnect dialog from current updates)

* Only for dialogs use.

Normal operation is to refresh card, but refresh is used to stop
rerendering card, but still update the current (superstate).

Can force card refresh by setting to true.

webPaneName[refresh=false].minipreview?appointment_id=245

Use SoProtocol to set the currents...

Currents are History Items:
person_id =>

person:

* id
* name: shortcut to reduce access to the DB, list items contain IDs and name.
* type: used for different things. (differentiate)
  * associate or resource

<!-- Explain how to use soprotocol elements/parameters to pre-set fields in new entities, i.e.
soprotocol:document?contact_id=395678&person_id=1198581&document_id=0&task_idx=123 -->

<!-- Referenced links -->
