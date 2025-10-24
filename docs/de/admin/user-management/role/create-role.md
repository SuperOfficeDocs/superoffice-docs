---
uid: help-de-role-create
title: Rolle erstellen
description: Rolle erstellen
keywords: Rolle, Benutzerverwaltung
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /de/admin/user-management/learn/role/create-role
language: de
---

# Rolle erstellen

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](../includes/open-roles.md)]

1. Wählen Sie eine der folgenden Registerkarten:

    * **Mitarbeiter**: Hier können Sie Rollen für Mitarbeiter Ihrer Firma hinzufügen.
    * **Extern**:  Hier können Sie Rollen für externe Benutzer (nur Vor Ort) hinzufügen.

    > [!NOTE]
    > Für anonyme Benutzer ist nur eine einzige Rolle vorhanden. Sie können keine neue Rolle erstellen. Siehe [Rechte für anonyme Benutzer bearbeiten][8].

1. Klicken Sie unter der Liste auf **Hinzufügen**.

1. Geben Sie im Dialogfeld **Neue Rolle erstellen** einen Namen für die Rolle im Feld **Rollenname** ein.

1. Geben Sie eine Beschreibung für die Rolle in das Feld **Beschreibung** ein.

1. Wählen Sie eine der folgenden Optionen:

    * Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben **Rechte kopieren aus** und wählen Sie die gewünschte Rolle als Basis für die neue Rolle aus.
    * Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie **Ohne Berechtigungen beginnen** aus, um die Rolle völlig neu zu erstellen.

1. Klicken Sie auf **Speichern**. Die neue Rolle wird in der Liste **Rollen** angezeigt.

1. Klicken Sie auf den Rollennamen in der Liste, um die Rechte für die Rolle auf der Registerkarte **Datenrechte** anzuzeigen.

1. [Geben Sie die Datenrechte auf der Registerkarte **Datenrechte** ein][7].

1. Beim Erstellen von Rollen für Mitarbeiter: Klicken Sie auf die Registerkarte **Funktionelle Rechte**.

    Auf dieser Registerkarte können Sie festlegen, welche Funktionen für die Rolle verfügbar sind, wie zum Beispiel Serienbrief erstellen, veröffentlichen, Selektionen exportieren und Administratorzugriff in Einstellungen und Verwaltung.

    > [!TIP]
    > Wenn Sie mit dem Mauszeiger auf ein Recht zeigen, werden weitere Informationen darüber angezeigt.

1. Legen Sie [die funktionellen Rechte][6] der Rolle fest:

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    Die Änderungen werden automatisch gespeichert.

## Verwandte Inhalte

* [Benutzer hinzufügen][5]
* [Rollen bearbeiten][4]

<!-- Referenced links -->
[4]: update-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
[8]: ../onsite/other-users.md#rights
