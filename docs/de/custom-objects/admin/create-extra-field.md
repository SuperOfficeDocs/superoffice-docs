---
uid: help-de-extra-fields-create
title: Zusatzfelder hinzufügen
description: Zusatzfelder hinzufügen
keywords: Zusatzfeld, Zusatztabelle, Datenbankfeld
author: Bergfrid Dias
date: 04.09.2024
version: 10.3.4
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Zusatzfelder hinzufügen

Nachdem Sie eine [Zusatztabelle][1] erstellt haben, müssen Sie Felder in der Tabelle einrichten, damit Sie anschließend Daten (Einträge) in die Tabelle eingeben können. Sie können auch Zusatzfelder in Standardtabellen erstellen.

## Schritte

1. [!include[Zu Tabellen gehen](includes/goto-tables.md)]

1. zeigen Sie auf den Tabellennamen und klicken Sie auf **Neues Feld**.

    ![Extra Feld erstellen -screenshot][img1]

1. Wählen Sie einen Typ für das neue Feld und klicken Sie auf **OK**.

1. In der Ansicht **Eigenschaften des Feldes**, geben Sie Daten über das neue Feld ein.

    * Geben Sie einen *Namen* ein, der als Bezeichnung verwendet wird.
    * Geben Sie ein *Datenbankfeld* ein, das mit **x_** beginnt, um es im Schema zu identifizieren.
    * Optional setzen Sie andere Eigenschaften. Der Typ (in Schritt 3 festgelegt) bestimmt, was verfügbar ist. Siehe Details zu den Feldern unten.

    > [!TIP]
    > Um ein Feld obligatorisch zu machen, wählen Sie **Darf nicht leer sein**.

1. Klicken Sie auf **OK**, um das neue Feld zu speichern (führt `alter table y_mynewtable add column x_mynewfield ...` aus).

1. Fahren Sie fort, weitere Felder hinzuzufügen.

1. Klicken Sie auf **NetServer neu starten**, wenn Sie fertig sind. Wenn Travel aktiviert ist, sehen Sie auch eine Nachricht, dass eine neue Travel-Datenbank generiert werden muss.

## Eigenschaften des Feldes

