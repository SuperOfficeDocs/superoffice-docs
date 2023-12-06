---
uid: help-de-document-update
title: Dokumente bearbeiten
description: Dokumente bearbeiten
author: SuperOffice RnD
so.date: 12.06.2023
keywords: Dokument
so.topic: howto
language: de
---

# Dokumente bearbeiten

Das Bearbeiten von Dokumenten beinhaltet zwei Schritte:

* Bearbeiten von Dokumenteigenschaften in der Anzeige Dokument.
* Bearbeiten der Dokumentdatei in der Anwendung, in der das Dokument erstellt wurde.

Sie können Dokumente im [Bearbeitungs- oder im Lesemodus][1] öffnen. Wenn Sie ein Dokument im Bearbeitungsmodus öffnen, können nur Sie selbst es bearbeiten. Andere Benutzer können das Dokument im Lesemodus öffnen.

Wenn Ihre Organisation eine Dokumentbibliothek wie SharePoint nutzt, können mehrere Personen ein Dokument gleichzeitig bearbeiten.

> [!NOTE]
> Für diese Funktion ist eine Lizenz erforderlich.

Befolgen Sie die jeweiligen Anweisungen für die Art und Weise, wie Dokumente in Ihrer SuperOffice-Installation verwaltet werden:

## Wie weiß ich, ob ich SharePoint, SuperOffice WebTools verwende oder nicht?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Dokumenteigenschaften in der Anzeige Dokument bearbeiten

Verwenden Sie die Ansicht Dokument, um die Dokumenteigenschaften zu ändern, wie zum Beispiel das Projekt, mit dem das Dokument verknüpft ist:

1. [Wählen Sie das gewünschte Dokument aus][2].
2. Klicken Sie mit der rechten Maustaste und wählen Sie **Dokument**. Wenn Sie auf das Dokument doppelklicken, wird es direkt in dem Programm geöffnet, in dem es erstellt wurde.
3. [Nehmen Sie die erforderlichen Änderungen vor][3].
4. Klicken Sie auf die Schaltfläche **Speichern**.

## Inhalte in SharePoint-Dokumenten bearbeiten

1. [Doppelklicken Sie auf das gewünschte Dokument][2]. Das Dokument wird mit dem Online-Textbearbeitungsprogramm (Office Online) auf einer neuen Registerkarte geöffnet.

    > [!NOTE]
    > Wenn Sie das Desktop-Textbearbeitungsprogramm verwenden möchten, können Sie von Office Online **In Desktop-App öffnen** auswählen.

2. Bearbeiten Sie das Dokument.

3. Schließen Sie die Registerkarte oder die Desktop-App. Das Dokument wird automatisch in SharePoint gespeichert.

## Dokumentinhalte ohne SuperOffice Web Tools bearbeiten

> [!NOTE]
> In diesem Verfahren wird beschrieben, wie Sie mit einem Desktop-Textbearbeitungsprogramm neue Dokumente erstellen. Die tatsächliche Schritte können mit einem Online-Textbearbeitungstool (wie Microsoft Office Online) und einer Dokumentbibliothek (wie SharePoint) leicht abweichen.

1. [Doppelklicken Sie auf das gewünschte Dokument][2].
2. Klicken Sie im Dialogfeld **Dokument** auf **Öffnen**.
3. Klicken Sie auf **Bearbeiten**, wenn ein Dialogfeld geöffnet wird.
4. Wählen Sie eine der folgenden Optionen im Dialogfeld Datei herunterladen aus:
    * **Öffnen**: Wenn Sie auf die Option zum Öffnen klicken, wird das Dokument im Textbearbeitungsprogramm geöffnet. Geben Sie den Inhalt des Dokuments ein und wählen Sie **Datei** > **Speichern unter**, um die Datei am gewünschten Ort auf Ihrem PC zu speichern.
    * **Speichern**: Wenn Sie auf die Option zum Speichern klicken, wird das Dialogfeld **Speichern unter** angezeigt. Geben Sie an, wo auf dem PC die Datei gespeichert werden soll, und speichern Sie sie. Öffnen Sie anschließend das Dokument, geben Sie den erforderlichen Text ein und speichern Sie das Dokument.
5. Schließen Sie das Textbearbeitungsprogramm.
6. Wechseln Sie zum Dialogfeld **Dokument**.

    > [!NOTE]
    > Wenn im Dialogfeld **Dokument** **Abgeschlossen** aktiviert ist, sind die Optionen für das Hochladen deaktiviert. Entfernen Sie in diesem Fall das Häkchen für die Option **Abgeschlossen**.

7. Klicken Sie auf den Link, um das Dokument hochzuladen oder ziehen und legen Sie das Dokument vom Windows Explorer im Dialogfeld **Dokument** ab.

    ![Neues Dokument erstellen -screenshot][img1]

8. Schließen Sie das Dialogfeld **Dokument**, indem Sie auf **Speichern** klicken. Das Dokument wird eingecheckt und erhält den Status **Abgeschlossen**.

## Dokumentinhalt mit SuperOffice WebTools bearbeiten

1. [Doppelklicken Sie auf das gewünschte Dokument][2].
2. Klicken Sie auf **Bearbeiten**, wenn ein Dialogfeld geöffnet wird.
3. Speichern Sie und schließen Sie das Textbearbeitungsprogramm.
4. (falls zutreffend) Klicken Sie in dem angezeigten Dialogfeld auf **Ja**, wenn Sie mit der Bearbeitung des Dokuments fertig sind. Klicken Sie auf **Nein**, wenn das Dokument weiterhin ausgecheckt bleiben soll.

    Dieses Dialogfeld wird nur angezeigt, wenn diese Option in SuperOffice WebTools aktiviert wurde.

5. Das Dokument wird eingecheckt und erhält den Status **Abgeschlossen**.

### <a id="allow" />Browser-Sicherheitsfrage beim Öffnen von Dateien

Wenn Sie auf ein Dokument, eine Datei oder eine E-Mail in SuperOffice zugreifen und diese bearbeiten, fordert Ihr Browser Sie mit einer *Sicherheitsfrage* zur Dateiherunterladung auf.

* Um die Datei zu öffnen, müssen Sie die Schaltfläche **Öffnen**/**Zulassen** auswählen.
* Wählen Sie **Immer zulassen**, um die Frage beim nächsten Mal zu überspringen.

Die Dialogbox sieht in Chrome, Edge, Firefox und Safari etwas anders aus.

**Chrome:** Wählen Sie **Öffnen URL:SuperOffice-Extensions** aus.

![Chrome: Öffnen URL:SuperOffice-Extensions button -screenshot][img5]

**Edge:** Wählen Sie **Öffnen** aus.

![Edge: Öffnen button -screenshot][img2]

**Firefox:** Wählen Sie **Link öffnen** aus.

![Firefox: Link öffnen button -screenshot][img3]

**Safari:** Wählen Sie **Immer erlauben** oder **Erlauben** aus.

![Safari: Immer erlauben oder Erlauben button -screenshot][img4]

## Fehlerbehebung

Wenn Sie auf ein Dokument doppelklicken und nichts geschieht, klicken Sie mit der rechten Maustaste darauf und wählen Sie **Dokument**. Dadurch wird das Dialogfeld **Dokument** geöffnet. Klicken Sie auf **Öffnen** und überprüfen Sie, ob das Dokument jetzt geöffnet wird.

<!-- Referenced links -->
[1]: lock.md
[2]: open.md
[3]: screen/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/document/upload.png
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
