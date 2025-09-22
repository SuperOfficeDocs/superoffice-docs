---
uid: help-de-saint-update
title: Aktivitätsüberwachung aktualisieren
description: Aktivitätsüberwachung aktualisieren
keywords: SAINT, Aktivitätsüberwachung, Standardfolgeaufgabe, Statusüberwachung löschen, Statusüberwachung wiederherstellen, Kriterien
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
index: true
redirect_from: 
  - /de/sale/saint/learn/admin/edit-status
  - /de/saint/admin/edit-status
  - /de/sale/saint/learn/admin/select-default-follow-up-type-for-status
  - /de/saint/admin/select-default-follow-up-type-for-status
  - /de/sale/saint/learn/admin/restore-status
  - /de/saint/admin/restore-status
  - /de/sale/saint/learn/admin/select-status-criteria
  - /de/saint/admin/select-status-criteria
---

# Aktivitätsüberwachung aktualisieren

[!include[Requirement](../includes/note-saint-req.md)]

## SAINT-Bildschirm öffnen

Bevor Sie eine der folgenden Aufgaben ausführen, öffnen Sie den Bildschirm **SAINT** in Einstellungen und Verwaltung wählen Sie die Registerkarte **Firma**, **Person** oder **Projekt** aus.

## Statusbeschreibung bearbeiten

Auf der Registerkarte **Beschreibung** wird die Beschreibung angezeigt, die Sie eingegeben haben, wenn Sie die Option [Status erstellen][1] ausgeführt haben.

1. Wählen Sie in der Statusliste den Status aus, dessen Beschreibung Sie bearbeiten möchten.

1. Bearbeiten Sie den Text im Feld **Beschreibung**.

## Standardfolgeaufgabe für einen Status auswählen

Sie können einen Folgeaufgabentyp zu einem Status verknüpfen. Wenn ein Benutzer in die Mitte der Statuskarte klickt, wird automatisch eine Folgeaufgabe geöffnet. Dies kann vorab ausgefüllten Text enthalten, der erklärt, welche Aktion für Firmen, Personen oder Projekte mit diesem Status zu ergreifen ist.

Um einen Standard-Folgeaufgabentyp und eine Beschreibung festzulegen, verwenden Sie die Registerkarte **Folgeaufgabe erstellen**.

1. Wählen Sie den gewünschten Status aus der Statusliste aus.
1. Gehen Sie zur Registerkarte **Folgeaufgabe erstellen**.
1. Wählen Sie einen Folgeaufgabentyp aus der Dropdown-Liste **Typ** aus.
1. Geben Sie die Nachricht ein, die im Folgeaufgaben-Dialogfeld angezeigt werden soll.

![Die Registerkarte 'Folgeaufgabe erstellen' in der SAINT-Statusüberwachung, die die Auswahl des Folgeaufgabentyps und die Eingabe einer benutzerdefinierten Nachricht zeigt. -screenshot][img1]

## <a id="criteria"></a>Kriterien zu einem Status hinzufügen

Jeder Status muss mindestens ein Kriterium haben. Die [Kriterien][2] bestimmen, für welche Firmen, Personen oder Projekte der Status gilt.

1. Wählen Sie in der Statusliste den gewünschten Status aus.

1. Wählen Sie unter der Kriterienliste **Hinzufügen**, um eine neue Zeile einzufügen.

1. Wählen Sie einen Kriterientyp aus der Dropdown-Liste aus.

    ![Kriterienliste mit mehreren definierten Bedingungen und der Schaltfläche Hinzufügen unter der Liste -screenshot][img3]

1. Legen Sie die Bedingung fest (wie **Vor**, **Nach** oder **Gleich**) und geben Sie einen Wert ein.

1. Wiederholen Sie den Vorgang, um weitere Kriterien hinzuzufügen.

    > [!NOTE]
    > Sie können nur eines von jedem Kriterientyp hinzufügen. Sie können beispielsweise das Kriterium **Postleitzahl** nicht zweimal hinzufügen.

1. Wählen Sie <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Ausgewählte Statusangaben aktualisieren**, um die Änderungen anzuwenden.

## <a id="delete"></a>Eine Statusüberwachung löschen

Sie können einen Status aus der Statusüberwachungsliste löschen. Gelöschte Statusangaben können später wiederhergestellt werden.

1. Wählen Sie in der Statusliste den Status aus, den Sie löschen möchten.
1. Klicken Sie unten in der Liste auf **Löschen**.

Der gelöschte Status wird aus der aktiven Liste entfernt, kann aber durch Auswahl von **Gelöschte anzeigen** wieder angezeigt werden.

## <a id="restore"></a>Eine gelöschte Statusüberwachung wiederherstellen

Sie können einen zuvor gelöschten Status wiederherstellen und regenerieren.

1. Wählen Sie unten in der Statusliste **Gelöschte anzeigen** aus.

1. Doppelklicken Sie auf den Status, den Sie wiederherstellen möchten.

    ![Statusüberwachungsdialog geöffnet nach Auswahl eines gelöschten Status, mit sichtbaren Schaltflächen Wiederherstellen und Speichern -screenshot][img2]

1. Wählen Sie im Dialogfeld **Statusüberwachung** **Wiederherstellen** und dann **Speichern** aus.

    Der Status wird wiederhergestellt und in schwarzer Schrift in der Liste angezeigt.

1. Wählen Sie **Ausgewählte Statusüberwachung regenerieren** aus, um den wiederhergestellten Status zu aktualisieren.

<!-- Referenced links -->
[1]: create-status.md
[2]: ../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/saint-create-follow-up-tab.png
[img2]: ../../../media/loc/en/saint/delete-restore-status-monitor.png
[img3]: ../../../media/loc/en/saint/criteria.png
