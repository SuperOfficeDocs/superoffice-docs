---
uid: help-de-user-add
title: Benutzer hinzufügen
description: In dieser Anleitung lernen Sie, wie Sie einen neuen Benutzer zu SuperOffice CRM hinzufügen.
keywords: Benutzer hinzufügen, Mitarbeiter
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
tier: starter
redirect_from: /de/admin/user-management/learn/add-associate
language: de
---

# Benutzer hinzufügen

Nachdem Ihre SuperOffice CRM-Lösung konfiguriert und personalisiert wurde, können Sie Ihren Benutzern Zugriff gewähren. Diese Anleitung beschreibt, wie Sie einen Benutzer nach dem anderen hinzufügen.

Administratoren sind dafür verantwortlich, jedem neuen Benutzer einen Benutzernamen, ein Passwort und eine Primärgruppe zuzuweisen. In **SuperOffice CRM Online** umfasst dies auch die Auswahl eines Benutzerplans. In **SuperOffice CRM Suite**-Abonnements gilt der Firmenplan für alle Benutzer — aktivieren Sie einfach die Option **Anmelden möglich**, um Zugriff zu gewähren.

> [!NOTE]
> Wenn Sie bei der Bestellung von SuperOffice CRM Benutzerinformationen angegeben haben, befinden sich diese Benutzer möglicherweise bereits im System und haben ihre Zugangsdaten per E-Mail erhalten. Überprüfen Sie die Ansicht **Benutzer**, bevor Sie jemanden manuell hinzufügen.

## Schritte

1. Öffnen Sie die Ansicht Benutzer.
1. Wählen Sie die Registerkarte **Mitarbeiter** aus.
1. Klicken Sie unter der Liste auf die Schaltfläche **Hinzufügen**.
1. Geben Sie den Namen und die E-Mail-Adresse des neuen Benutzers im oberen Bereich der Karte ein.
1. Wenn in Ihrem SuperOffice-Tenant mehr als eine Eigentümerfirma verfügbar ist, können Sie die Eigentümerfirma unter dem Feld **E-Mail** auswählen.
1. Geben Sie die relevanten Informationen in den Registerkarten **Details** und **Lizenzen** ein.

    ![Create user details -screenshot][img7]

1. Klicken Sie auf **Speichern**. Der Name des neuen Benutzers wird in der Liste angezeigt.

    * **SuperOffice CRM Online:** Wenn aktive Benutzer einen anderen Benutzerplan benötigen, können Sie in Einstellungen und Verwaltung [Benutzerpläne zuordnen][4].
    * **SuperOffice CRM Suite:** Verwalten Sie den Benutzerzugriff, indem Sie die Option **Anmelden möglich** aktivieren oder deaktivieren. Der Firmenplan bestimmt, auf welche Funktionen alle Benutzer zugreifen können. Weitere Informationen finden Sie unter [CRM Suite-Plänen][5].

## <a id="fields"></a>Erklärung wichtiger Felder

<!-- markdownlint-disable-file MD051 -->
### [Registerkarte Details](#tab/details)

Auf der Registerkarte **Details** stehen folgende Optionen zur Verfügung:

* **Benutzer-ID:** Bearbeiten Sie im Feld **Benutzer-ID** die vorgeschlagene ID für den Benutzer (falls Sie die automatisch generierte ID nicht verwenden wollen). Sie dürfen keine Benutzer-ID festlegen, die bereits in der Datenbank vorhanden ist. Bezüglich der Zeichen, die in der Benutzer-ID verwendet werden dürfen, bestehen keine Einschränkungen.

    > [!NOTE]
    > Die Benutzer-ID wird in SuperOffice CRM in den ID-Spalten angezeigt, weil der Platz in diesen Spalten begrenzt sein kann und die Benutzer-ID nicht zu lang sein sollte.

* **Nickname:** Der Nickname ist der für andere Benutzer von SuperOffice sichtbare Name und wird nur für Benutzer von SuperOffice Service verwendet. Sie können den vorgeschlagenen Spitznamen für den Benutzer bearbeiten (falls Sie den automatisch generierten Namen nicht verwenden wollen).

* **Authentifizierung:** Wenn mehrere Authentifizierungsmethoden verfügbar sind, können Sie hier eine Authentifizierungsmethode auswählen.

* **Benutzername:** Geben Sie den SuperOffice-Benutzernamen ein. Dies sollte derselbe Name wie im System Ihres Identitätsanbieters sein (wenn Sie Office 365 oder Gmail für die Authentifizierung verwenden). Wenn Sie SuperOffice für die Authentifizierung verwenden, geben Sie einfach Ihre E-Mail-Adresse ein. Stellen Sie sicher, dass die E-Mail-Adresse gültig ist, weil sie zur Kontobestätigung verwendet wird.

* **Rolle:** Legen Sie im Listenfeld **Rolle** die [Rolle][3] für den Benutzer fest. Die Rolle bestimmt den Datenzugriff des Benutzers und die Rechte für die Funktionen. Sie können Ihre eigene Rolle nicht ändern.

* **Benutzerplan:** Wählen Sie den relevanten Benutzerplan für den Benutzer aus. Damit wird festgelegt, auf welche SuperOffice-Funktionen der Benutzer zugreifen kann. (Nur SuperOffice CRM Online. In SuperOffice CRM Suite-Abonnements gilt der Firmenplan für alle Benutzer.)

