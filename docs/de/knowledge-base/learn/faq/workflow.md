---
uid: help-de-faq-workflow
title: Workflowstufen
description: Workflowstufen
keywords: FAQ
author: SuperOffice RnD
date: 07.15.2025
version: 10.5
content_type: howto
category: service
topic: faq
license: servicepremium
functional_right: knowledge-base
audience: person
audience_tooltip: SuperOffice Service
language: de
redirect_from: /de/faq/learn/workflow
---

# Workflowstufen

In einer neuen Installation enthält der Workflow zwei Standardstufen: **Unveröffentlicht** und **Veröffentlicht**. Es ist möglich, zwischen diesen zwei Stufen zusätzliche Stufen einzufügen. Sie können beispielsweise eine Stufe einrichten, in der ein FAQ-Eintrag zum Korrekturlesen versendet wird, damit der Eintrag überprüft und anschließend veröffentlicht bzw. unveröffentlicht zur Bearbeitung zurückgesendet wird.

## Neue Stufe erstellen

1. Gehen Sie zum <i class="ph ph-list" aria-label="Main menu"></i> in der oberen Leiste und wählen Sie **Wissensdatenbank** > **FAQ** aus.
1. Klicken Sie auf die Schaltfläche **Workflow**. Sie gelangen zur Ansicht **Workflow anzeigen**.
1. Klicken Sie auf die Schaltfläche **Neue Stufe**. Sie gelangen zur Ansicht **Neue Stufe**.
1. Geben Sie einen aussagekräftigen Namen für die Stufe in das Feld **Name** ein.
1. Wählen Sie in der Liste **Neue Stufe einfügen zwischen** aus, zwischen welchen zwei Stufen die neue Stufe eingefügt werden soll.
1. Klicken Sie auf **OK**. Sie gelangen zur Ansicht **Stufe bearbeiten**.
1. Wählen Sie in der Liste **Benutzer auswählen** im unteren Bereich der Ansicht aus, welcher Benutzer Zugriff auf diese Stufe im Workflow haben soll.
1. Wählen Sie die Zugriffsstufe für den Benutzer aus. Dabei können Sie zwischen folgenden Optionen wählen:
    * **Kann verschieben**: Dem Benutzer ist es gestattet, die Workflowstufe für Einträge zu ändern (Einträge zu veröffentlichen oder die Veröffentlichung abzubrechen).
    * **Kann bearbeiten**: Dem Benutzer ist es gestattet, FAQ-Einträge zu bearbeiten.
    * **Uneingeschränkter Zugriff**: Der Benutzer verfügt bezüglich des Workflows über alle Rechte.
1. Klicken Sie auf **+**, um den Benutzer der Liste unter **Benutzerzugriff** hinzuzufügen.
1. Wiederholen Sie die Schritte 7-9, um weitere Benutzer hinzuzufügen.
1. Klicken Sie auf **OK**. Die Stufe wird erstellt und ist nun bei der Veröffentlichung von FAQ-Einträgen verfügbar.

## Stufe bearbeiten

Sie können sowohl den Namen einer Stufe ändern als auch die Einstellung, welche Benutzer Zugriff darauf haben sollen.

1. Gehen Sie zum <i class="ph ph-list" aria-label="Main menu"></i> in der oberen Leiste und wählen Sie **Wissensdatenbank** > **FAQ** aus.
1. Klicken Sie auf die Schaltfläche **Workflow**.
1. Klicken Sie auf den Namen der Stufe. Sie gelangen zur Ansicht **Stufe bearbeiten**.
1. Bearbeiten Sie den Namen nach Bedarf.
1. Ändern Sie die Einstellung, welche Benutzer Zugriff auf die Stufe haben sollen:
    * Um Benutzer hinzuzufügen, befolgen Sie die oben aufgeführten Schritte.
    * Um Benutzer zu entfernen, wählen Sie die betreffenden Benutzer aus, klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe"></i> und wählen Sie **Zugriff für ausgewählte Benutzer entfernen** aus.
1. Klicken Sie auf **OK**. Die Änderungen werden gespeichert.

## Stufe löschen

1. Gehen Sie zum <i class="ph ph-list" aria-label="Main menu"></i> in der oberen Leiste und wählen Sie **Wissensdatenbank** > **FAQ** aus.
1. Klicken Sie auf der Schaltfläche **Workflow** (<i class="ph ph-gear" aria-hidden="true"></i>).
1. Klicken Sie auf den Namen der Stufe. Sie gelangen zur Ansicht **Stufe bearbeiten**.
1. Klicken Sie auf **Löschen**. Wenn diese Stufe keinem FAQ-Eintrag zugeordnet ist, wird sie sofort gelöscht.

   > [!NOTE]
   > Die Standardstufen **Unveröffentlicht** und **Veröffentlicht** können nicht gelöscht werden.

1. Wenn sie FAQ-Einträgen zugeordnet ist, müssen Sie auswählen, welcher Stufe im Workflow diese FAQ-Einträge stattdessen zugeordnet werden sollen. Wählen Sie die gewünschte Stufe in der Liste **Verschieben in Workflow** aus.
1. Klicken Sie auf **Löschen**. Die Stufe wird gelöscht und ihr zugeordneten FAQ-Einträge werden in die ausgewählte Stufe verschoben.

## Über Workflow veröffentlichen

1. [Öffnen Sie den FAQ-Eintrag][1].
1. Um vor der Veröffentlichung noch etwas zu ändern, müssen Sie die Schritte unter [FAQ-Einträge veröffentlichen][2] befolgen.
1. Klicken Sie auf die Schaltfläche **Weiter im Workflow**, bis die Stufe **Veröffentlicht** im Feld **Workflowstufe** auf der Registerkarte **Details** angezeigt wird.

   > [!TIP]
   > Sie können die Veröffentlichung von FAQ-Einträgen abbrechen, indem Sie auf die Schaltfläche **Zurück im Workflow** klicken.

<!-- Referenced links -->
[1]: index.md
[2]: publish.md
