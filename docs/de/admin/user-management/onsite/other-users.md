---
uid: help-de-user-other
title: Andere Benutzer verwalten
description: Anonyme und Systembenutzer verwalten (Vor Ort)
keywords: anonyme Benutzer, Systembenutzer, Andere Benutzer
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
deployment: onsite
platform: web
index: true
redirect_from: 
  - /de/admin/user-management/learn/other-users
  - /de/admin/user-management/learn/role/edit-rights-for-anonymous-users
language: de
---

# Anonyme und Systembenutzer verwalten (Vor Ort)

* **Systembenutzer**: Systembenutzer können sich über Anwendungen von Drittanbietern beim System anmelden und verfügen über alle Rechte.
* **Anonym**: Anonyme Benutzer verfügen über Rechte gemäß der [Rolle für anonyme Benutzer](#rights). Es ist in der Regel nicht erforderlich, mehr als einen anonymen Benutzer einzurichten.

> [!NOTE]
> Anonyme und externe Benutzer benötigen die [SuperOffice Expander Services-Systemlizenz][1] und kann auf der Registerkarte **Andere Benutzer** verwaltet werden.
>
> 1. Wählen Sie im Navigator <i class="ph ph-user" aria-hidden="true"></i> **Benutzer** aus.
> 1. Wählen Sie die Registerkarte **Andere Benutzer**. Es wird eine Liste mit vorhandenen anonymen Benutzern und Systembenutzern angezeigt.

## Anonyme oder Systembenutzer hinzufügen

1. Klicken Sie unter der Liste auf **Hinzu**.

1. Geben Sie eine ID in das Feld **Benutzer-ID** ein.

1. Geben Sie im Feld **Passwort**, falls erforderlich, ein Passwort für den Benutzer ein.

1. Geben Sie gegebenenfalls eine Beschreibung für den Benutzer in das Feld **Beschreibung** ein.

1. Wählen Sie den **Typ** aus: **Systembenutzer** oder **Anonym**

1. Wählen Sie rechts neben **Login** die Option **Aktiv**, um den Benutzer zu aktivieren.

1. Klicken Sie auf **Speichern**. Der Benutzer wird nun zur Liste hinzugefügt.

## Anonymen oder Systembenutzer bearbeiten

1. Doppelklicken Sie in der Liste auf den Benutzer, den Sie bearbeiten möchten.

1. Nehmen Sie die erforderlichen Änderungen im angezeigten Dialogfeld vor.

1. Klicken Sie abschließend auf **Speichern**.

## <a id="rights"></a>Rechte für anonyme Benutzer bearbeiten

Für anonyme Benutzer ist nur eine Rolle vorhanden und für diese Rolle können nur die Datenrechte bearbeitet werden.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Wählen Sie die Registerkarte **Anonym** aus.

1. [Geben Sie die Datenrechte auf der Registerkarte **Datenrechte** ein][2].

Die Änderungen werden automatisch gespeichert.

## Login-Rechte für andere Benutzer ändern

Wenn sich ein anonymer Benutzer oder ein Systembenutzer nicht mehr beim System anmelden soll, können Sie die entsprechenden Login-Rechte entfernen. Der externe Benutzer wird nicht entfernt, sondern als inaktiv definiert und kann bei Bedarf jederzeit reaktiviert werden.

### Benutzer deaktivieren

1. Wählen Sie den aktiven Benutzer, dessen Login-Rechte Sie löschen möchten, in der Liste aus und klicken Sie unter der Liste auf **Login verweigern**.

    Der entsprechende Benutzer kann sich nun nicht mehr beim System anmelden.

### Benutzer aktivieren

1. Doppelklicken Sie in der Liste auf den Benutzer, den Sie aktivieren möchten.
1. Wählen Sie rechts neben **Login** die Option **Aktiv**, um den Benutzer zu aktivieren.
1. Klicken Sie auf **Speichern**. Der entsprechende Benutzer kann sich nun beim System anmelden.

## Anonymen oder Systembenutzer löschen

1. Wählen Sie den Benutzer, den Sie löschen möchten.
1. Klicken Sie auf die Schaltfläche **Löschen**. Der Benutzer wird von der Liste entfernt.

<!-- Referenced links -->
[1]: ../../license/expander-services.md
[2]: ../role/set-data-rights-for-role.md
