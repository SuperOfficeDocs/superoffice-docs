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
  - /de/saint/admin/create-status
---

# Neue Aktivitätsüberwachung einrichten

[!include[Requirement](../includes/note-saint-req.md)]

Mit der Statusüberwachung sehen Sie auf einen Blick alle Kunden, die Aufmerksamkeit benötigen.

Um einen Status zu erstellen, definieren Sie seinen Namen und seine Beschreibung, fügen mindestens ein Kriterium hinzu und geben optional eine Priorität, einen Standard-Ereignistyp oder ein Bild an. Die folgenden Schritte zeigen den gesamten Prozess.

## Schritte

1. Öffnen Sie die Ansicht **SAINT** unter Einstellungen und Verwaltung und wählen Sie die Registerkarte **Firma**, **Person** oder **Projekt**.

1. Klicken Sie auf **Hinzufügen** unter der Liste **Statusüberwachung**.

1. Füllen Sie im Dialogfeld folgende Felder aus:

    * **Name:** Geben Sie einen beschreibenden Namen für den Status ein, den Sie hinzufügen möchten.
        Optional: Wählen Sie <i class="ph ph-translate" aria-label="Translate"></i>, um [Übersetzungen hinzuzufügen][8] des Statusnamens.

    * **Beschreibung:** Geben Sie eine klare Beschreibung des Status und der erforderlichen oder empfohlenen Maßnahme ein. Sie können auch [Vorlagenvariablen][9] verwenden, um den Text an die Firma, Person oder das Projekt anzupassen.

    ![New status monitor dialog -screenshot][img1]

    Der Name und die Beschreibung werden in SuperOffice CRM angezeigt, wenn der Benutzer mit der Maus über das Statusbild fährt oder das Status-Dialogfeld öffnet. Sie können die Beschreibung später bearbeiten.

1. Klicken Sie auf **Speichern**. Wählen Sie dann den neuen Status in der Liste aus, um mit der Konfiguration fortzufahren.

1. **Kriterien für den Status festlegen:**

    1. Wählen Sie unter der Kriterienliste **Hinzufügen**, um ein neues Kriterium einzufügen.
    1. Wählen Sie einen Kriterientyp, stellen Sie die Bedingung ein und geben Sie einen Wert an.

    ![Criteria list with multiple conditions defined and the Add button below the list -screenshot][img3]

    Jeder Status muss mindestens ein Kriterium enthalten. Wiederholen Sie den Vorgang bei Bedarf, um weitere hinzuzufügen.

1. *(Optional)* [Definieren Sie einen Standard-Ereignistyp][2] für den Status in der Registerkarte **Folgeaufgabe erstellen**.

1. *(Optional)* [Wählen Sie ein Bild zur Visualisierung des Status](#image).

1. Wenn mehrere Status in der Liste vorhanden sind, stellen Sie die **Priorität** ein, um zu steuern, welches Statusbild auf der Karte angezeigt wird.
    Eine Firma, Person oder ein Projekt kann die Kriterien für mehrere Status erfüllen, aber nur ein Bild kann angezeigt werden.
    Wählen Sie einen Status aus und verwenden Sie die Pfeilschaltflächen unter der Liste, um ihn nach oben oder unten zu verschieben.

    ![List of status monitors with priorities -screenshot][img2]

1. Wenn Sie fertig sind, wählen Sie <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Ausgewählte Statusüberwachung regenerieren**, um den Status zu aktivieren.

## <a id="image"></a>Ein Bild für einen Status auswählen

Sie können ein Bild hinzufügen, das auf Firmen-, Personen- oder Projektkarten angezeigt wird, die die Statuskriterien erfüllen. Das Bild wird als helles Wasserzeichen (40% Transparenz) angezeigt, sodass es andere Inhalte nicht verdeckt.

Das Hinzufügen eines Bildes ist optional. Es kann helfen, Aufmerksamkeit zu erregen und die Art der Folgeaktion zu symbolisieren, die Benutzer durchführen sollen. Wenn Sie den Status nur für Suchen oder Selektionen verwenden möchten, können Sie ihn ohne Bild lassen.

1. Wählen Sie in der Statusliste den gewünschten Status aus.
1. Aktivieren Sie auf der rechten Seite der Ansicht **Visualisieren**, um das Bild anzuzeigen.
1. Wählen Sie **Bild ändern**.
1. Führen Sie einen der folgenden Schritte aus:
    * Wählen Sie eines der vorhandenen Bilder aus der Liste **Bilder**.
    * Wählen Sie **Hinzufügen**, laden Sie eine Datei hoch, geben Sie eine Beschreibung ein und wählen Sie **Speichern**.
1. Wählen Sie **OK** zur Bestätigung.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Verwenden Sie einfache, helle Bilder, die den Status auf sinnvolle Weise darstellen. Ein Spinnennetz kann beispielsweise Inaktivität symbolisieren.

## Vorlagenvariablen in Beschreibungen verwenden

Sie können Vorlagenvariablen im Feld **Beschreibung** verwenden, um den Text zu personalisieren, der in Folgeaufgaben oder Statusdialogen angezeigt wird. Variablen werden durch Informationen aus der Firma, der Person oder dem Projekt ersetzt.

### Beispiel

Ein Status könnte sich zum Beispiel auf Firmen beziehen, die folgende Kriterien erfüllen:

* Kategorie = Kunde
* Letzter Verkauf älter als 2 Monate
* Anzahl der Verkäufe größer als 50

Der Text im Feld **Beschreibung** könnte wie folgt lauten:

"&lt;name&gt; war früher ein guter Kunde, aber wir haben seit 2 Monaten nichts an sie verkauft. &lt;cont&gt; ist der Hauptkontakt für diesen Kunden und sollte den Kunden bald telefonisch (&lt;cpho&gt;) oder per E-Mail (&lt;mail&gt;) kontaktieren, um herauszufinden warum."

In diesem Beispiel werden folgende Vorlagenvariablen verwendet:

| Variable | Beschreibung |
|---|---|
| name | Der Name der Firma |
| cont | Der Name unseres Kontakts für die Firma |
| cpho | Die Telefonnummer der Firma |
| mail | Die E-Mail-Adresse der Firma |

## Verwandte Inhalte

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
