---
uid: help-de-import-from-excel
title: Aus Excel importieren
description: "In dieser Anleitung lernen Sie, wie Sie alle Ihre Interessenten, Kunden und deren Personen importieren können."
keywords: Importieren, Excel, Firma, Person, Tabellenkalkulation
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/import/learn/import-from-excel
language: de
---

# Aus Excel importieren

In SuperOffice CRM können Sie mit Excel, Outlook, Gmail oder Ihrem ERP-Synchronizer in einem Schritt [Ihre Kundendaten importieren][2].

Die Excel-Tabellenkalkulation kann beispielsweise die folgenden Informationen enthalten:

* Eine Liste möglicher Kunden/Interessenten, die Sie in SuperOffice importieren möchten.

    > [!TIP]
    > Fügen Sie beispielsweise allen Personen eine Spalte mit dem Text "Interessent" hinzu, um sie ganz einfach mit der richtigen Kategorie in SuperOffice CRM zu verknüpfen.

* Eine Firmen-/Personenliste mit "bereinigten" Daten (exportiert und auf Qualität geprüft und wird wieder importiert).

* Firmen und Personen aus anderen Anwendungen und Formaten, wie beispielsweise Buchhaltungssystemen, anderen CRM-Clients, E-Mail-Clients (anderen als Gmail und Outlook) und Windows-Installationen von SuperOffice CRM.

## Bevor Sie beginnen

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Sie müssen die [Excel-Datei vorbereiten][1], bevor Sie mit dem Import beginnen. Auswahlliste:

* Die Excel-Tabellenkalkulation sollte mindestens Spalten mit Firmennamen und Personennamen (Vorname und Nachname) enthalten.

* Überprüfen Sie, ob die Daten auf dem neuesten Stand sind. Sind zum Beispiel Postadressen und Telefonnummern korrekt?

## Firmen/Personen aus einer Excel-Datei importieren

Sehen Sie sich dieses Video an oder führen Sie die folgenden Schritte aus, um zu lernen, wie Sie Ihre Personen mit unserer Importvorlage in SuperOffice CRM importieren können (Videolänge - 4:02):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/dVkCfpOkNl8]

### Schritte

1. [!include[Open Import](includes/open-import.md)]

2. Vergewissern Sie sich, dass **Personen** unter **Importquelle auswählen** ausgewählt ist, und klicken Sie dann auf das ![Symbol][img1] Excel.

3. Klicken Sie im Dialogfeld **Datei hochladen** auf **Datei hochladen**, um die Excel-Tabelle auszuwählen, die Sie importieren möchten.

4. Blättern Sie zur gewünschten Excel-Tabellenkalkulation und klicken Sie auf **Öffnen**. Die Daten aus der Tabellenkalkulation werden in der Tabelle angezeigt.

> [!NOTE]
> In dieser Stufe sind die Firmen/Personen von Excel noch nicht in die SuperOffice-Datenbank importiert worden. SuperOffice lädt lediglich die Firmen-/Personenliste aus der Tabellenkalkulation hoch, damit Sie die Importeinstellungen festlegen können.

## Importeinstellungen anpassen

Da eine Excel-Tabellenkalkulation sowohl wenig als auch viele Spalten enthalten kann, ist es wichtig, dass die Spalten mit den Daten, die Sie importieren möchten, mit den richtigen SuperOffice-Feldern verknüpft werden.

> [!NOTE]
> Wenn die Excel-Tabellenkalkulation oben eine Titelzeile hat, wird dies ebenfalls in der Liste angezeigt. Sie können sie entfernen, wenn Sie die Daten im nächsten Schritt in der Vorschau anzeigen.

1. Suchen Sie die Spalte heraus, die die Firmennamen enthält, und klicken Sie auf den Spaltentitel **(Keine Selektion)** und wählen Sie **Firma: Name**.

1. Suchen Sie die Spalte heraus, die die Vor- und Nachnamen der Personen enthält, und klicken Sie auf den Spaltentitel **(Keine Selektion)** und wählen Sie **Person: Vorname** und **Person: Nachname**. Wenn Vor- und Nachname in einer Spalte zusammengefasst sind, wählen Sie **Person: Vollständiger Name**.

1. Wählen Sie die SuperOffice-Felder für die übrigen Spalten in der Tabelle aus. Überspringen Sie die Spalten, die Sie nicht importiert möchten.

1. [!include[Configure import settings](includes/configure-import-settings.md)]

1. [!include[Enter concent comment](includes/step-concent-comment.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Entfernen Sie die Markierungen für die Zeilen, die NICHT importiert werden sollen. Wenn das Excel-Arbeitsblatt eine Überschriftenzeile enthalten hat, können Sie sie hier entfernen.

1. Wenn Sie sicher sind, dass Sie alle Daten einbezogen haben, die Sie importieren möchten, klicken Sie auf **Importieren**.

### Fehlerbehebung

[!include[Contacts without icons](includes/troubleshoot-import.md)]

**Ich komme nicht weiter!**

Sie müssen alle erforderlichen SuperOffice-Felder mit ihren jeweiligen Spalten verknüpfen, um fortzufahren. Die Pflichtfelder werden über der Tabelle angezeigt. Wenn Sie festgelegt haben, dass Personen ohne Firmen als neue Firmen hinzugefügt werden sollen, müssen Sie nur das SuperOffice-Feld **Firma: Name** ausfüllen.

## Import abschließen

[!include[Step: complete the import](includes/import-complete.md)]

## Verwandt

* [Importeinstellungen konfigurieren][3]
* [Aus Gmail importieren][5]
* [Aus ERP importieren][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[5]: from-gmail.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png
