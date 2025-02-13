---
uid: help-de-project-guide-create
title: Neuen Projektleitfaden erstellen
description: Erfahren Sie, wie Sie in SuperOffice CRM einen neuen Projektleitfaden erstellen. Definieren Sie Statuswerte, legen Sie Projekttypen fest und verknüpfen Sie Folgeaufgaben und Dokumente für eine optimierte Projektsteuerung.
keywords: Projektleitfaden erstellen, neuer Projektleitfaden, Projektleitfaden, Leitfaden, Workflow, Projekt
author: SuperOffice RnD
date: 02.11.2025
version: 10.5.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Neuen Projektleitfaden erstellen

[!include[Muss Admin sein](../../learn/includes/req-admin.md)]

In Einstellungen und Verwaltung definieren Sie, welche Projekttypen mit einem Projektleitfaden verknüpft werden und welche Statuswerte sowie Aktivitäten enthalten sein sollen. Das Erscheinungsbild eines Projektleitfadens kann daher variieren.

Sie haben zum Beispiel ein Projekt mit der Bezeichnung **Konferenz**. Dieser Projekttyp kann mit einem Projektleitfaden verknüpft sein, der die folgenden Status, Folgeaufgaben und Dokumente enthält:

| Status | Folgeaufgaben | Dokumente |
|---|---|---|
| Geplant | Recherche (Meeting (intern)) | Konferenzprogramm (Notiz) |
| In Bearbeitung | Liste der Projektmitglieder (Aufgabe) erstellen; Konferenz (Meeting (extern)) | Konferenzeinladung (Brief) |
| Wird beendet | Auswertungsmeeting (Meeting (intern)) | Auswertungsbericht (Notiz) |

Dieses Verfahren zeigt, wie Sie einen Projektleitfaden von Grund auf neu erstellen.

