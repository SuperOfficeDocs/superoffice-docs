---
uid: help-de-saint-setup
title: Neue Aktivitätsüberwachung einrichten
description: Neue Aktivitätsüberwachung einrichten
keywords: SAINT, Aktivitätsüberwachung, Statusüberwachung
author: SuperOffice Product and Engineering
date: 09.23.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
index: true
redirect_from: 
  - /de/sale/saint/learn/admin/create-status
  - /de/sale/saint/learn/admin/select-image-for-status
  - /de/saint/admin/select-image-for-status
---

# Neue Aktivitätsüberwachung einrichten

[!include[Requirement](../includes/note-saint-req.md)]

Mit dieser Statusüberwachung sehen Sie leicht alle Kunden, die Ihre Aufmerksamkeit verlangen.

Um einen Status zu erstellen, definieren Sie seinen Namen und die Beschreibung, fügen mindestens ein Kriterium hinzu und legen optional eine Priorität, einen Standard-Folgeaufgabentyp oder ein Bild fest. Die folgenden Schritte zeigen den gesamten Prozess.

## Schritte

1. Öffnen Sie die Anzeige **SAINT** in Einstellungen und Verwaltung und wählen Sie die Registerkarte **Firma**, **Person** oder **Projekt** aus.

1. Klicken Sie unter der Liste **Statusüberwachung** auf **Hinzufügen**.

1. Füllen Sie im Dialogfeld diese Felder aus:

    * **Name:** Geben Sie einen beschreibenden Namen für den hinzuzufügenden Status ein.
        Optional: Wählen Sie <i class="ph ph-translate" aria-label="Translate"></i> aus, um [Übersetzungen][8] des Statusnamens hinzuzufügen.

    * **Beschreibung:** Geben Sie eine klare Beschreibung des Status und der erforderlichen oder empfohlenen Aktion ein. Sie können auch [Vorlagenvariablen][9] verwenden, um den Text an die Firma, Person oder das Projekt anzupassen.

    ![New status monitor dialog -screenshot][img1]

    Name und Beschreibung werden in SuperOffice CRM angezeigt, wenn der Benutzer mit dem Mauszeiger über das Statusbild fährt oder den Statusdialog öffnet. Sie können später die Beschreibung bearbeiten.

1. Klicken Sie auf **Speichern**. Wählen Sie dann den neuen Status in der Liste aus, um mit der Einrichtung fortzufahren.

1. **Kriterien für den Status festlegen:**

    1. Wählen Sie unter der Kriterienliste **Hinzufügen** aus, um ein neues Kriterium einzufügen.
    1. Wählen Sie einen Kriteriumtyp aus, stellen Sie die Bedingung ein und geben Sie einen Wert ein.

    ![Criteria list with multiple conditions defined and the Add button below the list -screenshot][img3]

    Jeder Status muss mindestens ein Kriterium enthalten. Wiederholen Sie den Vorgang nach Bedarf, um weitere hinzuzufügen.

1. *(Optional)* [Definieren Sie einen Standard-Folgeaufgabentyp][2] für den Status auf der Registerkarte **Folgeaufgabe erstellen**.

1. *(Optional)* [Wählen Sie ein Bild aus, um den Status zu visualisieren](#image).

1. Wenn es mehrere Status in der Liste gibt, legen Sie die **Priorität** fest, um zu steuern, welches Statusbild auf der Karte angezeigt wird.
    Eine Firma, eine Person oder ein Projekt kann die Kriterien für mehrere Status erfüllen, aber es kann nur ein Bild angezeigt werden.
    Wählen Sie einen Status aus und verwenden Sie die Pfeiltasten unter der Liste, um ihn nach oben oder unten zu verschieben.

    ![List of status monitors with priorities -screenshot][img2]

1. Wenn Sie fertig sind, wählen Sie <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Ausgewählte Statusüberwachung regenerieren** aus, um den Status zu aktivieren.

## <a id="image"></a>Ein Bild für einen Status auswählen

Sie können ein Bild hinzufügen, das auf Firmen-, Personen- oder Projektkarten angezeigt wird, die den Statuskriterien entsprechen. Das Bild erscheint als helles Wasserzeichen (40% Transparenz), sodass es andere Inhalte nicht verdeckt.

Das Hinzufügen eines Bildes ist optional. Es kann dazu beitragen, Aufmerksamkeit zu erregen und die Art der Folgeaktion zu symbolisieren, die Benutzer ausführen sollen. Wenn Sie den Status nur für Suchen oder Selektionen verwenden möchten, können Sie ihn ohne Bild belassen.

1. Wählen Sie in der Statusliste den gewünschten Status aus.
1. Aktivieren Sie auf der rechten Seite des Bildschirms **Darstellen**, um das Bild anzuzeigen.
1. Wählen Sie **Bild ändern**.
1. Führen Sie einen der folgenden Schritte aus:
    * Wählen Sie eines der vorhandenen Bilder aus der Liste **Bilder** aus.
    * Wählen Sie **Hinzufügen**, laden Sie eine Datei hoch, geben Sie eine Beschreibung ein und wählen Sie **Speichern**.
1. Wählen Sie **OK** zur Bestätigung.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Verwenden Sie einfache, helle Bilder, die den Status sinnvoll darstellen. Ein Spinnennetz kann beispielsweise Inaktivität symbolisieren.

## Verwandte Themen

* [Statusüberwachung aktualisieren, löschen und wiederherstellen][2]
* [Zähler und Zählereinstellungen (Zeitraum)][7]
* [Statusüberwachung und Zähler regenerieren][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png
