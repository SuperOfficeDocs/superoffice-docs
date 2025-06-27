---
uid: help-de-extra-table-create
title: Zusatztabellen hinzufügen
description: Zusatztabellen hinzufügen
author: Bergfrid Dias
keywords: Zusatztabelle, Tabelle, Datentypen, Datenbanktabelle, Systemdesign
date: 01.30.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Zusatztabellen hinzufügen

Sie können Zusatztabellen in SuperOffice erstellen, um unterschiedliche Datentypen zu erfassen. Nachdem Sie die Tabelle und darin [Zusatzfelder erstellt][1] wurden, können Sie die Tabelle öffnen, um ihr Inhalte hinzuzufügen.

## Schritte

1. [!include[Zu Tabellen gehen](includes/goto-tables.md)]

1. Klicken Sie auf **Neue Tabelle**.

    ![Erstellen Sie eine Zusatztabelle -screenshot][img1]

1. In der Ansicht **Eigenschaften der Tabelle** geben Sie Daten über die neue Tabelle ein.

    * Geben Sie einen *Namen* ein, der als Bezeichnung verwendet wird.
    * Geben Sie eine *Datenbanktabelle* ein, die mit **y_** beginnt, um sie im Schema zu identifizieren.
    * Optional setzen Sie andere Eigenschaften. Sehen Sie Details zu den Feldern unten.

    > [!NOTE]
    > Einige Tabelleneigenschaften können nicht eingestellt werden, bis Sie Felder hinzugefügt haben.

1. Klicken Sie auf **OK**, um die neue Tabelle zu speichern (führt `create table y_mynewtable ...` aus).

1. [Fügen Sie Felder zu Ihrer neuen Tabelle hinzu][1].

1. Optional, passen Sie Tabelleneigenschaften wie Sortierreihenfolge an. (Klicken Sie auf den Tabellennamen in der Liste, um den Bearbeitungsmodus zu betreten.)

1. Klicken Sie auf **NetServer neu starten**. Wenn Travel aktiviert ist, sehen Sie auch eine Nachricht, dass eine neue Travel-Datenbank generiert werden muss.

Sie können nun die Tabelle in der Benutzeroberfläche öffnen, um Inhalte hinzuzufügen **oder** sie über die APIs zu füllen.

## Felder

| Feld | Beschreibung |
|---|---|
| Ordner | Um die Tabelle in einen vorhandenen Ordner zu kopieren, wählen Sie einen Ordner von der Liste aus. |
| Name | Der Name der Tabelle. |
| Datenbanktabelle | Der Name der Datenbanktabelle. Kann nur bei der Erstellung festgelegt und nicht mehr geändert werden. Der Tabellenname kann Unterstriche, die Buchstaben a-z und Zahlen enthalten, und der Name muss mit "y_" beginnen. Ein logischer Name ist am besten, weil er es einfacher macht, zu sehen, was die Datenbank enthält. |
| Kopfzeile für Suche | Die Kopfzeile wird für diese Tabelle in der Ansicht Suchen verwendet. |
| Kopfzeile für Datenanzeige | Die Kopfzeile wird zur Anzeige eines Eintrags in dieser Tabelle verwendet. |
| Kopfzeile für neuen Eintrag | Die Kopfzeile wird zum Erstellen eines neuen Eintrags in dieser Tabelle verwendet. |
| Kopfzeile für Datenbearbeitung | Die Kopfzeile wird für die Bearbeitung eines Eintrags in dieser Tabelle verwendet. |
| Sortierreihenfolge | Die Spalte, nach der die Tabelle sortiert wird. Wenn Sie **Absteigend** aktivieren, werden die Werte in absteigender Reihenfolge sortiert. Für Zahlenwerte bedeutet dies, dass der höchste Wert ganz oben in der Tabelle angezeigt wird. Die Tabelle muss Felder enthalten, bevor Sie hier etwas auswählen können. |
| Anzeigefeld | Wenn Daten aus dieser Tabelle in einer anderen Tabelle (eine Beziehung) angezeigt werden sollen, müssen Sie hier auswählen, welches Feld in der anderen Tabelle angezeigt werden soll. Die Tabelle muss Felder enthalten, bevor Sie hier etwas auswählen können. |
| Übergeordnetes Feld | Dieses Feld kommt in Verbindung mit Tabellen mit hierarchischer Struktur zum Einsatz. |
| Vollständiger Name | Für hierarchisch strukturierte Tabellen können Sie hier ein Feld angeben, in das automatisch der vollständige Name des Eintrags eingefügt wird. Der Name wird aus dem Namensfeld des Eintrags und aller übergeordneten Einträge abgeleitet. |
| ID-Feld ausblenden | Wenn diese Option ausgewählt ist, wird das ID-Feld bei der Auflistung von Einträgen in der Tabelle nicht angezeigt. |
| Tabelle ausblenden | Wenn diese Option aktiviert ist, ist die Tabelle nicht über das **Systemdesign** > **Tabellen** sichtbar. |

## Tabelleninformation in Web-Bildschirme erstellen

In SuperOffice können Sie Web-Bildschirme erstellen, die Tabelleninformationen enthalten können. Um die entsprechenden Zugriffsrechte festzulegen, muss der Benutzer einer Rolle angehören, die über die Funktionsrechte **Tabellen anzeigen** und **Tabellen bearbeiten** verfügt.

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
