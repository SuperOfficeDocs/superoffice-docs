---
uid: help-de-saint-status-create
title: Neuen Status erstellen
description: Neuen Status erstellen
keywords: SAINT, Statuskontrollen, Bild, darstellen, Suche
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: 
  - /de/sale/saint/learn/admin/create-status
  - /de/sale/saint/learn/admin/select-image-for-status
  - /de/saint/admin/select-image-for-status
index: true
---

# Neuen Status erstellen

[!include[Requirement](../includes/note-saint-req.md)]

## Warum man eine Statuskontrolle erstellen sollte?

Sie möchten Firmen überwachen, mit denen Sie nur sehr wenige Aktivitäten haben, um unzufriedene Kunden und Abwanderung zu vermeiden. Mit dieser Statuskontrolle sehen Sie leicht alle Kunden, die Ihre Aufmerksamkeit verlangen.

![Statuskontrolle durch Anklicken der Hinzufügen-Schaltfläche auf der Anzeige erstellen -screenshot][img1]

## Schritte

1. Öffnen Sie die Anzeige **SAINT** und wählen Sie die Registerkarte **Firma**, **Kontakt** oder **Projekt** aus.

1. Klicken Sie unter der Liste **Statuskontrollen** auf die Schaltfläche **Hinzufügen**.

1. Füllen Sie im Dialogfeld die folgenden Felder aus:

    * **Name**: Geben Sie einen beschreibenden Namen für den hinzuzufügenden Status ein.

        Optional: Klicken Sie auf <i class="ph ph-translate" aria-label="Translate"></i>, damit Sie für den Statusnamen [Übersetzungen hinzufügen][8] können.

    * **Beschreibung**: Geben Sie eine erklärende Beschreibung des Status und die erforderlichen oder empfohlenen Maßnahmen ein. In diesem Feld können Sie den Text mit [Vorlagenvariablen][9] auch auf die entsprechende Firma, Person oder das entsprechende Projekt zuschneiden.

    Name und Beschreibung werden in SuperOffice CRM angezeigt, wenn der Benutzer mit dem Mauszeiger über das Statusbild fährt oder das Statusbild für das Unternehmen öffnet. Sie können nachträglich die [Beschreibung bearbeiten][2].

1. Klicken Sie auf **Speichern**. Der Status wird in der Statusliste angezeigt.

1. Wenn mehrere Statusangaben in der Liste enthalten sind, müssen Sie die Priorität für den neuen Status festlegen. Klicken Sie auf den Status und verschieben Sie ihn mit den Pfeiltasten rechts neben der Statusliste nach oben oder nach unten.

### Kriterien für den Status festlegen

Jeder Status muss mindestens ein Kriterium enthalten. Nach dem Erstellen des Status:

1. Wählen Sie den neuen Status in der Liste aus.
1. Wählen Sie **Hinzufügen**, um ein neues Kriterium einzufügen.
1. Wählen Sie einen Kriteriumtyp, stellen Sie die Bedingung ein und geben Sie einen Wert ein.
1. Wiederholen Sie den Vorgang nach Bedarf und wählen Sie dann **Ausgewählte Statusüberwachung regenerieren**, um den Status zu aktivieren.

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

### Was ist in der Statusliste enthalten?

* Das **Anzeigen**-Symbol (<i class="ph ph-eye" aria-hidden="true"></i>) gibt an, ob für Firmen-, Personen- oder Projektkarten die Option [Statusbild anzeigen][3] ausgeführt oder ob Projektkarten, welche die Statuskriterien erfüllen, angezeigt werden sollen. Das Symbol wird nur angezeigt, wenn Sie für den betreffenden Status **anzeigen** in der Registerkarte **Bild** aktiviert haben.

* Ein rotes Kreuz weist darauf hin, dass der Status neu erstellt werden muss. Der [Status muss erneuert werden][4], wenn Sie ein Kriterium hinzugefügt, bearbeitet oder gelöscht oder wenn Sie zum Beispiel den Zweck für eine Aufgabe geändert haben. Statusangaben mit einem roten Kreuz werden nicht aktualisiert und geben beim Verwenden von SuperOffice CRM keine aktuellen Daten zurück.

* **Name** – Der Name des Status. Gelöschte Statusangaben werden rot dargestellt, wenn das Kontrollkästchen **Gelöschte anzeigen** aktiviert wurde.

* **Priorität** – Die Priorität des Status. Die Priorität bestimmt, welcher Status angezeigt werden soll, wenn eine Firma, eine Person oder ein Projekt die Kriterien für mehrere Statusangaben erfüllt.

## Warum muss ich die Priorität für einen Status festlegen?

Eine Firma, eine Person oder ein Projekt kann zwar die Kriterien für mehrere Statusangaben erfüllen, in SuperOffice CRM kann jedoch nur ein Statusbild auf der Firmen-, Personen- oder Projektkarte angezeigt werden. Daher muss für die Anzeige von Statusangaben in SuperOffice CRM eine Rangfolge festgelegt werden. Bei Firmen, Personen oder Projekten, die die Kriterien für den Status mit der höchsten Priorität nicht erfüllen, wird der Status mit der nächsthöheren Priorität angezeigt. Erfüllt die Firma, die Person oder das Projekt auch diese Kriterien nicht, wird der nächste Status angezeigt usw.

Bei mehreren aktiven Statusangaben für eine Firma, eine Person oder ein Projekt werden die Statusangaben mit niedrigerer Priorität als Verknüpfungen im Statusdialogfeld angezeigt. Dieses Dialogfeld wird angezeigt, wenn der Benutzer auf das Statusbild in SuperOffice CRM klickt oder im Menü **Firma**, **Person** oder **Projekt** die Option **Statusinformationen anzeigen** für eine Firma, eine Person oder ein Projekt mit aktivem Status auswählt.

## Verwandte Themen

* [Statuskriterien festlegen][6]
* [Zeitraum festlegen][7]
* [Statuskontrollen verwalten][4]

<!-- Referenced links -->
[2]: edit-status.md
[3]: select-image-for-status.md
[4]: manage-status-monitors.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
