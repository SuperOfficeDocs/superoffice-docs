---
uid: help-de-deleting-role
title: Rolle löschen
description: Rolle löschen
author: Bergfrid Dias
date: 03.15.2023
keywords: Benutzerverwaltung, Rolle
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Rolle löschen

[!include[Requirement](../includes/note-anon-req.md)]

Wenn Sie eine Rolle löschen, müssen Sie die Benutzer mit dieser Rolle in eine andere Rolle verschieben. Stellen Sie daher sicher, dass die Benutzer den entsprechenden Zugriff in der Rolle, in die sie verschoben werden, besitzen.

## Schritte

1. [!include[Open Roles](includes/open-roles.md)]

2. Wählen Sie die Registerkarte **Mitarbeiter** oder **Extern**.

    > [!NOTE]
    > Sie können die Rolle für anonyme Benutzer nicht löschen.

3. Wählen Sie die gewünschte Rolle in der Liste **Rollen**.

4. Klicken Sie auf **Löschen**.

    Ist die Schaltfläche Löschen deaktiviert (ausgegraut)? Die Rolle, zu der Sie selbst gehören, oder die Systembenutzerrolle (**Benutzerebene 0**) kann nicht gelöscht werden. Wenn nur noch eine einzige Rolle vorhanden ist, können Sie diese nicht löschen.

5. Klicken Sie im Dialogfeld **Rolle löschen** auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem Feld **Alle Benutzer mit dieser Rolle zuweisen zu** und wählen Sie eine andere Rolle für die Benutzer der zu löschenden Rolle aus.

6. Klicken Sie auf **Löschen**. Die Rolle wird aus der Liste entfernt. Eine gelöschte Rolle kann nicht wiederhergestellt werden.