* **Ausgeschiedener Mitarbeiter:** Wenn ein Benutzer keinen Zugriff mehr auf SuperOffice haben soll, wählen Sie diese Option aus, um den Benutzerplan und die Login-Rechte des Benutzers zu löschen.

* **Primärgruppe:** Wählen Sie im Listenfeld **Primärgruppe** eine der vordefinierten Optionen für eine Gruppenzugehörigkeit aus. Diese Optionen werden in der Ansicht **Listen** festgelegt. Der Benutzer erhält Zugriff auf Daten, die anderen Benutzern derselben Primärgruppe gehören. Zugriffsrechte für diese Daten (zum Beispiel zum Schreiben und Löschen) sind in der [Rolle][3] definiert, zu der der Benutzer gehört. Für weitere Informationen siehe auch [Sichtbarkeit][2] zum Teilen von Daten mit Ihrer Primärgruppe.

* **Weitere Gruppen:** Klicken Sie in das Feld **Weitere Gruppen** und wählen Sie aus, zu welchen anderen Gruppen der Benutzer gehören soll. Wenn die Liste viele Gruppen enthält, geben Sie zunächst einen Gruppennamen in das Suchfeld ein, um die Liste zu filtern.

* **SuperOffice Service-Kategorien:** Mit diesen Kategorien erhalten Benutzer Zugriff auf bestimmte Anfragekategorien.

* **Service-Kategorien aus Benutzergruppen:** Die Kategorien werden angezeigt, die der Benutzer von einer Benutzergruppe bekommt.

#### Beispiel

Peter Weber arbeitet in der Vertriebsabteilung einer großen Firma. Die Primärgruppe ist auf "Verkäufe" festgelegt, sodass Peter Weber Zugriffsrechte für Daten hat, die von Benutzern der Vertriebsabteilung erstellt wurden. Die Zugriffsrechte für die Primärgruppe sind in der Rolle definiert, zu der Peter Weber gehört. Diese Rolle bestimmt, ob Peter Weber Daten, die von anderen Benutzern in der Vertriebsabteilung erstellt wurden, bearbeiten oder löschen kann (siehe [Datenrechte für eine Rolle festlegen][8]).

Peter Weber muss außerdem über beschränkte Rechte für Dokumente von der Marketing- und der Entwicklungsabteilung verfügen. Diese beiden Abteilungen werden unter **Weitere Gruppen** hinzugefügt. In der Rolle, zu der Peter Weber gehört, ist festgelegt, dass Peter Weber nur Lesezugriff auf diese Daten besitzt.

### [Die Registerkarte Lizenzen](#tab/license)

In der Registerkarte **Lizenzen** können Sie zusätzliche Lizenzen auswählen.

**Vertrauliche Aktivitäten:** aktiviert die Liste **Sichtbar für** Folgeaufgaben, Dokumente und Verkäufe, damit sichtbare Einträge nur für den Benutzer, die Primärgruppe des Benutzers oder für alle sichtbar gemacht werden.

***

## Video: Neuen SuperOffice CRM-Benutzer hinzufügen

Sehen Sie sich diese Demo an, um zu sehen, wie Sie einen neuen Benutzer in SuperOffice CRM hinzufügen können.
(Dieses Video zeigt eine frühere Version von SuperOffice, daher kann das Design anders aussehen. Die Schritte sind dieselben.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(Videolänge - 1:46)

## Fehlerbehebung

### Ein neu erstellter Benutzer kann sich nicht bei SuperOffice anmelden

Es gibt zwei häufige Situationen, in denen sich ein neuer Benutzer nicht anmelden kann:

* Der Benutzername ist keine E-Mail-Adresse, oder die E-Mail-Adresse ist ungültig
* Das Konto des neuen Benutzers ist nicht aktiviert

1. [!include[Benutzer öffnen](includes/goto-users.md)]

1. Wählen Sie in der Benutzerliste den Benutzer aus, der sich nicht anmelden kann.

1. Stellen Sie sicher, dass der Benutzer eine gültige E-Mail-Adresse eingetragen hat, da die Aktivierungs-E-Mail an diese Adresse gesendet wird.

    ![E-Mail-Adresse des Benutzers überprüfen -screenshot][img2]

1. Stellen Sie sicher, dass der Benutzer die Aktivierungs-E-Mail erhalten hat und dass der Aktivierungslink innerhalb von 48 Stunden angeklickt wurde.

    ![Aktivierungs-E-Mail -screenshot][img3]

    Um die Willkommens-E-Mail erneut zu senden, gehen Sie zu **Einstellungen und Verwaltung** > **Benutzer**, wählen Sie Ihren Benutzer aus, klicken Sie auf die Schaltfläche **Aufgabe** und wählen Sie **Willkommens-E-Mail senden**.

1. Stellen Sie sicher, dass der Benutzer die [Anleitung zur Anmeldung bei SuperOffice CRM][7] befolgt hat.

## Verwandte Inhalte

* [Benutzer/Mitarbeiter bearbeiten][6]
* [Onsite-Benutzerverwaltung][10]

<!-- Referenced links -->

[2]: index.md#visible
[3]: role/index.md
[4]: ../license/user-plans.md#change
[5]: ../license/crm-suite.md
[6]: update-user.md
[7]: ../../learn/getting-started/login.md
[8]: role/set-data-rights-for-role.md
[10]: https://help.superoffice.com/docs/11/de/admin/user-management/add-associate.html

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/filled-in-email.png
[img3]: ../../../media/loc/en/admin/activation-email.png
[img7]: ../../../media/loc/en/admin/selected-user-plan.png
