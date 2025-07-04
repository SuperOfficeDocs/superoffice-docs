---
uid: help-de-quote-create-document
title: Angebotsdokument erstellen
description: Erstellen Sie ein Angebotsdokument für Ihren SuperOffice-Angebotsvorschlag, das Sie an den Kunden senden können.
keywords: Angebotsdokument erstellen, Angebotsdokument ändern, Angebotsdokument, Angebot
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: de
redirect_from: /de/quote/learn/create-quote-document
---

# Angebotsdokument erstellen

Nachdem Sie das Angebot erstellt und Produkte hinzugefügt haben, können Sie das Angebotsdokument generieren. Dies ist das "Anschreiben", das an den Kunden gesendet wird. Die Liste der angebotenen Produkte wird beim Senden des Angebots hinzugefügt.

Sie können das Dokument entweder über die Bereichsregisterkarte **Angebot** eines Verkaufs oder im Dialogfeld **Angebot bearbeiten** erstellen.

> [!TIP]
> Verwenden Sie [eine Vorlage mit angebotsbezogenen Merge fields][3], um Angebotsdetails in das Dokument einzufügen.

## Angebotsdokument erstellen

1. Wenn Sie das Angebot bereits bearbeiten, klicken Sie oben im Dialogfeld **Angebot bearbeiten** auf **Zur Erstellung eines Angebotsdokuments hier klicken**.

    *Alternativ* klicken Sie auf der Bereichsregisterkarte **Angebot** des Verkaufs auf **Zur Erstellung eines Angebotsdokuments hier klicken**.

    > [!NOTE]
    > Das Angebot muss den Status **Entwurf** haben. Wenn es bereits gesendet wurde, [erstellen Sie zuerst eine neue Version][1].

2. Füllen Sie im Dialogfeld **Dokument** die [erforderlichen Felder][2] aus.

3. Klicken Sie auf **Erstellen**, um ein neues Dokument basierend auf der ausgewählten Vorlage zu erstellen.

4. Bearbeiten Sie den Inhalt in Word (oder einem anderen Editor), speichern und schließen Sie die Datei.

    Das Dokument erscheint auf der Bereichsregisterkarte **Angebot** und ist mit dem Angebot verknüpft. Es wird außerdem im Bereich **Aktivitäten** des Verkaufs (sowie in den Ansichten Firma und Kalender) angezeigt.

## <a id="replace"></a>Angebotsdokument ersetzen

Wenn Sie den Inhalt oder die Vorlage eines Angebotsdokuments ändern möchten, wählen Sie eine der folgenden Optionen:

### Option 1: Nur Datei ersetzen

Verwenden Sie diese Methode, wenn Sie die Dokumentinformationen beibehalten, aber eine neue Datei hochladen möchten.

1. Klicken Sie auf das Dokument in der Registerkarte **Angebot**.

2. Deaktivieren Sie **Abgeschlossen**.

3. Klicken Sie auf **Ersetzen**, wählen Sie die neue Datei aus und laden Sie sie hoch.

4. Klicken Sie auf **Speichern**.

### Option 2: Dokument löschen und neu erstellen

Verwenden Sie diese Methode, um das alte Dokument zu entfernen und mit einer neuen Vorlage neu zu beginnen.

1. Klicken Sie auf das vorhandene Dokument in der Registerkarte **Angebot**.

2. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie im Menü **Aufgabe** die Option **Löschen**.

3. Klicken Sie erneut auf **Zur Erstellung eines Angebotsdokuments hier klicken**, um ein neues Dokument zu erstellen.

### Option 3: Neues Dokument erstellen und verknüpfen

Verwenden Sie diese Methode, um manuell ein neues Dokument mit Ihrer bevorzugten Vorlage zu erstellen und mit dem Angebot zu verknüpfen. Das bestehende Dokument bleibt erhalten.

1. Klicken Sie in der oberen Leiste auf **Neu** und wählen Sie **Dokument**.

2. Wählen Sie im Dialogfeld **Dokument** eine Angebotsvorlage aus, verknüpfen Sie das Dokument mit dem gewünschten Verkauf und klicken Sie auf **Erstellen**.

3. Öffnen Sie die Bereichsregisterkarte **Angebot** im Verkauf und klicken Sie auf **Öffnen**.

4. Klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie **Angebotsdokument ändern**.

5. Wählen Sie das neue Dokument aus der Liste.

    In der Liste erscheinen alle Angebotsdokumente, die dem aktuellen Verkauf zugeordnet sind.

> [!TIP]
> Für kleinere Änderungen öffnen Sie das bestehende Dokument, nehmen Anpassungen vor und speichern es. Ein Ersetzen oder Löschen ist nicht erforderlich.

## Wie Angebotsvorlagen funktionieren

Vorlagen für Angebotsdokumente, Angebotsdetails und Auftragsbestätigungen unterscheiden sich von normalen Dokumentvorlagen. Sie verwenden **Merge fields** zusätzlich zu Standardvariablen.

* Ist das Feld `<<QuoteDetails>>` im Hauptdokument enthalten, werden die Angebotsdetails an dieser Stelle eingefügt.
* Fehlt das Feld, werden die Angebotsdetails am Dokumentende angehängt.

## Verwandte Inhalte

* [Angebot senden][4]
* [Auftrag erteilen][5]
* [Ein Dokument bearbeiten][2]
* [Angebotsvorlagen][6]
* [Vorlagenvariablen und Merge fields][3]

<!-- Referenced links -->
[1]: send.md#versions
[2]: ../../../document/learn/edit.md
[3]: ../../../document/templates/merge-fields/quote.md
[4]: send.md
[5]: place-order.md
[6]: ../../../document/templates/learn/quote-templates.md
