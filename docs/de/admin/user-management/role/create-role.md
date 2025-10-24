---
uid: help-de-role-create
title: Rolle erstellen
description: Rolle erstellen
author: Bergfrid Dias
date: 03.15.2023
keywords: Rolle, Benutzerverwaltung
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Rolle erstellen

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](includes/open-roles.md)]

2. Wählen Sie eine der folgenden Registerkarten:

    * **Mitarbeiter**: Hier können Sie Rollen für Mitarbeiter Ihrer Firma hinzufügen.
    * **Extern**:  Hier können Sie Rollen für externe Benutzer (nur Vor Ort) hinzufügen.

    > [!NOTE]
    > Für anonyme Benutzer ist nur eine einzige Rolle vorhanden. Sie können keine neue Rolle erstellen. Siehe [Rechte für anonyme Benutzer bearbeiten][5].

3. Klicken Sie unter der Liste auf **Hinzufügen**.

4. Geben Sie im Dialogfeld **Neue Rolle erstellen** einen Namen für die Rolle im Feld **Rollenname** ein.

5. Geben Sie eine Beschreibung für die Rolle in das Feld **Beschreibung** ein.

6. Wählen Sie eine der folgenden Optionen:

    * Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben **Rechte kopieren aus** und wählen Sie die gewünschte Rolle als Basis für die neue Rolle aus.
    * Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> und wählen Sie **Ohne Berechtigungen beginnen** aus, um die Rolle völlig neu zu erstellen.

7. Klicken Sie auf **Speichern**. Die neue Rolle wird in der Liste **Rollen** angezeigt.

8. Klicken Sie auf den Rollennamen in der Liste, um die Rechte für die Rolle auf der Registerkarte **Datenrechte** anzuzeigen.

9. [Geben Sie die Datenrechte auf der Registerkarte **Datenrechte** ein][7].

10. Beim Erstellen von Rollen für Mitarbeiter: Klicken Sie auf die Registerkarte **Funktionelle Rechte**.

    Auf dieser Registerkarte können Sie festlegen, welche Funktionen für die Rolle verfügbar sind, wie zum Beispiel Serienbrief erstellen, veröffentlichen, Selektionen exportieren und Administratorzugriff in Einstellungen und Verwaltung.

    > [!TIP]
    > Wenn Sie mit dem Mauszeiger auf ein Recht zeigen, werden weitere Informationen darüber angezeigt.

11. Legen Sie [die funktionellen Rechte][6] der Rolle fest:

    [!include[How to set functional rights](includes/add-remove-right.md)]

    Die Änderungen werden automatisch gespeichert.

## Was möchten Sie jetzt tun?

* [Benutzer hinzufügen][5]
* [Rollen bearbeiten][4]

<!-- Referenced links -->
[4]: editing-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
