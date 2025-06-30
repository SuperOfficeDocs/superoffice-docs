---
uid: help-de-preferences-manage
title: Arbeiten mit Einstellungen
description: "Wie man Einstellungen hinzufügt, bearbeitet und löscht."
author: Bergfrid Dias
date: 03.21.2023
keywords: Optionen, Einstellung
content_type: howto
language: de
---

# Arbeiten mit Einstellungen

## Gehen Sie zur Einstellung, die Sie aktualisieren möchten

1. [!include[Open preferences](includes/open-preferences.md)]
2. Wählen Sie im Listenfeld oben die gewünschte Einstellungsgruppe aus.
3. Wählen Sie in der Liste **Einstellungen** die gewünschte Einstellung aus.

    Die bereits für diese Einstellung definierten Optionen werden im Feld **Aktive Einstellungen** angezeigt. Wenn dieses Feld leer ist, kann es sein, dass Sie nicht für alle Ebenen die anzuzeigenden Optionen aktiviert haben.

> [!TIP]
> Suchen Sie mithilfe des Feldes **Volltextsuche** im oberen Abschnitt der Ansicht nach der Einstellung, die Sie ändern möchten. Die Suchergebnisse werden in der Liste unten angezeigt.

## Einstellungsoptionen hinzufügen

1. Gehen Sie zur Einstellung, der Sie eine neue Einstellung hinzufügen möchten.

1. Klicken Sie unten in der Ansicht auf die Schaltfläche **Hinzufügen**.

1. Wählen Sie im Dialogfeld **Einstellung** unter **Diese Einstellung gilt für** aus, für [welche Stufe][2] die Option gelten soll: das gesamte System, eine Datenbank, eine Benutzergruppe oder einen einzelnen Benutzer.

    > [!NOTE]
    > Wenn eine oder mehrere Optionen deaktiviert sind, können Sie diese nicht für die Einstellung auswählen.

1. Wählen Sie je nach der oben ausgewählten Option den Namen der gewünschten Datenbank, der Gruppe oder des Benutzers aus.

    > [!NOTE]
    > Wenn Sie **System** gewählt haben, wird das Feld **Ziel** automatisch ausgefüllt, da es nur ein System gibt.

1. Der Name des Felds unter **Wert** hängt von der betreffenden Einstellung ab. Geben Sie hier den Wert der Option je nach Einstellungstyp direkt ein, wählen Sie ihn aus einer vordefinierten Liste aus oder nehmen Sie eine Auswahl in einem Auswahlfeld vor.

1. Wenn Sie unter **Diese Einstellung gilt für** eine andere als die niedrigste Ebene wählen, können Sie unten im Dialogfeld die Option **Einstellungen auf unteren Ebenen entfernen** aktivieren, wenn Sie die Optionen auf allen niedrigeren Ebenen entfernen möchten. Die neue Einstellung überschreibt dann die für niedrigere Ebenen festgelegten Einstellungen.

1. Klicken Sie auf **Speichern**. Die Option ist dann für die Benutzer bei ihrem nächsten Einloggen bei SuperOffice CRM verfügbar.

> [!NOTE]
> Einstellungen mit aktiven individuellen Einstelloptionen werden in der Liste mit den Einstellungen in Fettschrift angezeigt.

## <a id="edit"></a>Einstellungsoptionen bearbeiten

1. Gehen Sie zur Einstellung, die Sie aktualisieren möchten.

1. Doppelklicken Sie auf die Option, die Sie ändern möchten.

1. Aktualisieren Sie die Felder wie gewünscht.

1. Klicken Sie auf **Speichern**. Die Option ist dann für die Benutzer bei ihrem nächsten Einloggen bei SuperOffice CRM verfügbar.

    > [!NOTE]
    > Wenn Sie die Änderungen verwerfen möchten, klicken Sie auf **Abbrechen**.

## <a id="personal"></a>Individuelle Einstellungen zulassen

1. Gehen Sie zur Einstellung, die Sie im Menü **Persönliche Einstellungen** verfügbar machen möchten.

1. Aktivieren Sie das Kontrollkästchen **Individuelle Einstellungen zulassen**. Die Einstellung wird dann im Dialogfeld **Einstellungen** angezeigt, und jede Person kann die Einstellungen für ihre eigene Verwendung bearbeiten.

> [!NOTE]
> Die Einstellungen auf Benutzerebene sind nicht für alle Einstellungsoptionen verfügbar.

## Einstellungsoptionen löschen

1. Gehen Sie zur Einstellung, von der Sie eine Einstellung löschen möchten.

1. Wählen Sie eine oder mehrere Einstellungen aus, die Sie löschen möchten, und klicken Sie am unteren Fensterrand auf **Löschen**. Alle ausgewählten Einstellungen werden von der Liste entfernt.

<!-- Referenced links -->
[2]: index.md#levels

<!-- Referenced images -->