| Feld | Beschreibung |
|---|---|
| Darf nicht leer sein | Wenn diese Option aktiviert ist, wird dieses Feld obligatorisch. |
| Von Listenfeld wählen | Wenn das Feld mit einer Zusatztabelle verbunden ist, wählen Sie diese Option, um eine Liste von Tabellenwerten anzuzeigen. |
| Werte aus Liste wählen | Wenn diese Option aktiviert ist, wird das Feld zu einem Listenfeld. Die Zeichenfolgen, die Sie in das Textfeld eingeben, werden als Optionen in der Liste angezeigt. Für jede Option gibt es eine Zeile. |
| Index erstellen | Diese Option legt fest, ob das Feld indiziert werden soll. Daten in indizierten Feldern sind schneller zu finden. |
| Datenbankfeld | Der Name, den die Spalte in der Datenbank erhält. Der Name muss in der Tabelle eindeutig sein. Weiter muss der Spaltenname ein einziges Wort sein, das nur Unterstriche, Buchstaben von a bis z oder Ziffern enthält und mit "x_" beginnt. Kann nur festgelegt werden, wenn das Feld erstellt wurde; **es kann später nicht mehr geändert werden**. |
| Dezimalstellen | Die Anzahl an Dezimalstellen, die bei einer Zahl zulässig sind. |
| Standardwert | Der Standardwert wird für dieses Feld verwendet. |
| Beschreibung | Die Standardbeschreibung. |
| Wert anzeigen | Diese Option legt fest, ob der Wert angezeigt werden soll. |
| Extern | Wenn diese Option aktiviert ist, ist das Feld in einem Kundenzentrum verfügbar. Dies ist nur für Standardtabellen relevant, weil Zusatztabellen immer in Kundenzentren angezeigt werden. |
| Kopfzeile für Liste | In diesem Feld geben Sie eine Kopfzeile für Einträge an, wenn sie als "Untereinträge" in einer Liste angezeigt werden. |
| Funktionsschaltflächen ausblenden | (Beziehungen) Wählen Sie diese Option, um die Funktion zum Hinzufügen neuer Einträge zu Beziehungstabellen auszublenden. |
| Feld ausblenden | Diese Option legt fest, ob das Feld angezeigt werden soll. |
| HTML-Tags beibehalten | (Text) Wählen Sie diese Option, um das HTML-Tag in den Text aufzunehmen. |
| Name | Der Name des Feldes. |
| Anzahl der Einheiten | (Zeitraum) Geben Sie die maximale Anzahl von Einheiten für die übergeordnete ausgewählte Zeiteinheit ein. Beispiel: Wenn Sie Stunden und Minuten ausgewählt haben und "4" eingeben, können höchstens 4 Stunden ausgewählt werden, während bis zu 60 Minuten möglich sind. In ähnlicher Weise können für Tage und Stunden höchstens 4 Tage ausgewählt werden, während bis zu 24 Stunden möglich sind. |
| Untergeordnete Knoten nur in hierarchischen Dropdown-Listen zulassen | (Beziehung zu Zusatztabelle) Gibt an, ob nur der niedrigste Knoten in einer Hierarchie vom Benutzer ausgewählt werden kann. |
| Position | Legt die Position dieses Feldes unter den anderen Feldern in der Liste fest. |
| Suchen-Operator | Wählen Sie den Suchoperator aus, der für dieses Feld verwendet werden soll. |
| In Tabelle anzeigen | Wenn diese Option aktiviert ist, wird dieses Feld als Spalte in Ansichten angezeigt, in denen mehrere Einträge in einer Tabelle angezeigt werden. |
| Eins-zu-viele-Beziehungen anzeigen | Wenn Sie die Optionen **Beziehung zu Person**, **Beziehung zu Firma** oder **Beziehung zu Anfrage** auswählen und eine Registerkarte mit Daten aus dieser Tabelle in den Ansichten Person, Firma und Anfrage anzeigen möchten, können Sie dieses Feld aktivieren. |
| Tabelle | Gibt an, zu welcher Tabelle das Feld gehört. |
| Zieltabelle | Gibt an, welche Tabelle verwendet werden soll. |
| Textbereich /Höhe | Wählen Sie diese Optionen, um die Höhe (Anzahl der Zeilen) des Textfelds anzugeben. |
| Typ | Zeigt den ausgewählten Feldtyp an. |
| Nullwerte jetzt aktualisieren | Aktivieren Sie diese Option, um alle Nullwerte (leere Felder) in der Datenbank durch den Standardwert zu ersetzen. Beachten Sie, dass dies etwas länger dauern kann. |
| URL | Geben Sie hier die URL des dynamischen Links ein. |
| Aktiven Benutzer als Standardwert verwenden | Wenn diese Option aktiviert ist, wird der Wert des Felds standardmäßig als aktueller Benutzer festgelegt. |
| Aktuelles Datum/aktuelle Uhrzeit als Standardwert verwenden | Wenn diese Option aktiviert ist, wird der Wert des Felds standardmäßig als aktuelles Datum/aktuelle Uhrzeit festgelegt. |
| Tage verwenden / Stunden verwenden / Minuten verwenden | Wählen Sie die Zeiteinheit, die im Zeitraumfeld verwendet werden soll. |
| Standardwert verwenden | Wenn diese Option aktiviert ist, wird dem Feld ein Standardwert zugeordnet, sofern nicht anders festgelegt. |
| In Beziehungsauswahl anzeigen | Wenn die aktuelle Tabelle mit einer anderen Tabelle in Beziehung steht (Beziehung zu Zusatztabelle), wählen Sie diese Option, damit das Feld als Suchfeld zur Verfügung steht. Beispiel: Sie haben eine Zusatztabelle mit dem Namen "Produkte" mit einer Zusatztabellen-Beziehung zur Tabelle **Anfragen** erstellt. So können Sie beim Erstellen neuer Anfragen Produkte auf der Registerkarte **Zusatzfelder** suchen und hinzufügen. Wenn Sie die Option **In Beziehungsauswahl anzeigen** für bestimmte Felder in der Tabelle "Produkte" wählen, stehen diese Felder auf der Registerkarte **Zusatzfelder** als Suchfelder zur Verfügung. |

## Beziehung hinzufügen (Fremdschlüssel, FK)

1. Klicken Sie auf **Neues Feld**.
1. Wählen Sie den Beziehungstyp für die Entität aus, mit der Sie verbinden möchten, und klicken Sie auf **OK**.

    > [!NOTE]
    > Verfügbar ab Version 10.3.4 im Pilot: Die Auswahl von **Ein-zu-viele-Beziehungen anzeigen** fügt einen Bereichsreiter (Archiv) zu den zugehörigen Standardentitäten hinzu.

1. Stellen Sie die Feldeigenschaften wie oben beschrieben ein.
1. Klicken Sie auf **OK**, um die Beziehung zu speichern.
1. Klicken Sie auf **NetServer neu starten**, um die Änderungen anzuwenden.

Zum Beispiel, um alle eingehenden Anfragen mit einem bestimmten Verkauf zu verbinden, können Sie ein zusätzliches Feld des Typs Verkaufsbeziehung zu Anfragen hinzufügen ([Tickettabelle][4]). Um verbundene Anfragen beim Ansicht eines Verkaufs in SuperOffice CRM aufzulisten, müssen Sie ein Webpanel erstellen.

<!-- Referenced links -->
[1]: create-extra-table.md
[4]: https://docs.superoffice.com/en/database/tables/ticket.html

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
