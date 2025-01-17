---
uid: help-de-project-guide-create
title: Neuen Projektleitfaden erstellen
description: Wie man einen neuen Projektleitfaden in SuperOffice erstellt
author: SuperOffice RnD
so.date: 02.23.2023
keywords: Projekt, Leitfaden, Workflow
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Neuen Projektleitfaden erstellen

[!include[Must be admin](../../../learn/includes/req-admin.md)]

In SuperOffice Einstellungen und Verwaltung wird festgelegt, welche Projektarten einem Projektleitfaden zugewiesen werden und welche Status und Aktivitäten ein Projektleitfaden enthalten soll. Das Erscheinungsbild der Projektleitfäden kann deshalb variieren. Im Folgenden erhalten Sie ein Beispiel dafür, wie ein Projekt mithilfe eines Projektleitfadens dargestellt werden kann.

Sie haben zum Beispiel ein Projekt mit der Bezeichnung **Konferenz**. Dieser Projekttyp kann mit einem Projektleitfaden verknüpft sein, der die folgenden Status, Folgeaufgaben und Dokumente enthält:

| Status | Folgeaufgaben | Dokumente |
|---|---|---|
| Geplant | Recherche (Meeting (intern)) | Konferenzprogramm (Notiz) |
| In Bearbeitung | Liste der Projektmitglieder (Aufgabe) erstellen; Konferenz (Meeting (extern)) | Konferenzeinladung (Brief) |
| Wird beendet | Auswertungsmeeting (Meeting (intern)) | Auswertungsbericht (Notiz) |

Nachstehend wird die Vorgehensweise zur Erstellung eines komplett neuen Projektleitfadens beschrieben.

