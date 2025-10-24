---
uid: help-de-role-edit
title: Rolle aktualisieren
description: Wie man eine Rolle bearbeitet.
keywords: Rolle, Benutzerverwaltung
author: digitaldiina
date: 10.24.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: 
  - /de/admin/user-management/learn/role/editing-role
  - /de/admin/user-management/learn/role/deleting-role
language: de
---

# Rolle aktualisieren

[!include[Requirement](../includes/note-anon-req.md)]

Um eine [Rolle][3] zu bearbeiten oder zu löschen, wählen Sie die Rolle zuerst auf der Registerkarte **Mitarbeiter** oder **Externe** aus.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Wählen Sie die Registerkarte **Mitarbeiter** oder **Extern**.

    [Wie man die Rolle für anonyme Benutzer bearbeitet.][1]

1. Doppelklicken Sie in der Liste auf die Rolle, die Sie bearbeiten möchten.

## Rolle bearbeiten

1. Ändern Sie im Dialogfeld **Neue Rolle erstellen** gegebenenfalls den Namen und die Beschreibung und klicken Sie anschließend auf **Speichern**.

1. [Bearbeiten Sie die Rechte der Rolle.][4]

1. Beim Bearbeiten von Rollen für Mitarbeiter: Wechseln Sie zur Registerkarte **Funktionelle Rechte** und bearbeiten Sie die funktionellen Rechte der Rolle.

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Die Änderungen werden automatisch gespeichert.

## Rolle löschen

Wenn Sie eine Rolle löschen, müssen Sie die Benutzer mit dieser Rolle in eine andere Rolle verschieben. Stellen Sie daher sicher, dass die Benutzer den entsprechenden Zugriff in der Rolle, in die sie verschoben werden, besitzen.

> [!NOTE]
> Sie können die Rolle für anonyme Benutzer oder die Systembenutzerrolle (**Benutzerebene 0**) nicht löschen.
>
> **Eine gelöschte Rolle kann nicht wiederhergestellt werden.**

1. Mit die Rolle ausgewält, Klicken Sie auf **Löschen**.

    Ist die Schaltfläche Löschen deaktiviert (ausgegraut)? Die Rolle, zu der Sie selbst gehören kann nicht gelöscht werden. Wenn nur noch eine einzige Rolle vorhanden ist, können Sie diese nicht löschen.

1. Klicken Sie im Dialogfeld **Rolle löschen** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem Feld **Alle Benutzer mit dieser Rolle zuweisen zu** und wählen Sie eine andere Rolle für die Benutzer der zu löschenden Rolle aus.

1. Klicken Sie auf **Löschen**.

    * Die Rolle wird aus der Liste entfernt.

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[3]: index.md
[4]: set-data-rights-for-role.md
