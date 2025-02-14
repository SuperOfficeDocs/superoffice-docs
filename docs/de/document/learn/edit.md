---
uid: help-de-document-update
title: Dokumente bearbeiten
description: Dokumente bearbeiten
keywords: Dokument bearbeiten, Dokumenteigenschaften, Dokument
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Dokumente bearbeiten

Das Bearbeiten von Dokumenten beinhaltet zwei Schritte:

* Bearbeiten von Dokumenteigenschaften in der Anzeige Dokument.
* Bearbeiten der Dokumentdatei in der Anwendung, in der das Dokument erstellt wurde.

Sie können Dokumente im [Bearbeitungs- oder im Lesemodus][1] öffnen. Wenn Sie ein Dokument im Bearbeitungsmodus öffnen, können nur Sie selbst es bearbeiten. Andere Benutzer können das Dokument im Lesemodus öffnen. Wenn Ihre Organisation eine Dokumentbibliothek wie SharePoint nutzt, können mehrere Personen ein Dokument gleichzeitig bearbeiten.

## Dokumenteigenschaften in der Anzeige Dokument bearbeiten

Verwenden Sie das Dialogfeld Dokument, um die Dokumenteigenschaften zu ändern, wie zum Beispiel das Projekt, mit dem das Dokument verknüpft ist:

1. Wählen Sie das gewünschte Dokument aus.

2. Klicken Sie mit der rechten Maustaste und wählen Sie **Dokument**. Wenn Sie auf das Dokument doppelklicken, wird es direkt in dem Programm geöffnet, in dem es erstellt wurde.

3. [Nehmen Sie die erforderlichen Änderungen vor][3].

4. Klicken Sie auf die Schaltfläche **Speichern**.

> [!NOTE]
> Erledigte Dokumente können Sie nur bearbeiten, wenn Sie den Status **Abgeschlossen** aufheben.

## Inhalte bearbeiten

Befolgen Sie die jeweiligen Anweisungen für die Art und Weise, wie Dokumente in Ihrer SuperOffice-Installation verwaltet werden.

<!-- markdownlint-disable-file MD051 -->
### [Mit SuperOffice WebTools](#tab/webtools)

1. Doppelklicken Sie auf das gewünschte Dokument.

1. Klicken Sie auf **Bearbeiten**, wenn ein Dialogfeld geöffnet wird.

1. Nehmen Sie die erforderlichen Änderungen vor.

1. Speichern Sie und schließen Sie das Textbearbeitungsprogramm.

1. (falls zutreffend) Klicken Sie in dem angezeigten Dialogfeld auf **Ja**, wenn Sie mit der Bearbeitung des Dokuments fertig sind. Klicken Sie auf **Nein**, wenn das Dokument weiterhin ausgecheckt bleiben soll.

    Dieses Dialogfeld wird nur angezeigt, wenn diese Option in SuperOffice WebTools aktiviert wurde.

1. Das Dokument wird eingecheckt und erhält den Status **Abgeschlossen**.

### [Mit SharePoint](#tab/sharepoint)

**Für diese Funktion ist eine Lizenz erforderlich.**

1. Doppelklicken Sie auf das gewünschte Dokument. Das Dokument wird mit dem Online-Textbearbeitungsprogramm (Office Online) auf einer neuen Registerkarte geöffnet.

    Wenn Sie das Desktop-Textbearbeitungsprogramm verwenden möchten, können Sie von Office Online **In Desktop-App öffnen** auswählen.

2. Bearbeiten Sie das Dokument.

3. Schließen Sie die Registerkarte oder die Desktop-App. Das Dokument wird automatisch in SharePoint gespeichert.

### [Ohne SuperOffice Web Tools](#tab/no-webtools)

> [!NOTE]
> In diesem Verfahren wird beschrieben, wie Sie mit einem Desktop-Textbearbeitungsprogramm neue Dokumente erstellen. Die tatsächliche Schritte können mit einem Online-Textbearbeitungstool (wie Microsoft Office Online) und einer Dokumentbibliothek (wie SharePoint) leicht abweichen.

1. Doppelklicken Sie auf das gewünschte Dokument.

2. Klicken Sie im Dialogfeld **Dokument** auf **Öffnen**.

3. Klicken Sie auf **Bearbeiten**, wenn ein Dialogfeld geöffnet wird.

4. Im Dialogfeld **Datei herunterladen** wählen Sie **Öffnen** oder **Speichern**. Anschließend folgen Sie den Schritten 5-9 aus dem Verfahren [Dokument ohne WebTools erstellen][2].

***

### <a id="allow"></a>Browser-Sicherheitsfrage beim Öffnen von Dateien

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

## <a id="delete"></a>Dokumente löschen

### Aus der Bereichsregisterkarte Aktivitäten

1. Wählen Sie das gewünschte Dokument in der Ansicht Firma, Person, Kalender, Verkauf oder Projekt in der Bereichsregisterkarte **Aktivitäten** aus.

2. Klicken Sie mit der rechten Maustaste und wählen Sie **Löschen**.

3. Bestätigen oder abbrechen Sie die Löschung im Bestätigungsdialog.

### Aus dem Dokument-Dialog

Beim Anzeigen eines bestimmten Dokuments:

1. Klicken Sie auf die Schaltfläche **Aufgabe** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) im **Dokument**-Dialog.
2. Wählen Sie **Löschen**.
3. Bestätigen oder abbrechen Sie die Löschung im Bestätigungsdialog.

## Fehlerbehebung

Wenn Sie auf ein Dokument doppelklicken und nichts geschieht, klicken Sie mit der rechten Maustaste darauf und wählen Sie **Dokument**. Dadurch wird das Dialogfeld **Dokument** geöffnet. Klicken Sie auf **Öffnen** und überprüfen Sie, ob das Dokument jetzt geöffnet wird.

### Wie weiß ich, ob ich SharePoint, SuperOffice WebTools verwende oder nicht?

[!include[How to check document library](includes/webtools-or-sharepoint.md)]

## Verwandte Themen

* [Wie man den Status Abgeschlossen für eine Aktivität ändert][4]

<!-- Referenced links -->
[1]: lock.md
[2]: create.md
[3]: create.md#fields
[4]: ../../diary/learn/change-completed-status.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-edge-security-question.png
[img3]: ../../../media/loc/en/webtools/webtools-firefox-security-question.png
[img4]: ../../../media/loc/en/webtools/webtools-safari-security-question.png
[img5]: ../../../media/loc/en/webtools/webtools-chrome-security-question.png
