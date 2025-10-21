---
uid: help-de-system-event-add
title: Systemereignisse hinzufügen
description: Systemereignisse hinzufügen
keywords: Ereignis, Benachrichtigung, Systemereignis
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: howto
deployment: onsite
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /de/admin/learn/system-events
  - /de/admin/learn/add-system-events
language: de
---

# Systemereignisse hinzufügen (Vor Ort)

Sie können manche Systemereignisse von der Liste **Systembenachrichtigungen** aus in der Registerkarte **Status** initiieren.

1. Öffnen Sie die Ansicht Lizenzen.

2. Wählen Sie die Registerkarte **Status**.

3. Klicken Sie unter der Liste auf die Schaltfläche **Hinzufügen** unter **Systembenachrichtigungen**.

4. Wählen Sie im Dialogfeld **Ereignis hinzu** einen [Systemereignistyp](#types) aus dem Listenfeld **Ereignistyp** aus.

5. Geben Sie im Feld **Fertiggestellt** die Uhrzeit ein, zu der das Ereignis voraussichtlich beendet sein wird.

    > [!NOTE]
    > Ereignisse werden nicht automatisch beendet. Sie müssen sie von der Registerkarte **Systemereignisse** entfernen, um sie zu beenden.

6. Geben Sie ausführlichere Informationen zum Ereignis im Feld **Beschreibung** ein.

    > [!NOTE]
    > Wenn Sie ein Ereignis vom Typ **Mitteilung des Tages** (Meldung an alle Benutzer) hinzufügen, wird der Text im Feld **Beschreibung** zusammen mit der erwarteten Endzeit an alle Benutzer gesendet.

7. Klicken Sie auf **Speichern**, um das Ereignis zu erstellen. Es wird in der Liste **Systembenachrichtigungen** auf der Registerkarte **Status** angezeigt.

> [!TIP]
> Zur Bearbeitung doppelklicken Sie auf das Ereignis in der Liste.
>
> Um ein Ereignis zu löschen, wählen Sie es in der Liste an und klicken Sie die Schaltfläche **Löschen**.

## <a id="types"></a>Typen

Folgende Ereignisarten werden von den verschiedenen Ansichten in Einstellungen und Verwaltung gestartet:

* **UDefRebuild**, wovon es verschiedene Arten gibt: Das Layout für benutzerdefinierte Felder wird aktualisiert. Während dieses Ereignis in Bearbeitung ist, kann nicht auf die benutzerdefinierten Felder zugegriffen werden.

    > [!NOTE]
    > Dieses Ereignis dürfen Sie nicht von der Liste **Systembenachrichtigungen** abbrechen.

* **FreetextRebuild**: Die Volltextsuchindex wird generiert und Benutzer können den Volltext nicht verwenden, während die Generierung in Bearbeitung ist.

* **PrototypeRebuild**: Es wird ein Travel-Prototyp generiert. Während dieses Vorgangs kann nicht auf die Travel-Funktionen zugegriffen werden.

    > [!NOTE]
    > In Notfällen können Sie die Ereignisse **FreetextRebuild** und **PrototypeRebuild** von der Liste **Systembenachrichtigungen** abbrechen.

* **ROURebuild**: Zähler oder Statuskontrollen werden erneuert. Statusbilder, die Registerkarte **Statistik** sowie Zähler sind nicht verfügbar, solange das Ereignis aktiv ist. (Für Statuskontrollen ist eine [separate Lizenz][2] erforderlich.)

Sie können folgende Ereignisarten von der Ansicht Lizenzen in der Registerkarte **Status** starten:

* **Keine Anmeldung**: Wählen Sie das Ereignis aus, um zu verhindern, dass sich jemand während einer Server- oder Datenbankaktualisierung, planmäßigen Wartung usw. einloggt.
* **Kein Volltext**: Wählen Sie das Ereignis aus, um die Größe der ausgehenden Travel-Datenbank zu begrenzen.
* **Kein Travel**: Wählen Sie dieses Ereignis aus, um Travel zu deaktivieren. Dies kann direkt vor großen Systemaktualisierungen sehr nützlich sein, da es Synchronisierungsprobleme für regelmäßige Travel-Benutzer verhindert.
* **Mitteilung des Tages**: Wählen Sie dieses Ereignis aus, um wichtige Nachrichten zu erstellen, die für alle, die in SuperOffice CRM angemeldet sind, angezeigt werden (und nach einigen Minuten wird die Mitteilung auch all jenen angezeigt, die bereits angemeldet sind).

<!-- Referenced links -->
[2]: ../../../en/admin/license/index.md

<!-- Referenced images -->
