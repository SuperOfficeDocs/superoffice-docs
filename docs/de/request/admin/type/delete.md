---
uid: help-de-request-type-delete
title: Anfragetyp löschen
description: Anfragetyp löschen
keywords: Anfragetyp löschen, als Standard verwenden, Anfragetyp übertragen auf, Anfragetyp, Anfrage
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/type/delete
---

# Anfragetyp löschen

> [!NOTE]
> Sie können den aktuellen Standardtyp (den mit einem Häkchen im Feld **Als Standard verwenden**) nicht löschen.

## Voraussetzungen

* Falls der zu löschende Typ als Standard verwendet wird, müssen Sie zunächst einen anderen Anfragetyp als Standard setzen. (Bis dies erledigt ist, bleibt die Schaltfläche **Löschen** deaktiviert.)

* Aktualisieren Sie alle [E-Mail-Filter][1] und [Postfächer][2], die diesen Anfragetyp verwenden. Ein Typ, der aktiv genutzt wird, kann nicht gelöscht werden.

  * **Einstellungen und Verwaltung** > **Anfragen** > **E-Mail** > **Eigenschaften festlegen**-Registerkarte
  * **Einstellungen und Verwaltung** > **Anfragen** > **E-Mail** > **Postfächer**-Registerkarte

## Schritte

1. Klicken Sie im Navigator auf **Anfragen** und wählen Sie die Registerkarte **Anfragetypen**.

1. Klicken Sie auf den gewünschten Anfragetyp.

1. Klicken Sie unten auf **Löschen**.

1. Falls Anfragen dieses Typs vorhanden sind, wählen Sie in der Liste **Anfragetyp übertragen auf** einen neuen Typ aus.

1. Klicken Sie auf **OK**, um zu bestätigen. Der Anfragetyp wird gelöscht, und alle zugehörigen Anfragen werden dem angegebenen alternativen Typ zugewiesen.

<!-- Referenced links -->
[1]: ../../../email/service/learn/email-filters/create-email-filter.md
[2]: ../../../email/service/learn/create-mailbox.md