1. Legen Sie die [Status](#create-stage) fest, die der Projektleitfaden einbeziehen soll.
2. Legen Sie den [Projekttyp](#create-type) (mit den zugehörigen Status) fest, mit dem der Projektleitfaden verknüpft werden soll.
3. Entwerfen Sie den [Projektleitfaden](#create-guide).

![Gehen Sie zum Abschnitt Workflow und erstellen Sie Ihre eigenen Projektroutinen in SuperOffice CRM -screenshot][img2]

## <a id="create-stage" />Status für den Projektleitfaden erstellen

Der Projektleitfaden muss mit einem Projekttyp verknüpft werden, der wiederum aus mehreren Status besteht. [Wie man einen Status erstellt][2].

Ein Projektleitfaden für ein Projekt des Konferenztyps kann zum Beispiel die Status Geplant, In Bearbeitung und Wird beendet haben.

Im nächsten Schritt können Sie die Status mit einem Projekttyp verknüpfen.

## <a id="create-type" /> Projekttyp für den Projektleitfaden erstellen

Der Projektleitfaden muss mit einem Projekttyp verknüpft werden. [Wie man einen Projekttyp erstellt][3].

Mögliche Projekttypen sind z. B.: "Konferenz", "Kampagne" und "Intern".

1. Aktivieren Sie die Option **Dieser Projekttyp ist mit einem Leitfaden verknüpft**.
1. Wählen Sie zumindest zwei Status aus.
1. Im nächsten Schritt können Sie den Projektleitfaden erstellen.

## <a id="create-guide" />Projektleitfaden erstellen

Nachdem Sie die Status erstellt und einen Projekttyp für den Projektleitfaden festgelegt haben, können Sie den eigentlichen Projektleitfaden gestalten. Dazu fügen Sie Folgeaufgaben und/oder Dokumente für jeden Status im Projektleitfaden hinzu.

1. Klicken auf die Schaltfläche **Workflow** im Navigator (![Symbol][img1]).

2. Wählen Sie die Registerkarte **Projektleitfaden**.

3. Wählen Sie in der Liste **Projekttyp** den Projekttyp aus, für den Sie einen Projektleitfaden erstellen möchten. Die für diesen Projekttyp ausgewählten Status werden in der Liste oben angezeigt.

    > [!NOTE]
    > Wenn für diese Projektart kein Projektleitfaden definiert ist, müssen Sie unten in der Ansicht auf **Hier klicken, um Leitfaden zu aktivieren** klicken.
    >
    > Wenn für den Projekttyp keine Status festgelegt sind, müssen Sie unten in der Ansicht auf **Hier klicken, um Status hinzuzufügen** klicken. Sie können den Projekttyp auch bearbeiten, indem Sie oben auf die Schaltfläche **Bearbeiten** klicken.

4. Wählen Sie den gewünschte Status in der Liste aus. Die Einzelheiten zu diesem Status werden unten in der Ansicht angezeigt.

5. [Einen oder mehrere Folgeaufgaben für den ausgewählten Status hinzufügen](#add-fo-status).

    > [!NOTE]
    > Sie müssen für die einzelnen Status nicht unbedingt ein Dokument hinzufügen, sollten jedoch zumindest eine Folgeaufgabe pro Status hinzufügen.

6. [Ein oder mehrere Dokumente für den ausgewählten Status hinzufügen](#add-doc-status).

7. Wiederholen Sie die Schritte 4 bis 6 für jeden Status, dem Sie Folgeaufgaben und Dokumente hinzufügen möchten.

Die Änderungen werden automatisch gespeichert. Der betreffende Projektleitfaden wird in SuperOffice CRM angezeigt, wenn ein Projekt mit einer Projektart, die in Schritt B ausgewählt wurde, erstellt wird.

## <a id="add-fo-status" />Folgeaufgabe für einen Status hinzufügen

1. Wählen Sie den gewünschten Projekttyp und den Status wie oben beschrieben aus.

2. Klicken Sie unter **Vorgeschlagene Folgeaufgaben in Status** auf **Hinzufügen**.

3. Geben Sie im Dialogfeld **Vorgeschlagene Folgeaufgabe** den Namen der Folgeaufgabe in das Feld **Name** ein. Es sollte sich dabei um einen aussagekräftigen Namen der Folgeaufgabe handeln.

4. Geben Sie den Zweck der Folgeaufgabe in das Feld**Zweck dieser Folgeaufgabe** ein. Dieser Text wird angezeigt, wenn Sie den Mauszeiger auf der Bereichsregisterkarte **Projektleitfaden** in SuperOffice CRM auf die Folgeaufgabe bewegen.

    > [!NOTE]
    > Einige der oben aufgeführten Optionen sind aus logischen Gründen nicht relevant für die erste Folgeaufgabe eines Projektleitfadens.

5. Aktivieren Sie die Option **Folgeaufgabe zu Projektmitglied zuweisen**, wenn Sie diese Folgeaufgabe einem der Projektteilnehmer zuweisen möchten. Wenn der Projekteigentümer diese Folgeaufgabe in SuperOffice CRM erstellt, kann er einen der Mitarbeiter auswählen, die Eigentümer der Folgeaufgabe sein sollen.

6. Aktivieren Sie die Option **Meilenstein-Folgeaufgabe**, um die Folgeaufgabe als Meilenstein zu definieren.

7. Wählen Sie in der Liste **Typ der Folgeaufgabe** einen Typ für die Folgeaufgabe aus.

8. Geben Sie im Feld **Startdatum** das Datum ein, an dem die Folgeaufgabe beginnen soll (als Anzahl an Tagen ab heute).

9. Geben Sie im Feld **Dauer** an, wie lange die Folgeaufgabe dauern soll. Das Format hierfür ist *0 h 00 m*.

10. Geben Sie in das Feld **Standardtext in Folgeaufgabe** eine Beschreibung für die Folgeaufgabe ein.

    > [!TIP]
    > Der Benutzer kann die obigen Informationen bei Bedarf ändern.

11. Klicken Sie auf **Speichern**.

12. Wiederholen Sie diesen Vorgang, wenn Sie weitere Folgeaufgaben zu diesem oder zu einem anderen Status hinzufügen möchten.

### Beispiel für eine Folgeaufgabe

**Projekttyp**: Konferenz
**Status**: Geplant
**Name** der Folgeaufgabe: Planung der Konferenz
**Zweck dieser Folgeaufgabe**: Abhalten einer Besprechung zur Planung der Konferenz und Festlegen eines Konferenzprogramms
**Typ der Folgeaufgabe**: Meeting (intern)
**Dauer**: 1 Stunde
**Standardtext**:

Recherche:

\- Was soll die Konferenz abdecken?
\- Teilnehmer?
\- Redner?
\- Wo?

## <a id="add-doc-status" />Dokument für einen Status hinzufügen

1. Wählen Sie den gewünschten Projekttyp und den Status wie oben beschrieben aus.
2. Klicken Sie unter **Vorgeschlagene Dokumente in Status** auf **Hinzufügen**.
3. Geben Sie im Dialogfeld **Vorgeschlagenes Dokument** den Namen des Dokuments in das Feld **Name** ein. Es sollte sich dabei um eine aussagekräftige Bezeichnung des Dokuments handeln.
4. Geben Sie den Zweck des Dokuments in das Feld **Zweck dieses Dokuments** ein. Dieser Text wird angezeigt, wenn Sie den Mauszeiger auf der Bereichsregisterkarte **Projektleitfaden** in SuperOffice CRM auf das Dokument bewegen.
5. Wählen Sie die gewünschte Vorlage im Feld **Vorlage** aus (siehe auch [Dokument - Vorlage][4]).
6. Wählen Sie den im Dokument zu verwendenden Betreff im Feld **Standardbetreff** aus.
7. Geben Sie Ihr Zeichen in das Feld **Unser Zeichen** ein. Hier können Sie zum Beispiel eine [Vorlagenvariable][1] für eine Projektnummer, einen Projekttitel oder ein anderes Feld angeben, das mit dem Projekt verknüpft ist.
8. Klicken Sie auf **Speichern**.
9. Wiederholen Sie diesen Vorgang, wenn Sie weitere Dokumente zu diesem oder zu anderen Status hinzufügen möchten.

### Beispiel für ein Dokument

**Projekttyp**: Konferenz
**Status**: Geplant
**Name** des Dokuments: Konferenzprogramm
**Zweck dieses Projektstatus**: Festlegen eines Konferenzprogramms
**Vorlage**: Notiz
**Standardbetreff**: Konferenzprogramm

## Verwandt

* [Projektleitfaden bearbeiten][5]
* [Projektleitfaden deaktivieren][6]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/from-project-card.html
[2]: ../../../admin/lists/learn/project-status.md
[3]: ../../../admin/lists/learn/project-type.md
[4]: ../../../admin/lists/learn/document-template.md
[5]: edit.md
[6]: deactivate.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
[img2]: ../../../../media/loc/en/project/create-project-guide.png
