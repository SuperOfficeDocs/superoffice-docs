---
uid: help-de-document-create
title: Neues Dokument erstellen
description: "Erstellen Sie ein neues Dokument direkt in SuperOffice CRM oder laden Sie ein bestehendes hoch, um sicherzustellen, dass Sie und Ihre Kollegen immer Zugriff auf die neuesten Dokumente und Versionen haben. Diese Anleitung zeigt Ihnen, wie Sie beides machen können."
author: SuperOffice RnD
date: 02.10.2023
keywords: Dokument
topic: howto
language: de
---

# Neue Dokumente erstellen

> [!TIP]
> Haben Sie bereits das Dokument? Siehe [Dokumente hochladen][1].

Befolgen Sie die jeweiligen Anweisungen für die Art und Weise, wie Dokumente in Ihrer SuperOffice-Installation verwaltet werden:

> [!NOTE]
> Für diese Funktion ist eine Lizenz erforderlich.

## Wie weiß ich, ob ich SharePoint, SuperOffice WebTools verwende oder nicht?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Neues Dokument als SharePoint-Dokument erstellen

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein][2].

3. Klicken Sie auf die Schaltfläche **Erstellen**, um ein neues Dokument auf Grundlage der ausgewählten Dokumentvorlage zu erstellen. Das Dokument wird in SharePoint erstellt und auf einer neuen Registerkarte mit der Online-Anwendung zur Textbearbeitung (Office Online) geöffnet.

    > [!NOTE]
    > Wenn Sie das Desktop-Textbearbeitungsprogramm verwenden möchten, können Sie von Office Online **In Desktop-App öffnen** auswählen.

4. Geben Sie den Inhalt des Dokuments ein.

5. Schließen Sie die Registerkarte oder die Desktop-App. Das Dokument wird automatisch in SharePoint gespeichert.

## Neues Dokument ohne SuperOffice WebTools erstellen

Wenn Sie SuperOffice WebTools nicht installiert haben, müssen Sie Dokumente zum Bearbeiten manuell herunterladen. Danach müssen Sie die bearbeiteten Dokumente auch wieder auf den zentralen Server hochladen.

> [!NOTE]
> In diesem Verfahren wird beschrieben, wie Sie mit einem Desktop-Textbearbeitungsprogramm neue Dokumente erstellen. Die tatsächliche Schritte können mit einem Online-Textbearbeitungstool (wie Microsoft Office Online) und einer Dokumentbibliothek (wie SharePoint) leicht abweichen.

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein][2].

3. Klicken Sie auf die Schaltfläche **Erstellen**, um ein neues Dokument auf Grundlage der ausgewählten Dokumentvorlage zu erstellen. Das Dokument wird auf dem Server erstellt.

4. Klicken Sie auf **Öffnen** und **Bearbeiten**.

5. Wählen Sie im Dialogfeld **Datei herunterladen** eine der folgenden Schaltflächen aus:

    * **Öffnen**: Wenn Sie auf **Öffnen** klicken, wird das Dokument im Textbearbeitungsprogramm geöffnet. Geben Sie den Inhalt des Dokuments ein und wählen Sie **Datei** > **Speichern unter**, um die Datei am gewünschten Ort auf Ihrem PC zu speichern.

    * **Speichern**: Wenn Sie auf **Speichern** klicken, wird das Dialogfeld **Speichern unter** angezeigt. Geben Sie an, wo Sie die Datei auf Ihrem PC speichern möchten, und klicken Sie anschließend auf **Speichern**, um das Herunterladen zu starten. Klicken Sie auf **Schließen**, nachdem der Herunterladen-Vorgang fertiggestellt wurde. Öffnen Sie den Windows Explorer und navigieren Sie zum soeben gespeicherten Dokument. Öffnen Sie das Dokument, geben Sie den erforderlichen Text ein und speichern Sie das Dokument.

6. Schließen Sie das Textbearbeitungsprogramm.

7. Gehen Sie zum Dialogfeld Dokument.

    > [!NOTE]
    > Wenn ![Symbol][img1] **Abgeschlossen** in der Anzeige Dokument aktiviert ist, sind die Optionen Herunterladen deaktiviert. Entfernen Sie in diesem Fall das Häkchen für die Option **Abgeschlossen**.

8. Klicken Sie auf den Link, um das Dokument hochzuladen oder ziehen und legen Sie das Dokument vom Windows Explorer im Dialogfeld **Dokument** ab.

    ![Neues Dokument erstellen -screenshot][img2]

9. Schließen Sie das Dialogfeld **Dokument**, indem Sie auf **Speichern** klicken.

## Neues Dokument mit SuperOffice WebTools erstellen

Bei SuperOffice CRM können Sie sich über einen Browser von jedem PC aus anmelden, Ihre Dokumente werden in diesem Fall jedoch auf dem zentralen Server gespeichert. Das Herunter- und Hochladen von Dokumenten erledigt SuperOffice WebTools automatisch.

1. Klicken Sie auf der oberen Leiste auf **Neu** > **Dokument**.

2. [Geben Sie die erforderlichen Informationen in die betreffenden Felder ein][2].

3. Klicken Sie auf die Schaltfläche **Erstellen**, um ein neues Dokument auf Grundlage der ausgewählten Dokumentvorlage zu erstellen. Das Dialogfeld **Dokument** wird automatisch geschlossen und das Dokument öffnet sich in Ihrem Standardtextbearbeitungsprogramm.

4. Geben Sie den Inhalt des Dokuments ein.

5. Speichern Sie und schließen Sie das Textbearbeitungsprogramm. Das Dokument wird gespeichert.

## Verwandte Themen

* [WebTools][3]
* [E-Mail-Anhänge von SuperOffice senden][4]
* [Dokumentvorlagen in Einstellungen und Verwaltung verwalten][5]

<!-- Referenced links -->
[1]: upload.md
[2]: screen/index.md
[3]: ../../webtools/learn/index.md
[4]: send-as-email.md
[5]: ../../admin/lists/learn/add-template.md

<!-- Referenced images -->
[img1]: ../../../media/icons/followup-completed-small.png
[img2]: ../../../media/loc/en/document/upload.png
