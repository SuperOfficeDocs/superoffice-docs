---
uid: help-de-user-add
title: Benutzer hinzufügen
description: "In dieser Anleitung lernen Sie, wie Sie einen neuen Benutzer zu SuperOffice CRM hinzufügen."
author: SuperOffice RnD
date: 02.21.2023
keywords: user, Mitarbeiter
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Benutzer hinzufügen

Nachdem Ihre SuperOffice CRM-Lösung konfiguriert und personalisiert wurde, können Sie Ihren Benutzern Zugriff auf ihre CRM-Lösung gewähren.

Administratoren sind dafür verantwortlich, neuen Benutzern einen Benutzerplan, einen Benutzernamen, ein Passwort zur Verfügung zu stellen und die Benutzergruppe mitzuteilen, zu welcher der Benutzer gehört. Sie können unter Einstellungen und Verwaltung Benutzer zu SuperOffice CRM hinzufügen.

> [!NOTE]
> Wenn Sie bei der Bestellung von SuperOffice CRM Informationen über Benutzer angegeben haben, müssen Sie keine Benutzer hinzufügen. Die Benutzer haben die Zugangsdaten von SuperOffice per E-Mail erhalten. Überprüfen Sie im Menü Benutzer in Einstellungen und Verwaltung, ob sich Benutzer im System befinden.
>
> Im Folgenden wird beschrieben, wie Sie einen einzelnen Benutzer hinzufügen. Informationen zum Hinzufügen mehrerer Benutzer finden Sie unter [Benutzer importieren][1].

## Schritte

1. Öffnen Sie die Ansicht Benutzer.
2. Wählen Sie die Registerkarte **Mitarbeiter** aus.
3. Klicken Sie unter der Liste auf die Schaltfläche **Hinzufügen**.
4. Geben Sie den Namen und die E-Mail-Adresse des neuen Benutzers im oberen Bereich der Karte ein.
5. Wenn in Ihrer SuperOffice-Installation mehr als eine Firma des Eigentümers verfügbar ist, können Sie diese unter dem Feld **E-Mail** auswählen.
6. Geben Sie die relevanten Informationen in den Registerkarten **Details** und **Lizenzen** ein.

    ![Create user details -screenshot][img7]

7. Klicken Sie auf **Speichern**. Der Name des neuen Benutzers wird in der Liste angezeigt.

    * Wenn aktive Benutzer einen anderen Benutzerplan benötigen, können Sie in Einstellungen und Verwaltung [Benutzerpläne zuordnen][4].

    * Im unteren Bereich der Benutzerkarte können Sie die Login-Rechte des ausgewählten Benutzers aktivieren oder deaktivieren, indem Sie auf die Schaltfläche **Anmelden möglich** klicken. Standardmäßig wird diese Option aktiviert, wenn Sie einen Benutzerplan für den Benutzer auswählen.

## <a id="fields"></a>Erklärung wichtiger Felder

<!-- markdownlint-disable-file MD051 -->
### [Registerkarte Details](#tab/details)

Auf der Registerkarte **Details** stehen folgende Optionen zur Verfügung:

* **Benutzer-ID**: Bearbeiten Sie im Feld **Benutzer-ID** die vorgeschlagene ID für den Benutzer (falls Sie die automatisch generierte ID nicht verwenden wollen). Sie dürfen keine Benutzer-ID festlegen, die bereits in der Datenbank vorhanden ist. Bezüglich der Zeichen, die in der Benutzer-ID verwendet werden dürfen, bestehen keine Einschränkungen.

    > [!NOTE]
    > Die Benutzer-ID wird in SuperOffice CRM in den ID-Spalten angezeigt, weil der Platz in diesen Spalten begrenzt sein kann und die Benutzer-ID nicht zu lang sein sollte.

* **Nickname**: Der Nickname ist der für andere Benutzer von SuperOffice sichtbare Name und wird nur für Benutzer von SuperOffice Service verwendet. Sie können den vorgeschlagenen Spitznamen für den Benutzer bearbeiten (falls Sie den automatisch generierten Namen nicht verwenden wollen).