1. Definieren Sie die [Statuswerte](#create-stage), die in den Projektleitfaden aufgenommen werden sollen.
2. Erstellen Sie den [Projekttyp](#create-type) und verknüpfen Sie ihn mit den Statuswerten.
3. Entwerfen Sie den [Projektleitfaden](#create-guide).

![Gehen Sie zum Abschnitt Workflow und erstellen Sie Ihre eigenen Projektabläufe in SuperOffice CRM -screenshot][img2]

## <a id="create-stage"></a>Statuswerte für den Projektleitfaden erstellen

Ein Projektleitfaden muss mit einem Projekttyp verknüpft sein, der wiederum aus mehreren Statuswerten besteht. [So erstellen Sie einen Status][2].

Beispiel: Ein Projektleitfaden für einen Projekttyp "Konferenz" könnte die Status **Geplant**, **In Bearbeitung** und **Wird beendet** enthalten.

Fahren Sie mit dem nächsten Abschnitt fort, um die Statuswerte mit einem Projekttyp zu verknüpfen.

## <a id="create-type"></a> Projekttyp für den Projektleitfaden erstellen

Ein Projektleitfaden muss mit einem Projekttyp verknüpft sein. [So erstellen Sie einen Projekttyp][3].

Beispiele für Projekttypen: **Konferenz**, **Kampagne**, **Intern**.

1. Aktivieren Sie die Option **Dieser Projekttyp ist mit einem Leitfaden verknüpft**.
1. Wählen Sie mindestens zwei Statuswerte aus.
1. Fahren Sie mit dem nächsten Abschnitt fort, um den Projektleitfaden zu konfigurieren.

## <a id="create-guide"></a>Projektleitfaden erstellen

Nachdem Sie die Statuswerte definiert und einen Projekttyp zugewiesen haben, können Sie den Projektleitfaden konfigurieren. Dazu fügen Sie Folgeaufgaben und/oder Dokumente für jeden Status hinzu.

1. Wählen Sie <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** im Navigator.

2. Öffnen Sie die Registerkarte **Projektleitfaden**.

3. Wählen Sie im Dropdown-Menü **Projekttyp** den Projekttyp aus, für den Sie einen Projektleitfaden erstellen möchten. Die zugewiesenen Statuswerte werden oben angezeigt.

    > [!NOTE]
    > Falls der Projekttyp noch keinen Projektleitfaden hat, klicken Sie auf **Hier klicken, um Leitfaden zu aktivieren**.
    >
    > Falls dem Projekttyp keine Statuswerte zugewiesen sind, klicken Sie auf **Hier klicken, um Status hinzuzufügen** oder wählen Sie **Bearbeiten**.

4. Wählen Sie einen Status aus der Liste. Die zugehörigen Details werden unten angezeigt.

5. [Fügen Sie eine oder mehrere Folgeaufgaben für diesen Status hinzu](#add-fo-status).

    > [!NOTE]
    > Sie müssen für jeden Status mindestens eine Folgeaufgabe hinzufügen.

6. [Fügen Sie eine oder mehrere Dokumente für diesen Status hinzu](#add-doc-status).

7. Wiederholen Sie die Schritte 4-6 für alle Statuswerte.

Die Änderungen werden automatisch gespeichert. Der Projektleitfaden wird nun in SuperOffice CRM angezeigt, wenn ein Projekt mit diesem Projekttyp erstellt wird.

## <a id="add-fo-status"></a>Folgeaufgabe für einen Status hinzufügen

1. Wählen Sie den gewünschten Projekttyp und Status aus.

2. Klicken Sie unter **Vorgeschlagene Folgeaufgaben in Status** auf **Hinzufügen**.

3. Geben Sie im Dialogfeld **Vorgeschlagene Folgeaufgabe** einen Namen für die Folgeaufgabe ein. Es sollte sich dabei um einen aussagekräftigen Namen der Folgeaufgabe handeln.

4. Geben Sie im Feld **Zweck dieser Folgeaufgabe** eine Beschreibung ein. Dieser Text wird angezeigt, wenn Sie den Mauszeiger auf der Bereichsregisterkarte **Projektleitfaden** in SuperOffice CRM auf die Folgeaufgabe bewegen.

    > [!NOTE]
    > Einige der oben aufgeführten Optionen sind aus logischen Gründen nicht relevant für die erste Folgeaufgabe eines Projektleitfadens.

5. Aktivieren Sie **Folgeaufgabe zu Projektmitglied zuweisen**, wenn die Folgeaufgabe einem Projektmitglied zugewiesen werden kann. Wenn der Projekteigentümer diese Folgeaufgabe in SuperOffice CRM erstellt, kann er einen der Mitarbeiter auswählen, die Eigentümer der Folgeaufgabe sein sollen.

6. Aktivieren Sie **Meilenstein-Folgeaufgabe**, um diese als Meilenstein zu definieren.

7. Wählen Sie im Dropdown-Menü **Typ der Folgeaufgabe** den gewünschten Typ aus.

8. Geben Sie im Feld **Startdatum** die Anzahl der Tage nach Projektstart an.

9. Definieren Sie die **Dauer** im Format *0h00m*.

10. Fügen Sie im Feld **Standardtext in Folgeaufgabe** eine Beschreibung hinzu.

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

## <a id="add-doc-status"></a>Dokument für einen Status hinzufügen

1. Wählen Sie den gewünschten Projekttyp und Status aus.
2. Klicken Sie unter **Vorgeschlagene Dokumente in Status** auf **Hinzufügen**.
3. Geben Sie im Dialogfeld **Vorgeschlagenes Dokument** einen Namen ein. Es sollte sich dabei um eine aussagekräftige Bezeichnung des Dokuments handeln.
4. Geben Sie im Feld **Zweck dieses Dokuments** eine Beschreibung ein. Dieser Text wird angezeigt, wenn Sie den Mauszeiger auf der Bereichsregisterkarte **Projektleitfaden** in SuperOffice CRM auf das Dokument bewegen.
5. Wählen Sie die erforderliche [Vorlage][4] aus.
6. Geben Sie im Feld **Standardbetreff** den Betreff des Dokuments ein.
7. Falls erforderlich, geben Sie ein Zeichen im Feld **Unser Zeichen** ein (z. B. eine [Vorlagenvariable][1] für Projektnummer oder -titel).
8. Klicken Sie auf **Speichern**.
9. Wiederholen Sie diesen Vorgang, wenn Sie weitere Dokumente zu diesem oder zu anderen Status hinzufügen möchten.

### Beispiel für ein Dokument

**Projekttyp**: Konferenz
**Status**: Geplant
**Name** des Dokuments: Konferenzprogramm
**Zweck dieses Projektstatus**: Festlegen eines Konferenzprogramms
**Vorlage**: Notiz
**Standardbetreff**: Konferenzprogramm

## Verwandte Inhalte

* [Projektleitfaden bearbeiten oder deaktivieren][5]

<!-- Referenced links -->
[1]: ../../document/templates/variables/from-project-card.md
[2]: project-status.md
[3]: project-type.md
[4]: ../../document/templates/learn/index.md
[5]: edit-project-guide.md

<!-- Referenced images -->
[img2]: ../../../media/loc/de/project/create-project-guide.png
