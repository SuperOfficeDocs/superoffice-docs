---
uid: help-de-quote-template-tutorial
title: Bestellbestätigungsvorlage anpassen
description: Bestellbestätigungsvorlage anpassen
keywords: Angebot, Angebotsvorlage, Vorlage, Angebotsdokument, Bestellbestätigung
author: Bergfrid Dias
date: 07.31.2024
version: 10
topic: tutorial
language: de
audience: settings
audience_tooltip: Settings and maintenance
---

# Bestellbestätigungsvorlage anpassen

In diesem Tutorial werden wir eine Bestellbestätigungsvorlage als Grundlage verwenden, um eine neue Vorlage zu erstellen.

Wir werden:

* Den Namen der Alternative hinzufügen (aus dem Angebot entnommen).
* Die Anzahl der Zeilen in der Alternative hinzufügen.
* Ein Thumbnail des Produkts hinzufügen.
* Die Produkte nach Produktnamen sortieren.
* Die Produkte im Dokument nach Produktfamilien gruppieren. Eine Produktfamilie könnte zum Beispiel "Hardware", "Software" oder "Zubehör" sein.
* Eine Gesamtsumme für die Produkte in jeder Gruppe eingeben, aber die Gesamtsumme für die Alternative, die bereits im Dokument existiert, beibehalten.

## Vorbereitungen

### Ein Verkauf zum Testen der Vorlage erstellen

1. Erstellen Sie in SuperOffice CRM [ein Angebot][5] mit verschiedenen Produkten aus verschiedenen Produktfamilien, um die Gruppierungsfunktion zu testen.

2. Stellen Sie sicher, dass der Verkauf den gleichen Typ hat wie der, den Sie später mit der Vorlage verknüpfen werden (später in diesem Tutorial).

3. Klicken Sie im Angebot auf **Auftrag erteilen**, um die Schaltfläche **Bestätigung anzeigen** zu aktivieren.

### Wählen Sie die anzuzeigenden Felder aus

1. Überprüfen Sie, ob die erforderlichen Produktfelder im Dialogfeld **Produkt konfigurieren** sichtbar sind.

* Nur Felder, die in Einstellungen und Verwaltung als sichtbar markiert sind, werden in der Vorlage angezeigt.

* Siehe [Produkte konfigurieren][4] für weitere Informationen zum Einstellen der Feldsichtbarkeit.

### Kopieren Sie die zu ändernde Vorlage

1. Wählen Sie in Einstellungen und Verwaltung **Listen** aus dem Navigator.
2. Klicken Sie auf den Pfeil und wählen Sie **Document - Template**.
3. Doppelklicken Sie auf die Vorlage *Auftragsbestätigung* und klicken Sie auf **Bearbeiten**, um sie in Microsoft Word zu öffnen.
4. Speichern Sie das Dokument unter einem neuen Namen an einem leicht zugänglichen Ort.
5. [Fügen Sie das Vorlagendokument hinzu][1].
6. Benennen Sie das Dokument logisch, zum Beispiel *Auftragsbestätigung – Gruppiert*.
7. Aktivieren Sie die Option **Angebotsdokumenttyp**, um es für Angebote in SuperOffice CRM verfügbar zu machen.
8. Wählen Sie **Vorlage für Auftragsbestätigung**.

### Verknüpfen Sie das Vorlagendokument mit einem Verkaufstyp

1. Doppelklicken Sie auf dem Bildschirm **Listen** auf **Sale – Type, Stages, Quote**.
2. Doppelklicken Sie in der Übersicht **Listenobjekt** auf einen Verkaufstyp, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.
3. Gehen Sie auf die Registerkarte **Standardwerte**, öffnen Sie die Liste **Auftragsbestätigungsvorlage** und wählen Sie Ihre neue Vorlage aus.
4. Klicken Sie auf **OK**, um Ihre Änderungen zu speichern.

## Ändern der Vorlage

In diesem Abschnitt erfahren Sie, wie Sie das Vorlagendokument ändern, indem Sie Felder einfügen, Produktbilder hinzufügen, Produkte gruppieren und Sortierreihenfolgen auswählen.

### Felder in Word einfügen

1. Öffnen Sie das Vorlagendokument aus der Liste **Document - Template**.

1. **Kopieren** Sie ein vorhandenes Feld aus der Vorlage. Stellen Sie sicher, dass Sie das gesamte Feld einschließlich der «» kopieren.

1. **Fügen Sie** das Feld nach dem Titel ("Details") in Ihre Vorlage ein.

1. Klicken Sie mit der rechten Maustaste auf das eingefügte Feld und wählen Sie **Felder bearbeiten**. Geben Sie im Feld **Feldname** unter **Feldeigenschaften** *alternative/name* (ohne «») ein. Klicken Sie auf **OK**.

    > [!NOTE]
    > Es ist wichtig, dass Sie bei der Eingabe der Feldnamen Groß- und Kleinschreibung beachten.