* **Authentifizierung**: Wenn mehrere Authentifizierungsmethoden verfügbar sind, können Sie hier eine Authentifizierungsmethode auswählen.

* **Benutzername**: Geben Sie den SuperOffice-Benutzernamen ein. Dies sollte derselbe Name wie im System Ihres Identitätsanbieters sein (wenn Sie Office 365 oder Gmail für die Authentifizierung verwenden). Wenn Sie SuperOffice für die Authentifizierung verwenden, geben Sie einfach Ihre E-Mail-Adresse ein. Stellen Sie sicher, dass die E-Mail-Adresse gültig ist, weil sie zur Kontobestätigung verwendet wird.

* **Rolle**: Legen Sie im Listenfeld **Rolle** die [Rolle][3] für den Benutzer fest. Die Rolle bestimmt den Datenzugriff des Benutzers und die Rechte für die Funktionen. Sie können Ihre eigene Rolle nicht ändern.

* **Benutzerplan**: Wählen Sie den relevanten Benutzerplan für den Benutzer aus. Damit wird festgelegt, auf welche SuperOffice-Funktionen der Benutzer zugreifen kann.

* **Ausgeschiedener Mitarbeiter**: Wenn ein Benutzer keinen Zugriff mehr auf SuperOffice haben soll, wählen Sie diese Option aus, um den Benutzerplan und die Login-Rechte des Benutzers zu löschen.

* **Primärgruppe**: Wählen Sie im Listenfeld **Primärgruppe** eine der vordefinierten Optionen für eine Gruppenzugehörigkeit aus. Diese Optionen werden in der Ansicht **Listen** festgelegt. Der Benutzer erhält Zugriff auf Daten, die anderen Benutzern derselben Primärgruppe gehören. Zugriffsrechte für diese Daten (zum Beispiel zum Schreiben und Löschen) sind in der [Rolle][3] definiert, zu der der Benutzer gehört. Für weitere Informationen siehe auch [Sichtbarkeit][2] zum Teilen von Daten mit Ihrer Primärgruppe.

* **Weitere Gruppen**: Klicken Sie in das Feld **Weitere Gruppen** und wählen Sie aus, zu welchen anderen Gruppen der Benutzer gehören soll. Wenn die Liste viele Gruppen enthält, geben Sie zunächst einen Gruppennamen in das Suchfeld ein, um die Liste zu filtern.

* **SuperOffice Service-Kategorien**: Mit diesen Kategorien erhalten Benutzer Zugriff auf bestimmte Anfragekategorien.

* **Service-Kategorien aus Benutzergruppen**: Die Kategorien werden angezeigt, die der Benutzer von einer Benutzergruppe bekommt.

#### Beispiel

[!include[Example](includes/example-grouping.md)]

### [Die Registerkarte Lizenzen](#tab/license)

In der Registerkarte **Lizenzen** können Sie neben den im ausgewählten Benutzerplan definierten Lizenzen weitere Lizenzen auswählen.

**Vertrauliche Aktivitäten**: aktiviert die Liste **Sichtbar für** Folgeaufgaben, Dokumente und Verkäufe, damit sichtbare Einträge nur für den Benutzer, die Primärgruppe des Benutzers oder für alle sichtbar gemacht werden.

***

## Video: Neuen SuperOffice CRM-Benutzer hinzufügen

Sehen Sie sich diese Demo an, um zu sehen, wie Sie einen neuen Benutzer in SuperOffice CRM hinzufügen können.
(Dieses Video zeigt eine frühere Version von SuperOffice, daher kann das Design anders aussehen. Die Schritte sind dieselben.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(Videolänge - 1:46)

## Verwandte Inhalte

* [Anonymen oder Systembenutzer hinzufügen (vor Ort)][5]
* [Benutzer/Mitarbeiter bearbeiten][6]

<!-- Referenced links -->
[1]: onsite/import-users.md
[2]: index.md#visible
[3]: role/index.md
[4]: ../../license/change-user-plan.md
[5]: onsite/other-users.md
[6]:  update-user.md

<!-- Referenced images -->
[img7]: ../../../../media/loc/en/admin/selected-user-plan.png
