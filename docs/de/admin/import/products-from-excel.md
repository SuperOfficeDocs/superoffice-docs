---
uid: help-de-import-products-from-excel
title: Produkte aus Excel importieren
description: "In dieser Anleitung lernen Sie, wie Sie alle Ihre Produkte, Beschreibungen und Produktcodes importieren können."
keywords: Importieren, Produkt, Excel
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/import/learn/import-products-from-excel
language: de
---

# Produkte aus Excel importieren

Der [Import][2] ist eine großartige Möglichkeit, Ihre Datenbank schnell mit Preisinformationen zu füllen oder zu aktualisieren. Wenn Sie eine Excel-Tabellenkalkulation mit einer Liste von Produkten haben, können Sie sie bequem in SuperOffice importieren.

## Bevor Sie beginnen

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Sie müssen die [Excel-Datei vorbereiten][1], bevor Sie mit dem Import beginnen. Auswahlliste:

* Die Excel-Tabellenkalkulation sollte zumindest Spalten mit Produktcode, Produktname und Listenpreis enthalten.
* Stellen Sie sicher, dass sie für jede Reihe eine einmalige Produktnummer als publizierten Schlüsselwert hinzufügen.

## Produkte von einer Excel-Importdatei exportieren

Sehen Sie sich dieses Video an oder folgen Sie den Schritten, um zu lernen, wie Sie Ihre Produkte mithilfe unserer Importvorlage in SuperOffice CRM importieren können (Videolänge - 4:22):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xOTB6j2zzNo]

1. [!include[Open Import](includes/open-import.md)]

2. Klicken Sie auf **Produkte** unter **Importquelle auswählen**.

3. Wählen Sie in **In Preisliste importieren** die Preisliste, in die Sie die Produkte importieren möchten.

4. Klicken Sie auf das ![Symbol][img1] Excel unter **Importquelle auswählen**.

5. Klicken Sie im Dialogfeld **Datei hochladen** auf **Datei hochladen**, um die Excel-Tabelle auszuwählen, die Sie importieren möchten.

6. Blättern Sie zur gewünschten Excel-Tabellenkalkulation und klicken Sie auf **Öffnen**. Das Feld **Dateiname** zeigt die Position und den Namen der ausgewählten Datei an.

7. Klicken Sie auf **Speichern**. Die Daten aus dem Arbeitsblatt werden in der Tabelle angezeigt, und der Name der Importdatei wird unten angegeben.

> [!NOTE]
> Zu diesem Zeitpunkt sind noch keine Produkte von Excel in die SuperOffice-Datenbank importiert worden. SuperOffice lädt lediglich die Produktliste aus der Tabellenkalkulation hoch, damit Sie die Importeinstellungen festlegen können.

## Importeinstellungen anpassen

Da eine Excel-Tabellenkalkulation sowohl wenig als auch viele Spalten enthalten kann, ist es wichtig, dass die Spalten mit den Daten, die Sie importieren möchten, mit den richtigen SuperOffice-Feldern verknüpft werden.

> [!NOTE]
> Die Tabellenkalkulation muss mindestens die Spalten beinhalten, die Sie für die Duplikatfirmen im Verfahren hierunter benötigen (Name, Produktnummer oder Name+Produktnummer)

1. Suchen Sie die Spalte heraus, die den Produktnamen enthält, klicken Sie auf den Spaltentitel **(Keine Selektion)** und wählen Sie **Produkt: Name**.

2. Suchen Sie die Spalte heraus, die den Produktcode enthält, klicken Sie auf den Spaltentitel **(Keine Selektion)** und wählen Sie **Produkt: Code**.

3. Wählen Sie die SuperOffice-Felder für die übrigen Spalten in der Tabelle aus. Überspringen Sie die Spalten, die Sie nicht importiert möchten.

4. [!include[Configure import settings](includes/configure-import-settings.md)]

5. Klicken Sie auf **Next** (Weiter). Die Ansicht **Vorschau des Imports anzeigen** erscheint.

6. Kontrollieren Sie die Importdaten auf eventuelle Probleme, bevor Sie mit dem Importieren beginnen.

    | Symbol | Beschreibung |
    |---|---|
    | <i class="ph ph-warning" aria-label="Warning"></i> | In dieser Reihe gibt es ein Datenproblem. Siehe erklärenden Text im Tabellenkopf. |
    | ![Symbol][img3] | Das Produkt ist noch nicht vorhanden und wird nun hinzugefügt. |
    | ![Symbol][img4] | Das Produkt ist bereits vorhanden und wird nun aktualisiert. |
    | leer | Keine Aktualisierung. |

7. Entfernen Sie die Markierungen für die Zeilen, die NICHT importiert werden sollen. Wenn das Excel-Arbeitsblatt eine Überschriftenzeile enthalten hat, können Sie sie hier entfernen.

8. Nachdem überprüft wurde, dass Sie alle Daten einbezogen haben, die zu importieren sind, klicken Sie auf **Importieren**.

## Import abschließen

Wenn der Import abgeschlossen ist, wird eine Liste importierter Produkte angezeigt. Über der Liste befindet sich ein Link zur aktualisierten Preisliste.

## Verwandt

* [Importeinstellungen konfigurieren][3]
* [Aus ERP importieren][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png
[img3]: ../../../media/icons/admin/import-preview-icon-product-new.png
[img4]: ../../../media/icons/admin/import-preview-icon-product-changed.png
