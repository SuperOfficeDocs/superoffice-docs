---
uid: help-de-service-profile-common
title: Gemeinsame Profile
description: Gemeinsame Profile
author: SuperOffice RnD
date: 06.29.2022
keywords: Profil, Service
content_type: howto
language: de
---

# Gemeinsame Profile

[!include[Legacy](../includes/legacy-profiles.md)]

Gemeinsame Profile werden mit einer [Rolle][2] verknüpft und gelten für alle Benutzer, die diese Rolle innehaben. Gemeinsame Profile werden in der Ansicht **Profile anzeigen** konfiguriert.

## Profiltypen

* **System**: Diese Profile werden wie im Folgenden erläutert konfiguriert.
* **Systemansichten**: Mit den [Systemdesignern][1] in SuperOffice Service wird eine List von Ansichten erstellt. Diese Ansichten können Sie ändern, wenn Sie Zugriff auf **Systemdesign** > **Ansichten** haben.

## <a id="create"></a>Gemeinsame Profile erstellen

Die folgenden Schritte zeigen zum Beispiel, wie Sie ein Feld in der Ansicht **Anfragen suchen** hinzufügen.

1. Wählen Sie **Systemeinstellungen** > **Profil** aus. Die Ansicht **Profile anzeigen** wird geöffnet.
2. Wählen Sie **System**. Daraufhin wird eine hierarchische Liste aller Profile im System angezeigt.
3. Klicken Sie auf **Suchen**.
4. Zeigen Sie auf **Anfragen suchen** und klicken Sie auf <i class="ph ph-list" aria-label="Main menu"></i> (**Neues gemeinsames Profil**) rechts neben dem Namen. Die Ansicht **Elementprofil bearbeiten** wird angezeigt.
5. Geben Sie im Feld **Name** den Namen für das Profil ein.
6. Klicken Sie auf die Schaltfläche **Kriterien hinzufügen**.
7. Gehen Sie im Dialogfeld wie folgt vor:
    * **Geben Sie hier die Bezeichnung für das Feld ein**: Geben Sie den Feldnamen ein.
    * **Feld auswählen**: Wählen Sie die Felder in der Datenbank, aus denen Daten abgerufen werden sollen.
8. Klicken Sie auf **OK**. Das neue Kriterium wird unter den anderen Kriterien hinzugefügt.
9. Klicken Sie auf **OK**. Das neue Profil wird erstellt. Sie können es nun zum Beispiel [mit einer bestimmten Rolle verknüpfen][3].

## Informationen in einem gemeinsamen Profil bearbeiten

1. Wählen Sie **Systemeinstellungen** > **Profil** aus. Die Ansicht **Profile anzeigen** wird geöffnet.
2. Wählen Sie **System**. Daraufhin wird eine hierarchische Liste aller Profile im System angezeigt.
3. Öffnen Sie die Hierarchieebenen, bis Sie das gewünschte Profil gefunden haben.
4. Klicken Sie auf den Profilnamen. Die Ansicht **Elementprofil bearbeiten** wird angezeigt.
5. Nehmen Sie die erforderlichen Änderungen vor.
6. Klicken Sie auf **OK**. Die Änderungen werden gespeichert.

## Gemeinsames Profil löschen

1. Wählen Sie **Systemeinstellungen** > **Profil** aus. Die Ansicht **Profile anzeigen** wird geöffnet.
2. Wählen Sie **System**. Daraufhin wird eine hierarchische Liste aller Profile im System angezeigt.
3. Öffnen Sie die Hierarchieebenen, bis Sie das gewünschte Profil gefunden haben.
4. Klicken Sie auf den Profilnamen. Die Ansicht **Elementprofil bearbeiten** wird angezeigt.
5. Klicken Sie auf die Schaltfläche **Standard wiederherstellen (löscht dieses Profil)** im unteren Teil der Ansicht. Das Profil wird gelöscht.

## Worüber würden Sie gern mehr erfahren?

* [Persönliche Profile][4]
* [Allgemeine Profile][5]

<!-- Referenced links -->
[1]: ../screen-properties.md
[2]: ../../../../admin/user-management/role/index.md
[3]: ../../../../admin/user-management/role/create-role.md
[4]: personal.md
[5]: global.md
