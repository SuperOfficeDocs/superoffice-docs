---
uid: help-de-email-inbox-setup
title: SuperOffice Posteingang einrichten
description: Erfahren Sie, wie Sie den SuperOffice Posteingang einrichten und sich anmelden. Diese Funktion ist eine Alternative zu WebTools, um Ihr E-Mail-Konto mit SuperOffice CRM zu verbinden.
keywords: SuperOffice Posteingang, Posteingang einrichten, E-Mail-Konfiguration, IMAP, E-Mail-Verbindung
author: Bergfrid Dias
date: 05.28.2025
version: 10.5
content_type: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# SuperOffice Posteingang einrichten

Der SuperOffice Posteingang ist eine alternative Methode, um Ihr E-Mail-Konto mit SuperOffice CRM zu verbinden. Diese Funktion wurde für Benutzer entwickelt, die [WebTools][9] nicht verwenden können. Unterstützt werden ausschließlich IMAP-Konten.

> [!NOTE]
> Der SuperOffice Posteingang unterstützt nur **ein** E-Mail-Konto pro Benutzer. Wenn WebTools installiert und mit Ihrem E-Mail-Konto verbunden ist, steht die Posteingangsfunktion nicht zur Verfügung.

## Vorbereitungen

* Stellen Sie sicher, dass **SuperOffice CRM** in den **lokalen Einstellungen** als [bevorzugter E-Mail-Client][8] ausgewählt ist.

* Vergewissern Sie sich, dass **IMAP in Ihrem E-Mail-Client aktiviert** ist.

* Die **E-Mail-Adresse**, die Sie verwenden möchten, muss mit der primären E-Mail-Adresse auf Ihrer [Personenkarte][1] in SuperOffice übereinstimmen.

## E-Mail-Konto verbinden

1. Klicken Sie im Navigator auf <i class="ph ph-at" aria-hidden="true"></i> **Posteingang**.

    Beim ersten Öffnen erscheint der Dialog **E-Mail-Konto einrichten**.

    ![Dialog E-Mail-Konto einrichten mit E-Mail-Feld und Weiter-Schaltfläche -screenshot][img1]

1. Geben Sie im Feld **E-Mail-Konto** die gewünschte E-Mail-Adresse ein.

1. Klicken Sie auf **Weiter**.

    * SuperOffice erkennt Ihren E-Mail-Anbieter und leitet Sie zur Anmeldung weiter.
    * Falls Ihr Passwort beim Anbieter gespeichert ist, wird die Authentifizierung automatisch abgeschlossen.
    * Andernfalls werden Sie zur Eingabe Ihres Passworts beim Anbieter (z. B. Microsoft oder Google) aufgefordert.
    * Nach erfolgreicher Anmeldung kehren Sie zu SuperOffice zurück und der Posteingang wird geöffnet.

1. Schlägt die Anmeldung fehl oder kann der Anbieter nicht erkannt werden, erscheint der Dialog **Erweiterte Einstellungen**, in dem Sie die Serverdaten manuell eingeben können.

## Erweiterte Einstellungen konfigurieren

Wenn die automatische Einrichtung fehlschlägt, müssen Sie die Serverinformationen manuell eintragen. Alle Felder sind erforderlich, um den E-Mail-Verkehr über den SuperOffice Posteingang sicherzustellen.

1. Geben Sie die Einstellungen für eingehende E-Mails ein:

    * **Server für eingehende E-Mails:** Adresse Ihres IMAP-Servers
    * **Benutzername:** In der Regel Ihre vollständige E-Mail-Adresse
    * **Passwort:** Passwort Ihres E-Mail-Kontos
    * **SSL:** Ein oder Aus, abhängig vom Anbieter

1. Geben Sie die Einstellungen für ausgehende E-Mails ein:

    * **Server für ausgehende E-Mails:** Adresse Ihres SMTP-Servers
    * **Benutzername**, **Passwort** und **SSL**: analog zu den eingehenden Einstellungen

1. Klicken Sie auf **Speichern**, um das Konto zu verbinden.

![Erweiterte Einstellungen für E-Mail-Konto -screenshot][img4]

## E-Mail-Konto trennen oder ändern

Sie können Ihr aktuelles E-Mail-Konto trennen und bei Bedarf ein neues Konto verbinden.

1. Klicken Sie in der oberen Leiste auf <i class="ph ph-user-circle" aria-label="Persönliche Einstellungen"></i> und wählen Sie **E-Mail-Optionen**.

1. Wechseln Sie zur Registerkarte **E-Mail-Konto**.

    ![Registerkarte E-Mail-Konto mit Schaltfläche Bearbeiten/Entfernen -screenshot][img6]

1. Klicken Sie auf **Bearbeiten/Entfernen**, um das Konto zu trennen.

    * Dadurch wird der gleiche Dialog wie bei der ersten Einrichtung geöffnet.
    * Zum Entfernen schließen Sie einfach den Dialog.
    * Um erneut zu verbinden, geben Sie eine neue E-Mail-Adresse ein und folgen den Einrichtungsschritten.

> [!NOTE]
> Das Entfernen eines E-Mail-Kontos löscht **nicht** Ihr tatsächliches Konto (z. B. bei Gmail oder Outlook), sondern nur die Verbindung zu SuperOffice.

## Tipps zur Fehlerbehebung

* Der SuperOffice Posteingang unterstützt **keine POP3-Konten**. Nur IMAP wird unterstützt.

* Wenn der Posteingang nicht aktualisiert wird, blockiert Ihr Anbieter möglicherweise die Verbindung.
  * Überprüfen Sie Ihr E-Mail-Konto auf Benachrichtigungen zu blockierten oder nicht autorisierten Anmeldeversuchen.
  * Befolgen Sie die Anweisungen, um SuperOffice Zugriff zu gewähren.

* **Gmail-Nutzer:** Ab Januar 2025 ist IMAP dauerhaft aktiviert. Falls ein Passwort abgefragt wird, verwenden Sie ein **App-Passwort** anstelle Ihres regulären Gmail-Passworts.

> [!TIP]
> Um Layout, Schriftart oder Verhalten von Nachrichten anzupassen, gehen Sie zu <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **E-Mail-Optionen** > Registerkarte **Allgemein**.

## Verwandte Inhalte

* [IMAP für Office 365 aktivieren][11] – FAQ
* [Google-App-Passwort für 2-Faktor-Anmeldung generieren][12] – FAQ
* [Standard-E-Mail-Client in SuperOffice ändern][8]

<!-- Referenced links -->
[1]: ../../../contact/learn/index.md
[8]: ../../learn/change-default-mail-client.md
[9]: https://docs.superoffice.com/integrations/webtools/index.html
[11]: https://learn.microsoft.com/en-au/exchange/troubleshoot/user-and-shared-mailboxes/pop3-imap-owa-activesync-office-365
[12]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-generate-a-googleapp-password-to-use-2-step-verification-with-superoffice-inbox/

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/inbox-setup-dialog.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
