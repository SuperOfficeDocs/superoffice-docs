---
uid: help-de-document-create
title: Neues Dokument erstellen
description: Erstellen Sie ein neues Dokument direkt in SuperOffice CRM oder laden Sie ein bestehendes hoch, um sicherzustellen, dass Sie und Ihre Kollegen immer Zugriff auf die neuesten Dokumente und Versionen haben. Diese Anleitung zeigt Ihnen, wie Sie beides machen können.
keywords: neues Dokument, Dokument hinzufügen, Dokument erstellen, WebTools, SharePoint, Dokument
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Neue Dokumente erstellen

> [!TIP]
> Haben Sie bereits das Dokument? Siehe [Dokumente hochladen](#upload).

Befolgen Sie die jeweiligen Anweisungen für die Art und Weise, wie Dokumente in Ihrer SuperOffice-Installation verwaltet werden.

## Wie weiß ich, ob ich SharePoint, SuperOffice WebTools verwende oder nicht?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

<!-- markdownlint-disable-file MD051 -->
## Scritte

### [Mit SuperOffice WebTools](#tab/webtools)

Bei SuperOffice CRM können Sie sich über einen Browser von jedem PC aus anmelden, Ihre Dokumente werden in diesem Fall jedoch auf dem zentralen Server gespeichert. Das Herunter- und Hochladen von Dokumenten erledigt SuperOffice WebTools automatisch.

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein](#fields).

3. Klicken Sie auf die Schaltfläche **Erstellen**, um ein neues Dokument auf Grundlage der ausgewählten [Dokumentvorlage][5] zu erstellen. Das Dialogfeld **Dokument** wird automatisch geschlossen und das Dokument öffnet sich in Ihrem Standardtextbearbeitungsprogramm.

4. Geben Sie den Inhalt des Dokuments ein.

5. Speichern Sie und schließen Sie das Textbearbeitungsprogramm. Das Dokument wird gespeichert.

### [Mit SharePoint-Dokument](#tab/sharepoint)

**Für diese Funktion ist eine Lizenz erforderlich.**

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein](#fields).

3. Klicken Sie auf die Schaltfläche **Erstellen**, um ein neues Dokument auf Grundlage der ausgewählten [Dokumentvorlage][5] zu erstellen. Das Dokument wird in SharePoint erstellt und auf einer neuen Registerkarte mit der Online-Anwendung zur Textbearbeitung (Office Online) geöffnet.

    Wenn Sie das Desktop-Textbearbeitungsprogramm verwenden möchten, können Sie von Office Online **In Desktop-App öffnen** auswählen.

4. Geben Sie den Inhalt des Dokuments ein.

5. Schließen Sie die Registerkarte oder die Desktop-App. Das Dokument wird automatisch in SharePoint gespeichert.

### [Ohne SuperOffice WebTools](#tab/no-webtools)

Wenn Sie SuperOffice WebTools nicht installiert haben, müssen Sie Dokumente zum Bearbeiten manuell herunterladen. Danach müssen Sie die bearbeiteten Dokumente auch wieder auf den zentralen Server hochladen.

> [!NOTE]
> In diesem Verfahren wird beschrieben, wie Sie mit einem Desktop-Textbearbeitungsprogramm neue Dokumente erstellen. Die tatsächliche Schritte können mit einem Online-Textbearbeitungstool (wie Microsoft 365) und einer Dokumentbibliothek (wie SharePoint) leicht abweichen.

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein](#fields).

3. Klicken Sie auf die Schaltfläche **Erstellen**, um ein neues Dokument auf Grundlage der ausgewählten [Dokumentvorlage][5] zu erstellen. Das Dokument wird auf dem Server erstellt.

4. Klicken Sie auf **Öffnen** und **Bearbeiten**.

5. Wählen Sie im Dialogfeld **Datei herunterladen** eine der folgenden Schaltflächen aus:

    * **Öffnen**: Wenn Sie auf **Öffnen** klicken, wird das Dokument im Textbearbeitungsprogramm geöffnet. Geben Sie den Inhalt des Dokuments ein und wählen Sie **Datei** > **Speichern unter**, um die Datei am gewünschten Ort auf Ihrem PC zu speichern.

    * **Speichern**: Wenn Sie auf **Speichern** klicken, wird das Dialogfeld **Speichern unter** angezeigt. Geben Sie an, wo Sie die Datei auf Ihrem PC speichern möchten, und klicken Sie anschließend auf **Speichern**, um das Herunterladen zu starten. Klicken Sie auf **Schließen**, nachdem der Herunterladen-Vorgang fertiggestellt wurde. Öffnen Sie den Windows Explorer und navigieren Sie zum soeben gespeicherten Dokument. Öffnen Sie das Dokument, geben Sie den erforderlichen Text ein und speichern Sie das Dokument.

    > [!NOTE]
    > Änderungen am Dokument werden in SuperOffice nicht automatisch gespeichert. Wenn Sie ein solches Verhalten wünschen, empfehlen wir die Installation von [SuperOffice WebTools][7].

6. Schließen Sie das Textbearbeitungsprogramm.

7. Gehen Sie zum Dialogfeld Dokument.

    > [!NOTE]
    > Wenn **Abgeschlossen** in der Anzeige Dokument aktiviert ist, sind die Optionen Herunterladen deaktiviert. Entfernen Sie in diesem Fall das Häkchen für die Option **Abgeschlossen**.

8. Klicken Sie auf den Link, um das Dokument hochzuladen oder ziehen und legen Sie das Dokument vom Windows Explorer im Dialogfeld **Dokument** ab.

9. Schließen Sie das Dialogfeld **Dokument**, indem Sie auf **Speichern** klicken.

***

## <a id="fields"></a>Wie man Informationen eingibt

> [!NOTE]
> Viele Felder haben eine Liste von vordefinierten Werten, aus denen Sie wählen können. Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i>, um die Liste zu erweitern. Wählen Sie dann einen Wert für dieses Feld. Alternativ können Sie im Feld mit der Eingabe beginnen, um nach einem bestimmten Wert zu suchen, wie zum Beispiel einem Firmennamen.

![Dokument aus Vorlage erstellen (neu) -screenshot][img4]

**Scritte:**

1. Wählen Sie eine [Dokumentvorlage][5]. Wählen Sie eine Sprache für die Vorlage. Diese Option ist nur verfügbar, wenn die ausgewählte Vorlage übersetzte Versionen enthält.

1. Wählen Sie optional ein Unternehmen oder einen Kontakt, auf den sich das Dokument bezieht.

1. Wählen Sie optional ein Projekt und/oder einen Verkauf, um es mit dem Dokument zu verknüpfen. Sie können jedes Projekt/Verkauf unabhängig davon, welches Unternehmen Sie zuvor ausgewählt haben.

1. Geben Sie einen Dokumenttitel im Feld **Betreff** ein. Dieser Text wird in Abschnitts-Tabs und in anderen Dokumentlisten angezeigt.

1. Das heutige **Datum** ist standardmäßig eingestellt. Ändern Sie optional das Erstellungsdatum (klicken Sie, um den Datumswähler zu öffnen).

    > [!NOTE]
    > Sie können dieses Datum nicht mehr ändern, nachdem Sie auf die Schaltfläche **Erstellen** geklickt haben (das Feld wird schreibgeschützt).

1. Geben Sie Referenzen ein:

    * **Unsere Ref.:** Geben Sie Ihre eigene Referenz ein. Der Standardwert für jede Vorlage wird in den Einstellungen und der Wartung definiert, aber Sie können den Inhalt dieses Feldes auch bearbeiten.
    * **Ihre Ref.:** Geben Sie die Referenz des Adressaten aus ihrer Kommunikation ein.

### Weitere Einstellungen (optional)

* Geben Sie im Tab **Details** eine Beschreibung des Dokuments (oder Schlüsselwörter) ein, um die Freitextsuche zu erleichtern.

* Klicken Sie im Tab **Links** auf **Link hinzufügen**, um [das Dokument mit anderen Aktivitäten zu verknüpfen][9].

* Legen Sie im Tab **Mehr** alle [benutzerdefinierten Felder][10] fest, die in den Einstellungen und der Wartung konfiguriert sind.

## <a id="upload"></a>Dokumente hochladen

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. Ziehen Sie das Dokument aus dem Windows Explorer in das Dialogfeld **Dokument** und legen Sie es dort ab.

3. (Optional) Wählen Sie das Kontrollkästchen in der Fußzeile aus, um das Dokument als abgeschlossen zu markieren.

4. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein](#fields).

5. Klicken Sie auf die Schaltfläche **Erstellen**, um in SuperOffice CRM ein neues Dokument zu erstellen. Das Dokument wird zur Bereichsregisterkarte **Aktivitäten** hinzugefügt.

## Verwandte Inhalte

* [Dokumente bearbeiten][1]
* [Dokumente ein-/auschecken][3]
* [E-Mail archivieren][8]
* [E-Mail-Anhänge von SuperOffice senden][4]
* [Dokumentvorlagen in Einstellungen und Verwaltung verwalten][6]

<!-- Referenced links -->
[1]: edit.md
[3]: lock.md
[4]: send-as-email.md
[5]: ../templates/learn/index.md
[6]: ../templates/admin/link-template.md
[7]: ../../webtools/learn/install.md
[8]: ../../email/mail-link/learn/archive.md
[9]: ../../learn/basics/links.md
[10]: ../../custom-objects/learn/udef.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/document/create-document.png
