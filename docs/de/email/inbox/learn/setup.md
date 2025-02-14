---
uid: help-de-email-inbox-setup
title: SuperOffice Posteingang einrichten
description: "Der SuperOffice Posteingang ist eine alternative Möglichkeit, Ihre E-Mails mit Ihrem SuperOffice CRM für E-Mail-Clients zu verbinden, die nicht über WebTools verbunden werden können. Lernen Sie, wie Sie ihn einrichten und zum ersten Mal einloggen."
author: SuperOffice RnD
date: 02.14.2023
keywords: E-Mail, E-Mail
topic: howto
language: de
---

# SuperOffice Posteingang einrichten

Der SuperOffice Posteingang ist eine alternative Möglichkeit, Ihre E-Mails mit Ihrem SuperOffice CRM für E-Mail-Clients zu verbinden, die nicht über WebTools verbunden werden können.

## Bevor Sie beginnen

* Stellen Sie sicher, dass IMAP in Ihrem E-Mail-Client aktiviert ist. SuperOffice Inbox unterstützt die meisten IMAP-E-Mail-Server.

* Um E-Mails von SuperOffice CRM versenden zu können, müssen Sie sicherstellen, dass die für den SuperOffice Posteingang verwendete die E-Mail-Adresse mit der ersten E-Mail-Adresse übereinstimmt, die auf Ihrer Personenkarte/Anzeige erfasst wurde.

![Sie können überprüfen, welche E-Mail-Adresse Sie auf Ihrer Personenkarte erfasst wurde -screenshot][img2]

## E-Mail-Konto einrichten

Um auf E-Mails zugreifen zu können, müssen Sie zunächst Details über Ihr E-Mail-Konto angeben.

Sehen Sie sich dieses Video an, um zu sehen, wie schnell und einfach Sie Ihren SuperOffice-Posteingang einrichten können, oder führen Sie die folgenden Schritte aus (Videolänge -1:34):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/QoAanZgQs5A]

### Schritte

1. Klicken Sie auf das Symbol Posteingang im Navigator-Menü. Wenn Sie die E-Mail-Funktion zum ersten Mal aufrufen, wird die Ansicht **E-Mail-Konto einrichten** angezeigt.

1. Geben Sie im Feld **E-Mail-Konto** die E-Mail-Adresse des Kontos ein, das in SuperOffice verwendet werden soll.

    ![x -screenshot][img3]

1. Um Informationen über ein- und ausgehende E-Mails einzugeben, müssen Sie auf **Erweiterte Einstellungen** klicken. Andernfalls klicken Sie auf **Weiter**. SuperOffice versucht dann, diese Informationen für Sie zu konfigurieren.

1. Geben Sie im Feld **Passwort** Ihr Passwort ein.

1. Klicken Sie auf **Anmelden**.

    * Wenn SuperOffice den E-Mail-Anbieter (wie Gmail) erkennt, werden die Servereinstellungen automatisch konfiguriert und der Posteingang geladen.
    * Wenn die Details oder die von Ihnen eingegebene E-Mail-Adresse und das Passwort nicht korrekt sind, wird das Dialogfeld **Erweiterte Einstellungen** geöffnet. Überprüfen und geben Sie manuell die Konfigurationsinformationen für ein- und ausgehende Server ein.

## Wie man Serverinformationen manuell hinzufügt

### Einstellungen für eingehende E-Mails

Um Ihre E-Mails in SuperOffice CRM importieren zu lassen, müssen Sie die Details Ihres IMAP-Servers eingeben, die Sie in den Einstellungen Ihres E-Mail-Clients finden.

* Benutzername: Ihre vollständige E-Mail-Adresse
* Passwort: Passwort für Ihr E-Mail-Konto
* SSL: Ein/Aus - hängt von den Einstellungen Ihres E-Mail-Anbieters ab (siehe Einstellungen für Outlook und Gmail)

### Einstellungen für ausgehende E-Mails

Geben Sie die Details Ihres SMTP-Servers ein, um E-Mails von SuperOffice CRM zu senden.

* Benutzername: Ihre vollständige E-Mail-Adresse
* Passwort: Passwort für Ihr E-Mail-Konto
* SSL: hängt von den Einstellungen Ihres E-Mail-Anbieters ab (siehe Einstellungen für Outlook und Gmail)

![Erweiterte Einstellungen - Gehen Sie zum Posteingang, um manuell die korrekten E-Mail-Serverinformationen hinzuzufügen -screenshot][img4]

## E-Mail-Konfiguration im SuperOffice Posteingang ändern

1. Wenn Sie Ihr verknüpftes E-Mail-Konto bearbeiten oder entfernen möchten, klicken Sie auf Ihr Profilsymbol in der oberen rechten Ecke und wählen Sie **E-Mail-Optionen** aus.

    ![E-Mail-Optionen -screenshot][img5]

1. Wählen Sie die Registerkarte **E-Mail-Konto**aus und klicken Sie auf die Schaltfläche **Bearbeiten/Entfernen**.

    ![E-Mail-Optionen -screenshot][img6]

## Warum wird die E-Mail-Liste nicht aktualisiert?

Manche E-Mail-Anbieter wie Gmail blockieren Anmeldeversuche von unbekannten Apps. Überprüfen Sie in Ihrem Posteingang, um zu sehen, ob Ihr E-Mail-Anbieter Informationen über einen nicht autorisierten Anmeldeversuch gesendet hat. Befolgen Sie die Anweisungen in der E-Mail, um SuperOffice Zugriff auf Ihr Konto zu gewähren.

> [!TIP]
> Um auf die E-Mail-Optionen zuzugreifen, müssen Sie auf <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **E-Mail-Optionen** gehen.

<!-- Referenced links -->

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/email/getstarted-contact-mycontactcard.png
[img3]: ../../../../media/loc/en/email/getstarted-inbox-login.png
[img4]: ../../../../media/loc/en/email/so-inbox-advanced-settings.png
[img5]: ../../../../media/loc/en/email/email-options-general.png
[img6]: ../../../../media/loc/en/email/email-options-account.png
