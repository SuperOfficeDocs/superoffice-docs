---
uid: help-de-system-events
title: Systemereignisse
description: Systemereignisse
author: SuperOffice RnD
date: 06.29.2022
keywords: Veranstaltung
topic: concept
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Systemereignisse

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

[!include[Terminate events](includes/note-terminate-event.md)]

## Was möchten Sie jetzt tun?

* [Systemereignisse hinzufügen][1]

<!-- Referenced links -->
[1]: add-system-event.md
[2]: https://docs.superoffice.com/en/admin/license/index.html

<!-- Referenced images -->