1. Kopieren Sie erneut ein vorhandenes Feld und fügen Sie es unter die Produkttabelle ein (linksbündig in derselben Zeile wie die Gesamtsumme der Alternative).

1. Geben Sie *alternative/numLines* als Feldnamen ein und klicken Sie auf **OK**.

1. Geben Sie die Bezeichnung *Zeilen:* links neben dem Feld numLines ein.

1. Fügen Sie eine neue Spalte mit dem Titel "Bild" (`Image:line/quoteLineThumbnail`.) ein.

1. Ihre Vorlage sollte nun so aussehen:

    ![Auftragsbestätigung mit neuen Feldern -screenshot][img1]

1. Speichern Sie das Vorlagendokument, schließen Sie es jedoch nicht.

### Auftragsbestätigung in SuperOffice CRM anzeigen (optional)

Um sicherzustellen, dass Ihre Änderungen korrekt wiedergegeben werden, befolgen Sie diese Schritte, um die Auftragsbestätigung anzuzeigen:

1. **Öffnen Sie einen Verkauf** des gleichen Typs, mit dem Ihre Vorlage verknüpft ist.
2. Gehen Sie auf die Registerkarte **Angebot** innerhalb des Verkaufs und klicken Sie auf **Öffnen**.
3. Klicken Sie auf **Auftrag erteilen**, wenn Sie dies noch nicht getan haben.
4. Klicken Sie im Dialogfeld **Angebot bearbeiten** auf **Bestätigung anzeigen**. Die Auftragsbestätigung wird als PDF-Datei geöffnet.
5. Überprüfen Sie die Auftragsbestätigung:
    * Stellen Sie sicher, dass alle Tabelleninhalte korrekt angezeigt werden, ohne dass Zahlen auf zwei Zeilen aufgeteilt werden.
    * Überprüfen Sie, ob keine Feldnamen im Dokument angezeigt werden; falls doch, haben Sie möglicherweise falsche Feldnamen verwendet.
    * Bestätigen Sie, dass alle eingefügten Felder vorhanden sind. Fehlende Felder können darauf hinweisen, dass die erforderlichen Daten im Angebot oder Produkt nicht verfügbar sind.
6. Nehmen Sie bei Bedarf die erforderlichen Anpassungen an der Vorlage vor und speichern Sie diese.
7. Überprüfen Sie die Auftragsbestätigung erneut, um sicherzustellen, dass alle Änderungen korrekt angezeigt werden.

### Sortierreihenfolge festlegen

1. Fügen Sie das **OrderBy**-Feld in das Vorlagendokument ein.

    `«TableStart:alternative»«OrderBy:name»`

Produkte werden nun nach Produktnamen innerhalb jeder Alternative sortiert. Nach der Definition des Gruppierungsbereichs werden die Produkte auch innerhalb jeder Gruppe sortiert.

### Gruppierungsbereich und Schlüssel festlegen

1. Fügen Sie `«TableStart:group»` vor TableStart:linie ein.
1. Fügen Sie `«TableEnd:groupå»` nach TableEnd:linie ein.
1. Fügen Sie `«GroupBy:productFamilyKey»` an einer beliebigen Stelle im Dokument ein, um den Gruppierungsschlüssel zu definieren.

### Gruppenspezifische Felder hinzufügen

1. Verschieben Sie die Tabelle mit der Gesamtsumme der Alternative (einschließlich der Gesamtzeilenanzahl) um ein paar Zeilen nach unten, um Platz zu schaffen, um die Gruppenfelder zwischen TableStart:group und TableEnd:group einzufügen.

1. Fügen Sie zwischen dem Titel und der Tabelle mit den Produkten `«group/groupField»` ein. Geben Sie dem Feld einen Überschriftstil.

    Dies ist der Titel der Gruppe (der Name des Feldes, nach dem die Produkte gruppiert sind).

1. Fügen Sie unten in der Spalte mit den Preisen `««group/sumtotalPrice»»` ein.

    Dies ist die Gesamtsumme für die gesamte Gruppe.

1. Fügen Sie in die Zelle links von der Gesamtsumme für die gesamte Gruppe `«group/groupField»` ein. Geben Sie die Bezeichnung *Summe* links neben dem Feld ein.

### Speichern und Überprüfen

1. Ihre Vorlage sollte nun so aussehen:

    ![Auftragsbestätigung Ergebnis -screenshot][img2]

1. Speichern Sie das Vorlagendokument und überprüfen Sie es wie oben beschrieben.

## Verwandte Themen

* [Erstellen eines Vorlagendokuments][2]
* [Vorlagenvariablenreferenz][3]

<!-- Referenced links -->
[1]: link-template.md
[2]: ../learn/create.md
[3]: ../variables/index.md
[4]: ../../../quote/learn/admin/product/configure.md
[5]: ../../../sale/learn/create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/tutorial-insert-fields.png
[img2]: ../../../../media/loc/en/document/tutorial-grouped.png
